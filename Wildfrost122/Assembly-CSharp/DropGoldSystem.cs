// Decompiled with JetBrains decompiler
// Type: DropGoldSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class DropGoldSystem : GameSystem
{
  [SerializeField]
  private float goldFactor = 0.02f;
  [SerializeField]
  private int goldPerUpgrade = 5;
  [SerializeField]
  private bool dropGoldOnFlee = true;

  private void OnEnable()
  {
    global::Events.OnEntityKilled += new UnityAction<Entity, DeathType>(this.EntityKilled);
    global::Events.OnEntityFlee += new UnityAction<Entity>(this.EntityFlee);
  }

  private void OnDisable()
  {
    global::Events.OnEntityKilled -= new UnityAction<Entity, DeathType>(this.EntityKilled);
    global::Events.OnEntityFlee -= new UnityAction<Entity>(this.EntityFlee);
  }

  private void EntityKilled(Entity entity, DeathType deathType)
  {
    if (deathType != DeathType.Normal)
      return;
    this.TryDropGold(entity, "Kill");
  }

  private void EntityFlee(Entity entity)
  {
    if (!this.dropGoldOnFlee)
      return;
    this.TryDropGold(entity, "Flee");
  }

  private void TryDropGold(Entity entity, string source)
  {
    if ((bool) (Object) entity.owner && entity.owner.team == References.Player.team)
      return;
    int goldToDrop = this.GetGoldToDrop(entity);
    if (goldToDrop <= 0)
      return;
    global::Events.InvokeDropGold(goldToDrop, source, References.Player, entity.transform.position);
  }

  private int GetGoldToDrop(Entity entity)
  {
    int num = Mathf.RoundToInt((float) entity.data.value * this.goldFactor * References.PlayerData.enemyGoldFactor);
    int goldToDrop = num > 0 ? Mathf.Max(0, num + Mathf.RoundToInt(entity.data.random3.z)) : 0;
    if (entity.data.upgrades != null)
      goldToDrop += entity.data.upgrades.Count * this.goldPerUpgrade;
    return goldToDrop;
  }
}
