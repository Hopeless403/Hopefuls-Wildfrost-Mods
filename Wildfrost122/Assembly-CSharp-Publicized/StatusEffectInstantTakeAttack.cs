// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantTakeAttack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Take Attack", fileName = "Take Attack")]
public class StatusEffectInstantTakeAttack : StatusEffectInstant
{
  [SerializeField]
  public StatusEffectData increaseAttackEffect;

  public override IEnumerator Process()
  {
    StatusEffectInstantTakeAttack instantTakeAttack = this;
    int amount = instantTakeAttack.GetAmount();
    instantTakeAttack.target.damage.max -= amount;
    instantTakeAttack.target.damage.current -= amount;
    instantTakeAttack.target.PromptUpdate();
    Hit hit = new Hit(instantTakeAttack.target, instantTakeAttack.applier, 0)
    {
      canRetaliate = false,
      countsAsHit = false
    };
    hit.AddStatusEffect(instantTakeAttack.increaseAttackEffect, amount);
    yield return (object) hit.Process();
    yield return (object) instantTakeAttack.\u003C\u003En__0();
  }

  [CompilerGenerated]
  [DebuggerHidden]
  public new IEnumerator \u003C\u003En__0() => base.Process();
}
