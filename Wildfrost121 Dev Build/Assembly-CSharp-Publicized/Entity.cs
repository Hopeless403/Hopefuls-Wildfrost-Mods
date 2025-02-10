// Decompiled with JetBrains decompiler
// Type: Entity
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using Dead;
using NaughtyAttributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
public class Entity : MonoBehaviourCacheTransform, IPoolable
{
  public bool inPlay = true;
  public CardData _data;
  public EntityDisplay display;
  public int height = 1;
  public bool paused;
  [HorizontalLine(2f, EColor.Gray)]
  public Wobbler wobbler;
  public Flipper flipper;
  public UINavigationItem uINavigationItem;
  public CurveAnimator curveAnimator;
  public CardIdleAnimation imminentAnimation;
  [Required(null)]
  public Transform offset;
  [HorizontalLine(2f, EColor.Gray)]
  [ReadOnly]
  public bool dragging;
  [ReadOnly]
  public int blockRecall;
  [SerializeField]
  [ReadOnly]
  public List<CardContainer> _containers;
  public CardContainer[] _preContainers;
  public bool alive = true;
  public Character owner;
  public SplatterSurface splatterSurface;
  public bool inCardPool;
  public bool returnToPool = true;
  [HorizontalLine(2f, EColor.Gray)]
  public List<CardData.StatusEffectStacks> attackEffects;
  public List<StatusEffectData> statusEffects;
  public Stat damage;
  public SafeInt tempDamage;
  public Stat hp;
  public Stat counter;
  public Stat uses;
  public int effectBonus;
  public float effectFactor = 1f;
  [ReadOnly]
  public Hit lastHit;
  public bool promptUpdate;
  [ReadOnly]
  public Vector3 random3;
  public bool forceKill;
  public TargetMode targetMode;
  public int positionPriority = 1;
  [ReadOnly]
  public bool startingEffectsApplied;
  [HideInInspector]
  public Entity triggeredBy;
  public int cannotBeHitCount;
  public int silenceCount;
  public readonly List<Entity.TraitStacks> traits = new List<Entity.TraitStacks>();
  public Canvas canvas;
  public int traitUpdateRunning;

  public CardData data
  {
    get => this._data;
    set
    {
      this._data = value;
      if (!(bool) (UnityEngine.Object) this._data)
        return;
      if (!this._data.canBeHit)
        ++this.cannotBeHitCount;
      this.targetMode = this._data.targetMode;
    }
  }

  public CardContainer[] containers
  {
    get
    {
      List<CardContainer> containers = this._containers;
      return containers == null ? (CardContainer[]) null : containers.Select<CardContainer, CardContainer>((Func<CardContainer, CardContainer>) (c => c.Group)).ToArray<CardContainer>();
    }
  }

  public List<CardContainer> actualContainers => this._containers;

  public CardContainer[] preContainers
  {
    get
    {
      CardContainer[] preContainers = this._preContainers;
      return preContainers == null ? (CardContainer[]) null : ((IEnumerable<CardContainer>) preContainers).Select<CardContainer, CardContainer>((Func<CardContainer, CardContainer>) (c => c.Group)).ToArray<CardContainer>();
    }
  }

  public CardContainer[] preActualContainers => this._preContainers;

  public void AddTo(CardContainer container) => this._containers.Add(container);

  public void RemoveFrom(CardContainer container) => this._containers.Remove(container);

  public bool NeedsTarget => this.targetMode.NeedsTarget && this.data.needsTarget;

  public bool canBeHit => this.cannotBeHitCount <= 0;

  public bool silenced => this.silenceCount > 0;

  public int DrawOrder
  {
    get
    {
      if (!(bool) (UnityEngine.Object) this.canvas && (bool) (UnityEngine.Object) this.display)
        this.canvas = this.display.GetCanvas();
      return !((UnityEngine.Object) this.canvas != (UnityEngine.Object) null) ? 0 : this.canvas.sortingOrder;
    }
    set
    {
      if (!(bool) (UnityEngine.Object) this.canvas && (bool) (UnityEngine.Object) this.display)
        this.canvas = this.display.GetCanvas();
      if (!(bool) (UnityEngine.Object) this.canvas)
        return;
      this.canvas.overrideSorting = !value.Equals(0);
      if (!this.canvas.overrideSorting)
        return;
      this.canvas.sortingOrder = value;
      Canvas componentInParent = this.GetComponentInParent<Canvas>();
      if (!(bool) (UnityEngine.Object) componentInParent)
        return;
      this.canvas.sortingLayerID = componentInParent.sortingLayerID;
    }
  }

