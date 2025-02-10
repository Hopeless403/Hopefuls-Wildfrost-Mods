// Decompiled with JetBrains decompiler
// Type: StatusEffectOngoing
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System.Collections;
using UnityEngine;

#nullable disable
public abstract class StatusEffectOngoing : StatusEffectData
{
  [InfoBox("\"Reverse\" to reduce instead of increase", EInfoBoxType.Normal)]
  [SerializeField]
  private bool reverse;

  protected virtual IEnumerator Add(int add) => (IEnumerator) null;

  protected virtual IEnumerator Remove(int remove) => (IEnumerator) null;

  public override bool HasStackRoutine => true;

  public override IEnumerator StackRoutine(int stacks)
  {
    yield return (object) this.Add(this.reverse ? -stacks : stacks);
  }

  public override IEnumerator RemoveStacks(int amount, bool removeTemporary)
  {
    StatusEffectOngoing statusEffectOngoing = this;
    int num = Mathf.Min(statusEffectOngoing.count, amount);
    yield return (object) statusEffectOngoing.Remove(statusEffectOngoing.reverse ? -num : num);
    // ISSUE: reference to a compiler-generated method
    yield return (object) statusEffectOngoing.\u003C\u003En__0(amount, removeTemporary);
  }

  public override bool HasEndRoutine => true;

  public override IEnumerator EndRoutine() => this.Remove(this.reverse ? -this.count : this.count);
}
