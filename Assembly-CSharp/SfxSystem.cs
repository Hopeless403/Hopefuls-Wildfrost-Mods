// Decompiled with JetBrains decompiler
// Type: SfxSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using FMOD;
using FMOD.Studio;
using FMODUnity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SfxSystem : GameSystem
{
  private static SfxSystem instance;
  private const float DRAG_THRESHOLD = 0.35f;
  private static readonly Dictionary<string, float> cooldownTimers = new Dictionary<string, float>()
  {
    {
      "event:/sfx/card/hover",
      0.1f
    },
    {
      "event:/sfx/card/flip_single",
      0.075f
    },
    {
      "event:/sfx/card/enter_pocket",
      0.1f
    },
    {
      "event:/sfx/status/block",
      0.05f
    },
    {
      "event:/sfx/status/demonize",
      0.05f
    },
    {
      "event:/sfx/status/heal",
      0.05f
    },
    {
      "event:/sfx/status/power",
      0.05f
    },
    {
      "event:/sfx/status/shell",
      0.05f
    },
    {
      "event:/sfx/status/shroom",
      0.05f
    },
    {
      "event:/sfx/status/snow",
      0.05f
    },
    {
      "event:/sfx/status/spice",
      0.05f
    },
    {
      "event:/sfx/status/sun",
      0.05f
    },
    {
      "event:/sfx/status/teeth",
      0.05f
    },
    {
      "event:/sfx/status/overburn",
      0.05f
    },
    {
      "event:/sfx/status/scrap",
      0.05f
    },
    {
      "event:/sfx/status/frenzy",
      0.05f
    },
    {
      "event:/sfx/status/frost",
      0.05f
    },
    {
      "event:/sfx/status/haze",
      0.05f
    },
    {
      "event:/sfx/status/ink",
      0.05f
    },
    {
      "event:/sfx/status/bom",
      0.05f
    },
    {
      "event:/sfx/location/shop/crown_hover",
      0.05f
    },
    {
      "event:/sfx/location/shop/charm_hover",
      0.05f
    },
    {
      "event:/sfx/card/ping",
      0.05f
    }
  };
  private static readonly Dictionary<string, SfxSystem.Cooldown> cooldowns = new Dictionary<string, SfxSystem.Cooldown>();
  [SerializeField]
  private AnimationCurve pathRevealPitch;
  [SerializeField]
  private EventReference test;
  private List<EventInstance> running;
  private Entity dragging;
  private Entity draggingItem;
  private bool dragTrigger;
  private Vector2 dragFrom;
  private EventInstance itemAim;
  private int revealActionsInQueue;
  private EventInstance flipMulti;
  private EventInstance transitionSnow;
  private EventInstance goldCounter;
  private EventInstance muncherFeed;
  private EventInstance drawMulti;
  private EventInstance townProgressionLoop;
  private GoldDisplay goldDisplay;

  private void OnEnable()
  {
    SfxSystem.instance = this;
    global::Events.OnEntityHit += new UnityAction<Hit>(SfxSystem.EntityHit);
    global::Events.OnEntityHover += new UnityAction<Entity>(SfxSystem.EntityHover);
    global::Events.OnEntityKilled += new UnityAction<Entity, DeathType>(SfxSystem.EntityKilled);
    global::Events.OnEntitySelect += new UnityAction<Entity>(SfxSystem.EntitySelect);
    global::Events.OnEntityDrag += new UnityAction<Entity>(this.EntityDrag);
    global::Events.OnEntityRelease += new UnityAction<Entity>(this.EntityRelease);
    global::Events.OnEntityPlace += new UnityAction<Entity, CardContainer[], bool>(SfxSystem.EntityPlace);
    global::Events.OnEntityFlipUp += new UnityAction<Entity>(SfxSystem.EntityFlipUp);
    global::Events.OnEntityFlipDown += new UnityAction<Entity>(SfxSystem.EntityFlipDown);
    global::Events.OnEntityTrigger += new global::Events.UnityActionRef<Trigger>(SfxSystem.EntityTrigger);
    global::Events.OnEntityMove += new UnityAction<Entity>(SfxSystem.EntityMove);
    global::Events.OnEntityFocus += new UnityAction<Entity>(SfxSystem.Focus);
    global::Events.OnEntityEnterPocket += new UnityAction<Entity, CardPocket>(SfxSystem.EntityEnterPocket);
    global::Events.OnEntityEnterBackpack += new UnityAction<Entity>(SfxSystem.EntityEnterBackpack);
    global::Events.OnNoomlinShow += new UnityAction<Entity>(SfxSystem.NoomlinShow);
    global::Events.OnNoomlinUsed += new UnityAction<Entity>(SfxSystem.NoomlinUsed);
    global::Events.OnBattlePhaseStart += new UnityAction<Battle.Phase>(SfxSystem.BattlePhaseStart);
    global::Events.OnStatusEffectApplied += new UnityAction<StatusEffectApply>(SfxSystem.StatusApplied);
    global::Events.OnCardDraw += new UnityAction<int>(this.CardDraw);
    global::Events.OnCardDrawEnd += new UnityAction(this.CardDrawEnd);
    global::Events.OnStatusIconChanged += new UnityAction<StatusIcon, Stat, Stat>(SfxSystem.StatusIconChanged);
    global::Events.OnDropGold += new UnityAction<int, string, Character, Vector3>(SfxSystem.DropGold);
    global::Events.OnGoldFlyToBag += new UnityAction<int, Character, Vector3>(SfxSystem.GoldFlyToBag);
    global::Events.OnCollectGold += new UnityAction<int>(SfxSystem.CollectGold);
    global::Events.OnDeckpackOpen += new UnityAction(SfxSystem.DeckpackOpen);
    global::Events.OnDeckpackClose += new UnityAction(SfxSystem.DeckpackClose);
    global::Events.OnMapPathReveal += new UnityAction<float>(this.MapPathReveal);
    global::Events.OnMapNodeReveal += new UnityAction<MapNode>(SfxSystem.MapNodeReveal);
    global::Events.OnMapNodeHover += new UnityAction<MapNode>(SfxSystem.MapNodeHover);
    global::Events.OnMapNodeSelect += new UnityAction<MapNode>(SfxSystem.MapNodeSelect);
    global::Events.OnActionQueued += new UnityAction<PlayAction>(this.ActionQueued);
    global::Events.OnActionPerform += new UnityAction<PlayAction>(this.ActionPerform);
    global::Events.OnActionFinished += new UnityAction<PlayAction>(this.ActionFinished);
    global::Events.OnTransitionStart += new UnityAction<TransitionType>(this.TransitionStart);
    global::Events.OnTransitionEnd += new UnityAction<TransitionType>(this.TransitionEnd);
    global::Events.OnGoldCounterStart += new UnityAction<GoldDisplay, float>(this.GoldCounterStart);
    global::Events.OnMuncherDrag += new UnityAction(this.MuncherDrag);
    global::Events.OnMuncherDragCancel += new UnityAction(this.MuncherDragEnd);
    global::Events.OnMuncherFeed += new UnityAction<Entity>(this.MuncherFeed);
    global::Events.OnBombardShoot += new UnityAction<Entity>(SfxSystem.BombardShoot);
    global::Events.OnBombardRocketFall += new UnityAction<BombardRocket>(SfxSystem.BombardRocketFall);
    global::Events.OnBombardRocketExplode += new UnityAction<BombardRocket>(SfxSystem.BombardRocketExplode);
    global::Events.OnButtonHover += new UnityAction<ButtonType>(SfxSystem.ButtonHover);
    global::Events.OnButtonPress += new UnityAction<ButtonType>(SfxSystem.ButtonPress);
    global::Events.OnProgressStart += new UnityAction<float>(this.ProgressStart);
    global::Events.OnProgressUpdate += new UnityAction<float>(this.ProgressUpdate);
    global::Events.OnProgressStop += new UnityAction(this.ProgressStop);
    global::Events.OnProgressDing += new UnityAction(SfxSystem.ProgressDing);
    global::Events.OnProgressBlip += new UnityAction(SfxSystem.ProgressBlip);
    global::Events.OnTownUnlock += new UnityAction<UnlockData>(SfxSystem.TownUnlockPopUp);
    global::Events.OnUpgradeHover += new UnityAction<UpgradeDisplay>(SfxSystem.UpgradeHover);
    global::Events.OnUpgradePickup += new UnityAction<UpgradeDisplay>(SfxSystem.UpgradePickup);
    global::Events.OnUpgradeDrop += new UnityAction<UpgradeDisplay>(SfxSystem.UpgradeDrop);
    global::Events.OnUpgradeAssign += new UnityAction<Entity, CardUpgradeData>(SfxSystem.UpgradeAssign);
    global::Events.OnShopItemHover += new UnityAction<ShopItem>(SfxSystem.ShopItemHover);
    global::Events.OnAbilityTargetAdd += new UnityAction<CardContainer>(SfxSystem.AbilityTargetAdd);
    global::Events.OnEntityPing += new UnityAction<GameObject>(SfxSystem.EntityPing);
    this.running = new List<EventInstance>();
    SfxSystem.cooldowns.Clear();
    foreach (KeyValuePair<string, float> cooldownTimer in SfxSystem.cooldownTimers)
      SfxSystem.cooldowns[cooldownTimer.Key] = new SfxSystem.Cooldown(cooldownTimer.Key, cooldownTimer.Value);
  }

  private void OnDisable()
  {
    global::Events.OnEntityHit -= new UnityAction<Hit>(SfxSystem.EntityHit);
    global::Events.OnEntityHover -= new UnityAction<Entity>(SfxSystem.EntityHover);
    global::Events.OnEntityKilled -= new UnityAction<Entity, DeathType>(SfxSystem.EntityKilled);
    global::Events.OnEntitySelect -= new UnityAction<Entity>(SfxSystem.EntitySelect);
    global::Events.OnEntityDrag -= new UnityAction<Entity>(this.EntityDrag);
    global::Events.OnEntityRelease -= new UnityAction<Entity>(this.EntityRelease);
    global::Events.OnEntityPlace -= new UnityAction<Entity, CardContainer[], bool>(SfxSystem.EntityPlace);
    global::Events.OnEntityFlipUp -= new UnityAction<Entity>(SfxSystem.EntityFlipUp);
    global::Events.OnEntityFlipDown -= new UnityAction<Entity>(SfxSystem.EntityFlipDown);
    global::Events.OnEntityTrigger -= new global::Events.UnityActionRef<Trigger>(SfxSystem.EntityTrigger);
    global::Events.OnEntityMove -= new UnityAction<Entity>(SfxSystem.EntityMove);
    global::Events.OnEntityFocus -= new UnityAction<Entity>(SfxSystem.Focus);
    global::Events.OnEntityEnterPocket -= new UnityAction<Entity, CardPocket>(SfxSystem.EntityEnterPocket);
    global::Events.OnEntityEnterBackpack -= new UnityAction<Entity>(SfxSystem.EntityEnterBackpack);
    global::Events.OnNoomlinShow -= new UnityAction<Entity>(SfxSystem.NoomlinShow);
    global::Events.OnNoomlinUsed -= new UnityAction<Entity>(SfxSystem.NoomlinUsed);
    global::Events.OnBattlePhaseStart -= new UnityAction<Battle.Phase>(SfxSystem.BattlePhaseStart);
    global::Events.OnStatusEffectApplied -= new UnityAction<StatusEffectApply>(SfxSystem.StatusApplied);
    global::Events.OnCardDraw -= new UnityAction<int>(this.CardDraw);
    global::Events.OnCardDrawEnd -= new UnityAction(this.CardDrawEnd);
    global::Events.OnStatusIconChanged -= new UnityAction<StatusIcon, Stat, Stat>(SfxSystem.StatusIconChanged);
    global::Events.OnDropGold -= new UnityAction<int, string, Character, Vector3>(SfxSystem.DropGold);
    global::Events.OnGoldFlyToBag -= new UnityAction<int, Character, Vector3>(SfxSystem.GoldFlyToBag);
    global::Events.OnCollectGold -= new UnityAction<int>(SfxSystem.CollectGold);
    global::Events.OnDeckpackOpen -= new UnityAction(SfxSystem.DeckpackOpen);
    global::Events.OnDeckpackClose -= new UnityAction(SfxSystem.DeckpackClose);
    global::Events.OnMapPathReveal -= new UnityAction<float>(this.MapPathReveal);
    global::Events.OnMapNodeReveal -= new UnityAction<MapNode>(SfxSystem.MapNodeReveal);
    global::Events.OnMapNodeHover -= new UnityAction<MapNode>(SfxSystem.MapNodeHover);
    global::Events.OnMapNodeSelect -= new UnityAction<MapNode>(SfxSystem.MapNodeSelect);
    global::Events.OnActionQueued -= new UnityAction<PlayAction>(this.ActionQueued);
    global::Events.OnActionPerform -= new UnityAction<PlayAction>(this.ActionPerform);
    global::Events.OnActionFinished -= new UnityAction<PlayAction>(this.ActionFinished);
    global::Events.OnTransitionStart -= new UnityAction<TransitionType>(this.TransitionStart);
    global::Events.OnTransitionEnd -= new UnityAction<TransitionType>(this.TransitionEnd);
    global::Events.OnGoldCounterStart -= new UnityAction<GoldDisplay, float>(this.GoldCounterStart);
    global::Events.OnMuncherDrag -= new UnityAction(this.MuncherDrag);
    global::Events.OnMuncherDragCancel -= new UnityAction(this.MuncherDragEnd);
    global::Events.OnMuncherFeed -= new UnityAction<Entity>(this.MuncherFeed);
    global::Events.OnBombardShoot -= new UnityAction<Entity>(SfxSystem.BombardShoot);
    global::Events.OnBombardRocketFall -= new UnityAction<BombardRocket>(SfxSystem.BombardRocketFall);
    global::Events.OnBombardRocketExplode -= new UnityAction<BombardRocket>(SfxSystem.BombardRocketExplode);
    global::Events.OnButtonHover -= new UnityAction<ButtonType>(SfxSystem.ButtonHover);
    global::Events.OnButtonPress -= new UnityAction<ButtonType>(SfxSystem.ButtonPress);
    global::Events.OnProgressStart -= new UnityAction<float>(this.ProgressStart);
    global::Events.OnProgressUpdate -= new UnityAction<float>(this.ProgressUpdate);
    global::Events.OnProgressStop -= new UnityAction(this.ProgressStop);
    global::Events.OnProgressDing -= new UnityAction(SfxSystem.ProgressDing);
    global::Events.OnProgressBlip -= new UnityAction(SfxSystem.ProgressBlip);
    global::Events.OnTownUnlock -= new UnityAction<UnlockData>(SfxSystem.TownUnlockPopUp);
    global::Events.OnUpgradeHover -= new UnityAction<UpgradeDisplay>(SfxSystem.UpgradeHover);
    global::Events.OnUpgradePickup -= new UnityAction<UpgradeDisplay>(SfxSystem.UpgradePickup);
    global::Events.OnUpgradeDrop -= new UnityAction<UpgradeDisplay>(SfxSystem.UpgradeDrop);
    global::Events.OnUpgradeAssign -= new UnityAction<Entity, CardUpgradeData>(SfxSystem.UpgradeAssign);
    global::Events.OnShopItemHover -= new UnityAction<ShopItem>(SfxSystem.ShopItemHover);
    global::Events.OnAbilityTargetAdd -= new UnityAction<CardContainer>(SfxSystem.AbilityTargetAdd);
    global::Events.OnEntityPing -= new UnityAction<GameObject>(SfxSystem.EntityPing);
    this.StopAll();
    this.running = (List<EventInstance>) null;
  }

  private void Update()
  {
    for (int index = this.running.Count - 1; index >= 0; --index)
    {
      EventInstance eventInstance = this.running[index];
      if (!SfxSystem.IsRunning(eventInstance))
      {
        int num = (int) eventInstance.release();
        this.running.RemoveAt(index);
      }
    }
    foreach (KeyValuePair<string, SfxSystem.Cooldown> cooldown in SfxSystem.cooldowns)
    {
      if ((double) cooldown.Value.current > 0.0)
        cooldown.Value.current -= Time.deltaTime;
    }
    if (this.dragTrigger)
    {
      if (!(bool) (Object) this.dragging)
        this.dragTrigger = false;
      else if ((double) ((Vector2) this.dragging.transform.position - this.dragFrom).sqrMagnitude > 0.34999999403953552)
      {
        this.dragTrigger = false;
        SfxSystem.OneShot("event:/sfx/card/drag");
      }
    }
    if (!SfxSystem.IsRunning(this.goldCounter) || (bool) (Object) this.goldDisplay && (double) this.goldDisplay.add != 0.0)
      return;
    SfxSystem.Stop(this.goldCounter);
    this.goldDisplay = (GoldDisplay) null;
  }

  public static EventInstance OneShot(EventReference eventRef) => SfxSystem.OneShot(eventRef.Guid);

  public static EventInstance OneShot(GUID guid)
  {
    EventInstance instance = RuntimeManager.CreateInstance(guid);
    int num = (int) instance.start();
    return instance;
  }

  public static void OneShot(string eventName) => RuntimeManager.PlayOneShot(eventName);

  private static void OneShotCheckCooldown(string eventName, bool resetCooldown = true)
  {
    if (!SfxSystem.CheckCooldown(eventName))
      return;
    SfxSystem.OneShot(eventName);
    if (!resetCooldown)
      return;
    SfxSystem.SetCooldown(eventName);
  }

  private static void OneShot(string eventName, params SfxSystem.Param[] parameters)
  {
    EventInstance instance = RuntimeManager.CreateInstance(eventName);
    foreach (SfxSystem.Param parameter in parameters)
    {
      int num = (int) instance.setParameterByName(parameter.name, parameter.value);
    }
    int num1 = (int) instance.start();
    int num2 = (int) instance.release();
  }

  private EventInstance Play(string eventPath, params SfxSystem.Param[] parameters)
  {
    try
    {
      EventInstance instance = RuntimeManager.CreateInstance(eventPath);
      foreach (SfxSystem.Param parameter in parameters)
      {
        int num = (int) instance.setParameterByName(parameter.name, parameter.value);
      }
      this.running.Add(instance);
      int num1 = (int) instance.start();
      return instance;
    }
    catch (EventNotFoundException ex)
    {
      UnityEngine.Debug.LogWarning((object) ex);
      return new EventInstance();
    }
  }

  private EventInstance Play(EventReference eventRef, params SfxSystem.Param[] parameters)
  {
    try
    {
      EventInstance instance = RuntimeManager.CreateInstance(eventRef);
      foreach (SfxSystem.Param parameter in parameters)
      {
        int num = (int) instance.setParameterByName(parameter.name, parameter.value);
      }
      this.running.Add(instance);
      int num1 = (int) instance.start();
      return instance;
    }
    catch (EventNotFoundException ex)
    {
      UnityEngine.Debug.LogWarning((object) ex);
      return new EventInstance();
    }
  }

  public static void SetParam(EventInstance eventInstance, string param, float value)
  {
    if (!SfxSystem.IsRunning(eventInstance))
      return;
    int num = (int) eventInstance.setParameterByName(param, value);
  }

  public static void Stop(EventInstance eventInstance, FMOD.Studio.STOP_MODE stopMode = FMOD.Studio.STOP_MODE.ALLOWFADEOUT)
  {
    if (!SfxSystem.IsRunning(eventInstance))
      return;
    int num1 = (int) eventInstance.stop(stopMode);
    int num2 = (int) eventInstance.release();
  }

  private static bool IsRunning(EventInstance eventInstance)
  {
    if (eventInstance.isValid())
    {
      PLAYBACK_STATE state;
      int playbackState = (int) eventInstance.getPlaybackState(out state);
      if (state != PLAYBACK_STATE.STOPPED)
        return true;
    }
    return false;
  }

  private static void SetCooldown(string eventName)
  {
    if (!SfxSystem.cooldowns.ContainsKey(eventName))
      return;
    SfxSystem.cooldowns[eventName].Max();
  }

  private static bool CheckCooldown(string eventName) => !SfxSystem.cooldowns.ContainsKey(eventName) || (double) SfxSystem.cooldowns[eventName].current <= 0.0;

  public static void SetGlobalParam(string paramName, float value)
  {
    int num = (int) RuntimeManager.StudioSystem.setParameterByName(paramName, value);
  }

  public static EventInstance Loop(string eventName) => SfxSystem.instance.Play(eventName);

  public static EventInstance Loop(EventReference eventRef) => SfxSystem.instance.Play(eventRef);

  public static void EndLoop(EventInstance? inst)
  {
    if (!inst.HasValue)
      return;
    EventInstance valueOrDefault = inst.GetValueOrDefault();
    if (!SfxSystem.IsRunning(valueOrDefault))
      return;
    SfxSystem.Stop(valueOrDefault);
  }

  private static int GetHitPower(Hit hit) => hit.damage + hit.damageBlocked + hit.extraOffensiveness;

  private static void EntityHit(Hit hit)
  {
    if (!hit.Offensive || !hit.doAnimation || !hit.countsAsHit || !(bool) (Object) hit.target)
      return;
    int hitPower = SfxSystem.GetHitPower(hit);
    if (hitPower < 0)
      return;
    switch (hit.damageType)
    {
      case "basic":
        SfxSystem.OneShot("event:/sfx/attack/hit_level", new SfxSystem.Param("power", (float) Mathf.Max(1, hitPower)));
        break;
      case "shroom":
        SfxSystem.OneShot("event:/sfx/status/shroom_damage");
        break;
      case "spikes":
        SfxSystem.OneShot("event:/sfx/status/teeth_damage");
        break;
      case "overload":
        SfxSystem.OneShot("event:/sfx/status/overburn_damage");
        break;
    }
  }

  private static void EntityHover(Entity entity) => SfxSystem.OneShotCheckCooldown("event:/sfx/card/hover", false);

  private static void EntityKilled(Entity entity, DeathType deathType)
  {
    if (deathType == DeathType.Normal || deathType == DeathType.Eaten)
      SfxSystem.OneShot("event:/sfx/card/destroy");
    if (!(bool) (Object) entity || !(bool) (Object) entity.data)
      return;
    CardType cardType = entity.data.cardType;
    if (cardType == null || !cardType.miniboss)
      return;
    SfxSystem.OneShot("event:/sfx/card/destroy_boss");
  }

  private static void EntitySelect(Entity entity) => SfxSystem.OneShot("event:/sfx/card/click");

  private void EntityDrag(Entity entity)
  {
    this.dragging = entity;
    if (!entity.inPlay)
    {
      this.dragTrigger = true;
      this.dragFrom = (Vector2) entity.transform.position;
    }
    else
    {
      if (entity.data.cardType.item)
      {
        this.itemAim = this.Play(entity.IsOffensive() ? "event:/sfx/attack/item_aim_offensive" : "event:/sfx/attack/item_aim_supportive");
        this.draggingItem = entity;
      }
      if (entity.data.playType != Card.PlayType.Place)
        return;
      this.dragTrigger = true;
      this.dragFrom = (Vector2) entity.transform.position;
    }
  }

  private void EntityRelease(Entity entity)
  {
    if ((Object) this.dragging == (Object) entity)
    {
      this.dragging = (Entity) null;
      SfxSystem.SetCooldown("event:/sfx/card/hover");
    }
    if (!((Object) this.draggingItem == (Object) entity) || !SfxSystem.IsRunning(this.itemAim))
      return;
    SfxSystem.SetParam(this.itemAim, "stop", 1f);
    this.draggingItem = (Entity) null;
  }

  private static void EntityPlace(Entity entity, CardContainer[] containers, bool freeMove) => SfxSystem.OneShot("event:/sfx/card/place");

  private static void EntityFlipUp(Entity entity) => SfxSystem.OneShotCheckCooldown("event:/sfx/card/flip_single");

  private static void EntityFlipDown(Entity entity) => SfxSystem.OneShotCheckCooldown("event:/sfx/card/flip_single");

  private static void EntityTrigger(ref Trigger trigger)
  {
    CardType cardType = trigger.entity.data.cardType;
    if (cardType == null || !cardType.item || !((Object) trigger.triggeredBy == (Object) trigger.entity.owner.entity))
      return;
    SfxSystem.OneShot("event:/sfx/attack/item_use");
  }

  private static void EntityMove(Entity entity)
  {
    Character enemy = Battle.instance.enemy;
    if (enemy == null || !((Object) entity.owner == (Object) enemy) || !entity.preContainers.Contains<CardContainer>(enemy.reserveContainer))
      return;
    SfxSystem.OneShot("event:/sfx/card/enemy_showup");
  }

  private static void Focus(Entity entity) => SfxSystem.OneShot("event:/sfx/card/drag");

  private static void EntityEnterPocket(Entity entity, CardPocket pocket) => SfxSystem.OneShotCheckCooldown("event:/sfx/card/enter_pocket");

  private static void EntityEnterBackpack(Entity entity) => SfxSystem.OneShotCheckCooldown("event:/sfx/card/enter_backpack");

  private static void NoomlinShow(Entity entity)
  {
    if (!entity.inPlay)
      return;
    SfxSystem.OneShot("event:/sfx/keyword/noomlin_showup");
  }

  private static void NoomlinUsed(Entity entity)
  {
    if (!entity.inPlay)
      return;
    SfxSystem.OneShot("event:/sfx/keyword/noomlin_use");
  }

  private static void BattlePhaseStart(Battle.Phase phase)
  {
    if (phase == Battle.Phase.Battle)
    {
      SfxSystem.OneShot("event:/sfx/inventory/battle_zoom_in");
    }
    else
    {
      if (Battle.instance.phase != Battle.Phase.Battle)
        return;
      SfxSystem.OneShot("event:/sfx/inventory/battle_zoom_out");
    }
  }

  private static void StatusApplied(StatusEffectApply apply)
  {
    if (!(bool) (Object) apply?.effectData || !apply.target.display.init || !apply.target.startingEffectsApplied || Transition.Running)
      return;
    string type = apply.effectData.type;
    // ISSUE: reference to a compiler-generated method
    switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(type))
    {
      case 300022785:
        if (!(type == "shell"))
          break;
        SfxSystem.OneShotCheckCooldown("event:/sfx/status/shell");
        break;
      case 612613805:
        if (!(type == "damage up"))
          break;
        SfxSystem.OneShotCheckCooldown("event:/sfx/status/power");
        break;
      case 782257799:
        if (!(type == "frenzy"))
          break;
        SfxSystem.OneShotCheckCooldown("event:/sfx/status/frenzy");
        break;
      case 979982427:
        if (!(type == "heal"))
          break;
        SfxSystem.OneShotCheckCooldown("event:/sfx/status/heal");
        break;
      case 1224417970:
        if (!(type == "scrap"))
          break;
        SfxSystem.OneShotCheckCooldown("event:/sfx/status/scrap");
        break;
      case 1601927818:
        if (!(type == "demonize"))
          break;
        SfxSystem.OneShotCheckCooldown("event:/sfx/status/demonize");
        break;
      case 1964130039:
        if (!(type == "vim"))
          break;
        SfxSystem.OneShotCheckCooldown("event:/sfx/status/bom");
        break;
      case 2223183858:
        if (!(type == "snow"))
          break;
        SfxSystem.OneShotCheckCooldown("event:/sfx/status/snow");
        break;
      case 2699661231:
        if (!(type == "ink"))
          break;
        SfxSystem.OneShotCheckCooldown("event:/sfx/status/ink");
        break;
      case 2884297373:
        if (!(type == "spice"))
          break;
        SfxSystem.OneShotCheckCooldown("event:/sfx/status/spice");
        break;
      case 2989549779:
        if (!(type == "max counter down"))
          break;
        SfxSystem.OneShotCheckCooldown("event:/sfx/status/sun");
        break;
      case 3121317895:
        if (!(type == "overload"))
          break;
        SfxSystem.OneShotCheckCooldown("event:/sfx/status/overburn");
        break;
      case 3376736801:
        if (!(type == "teeth"))
          break;
        SfxSystem.OneShotCheckCooldown("event:/sfx/status/teeth");
        break;
      case 3587623927:
        if (!(type == "haze"))
          break;
        SfxSystem.OneShotCheckCooldown("event:/sfx/status/haze");
        break;
      case 3735618345:
        if (!(type == "counter down"))
          break;
        SfxSystem.OneShotCheckCooldown("event:/sfx/status/sun");
        break;
      case 3881701069:
        if (!(type == "frost"))
          break;
        SfxSystem.OneShotCheckCooldown("event:/sfx/status/frost");
        break;
      case 3903208501:
        if (!(type == "shroom"))
          break;
        SfxSystem.OneShotCheckCooldown("event:/sfx/status/shroom");
        break;
      case 3943480674:
        if (!(type == "block"))
          break;
        SfxSystem.OneShotCheckCooldown("event:/sfx/status/block");
        break;
      case 4164197074:
        if (!(type == "max health up"))
          break;
        SfxSystem.OneShotCheckCooldown("event:/sfx/status/heal");
        break;
    }
  }

  private void CardDraw(int amount)
  {
    if (SfxSystem.IsRunning(this.drawMulti))
      SfxSystem.Stop(this.drawMulti);
    this.drawMulti = this.Play("event:/sfx/card/draw_multi");
  }

  private void CardDrawEnd()
  {
    if (!SfxSystem.IsRunning(this.drawMulti))
      return;
    SfxSystem.SetParam(this.drawMulti, "draw_stop", 1f);
  }

  private static void StatusIconChanged(StatusIcon icon, Stat previousValue, Stat newValue)
  {
    if (Transition.Running)
      return;
    switch (icon.type)
    {
      case "counter":
        if (newValue.current < previousValue.current)
        {
          SfxSystem.OneShot("event:/sfx/status_icon/counter_decrease");
          break;
        }
        if (newValue.current <= previousValue.current)
          break;
        SfxSystem.OneShot("event:/sfx/status_icon/counter_increase");
        break;
      case "snow":
        if (newValue.current >= previousValue.current)
          break;
        SfxSystem.OneShot("event:/sfx/status_icon/snow_decrease");
        break;
      case "scrap":
        if (newValue.current >= previousValue.current)
          break;
        SfxSystem.OneShot("event:/sfx/status_icon/scrap_decrease");
        break;
      case "shell":
        if (newValue.current >= previousValue.current)
          break;
        SfxSystem.OneShot("event:/sfx/status_icon/shell_decrease");
        break;
    }
  }

  private static void DropGold(int amount, string source, Character owner, Vector3 position)
  {
    if (source == "Flee")
      return;
    SfxSystem.OneShot("event:/sfx/inventory/bling_dropping", new SfxSystem.Param("battle", (float) (SceneManager.ActiveSceneName == "Battle" ? 1 : 0)));
  }

  private static void GoldFlyToBag(int amount, Character owner, Vector3 position) => SfxSystem.OneShot("event:/sfx/inventory/bling_flying");

  private static void CollectGold(int amount) => SfxSystem.OneShot("event:/sfx/inventory/bling_collect");

  private static void DeckpackOpen() => SfxSystem.OneShot("event:/sfx/inventory/backpack_opening");

  private static void DeckpackClose() => SfxSystem.OneShot("event:/sfx/inventory/backpack_closing");

  private void MapPathReveal(float totalTime)
  {
    EventInstance mapPathReveal = this.Play("event:/sfx/map/path_showup");
    UnityEngine.Debug.Log((object) "> Playing path_showup");
    this.StartCoroutine(this.MapPathRevealRoutine(mapPathReveal, totalTime));
  }

  private IEnumerator MapPathRevealRoutine(EventInstance mapPathReveal, float totalTime)
  {
    float time = 0.0f;
    while ((double) time < (double) totalTime && SfxSystem.IsRunning(mapPathReveal))
    {
      time += Time.deltaTime;
      float time1 = time / totalTime;
      int num = (int) mapPathReveal.setPitch(this.pathRevealPitch.Evaluate(time1));
      if ((double) time >= (double) totalTime)
      {
        SfxSystem.Stop(mapPathReveal);
        break;
      }
      yield return (object) new WaitForFixedUpdate();
    }
  }

  private static void MapNodeReveal(MapNode node) => SfxSystem.OneShot("event:/sfx/map/location_showup");

  private static void MapNodeHover(MapNode node) => SfxSystem.OneShot("event:/sfx/map/location_hover");

  private static void MapNodeSelect(MapNode node)
  {
    if ((Object) node != (Object) null)
    {
      SfxSystem.OneShot("event:/sfx/map/location_select");
      if (!node.campaignNode.type.isBattle)
        return;
      SfxSystem.OneShot(node.campaignNode.type.isBoss ? "event:/sfx/map/location_select_battle_boss" : "event:/sfx/map/location_select_battle");
    }
    else
      SfxSystem.OneShot("event:/sfx/ui/deny");
  }

  private void ActionQueued(PlayAction action)
  {
    if (!(action is ActionReveal))
      return;
    ++this.revealActionsInQueue;
  }

  private void ActionPerform(PlayAction action)
  {
    if (!(action is ActionReveal) || this.revealActionsInQueue <= 1 || SfxSystem.IsRunning(this.flipMulti))
      return;
    this.flipMulti = this.Play("event:/sfx/card/flip_multi");
  }

  private void ActionFinished(PlayAction action)
  {
    if (!(action is ActionReveal) || --this.revealActionsInQueue > 0)
      return;
    SfxSystem.SetParam(this.flipMulti, "flip_stop", 1f);
  }

  private void TransitionStart(TransitionType transition)
  {
    if (!(transition is TransitionSnow))
      return;
    this.transitionSnow = this.Play("event:/sfx/transition/snow");
  }

  private void TransitionEnd(TransitionType transition)
  {
    if (!(transition is TransitionSnow) || !SfxSystem.IsRunning(this.transitionSnow))
      return;
    SfxSystem.SetParam(this.transitionSnow, "transition_end", 1f);
  }

  private void GoldCounterStart(GoldDisplay display, float addAmount)
  {
    this.GoldCounterStop();
    if ((double) addAmount > 0.0)
    {
      this.goldDisplay = display;
      this.goldCounter = this.Play("event:/sfx/inventory/bling_counter_up");
    }
    else
    {
      if ((double) addAmount >= 0.0)
        return;
      this.goldDisplay = display;
      this.goldCounter = this.Play("event:/sfx/inventory/bling_counter_down");
    }
  }

  private void GoldCounterStop()
  {
    if (!SfxSystem.IsRunning(this.goldCounter))
      return;
    SfxSystem.Stop(this.goldCounter);
  }

  private void MuncherDrag() => this.muncherFeed = this.Play("event:/sfx/location/muncher/feed");

  private void MuncherDragEnd()
  {
    if (!SfxSystem.IsRunning(this.muncherFeed))
      return;
    SfxSystem.Stop(this.muncherFeed);
  }

  private void MuncherFeed(Entity entity)
  {
    if (!SfxSystem.IsRunning(this.muncherFeed))
      return;
    SfxSystem.Stop(this.muncherFeed);
    SfxSystem.OneShot("event:/sfx/location/muncher/eat");
  }

  private static void BombardShoot(Entity entity) => SfxSystem.OneShot("event:/sfx/specific/boss_shooting");

  private static void BombardRocketFall(BombardRocket rocket) => SfxSystem.OneShot("event:/sfx/specific/boss_rockets_flying");

  private static void BombardRocketExplode(BombardRocket rocket) => SfxSystem.OneShot("event:/sfx/specific/boss_rockets_impact");

  private static void ButtonHover(ButtonType buttonType)
  {
    if (buttonType != ButtonType.Bell)
      SfxSystem.OneShot("event:/sfx/ui/menu_hover");
    else
      SfxSystem.OneShot("event:/sfx/modifiers/bell_hovering");
  }

  private static void ButtonPress(ButtonType buttonType)
  {
    if (buttonType != ButtonType.Sub)
    {
      if (buttonType != ButtonType.Back)
        SfxSystem.OneShot("event:/sfx/ui/menu_click");
      else
        SfxSystem.OneShot("event:/sfx/ui/menu_click_back");
    }
    else
      SfxSystem.OneShot("event:/sfx/ui/menu_click_sub");
  }

  private void ProgressStart(float fill)
  {
    this.townProgressionLoop = SfxSystem.Loop("event:/sfx/town_progress/ramp");
    SfxSystem.SetParam(this.townProgressionLoop, "townramp", fill);
  }

  private void ProgressUpdate(float fill)
  {
    if (!SfxSystem.IsRunning(this.townProgressionLoop))
      return;
    SfxSystem.SetParam(this.townProgressionLoop, "townramp", fill);
  }

  private void ProgressStop() => SfxSystem.Stop(this.townProgressionLoop);

  private static void ProgressDing() => SfxSystem.OneShot("event:/sfx/town_progress/achieved");

  private static void ProgressBlip() => SfxSystem.OneShot("event:/sfx/town_progress/blip");

  private static void TownUnlockPopUp(UnlockData unlockData) => SfxSystem.OneShot("event:/sfx/town_progress/notification");

  private static void UpgradeHover(UpgradeDisplay upgradeDisplay)
  {
    if (upgradeDisplay.data.type != CardUpgradeData.Type.Crown)
      SfxSystem.OneShot("event:/sfx/inventory/charm_hover");
    else
      SfxSystem.OneShot("event:/sfx/inventory/crown_hover");
  }

  private static void UpgradePickup(UpgradeDisplay upgradeDisplay)
  {
    if (upgradeDisplay.data.type != CardUpgradeData.Type.Crown)
      SfxSystem.OneShot("event:/sfx/inventory/charm_pickup");
    else
      SfxSystem.OneShot("event:/sfx/inventory/crown_pickup");
  }

  private static void UpgradeDrop(UpgradeDisplay upgradeDisplay)
  {
    if (upgradeDisplay.data.type != CardUpgradeData.Type.Crown)
      SfxSystem.OneShot("event:/sfx/inventory/charm_return");
    else
      SfxSystem.OneShot("event:/sfx/inventory/crown_return");
  }

  private static void UpgradeAssign(Entity entity, CardUpgradeData upgradeData)
  {
    if (upgradeData.type != CardUpgradeData.Type.Crown)
      return;
    SfxSystem.OneShot("event:/sfx/inventory/crown_assign");
  }

  private static void ShopItemHover(ShopItem shopItem)
  {
    CrownHolderShop component1 = shopItem.GetComponent<CrownHolderShop>();
    if (component1 != null && component1.hasCrown && component1.enabled)
    {
      SfxSystem.OneShotCheckCooldown("event:/sfx/location/shop/crown_hover");
    }
    else
    {
      CharmMachine component2 = shopItem.GetComponent<CharmMachine>();
      if (component2 == null || !component2.enabled)
        return;
      SfxSystem.OneShotCheckCooldown("event:/sfx/location/shop/charm_hover");
    }
  }

  private static void AbilityTargetAdd(CardContainer container) => SfxSystem.OneShot("event:/sfx/specific/boss_targets");

  private static void EntityPing(GameObject obj) => SfxSystem.OneShot("event:/sfx/card/ping");

  private void StopAll(FMOD.Studio.STOP_MODE stopMode = FMOD.Studio.STOP_MODE.IMMEDIATE)
  {
    foreach (EventInstance eventInstance in this.running)
    {
      int num1 = (int) eventInstance.stop(stopMode);
      int num2 = (int) eventInstance.release();
    }
    SfxSystem.cooldowns.Clear();
  }

  private readonly struct Param
  {
    public readonly string name;
    public readonly float value;

    public Param(string name, float value)
    {
      this.name = name;
      this.value = value;
    }
  }

  private class Cooldown
  {
    private string eventName;
    public float current;
    private readonly float max;

    public Cooldown(string eventName, float value)
    {
      this.eventName = eventName;
      this.current = 0.0f;
      this.max = value;
    }

    public void Max() => this.current = this.max;
  }
}
