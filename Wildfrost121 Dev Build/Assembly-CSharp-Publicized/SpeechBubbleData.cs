﻿// Decompiled with JetBrains decompiler
// Type: SpeechBubbleData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
public class SpeechBubbleData
{
  public Transform target;
  public string targetName;
  public string text;
  public float delay;
  [CompilerGenerated]
  public float \u003Cduration\u003Ek__BackingField;

  public float duration
  {
    get => this.\u003Cduration\u003Ek__BackingField;
    set => this.\u003Cduration\u003Ek__BackingField = value;
  }

  public SpeechBubbleData(Transform target, string targetName, string text, float delay = 0.0f)
  {
    this.target = target;
    this.targetName = targetName;
    this.text = text;
    this.delay = delay;
  }

  public void SetDuration(float duration) => this.duration = duration;
}
