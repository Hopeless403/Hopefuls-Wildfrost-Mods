// Decompiled with JetBrains decompiler
// Type: SettingOptions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using TMPro;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class SettingOptions : Setting<int>
{
  [SerializeField]
  public TMP_Dropdown dropdown;
  [SerializeField]
  public GameObject tweener;
  [SerializeField]
  public AnimationCurve tweenCurve;
  [SerializeField]
  public float tweenDur = 0.33f;
  [SerializeField]
  public UnityEvent<int> onValueChanged;

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

  public void Tween(int dir)
  {
    LeanTween.cancel(this.tweener);
    LeanTween.moveLocalX(this.tweener, 0.1f * (float) dir, this.tweenDur).setFrom(0.0f).setEase(this.tweenCurve).setIgnoreTimeScale(true);
  }
}
