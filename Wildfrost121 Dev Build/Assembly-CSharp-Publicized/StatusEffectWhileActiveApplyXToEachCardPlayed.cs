// Decompiled with JetBrains decompiler
// Type: StatusEffectWhileActiveApplyXToEachCardPlayed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Reactions/While Active Apply X To Each Card Played", fileName = "While Active Apply X To Each Card Played")]
public class StatusEffectWhileActiveApplyXToEachCardPlayed : StatusEffectReaction
{
  [SerializeField]
  public StatusEffectData effectToApply;

  public override void Init()
  {
    this.PreCardPlayed += new StatusEffectData.EffectCardPlayEventHandler(this.Activate);
  }

  public override bool RunPreCardPlayedEvent(Entity entity, Entity[] targets)
  {
    return this.CheckEntity(entity) && this.CanTrigger() && Battle.IsOnBoard(this.target);
  }

  public IEnumerator Activate(Entity entity, Entity[] targets)
  {
    yield return (object) this.Run(entity);
  }

  public IEnumerator Run(Entity entity)
  {
    StatusEffectWhileActiveApplyXToEachCardPlayed xtoEachCardPlayed = this;
    Hit hit = new Hit(xtoEachCardPlayed.target, entity, 0);
    hit.AddStatusEffect(xtoEachCardPlayed.effectToApply, xtoEachCardPlayed.GetAmount());
    Routine.Clump clump = new Routine.Clump();
    clump.Add(hit.Process());
    CurveAnimator curveAnimator = xtoEachCardPlayed.target.curveAnimator;
    if (curveAnimator != null)
    {
      double num = (double) curveAnimator.Ping();
    }
    clump.Add(Sequences.Wait(0.3f));
    yield return (object) clump.WaitForEnd();
  }

  public bool CheckEntity(Entity entity)
  {
    return (Object) entity.owner == (Object) this.target.owner && (Object) entity.owner != (Object) null && (Object) entity.data != (Object) null && entity.data.cardType.item;
  }
}
