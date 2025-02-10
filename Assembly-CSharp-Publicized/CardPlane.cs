// Decompiled with JetBrains decompiler
// Type: CardPlane
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;
using UnityEngine;

public class CardPlane : CardContainer
{
  public readonly Dictionary<Entity, Vector3> positions = new Dictionary<Entity, Vector3>();

  public override float CardScale => 1f;

  public override void Add(Entity entity)
  {
    base.Add(entity);
    this.StorePosition(entity);
  }

  public override void Insert(int index, Entity entity)
  {
    base.Insert(index, entity);
    this.StorePosition(entity);
  }

  public override void Remove(Entity entity)
  {
    base.Remove(entity);
    this.FreePosition(entity);
  }

  public override Vector3 GetChildPosition(Entity child) => !this.positions.ContainsKey(child) ? Vector3.zero : this.positions[child];

  public void StorePosition(Entity entity) => this.positions[entity] = entity.transform.localPosition;

  public void FreePosition(Entity entity) => this.positions.Remove(entity);
}
