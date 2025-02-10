// Decompiled with JetBrains decompiler
// Type: BattleLogSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;

#nullable disable
public class BattleLogSystem : GameSystem
{
  public List<BattleLog> list = new List<BattleLog>();
  public static readonly Dictionary<string, string> damageTypes = new Dictionary<string, string>()
  {
    {
      "shroom",
      "<sprite name=shroom>"
    },
    {
      "spikes",
      "<sprite name=teeth>"
    },
    {
      "overload",
      "<sprite name=overload>"
    }
  };
  [SerializeField]
  public LocalizedString logTurnKey;
  [SerializeField]
  public LocalizedString logHitKey;
  [SerializeField]
  public LocalizedString logDamageKey;
  [SerializeField]
  public LocalizedString logSpecialDamageKey;
  [SerializeField]
  public LocalizedString logDestroyKey;
  [SerializeField]
  public LocalizedString logConsumedKey;
  [SerializeField]
  public LocalizedString logEatenKey;
  [SerializeField]
  public LocalizedString logSacrificedKey;
  [SerializeField]
  public LocalizedString logBlockKey;
  [SerializeField]
  public LocalizedString logStatusKey;
  [SerializeField]
  public LocalizedString logStatusFromKey;
  [SerializeField]
  public LocalizedString logHealKey;
  [SerializeField]
  public LocalizedString logRestoredKey;
  [SerializeField]
  public LocalizedString logBoostKey;
  [SerializeField]
  public LocalizedString logDamageUpKey;
  [SerializeField]
  public LocalizedString logDamageUpSelfKey;
  [SerializeField]
  public LocalizedString logDamageDownKey;
  [SerializeField]
  public LocalizedString logDamageDownSelfKey;
  [SerializeField]
  public LocalizedString logHealthUpKey;
  [SerializeField]
  public LocalizedString logHealthUpSelfKey;
  [SerializeField]
  public LocalizedString logHealthDownKey;
  [SerializeField]
  public LocalizedString logHealthDownSelfKey;
  [SerializeField]
  public LocalizedString logCounterUpKey;
  [SerializeField]
  public LocalizedString logCounterUpSelfKey;
  [SerializeField]
  public LocalizedString logCounterDownKey;
  [SerializeField]
  public LocalizedString logCounterDownSelfKey;
  [SerializeField]
  public LocalizedString logEnterBattleKey;
  [SerializeField]
  public LocalizedString logRecalledKey;
  [SerializeField]
  public LocalizedString logSummonedKey;
  [SerializeField]
  public LocalizedString logBattleWinKey;
  [SerializeField]
  public LocalizedString logBattleLoseKey;
  [SerializeField]
  public LocalizedString logFleeKey;

  public void OnEnable()
  {
    global::Events.OnBattlePhaseStart += new UnityAction<Battle.Phase>(this.BattlePhaseStart);
    global::Events.OnBattleTurnEnd += new UnityAction<int>(this.TurnEnd);
    global::Events.OnEntityHit += new UnityAction<global::Hit>(this.Hit);
    global::Events.OnEntityMove += new UnityAction<Entity>(this.EntityMove);
    global::Events.OnStatusEffectApplied += new UnityAction<StatusEffectApply>(this.StatusApplied);
    global::Events.OnEntityPostHit += new UnityAction<global::Hit>(this.PostHit);
    global::Events.OnEntityKilled += new UnityAction<Entity, DeathType>(this.EntityKilled);
    global::Events.OnEntityFlee += new UnityAction<Entity>(this.EntityFlee);
    global::Events.OnBattleEnd += new UnityAction(this.BattleEnd);
  }

  public void OnDisable()
  {
    global::Events.OnBattlePhaseStart -= new UnityAction<Battle.Phase>(this.BattlePhaseStart);
    global::Events.OnBattleTurnEnd -= new UnityAction<int>(this.TurnEnd);
    global::Events.OnEntityHit -= new UnityAction<global::Hit>(this.Hit);
    global::Events.OnEntityMove -= new UnityAction<Entity>(this.EntityMove);
    global::Events.OnStatusEffectApplied -= new UnityAction<StatusEffectApply>(this.StatusApplied);
    global::Events.OnEntityPostHit -= new UnityAction<global::Hit>(this.PostHit);
    global::Events.OnEntityKilled -= new UnityAction<Entity, DeathType>(this.EntityKilled);
    global::Events.OnEntityFlee -= new UnityAction<Entity>(this.EntityFlee);
    global::Events.OnBattleEnd -= new UnityAction(this.BattleEnd);
  }

  public void BattlePhaseStart(Battle.Phase phase)
  {
    if (phase != Battle.Phase.Init)
      return;
    this.list.Clear();
  }

