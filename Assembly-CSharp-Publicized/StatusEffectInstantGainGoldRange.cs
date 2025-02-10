// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantGainGoldRange
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Instant/Gain Gold Range", fileName = "Gain Gold Range")]
public class StatusEffectInstantGainGoldRange : StatusEffectInstant
{
  [SerializeField]
  public Vector2Int range;

  public override IEnumerator Process()
  {
    StatusEffectInstantGainGoldRange instantGainGoldRange = this;
    Character owner = instantGainGoldRange.target.owner;
    if ((Object) owner != (Object) null)
    {
      int amount = instantGainGoldRange.range.Random();
      owner.GainGold(amount);
    }
    yield return (object) instantGainGoldRange.\u003C\u003En__0();
  }

  [CompilerGenerated]
  [DebuggerHidden]
  public new IEnumerator \u003C\u003En__0() => base.Process();
}
