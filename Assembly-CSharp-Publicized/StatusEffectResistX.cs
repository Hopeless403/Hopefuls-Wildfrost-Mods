// Decompiled with JetBrains decompiler
// Type: StatusEffectResistX
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Immunity/Resist X", fileName = "Resist X")]
public class StatusEffectResistX : StatusEffectData
{
  [SerializeField]
  public string resistType = "snow";

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
