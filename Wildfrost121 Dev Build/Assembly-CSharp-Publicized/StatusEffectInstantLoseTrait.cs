// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantLoseTrait
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Lose Trait", fileName = "Lose Trait")]
public class StatusEffectInstantLoseTrait : StatusEffectInstant
{
  public TraitData traitToLose;

  public override IEnumerator Process()
  {
    StatusEffectInstantLoseTrait instantLoseTrait = this;
    Entity.TraitStacks moveToFront = instantLoseTrait.target.traits.FirstOrDefault<Entity.TraitStacks>(new Func<Entity.TraitStacks, bool>(instantLoseTrait.\u003CProcess\u003Eb__1_0));
    if (moveToFront != null)
    {
      moveToFront.count = 0;
      yield return (object) instantLoseTrait.target.UpdateTraits(moveToFront);
      instantLoseTrait.target.display.promptUpdateDescription = true;
      instantLoseTrait.target.PromptUpdate();
    }
    foreach (StatusEffectData statusEffectData in instantLoseTrait.target.statusEffects.Where<StatusEffectData>(new Func<StatusEffectData, bool>(instantLoseTrait.\u003CProcess\u003Eb__1_1)).ToList<StatusEffectData>())
      yield return (object) statusEffectData.Remove();
    yield return (object) instantLoseTrait.\u003C\u003En__0();
  }

  [CompilerGenerated]
  public bool \u003CProcess\u003Eb__1_0(Entity.TraitStacks t)
  {
    return (UnityEngine.Object) t.data == (UnityEngine.Object) this.traitToLose;
  }

  [CompilerGenerated]
  public bool \u003CProcess\u003Eb__1_1(StatusEffectData a)
  {
    return a is StatusEffectTemporaryTrait effectTemporaryTrait && (UnityEngine.Object) effectTemporaryTrait.Trait == (UnityEngine.Object) this.traitToLose;
  }

  [CompilerGenerated]
  [DebuggerHidden]
  public new IEnumerator \u003C\u003En__0() => base.Process();
}
