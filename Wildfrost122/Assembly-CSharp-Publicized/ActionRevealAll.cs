// Decompiled with JetBrains decompiler
// Type: ActionRevealAll
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;
using UnityEngine;

#nullable disable
public class ActionRevealAll : PlayAction
{
  public readonly CardContainer[] containers;

  public ActionRevealAll(params CardContainer[] containers) => this.containers = containers;

  public override bool IsRoutine => false;

  public override void Process()
  {
    HashSet<Entity> entitySet = new HashSet<Entity>();
    float pauseAfter = 0.167f;
    int num = 1;
    foreach (CardContainer container in this.containers)
    {
      if (!((Object) container == (Object) null))
      {
        foreach (Entity entity in container)
        {
          if (!((Object) entity == (Object) null))
          {
            if (entity.flipper.flipped)
              ActionQueue.Insert(num++, (PlayAction) new ActionReveal(entity, pauseAfter));
            if (!entity.enabled)
              entitySet.Add(entity);
          }
        }
      }
    }
    foreach (Entity entity in entitySet)
      ActionQueue.Insert(num++, (PlayAction) new ActionRunEnableEvent(entity));
  }
}
