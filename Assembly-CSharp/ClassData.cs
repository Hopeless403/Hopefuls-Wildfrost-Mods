// Decompiled with JetBrains decompiler
// Type: ClassData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using FMODUnity;
using NaughtyAttributes;
using UnityEngine;

[CreateAssetMenu(fileName = "New Class", menuName = "Character/Class")]
public class ClassData : DataFile, ISaveable<ClassSaveData>
{
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