  public List<Entity> GetAllAllies()
  {
    List<Entity> cardsOnBoard = Battle.GetCardsOnBoard(this.owner);
    cardsOnBoard.Remove(this);
    return cardsOnBoard;
  }

  public List<Entity> GetAllies()
  {
    List<Entity> allies = new List<Entity>();
    foreach (CardContainer row in Battle.instance.GetRows(this.owner))
    {
      for (int index = 0; index < row.Count; ++index)
      {
        Entity entity = row[index];
        if ((UnityEngine.Object) entity != (UnityEngine.Object) this)
          allies.Add(entity);
      }
    }
    return allies;
  }

  public List<Entity> GetAlliesInRow()
  {
    List<Entity> alliesInRow = new List<Entity>();
    foreach (CardContainer container in this.containers)
    {
      for (int index = 0; index < container.Count; ++index)
      {
        Entity entity = container[index];
        if ((UnityEngine.Object) entity != (UnityEngine.Object) this)
          alliesInRow.Add(entity);
      }
    }
    return alliesInRow;
  }

  public List<Entity> GetAlliesInRow(int rowIndex)
  {
    List<Entity> alliesInRow = new List<Entity>();
    foreach (Entity entity in References.Battle.GetRow(this.owner, rowIndex))
    {
      if ((UnityEngine.Object) entity != (UnityEngine.Object) this)
        alliesInRow.Add(entity);
    }
    return alliesInRow;
  }

  public List<Entity> GetAllEnemies() => Battle.GetCardsOnBoard(Battle.GetOpponent(this.owner));

  public List<Entity> GetEnemies()
  {
    List<Entity> enemies = new List<Entity>();
    List<CardContainer> cardContainerList = new List<CardContainer>();
    foreach (KeyValuePair<Character, List<CardContainer>> row in Battle.instance.rows)
    {
      if ((UnityEngine.Object) row.Key != (UnityEngine.Object) this.owner)
        cardContainerList.AddRange((IEnumerable<CardContainer>) Battle.instance.GetRows(row.Key));
    }
    foreach (CardContainer cardContainer in cardContainerList)
    {
      foreach (Entity entity in cardContainer)
      {
        if ((UnityEngine.Object) entity != (UnityEngine.Object) this && !enemies.Contains(entity))
          enemies.Add(entity);
      }
    }
    return enemies;
  }

  public List<Entity> GetEnemiesInRow(int rowIndex)
  {
    List<Entity> enemiesInRow = new List<Entity>();
    if (this.containers != null && rowIndex >= 0)
    {
      List<CardContainer> cardContainerList = new List<CardContainer>();
      foreach (KeyValuePair<Character, List<CardContainer>> row in Battle.instance.rows)
      {
        if ((UnityEngine.Object) row.Key != (UnityEngine.Object) this.owner)
          cardContainerList.Add(Battle.instance.GetRow(row.Key, rowIndex));
      }
      foreach (CardContainer cardContainer in cardContainerList)
      {
        foreach (Entity entity in cardContainer)
          enemiesInRow.Add(entity);
      }
    }
    return enemiesInRow;
  }

  public StatusEffectData FindStatus(string type)
  {
    return this.statusEffects.Find((Predicate<StatusEffectData>) (a => a.type == type));
  }

  public StatusEffectData FindStatus(StatusEffectData dataType)
  {
    return this.statusEffects.Find((Predicate<StatusEffectData>) (a => a.name == dataType.name));
  }

  public IEnumerator ClearStatuses()
  {
    for (int i = this.statusEffects.Count - 1; i >= 0; --i)
      yield return (object) this.statusEffects[i].Remove();
    this.statusEffects.Clear();
    this.startingEffectsApplied = false;
  }

  public int SnowAmount()
  {
    StatusEffectData status = this.FindStatus("snow");
    return !(bool) (UnityEngine.Object) status ? 0 : status.count;
  }

  public bool IsSnowed => this.SnowAmount() > 0;

