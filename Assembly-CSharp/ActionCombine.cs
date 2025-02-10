// Decompiled with JetBrains decompiler
// Type: ActionCombine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ActionCombine : PlayAction
{
  private readonly Entity[] entities;
  private readonly Entity finalEntity;

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
