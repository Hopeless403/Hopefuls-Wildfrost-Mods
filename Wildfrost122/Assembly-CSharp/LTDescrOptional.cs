// Decompiled with JetBrains decompiler
// Type: LTDescrOptional
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using UnityEngine;

#nullable disable
public class LTDescrOptional
{
  public AnimationCurve animationCurve;
  public int initFrameCount;
  public Color color;

  public Transform toTrans { get; set; }

  public Vector3 point { get; set; }

  public Vector3 axis { get; set; }

  public float lastVal { get; set; }

  public Quaternion origRotation { get; set; }

  public LTBezierPath path { get; set; }

  public LTSpline spline { get; set; }

  public LTRect ltRect { get; set; }

  public Action<float> onUpdateFloat { get; set; }

  public Action<float, float> onUpdateFloatRatio { get; set; }

  public Action<float, object> onUpdateFloatObject { get; set; }

  public Action<Vector2> onUpdateVector2 { get; set; }

  public Action<Vector3> onUpdateVector3 { get; set; }

  public Action<Vector3, object> onUpdateVector3Object { get; set; }

  public Action<Color> onUpdateColor { get; set; }

  public Action<Color, object> onUpdateColorObject { get; set; }

  public System.Action onComplete { get; set; }

  public Action<object> onCompleteObject { get; set; }

  public object onCompleteParam { get; set; }

  public object onUpdateParam { get; set; }

  public System.Action onStart { get; set; }

  public void reset()
  {
    this.animationCurve = (AnimationCurve) null;
    this.onUpdateFloat = (Action<float>) null;
    this.onUpdateFloatRatio = (Action<float, float>) null;
    this.onUpdateVector2 = (Action<Vector2>) null;
    this.onUpdateVector3 = (Action<Vector3>) null;
    this.onUpdateFloatObject = (Action<float, object>) null;
    this.onUpdateVector3Object = (Action<Vector3, object>) null;
    this.onUpdateColor = (Action<Color>) null;
    this.onComplete = (System.Action) null;
    this.onCompleteObject = (Action<object>) null;
    this.onCompleteParam = (object) null;
    this.onStart = (System.Action) null;
    this.point = Vector3.zero;
    this.initFrameCount = 0;
  }

  public void callOnUpdate(float val, float ratioPassed)
  {
    if (this.onUpdateFloat != null)
      this.onUpdateFloat(val);
    if (this.onUpdateFloatRatio != null)
      this.onUpdateFloatRatio(val, ratioPassed);
    else if (this.onUpdateFloatObject != null)
      this.onUpdateFloatObject(val, this.onUpdateParam);
    else if (this.onUpdateVector3Object != null)
      this.onUpdateVector3Object(LTDescr.newVect, this.onUpdateParam);
    else if (this.onUpdateVector3 != null)
    {
      this.onUpdateVector3(LTDescr.newVect);
    }
    else
    {
      if (this.onUpdateVector2 == null)
        return;
      this.onUpdateVector2(new Vector2(LTDescr.newVect.x, LTDescr.newVect.y));
    }
  }
}
