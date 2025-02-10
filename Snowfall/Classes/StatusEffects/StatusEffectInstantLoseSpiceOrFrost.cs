// Decompiled with JetBrains decompiler
// Type: Snowfall2.Classes.StatusEffects.StatusEffectInstantLoseSpiceOrFrost
// Assembly: Snowfall, Version=0.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 26AFE777-3FAB-4D6F-AF6C-494837402D4A
// Assembly location: C:\Users\harri\AppData\Local\Temp\Temp1_Snowfall_-_Alpha_2.1.2.zip\Snowfall.dll

using System;
using System.Collections;

namespace Snowfall2.Classes.StatusEffects
{
  public class StatusEffectInstantLoseSpiceOrFrost : StatusEffectInstant
  {
    public StatusEffectInstantLoseSpiceOrFrost.InstantLoseType typeToLose;
    public bool doPing;

    public override IEnumerator Process()
    {
      string typeName = "Spice";
      StatusEffectInstantLoseSpiceOrFrost.InstantLoseType typeToLose = this.typeToLose;
      switch (typeToLose)
      {
        case StatusEffectInstantLoseSpiceOrFrost.InstantLoseType.Spice:
          if (this.target.FindStatus("spice") != null && this.target.FindStatus("spice") is StatusEffectSpice spice && this.count < spice.current)
          {
            this.target.tempDamage -= this.count;
            spice.current -= this.count;
            spice.amountToClear -= this.count;
            break;
          }
          break;
        case StatusEffectInstantLoseSpiceOrFrost.InstantLoseType.Frost:
          if (this.target.FindStatus("frost") != null && this.target.FindStatus("frost") is StatusEffectFrost frost && this.count < frost.current)
          {
            this.target.tempDamage += this.count;
            frost.current -= this.count;
            frost.toClear -= this.count;
            break;
          }
          break;
      }
      spice = (StatusEffectSpice) null;
      frost = (StatusEffectFrost) null;
      this.target.Update();
      StatusEffectData statusEffectData = this.target.statusEffects.Find((Predicate<StatusEffectData>) (a => a.name == typeName));
      if ((bool) (UnityEngine.Object) statusEffectData)
      {
        if (this.doPing)
        {
          double num = (double) this.target.curveAnimator.Ping();
        }
        yield return (object) statusEffectData.RemoveStacks(this.count, false);
      }
      yield return (object) base.Process();
    }

    public enum InstantLoseType
    {
      Spice,
      Frost,
    }
  }
}
