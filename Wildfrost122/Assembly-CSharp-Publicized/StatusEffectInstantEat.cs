// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantEat
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
[CreateAssetMenu(menuName = "Status Effects/Instant/Eat", fileName = "Eat")]
public class StatusEffectInstantEat : StatusEffectInstant
{
  [SerializeField]
  public bool gainHealth = true;
  [SerializeField]
  public bool gainAttack = true;
  [SerializeField]
  public bool gainEffects = true;
  [SerializeField]
  [ShowIf("gainEffects")]
  public TraitData[] illegalTraits;
  [SerializeField]
  [ShowIf("gainEffects")]
  public StatusEffectData[] illegalEffects;

  public override IEnumerator Process()
  {
    StatusEffectInstantEat effectInstantEat = this;
    if ((bool) (UnityEngine.Object) effectInstantEat.applier && effectInstantEat.applier.alive && (bool) (UnityEngine.Object) effectInstantEat.target && effectInstantEat.target.alive && (effectInstantEat.gainHealth || effectInstantEat.gainAttack || effectInstantEat.gainEffects))
      yield return (object) effectInstantEat.Eat();
    effectInstantEat.target.forceKill = true;
    yield return (object) effectInstantEat.target.Kill(DeathType.Eaten);
    yield return (object) effectInstantEat.\u003C\u003En__0();
  }

  public IEnumerator Eat()
  {
    StatusEffectInstantEat effectInstantEat = this;
    if (effectInstantEat.gainHealth)
      effectInstantEat.GainHealth();
    if (effectInstantEat.gainAttack)
      effectInstantEat.GainAttack();
    if (effectInstantEat.gainEffects)
    {
      yield return (object) effectInstantEat.GainEffects();
      effectInstantEat.applier.PromptUpdate();
    }
  }

  public void GainHealth()
  {
    this.applier.hp.current += this.target.hp.current;
    this.applier.hp.max += this.target.hp.max;
  }

  public void GainAttack()
  {
    this.applier.damage.current += this.target.damage.current;
    this.applier.damage.max += this.target.damage.max;
  }

  public IEnumerator GainEffects()
  {
    StatusEffectInstantEat effectInstantEat = this;
    effectInstantEat.applier.attackEffects = CardData.StatusEffectStacks.Stack((IEnumerable<CardData.StatusEffectStacks>) effectInstantEat.applier.attackEffects, (IEnumerable<CardData.StatusEffectStacks>) effectInstantEat.target.attackEffects).ToList<CardData.StatusEffectStacks>();
    List<StatusEffectData> list = effectInstantEat.target.statusEffects.Where<StatusEffectData>(new Func<StatusEffectData, bool>(effectInstantEat.\u003CGainEffects\u003Eb__9_0)).ToList<StatusEffectData>();
    foreach (Entity.TraitStacks trait in effectInstantEat.target.traits)
    {
      foreach (StatusEffectData passiveEffect in trait.passiveEffects)
        list.Remove(passiveEffect);
      int count = trait.count - trait.tempCount;
      if (count > 0 && !((IEnumerable<TraitData>) effectInstantEat.illegalTraits).Select<TraitData, string>((Func<TraitData, string>) (t => t.name)).Contains<string>(trait.data.name))
        effectInstantEat.applier.GainTrait(trait.data, count);
    }
    foreach (StatusEffectData effectData in list)
      yield return (object) StatusEffectSystem.Apply(effectInstantEat.applier, effectInstantEat.target, effectData, effectData.count);
    yield return (object) effectInstantEat.applier.UpdateTraits();
    effectInstantEat.applier.display.promptUpdateDescription = true;
  }

  [CompilerGenerated]
  [DebuggerHidden]
  public new IEnumerator \u003C\u003En__0() => base.Process();

  [CompilerGenerated]
  public bool \u003CGainEffects\u003Eb__9_0(StatusEffectData e1)
  {
    return (UnityEngine.Object) e1 != (UnityEngine.Object) this && !((IEnumerable<StatusEffectData>) this.illegalEffects).Select<StatusEffectData, string>((Func<StatusEffectData, string>) (e2 => e2.name)).Contains<string>(e1.name);
  }
}