  public void TurnEnd(int turnNumber)
  {
    if (References.Battle.ended)
      return;
    this.Log(this.logTurnKey, BattleLogType.Turn, (object) (turnNumber + 1));
  }

  public void Hit(global::Hit hit)
  {
    if (!hit.countsAsHit || !hit.Offensive)
      return;
    if (!hit.BasicHit || !(bool) (Object) hit.attacker || !(bool) (Object) hit.attacker.data)
      this.LogDamage(hit.target, hit.damage + hit.damageBlocked, hit.damageType);
    else
      this.LogHit(hit.attacker, hit.target, hit.damage + hit.damageBlocked, hit.damageType);
  }

  public void EntityMove(Entity entity)
  {
    if (!Battle.IsOnBoard(entity) || Battle.IsOnBoard(entity.preContainers))
      return;
    this.Log(this.logEnterBattleKey, BattleLogType.Enter, (object) BattleLogSystem.GetBattleEntity(entity));
  }

  public void StatusApplied(StatusEffectApply apply)
  {
    if (!(bool) (Object) apply.effectData || apply.effectData.type.IsNullOrWhitespace() || apply.count <= 0)
      return;
    switch (apply.effectData.type)
    {
      case "counter down":
      case "max counter down":
        this.LogCounterDown(apply.applier, apply.target, apply.count);
        break;
      case "counter up":
      case "max counter up":
        this.LogCounterUp(apply.applier, apply.target, apply.count);
        break;
      case "damage down":
        this.LogDamageDown(apply.applier, apply.target, apply.count);
        break;
      case "damage up":
        this.LogDamageUp(apply.applier, apply.target, apply.count);
        break;
      case "heal":
        this.LogHeal(apply.applier, apply.target);
        break;
      case "max health down":
        this.LogHealthDown(apply.applier, apply.target, apply.count);
        break;
      case "max health up":
        this.LogHealthUp(apply.applier, apply.target, apply.count);
        break;
      default:
        this.LogStatus(apply.applier, apply.target, apply.effectData, apply.count);
        break;
    }
  }

  public void PostHit(global::Hit hit)
  {
    if (!hit.countsAsHit || !hit.Offensive || hit.damageBlocked <= 0)
      return;
    this.LogBlock(hit.target, hit.damageBlocked);
  }

  public void EntityKilled(Entity entity, DeathType deathType)
  {
    if (deathType != DeathType.Consume)
    {
      if (DeathSystem.KilledByOwnTeam(entity))
        this.Log(this.logSacrificedKey, BattleLogType.Die, (object) BattleLogSystem.GetBattleEntity(entity));
      else
        this.Log(this.logDestroyKey, BattleLogType.Die, (object) BattleLogSystem.GetBattleEntity(entity));
    }
    else
      this.Log(this.logConsumedKey, BattleLogType.Consume, (object) BattleLogSystem.GetBattleEntity(entity));
  }

  public void EntityFlee(Entity entity)
  {
    this.Log(this.logFleeKey, BattleLogType.Flee, (object) BattleLogSystem.GetBattleEntity(entity));
  }

  public void BattleEnd()
  {
    if ((Object) References.Battle.winner == (Object) References.Battle.player)
      this.Log(this.logBattleWinKey, BattleLogType.Win);
    else
      this.Log(this.logBattleLoseKey, BattleLogType.Win);
  }

  public void LogHit(Entity attacker, Entity target, int damage, string damageType)
  {
    if (!(bool) (Object) target)
      return;
    this.Log(this.logHitKey, BattleLogType.Attack, (object) BattleLogSystem.GetBattleEntity(attacker), (object) BattleLogSystem.GetBattleEntity(target), (object) damage);
  }

  public void LogDamage(Entity target, int damage, string damageType)
  {
    if (damage <= 0)
      return;
    string str;
    if (BattleLogSystem.damageTypes.TryGetValue(damageType, out str))
      this.Log(this.logSpecialDamageKey, BattleLogType.Debuff, (object) BattleLogSystem.GetBattleEntity(target), (object) damage, (object) str);
    else
      this.Log(this.logDamageKey, BattleLogType.Debuff, (object) BattleLogSystem.GetBattleEntity(target), (object) damage);
  }

  public void LogBlock(Entity target, int damageBlocked)
  {
    this.Log(this.logBlockKey, BattleLogType.Buff, (object) BattleLogSystem.GetBattleEntity(target), (object) damageBlocked);
  }

