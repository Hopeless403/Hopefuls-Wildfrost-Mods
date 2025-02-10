// Decompiled with JetBrains decompiler
// Type: SliderUINavigationScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

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
