// Decompiled with JetBrains decompiler
// Type: CharacterSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using UnityEngine;

[Serializable]
public class CharacterSaveData : ILoadable<Character>
{
  public string name;
  public string title;
  public int team;
  public ClassSaveData classData;
  public InventorySaveData inventoryData;
  [Header("Stats")]
  public int handSize = 6;
  public int redrawBell = 4;
  public int companionLimit = 3;
  public float enemyGoldFactor = 1f;
  public float comboGoldFactor = 1f;

  public CharacterSaveData()
  {
  }

  public CharacterSaveData(Character character)
  {
    this.name = character.name;
    this.title = character.title;
    this.team = character.team;
    this.classData = character.data.classData.Save();
    this.inventoryData = character.data.inventory.Save();
    this.handSize = character.data.handSize;
    this.redrawBell = character.data.redrawBell;
    this.companionLimit = character.data.companionLimit;
    this.enemyGoldFactor = character.data.enemyGoldFactor;
    this.comboGoldFactor = character.data.comboGoldFactor;
  }

  public Character Load()
  {
    PlayerData data = this.LoadPlayerData();
    data.handSize = this.handSize;
    data.redrawBell = this.redrawBell;
    data.companionLimit = this.companionLimit;
    data.enemyGoldFactor = this.enemyGoldFactor;
    data.comboGoldFactor = this.comboGoldFactor;
    Character character = UnityEngine.Object.Instantiate<Character>(data.classData.characterPrefab);
    character.name = this.name;
    character.title = this.title;
    character.team = this.team;
    character.Assign(data);
    return character;
  }

  public PlayerData LoadPlayerData() => new PlayerData(this.classData.Load(), this.inventoryData.Load());
}
