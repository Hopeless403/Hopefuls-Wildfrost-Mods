﻿// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantReduceMaxHealth
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Instant/Reduce Max Health", fileName = "Reduce Max Health")]
public class StatusEffectInstantReduceMaxHealth : StatusEffectInstant
{
  public override IEnumerator Process()
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    StatusEffectInstantReduceMaxHealth instantReduceMaxHealth = this;
    if (num != 0)
    {
      if (num != 1)
        return false;
      // ISSUE: reference to a compiler-generated field
      this.\u003C\u003E1__state = -1;
      return false;
    }
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = -1;
    instantReduceMaxHealth.target.hp.max -= instantReduceMaxHealth.GetAmount();
    instantReduceMaxHealth.target.hp.current -= instantReduceMaxHealth.GetAmount();
    instantReduceMaxHealth.target.PromptUpdate();
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E2__current = (object) instantReduceMaxHealth.\u003C\u003En__0();
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = 1;
    return true;
  }

  [CompilerGenerated]
  [DebuggerHidden]
  public new IEnumerator \u003C\u003En__0() => base.Process();
}
