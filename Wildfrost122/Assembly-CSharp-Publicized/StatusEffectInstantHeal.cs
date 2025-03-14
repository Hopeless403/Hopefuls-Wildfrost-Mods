﻿// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantHeal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Heal", fileName = "Heal")]
public class StatusEffectInstantHeal : StatusEffectInstant
{
  [SerializeField]
  public bool doPing = true;

  public override IEnumerator Process()
  {
    StatusEffectInstantHeal effectInstantHeal = this;
    if (effectInstantHeal.target.alive)
    {
      if (effectInstantHeal.doPing)
      {
        CurveAnimator curveAnimator = effectInstantHeal.target.curveAnimator;
        if (curveAnimator != null)
        {
          double num = (double) curveAnimator.Ping();
        }
      }
      yield return (object) new Hit(effectInstantHeal.applier, effectInstantHeal.target, -effectInstantHeal.GetAmount()).Process();
    }
    yield return (object) effectInstantHeal.\u003C\u003En__0();
  }

  [CompilerGenerated]
  [DebuggerHidden]
  public new IEnumerator \u003C\u003En__0() => base.Process();
}
