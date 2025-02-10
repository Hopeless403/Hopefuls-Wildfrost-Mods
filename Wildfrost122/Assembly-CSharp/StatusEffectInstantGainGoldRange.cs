// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantGainGoldRange
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Gain Gold Range", fileName = "Gain Gold Range")]
public class StatusEffectInstantGainGoldRange : StatusEffectInstant
{
  [SerializeField]
  private Vector2Int range;

  protected override IEnumerator Process()
  {
    StatusEffectInstantGainGoldRange instantGainGoldRange = this;
    Character owner = instantGainGoldRange.target.owner;
    if ((Object) owner != (Object) null)
    {
      int amount = instantGainGoldRange.range.Random();
      owner.GainGold(amount);
    }
    // ISSUE: reference to a compiler-generated method
    yield return (object) instantGainGoldRange.\u003C\u003En__0();
  }
}
