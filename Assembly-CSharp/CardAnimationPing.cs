// Decompiled with JetBrains decompiler
// Type: CardAnimationPing
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(fileName = "Ping", menuName = "Card Animation/Ping")]
public class CardAnimationPing : CardAnimation
{
  [SerializeField]
  private bool waitForEnd;

  public override IEnumerator Routine(object data, float startDelay = 0.0f)
  {
    if (data is Entity target)
    {
      yield return (object) new WaitForSeconds(startDelay);
      CurveAnimator curveAnimator = target.curveAnimator;
      if (curveAnimator != null)
      {
        double num = (double) curveAnimator.Ping();
        if (this.waitForEnd)
          yield return (object) new WaitForSeconds(curveAnimator.pingDuration);
      }
    }
  }
}
