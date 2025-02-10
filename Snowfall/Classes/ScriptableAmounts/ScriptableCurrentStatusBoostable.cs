// Decompiled with JetBrains decompiler
// Type: Snowfall2.Classes.ScriptableAmounts.ScriptableCurrentStatusBoostable
// Assembly: Snowfall, Version=0.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 26AFE777-3FAB-4D6F-AF6C-494837402D4A
// Assembly location: C:\Users\harri\AppData\Local\Temp\Temp1_Snowfall_-_Alpha_2.1.2.zip\Snowfall.dll

using UnityEngine;

namespace Snowfall2.Classes.ScriptableAmounts
{
  public class ScriptableCurrentStatusBoostable : ScriptableAmount
  {
    public string statusType = "shroom";
    public int offset;

    public override int Get(Entity entity)
    {
      if (!(bool) (Object) entity)
        return this.offset;
      StatusEffectData status = entity.FindStatus(this.statusType);
      if (status == null)
        return this.offset;
      return !status.canBeBoosted ? status.count + this.offset : Mathf.Max(0, Mathf.RoundToInt((float) (status.count + entity.effectBonus) * entity.effectFactor));
    }
  }
}
