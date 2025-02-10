// Decompiled with JetBrains decompiler
// Type: StatusEffectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;

#nullable disable
public abstract class StatusEffectData : DataFile
{
  public static ulong idCurrent;
  public ulong id;
  public StatusEffectData original;
  public bool isClone;
  public bool isStatus;
  public bool isReaction;
  public bool isKeyword;
  public string type;
  public string keyword;
  public string iconGroupName;
  public bool visible;
  public bool stackable = true;
  public bool offensive;
  public bool makesOffensive;
  public bool doesDamage;
  public bool canBeBoosted;
  [InfoBox("Description that will be added to the card", EInfoBoxType.Normal)]
  public LocalizedString textKey;
  public string textInsert;
  public int textOrder;
  [TextArea]
  [SerializeField]
  public string desc;
  [SerializeField]
  public string descColorHex;
  [SerializeField]
  public int descOrder;
  public KeywordData[] hiddenKeywords;
  public string applyFormat;
  public LocalizedString applyFormatKey;
  [InfoBox("\"Reaction\" Effects should be affected by snow", EInfoBoxType.Normal)]
  [SerializeField]
  public bool affectedBySnow;
  [InfoBox("Higher priority effects will run FIRST", EInfoBoxType.Normal)]
  public int eventPriority;
  public bool removeOnDiscard;
  public bool preventDeath;
  [Header("Constraints that must be met for this to be applied")]
  public TargetConstraint[] targetConstraints;
  public bool removing;
  public int temporary;
  [HideInInspector]
  public Entity applier;
  [HideInInspector]
  public Character applierOwner;
  [HideInInspector]
  public Entity target;
  [ReadOnly]
  public int count;

  public StatusEffectData Instantiate()
  {
    StatusEffectData original = this.GetOriginal();
    StatusEffectData statusEffectData = Object.Instantiate<StatusEffectData>(original);
    statusEffectData.id = StatusEffectData.idCurrent++;
    statusEffectData.name = this.name;
    statusEffectData.original = original;
    statusEffectData.isClone = true;
    return statusEffectData;
  }

  public StatusEffectData GetOriginal() => !this.isClone ? this : this.original;

  public bool HasDesc => !this.Instant && !this.textKey.IsEmpty;

  public bool HasDescOrIsKeyword => this.isKeyword || this.HasDesc;

  public string GetDesc(int amount, bool silenced = false)
  {
    string desc = Text.GetEffectText(this.textKey, this.textInsert, amount, silenced);
    if (!this.descColorHex.IsNullOrWhitespace())
      desc = "<color=#" + this.descColorHex + ">" + desc + "</color>";
    return desc;
  }

  public string GetPlainDesc() => this.desc;

  public string GetApplyFormat()
  {
    LocalizedString applyFormatKey = this.applyFormatKey;
    return applyFormatKey == null || applyFormatKey.IsEmpty ? (string) null : Text.HandleBracketTags(this.applyFormatKey.GetLocalizedString());
  }

  public virtual object GetMidBattleData() => (object) null;

  public virtual void RestoreMidBattleData(object data)
  {
  }

  public virtual bool Instant => false;

  public virtual bool CanStackActions => true;

  public bool CanPlayOn(Entity target)
  {
    foreach (TargetConstraint targetConstraint in this.targetConstraints)
    {
      if (!targetConstraint.Check(target))
        return false;
    }
    return true;
  }

  public virtual bool CanTrigger()
  {
    if (!this.target.enabled || this.target.silenced)
      return false;
    if (!this.affectedBySnow)
      return true;
    return !this.target.IsSnowed && !this.target.paused;
  }

  public bool IsNegativeStatusEffect() => this.offensive && this.visible && this.isStatus;

  public event StatusEffectData.EffectEventHandler OnBegin;

  public event StatusEffectData.EffectEventHandler OnEnd;

  public event StatusEffectData.EffectEntityEventHandler OnEnable;

  public event StatusEffectData.EffectEntityEventHandler OnDisable;

  public event StatusEffectData.EffectStackEventHandler OnStack;

  public event StatusEffectData.EffectEntityEventHandler OnTurnStart;

  public event StatusEffectData.EffectEntityEventHandler OnTurn;

  public event StatusEffectData.EffectEntityEventHandler OnTurnEnd;

  public event StatusEffectData.EffectHitEventHandler PreAttack;

  public event StatusEffectData.EffectHitEventHandler OnHit;

  public event StatusEffectData.EffectHitEventHandler PostHit;

  public event StatusEffectData.EffectHitEventHandler PostAttack;

  public event StatusEffectData.EffectApplyEventHandler OnApplyStatus;

  public event StatusEffectData.EffectApplyEventHandler PostApplyStatus;

  public event StatusEffectData.EffectEntityDeathEventHandler OnEntityDestroyed;

  public event StatusEffectData.EffectEntityEventHandler OnCardMove;

  public event StatusEffectData.EffectTriggerEventHandler PreTrigger;

  public event StatusEffectData.EffectCardPlayEventHandler PreCardPlayed;

  public event StatusEffectData.EffectCardPlayEventHandler OnCardPlayed;

