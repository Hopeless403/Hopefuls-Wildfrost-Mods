// Decompiled with JetBrains decompiler
// Type: IdleAnimationSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IdleAnimationSystem : GameSystem
{
  private readonly List<Entity> current = new List<Entity>();

  private void OnEnable()
  {
    global::Events.OnEntityHover += new UnityAction<Entity>(this.EntityHover);
    global::Events.OnEntityUnHover += new UnityAction<Entity>(this.EntityUnHover);
    this.current.Clear();
  }

  private void OnDisable()
  {
    global::Events.OnEntityHover -= new UnityAction<Entity>(this.EntityHover);
    global::Events.OnEntityUnHover -= new UnityAction<Entity>(this.EntityUnHover);
  }

  private void EntityHover(Entity entity)
  {
    if (!(bool) (Object) entity.data.idleAnimationProfile || !(entity.display is Card display))
      return;
    display.imageIdleAnimator.FadeIn();
    display.backgroundIdleAnimator.FadeIn();
    this.current.Add(entity);
  }

  private void EntityUnHover(Entity entity)
  {
    if (!this.current.Contains(entity) || !(entity.display is Card display))
      return;
    display.imageIdleAnimator.FadeOut();
    display.backgroundIdleAnimator.FadeOut();
    this.current.Remove(entity);
  }
}
