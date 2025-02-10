// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectSketchOnDeploy
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectSketchOnDeploy : StatusEffectApplyXWhenDeployed
  {
    public override bool RunEnableEvent(Entity entity)
    {
      return base.RunEnableEvent(entity) && this.CountDown();
    }

    public override bool RunCardMoveEvent(Entity entity)
    {
      return base.RunCardMoveEvent(entity) && this.CountDown();
    }

    public bool CountDown()
    {
      foreach (CardData cardData in References.PlayerData.inventory.deck)
      {
        if ((long) this.target.data.id == (long) cardData.id)
        {
          for (int index = 0; index < cardData.startWithEffects.Length; ++index)
          {
            CardData.StatusEffectStacks startWithEffect = cardData.startWithEffects[index];
            if (startWithEffect.data.name == this.name)
            {
              --startWithEffect.count;
              if (startWithEffect.count == 0)
              {
                cardData.startWithEffects = cardData.startWithEffects.RemoveFromArray<CardData.StatusEffectStacks>(startWithEffect);
                return true;
              }
            }
          }
        }
      }
      return true;
    }
  }
}
