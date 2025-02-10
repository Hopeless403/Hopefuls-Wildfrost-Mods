// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenDeployed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Deployed", fileName = "Apply X When Deployed")]
public class StatusEffectApplyXWhenDeployed : StatusEffectApplyX
{
  [SerializeField]
  private bool whenSelfDeployed = true;
  [SerializeField]
  private bool whenAllyDeployed;
  [SerializeField]
  private bool whenEnemyDeployed;
  private Hit hackyHit;
  private bool isAlreadyOnBoard;

  public override object GetMidBattleData() => (object) Battle.IsOnBoard(this.target);

  public override void RestoreMidBattleData(object data)
  {
    if (!(data is bool flag))
      return;
    this.isAlreadyOnBoard = flag && Battle.IsOnBoard(this.target);
  }

  protected override void Init()
  {
    this.OnEnable += new StatusEffectData.EffectEntityEventHandler(this.CheckEnable);
    this.OnCardMove += new StatusEffectData.EffectEntityEventHandler(this.CheckCardMove);
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

  private IEnumerator CheckEnable(Entity entity) => this.Run(this.GetTargets(this.hackyHit));

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

  private IEnumerator CheckCardMove(Entity entity) => this.Run(this.GetTargets(this.hackyHit));

  private static bool WasMovedOnToBoard(Entity entity) => Battle.IsOnBoard(entity) && !Battle.IsOnBoard(entity.preContainers);

  private static bool IsAlly(Entity a, Entity b) => (Object) a != (Object) b && a.owner.team == b.owner.team;

  private static bool IsEnemy(Entity a, Entity b) => a.owner.team != b.owner.team;
}