  public event StatusEffectData.EffectEventHandler OnEffectBonusChanged;

  public event StatusEffectData.EffectActionPerformedHandler OnActionPerformed;

  public event StatusEffectData.EffectEntityEventHandler OnBuild;

  public virtual bool HasBeginRoutine => this.OnBegin != null;

  public virtual bool HasEndRoutine => this.OnEnd != null;

  public virtual bool HasEnableRoutine => this.OnEnable != null;

  public virtual bool HasDisableRoutine => this.OnDisable != null;

  public virtual bool HasStackRoutine => this.OnStack != null;

  public virtual bool HasTurnStartRoutine => this.OnTurnStart != null && this.HasActiveTarget;

  public virtual bool HasTurnRoutine => this.OnTurn != null && this.HasActiveTarget;

  public virtual bool HasTurnEndRoutine => this.OnTurnEnd != null && this.HasActiveTarget;

  public virtual bool HasPreAttackRoutine => this.PreAttack != null && this.HasActiveTarget;

  public virtual bool HasHitRoutine => this.OnHit != null && this.HasActiveTarget;

  public virtual bool HasPostHitRoutine => this.PostHit != null && this.HasActiveTarget;

  public virtual bool HasPostAttackRoutine => this.PostAttack != null && this.HasActiveTarget;

  public virtual bool HasApplyStatusRoutine => this.OnApplyStatus != null && this.HasActiveTarget;

  public virtual bool HasPostApplyStatusRoutine
  {
    get => this.PostApplyStatus != null && this.HasActiveTarget;
  }

  public virtual bool HasEntityDestroyedRoutine
  {
    get => this.OnEntityDestroyed != null && this.HasActiveTarget;
  }

  public virtual bool HasPreTriggerRoutine => this.PreTrigger != null && this.HasActiveTarget;

  public virtual bool HasPreCardPlayedRoutine => this.PreCardPlayed != null && this.HasActiveTarget;

  public virtual bool HasCardMoveRoutine => this.OnCardMove != null && this.HasActiveTarget;

  public virtual bool HasCardPlayedRoutine => this.OnCardPlayed != null && this.HasActiveTarget;

  public virtual bool HasEffectBonusChangedRoutine
  {
    get => this.OnEffectBonusChanged != null && this.HasActiveTarget;
  }

  public virtual bool HasActionPerformedRoutine
  {
    get => this.OnActionPerformed != null && this.HasActiveTarget;
  }

  public virtual bool HasBuildRoutine => this.OnBuild != null && this.HasActiveTarget;

  public virtual bool RunBeginEvent() => true;

  public virtual bool RunEndEvent() => true;

  public virtual bool RunEnableEvent(Entity entity) => true;

  public virtual bool RunDisableEvent(Entity entity) => true;

  public virtual bool RunStackEvent(int stacks) => true;

  public virtual bool RunTurnStartEvent(Entity entity) => true;

  public virtual bool RunTurnEvent(Entity entity) => true;

  public virtual bool RunTurnEndEvent(Entity entity) => true;

  public virtual bool RunPreAttackEvent(Hit hit) => true;

  public virtual bool RunHitEvent(Hit hit) => true;

  public virtual bool RunPostHitEvent(Hit hit) => true;

  public virtual bool RunPostAttackEvent(Hit hit) => true;

  public virtual bool RunApplyStatusEvent(StatusEffectApply apply) => true;

  public virtual bool RunPostApplyStatusEvent(StatusEffectApply apply) => true;

  public virtual bool RunEntityDestroyedEvent(Entity entity, DeathType deathType) => true;

  public virtual bool RunCardMoveEvent(Entity entity) => true;

  public virtual bool RunPreTriggerEvent(Trigger trigger) => true;

  public virtual bool RunPreCardPlayedEvent(Entity entity, Entity[] targets) => true;

  public virtual bool RunCardPlayedEvent(Entity entity, Entity[] targets) => true;

  public virtual bool RunEffectBonusChangedEvent() => true;

  public virtual bool RunActionPerformedEvent(PlayAction action) => true;

  public virtual bool RunBuildEvent(Entity entity) => true;

  public bool HasActiveTarget => (Object) this.target != (Object) null && this.target.enabled;

  public virtual IEnumerator BeginRoutine() => this.OnBegin();

  public virtual IEnumerator EndRoutine() => this.OnEnd();

  public virtual IEnumerator EnableRoutine(Entity entity) => this.OnEnable(entity);

  public virtual IEnumerator DisableRoutine(Entity entity) => this.OnDisable(entity);

  public virtual IEnumerator StackRoutine(int stacks) => this.OnStack(stacks);

  public virtual IEnumerator TurnStartRoutine(Entity entity) => this.OnTurnStart(entity);

  public virtual IEnumerator TurnRoutine(Entity entity) => this.OnTurn(entity);

  public virtual IEnumerator TurnEndRoutine(Entity entity) => this.OnTurnEnd(entity);

  public virtual IEnumerator PreAttackRoutine(Hit hit) => this.PreAttack(hit);

  public virtual IEnumerator HitRoutine(Hit hit) => this.OnHit(hit);

