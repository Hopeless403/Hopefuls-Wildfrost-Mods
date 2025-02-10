// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectInstantRemoveCounter
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Pokefrost
{
  public class StatusEffectInstantRemoveCounter : StatusEffectInstant
  {
    public int cCount = 99;

    public override IEnumerator Process()
    {
      this.target.counter.current = this.cCount;
      this.target.counter.max = this.cCount;
      for (int j = this.target.statusEffects.Count - 1; j >= 0; --j)
      {
        if (this.target.statusEffects[j].HasDescOrIsKeyword && this.target.statusEffects[j].GetType() == typeof (StatusEffectWhileActiveX))
        {
          StatusEffectWhileActiveX activeEff = this.target.statusEffects[j] as StatusEffectWhileActiveX;
          if (activeEff.active)
            yield return (object) activeEff.Deactivate();
          activeEff = (StatusEffectWhileActiveX) null;
        }
        yield return (object) this.target.statusEffects[j].Remove();
      }
      this.target.attackEffects = new List<CardData.StatusEffectStacks>();
      this.target.traits.Clear();
      this.target.PromptUpdate();
      yield return (object) base.Process();
    }
  }
}
