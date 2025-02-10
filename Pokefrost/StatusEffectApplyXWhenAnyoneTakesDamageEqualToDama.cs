// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectApplyXWhenAnyoneTakesDamageEqualToDamage
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectApplyXWhenAnyoneTakesDamageEqualToDamage : 
    StatusEffectApplyXWhenAnyoneTakesDamage
  {
    public int damageAmount;

    public override bool RunPostHitEvent(Hit hit)
    {
      if (!this.target.enabled || !this.target.alive || !hit.Offensive || !(hit.damageType == this.targetDamageType))
        return false;
      this.damageAmount = hit.damage + hit.damageBlocked;
      return Battle.IsOnBoard(this.target);
    }

    public override int GetAmount(Entity entity, bool equalAmount = false, int equalTo = 0)
    {
      return this.damageAmount;
    }
  }
}
