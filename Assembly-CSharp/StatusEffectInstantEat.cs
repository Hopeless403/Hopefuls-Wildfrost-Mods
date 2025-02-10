// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantEat
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Instant/Eat", fileName = "Eat")]
public class StatusEffectInstantEat : StatusEffectInstant
{
  [SerializeField]
  private bool gainHealth = true;
  [SerializeField]
  private bool gainAttack = true;
  [SerializeField]
  private bool gainEffects = true;
  [SerializeField]
  [ShowIf("gainEffects")]
  private TraitData[] illegalTraits;
  [SerializeField]
  [ShowIf("gainEffects")]
  private StatusEffectData[] illegalEffects;

  protected override IEnumerator Process()
  {
    StatusEffectInstantEat effectInstantEat = this;
    if ((bool) (UnityEngine.Object) effectInstantEat.applier && effectInstantEat.applier.alive && (bool) (UnityEngine.Object) effectInstantEat.target && effectInstantEat.target.alive && (effectInstantEat.gainHealth || effectInstantEat.gainAttack || effectInstantEat.gainEffects))
      yield return (object) effectInstantEat.Eat();
    effectInstantEat.target.forceKill = true;
    yield return (object) effectInstantEat.target.Kill(DeathType.Eaten);
    // ISSUE: reference to a compiler-generated method
    yield return (object) effectInstantEat.\u003C\u003En__0();
  }

  private IEnumerator Eat()
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

  private void GainHealth()
  {
    this.applier.hp.current += this.target.hp.current;
    this.applier.hp.max += this.target.hp.max;
  }

  private void GainAttack()
  {
    this.applier.damage.current += this.target.damage.current;
    this.applier.damage.max += this.target.damage.max;
  }

  private IEnumerator GainEffects()
  {
    StatusEffectInstantEat effectInstantEat = this;
    effectInstantEat.applier.attackEffects = CardData.StatusEffectStacks.Stack((IEnumerable<CardData.StatusEffectStacks>) effectInstantEat.applier.attackEffects, (IEnumerable<CardData.StatusEffectStacks>) effectInstantEat.target.attackEffects).ToList<CardData.StatusEffectStacks>();
    // ISSUE: reference to a compiler-generated method
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
}
