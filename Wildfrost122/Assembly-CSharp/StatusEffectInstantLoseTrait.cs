// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantLoseTrait
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Linq;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Lose Trait", fileName = "Lose Trait")]
public class StatusEffectInstantLoseTrait : StatusEffectInstant
{
  public TraitData traitToLose;

  protected override IEnumerator Process()
  {
    StatusEffectInstantLoseTrait instantLoseTrait = this;
    // ISSUE: reference to a compiler-generated method
    Entity.TraitStacks moveToFront = instantLoseTrait.target.traits.FirstOrDefault<Entity.TraitStacks>(new Func<Entity.TraitStacks, bool>(instantLoseTrait.\u003CProcess\u003Eb__1_0));
    if (moveToFront != null)
    {
      moveToFront.count = 0;
      yield return (object) instantLoseTrait.target.UpdateTraits(moveToFront);
      instantLoseTrait.target.display.promptUpdateDescription = true;
      instantLoseTrait.target.PromptUpdate();
    }
    // ISSUE: reference to a compiler-generated method
    foreach (StatusEffectData statusEffectData in instantLoseTrait.target.statusEffects.Where<StatusEffectData>(new Func<StatusEffectData, bool>(instantLoseTrait.\u003CProcess\u003Eb__1_1)).ToList<StatusEffectData>())
      yield return (object) statusEffectData.Remove();
    // ISSUE: reference to a compiler-generated method
    yield return (object) instantLoseTrait.\u003C\u003En__0();
  }
}
