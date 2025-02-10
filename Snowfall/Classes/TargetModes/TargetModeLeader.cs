// Decompiled with JetBrains decompiler
// Type: Snowfall2.Classes.TargetModes.TargetModeLeader
// Assembly: Snowfall, Version=0.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 26AFE777-3FAB-4D6F-AF6C-494837402D4A
// Assembly location: C:\Users\harri\AppData\Local\Temp\Temp1_Snowfall_-_Alpha_2.1.2.zip\Snowfall.dll

using System;
using System.Linq;

namespace Snowfall2.Classes.TargetModes
{
  public class TargetModeLeader : TargetMode
  {
    public override Entity[] GetPotentialTargets(
      Entity entity,
      Entity target,
      CardContainer targetContainer)
    {
      return Battle.instance.cards.Where<Entity>((Func<Entity, bool>) (c => c.data.cardType.name == "Leader")).ToArray<Entity>();
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
