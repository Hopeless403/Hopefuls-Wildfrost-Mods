// Decompiled with JetBrains decompiler
// Type: ActionCombine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
public class ActionCombine : PlayAction
{
  public readonly Entity[] entities;
  public readonly Entity finalEntity;

  public ActionCombine(Entity[] entities)
  {
    this.entities = entities;
    this.finalEntity = ((IEnumerable<Entity>) entities).Last<Entity>();
  }

  public override IEnumerator Run()
  {
    if ((bool) (Object) CombineSystem.instance)
      yield return (object) CombineSystem.instance.Combine(this.entities, this.finalEntity);
  }
}
