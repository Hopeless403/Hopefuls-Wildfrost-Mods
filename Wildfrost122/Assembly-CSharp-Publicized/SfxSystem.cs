// Decompiled with JetBrains decompiler
// Type: SfxSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using FMOD;
using FMOD.Studio;
using FMODUnity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class SfxSystem : GameSystem
{
  public static SfxSystem instance;
  public const float DRAG_THRESHOLD = 0.35f;
  public static readonly Dictionary<string, float> cooldownTimers = new Dictionary<string, float>()
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
  public static readonly Dictionary<string, SfxSystem.Cooldown> cooldowns = new Dictionary<string, SfxSystem.Cooldown>();
  [SerializeField]
  public AnimationCurve pathRevealPitch;
  [SerializeField]
  public EventReference test;
  public List<EventInstance> running;
  public Entity dragging;
  public Entity draggingItem;
  public bool dragTrigger;
  public Vector2 dragFrom;
  public EventInstance itemAim;
  public int revealActionsInQueue;
  public EventInstance flipMulti;
  public EventInstance transitionSnow;
  public EventInstance goldCounter;
  public EventInstance muncherFeed;
  public EventInstance drawMulti;
  public EventInstance townProgressionLoop;
  public GoldDisplay goldDisplay;

  public void OnEnable()
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

  public void OnDisable()
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

  public void Update()
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

  public static void OneShotCheckCooldown(string eventName, bool resetCooldown = true)
  {
    if (!SfxSystem.CheckCooldown(eventName))
      return;
    SfxSystem.OneShot(eventName);
    if (!resetCooldown)
      return;
    SfxSystem.SetCooldown(eventName);
  }

  public static void OneShot(string eventName, params SfxSystem.Param[] parameters)
  {
    EventInstance instance = RuntimeManager.CreateInstance(eventName);
    foreach (SfxSystem.Param parameter in parameters)
    {
      int num = (int) instance.setParameterByName(parameter.name, parameter.value);
    }
    int num1 = (int) instance.start();
    int num2 = (int) instance.release();
  }

  public EventInstance Play(string eventPath, params SfxSystem.Param[] parameters)
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

  public EventInstance Play(EventReference eventRef, params SfxSystem.Param[] parameters)
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

  public static bool IsRunning(EventInstance eventInstance)
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

  public static void SetCooldown(string eventName)
  {
    if (!SfxSystem.cooldowns.ContainsKey(eventName))
      return;
    SfxSystem.cooldowns[eventName].Max();
  }

  public static bool CheckCooldown(string eventName)
  {
    return !SfxSystem.cooldowns.ContainsKey(eventName) || (double) SfxSystem.cooldowns[eventName].current <= 0.0;
  }

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

  public static int GetHitPower(Hit hit) => hit.damage + hit.damageBlocked + hit.extraOffensiveness;

  public static void EntityHit(Hit hit)
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

  public static void EntityHover(Entity entity)
  {
    SfxSystem.OneShotCheckCooldown("event:/sfx/card/hover", false);
  }

  public static void EntityKilled(Entity entity, DeathType deathType)
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

  public static void EntitySelect(Entity entity) => SfxSystem.OneShot("event:/sfx/card/click");

  public void EntityDrag(Entity entity)
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

  public void EntityRelease(Entity entity)
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

  public static void EntityPlace(Entity entity, CardContainer[] containers, bool freeMove)
  {
    SfxSystem.OneShot("event:/sfx/card/place");
  }

  public static void EntityFlipUp(Entity entity)
  {
    SfxSystem.OneShotCheckCooldown("event:/sfx/card/flip_single");
  }

  public static void EntityFlipDown(Entity entity)
  {
    SfxSystem.OneShotCheckCooldown("event:/sfx/card/flip_single");
  }

  public static void EntityTrigger(ref Trigger trigger)
  {
    CardType cardType = trigger.entity.data.cardType;
    if (cardType == null || !cardType.item || !((Object) trigger.triggeredBy == (Object) trigger.entity.owner.entity))
      return;
    SfxSystem.OneShot("event:/sfx/attack/item_use");
  }

  public static void EntityMove(Entity entity)
  {
    Character enemy = Battle.instance.enemy;
    if (enemy == null || !((Object) entity.owner == (Object) enemy) || !entity.preContainers.Contains<CardContainer>(enemy.reserveContainer))
      return;
    SfxSystem.OneShot("event:/sfx/card/enemy_showup");
  }

  public static void Focus(Entity entity) => SfxSystem.OneShot("event:/sfx/card/drag");

  public static void EntityEnterPocket(Entity entity, CardPocket pocket)
  {
    SfxSystem.OneShotCheckCooldown("event:/sfx/card/enter_pocket");
  }

  public static void EntityEnterBackpack(Entity entity)
  {
    SfxSystem.OneShotCheckCooldown("event:/sfx/card/enter_backpack");
  }

  public static void BattlePhaseStart(Battle.Phase phase)
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

  public static void StatusApplied(StatusEffectApply apply)
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

  public void CardDraw(int amount)
  {
    if (SfxSystem.IsRunning(this.drawMulti))
      SfxSystem.Stop(this.drawMulti);
    this.drawMulti = this.Play("event:/sfx/card/draw_multi");
  }

  public void CardDrawEnd()
  {
    if (!SfxSystem.IsRunning(this.drawMulti))
      return;
    SfxSystem.SetParam(this.drawMulti, "draw_stop", 1f);
  }

  public static void StatusIconChanged(StatusIcon icon, Stat previousValue, Stat newValue)
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

  public static void DropGold(int amount, string source, Character owner, Vector3 position)
  {
    if (source == "Flee")
      return;
    SfxSystem.OneShot("event:/sfx/inventory/bling_dropping", new SfxSystem.Param("battle", (float) (SceneManager.ActiveSceneName == "Battle" ? 1 : 0)));
  }

  public static void GoldFlyToBag(int amount, Character owner, Vector3 position)
  {
    SfxSystem.OneShot("event:/sfx/inventory/bling_flying");
  }

  public static void CollectGold(int amount)
  {
    SfxSystem.OneShot("event:/sfx/inventory/bling_collect");
  }

  public static void DeckpackOpen() => SfxSystem.OneShot("event:/sfx/inventory/backpack_opening");

  public static void DeckpackClose() => SfxSystem.OneShot("event:/sfx/inventory/backpack_closing");

  public void MapPathReveal(float totalTime)
  {
    EventInstance mapPathReveal = this.Play("event:/sfx/map/path_showup");
    UnityEngine.Debug.Log((object) "> Playing path_showup");
    this.StartCoroutine(this.MapPathRevealRoutine(mapPathReveal, totalTime));
  }

  public IEnumerator MapPathRevealRoutine(EventInstance mapPathReveal, float totalTime)
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

  public static void MapNodeReveal(MapNode node)
  {
    SfxSystem.OneShot("event:/sfx/map/location_showup");
  }

  public static void MapNodeHover(MapNode node)
  {
    SfxSystem.OneShot("event:/sfx/map/location_hover");
  }

  public static void MapNodeSelect(MapNode node)
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

  public void ActionQueued(PlayAction action)
  {
    if (!(action is ActionReveal))
      return;
    ++this.revealActionsInQueue;
  }

  public void ActionPerform(PlayAction action)
  {
    if (!(action is ActionReveal) || this.revealActionsInQueue <= 1 || SfxSystem.IsRunning(this.flipMulti))
      return;
    this.flipMulti = this.Play("event:/sfx/card/flip_multi");
  }

  public void ActionFinished(PlayAction action)
  {
    if (!(action is ActionReveal) || --this.revealActionsInQueue > 0)
      return;
    SfxSystem.SetParam(this.flipMulti, "flip_stop", 1f);
  }

  public void TransitionStart(TransitionType transition)
  {
    if (!(transition is TransitionSnow))
      return;
    this.transitionSnow = this.Play("event:/sfx/transition/snow");
  }

  public void TransitionEnd(TransitionType transition)
  {
    if (!(transition is TransitionSnow) || !SfxSystem.IsRunning(this.transitionSnow))
      return;
    SfxSystem.SetParam(this.transitionSnow, "transition_end", 1f);
  }

  public void GoldCounterStart(GoldDisplay display, float addAmount)
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

  public void GoldCounterStop()
  {
    if (!SfxSystem.IsRunning(this.goldCounter))
      return;
    SfxSystem.Stop(this.goldCounter);
  }

  public void MuncherDrag() => this.muncherFeed = this.Play("event:/sfx/location/muncher/feed");

  public void MuncherDragEnd()
  {
    if (!SfxSystem.IsRunning(this.muncherFeed))
      return;
    SfxSystem.Stop(this.muncherFeed);
  }

  public void MuncherFeed(Entity entity)
  {
    if (!SfxSystem.IsRunning(this.muncherFeed))
      return;
    SfxSystem.Stop(this.muncherFeed);
    SfxSystem.OneShot("event:/sfx/location/muncher/eat");
  }

  public static void BombardShoot(Entity entity)
  {
    SfxSystem.OneShot("event:/sfx/specific/boss_shooting");
  }

  public static void BombardRocketFall(BombardRocket rocket)
  {
    SfxSystem.OneShot("event:/sfx/specific/boss_rockets_flying");
  }

  public static void BombardRocketExplode(BombardRocket rocket)
  {
    SfxSystem.OneShot("event:/sfx/specific/boss_rockets_impact");
  }

  public static void ButtonHover(ButtonType buttonType)
  {
    if (buttonType != ButtonType.Bell)
      SfxSystem.OneShot("event:/sfx/ui/menu_hover");
    else
      SfxSystem.OneShot("event:/sfx/modifiers/bell_hovering");
  }

  public static void ButtonPress(ButtonType buttonType)
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

  public void ProgressStart(float fill)
  {
    this.townProgressionLoop = SfxSystem.Loop("event:/sfx/town_progress/ramp");
    SfxSystem.SetParam(this.townProgressionLoop, "townramp", fill);
  }

  public void ProgressUpdate(float fill)
  {
    if (!SfxSystem.IsRunning(this.townProgressionLoop))
      return;
    SfxSystem.SetParam(this.townProgressionLoop, "townramp", fill);
  }

  public void ProgressStop() => SfxSystem.Stop(this.townProgressionLoop);

  public static void ProgressDing() => SfxSystem.OneShot("event:/sfx/town_progress/achieved");

  public static void ProgressBlip() => SfxSystem.OneShot("event:/sfx/town_progress/blip");

  public static void TownUnlockPopUp(UnlockData unlockData)
  {
    SfxSystem.OneShot("event:/sfx/town_progress/notification");
  }

  public static void UpgradeHover(UpgradeDisplay upgradeDisplay)
  {
    if (upgradeDisplay.data.type != CardUpgradeData.Type.Crown)
      SfxSystem.OneShot("event:/sfx/inventory/charm_hover");
    else
      SfxSystem.OneShot("event:/sfx/inventory/crown_hover");
  }

  public static void UpgradePickup(UpgradeDisplay upgradeDisplay)
  {
    if (upgradeDisplay.data.type != CardUpgradeData.Type.Crown)
      SfxSystem.OneShot("event:/sfx/inventory/charm_pickup");
    else
      SfxSystem.OneShot("event:/sfx/inventory/crown_pickup");
  }

  public static void UpgradeDrop(UpgradeDisplay upgradeDisplay)
  {
    if (upgradeDisplay.data.type != CardUpgradeData.Type.Crown)
      SfxSystem.OneShot("event:/sfx/inventory/charm_return");
    else
      SfxSystem.OneShot("event:/sfx/inventory/crown_return");
  }

  public static void UpgradeAssign(Entity entity, CardUpgradeData upgradeData)
  {
    if (upgradeData.type != CardUpgradeData.Type.Crown)
      return;
    SfxSystem.OneShot("event:/sfx/inventory/crown_assign");
  }

  public static void ShopItemHover(ShopItem shopItem)
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

  public static void AbilityTargetAdd(CardContainer container)
  {
    SfxSystem.OneShot("event:/sfx/specific/boss_targets");
  }

  public static void EntityPing(GameObject obj) => SfxSystem.OneShot("event:/sfx/card/ping");

  public void StopAll(FMOD.Studio.STOP_MODE stopMode = FMOD.Studio.STOP_MODE.IMMEDIATE)
  {
    foreach (EventInstance eventInstance in this.running)
    {
      int num1 = (int) eventInstance.stop(stopMode);
      int num2 = (int) eventInstance.release();
    }
    SfxSystem.cooldowns.Clear();
  }

  public readonly struct Param
  {
    public readonly string name;
    public readonly float value;

    public Param(string name, float value)
    {
      this.name = name;
      this.value = value;
    }
  }

  public class Cooldown
  {
    public string eventName;
    public float current;
    public readonly float max;

    public Cooldown(string eventName, float value)
    {
      this.eventName = eventName;
      this.current = 0.0f;
      this.max = value;
    }

    public void Max() => this.current = this.max;
  }
}