  public void LogStatus(Entity applier, Entity target, StatusEffectData status, int count)
  {
    if (!status.isStatus)
      return;
    BattleLogType type = status.offensive ? BattleLogType.Debuff : BattleLogType.Buff;
    if ((bool) (Object) applier && (long) applier.data.id != (long) target.data.id)
      this.Log(this.logStatusFromKey, type, (object) BattleLogSystem.GetBattleEntity(applier), (object) BattleLogSystem.GetBattleEntity(target), (object) count, (object) status.type);
    else
      this.Log(this.logStatusKey, type, (object) BattleLogSystem.GetBattleEntity(target), (object) count, (object) status.type);
  }

  public void LogHeal(Entity healer, Entity target)
  {
    this.Log(this.logHealKey, BattleLogType.Heal, (object) BattleLogSystem.GetBattleEntity(healer), (object) BattleLogSystem.GetBattleEntity(target));
  }

  public void LogRestore(Entity target, int amount)
  {
    this.Log(this.logRestoredKey, BattleLogType.Heal, (object) BattleLogSystem.GetBattleEntity(target), (object) amount);
  }

  public void LogDamageUp(Entity applier, Entity target, int amount)
  {
    if (!(bool) (Object) applier || (Object) applier == (Object) target)
      this.Log(this.logDamageUpSelfKey, BattleLogType.Buff, (object) BattleLogSystem.GetBattleEntity(target), (object) amount);
    else
      this.Log(this.logDamageUpKey, BattleLogType.Buff, (object) BattleLogSystem.GetBattleEntity(applier), (object) BattleLogSystem.GetBattleEntity(target), (object) amount);
  }

  public void LogDamageDown(Entity applier, Entity target, int amount)
  {
    if (!(bool) (Object) applier || (Object) applier == (Object) target)
      this.Log(this.logDamageDownSelfKey, BattleLogType.Debuff, (object) BattleLogSystem.GetBattleEntity(target), (object) amount);
    else
      this.Log(this.logDamageDownKey, BattleLogType.Debuff, (object) BattleLogSystem.GetBattleEntity(applier), (object) BattleLogSystem.GetBattleEntity(target), (object) amount);
  }

  public void LogHealthUp(Entity applier, Entity target, int amount)
  {
    if (!(bool) (Object) applier || (Object) applier == (Object) target)
      this.Log(this.logHealthUpSelfKey, BattleLogType.Buff, (object) BattleLogSystem.GetBattleEntity(target), (object) amount);
    else
      this.Log(this.logHealthUpKey, BattleLogType.Buff, (object) BattleLogSystem.GetBattleEntity(applier), (object) BattleLogSystem.GetBattleEntity(target), (object) amount);
  }

  public void LogHealthDown(Entity applier, Entity target, int amount)
  {
    if (!(bool) (Object) applier || (Object) applier == (Object) target)
      this.Log(this.logHealthDownSelfKey, BattleLogType.Debuff, (object) BattleLogSystem.GetBattleEntity(target), (object) amount);
    else
      this.Log(this.logHealthDownKey, BattleLogType.Debuff, (object) BattleLogSystem.GetBattleEntity(applier), (object) BattleLogSystem.GetBattleEntity(target), (object) amount);
  }

  public void LogCounterUp(Entity applier, Entity target, int amount)
  {
    if (!(bool) (Object) applier || (Object) applier == (Object) target)
      this.Log(this.logCounterUpSelfKey, BattleLogType.Debuff, (object) BattleLogSystem.GetBattleEntity(target), (object) amount);
    else
      this.Log(this.logCounterUpKey, BattleLogType.Debuff, (object) BattleLogSystem.GetBattleEntity(applier), (object) BattleLogSystem.GetBattleEntity(target), (object) amount);
  }

  public void LogCounterDown(Entity applier, Entity target, int amount)
  {
    if (!(bool) (Object) applier || (Object) applier == (Object) target)
      this.Log(this.logCounterDownSelfKey, BattleLogType.Buff, (object) BattleLogSystem.GetBattleEntity(target), (object) amount);
    else
      this.Log(this.logCounterDownKey, BattleLogType.Buff, (object) BattleLogSystem.GetBattleEntity(applier), (object) BattleLogSystem.GetBattleEntity(target), (object) amount);
  }

  public void Log(LocalizedString textKey, BattleLogType type, params object[] args)
  {
    this.list.Add(new BattleLog()
    {
      textKey = textKey,
      type = type,
      args = args
    });
  }

  public static BattleEntity GetBattleEntity(Entity entity)
  {
    BattleEntity battleEntity = new BattleEntity()
    {
      cardType = entity.data.cardType.name,
      friendly = entity.owner.team == References.Player.team,
      forceTitle = entity.data.forceTitle
    };
    if (battleEntity.forceTitle.IsNullOrWhitespace())
    {
      if (entity.data.titleKey.IsEmpty)
        battleEntity.forceTitle = entity.data.titleFallback;
      else
        battleEntity.titleKey = entity.data.titleKey;
    }
    return battleEntity;
  }
}
