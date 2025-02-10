// Decompiled with JetBrains decompiler
// Type: StatusEffectNextPhase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Status Effects/Misc/Next Phase", fileName = "Next Phase")]
public class StatusEffectNextPhase : StatusEffectData
{
  [SerializeField]
  private CardData nextPhase;
  [SerializeField]
  private CardData[] splitOptions;
  [SerializeField]
  private int splitCount;
  [SerializeField]
  private CardAnimation animation;
  private bool goToNextPhase;
  private bool activated;

  protected override void Init() => global::Events.OnEntityDisplayUpdated += new UnityAction<Entity>(this.EntityDisplayUpdated);

  private void OnDestroy() => global::Events.OnEntityDisplayUpdated -= new UnityAction<Entity>(this.EntityDisplayUpdated);

  private void EntityDisplayUpdated(Entity entity)
  {
    if (this.activated || this.target.hp.current > 0 || !((UnityEngine.Object) entity == (UnityEngine.Object) this.target))
      return;
    this.TryActivate();
  }

  public override bool RunPostHitEvent(Hit hit)
  {
    if (!this.activated && (UnityEngine.Object) hit.target == (UnityEngine.Object) this.target && this.target.hp.current <= 0)
      this.TryActivate();
    return false;
  }

  private void TryActivate()
  {
    bool flag = true;
    foreach (StatusEffectData statusEffect in this.target.statusEffects)
    {
      if ((UnityEngine.Object) statusEffect != (UnityEngine.Object) this && statusEffect.preventDeath)
      {
        flag = false;
        break;
      }
    }
    if (!flag)
      return;
    this.activated = true;
    UnityEngine.Object.FindObjectOfType<ChangePhaseAnimationSystem>()?.Flash();
    if ((bool) (UnityEngine.Object) this.nextPhase)
    {
      ActionChangePhase action = new ActionChangePhase(this.target, this.nextPhase.Clone(), this.animation);
      action.priority = 10;
      ActionQueue.Stack((PlayAction) action, true);
    }
    else
    {
      if (this.splitCount > 0)
      {
        CardData[] splitOptions = this.splitOptions;
        if (splitOptions != null && splitOptions.Length > 0)
        {
          ActionChangePhase action = new ActionChangePhase(this.target, ((IEnumerable<CardData>) this.splitOptions.RandomItems<CardData>(this.splitCount)).Select<CardData, CardData>((Func<CardData, CardData>) (a => a.Clone())).ToArray<CardData>(), this.animation);
          action.priority = 10;
          ActionQueue.Stack((PlayAction) action, true);
          return;
        }
      }
      throw new ArgumentException("Next phase not given!");
    }
  }
}
