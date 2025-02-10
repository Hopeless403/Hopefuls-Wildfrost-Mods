// Decompiled with JetBrains decompiler
// Type: CardAnimationOverburn
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Overburn", menuName = "Card Animation/Overburn")]
public class CardAnimationOverburn : CardAnimation
{
  public override IEnumerator Routine(object data, float startDelay = 0.0f)
  {
    if (data is Entity target)
    {
      yield return (object) new WaitForSeconds(startDelay);
      CurveAnimator curveAnimator = target.curveAnimator;
      if (curveAnimator != null)
      {
        double num = (double) curveAnimator.Scale(Vector3.one * 0.85f, Curves.Get("Buildup"), 0.67f);
        yield return (object) new WaitForSeconds(0.67f);
      }
    }
  }
}
