// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantTakeHealth
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Instant/Take Health", fileName = "Take Health")]
public class StatusEffectInstantTakeHealth : StatusEffectInstant
{
  [SerializeField]
  public StatusEffectData increaseHealthEffect;

  public override IEnumerator Process()
  {
    StatusEffectInstantTakeHealth instantTakeHealth = this;
    int amount = instantTakeHealth.GetAmount();
    int count = Mathf.Min(instantTakeHealth.target.hp.current, amount);
    instantTakeHealth.target.hp.max -= amount;
    instantTakeHealth.target.hp.current -= amount;
    instantTakeHealth.target.PromptUpdate();
    Hit hit = new Hit(instantTakeHealth.target, instantTakeHealth.applier, 0)
    {
      canRetaliate = false,
      countsAsHit = false
    };
    hit.AddStatusEffect(instantTakeHealth.increaseHealthEffect, count);
    yield return (object) hit.Process();
    yield return (object) instantTakeHealth.\u003C\u003En__0();
  }

  [CompilerGenerated]
  [DebuggerHidden]
  public new IEnumerator \u003C\u003En__0() => base.Process();
}
