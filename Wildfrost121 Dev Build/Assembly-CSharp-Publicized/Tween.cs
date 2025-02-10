// Decompiled with JetBrains decompiler
// Type: Tween
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using UnityEngine;

#nullable disable
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
