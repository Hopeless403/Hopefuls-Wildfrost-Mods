﻿// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantGainGoldRange
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
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
