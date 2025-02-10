// Decompiled with JetBrains decompiler
// Type: CardAnimationPunch
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(fileName = "Punch", menuName = "Card Animation/Punch")]
public class CardAnimationPunch : CardAnimation
{
  [SerializeField]
  public AnimationCurve curve;
  [SerializeField]
  public float duration = 1f;
  [SerializeField]
  public float animationDistance = 2.5f;
  [SerializeField]
  public float hitPos = 0.22f;

  public override IEnumerator Routine(object data, float startDelay = 0.0f)
  {
    if (data is Trigger trigger)
    {
      yield return (object) new WaitForSeconds(startDelay);
      Vector3 zero = Vector3.zero;
      foreach (Hit hit in trigger.hits)
        zero += hit.target.transform.position;
      if (trigger.hits.Length != 0)
        zero /= (float) trigger.hits.Length;
      Vector3 offset = ((zero - trigger.entity.transform.position).normalized * this.animationDistance) with
      {
        z = -1f
      };
      double num = (double) trigger.entity.curveAnimator.Move(offset, this.curve, this.duration);
      yield return (object) Sequences.Wait(this.duration * this.hitPos);
    }
  }
}
