// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantReduceAttack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Reduce Attack", fileName = "Reduce Attack")]
public class StatusEffectInstantReduceAttack : StatusEffectInstant
{
  public override IEnumerator Process()
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    StatusEffectInstantReduceAttack instantReduceAttack = this;
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
    instantReduceAttack.target.damage.current -= instantReduceAttack.GetAmount();
    instantReduceAttack.target.PromptUpdate();
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E2__current = (object) instantReduceAttack.\u003C\u003En__0();
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = 1;
    return true;
  }

  [CompilerGenerated]
  [DebuggerHidden]
  public new IEnumerator \u003C\u003En__0() => base.Process();
}
