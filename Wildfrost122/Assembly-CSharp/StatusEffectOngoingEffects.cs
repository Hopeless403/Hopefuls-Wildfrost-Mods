﻿// Decompiled with JetBrains decompiler
// Type: StatusEffectOngoingEffects
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Ongoing/Increase Effects", fileName = "Ongoing Increase Effects")]
public class StatusEffectOngoingEffects : StatusEffectOngoing
{
  [SerializeField]
  private bool add = true;
  [SerializeField]
  [HideIf("add")]
  private bool multiply;

  protected override IEnumerator Add(int add)
  {
    StatusEffectOngoingEffects effectOngoingEffects = this;
    if (effectOngoingEffects.add)
      effectOngoingEffects.target.effectBonus += add;
    else if (effectOngoingEffects.multiply)
      effectOngoingEffects.target.effectFactor += (float) add;
    effectOngoingEffects.target.PromptUpdate();
    yield return (object) Sequences.Null();
  }

  protected override IEnumerator Remove(int remove)
  {
    StatusEffectOngoingEffects effectOngoingEffects = this;
    if (effectOngoingEffects.add)
      effectOngoingEffects.target.effectBonus -= remove;
    else if (effectOngoingEffects.multiply)
      effectOngoingEffects.target.effectFactor -= (float) remove;
    effectOngoingEffects.target.PromptUpdate();
    yield return (object) Sequences.Null();
  }
}