  public Vector3 GetScaleFromContainers()
  {
    if (this.containers == null || this.containers.Length == 0)
      return Vector3.one;
    Vector3 zero = Vector3.zero;
    foreach (CardContainer container in this.containers)
      zero += container.GetChildScale(this);
    return zero / (float) this._containers.Count;
  }

  public Vector3 GetPositionFromContainers()
  {
    Vector3 zero = Vector3.zero;
    foreach (CardContainer container in this.containers)
      zero += container.transform.position + container.GetChildPosition(this);
    return zero / (float) this._containers.Count;
  }

  public void RemoveFromContainers()
  {
    LeanTween.cancel(this.gameObject);
    this._preContainers = this.actualContainers.ToArray();
    foreach (CardContainer container in this.containers)
    {
      if ((bool) (UnityEngine.Object) container)
        container.Remove(this);
    }
  }

  public void ResetDrawOrder()
  {
    int a = 0;
    foreach (CardContainer container in this.containers)
      a = Mathf.Max(a, container.GetChildDrawOrder(this));
    this.DrawOrder = a;
  }

  public bool InHand()
  {
    return (bool) (UnityEngine.Object) this.owner && (bool) (UnityEngine.Object) this.owner.handContainer && this._containers.Count == 1 && (UnityEngine.Object) this.containers[0] == (UnityEngine.Object) this.owner.handContainer;
  }

  public bool InContainer(CardContainer container)
  {
    foreach (UnityEngine.Object actualContainer in this.actualContainers)
    {
      if (actualContainer == (UnityEngine.Object) container)
        return true;
    }
    return false;
  }

  public bool InContainerGroup(CardContainer container)
  {
    foreach (UnityEngine.Object container1 in this.containers)
    {
      if (container1 == (UnityEngine.Object) container)
        return true;
    }
    return false;
  }

  public void Awake() => this.random3 = PettyRandom.Vector3();

  public void Update()
  {
    if (!this.promptUpdate || !this.enabled)
      return;
    this.promptUpdate = false;
    if ((bool) (UnityEngine.Object) this.display)
      CoroutineManager.Start(!this.display.init ? this.display.UpdateData() : this.display.UpdateDisplay());
    if (!this.alive || !this.ReadyToDie())
      return;
    this.forceKill = false;
    CoroutineManager.Start(this.Kill());
  }

  public bool ReadyToDie()
  {
    if (this.forceKill)
      return true;
    return this.hp.current <= 0 && (!(bool) (UnityEngine.Object) this.data || (bool) (UnityEngine.Object) this.data && this.data.cardType.canDie) && !this.statusEffects.Exists((Predicate<StatusEffectData>) (a => a.preventDeath));
  }

  public IEnumerator Reset()
  {
    yield return (object) this.ClearStatuses();
    if (this.display is Card display)
      yield return (object) display.UpdateData(false);
  }

  [Button(null, EButtonEnableMode.Always)]
  public void PromptUpdate() => this.promptUpdate = true;

  public bool CanPlayOn(Entity target, bool ignoreRowCheck = false)
  {
    if (this.data.playOnSlot || !this.NeedsTarget || this.targetMode.TargetRow && !ignoreRowCheck || (UnityEngine.Object) target == (UnityEngine.Object) this || this.damage.current + this.tempDamage.Value > 0 && !target.canBeHit || !this.targetMode.CanTarget(target))
      return false;
    bool flag = this.owner.team == target.owner.team;
    if (!this.data.canPlayOnEnemy && !flag || !this.data.canPlayOnFriendly & flag || !this.data.canPlayOnHand && target.containers.Contains<CardContainer>(this.owner.handContainer) || !this.data.canPlayOnBoard && Battle.IsOnBoard(target))
      return false;
    TargetConstraint[] targetConstraints = this.data.targetConstraints;
    return (targetConstraints == null || targetConstraints.Length <= 0 || !((IEnumerable<TargetConstraint>) this.data.targetConstraints).Any<TargetConstraint>((Func<TargetConstraint, bool>) (c => !c.Check(target)))) && (this.damage.max > 0 || !this.attackEffects.Any<CardData.StatusEffectStacks>((Func<CardData.StatusEffectStacks, bool>) (s => !s.data.CanPlayOn(target))));
  }

