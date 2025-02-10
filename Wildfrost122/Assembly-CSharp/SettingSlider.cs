// Decompiled with JetBrains decompiler
// Type: SettingSlider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class SettingSlider : Setting<float>
{
  [SerializeField]
  private Slider slider;

  public override void SetValue(float value) => this.slider.value = value;
}
