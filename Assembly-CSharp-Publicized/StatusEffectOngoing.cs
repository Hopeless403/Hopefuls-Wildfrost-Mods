// Decompiled with JetBrains decompiler
// Type: StatusEffectOngoing
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public abstract class StatusEffectOngoing : StatusEffectData
{
  [InfoBox("\"Reverse\" to reduce instead of increase", EInfoBoxType.Normal)]
  [SerializeField]
  public bool reverse;

  public virtual IEnumerator Add(int add) => (IEnumerator) null;

  public virtual IEnumerator Remove(int remove) => (IEnumerator) null;

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
    yield return (object) statusEffectOngoing.\u003C\u003En__0(amount, removeTemporary);
  }

  public override bool HasEndRoutine => true;

  public override IEnumerator EndRoutine() => this.Remove(this.reverse ? -this.count : this.count);

  [CompilerGenerated]
  [DebuggerHidden]
  public IEnumerator \u003C\u003En__0(int amount, bool removeTemporary) => base.RemoveStacks(amount, removeTemporary);
}