  public bool CanPlayOn(CardContainer container, bool ignoreRowCheck = false)
  {
    if (!(bool) (UnityEngine.Object) container)
      return false;
    if ((UnityEngine.Object) container == (UnityEngine.Object) this.owner.discardContainer && this.CanRecall())
      return true;
    switch (this.data.playType)
    {
      case Card.PlayType.Play:
        if (!this.NeedsTarget || !container.canPlayOn)
          return false;
        if (this.targetMode.TargetRow && !ignoreRowCheck)
        {
          if (container is CardSlotLane && this.data.canPlayOnBoard && (!this.data.playOnSlot || container.Count < container.max))
          {
            if (!this.data.playOnSlot)
            {
              Entity[] targets = this.targetMode.GetTargets(this, (Entity) null, container);
              if (targets == null || targets.Length <= 0)
                return false;
            }
            return !((UnityEngine.Object) container.owner == (UnityEngine.Object) this.owner) ? this.data.canPlayOnEnemy : this.data.canPlayOnFriendly;
          }
        }
        else if (this.data.playOnSlot && container is CardSlot && this.data.canPlayOnBoard && container.Group is CardSlotLane group1)
        {
          if (!container.Empty)
          {
            if (this.owner.team != container.owner.team)
              return false;
            int count = group1.Count;
            int max = group1.max;
            if (this.data.canShoveToOtherRow)
            {
              foreach (CardContainer cardContainer in group1.shoveTo)
              {
                count += cardContainer.Count;
                max += cardContainer.max;
              }
            }
            if (count >= max)
              return false;
          }
          return !((UnityEngine.Object) group1.owner == (UnityEngine.Object) this.owner) ? this.data.canPlayOnEnemy : this.data.canPlayOnFriendly;
        }
        return false;
      case Card.PlayType.Place:
        if (!(container is CardSlot cardSlot) || !container.canBePlacedOn || !((UnityEngine.Object) container.owner == (UnityEngine.Object) this.owner))
          return false;
        switch (this.positionPriority)
        {
          case -1:
          case 2:
            return cardSlot.Group is CardSlotLane group2 && group2.slots.IndexOf(cardSlot) == (this.positionPriority == -1 ? group2.slots.Count - 1 : 0);
          default:
            return true;
        }
      default:
        return false;
    }
  }

  public IEnumerator Kill(DeathType deathType = DeathType.Normal)
  {
    Entity entity = this;
    if (entity.alive)
    {
      entity.alive = false;
      if ((bool) (UnityEngine.Object) entity.display && (bool) (UnityEngine.Object) entity.display.hover)
        entity.display.hover.Disable();
      LeanTween.cancel(entity.gameObject);
      Routine.Clump clump = new Routine.Clump();
      clump.Add(StatusEffectSystem.EntityDestroyedEvent(entity, deathType));
      yield return (object) null;
      entity.RemoveFromContainers();
      entity.transform.SetParent((Transform) null);
      Events.InvokeEntityKilled(entity, deathType);
      yield return (object) clump.WaitForEnd();
      clump = (Routine.Clump) null;
    }
  }

  public void OnDisable() => Events.InvokeEntityDisabled(this);

  public void OnDestroy()
  {
    Events.InvokeEntityDisabled(this);
    Events.InvokeEntityDestroyed(this);
    if (this.statusEffects.Count <= 0)
      return;
    Debug.Log((object) string.Format("[{0}] Destroyed! Removing [{1}] status effects...", (object) this, (object) this.statusEffects.Count));
    foreach (StatusEffectData statusEffectData in this.statusEffects.Where<StatusEffectData>((Func<StatusEffectData, bool>) (status => (bool) (UnityEngine.Object) status)))
      statusEffectData.Destroy();
    this.statusEffects.Clear();
  }

  public Entity.TraitStacks GainTrait(TraitData traitData, int count, bool temporary = false)
  {
    Entity.TraitStacks traitStacks1 = this.traits.FirstOrDefault<Entity.TraitStacks>((Func<Entity.TraitStacks, bool>) (a => (UnityEngine.Object) a.data == (UnityEngine.Object) traitData));
    if (traitStacks1 != null)
    {
      traitStacks1.count += count;
      if (temporary)
        traitStacks1.tempCount += count;
      this.traits.Remove(traitStacks1);
      this.traits.Add(traitStacks1);
      return traitStacks1;
    }
    Entity.TraitStacks traitStacks2 = new Entity.TraitStacks(traitData, count, temporary);
    this.traits.Add(traitStacks2);
    return traitStacks2;
  }

