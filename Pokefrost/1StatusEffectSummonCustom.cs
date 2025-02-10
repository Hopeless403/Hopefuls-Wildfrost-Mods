// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectInstantSummonLastRecycled
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectInstantSummonLastRecycled : StatusEffectInstantSummon
  {
    public override IEnumerator Process()
    {
      if ((Object) StatusEffectAllCardsAreRecycled.PatchRecycle.lastDestroyed != (Object) null)
      {
        this.targetSummon.summonCard = StatusEffectAllCardsAreRecycled.PatchRecycle.lastDestroyed;
        StatusEffectAllCardsAreRecycled.PatchRecycle.lastDestroyed = (CardData) null;
        yield return (object) base.Process();
      }
      else
        yield return (object) this.Remove();
    }
  }
}
