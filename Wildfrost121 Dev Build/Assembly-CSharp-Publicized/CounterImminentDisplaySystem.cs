﻿// Decompiled with JetBrains decompiler
// Type: CounterImminentDisplaySystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class CounterImminentDisplaySystem : GameSystem
{
  [SerializeField]
  public bool disableCardAnimationHover = true;
  [SerializeField]
  public bool disableIconAnimationHover = true;
  public List<Entity> currentImminent = new List<Entity>();
  public List<Entity> currentHover = new List<Entity>();

  public void OnEnable()
  {
    global::Events.OnEntityHover += new UnityAction<Entity>(this.EntityHover);
    global::Events.OnEntityUnHover += new UnityAction<Entity>(this.EntityUnHover);
    global::Events.OnEntityDisplayUpdated += new UnityAction<Entity>(this.EntityCheck);
    global::Events.OnEntityEnabled += new UnityAction<Entity>(this.EntityCheck);
    global::Events.OnEntityDisabled += new UnityAction<Entity>(this.EntityDisabled);
    global::Events.OnInspect += new UnityAction<Entity>(this.EntityHover);
    global::Events.OnInspectEnd += new UnityAction<Entity>(this.EntityUnHover);
  }

  public void OnDisable()
  {
    global::Events.OnEntityHover -= new UnityAction<Entity>(this.EntityHover);
    global::Events.OnEntityUnHover -= new UnityAction<Entity>(this.EntityUnHover);
    global::Events.OnEntityDisplayUpdated -= new UnityAction<Entity>(this.EntityCheck);
    global::Events.OnEntityEnabled -= new UnityAction<Entity>(this.EntityCheck);
    global::Events.OnEntityDisabled -= new UnityAction<Entity>(this.EntityDisabled);
    global::Events.OnInspect -= new UnityAction<Entity>(this.EntityHover);
    global::Events.OnInspectEnd -= new UnityAction<Entity>(this.EntityUnHover);
  }

  public void EntityHover(Entity entity)
  {
    if (!((Object) entity != (Object) null))
      return;
    this.currentHover.Add(entity);
    if (!this.currentImminent.Contains(entity))
      return;
    if (this.disableCardAnimationHover)
      this.SetCardAnimation(entity, false);
    if (!this.disableIconAnimationHover)
      return;
    this.SetCounterIconAnimation(entity, false);
  }

  public void EntityUnHover(Entity entity)
  {
    if (!((Object) entity != (Object) null))
      return;
    this.currentHover.Remove(entity);
    if (!entity.enabled || !this.currentImminent.Contains(entity))
      return;
    if (this.disableCardAnimationHover)
      this.SetCardAnimation(entity, true);
    if (!this.disableIconAnimationHover)
      return;
    this.SetCounterIconAnimation(entity, true);
  }

  public void EntityDisabled(Entity entity)
  {
    if (!this.currentImminent.Contains(entity))
      return;
    this.currentImminent.Remove(entity);
    this.SetCardAnimation(entity, false);
    this.SetCounterIconAnimation(entity, false);
  }

  public void SetCardAnimation(Entity entity, bool enable)
  {
    if (!((Object) entity.imminentAnimation != (Object) null))
      return;
    if (enable)
      entity.imminentAnimation.FadeIn();
    else
      entity.imminentAnimation.FadeOut();
  }

  public void SetCounterIconAnimation(Entity entity, bool enable)
  {
    if (!((Object) entity.display.counterIcon != (Object) null) || !(entity.display.counterIcon is StatusIconCounter counterIcon))
      return;
    CardIdleAnimation imminentAnimation = counterIcon.imminentAnimation;
    if (!((Object) imminentAnimation != (Object) null))
      return;
    if (enable)
      imminentAnimation.FadeIn();
    else
      imminentAnimation.FadeOut();
  }

  public void EntityCheck(Entity entity)
  {
    if (!entity.enabled)
      return;
    if (!this.currentImminent.Contains(entity))
    {
      if (!this.Imminent(entity))
        return;
      this.currentImminent.Add(entity);
      this.SetCardAnimation(entity, true);
      this.SetCounterIconAnimation(entity, true);
    }
    else
    {
      if (this.Imminent(entity))
        return;
      this.currentImminent.Remove(entity);
      this.SetCardAnimation(entity, false);
      this.SetCounterIconAnimation(entity, false);
    }
  }

  public bool Imminent(Entity entity) => !entity.IsSnowed && entity.counter.current == 1;
}
