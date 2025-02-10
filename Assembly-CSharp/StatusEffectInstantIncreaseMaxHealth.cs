// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantIncreaseMaxHealth
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Instant/Increase Max Health", fileName = "Increase Max Health")]
public class StatusEffectInstantIncreaseMaxHealth : StatusEffectInstant
{
  protected override IEnumerator Process()
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    StatusEffectInstantIncreaseMaxHealth increaseMaxHealth = this;
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
    increaseMaxHealth.target.hp.max += increaseMaxHealth.GetAmount();
    increaseMaxHealth.target.hp.current += increaseMaxHealth.GetAmount();
    increaseMaxHealth.target.PromptUpdate();
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated method
    this.\u003C\u003E2__current = (object) increaseMaxHealth.\u003C\u003En__0();
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = 1;
    return true;
  }
}
