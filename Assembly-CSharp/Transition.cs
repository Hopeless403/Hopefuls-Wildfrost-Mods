// Decompiled with JetBrains decompiler
// Type: Transition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Transition : MonoBehaviourSingleton<Transition>
{
  private static TransitionType current;
  [SerializeField]
  private TransitionType[] transitions;
  public static bool Running;
  private TransitionType prefab;

  private void OnEnable() => global::Events.OnSettingChanged += new UnityAction<string, object>(this.SettingChanged);

  private void OnDisable() => global::Events.OnSettingChanged -= new UnityAction<string, object>(this.SettingChanged);

  private void SettingChanged(string key, object value)
  {
    if (key != "TransitionType" || !(value is int index))
      return;
    this.SetTransitionType(index);
  }

  private void SetTransitionType(int index) => this.prefab = this.transitions[Mathf.Clamp(index, 0, this.transitions.Length - 1)];

  public static TransitionType Begin()
  {
    if ((bool) (UnityEngine.Object) Transition.current)
    {
      if (Transition.Running)
        return Transition.current;
      UnityEngine.Object.Destroy((UnityEngine.Object) Transition.current.gameObject);
    }
    if (!(bool) (UnityEngine.Object) MonoBehaviourSingleton<Transition>.instance.prefab)
      MonoBehaviourSingleton<Transition>.instance.SetTransitionType(Settings.Load<int>("TransitionType", 0));
    Transition.current = UnityEngine.Object.Instantiate<TransitionType>(MonoBehaviourSingleton<Transition>.instance.prefab, MonoBehaviourSingleton<Transition>.instance.transform);
    MonoBehaviourSingleton<Transition>.instance.StopAllCoroutines();
    MonoBehaviourSingleton<Transition>.instance.StartCoroutine(Transition.current.In());
    global::Events.InvokeTransitionStart(Transition.current);
    Transition.Running = true;
    return Transition.current;
  }

  public static void End()
  {
    if (!(bool) (UnityEngine.Object) Transition.current)
      return;
    MonoBehaviourSingleton<Transition>.instance.StopAllCoroutines();
    MonoBehaviourSingleton<Transition>.instance.StartCoroutine(Transition.current.Out());
    global::Events.InvokeTransitionEnd(Transition.current);
    Transition.Running = false;
  }

  public static IEnumerator WaitUntilDone(TransitionType transition)
  {
    if (transition == null)
      transition = Transition.current;
    yield return (object) new WaitUntil((Func<bool>) (() => !(bool) (UnityEngine.Object) transition || !transition.IsRunning));
  }

  public static IEnumerator To(string newSceneKey)
  {
    yield return (object) Transition.WaitUntilDone(Transition.Begin());
    yield return (object) Sequences.SceneChange(newSceneKey);
  }
}
