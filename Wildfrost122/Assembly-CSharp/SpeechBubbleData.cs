// Decompiled with JetBrains decompiler
// Type: SpeechBubbleData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
public class SpeechBubbleData
{
  public Transform target;
  public string targetName;
  public string text;
  public float delay;

  public float duration { get; private set; }

  public SpeechBubbleData(Transform target, string targetName, string text, float delay = 0.0f)
  {
    this.target = target;
    this.targetName = targetName;
    this.text = text;
    this.delay = delay;
  }

  public void SetDuration(float duration) => this.duration = duration;
}
