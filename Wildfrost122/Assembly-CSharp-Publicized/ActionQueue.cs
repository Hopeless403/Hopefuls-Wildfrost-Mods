// Decompiled with JetBrains decompiler
// Type: ActionQueue
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
public class ActionQueue : MonoBehaviourSingleton<ActionQueue>
{
  public readonly List<PlayAction> queue = new List<PlayAction>();
  [SerializeField]
  public int count;
  [SerializeField]
  public float delayBefore;
  [SerializeField]
  public float delayAfter;
  public static PlayAction current;
  public static readonly global::Routine.Clump parallelClump = new global::Routine.Clump();

  public static bool Empty => MonoBehaviourSingleton<ActionQueue>.instance.count <= 0;

  public static PlayAction Insert(int index, PlayAction action, bool fixedPosition = false)
  {
    if (fixedPosition)
      action.fixedPosition = true;
    int index1 = index;
    while (index1 < MonoBehaviourSingleton<ActionQueue>.instance.count && MonoBehaviourSingleton<ActionQueue>.instance.queue[index1].fixedPosition)
      ++index1;
    MonoBehaviourSingleton<ActionQueue>.instance.queue.Insert(index1, action);
    ++MonoBehaviourSingleton<ActionQueue>.instance.count;
    Events.InvokeActionQueued(action);
    return action;
  }

  public static PlayAction Add(PlayAction action, bool fixedPosition = false)
  {
    return ActionQueue.Insert(MonoBehaviourSingleton<ActionQueue>.instance.count, action, fixedPosition);
  }

  public static PlayAction Stack(PlayAction action, bool fixedPosition = false)
  {
    return ActionQueue.Insert(0, action, fixedPosition);
  }

  public static PlayAction[] GetActions()
  {
    return MonoBehaviourSingleton<ActionQueue>.instance.queue.ToArray();
  }

  public static int IndexOf(PlayAction action)
  {
    return MonoBehaviourSingleton<ActionQueue>.instance.queue.IndexOf(action);
  }

  public static bool Remove(PlayAction action)
  {
    if (ActionQueue.IndexOf(action) < 0 || action == ActionQueue.current)
      return false;
    MonoBehaviourSingleton<ActionQueue>.instance.queue.Remove(action);
    --MonoBehaviourSingleton<ActionQueue>.instance.count;
    return true;
  }

  public static IEnumerator Wait(bool includeParallel = true)
  {
    while (MonoBehaviourSingleton<ActionQueue>.instance.count > 0)
      yield return (object) null;
    if (includeParallel)
      yield return (object) ActionQueue.parallelClump.WaitForEnd();
  }

  public void Start() => this.StartCoroutine(this.Routine());

  public static void Restart()
  {
    Debug.Log((object) "~ ACTION QUEUE RESET ~");
    MonoBehaviourSingleton<ActionQueue>.instance.StopAllCoroutines();
    MonoBehaviourSingleton<ActionQueue>.instance.queue.Clear();
    MonoBehaviourSingleton<ActionQueue>.instance.count = 0;
    ActionQueue.current = (PlayAction) null;
    ActionQueue.parallelClump.Clear();
    MonoBehaviourSingleton<ActionQueue>.instance.StartCoroutine(MonoBehaviourSingleton<ActionQueue>.instance.Routine());
  }

  public IEnumerator Routine()
  {
    while (true)
    {
      while (this.count <= 0 || GameManager.paused || Deckpack.IsOpen || ActionQueue.current != null)
        yield return (object) null;
      yield return (object) this.RunActionRoutine();
    }
  }

  public IEnumerator RunActionRoutine()
  {
    int index = ActionQueue.GetIndexOfHighestPriorityAction((IReadOnlyList<PlayAction>) this.queue);
    ActionQueue.current = this.queue[index];
    ActionQueue.current.fixedPosition = true;
    if (ActionQueue.current.parallel)
    {
      ActionQueue.RunParallel(ActionQueue.current);
      this.queue.RemoveAt(index);
      --this.count;
    }
    else
    {
      yield return (object) this.PerformAction(ActionQueue.current);
      this.queue.RemoveAt(index);
      --this.count;
      yield return (object) this.PostAction(ActionQueue.current);
    }
    ActionQueue.current = (PlayAction) null;
  }

  public static int GetIndexOfHighestPriorityAction(IReadOnlyList<PlayAction> actions)
  {
    int num = int.MinValue;
    int highestPriorityAction = -1;
    int count = actions.Count;
    for (int index = 0; index < count; ++index)
    {
      PlayAction action = actions[index];
      if (action.priority > num)
      {
        num = action.priority;
        highestPriorityAction = index;
      }
    }
    return highestPriorityAction;
  }

  public IEnumerator Run(PlayAction action)
  {
    yield return (object) this.PerformAction(action);
    yield return (object) this.PostAction(action);
  }

  public IEnumerator PerformAction(PlayAction action)
  {
    Events.InvokeActionPerform(action);
    if ((double) action.pauseBefore + (double) this.delayBefore > 0.0)
      yield return (object) Sequences.Wait(action.pauseBefore + this.delayBefore);
    if (action.IsRoutine)
      yield return (object) action.Run();
    else
      action.Process();
  }

  public IEnumerator PostAction(PlayAction action)
  {
    Events.InvokeActionFinished(action);
    yield return (object) StatusEffectSystem.ActionPerformedEvent(action);
    if ((double) action.pauseAfter + (double) this.delayAfter > 0.0)
      yield return (object) Sequences.Wait(action.pauseAfter + this.delayAfter);
  }

  public static void RunParallel(PlayAction action)
  {
    ActionQueue.parallelClump.Add(MonoBehaviourSingleton<ActionQueue>.instance.Run(action));
  }
}