  public virtual IEnumerator PostHitRoutine(Hit hit) => this.PostHit(hit);

  public virtual IEnumerator PostAttackRoutine(Hit hit) => this.PostAttack(hit);

  public virtual IEnumerator ApplyStatusRoutine(StatusEffectApply apply)
  {
    return this.OnApplyStatus(apply);
  }

  public virtual IEnumerator PostApplyStatusRoutine(StatusEffectApply apply)
  {
    return this.PostApplyStatus(apply);
  }

  public virtual IEnumerator EntityDestroyedRoutine(Entity entity, DeathType deathType)
  {
    return this.OnEntityDestroyed(entity, deathType);
  }

  public virtual IEnumerator CardMoveRoutine(Entity entity) => this.OnCardMove(entity);

  public virtual IEnumerator PreTriggerRoutine(Trigger trigger) => this.PreTrigger(trigger);

  public virtual IEnumerator PreCardPlayedRoutine(Entity entity, Entity[] targets)
  {
    return this.PreCardPlayed(entity, targets);
  }

  public virtual IEnumerator CardPlayedRoutine(Entity entity, Entity[] targets)
  {
    return this.OnCardPlayed(entity, targets);
  }

  public virtual IEnumerator EffectBonusChangedRoutine() => this.OnEffectBonusChanged();

  public virtual IEnumerator ActionPerformedRoutine(PlayAction action)
  {
    return this.OnActionPerformed(action);
  }

  public virtual IEnumerator BuildRoutine(Entity entity) => this.OnBuild(entity);

  public void Apply(int count, Entity target, Entity applier)
  {
    this.count = count;
    this.target = target;
    this.applier = applier;
    target.statusEffects.Add(this);
    this.Init();
  }

  public virtual void Init()
  {
  }

  public IEnumerator CountDown(Entity entity, int amount)
  {
    if ((bool) (Object) this.target && this.target.enabled && (Object) entity == (Object) this.target)
      yield return (object) this.RemoveStacks(amount, false);
  }

  public virtual IEnumerator RemoveStacks(int amount, bool removeTemporary)
  {
    this.count -= amount;
    if (removeTemporary)
      this.temporary -= amount;
    if (this.count <= 0)
      yield return (object) this.Remove();
    this.target.PromptUpdate();
  }

  public IEnumerator Remove()
  {
    StatusEffectData statusEffectData = this;
    if (!statusEffectData.removing)
    {
      statusEffectData.removing = true;
      statusEffectData.target.statusEffects.Remove(statusEffectData);
      StatusEffectSystem.activeEffects.Remove(statusEffectData);
      statusEffectData.target.PromptUpdate();
      if (statusEffectData.RunEndEvent() && statusEffectData.HasEndRoutine)
        yield return (object) statusEffectData.EndRoutine();
      statusEffectData.Destroy();
    }
  }

  public void Destroy()
  {
    if (!(bool) (Object) this)
      return;
    Debug.Log((object) string.Format("[{0} {1}] removed from [{2}]", (object) this.name, (object) this.count, (bool) (Object) this.target ? (object) this.target.name : (object) "null"));
    StatusEffectSystem.activeEffects.Remove(this);
    Object.Destroy((Object) this);
  }

  public virtual int GetAmount()
  {
    if (!(bool) (Object) this.target || this.target.silenced)
      return 0;
    return !this.canBeBoosted ? this.count : Mathf.Max(0, Mathf.RoundToInt((float) (this.count + this.target.effectBonus) * this.target.effectFactor));
  }

  public Entity GetDamager()
  {
    if ((bool) (Object) this.applier)
      return this.applier;
    return !(bool) (Object) this.applierOwner || !(bool) (Object) this.applierOwner.entity ? (Entity) null : this.applierOwner.entity;
  }

  public CardContainer[] GetTargetContainers()
  {
    CardContainer[] containers = this.target.containers;
    return containers != null && containers.Length != 0 ? containers : this.target.preContainers;
  }

  public CardContainer[] GetTargetActualContainers()
  {
    List<CardContainer> actualContainers = this.target.actualContainers;
    return actualContainers != null && actualContainers.Count != 0 ? actualContainers.ToArray() : this.target.preActualContainers;
  }

  public delegate IEnumerator EffectEventHandler();

  public delegate IEnumerator EffectStackEventHandler(int stacks);

  public delegate IEnumerator EffectCharacterEventHandler(Character character);

  public delegate IEnumerator EffectEntityEventHandler(Entity entity);

  public delegate IEnumerator EffectEntityDeathEventHandler(Entity entity, DeathType deathType);

  public delegate IEnumerator EffectCardPlayEventHandler(Entity entity, Entity[] targets);

  public delegate IEnumerator EffectTriggerEventHandler(Trigger trigger);

  public delegate IEnumerator EffectCardMoveEventHandler(
    Entity entity,
    CardContainer[] fromContainers);

  public delegate IEnumerator EffectHitEventHandler(Hit hit);

  public delegate IEnumerator EffectApplyEventHandler(StatusEffectApply apply);

  public delegate IEnumerator EffectActionPerformedHandler(PlayAction action);
}
