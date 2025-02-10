// Decompiled with JetBrains decompiler
// Type: SpeechBubbleData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

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
