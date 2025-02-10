// Decompiled with JetBrains decompiler
// Type: StatusEffectResistX
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Immunity/Resist X", fileName = "Resist X")]
public class StatusEffectResistX : StatusEffectData
{
  [SerializeField]
  private string resistType = "snow";

  public override bool RunApplyStatusEvent(StatusEffectApply apply)
  {
    if ((Object) apply.target == (Object) this.target && apply.effectData?.type == this.resistType)
    {
      apply.count -= this.count;
      if (apply.count <= 0)
      {
        apply.effectData = (StatusEffectData) null;
        apply.count = 0;
      }
    }
    return false;
  }
}
