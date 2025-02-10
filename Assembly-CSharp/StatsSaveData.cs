// Decompiled with JetBrains decompiler
// Type: StatsSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using UnityEngine;

[Serializable]
public class StatsSaveData
{
  public float playTime;
  public int gamesPlayed;
  public int wins;
  public int trueWins;
  public int cardsPlayed;
  [Header("Combat")]
  public int kills;
  public int bossesKilled;
  public int damageDealt;
  public int damageTaken;
  public int highestDamageHit;
  public int battlesWon;
  public int goldGained;
  public int goldSpent;
  public float quickestBattleWin;
  [Header("Score")]
  public int bestScore;
  public float bestTime;
}
