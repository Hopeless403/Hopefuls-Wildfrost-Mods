// Decompiled with JetBrains decompiler
// Type: ChallengeListenerSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public abstract class ChallengeListenerSystem : GameSystem
{
  public ChallengeData challengeData;
  public ChallengeSystem challengeSystem;

  public void Assign(ChallengeData challengeData, ChallengeSystem challengeSystem)
  {
    this.challengeData = challengeData;
    this.challengeSystem = challengeSystem;
  }

  public void Complete()
  {
    this.challengeSystem.SetAsComplete(this.challengeData);
    Object.Destroy((Object) this);
  }
}
