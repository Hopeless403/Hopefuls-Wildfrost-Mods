// Decompiled with JetBrains decompiler
// Type: DropGoldSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class DropGoldSystem : GameSystem
{
  [SerializeField]
  public float goldFactor = 0.02f;
  [SerializeField]
  public int goldPerUpgrade = 5;
  [SerializeField]
  public bool dropGoldOnFlee = true;

  public void OnEnable()
  {
    global::Events.OnEntityKilled += new UnityAction<Entity, DeathType>(this.EntityKilled);
    global::Events.OnEntityFlee += new UnityAction<Entity>(this.EntityFlee);
  }

  public void OnDisable()
  {
    global::Events.OnEntityKilled -= new UnityAction<Entity, DeathType>(this.EntityKilled);
    global::Events.OnEntityFlee -= new UnityAction<Entity>(this.EntityFlee);
  }

  public void EntityKilled(Entity entity, DeathType deathType)
  {
    if (deathType != DeathType.Normal)
      return;
    this.TryDropGold(entity, "Kill");
  }

  public void EntityFlee(Entity entity)
  {
    if (!this.dropGoldOnFlee)
      return;
    this.TryDropGold(entity, "Flee");
  }

  public void TryDropGold(Entity entity, string source)
  {
    if ((bool) (Object) entity.owner && entity.owner.team == References.Player.team)
      return;
    int goldToDrop = this.GetGoldToDrop(entity);
    if (goldToDrop <= 0)
      return;
    global::Events.InvokeDropGold(goldToDrop, source, References.Player, entity.transform.position);
  }

  public int GetGoldToDrop(Entity entity)
  {
    int num = Mathf.RoundToInt((float) entity.data.value * this.goldFactor * References.PlayerData.enemyGoldFactor);
    int goldToDrop = num > 0 ? Mathf.Max(0, num + Mathf.RoundToInt(entity.data.random3.z)) : 0;
    if (entity.data.upgrades != null)
      goldToDrop += entity.data.upgrades.Count * this.goldPerUpgrade;
    return goldToDrop;
  }
}
