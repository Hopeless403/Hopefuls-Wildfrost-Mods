// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantCleanse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Cleanse", fileName = "Cleanse")]
public class StatusEffectInstantCleanse : StatusEffectInstant
{
  protected override IEnumerator Process()
  {
    StatusEffectInstantCleanse effectInstantCleanse = this;
    for (int i = effectInstantCleanse.target.statusEffects.Count - 1; i >= 0; --i)
    {
      StatusEffectData statusEffect = effectInstantCleanse.target.statusEffects[i];
      if (statusEffect.IsNegativeStatusEffect())
        yield return (object) statusEffect.Remove();
    }
    effectInstantCleanse.target.PromptUpdate();
    // ISSUE: reference to a compiler-generated method
    yield return (object) effectInstantCleanse.\u003C\u003En__0();
  }
}
