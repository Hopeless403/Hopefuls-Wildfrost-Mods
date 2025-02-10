// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyToSummon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Traits/Apply To Summon", fileName = "Apply To Summon")]
public class StatusEffectApplyToSummon : StatusEffectData
{
  [SerializeField]
  private StatusEffectData effectToApply;

  protected override void Init()
  {
    global::Events.OnEntitySummoned += new UnityAction<Entity, Entity>(this.EntitySummoned);
  }

  private void OnDestroy()
  {
    global::Events.OnEntitySummoned -= new UnityAction<Entity, Entity>(this.EntitySummoned);
  }

  private void EntitySummoned(Entity entity, Entity summonedBy)
  {
    if ((long) summonedBy.data.id != (long) this.target.data.id)
      return;
    int amount = this.GetAmount();
    if (amount <= 0)
      return;
    ActionApplyStatus action = new ActionApplyStatus(entity, summonedBy, this.effectToApply, amount);
    action.fixedPosition = true;
    ActionQueue.Stack((PlayAction) action);
  }
}
