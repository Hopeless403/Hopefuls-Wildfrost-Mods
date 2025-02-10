// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectInstantSummonLuminPart
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectInstantSummonLuminPart : StatusEffectInstantSummon
  {
    public CardData card1;
    public CardData card2;

    public override IEnumerator Process()
    {
      List<Entity> entityList = new List<Entity>();
      entityList.AddRange((IEnumerable<Entity>) References.Player.handContainer.ToList<Entity>());
      entityList.AddRange((IEnumerable<Entity>) References.Player.drawContainer.ToList<Entity>());
      entityList.AddRange((IEnumerable<Entity>) References.Player.discardContainer.ToList<Entity>());
      Debug.Log((object) "[Pokefrost] Checking deck");
      foreach (Entity entity in entityList)
      {
        if (entity.data.name == this.card1.name)
        {
          this.targetSummon.summonCard = this.card2;
          break;
        }
        if (entity.data.name == this.card2.name)
        {
          this.targetSummon.summonCard = this.card1;
          break;
        }
      }
      return base.Process();
    }
  }
}
