// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantTriggerAgainst
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Trigger Against", fileName = "TriggerAgainst")]
public class StatusEffectInstantTriggerAgainst : StatusEffectInstant
{
  [SerializeField]
  public bool countsAsTrigger = true;
  [SerializeField]
  public string triggerType = "basic";
  [SerializeField]
  public bool reduceUses;

  public override IEnumerator Process()
  {
    StatusEffectInstantTriggerAgainst instantTriggerAgainst = this;
    if (instantTriggerAgainst.applier.IsAliveAndExists() && instantTriggerAgainst.target.IsAliveAndExists())
    {
      ActionQueue.Stack((PlayAction) new ActionTriggerAgainst(instantTriggerAgainst.applier, instantTriggerAgainst.target, instantTriggerAgainst.target, instantTriggerAgainst.target.containers[0])
      {
        countsAsTrigger = instantTriggerAgainst.countsAsTrigger
      }, true);
      if (instantTriggerAgainst.reduceUses)
        ActionQueue.Add((PlayAction) new ActionReduceUses(instantTriggerAgainst.applier));
      yield return (object) instantTriggerAgainst.\u003C\u003En__0();
    }
  }

  [CompilerGenerated]
  [DebuggerHidden]
  public new IEnumerator \u003C\u003En__0() => base.Process();
}
