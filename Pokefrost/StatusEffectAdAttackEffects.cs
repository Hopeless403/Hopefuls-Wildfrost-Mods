// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectAddAttackEffects
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Linq;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectAddAttackEffects : StatusEffectData
  {
    public StatusEffectData effectToApply;
    public bool sameOwner = false;
    public bool includeSelf = true;
    public TargetConstraint[] attackerConstraints = new TargetConstraint[0];

    public override bool RunHitEvent(Hit hit)
    {
      if ((UnityEngine.Object) hit.attacker == (UnityEngine.Object) null || !Battle.IsOnBoard(hit.attacker) || (UnityEngine.Object) hit.target == (UnityEngine.Object) null || !hit.Offensive || !hit.BasicHit || this.sameOwner && (UnityEngine.Object) hit?.attacker?.owner != (UnityEngine.Object) this.target.owner || !this.includeSelf && (UnityEngine.Object) hit?.attacker == (UnityEngine.Object) this.target)
        return false;
      foreach (TargetConstraint targetConstraint in this.targetConstraints)
      {
        if (!targetConstraint.Check(hit.target))
          return false;
      }
      foreach (TargetConstraint attackerConstraint in this.attackerConstraints)
      {
        if (!attackerConstraint.Check(hit.attacker))
          return false;
      }
      CardData.StatusEffectStacks statusEffectStacks = (CardData.StatusEffectStacks) null;
      if (hit.statusEffects != null)
        statusEffectStacks = hit.statusEffects.FirstOrDefault<CardData.StatusEffectStacks>((Func<CardData.StatusEffectStacks, bool>) (s => s.data?.name == this.effectToApply.name));
      if (statusEffectStacks == null)
        hit.AddStatusEffect(new CardData.StatusEffectStacks(this.effectToApply, this.GetAmount()));
      else
        statusEffectStacks.data.count += this.GetAmount();
      return false;
    }
  }
}
