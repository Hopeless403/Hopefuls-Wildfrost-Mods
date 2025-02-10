// Decompiled with JetBrains decompiler
// Type: SliderUINavigationScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class SliderUINavigationScript : MonoBehaviour
{
  public float valueMultiplier = 0.1f;
  public Slider slider;
  [SerializeField]
  public SliderSfx sfx;

  public void OnChangeSliderValue(float inValueChange)
  {
    inValueChange *= this.valueMultiplier;
    this.slider.value += inValueChange;
    if (!(bool) (Object) this.sfx)
      return;
    this.sfx.Fire();
  }
}
