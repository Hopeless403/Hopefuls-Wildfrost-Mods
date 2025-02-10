// Decompiled with JetBrains decompiler
// Type: ChallengeListenerSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
public abstract class ChallengeListenerSystem : GameSystem
{
  private ChallengeData challengeData;
  private ChallengeSystem challengeSystem;

  public void Assign(ChallengeData challengeData, ChallengeSystem challengeSystem)
  {
    this.challengeData = challengeData;
    this.challengeSystem = challengeSystem;
  }

  protected void Complete()
  {
    ChallengeProgressSystem.AddProgress(this.challengeData.name, 1);
    this.challengeSystem.SetAsComplete(this.challengeData);
    Object.Destroy((Object) this);
  }
}
