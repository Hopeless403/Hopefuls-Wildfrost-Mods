// Decompiled with JetBrains decompiler
// Type: CardAnimationPing
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

#nullable disable
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
