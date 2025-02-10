// Decompiled with JetBrains decompiler
// Type: DestroyTargetSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class DestroyTargetSystem : GameSystem
{
  [SerializeField]
  public Transform targetPrefab;
  [SerializeField]
  public Vector3 iconOffset;
  public Entity dragging;
  public Entity hover;
  public readonly Dictionary<Transform, Entity> targets = new Dictionary<Transform, Entity>();
  public readonly List<Transform> targetPool = new List<Transform>();
  public readonly HashSet<Entity> toIndicate = new HashSet<Entity>();

  public void OnEnable()
  {
    global::Events.OnEntityDrag += new UnityAction<Entity>(this.EntityDrag);
    global::Events.OnEntityRelease += new UnityAction<Entity>(this.EntityRelease);
    global::Events.OnEntityHover += new UnityAction<Entity>(this.EntityHover);
    global::Events.OnEntityUnHover += new UnityAction<Entity>(this.EntityUnHover);
  }

  public void OnDisable()
  {
    global::Events.OnEntityDrag -= new UnityAction<Entity>(this.EntityDrag);
    global::Events.OnEntityRelease -= new UnityAction<Entity>(this.EntityRelease);
    global::Events.OnEntityHover -= new UnityAction<Entity>(this.EntityHover);
    global::Events.OnEntityUnHover -= new UnityAction<Entity>(this.EntityUnHover);
  }

  public void Start()
  {
    global::Events.OnSettingChanged += new UnityAction<string, object>(this.SettingChanged);
    if (Settings.Load<int>("UnitTargets", 1) == 1)
      return;
    this.enabled = false;
  }

  public void OnDestroy()
  {
    global::Events.OnSettingChanged -= new UnityAction<string, object>(this.SettingChanged);
  }

  public void Update()
  {
    foreach (KeyValuePair<Transform, Entity> target in this.targets)
    {
      Transform offset = target.Value.offset;
      Vector3 lossyScale = offset.lossyScale;
      target.Key.position = offset.position + Vector3.Scale(this.iconOffset, lossyScale);
      target.Key.localScale = lossyScale;
    }
  }

  public void EntityDrag(Entity entity)
  {
    this.dragging = entity;
    if (!(bool) (UnityEngine.Object) this.hover)
      return;
    this.HideTargets();
  }

  public void EntityRelease(Entity entity)
  {
    if (!((UnityEngine.Object) this.dragging == (UnityEngine.Object) entity))
      return;
    this.dragging = (Entity) null;
  }

  public void EntityHover(Entity entity)
  {
    if ((bool) (UnityEngine.Object) this.dragging)
      return;
    if ((bool) (UnityEngine.Object) this.hover)
      this.EntityUnHover(this.hover);
    this.hover = entity;
    if (!entity.inPlay)
      return;
    this.ShowTargets(this.hover);
  }

  public void EntityUnHover(Entity entity)
  {
    if (!((UnityEngine.Object) this.hover == (UnityEngine.Object) entity))
      return;
    this.hover = (Entity) null;
    this.HideTargets();
  }

  public void SettingChanged(string key, object value)
  {
    if (!(key == "UnitTargets") || !(value is int num))
      return;
    if (num == 0 && this.enabled)
    {
      this.enabled = false;
    }
    else
    {
      if (num != 1 || this.enabled)
        return;
      this.enabled = true;
    }
  }

  public void ShowTargets(Entity entity)
  {
    if (entity.silenced)
      return;
    foreach (StatusEffectData statusEffect in entity.statusEffects)
    {
      StatusEffectApplyX applyEffect = statusEffect as StatusEffectApplyX;
      if (applyEffect != null && !statusEffect.doesDamage)
      {
        if (DestroyTargetSystem.CheckStatusEffectType(applyEffect))
        {
          if ((applyEffect.applyToFlags & StatusEffectApplyX.ApplyToFlags.Hand) != StatusEffectApplyX.ApplyToFlags.None)
            DestroyTargetSystem.CheckShowIconsForHand(applyEffect, this.toIndicate);
          if ((applyEffect.applyToFlags & StatusEffectApplyX.ApplyToFlags.RightCardInHand) != StatusEffectApplyX.ApplyToFlags.None)
            DestroyTargetSystem.CheckShowIconsForRightCardInHand(applyEffect, this.toIndicate);
        }
        else
        {
          StatusEffectInstantDestroyCardsInHandAndApplyXForEach destroyAllEffect = applyEffect.effectToApply as StatusEffectInstantDestroyCardsInHandAndApplyXForEach;
          if (destroyAllEffect != null)
            this.toIndicate.AddRange<Entity>(References.Player.handContainer.Where<Entity>((Func<Entity, bool>) (card => (UnityEngine.Object) card != (UnityEngine.Object) applyEffect.target && destroyAllEffect.CheckConstraints(card))));
        }
      }
      else if (statusEffect is StatusEffectRecycle statusEffectRecycle)
      {
        int amount = statusEffectRecycle.GetAmount();
        foreach (Entity entity1 in References.Player.handContainer)
        {
          if (entity1.data.name == statusEffectRecycle.cardToRecycle)
          {
            this.toIndicate.Add(entity1);
            if (--amount <= 0)
              break;
          }
        }
      }
    }
    foreach (Entity entity2 in this.toIndicate)
      this.ShowIcon(entity2);
    this.toIndicate.Clear();
  }

  public static bool CheckStatusEffectType(StatusEffectApplyX applyEffect)
  {
    if (DestroyTargetSystem.CheckApplyStatusEffectType(applyEffect.effectToApply))
      return true;
    if (applyEffect.effectToApply is StatusEffectInstantMultiple effectToApply)
    {
      foreach (StatusEffectData effect in effectToApply.effects)
      {
        if (DestroyTargetSystem.CheckApplyStatusEffectType(effect))
          return true;
      }
    }
    return false;
  }

  public static bool CheckApplyStatusEffectType(StatusEffectData applyEffect)
  {
    return applyEffect is StatusEffectInstantKill || applyEffect is StatusEffectInstantSacrifice;
  }

  public static void CheckShowIconsForHand(
    StatusEffectApplyX applyEffect,
    HashSet<Entity> toIndicate)
  {
    toIndicate.AddRange<Entity>(References.Player.handContainer.Where<Entity>((Func<Entity, bool>) (card => (UnityEngine.Object) card != (UnityEngine.Object) applyEffect.target && applyEffect.CheckConstraints(card))));
  }

  public static void CheckShowIconsForRightCardInHand(
    StatusEffectApplyX applyEffect,
    HashSet<Entity> toIndicate)
  {
    CardContainer handContainer = References.Player.handContainer;
    if (handContainer == null || handContainer.Count <= 0 || !applyEffect.CheckConstraints(References.Player.handContainer[0]))
      return;
    toIndicate.Add(References.Player.handContainer[0]);
  }

  public void HideTargets()
  {
    foreach (KeyValuePair<Transform, Entity> target in this.targets)
    {
      target.Key.gameObject.SetActive(false);
      this.targetPool.Add(target.Key);
    }
    this.targets.Clear();
  }

  public void ShowIcon(Entity entity) => this.targets.Add(this.PullIcon(), entity);

  public Transform PullIcon()
  {
    Transform transform;
    if (this.targetPool.Count > 0)
    {
      transform = this.targetPool[0];
      this.targetPool.RemoveAt(0);
    }
    else
      transform = UnityEngine.Object.Instantiate<Transform>(this.targetPrefab, this.transform);
    transform.gameObject.SetActive(true);
    return transform;
  }
}
