﻿// Decompiled with JetBrains decompiler
// Type: ActionReduceUses
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
public class ActionReduceUses : PlayAction
{
  public readonly Entity entity;

  public ActionReduceUses(Entity entity) => this.entity = entity;

  public override IEnumerator Run()
  {
    if ((bool) (Object) this.entity)
      yield return (object) ActionReduceUses.CardReduceUses(this.entity);
  }

  public static IEnumerator CardReduceUses(Entity entity)
  {
    if (entity.uses.max > 0 && entity.uses.current > 0)
    {
      if (--entity.uses.current <= 0)
      {
        if (entity.alive)
          yield return (object) Sequences.CardDiscard(entity);
      }
      else if (entity.alive)
        entity.TweenToContainer();
    }
  }
}
