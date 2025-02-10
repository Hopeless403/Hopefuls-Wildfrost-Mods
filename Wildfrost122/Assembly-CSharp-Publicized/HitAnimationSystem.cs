// Decompiled with JetBrains decompiler
// Type: HitAnimationSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class HitAnimationSystem : GameSystem
{
  [SerializeField]
  public AnimationCurve hitCurve;
  [SerializeField]
  public float strength = 0.65f;
  [SerializeField]
  public AnimationCurve strengthCurve;
  [SerializeField]
  public float duration = 0.667f;
  [SerializeField]
  public AnimationCurve durationCurve;
  [SerializeField]
  public float wobble = 2f;
  [SerializeField]
  public AnimationCurve wobbleCurve;

  public void OnEnable()
  {
    global::Events.OnEntityHit += new UnityAction<Hit>(this.EntityHit);
    global::Events.OnEntityDodge += new UnityAction<Hit>(this.EntityDodge);
  }

  public void OnDisable()
  {
    global::Events.OnEntityHit -= new UnityAction<Hit>(this.EntityHit);
    global::Events.OnEntityDodge -= new UnityAction<Hit>(this.EntityDodge);
  }

  public void EntityDodge(Hit hit)
  {
    if (!hit.Offensive || !hit.doAnimation)
      return;
    Entity target = hit.target;
    if (target == null || !(target.display is Card))
      return;
    this.CardTakeHit(hit);
  }

  public void EntityHit(Hit hit)
  {
    if (!hit.Offensive || !hit.doAnimation || !hit.countsAsHit)
      return;
    Entity target = hit.target;
    if (target == null || !(target.display is Card))
      return;
    this.CardTakeHit(hit);
  }

  public void CardTakeHit(Hit hit)
  {
    CurveAnimator curveAnimator = hit.target.curveAnimator;
    if (curveAnimator == null)
      return;
    int offensiveness = hit.GetOffensiveness();
    float num1 = this.strength * this.strengthCurve.Evaluate((float) offensiveness);
    float duration = this.duration * this.durationCurve.Evaluate((float) offensiveness);
    float num2 = this.wobble * this.wobbleCurve.Evaluate((float) offensiveness);
    Vector3 attackerPos = (bool) (Object) hit.attacker ? hit.attacker.transform.position : Vector3.zero;
    Vector3 hitDirection = HitAnimationSystem.GetHitDirection(hit.target.transform.position, attackerPos);
    double num3 = (double) curveAnimator.Move(hitDirection * num1, this.hitCurve, 0.0f, duration);
    if ((double) num2 <= 0.0 || !(bool) (Object) hit.target.wobbler)
      return;
    hit.target.wobbler.Wobble(hitDirection * num2);
  }

  public static Vector3 GetHitDirection(Vector3 targetPos, Vector3 attackerPos)
  {
    return (targetPos - attackerPos).normalized;
  }
}
