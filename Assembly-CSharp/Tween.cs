// Decompiled with JetBrains decompiler
// Type: Tween
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using UnityEngine;

[Serializable]
public struct Tween
{
  public LeanTweenType ease;
  public float dur;
  public bool hasFrom;
  public float scaleFrom;
  public float scaleTo;

  public void Run(GameObject gameObject)
  {
    LeanTween.cancel(gameObject);
    LeanTween.scale(gameObject, Vector3.one * this.scaleTo, this.dur).setEase(this.ease).setFrom(this.hasFrom ? Vector3.one * this.scaleFrom : gameObject.transform.localScale);
  }
}
