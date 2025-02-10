// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenDeployed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Deployed", fileName = "Apply X When Deployed")]
public class StatusEffectApplyXWhenDeployed : StatusEffectApplyX
{
  [SerializeField]
  public bool whenSelfDeployed = true;
  [SerializeField]
  public bool whenAllyDeployed;
  [SerializeField]
  public bool whenEnemyDeployed;
  public Hit hackyHit;
  public bool isAlreadyOnBoard;

  public override object GetMidBattleData() => (object) Battle.IsOnBoard(this.target);

  public override void RestoreMidBattleData(object data)
  {
    if (!(data is bool flag))
      return;
    this.isAlreadyOnBoard = flag && Battle.IsOnBoard(this.target);
  }

  public override void Init()
  {
    this.OnEnable += new StatusEffectData.EffectEntityEventHandler(this.Activate);
    this.OnCardMove += new StatusEffectData.EffectEntityEventHandler(this.Activate);
  }

  public override bool RunEnableEvent(Entity entity)
  {
    if (this.whenSelfDeployed && (Object) entity == (Object) this.target && Battle.IsOnBoard(this.target))
    {
      if (this.isAlreadyOnBoard)
      {
        this.isAlreadyOnBoard = false;
        return false;
      }
      this.hackyHit = (Hit) null;
      return true;
    }
    if (this.whenAllyDeployed && this.target.enabled && StatusEffectApplyXWhenDeployed.IsAlly(this.target, entity) && Battle.IsOnBoard(this.target) && Battle.IsOnBoard(entity))
    {
      this.hackyHit = new Hit(this.target, entity);
      return true;
    }
    if (!this.whenEnemyDeployed || !this.target.enabled || !StatusEffectApplyXWhenDeployed.IsEnemy(this.target, entity) || !Battle.IsOnBoard(this.target) || !Battle.IsOnBoard(entity))
      return false;
    this.hackyHit = new Hit(this.target, entity);
    return true;
  }

  public override bool RunCardMoveEvent(Entity entity)
  {
    if (!this.target.enabled || !entity.enabled)
      return false;
    if (this.whenSelfDeployed && (Object) entity == (Object) this.target && StatusEffectApplyXWhenDeployed.WasMovedOnToBoard(entity))
    {
      this.hackyHit = (Hit) null;
      return true;
    }
    if (this.whenAllyDeployed && StatusEffectApplyXWhenDeployed.IsAlly(this.target, entity) && StatusEffectApplyXWhenDeployed.WasMovedOnToBoard(entity))
    {
      this.hackyHit = new Hit(this.target, entity);
      return true;
    }
    if (!this.whenEnemyDeployed || !StatusEffectApplyXWhenDeployed.IsEnemy(this.target, entity) || !StatusEffectApplyXWhenDeployed.WasMovedOnToBoard(entity))
      return false;
    this.hackyHit = new Hit(this.target, entity);
    return true;
  }

  public IEnumerator Activate(Entity entity)
  {
    StatusEffectApplyXWhenDeployed applyXwhenDeployed = this;
    if ((bool) (Object) applyXwhenDeployed.contextEqualAmount)
    {
      int amount = applyXwhenDeployed.contextEqualAmount.Get(entity);
      yield return (object) applyXwhenDeployed.Run(applyXwhenDeployed.GetTargets(applyXwhenDeployed.hackyHit), amount);
    }
    else
      yield return (object) applyXwhenDeployed.Run(applyXwhenDeployed.GetTargets(applyXwhenDeployed.hackyHit));
  }

  public static bool WasMovedOnToBoard(Entity entity)
  {
    return Battle.IsOnBoard(entity) && !Battle.IsOnBoard(entity.preContainers);
  }

  public static bool IsAlly(Entity a, Entity b)
  {
    return (Object) a != (Object) b && a.owner.team == b.owner.team;
  }

  public static bool IsEnemy(Entity a, Entity b) => a.owner.team != b.owner.team;
}
