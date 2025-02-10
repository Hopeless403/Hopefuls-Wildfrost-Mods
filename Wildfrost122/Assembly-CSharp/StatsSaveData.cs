// Decompiled with JetBrains decompiler
// Type: StatsSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using UnityEngine;

#nullable disable
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
