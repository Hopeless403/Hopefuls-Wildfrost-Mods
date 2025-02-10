// Decompiled with JetBrains decompiler
// Type: PlayerData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using UnityEngine;

[Serializable]
public class PlayerData
{
  public ClassData classData;
  [Header("Stats")]
  public int handSize = 6;
  public int redrawBell = 4;
  public int companionLimit = 3;
  public float enemyGoldFactor = 1f;
  public float comboGoldFactor = 1f;
  [Header("Inventory")]
  public Inventory inventory;

  public PlayerData(ClassData classData, Inventory inventory)
  {
    this.classData = classData;
    this.inventory = inventory;
  }
}
