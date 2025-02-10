// Decompiled with JetBrains decompiler
// Type: SliderUINavigationScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class SliderUINavigationScript : MonoBehaviour
{
  public float valueMultiplier = 0.1f;
  public Slider slider;
  [SerializeField]
  private SliderSfx sfx;

  public void OnChangeSliderValue(float inValueChange)
  {
    inValueChange *= this.valueMultiplier;
    this.slider.value += inValueChange;
    if (!(bool) (Object) this.sfx)
      return;
    this.sfx.Fire();
  }
}
