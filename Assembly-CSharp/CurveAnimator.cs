// Decompiled with JetBrains decompiler
// Type: CurveAnimator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class CurveAnimator : MonoBehaviourCacheTransform, IPoolable
{
  private static readonly Vector3 rotationInfluence = new Vector3(5f, 7f, 2f);
  private static readonly float rotationDurationMod = 1.5f;
  private static readonly float moveAnimationDur = 0.667f;
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
}
