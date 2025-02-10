// Decompiled with JetBrains decompiler
// Type: ActionCombine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

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
