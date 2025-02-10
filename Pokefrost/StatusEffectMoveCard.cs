// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectMoveCard
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections;

#nullable disable
namespace Pokefrost
{
  public class StatusEffectMoveCard : StatusEffectInstant
  {
    public StatusEffectMoveCard.Containers toWhere = StatusEffectMoveCard.Containers.Discard;

    public virtual CardContainer GetContainer()
    {
      if (this.toWhere == StatusEffectMoveCard.Containers.Hand || this.toWhere == StatusEffectMoveCard.Containers.Draw)
        return References.Player.handContainer;
      if (this.toWhere == StatusEffectMoveCard.Containers.Discard)
        return References.Player.discardContainer;
      throw new Exception("Did you forget to declare a container when building the StatusEffect?");
    }

    public override IEnumerator Process()
    {
      yield return (object) Sequences.CardMove(this.target, new CardContainer[1]
      {
        this.GetContainer()
      });
      CardContainer[] cardContainerArray = this.target.preContainers;
      for (int index = 0; index < cardContainerArray.Length; ++index)
      {
        CardContainer c = cardContainerArray[index];
        c.TweenChildPositions();
        c = (CardContainer) null;
      }
      cardContainerArray = (CardContainer[]) null;
      yield return (object) base.Process();
    }

    public enum Containers
    {
      Hand,
      Draw,
      Discard,
    }
  }
}
