﻿// Decompiled with JetBrains decompiler
// Type: ClassData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using FMODUnity;
using NaughtyAttributes;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "New Class", menuName = "Character/Class")]
public class ClassData : DataFile, ISaveable<ClassSaveData>
{
  public string id;
  public UnlockData requiresUnlock;
  public Inventory startingInventory;
  public CardData[] leaders;
  public Character characterPrefab;
  public RewardPool[] rewardPools;
  public EventReference selectSfxEvent;
  [ShowAssetPreview(64, 64)]
  public Sprite flag;

  public ClassSaveData Save() => new ClassSaveData(this.name);

  public override string ToString() => this.name;
}
