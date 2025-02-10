// Decompiled with JetBrains decompiler
// Type: CurveAnimator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Runtime.CompilerServices;
using UnityEngine;

public class CurveAnimator : MonoBehaviourCacheTransform, IPoolable
{
  public static readonly Vector3 rotationInfluence = new Vector3(5f, 7f, 2f);
  public static readonly float rotationDurationMod = 1.5f;
  public static readonly float moveAnimationDur = 0.667f;
  public float pingDuration = 0.667f;
  public Vector3 pingScale = Vector3.one * 1.25f;
  public Vector3 pingMove = Vector3.back;
  public bool active;

  public float Move(Vector3 offset, AnimationCurve curve, float rotationAmount = 1f, float duration = 0.667f)
  {
    this.CancelTween();
    if ((bool) (UnityEngine.Object) this.gameObject)
    {
      this.active = true;
      LeanTween.moveLocal(this.gameObject, offset, duration).setEase(curve).setOnComplete((System.Action) (() => this.active = false));
      if ((double) rotationAmount != 0.0)
      {
        double num = (double) this.Rotate(new Vector3(offset.y * CurveAnimator.rotationInfluence.x, -offset.x * CurveAnimator.rotationInfluence.y, -offset.x * CurveAnimator.rotationInfluence.z) * rotationAmount, curve, duration * CurveAnimator.rotationDurationMod);
      }
    }
    return duration;
  }

  public float Rotate(Vector3 offset, AnimationCurve curve, float duration)
  {
    LeanTween.rotateLocal(this.gameObject, offset, duration).setEase(curve);
    return duration;
  }

  public float Scale(Vector3 offset, AnimationCurve curve, float duration)
  {
    this.CancelTween();
    LeanTween.scale(this.gameObject, offset, duration).setEase(curve);
    return duration;
  }

  public float Ping()
  {
    if ((bool) (UnityEngine.Object) this.gameObject)
    {
      this.CancelTween();
      this.active = true;
      AnimationCurve easeCurve = Curves.Get(nameof (Ping));
      LeanTween.moveLocal(this.gameObject, this.pingMove, this.pingDuration).setEase(easeCurve).setOnComplete((System.Action) (() => this.active = false));
      LeanTween.scale(this.gameObject, this.pingScale, this.pingDuration).setEase(easeCurve);
      Events.InvokeEntityPing(this.gameObject);
    }
    return this.pingDuration;
  }

  public void CancelTween()
  {
    if (!(bool) (UnityEngine.Object) this.gameObject)
      return;
    LeanTween.cancel(this.gameObject);
    this.transform.localPosition = Vector3.zero;
    this.transform.localEulerAngles = Vector3.zero;
    this.transform.localScale = Vector3.one;
  }

  public void OnGetFromPool()
  {
  }

  public void OnReturnToPool()
  {
    this.CancelTween();
    this.active = false;
  }

  [CompilerGenerated]
  public void \u003CMove\u003Eb__7_0() => this.active = false;

  [CompilerGenerated]
  public void \u003CPing\u003Eb__10_0() => this.active = false;
}
