// Decompiled with JetBrains decompiler
// Type: Snowfall2.Classes.TargetModes.TargetModePincer
// Assembly: Snowfall, Version=0.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 26AFE777-3FAB-4D6F-AF6C-494837402D4A
// Assembly location: C:\Users\harri\AppData\Local\Temp\Temp1_Snowfall_-_Alpha_2.1.2.zip\Snowfall.dll

namespace Snowfall2.Classes.TargetModes
{
  public class TargetModePincer : TargetModeRow
  {
    public override bool TargetRow => false;

    public override Entity[] GetPotentialTargets(
      Entity entity,
      Entity target,
      CardContainer targetContainer)
    {
      Entity[] potentialTargets1 = base.GetPotentialTargets(entity, target, targetContainer);
      Entity[] potentialTargets2;
      if (potentialTargets1.Length < 2)
        potentialTargets2 = potentialTargets1;
      else
        potentialTargets2 = new Entity[2]
        {
          potentialTargets1[0],
          potentialTargets1[potentialTargets1.Length - 1]
        };
      return potentialTargets2;
    }

    public override Entity[] GetSubsequentTargets(
      Entity entity,
      Entity target,
      CardContainer targetContainer)
    {
      return this.GetTargets(entity, target, targetContainer);
    }
  }
}
