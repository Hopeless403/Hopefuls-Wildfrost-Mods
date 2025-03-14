﻿// Decompiled with JetBrains decompiler
// Type: ChallengeListener
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Challenge Listener", menuName = "Town/Challenge Listener")]
public class ChallengeListener : DataFile
{
  public ChallengeListener.CheckType checkType;
  [ShowIf("CheckTypeCustomSystem")]
  public string systemName;
  [HideIf("CheckTypeCustomSystem")]
  public string stat;
  [HideIf("CheckTypeCustomSystem")]
  public bool hasKey;
  [HideIf("CheckTypeCustomSystem")]
  [ShowIf("hasKey")]
  public string key;
  [HideIf("CheckTypeCustomSystem")]
  public int target;

  public bool CheckTypeCustomSystem => this.checkType == ChallengeListener.CheckType.CustomSystem;

  public virtual bool Check(string stat, string key)
  {
    if (!(stat == this.stat))
      return false;
    return !this.hasKey || key == this.key;
  }

  public virtual bool CheckComplete(CampaignStats stats)
  {
    return stats.Get(this.stat, this.hasKey ? this.key : "", 0) >= this.target;
  }

  public virtual void Set(string challengeName, int oldValue, int newValue)
  {
    ChallengeListener.Add(challengeName, newValue - oldValue);
  }

  public static void Add(string challengeName, int value)
  {
    ChallengeProgressSystem.AddProgress(challengeName, value);
  }

  public void AddCustomSystem(ChallengeData challengeData, ChallengeSystem challengeSystem)
  {
    if (this.checkType != ChallengeListener.CheckType.CustomSystem)
      return;
    Component component = challengeSystem.gameObject.AddComponentByName(this.systemName);
    if (component is ChallengeListenerSystem challengeListenerSystem)
      challengeListenerSystem.Assign(challengeData, challengeSystem);
    else
      component.Destroy();
  }

  public enum CheckType
  {
    MidRun,
    EndOfRun,
    CustomSystem,
  }
}
