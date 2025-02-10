// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantCopyEffects
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Copy Effects", fileName = "Copy Effects")]
public class StatusEffectInstantCopyEffects : StatusEffectInstant
{
  [SerializeField]
  public bool replaceAllEffects = true;
  [SerializeField]
  [HideIf("replaceAllEffects")]
  public int replaceEffectNumber;

  public override IEnumerator Process()
  {
    StatusEffectInstantCopyEffects instantCopyEffects = this;
    yield return instantCopyEffects.replaceAllEffects ? (object) instantCopyEffects.RemoveAllEffects() : (object) instantCopyEffects.RemoveEffect(instantCopyEffects.replaceEffectNumber);
    yield return (object) instantCopyEffects.AddEffectCopies();
    if (instantCopyEffects.applier.display is Card display)
      display.promptUpdateDescription = true;
    instantCopyEffects.applier.PromptUpdate();
    yield return (object) instantCopyEffects.\u003C\u003En__0();
  }

  public IEnumerator RemoveAllEffects()
  {
    StatusEffectInstantCopyEffects instantCopyEffects = this;
    foreach (Entity.TraitStacks trait in instantCopyEffects.applier.traits)
      trait.count = 0;
    yield return (object) instantCopyEffects.applier.UpdateTraits();
    Routine.Clump clump = new Routine.Clump();
    foreach (StatusEffectData statusEffectData in instantCopyEffects.applier.statusEffects.Where<StatusEffectData>((Func<StatusEffectData, bool>) (e => !e.visible)))
      clump.Add(statusEffectData.Remove());
    yield return (object) clump.WaitForEnd();
  }

  public IEnumerator RemoveEffect(int effectNumber)
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    StatusEffectInstantCopyEffects instantCopyEffects = this;
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
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E2__current = (object) instantCopyEffects.applier.statusEffects[effectNumber].Remove();
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = 1;
    return true;
  }

  public IEnumerator AddEffectCopies()
  {
    StatusEffectInstantCopyEffects instantCopyEffects = this;
    List<StatusEffectData> list = instantCopyEffects.target.statusEffects.Where<StatusEffectData>(new Func<StatusEffectData, bool>(instantCopyEffects.\u003CAddEffectCopies\u003Eb__5_0)).ToList<StatusEffectData>();
    foreach (Entity.TraitStacks trait in instantCopyEffects.target.traits)
    {
      foreach (StatusEffectData passiveEffect in trait.passiveEffects)
        list.Remove(passiveEffect);
      int count = trait.count - trait.tempCount;
      if (count > 0)
        instantCopyEffects.applier.GainTrait(trait.data, count);
    }
    foreach (StatusEffectData effectData in list)
      yield return (object) StatusEffectSystem.Apply(instantCopyEffects.applier, effectData.applier, effectData, effectData.count - effectData.temporary);
    instantCopyEffects.applier.attackEffects = ((IEnumerable<CardData.StatusEffectStacks>) CardData.StatusEffectStacks.Stack((IEnumerable<CardData.StatusEffectStacks>) instantCopyEffects.applier.attackEffects, (IEnumerable<CardData.StatusEffectStacks>) instantCopyEffects.target.attackEffects)).Select<CardData.StatusEffectStacks, CardData.StatusEffectStacks>((Func<CardData.StatusEffectStacks, CardData.StatusEffectStacks>) (a => a.Clone())).ToList<CardData.StatusEffectStacks>();
    yield return (object) instantCopyEffects.applier.UpdateTraits();
  }

  [CompilerGenerated]
  [DebuggerHidden]
  public new IEnumerator \u003C\u003En__0() => base.Process();

  [CompilerGenerated]
  public bool \u003CAddEffectCopies\u003Eb__5_0(StatusEffectData e)
  {
    return e.count > e.temporary && !e.isStatus && (UnityEngine.Object) e != (UnityEngine.Object) this && e.HasDescOrIsKeyword;
  }
}
