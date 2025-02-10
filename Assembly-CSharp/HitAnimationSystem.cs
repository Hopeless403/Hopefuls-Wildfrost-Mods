// Decompiled with JetBrains decompiler
// Type: HitAnimationSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;

public class HitAnimationSystem : GameSystem
{
  [SerializeField]
  private AnimationCurve hitCurve;
  [SerializeField]
  private float strength = 0.65f;
  [SerializeField]
  private AnimationCurve strengthCurve;
  [SerializeField]
  private float duration = 0.667f;
  [SerializeField]
  private AnimationCurve durationCurve;
  [SerializeField]
  private float wobble = 2f;
  [SerializeField]
  private AnimationCurve wobbleCurve;

  private void OnEnable()
  {
    global::Events.OnEntityHit += new UnityAction<Hit>(this.EntityHit);
    global::Events.OnEntityDodge += new UnityAction<Hit>(this.EntityDodge);
  }

  private void OnDisable()
  {
    global::Events.OnEntityHit -= new UnityAction<Hit>(this.EntityHit);
    global::Events.OnEntityDodge -= new UnityAction<Hit>(this.EntityDodge);
  }

  private void EntityDodge(Hit hit)
  {
    if (!hit.Offensive || !hit.doAnimation)
      return;
    Entity target = hit.target;
    if (target == null || !(target.display is Card))
      return;
    this.CardTakeHit(hit);
  }

  private void EntityHit(Hit hit)
  {
    if (!hit.Offensive || !hit.doAnimation || !hit.countsAsHit)
      return;
    Entity target = hit.target;
    if (target == null || !(target.display is Card))
      return;
    this.CardTakeHit(hit);
  }

  private void CardTakeHit(Hit hit)
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

  private static Vector3 GetHitDirection(Vector3 targetPos, Vector3 attackerPos) => (targetPos - attackerPos).normalized;
}
