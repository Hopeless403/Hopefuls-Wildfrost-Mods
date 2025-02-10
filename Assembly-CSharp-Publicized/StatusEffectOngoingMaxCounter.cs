// Decompiled with JetBrains decompiler
// Type: StatusEffectOngoingMaxCounter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Ongoing/Increase Max Counter", fileName = "Ongoing Increase Max Counter")]
public class StatusEffectOngoingMaxCounter : StatusEffectOngoing
{
  public override IEnumerator Add(int add)
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    StatusEffectOngoingMaxCounter ongoingMaxCounter = this;
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
    ongoingMaxCounter.target.counter.current = Mathf.Max(0, ongoingMaxCounter.target.counter.current + add);
    ongoingMaxCounter.target.counter.max = Mathf.Max(1, ongoingMaxCounter.target.counter.max + add);
    ongoingMaxCounter.target.PromptUpdate();
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E2__current = (object) Sequences.Null();
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = 1;
    return true;
  }

  public override IEnumerator Remove(int remove)
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    StatusEffectOngoingMaxCounter ongoingMaxCounter = this;
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
    ongoingMaxCounter.target.counter.current = Mathf.Max(0, ongoingMaxCounter.target.counter.current - remove);
    ongoingMaxCounter.target.counter.max = Mathf.Max(1, ongoingMaxCounter.target.counter.max - remove);
    ongoingMaxCounter.target.PromptUpdate();
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E2__current = (object) Sequences.Null();
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = 1;
    return true;
  }
}
