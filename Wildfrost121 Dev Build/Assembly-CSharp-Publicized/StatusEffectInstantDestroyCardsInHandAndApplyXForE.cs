// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantDestroyCardsInHandAndApplyXForEach
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Destroy Cards In Hand And Apply X For Each", fileName = "Instant Destroy Cards In Hand And Apply X For Each")]
public class StatusEffectInstantDestroyCardsInHandAndApplyXForEach : StatusEffectInstant
{
  [SerializeField]
  public TargetConstraint[] destroyConstraints;
  [SerializeField]
  public StatusEffectInstant destroyCardEffect;
  [SerializeField]
  public StatusEffectData effectToApply;
  public int destroyed;

  public override IEnumerator Process()
  {
    StatusEffectInstantDestroyCardsInHandAndApplyXForEach andApplyXforEach = this;
    Character player = References.Player;
    int a = andApplyXforEach.GetAmount();
    yield return (object) andApplyXforEach.DestroyCardsSequence(player.handContainer);
    for (int i = 0; i < andApplyXforEach.destroyed; ++i)
      yield return (object) StatusEffectSystem.Apply(andApplyXforEach.target, andApplyXforEach.target, andApplyXforEach.effectToApply, a);
    yield return (object) andApplyXforEach.\u003C\u003En__0();
  }

  public IEnumerator DestroyCardsSequence(CardContainer container)
  {
    StatusEffectInstantDestroyCardsInHandAndApplyXForEach andApplyXforEach = this;
    bool pingDone = false;
    foreach (Entity entity in new List<Entity>((IEnumerable<Entity>) container))
    {
      if (andApplyXforEach.CheckConstraints(entity))
      {
        if (!pingDone)
        {
          double num = (double) andApplyXforEach.target.curveAnimator.Ping();
          pingDone = true;
        }
        ++andApplyXforEach.destroyed;
        yield return (object) StatusEffectSystem.Apply(entity, andApplyXforEach.target, (StatusEffectData) andApplyXforEach.destroyCardEffect, 1, true);
      }
    }
  }

  public bool CheckConstraints(Entity card)
  {
    foreach (TargetConstraint destroyConstraint in this.destroyConstraints)
    {
      if (!destroyConstraint.Check(card))
        return false;
    }
    return true;
  }

  [CompilerGenerated]
  [DebuggerHidden]
  public new IEnumerator \u003C\u003En__0() => base.Process();
}
