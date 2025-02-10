// Decompiled with JetBrains decompiler
// Type: ChallengeListenerSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
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
