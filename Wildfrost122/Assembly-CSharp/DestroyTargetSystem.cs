// Decompiled with JetBrains decompiler
// Type: DestroyTargetSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class DestroyTargetSystem : GameSystem
{
  [SerializeField]
  private Transform targetPrefab;
  [SerializeField]
  private Vector3 iconOffset;
  private Entity dragging;
  private Entity hover;
  private readonly Dictionary<Transform, Entity> targets = new Dictionary<Transform, Entity>();
  private readonly List<Transform> targetPool = new List<Transform>();
  private readonly HashSet<Entity> toIndicate = new HashSet<Entity>();

  private void OnEnable()
  {
    global::Events.OnEntityDrag += new UnityAction<Entity>(this.EntityDrag);
    global::Events.OnEntityRelease += new UnityAction<Entity>(this.EntityRelease);
    global::Events.OnEntityHover += new UnityAction<Entity>(this.EntityHover);
    global::Events.OnEntityUnHover += new UnityAction<Entity>(this.EntityUnHover);
  }

  private void OnDisable()
  {
    global::Events.OnEntityDrag -= new UnityAction<Entity>(this.EntityDrag);
    global::Events.OnEntityRelease -= new UnityAction<Entity>(this.EntityRelease);
    global::Events.OnEntityHover -= new UnityAction<Entity>(this.EntityHover);
    global::Events.OnEntityUnHover -= new UnityAction<Entity>(this.EntityUnHover);
  }

  private void Start()
  {
    global::Events.OnSettingChanged += new UnityAction<string, object>(this.SettingChanged);
    if (Settings.Load<int>("UnitTargets", 1) == 1)
      return;
    this.enabled = false;
  }

  private void OnDestroy()
  {
    global::Events.OnSettingChanged -= new UnityAction<string, object>(this.SettingChanged);
  }

  private void Update()
  {
    foreach (KeyValuePair<Transform, Entity> target in this.targets)
    {
      Transform offset = target.Value.offset;
      Vector3 lossyScale = offset.lossyScale;
      target.Key.position = offset.position + Vector3.Scale(this.iconOffset, lossyScale);
      target.Key.localScale = lossyScale;
    }
  }

  private void EntityDrag(Entity entity)
  {
    this.dragging = entity;
    if (!(bool) (UnityEngine.Object) this.hover)
      return;
    this.HideTargets();
  }

  private void EntityRelease(Entity entity)
  {
    if (!((UnityEngine.Object) this.dragging == (UnityEngine.Object) entity))
      return;
    this.dragging = (Entity) null;
  }

  private void EntityHover(Entity entity)
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

  private void EntityUnHover(Entity entity)
  {
    if (!((UnityEngine.Object) this.hover == (UnityEngine.Object) entity))
      return;
    this.hover = (Entity) null;
    this.HideTargets();
  }

  private void SettingChanged(string key, object value)
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

  private void ShowTargets(Entity entity)
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

  private static bool CheckStatusEffectType(StatusEffectApplyX applyEffect)
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

  private static bool CheckApplyStatusEffectType(StatusEffectData applyEffect)
  {
    return applyEffect is StatusEffectInstantKill || applyEffect is StatusEffectInstantSacrifice;
  }

  private static void CheckShowIconsForHand(
    StatusEffectApplyX applyEffect,
    HashSet<Entity> toIndicate)
  {
    toIndicate.AddRange<Entity>(References.Player.handContainer.Where<Entity>((Func<Entity, bool>) (card => (UnityEngine.Object) card != (UnityEngine.Object) applyEffect.target && applyEffect.CheckConstraints(card))));
  }

  private static void CheckShowIconsForRightCardInHand(
    StatusEffectApplyX applyEffect,
    HashSet<Entity> toIndicate)
  {
    CardContainer handContainer = References.Player.handContainer;
    if (handContainer == null || handContainer.Count <= 0 || !applyEffect.CheckConstraints(References.Player.handContainer[0]))
      return;
    toIndicate.Add(References.Player.handContainer[0]);
  }

  private void HideTargets()
  {
    foreach (KeyValuePair<Transform, Entity> target in this.targets)
    {
      target.Key.gameObject.SetActive(false);
      this.targetPool.Add(target.Key);
    }
    this.targets.Clear();
  }

  private void ShowIcon(Entity entity) => this.targets.Add(this.PullIcon(), entity);

  private Transform PullIcon()
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
