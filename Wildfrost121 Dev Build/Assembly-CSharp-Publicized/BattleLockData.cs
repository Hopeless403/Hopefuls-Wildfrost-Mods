// Decompiled with JetBrains decompiler
// Type: BattleLockData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Battle Lock Data", fileName = "Battle Lock Data")]
public class BattleLockData : ScriptableObject
{
  public string battleName;
  public ChallengeData linkToChallenge;

  public bool IsLocked()
  {
    bool flag = !(SaveSystem.LoadProgressData<List<string>>("completedChallenges", (List<string>) null) ?? new List<string>()).Contains(this.linkToChallenge.name);
    if (flag)
      Debug.Log((object) ("Battle [" + this.battleName + "] is locked! Requires [" + this.linkToChallenge.name + "]"));
    return flag;
  }
}
