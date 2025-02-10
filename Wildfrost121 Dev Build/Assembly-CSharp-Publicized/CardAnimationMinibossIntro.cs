// Decompiled with JetBrains decompiler
// Type: CardAnimationMinibossIntro
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Miniboss Intro", menuName = "Card Animation/Miniboss Intro")]
public class CardAnimationMinibossIntro : CardAnimation
{
  [SerializeField]
  public float rumbleAmount = 1f;
  [SerializeField]
  public float wobbleAmount = 1f;
  [SerializeField]
  public CurveProfile scaleTween;
  [SerializeField]
  public Vector3 scaleTo = new Vector3(1f, 1f, 1f);
  [SerializeField]
  public CurveProfile rotateTween;
  [SerializeField]
  public Vector3 rotateAmount = new Vector3(1f, 1f, 5f);

  public override IEnumerator Routine(object data, float startDelay = 0.0f)
  {
    if (data is Entity target)
    {
      yield return (object) new WaitForSeconds(startDelay);
      float seconds = Mathf.Max(this.scaleTween.duration, this.rotateTween.duration);
      Events.InvokeScreenRumble(0.0f, this.rumbleAmount, 0.0f, seconds * 0.5f, seconds * 0.5f, seconds * 0.5f);
      target.wobbler?.WobbleRandom(this.wobbleAmount);
      LeanTween.scale(target.gameObject, this.scaleTo, this.scaleTween.duration).setEase(this.scaleTween.curve);
      LeanTween.rotateLocal(target.gameObject, this.rotateAmount, this.rotateTween.duration).setEase(this.rotateTween.curve);
      yield return (object) new WaitForSeconds(seconds);
    }
  }
}
