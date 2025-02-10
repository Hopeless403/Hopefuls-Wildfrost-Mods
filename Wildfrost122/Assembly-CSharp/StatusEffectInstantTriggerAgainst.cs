// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantTriggerAgainst
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Trigger Against", fileName = "TriggerAgainst")]
public class StatusEffectInstantTriggerAgainst : StatusEffectInstant
{
  [SerializeField]
  private bool countsAsTrigger = true;
  [SerializeField]
  private string triggerType = "basic";
  [SerializeField]
  private bool reduceUses;

  protected override IEnumerator Process()
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
      // ISSUE: reference to a compiler-generated method
      yield return (object) instantTriggerAgainst.\u003C\u003En__0();
    }
  }
}
