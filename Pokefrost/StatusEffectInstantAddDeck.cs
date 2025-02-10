// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectInstantAddDeck
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectInstantAddDeck : StatusEffectInstant
  {
    public CardData card;

    public override IEnumerator Process()
    {
      References.Player.data.inventory.deck.Add(this.card.Clone());
      yield return (object) base.Process();
    }
  }
}
