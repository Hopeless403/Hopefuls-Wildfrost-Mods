// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantReduceMaxCounter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Reduce Max Counter", fileName = "Reduce Max Counter")]
public class StatusEffectInstantReduceMaxCounter : StatusEffectInstant
{
  public override IEnumerator Process()
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    StatusEffectInstantReduceMaxCounter reduceMaxCounter = this;
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
    reduceMaxCounter.target.counter.current = Mathf.Max(0, reduceMaxCounter.target.counter.current - reduceMaxCounter.GetAmount());
    reduceMaxCounter.target.counter.max = Mathf.Max(1, reduceMaxCounter.target.counter.max - reduceMaxCounter.GetAmount());
    reduceMaxCounter.target.PromptUpdate();
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E2__current = (object) reduceMaxCounter.\u003C\u003En__0();
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = 1;
    return true;
  }

  [CompilerGenerated]
  [DebuggerHidden]
  public new IEnumerator \u003C\u003En__0() => base.Process();
}
