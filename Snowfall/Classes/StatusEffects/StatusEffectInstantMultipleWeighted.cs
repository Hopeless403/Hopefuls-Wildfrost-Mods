// Decompiled with JetBrains decompiler
// Type: Snowfall2.Classes.StatusEffects.StatusEffectInstantMultipleWeighted
// Assembly: Snowfall, Version=0.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 26AFE777-3FAB-4D6F-AF6C-494837402D4A
// Assembly location: C:\Users\harri\AppData\Local\Temp\Temp1_Snowfall_-_Alpha_2.1.2.zip\Snowfall.dll

using System.Collections;

namespace Snowfall2.Classes.StatusEffects
{
  public class StatusEffectInstantMultipleWeighted : StatusEffectInstantMultiple
  {
    public int[] weights;
    public bool multiply = true;

    public override bool CanStackActions => false;

    public override IEnumerator Process()
    {
      int amount = this.GetAmount();
      Routine.Clump clump = new Routine.Clump();
      StatusEffectInstant[] array = this.effects;
      int[] array2 = this.weights;
      for (int i = 0; i < array.Length; ++i)
      {
        StatusEffectInstant eff = array[i];
        int weight = array2[i];
        if (!eff.canBeBoosted || amount > 0)
          clump.Add(StatusEffectSystem.Apply(this.target, this.applier, (StatusEffectData) eff, this.multiply ? amount * weight : amount + weight, true));
        eff = (StatusEffectInstant) null;
      }
      yield return (object) clump.WaitForEnd();
      yield return (object) this.Remove();
    }
  }
}