  public IEnumerator UpdateTraits(Entity.TraitStacks moveToFront = null)
  {
    Entity entity = this;
    if (entity.traitUpdateRunning > 0)
    {
      yield return (object) new WaitUntil(new Func<bool>(entity.\u003CUpdateTraits\u003Eb__95_0));
      if (!entity.IsAliveAndExists())
        yield break;
    }
    ++entity.traitUpdateRunning;
    if (moveToFront != null)
    {
      entity.traits.Remove(moveToFront);
      entity.traits.Insert(0, moveToFront);
    }
    int i;
    for (i = entity.traits.Count - 1; i >= 0; --i)
    {
      Entity.TraitStacks trait = entity.traits[i];
      if (trait.count <= 0)
      {
        Debug.Log((object) ("> [" + entity.name + " " + trait.data.name + "] Removed! Removing effects [" + string.Join<StatusEffectData>(", ", (IEnumerable<StatusEffectData>) trait.passiveEffects) + "]"));
        entity.traits.RemoveAt(i);
        yield return (object) trait.DisableEffects();
      }
    }
    foreach (Entity.TraitStacks trait in entity.traits)
      trait.silenceCount = 0;
    for (int index1 = entity.traits.Count - 1; index1 >= 0; --index1)
    {
      Entity.TraitStacks trait1 = entity.traits[index1];
      TraitData[] overrides = trait1.data.overrides;
      if (overrides != null && overrides.Length > 0)
      {
        for (int index2 = index1 - 1; index2 >= 0; --index2)
        {
          Entity.TraitStacks trait2 = entity.traits[index2];
          if (trait1.data.overrides.Contains<TraitData>(trait2.data))
            ++trait2.silenceCount;
        }
      }
    }
    foreach (Entity.TraitStacks traitStacks in entity.traits.Where<Entity.TraitStacks>((Func<Entity.TraitStacks, bool>) (a => a.MustDisable)))
    {
      Debug.Log((object) ("> [" + entity.name + " " + traitStacks.data.name + "] Silenced! Removing effects [" + string.Join<StatusEffectData>(", ", (IEnumerable<StatusEffectData>) traitStacks.passiveEffects) + "]"));
      yield return (object) traitStacks.DisableEffects();
    }
    Entity.TraitStacks t;
    foreach (Entity.TraitStacks traitStacks in entity.traits.Where<Entity.TraitStacks>((Func<Entity.TraitStacks, bool>) (a => a.ReadyToInit || a.MustEnable)))
    {
      t = traitStacks;
      yield return (object) t.EnableEffects(entity);
      Debug.Log((object) ("> [" + entity.name + " " + t.data.name + "] Enabled! Adding effects [" + string.Join<StatusEffectData>(", ", (IEnumerable<StatusEffectData>) t.passiveEffects) + "]"));
      t = (Entity.TraitStacks) null;
    }
    foreach (Entity.TraitStacks traitStacks in entity.traits.Where<Entity.TraitStacks>((Func<Entity.TraitStacks, bool>) (a => a.StacksRemoved)))
    {
      t = traitStacks;
      i = t.init - t.count;
      yield return (object) t.RemoveEffectStacks(entity, i);
      Debug.Log((object) string.Format("> [{0} {1}] Removing {2} Stacks of effects [{3}]", (object) entity.name, (object) t.data.name, (object) i, (object) string.Join<StatusEffectData>(", ", (IEnumerable<StatusEffectData>) t.passiveEffects)));
      t = (Entity.TraitStacks) null;
    }
    --entity.traitUpdateRunning;
  }

  public void OnGetFromPool()
  {
    this.inCardPool = false;
    this.wobbler.OnGetFromPool();
    this.flipper.OnGetFromPool();
    this.curveAnimator.OnGetFromPool();
    this.splatterSurface.OnGetFromPool();
    this.offset.localScale = Vector3.one;
    this.offset.SetLocalPositionAndRotation(Vector3.zero, Quaternion.identity);
    this._preContainers = (CardContainer[]) null;
  }

