// Decompiled with JetBrains decompiler
// Type: StatusEffectNextPhase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Misc/Next Phase", fileName = "Next Phase")]
public class StatusEffectNextPhase : StatusEffectData
{
  [SerializeField]
  public CardData nextPhase;
  [SerializeField]
  public CardData[] splitOptions;
  [SerializeField]
  public int splitCount;
  [SerializeField]
  public CardAnimation animation;
  public bool goToNextPhase;
  public bool activated;

  public override void Init()
  {
    global::Events.OnEntityDisplayUpdated += new UnityAction<Entity>(this.EntityDisplayUpdated);
  }

  public void OnDestroy()
  {
    global::Events.OnEntityDisplayUpdated -= new UnityAction<Entity>(this.EntityDisplayUpdated);
  }

  public void EntityDisplayUpdated(Entity entity)
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

  public void TryActivate()
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
