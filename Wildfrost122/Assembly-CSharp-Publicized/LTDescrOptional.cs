// Decompiled with JetBrains decompiler
// Type: LTDescrOptional
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
public class LTDescrOptional
{
  [CompilerGenerated]
  public Transform \u003CtoTrans\u003Ek__BackingField;
  [CompilerGenerated]
  public Vector3 \u003Cpoint\u003Ek__BackingField;
  [CompilerGenerated]
  public Vector3 \u003Caxis\u003Ek__BackingField;
  [CompilerGenerated]
  public float \u003ClastVal\u003Ek__BackingField;
  [CompilerGenerated]
  public Quaternion \u003CorigRotation\u003Ek__BackingField;
  [CompilerGenerated]
  public LTBezierPath \u003Cpath\u003Ek__BackingField;
  [CompilerGenerated]
  public LTSpline \u003Cspline\u003Ek__BackingField;
  public AnimationCurve animationCurve;
  public int initFrameCount;
  public Color color;
  [CompilerGenerated]
  public LTRect \u003CltRect\u003Ek__BackingField;
  [CompilerGenerated]
  public Action<float> \u003ConUpdateFloat\u003Ek__BackingField;
  [CompilerGenerated]
  public Action<float, float> \u003ConUpdateFloatRatio\u003Ek__BackingField;
  [CompilerGenerated]
  public Action<float, object> \u003ConUpdateFloatObject\u003Ek__BackingField;
  [CompilerGenerated]
  public Action<Vector2> \u003ConUpdateVector2\u003Ek__BackingField;
  [CompilerGenerated]
  public Action<Vector3> \u003ConUpdateVector3\u003Ek__BackingField;
  [CompilerGenerated]
  public Action<Vector3, object> \u003ConUpdateVector3Object\u003Ek__BackingField;
  [CompilerGenerated]
  public Action<Color> \u003ConUpdateColor\u003Ek__BackingField;
  [CompilerGenerated]
  public Action<Color, object> \u003ConUpdateColorObject\u003Ek__BackingField;
  [CompilerGenerated]
  public System.Action \u003ConComplete\u003Ek__BackingField;
  [CompilerGenerated]
  public Action<object> \u003ConCompleteObject\u003Ek__BackingField;
  [CompilerGenerated]
  public object \u003ConCompleteParam\u003Ek__BackingField;
  [CompilerGenerated]
  public object \u003ConUpdateParam\u003Ek__BackingField;
  [CompilerGenerated]
  public System.Action \u003ConStart\u003Ek__BackingField;

  public Transform toTrans
  {
    get => this.\u003CtoTrans\u003Ek__BackingField;
    set => this.\u003CtoTrans\u003Ek__BackingField = value;
  }

  public Vector3 point
  {
    get => this.\u003Cpoint\u003Ek__BackingField;
    set => this.\u003Cpoint\u003Ek__BackingField = value;
  }

  public Vector3 axis
  {
    get => this.\u003Caxis\u003Ek__BackingField;
    set => this.\u003Caxis\u003Ek__BackingField = value;
  }

  public float lastVal
  {
    get => this.\u003ClastVal\u003Ek__BackingField;
    set => this.\u003ClastVal\u003Ek__BackingField = value;
  }

  public Quaternion origRotation
  {
    get => this.\u003CorigRotation\u003Ek__BackingField;
    set => this.\u003CorigRotation\u003Ek__BackingField = value;
  }

  public LTBezierPath path
  {
    get => this.\u003Cpath\u003Ek__BackingField;
    set => this.\u003Cpath\u003Ek__BackingField = value;
  }

  public LTSpline spline
  {
    get => this.\u003Cspline\u003Ek__BackingField;
    set => this.\u003Cspline\u003Ek__BackingField = value;
  }

  public LTRect ltRect
  {
    get => this.\u003CltRect\u003Ek__BackingField;
    set => this.\u003CltRect\u003Ek__BackingField = value;
  }

  public Action<float> onUpdateFloat
  {
    get => this.\u003ConUpdateFloat\u003Ek__BackingField;
    set => this.\u003ConUpdateFloat\u003Ek__BackingField = value;
  }

  public Action<float, float> onUpdateFloatRatio
  {
    get => this.\u003ConUpdateFloatRatio\u003Ek__BackingField;
    set => this.\u003ConUpdateFloatRatio\u003Ek__BackingField = value;
  }

  public Action<float, object> onUpdateFloatObject
  {
    get => this.\u003ConUpdateFloatObject\u003Ek__BackingField;
    set => this.\u003ConUpdateFloatObject\u003Ek__BackingField = value;
  }

  public Action<Vector2> onUpdateVector2
  {
    get => this.\u003ConUpdateVector2\u003Ek__BackingField;
    set => this.\u003ConUpdateVector2\u003Ek__BackingField = value;
  }

  public Action<Vector3> onUpdateVector3
  {
    get => this.\u003ConUpdateVector3\u003Ek__BackingField;
    set => this.\u003ConUpdateVector3\u003Ek__BackingField = value;
  }

  public Action<Vector3, object> onUpdateVector3Object
  {
    get => this.\u003ConUpdateVector3Object\u003Ek__BackingField;
    set => this.\u003ConUpdateVector3Object\u003Ek__BackingField = value;
  }

  public Action<Color> onUpdateColor
  {
    get => this.\u003ConUpdateColor\u003Ek__BackingField;
    set => this.\u003ConUpdateColor\u003Ek__BackingField = value;
  }

  public Action<Color, object> onUpdateColorObject
  {
    get => this.\u003ConUpdateColorObject\u003Ek__BackingField;
    set => this.\u003ConUpdateColorObject\u003Ek__BackingField = value;
  }

  public System.Action onComplete
  {
    get => this.\u003ConComplete\u003Ek__BackingField;
    set => this.\u003ConComplete\u003Ek__BackingField = value;
  }

  public Action<object> onCompleteObject
  {
    get => this.\u003ConCompleteObject\u003Ek__BackingField;
    set => this.\u003ConCompleteObject\u003Ek__BackingField = value;
  }

  public object onCompleteParam
  {
    get => this.\u003ConCompleteParam\u003Ek__BackingField;
    set => this.\u003ConCompleteParam\u003Ek__BackingField = value;
  }

  public object onUpdateParam
  {
    get => this.\u003ConUpdateParam\u003Ek__BackingField;
    set => this.\u003ConUpdateParam\u003Ek__BackingField = value;
  }

  public System.Action onStart
  {
    get => this.\u003ConStart\u003Ek__BackingField;
    set => this.\u003ConStart\u003Ek__BackingField = value;
  }

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
