// Decompiled with JetBrains decompiler
// Type: CardAnimationPing
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(fileName = "Ping", menuName = "Card Animation/Ping")]
public class CardAnimationPing : CardAnimation
{
  [SerializeField]
  public bool waitForEnd;

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
