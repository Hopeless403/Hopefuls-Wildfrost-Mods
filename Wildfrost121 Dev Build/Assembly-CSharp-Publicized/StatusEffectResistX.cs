// Decompiled with JetBrains decompiler
// Type: StatusEffectResistX
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
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
