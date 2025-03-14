﻿// Decompiled with JetBrains decompiler
// Type: IdleAnimationSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class IdleAnimationSystem : GameSystem
{
  public readonly List<Entity> current = new List<Entity>();

  public void OnEnable()
  {
    global::Events.OnEntityHover += new UnityAction<Entity>(this.EntityHover);
    global::Events.OnEntityUnHover += new UnityAction<Entity>(this.EntityUnHover);
    this.current.Clear();
  }

  public void OnDisable()
  {
    global::Events.OnEntityHover -= new UnityAction<Entity>(this.EntityHover);
    global::Events.OnEntityUnHover -= new UnityAction<Entity>(this.EntityUnHover);
  }

  public void EntityHover(Entity entity)
  {
    if (!(bool) (Object) entity.data.idleAnimationProfile || !(entity.display is Card display))
      return;
    display.imageIdleAnimator.FadeIn();
    display.backgroundIdleAnimator.FadeIn();
    this.current.Add(entity);
  }

  public void EntityUnHover(Entity entity)
  {
    if (!this.current.Contains(entity) || !(entity.display is Card display))
      return;
    display.imageIdleAnimator.FadeOut();
    display.backgroundIdleAnimator.FadeOut();
    this.current.Remove(entity);
  }
}
