// Decompiled with JetBrains decompiler
// Type: CardAnimationMinibossIntro
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(fileName = "Miniboss Intro", menuName = "Card Animation/Miniboss Intro")]
public class CardAnimationMinibossIntro : CardAnimation
{
  [SerializeField]
  private float rumbleAmount = 1f;
  [SerializeField]
  private float wobbleAmount = 1f;
  [SerializeField]
  private CurveProfile scaleTween;
  [SerializeField]
  private Vector3 scaleTo = new Vector3(1f, 1f, 1f);
  [SerializeField]
  private CurveProfile rotateTween;
  [SerializeField]
  private Vector3 rotateAmount = new Vector3(1f, 1f, 5f);

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
