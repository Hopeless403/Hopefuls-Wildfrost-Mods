// Decompiled with JetBrains decompiler
// Type: CardAnimationSupportive
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Supportive", menuName = "Card Animation/Supportive")]
public class CardAnimationSupportive : CardAnimation
{
  [SerializeField]
  public float hitPos = 0.2f;

  public override IEnumerator Routine(object data, float startDelay = 0.0f)
  {
    if (data is Trigger trigger)
    {
      yield return (object) new WaitForSeconds(startDelay);
      yield return (object) Sequences.Wait(trigger.entity.curveAnimator.Ping() * this.hitPos);
    }
  }
}
