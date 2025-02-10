// Decompiled with JetBrains decompiler
// Type: Sequences
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using UnityEngine;

public static class Sequences
{
  public static IEnumerator Wait(float seconds)
  {
    while ((double) seconds > 0.0)
    {
      seconds -= Time.deltaTime;
      if ((double) seconds <= 0.0)
        break;
      yield return (object) null;
    }
  }

  public static IEnumerator Null()
  {
    if (!GameManager.paused)
      yield return (object) new WaitForFixedUpdate();
  }

  public static IEnumerator WaitForAnimationEnd(Entity entity)
  {
    yield return (object) new WaitUntil((Func<bool>) (() => !entity.IsAliveAndExists() || !(bool) (UnityEngine.Object) entity.curveAnimator || !entity.curveAnimator.active));
  }

  public static IEnumerator WaitForStatusEffectEvents()
  {
    while (StatusEffectSystem.EventsRunning)
      yield return (object) null;
  }

  public static IEnumerator ShuffleTo(
    CardContainer fromContainer,
    CardContainer toContainer,
    float delayBetween = 0.05f)
  {
    if ((bool) (UnityEngine.Object) toContainer && toContainer.Empty && (bool) (UnityEngine.Object) fromContainer)
    {
      while (!fromContainer.Empty)
      {
        yield return (object) Sequences.CardMove(fromContainer[UnityEngine.Random.Range(0, fromContainer.Count)], new CardContainer[1]
        {
          toContainer
        });
        if ((double) delayBetween > 0.0)
          yield return (object) Sequences.Wait(delayBetween);
      }
      if ((double) delayBetween <= 0.0)
        toContainer.SetChildPositions();
    }
  }

  public static IEnumerator CardDiscard(Entity entity)
  {
    Debug.Log((object) string.Format("Discarding [{0}]", (object) entity));
    yield return (object) Sequences.CardMove(entity, new CardContainer[1]
    {
      entity.owner.discardContainer
    });
  }

  public static IEnumerator CardMove(
    Entity entity,
    CardContainer[] toContainers,
    int insertPos = -1,
    bool tweenAll = true)
  {
    bool enabled = entity.enabled;
    entity.RemoveFromContainers();
    if (insertPos >= 0)
    {
      foreach (CardContainer toContainer in toContainers)
        toContainer.Insert(insertPos, entity);
    }
    else
    {
      foreach (CardContainer toContainer in toContainers)
        toContainer.Add(entity);
    }
    entity.ResetDrawOrder();
    if (!entity.enabled & enabled)
      yield return (object) StatusEffectSystem.EntityDisableEvent(entity);
    if (tweenAll)
    {
      foreach (CardContainer toContainer in toContainers)
        toContainer.TweenChildPositions();
      if (toContainers.Length == 1 && toContainers[0] is CardSlotLane toContainer1)
      {
        foreach (Entity entity1 in (CardContainer) toContainer1)
        {
          if (entity1.height > 1)
          {
            foreach (CardContainer container in entity1.containers)
            {
              if ((UnityEngine.Object) container != (UnityEngine.Object) toContainer1)
                container.TweenChildPositions();
            }
          }
        }
      }
    }
    Events.InvokeEntityMove(entity);
    yield return (object) StatusEffectSystem.CardMoveEvent(entity);
  }

  public static IEnumerator CardRecall(Entity entity)
  {
    if ((bool) (UnityEngine.Object) entity.owner.discardContainer)
    {
      yield return (object) Sequences.Wait(0.3f);
      yield return (object) Sequences.CardMove(entity, new CardContainer[1]
      {
        entity.owner.discardContainer
      });
    }
    else if ((bool) (UnityEngine.Object) entity.owner.reserveContainer)
    {
      yield return (object) Sequences.Wait(0.3f);
      int insertPos = RandomInclusive.Range(0, entity.owner.reserveContainer.Count - 1);
      yield return (object) Sequences.CardMove(entity, new CardContainer[1]
      {
        entity.owner.reserveContainer
      }, insertPos);
    }
  }

  public static IEnumerator EndCampaign(string newSceneKey)
  {
    yield return (object) Transition.WaitUntilDone(Transition.Begin());
    if ((bool) (UnityEngine.Object) References.Campaign)
      References.Campaign.Final();
    Routine.Clump clump = new Routine.Clump();
    clump.Add(SceneManager.Unload("Campaign"));
    clump.Add(SceneManager.Unload("UI"));
    yield return (object) clump.WaitForEnd();
    yield return (object) Sequences.SceneChange(newSceneKey);
  }

  public static IEnumerator SceneChange(string newSceneKey)
  {
    string preActive = SceneManager.ActiveSceneKey;
    CardPopUp.Clear();
    yield return (object) SceneManager.Load(newSceneKey, SceneType.Active);
    yield return (object) SceneManager.Unload(preActive);
  }
}
