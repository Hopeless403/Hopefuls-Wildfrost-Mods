// Decompiled with JetBrains decompiler
// Type: SettingOptions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class SettingOptions : Setting<int>
{
  [SerializeField]
  private TMP_Dropdown dropdown;
  [SerializeField]
  private GameObject tweener;
  [SerializeField]
  private AnimationCurve tweenCurve;
  [SerializeField]
  private float tweenDur = 0.33f;
  [SerializeField]
  private UnityEvent<int> onValueChanged;

  public override void SetValue(int value)
  {
    if (value < 0)
      value += this.dropdown.options.Count;
    value %= this.dropdown.options.Count;
    this.dropdown.value = value;
  }

  public void Add(float single)
  {
    if ((double) single > 0.0)
    {
      this.Increase();
    }
    else
    {
      if ((double) single >= 0.0)
        return;
      this.Decrease();
    }
  }

  public void Increase()
  {
    this.SetValue(this.dropdown.value + 1);
    this.Tween(1);
    this.onValueChanged?.Invoke(this.dropdown.value);
  }

  public void Decrease()
  {
    this.SetValue(this.dropdown.value - 1);
    this.Tween(-1);
    this.onValueChanged?.Invoke(this.dropdown.value);
  }

  private void Tween(int dir)
  {
    LeanTween.cancel(this.tweener);
    LeanTween.moveLocalX(this.tweener, 0.1f * (float) dir, this.tweenDur).setFrom(0.0f).setEase(this.tweenCurve).setIgnoreTimeScale(true);
  }
}
