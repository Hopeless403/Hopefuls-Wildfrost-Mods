// Decompiled with JetBrains decompiler
// Type: TimeScaleSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class TimeScaleSystem : GameSystem
{
  private void OnEnable() => global::Events.OnTimeScaleChange += new UnityAction<float>(this.TimeScaleSet);

  private void OnDisable() => global::Events.OnTimeScaleChange -= new UnityAction<float>(this.TimeScaleSet);

  private void TimeScaleSet(float value) => Time.timeScale = value;
}
