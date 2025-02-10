// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyToSummon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Status Effects/Traits/Apply To Summon", fileName = "Apply To Summon")]
public class StatusEffectApplyToSummon : StatusEffectData
{
  [SerializeField]
  private StatusEffectData effectToApply;

  protected override void Init() => global::Events.OnEntitySummoned += new UnityAction<Entity, Entity>(this.EntitySummoned);

  private void OnDestroy() => global::Events.OnEntitySummoned -= new UnityAction<Entity, Entity>(this.EntitySummoned);

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
