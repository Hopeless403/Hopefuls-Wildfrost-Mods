﻿// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantCleanse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Cleanse", fileName = "Cleanse")]
public class StatusEffectInstantCleanse : StatusEffectInstant
{
  public override IEnumerator Process()
  {
    StatusEffectInstantCleanse effectInstantCleanse = this;
    for (int i = effectInstantCleanse.target.statusEffects.Count - 1; i >= 0; --i)
    {
      StatusEffectData statusEffect = effectInstantCleanse.target.statusEffects[i];
      if (statusEffect.IsNegativeStatusEffect())
        yield return (object) statusEffect.Remove();
    }
    effectInstantCleanse.target.PromptUpdate();
    yield return (object) effectInstantCleanse.\u003C\u003En__0();
  }

  [CompilerGenerated]
  [DebuggerHidden]
  public new IEnumerator \u003C\u003En__0() => base.Process();
}
