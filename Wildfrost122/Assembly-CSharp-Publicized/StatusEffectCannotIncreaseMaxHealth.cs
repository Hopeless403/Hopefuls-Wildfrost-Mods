// Decompiled with JetBrains decompiler
// Type: StatusEffectCannotIncreaseMaxHealth
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Traits/Cannot Increase Max Health", fileName = "Cannot Increase Max Health")]
public class StatusEffectCannotIncreaseMaxHealth : StatusEffectData
{
  public override bool RunApplyStatusEvent(StatusEffectApply apply)
  {
    if ((Object) apply.target == (Object) this.target && !this.target.silenced && StatusEffectCannotIncreaseMaxHealth.CheckEffectType(apply.effectData))
      apply.count = 0;
    return false;
  }

  public static bool CheckEffectType(StatusEffectData effectData)
  {
    if (!(bool) (Object) effectData)
      return false;
    string type = effectData.type;
    return (type == "max health up" ? 0 : (!(type == "max health up only") ? 1 : 0)) == 0;
  }
}
