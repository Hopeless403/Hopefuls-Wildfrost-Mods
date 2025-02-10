// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectApplyXWhenCertainCardPlayed
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectApplyXWhenCertainCardPlayed : StatusEffectApplyXOnTurn
  {
    public string cardName = "";
    public bool useCardName = true;
    public string customDataKey = "";
    public bool useCustomData = false;

    public override bool RunCardPlayedEvent(Entity entity, Entity[] targets)
    {
      if (this.turnTaken || !this.target.enabled || !this.DesiredCard(entity) || !Battle.IsOnBoard(this.target))
        return false;
      if (!this.trueOnTurn)
        return true;
      this.turnTaken = true;
      return false;
    }

    protected virtual bool DesiredCard(Entity entity)
    {
      if (this.useCardName)
        return entity?.data?.name == this.cardName;
      if (!this.useCustomData)
        return false;
      string str;
      this.target.data.TryGetCustomData<string>(this.customDataKey, out str, "");
      return entity?.data?.name == str;
    }
  }
}
