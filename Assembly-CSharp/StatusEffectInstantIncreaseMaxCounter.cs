// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantIncreaseMaxCounter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Instant/Increase Max Counter", fileName = "Increase Max Counter")]
public class StatusEffectInstantIncreaseMaxCounter : StatusEffectInstant
{
  protected override IEnumerator Process()
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    StatusEffectInstantIncreaseMaxCounter increaseMaxCounter = this;
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
    increaseMaxCounter.target.counter.current += increaseMaxCounter.GetAmount();
    increaseMaxCounter.target.counter.max += increaseMaxCounter.GetAmount();
    increaseMaxCounter.target.PromptUpdate();
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated method
    this.\u003C\u003E2__current = (object) increaseMaxCounter.\u003C\u003En__0();
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = 1;
    return true;
  }
}