  public void OnReturnToPool()
  {
    this.inCardPool = true;
    Events.InvokeEntityDisabled(this);
    Events.InvokeEntityDestroyed(this);
    if (this.statusEffects.Count > 0)
    {
      Debug.Log((object) string.Format("[{0}] Destroyed! Removing [{1}] status effects...", (object) this, (object) this.statusEffects.Count));
      foreach (StatusEffectData statusEffect in this.statusEffects)
      {
        if ((bool) (UnityEngine.Object) statusEffect)
          statusEffect.Destroy();
      }
      this.statusEffects.Clear();
    }
    if (this.GetComponent<IRemoveWhenPooled>() is MonoBehaviour component)
      UnityEngine.Object.Destroy((UnityEngine.Object) component);
    this.enabled = false;
    this.dragging = false;
    this.blockRecall = 0;
    this.alive = true;
    this.attackEffects.Clear();
    this.statusEffects.Clear();
    this.traits.Clear();
    this.effectBonus = 0;
    this.effectFactor = 1f;
    this.tempDamage.Value = 0;
    this.forceKill = false;
    this.startingEffectsApplied = false;
    this.cannotBeHitCount = 0;
    this.silenceCount = 0;
    this._containers.Clear();
    this.lastHit = (Hit) null;
    this.wobbler.OnReturnToPool();
    this.flipper.OnReturnToPool();
    this.curveAnimator.OnReturnToPool();
    this.splatterSurface.OnReturnToPool();
    this.positionPriority = 1;
    this.promptUpdate = false;
    this.triggeredBy = (Entity) null;
    this.uINavigationItem.enabled = true;
    LeanTween.cancel(this.gameObject);
  }

  [CompilerGenerated]
  public bool \u003CUpdateTraits\u003Eb__95_0() => this.traitUpdateRunning <= 0;

  [Serializable]
  public class TraitStacks
  {
    public TraitData data;
    public int count;
    public int silenceCount;
    public int tempCount;
    public int init;
    public bool effectsDisabled;
    public readonly List<StatusEffectData> passiveEffects = new List<StatusEffectData>();

    public bool silenced => this.silenceCount > 0;

    public bool ReadyToInit => this.init < this.count && !this.silenced;

    public bool MustDisable => this.init == this.count && this.silenced && !this.effectsDisabled;

    public bool MustEnable => this.init == this.count && !this.silenced && this.effectsDisabled;

    public bool StacksRemoved => this.count < this.init;

    public TraitStacks(TraitData data, int count, bool temporary = false)
    {
      this.data = data;
      this.count = count;
      if (!temporary)
        return;
      this.tempCount = count;
    }

    public IEnumerator DisableEffects()
    {
      foreach (StatusEffectData passiveEffect in this.passiveEffects)
        yield return (object) passiveEffect.Remove();
      this.passiveEffects.Clear();
      this.effectsDisabled = true;
      this.init = 0;
    }

    public IEnumerator EnableEffects(Entity entity)
    {
      int stacks = this.count - this.init;
      yield return (object) this.AddEffectStacks(entity, stacks);
    }

    public IEnumerator AddEffectStacks(Entity entity, int stacks)
    {
      Entity.TraitStacks traitStacks = this;
      StatusEffectData[] statusEffectDataArray = traitStacks.data.effects;
      for (int index = 0; index < statusEffectDataArray.Length; ++index)
        yield return (object) StatusEffectSystem.Apply(entity, (Entity) null, statusEffectDataArray[index], stacks, true, new Action<StatusEffectData>(traitStacks.\u003CAddEffectStacks\u003Eb__20_0));
      statusEffectDataArray = (StatusEffectData[]) null;
      traitStacks.effectsDisabled = false;
      traitStacks.init += stacks;
    }

    public IEnumerator RemoveEffectStacks(Entity entity, int removeStacks)
    {
      StatusEffectData[] statusEffectDataArray = this.data.effects;
      for (int index = 0; index < statusEffectDataArray.Length; ++index)
      {
        StatusEffectData status = entity.FindStatus(statusEffectDataArray[index]);
        if ((bool) (UnityEngine.Object) status)
          yield return (object) status.RemoveStacks(removeStacks, true);
      }
      statusEffectDataArray = (StatusEffectData[]) null;
      this.init -= removeStacks;
    }

    [CompilerGenerated]
    public void \u003CAddEffectStacks\u003Eb__20_0(StatusEffectData a)
    {
      this.passiveEffects.Add(a);
    }
  }
}
