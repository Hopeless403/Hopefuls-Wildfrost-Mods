// Decompiled with JetBrains decompiler
// Type: StatusEffectResistX
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

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
