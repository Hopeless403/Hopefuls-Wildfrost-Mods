// Decompiled with JetBrains decompiler
// Type: Snowfall2.Classes.StatusEffects.StatusEffectInstantSummonRand
// Assembly: Snowfall, Version=0.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 26AFE777-3FAB-4D6F-AF6C-494837402D4A
// Assembly location: C:\Users\harri\AppData\Local\Temp\Temp1_Snowfall_-_Alpha_2.1.2.zip\Snowfall.dll

using Dead;
using System.Collections;

namespace Snowfall2.Classes.StatusEffects
{
  public class StatusEffectInstantSummonRand : StatusEffectInstantSummon
  {
    public CardData[] summonCardOptions;

    public override IEnumerator Process()
    {
      if (this.canSummonMultiple)
      {
        Routine.Clump clump = new Routine.Clump();
        int amount = this.GetAmount();
        for (int i = 0; i < amount; ++i)
          clump.Add(this.TrySummonRand());
        yield return (object) clump.WaitForEnd();
        clump = (Routine.Clump) null;
      }
      else if (this.queue)
      {
        ActionSequence action = new ActionSequence(this.TrySummonRand());
        action.note = "Instant Summon";
        ActionQueue.Stack((PlayAction) action, true);
      }
      else
        yield return (object) this.TrySummonRand();
      yield return (object) this.Remove();
    }

    public IEnumerator TrySummonRand()
    {
      this.targetSummon.summonCard = Random.Choose<CardData>(this.summonCardOptions);
      return this.TrySummon();
    }
  }
}
