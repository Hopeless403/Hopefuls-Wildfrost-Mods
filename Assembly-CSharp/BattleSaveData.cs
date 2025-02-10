// Decompiled with JetBrains decompiler
// Type: BattleSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;

[Serializable]
public class BattleSaveData
{
  public int campaignNodeId;
  public int turnCount;
  public int redrawBellCount;
  public BattleSaveData.ContainerGroup playerRows;
  public BattleSaveData.ContainerGroup enemyRows;
  public BattleSaveData.Container playerHand;
  public BattleSaveData.Container playerDraw;
  public BattleSaveData.Container playerDiscard;
  public BattleSaveData.Container playerReserve;
  public BattleSaveData.Container enemyReserve;
  public BattleSaveData.Status[] statuses;
  public BattleEntityData[] destroyed;
  public BattleWaveData enemyWaves;
  public BattleMusicSaveData battleMusicState;
  public Dictionary<string, object> storeStatusData = new Dictionary<string, object>();
  public int gold;

  [Serializable]
  public class ContainerGroup
  {
    public BattleSaveData.Container[] containers;

    public ContainerGroup()
    {
    }

    public ContainerGroup(IEnumerable<CardContainer> containers) => this.containers = containers.Select<CardContainer, BattleSaveData.Container>((Func<CardContainer, BattleSaveData.Container>) (a => new BattleSaveData.Container(a))).ToArray<BattleSaveData.Container>();
  }

  [Serializable]
  public class Container
  {
    public BattleEntityData[] cards;

    public Container()
    {
    }

    public Container(CardContainer container)
    {
      if (container is CardSlotLane cardSlotLane)
        this.cards = cardSlotLane.slots.Select<CardSlot, BattleEntityData>((Func<CardSlot, BattleEntityData>) (a =>
        {
          Entity top = a.GetTop();
          return top == null ? (BattleEntityData) null : new BattleEntityData(top);
        })).ToArray<BattleEntityData>();
      else
        this.cards = container.Select<Entity, BattleEntityData>((Func<Entity, BattleEntityData>) (a => new BattleEntityData(a))).ToArray<BattleEntityData>();
    }
  }

  [Serializable]
  public class Status
  {
    public string name;
    public int count;
    public ulong targetId;
    public bool hasApplier;
    public ulong applierId;

    public Status()
    {
    }

    public Status(StatusEffectData data)
    {
      this.name = data.name;
      this.count = data.count - data.temporary;
      this.targetId = data.target.data.id;
      this.hasApplier = (bool) (UnityEngine.Object) data.applier;
      if (!this.hasApplier)
        return;
      this.applierId = data.applier.data.id;
    }
  }
}
