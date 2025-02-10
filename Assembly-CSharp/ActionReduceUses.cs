// Decompiled with JetBrains decompiler
// Type: ActionReduceUses
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

public class ActionReduceUses : PlayAction
{
  public readonly Entity entity;

  public ActionReduceUses(Entity entity) => this.entity = entity;

  public override IEnumerator Run()
  {
    if ((bool) (Object) this.entity)
      yield return (object) ActionReduceUses.CardReduceUses(this.entity);
  }

  private static IEnumerator CardReduceUses(Entity entity)
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
