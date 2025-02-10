// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyToSummon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Traits/Apply To Summon", fileName = "Apply To Summon")]
public class StatusEffectApplyToSummon : StatusEffectData
{
  [SerializeField]
  public StatusEffectData effectToApply;

  public override void Init()
  {
    global::Events.OnEntitySummoned += new UnityAction<Entity, Entity>(this.EntitySummoned);
  }

  public void OnDestroy()
  {
    global::Events.OnEntitySummoned -= new UnityAction<Entity, Entity>(this.EntitySummoned);
  }

  public void EntitySummoned(Entity entity, Entity summonedBy)
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
