// Decompiled with JetBrains decompiler
// Type: SliderUINavigationScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.UI;

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
