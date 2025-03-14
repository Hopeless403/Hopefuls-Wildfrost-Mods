﻿// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantCleanse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Instant/Cleanse", fileName = "Cleanse")]
public class StatusEffectInstantCleanse : StatusEffectInstant
{
  protected override IEnumerator Process()
  {
    StatusEffectInstantCleanse effectInstantCleanse = this;
    for (int i = effectInstantCleanse.target.statusEffects.Count - 1; i >= 0; --i)
    {
      StatusEffectData statusEffect = effectInstantCleanse.target.statusEffects[i];
      if (statusEffect.offensive && statusEffect.visible && statusEffect.isStatus)
        yield return (object) statusEffect.Remove();
    }
    effectInstantCleanse.target.PromptUpdate();
    // ISSUE: reference to a compiler-generated method
    yield return (object) effectInstantCleanse.\u003C\u003En__0();
  }
}
