// Decompiled with JetBrains decompiler
// Type: Tween
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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
