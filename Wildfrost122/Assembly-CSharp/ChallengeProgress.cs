// Decompiled with JetBrains decompiler
// Type: ChallengeProgress
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;

#nullable disable
[Serializable]
public class ChallengeProgress
{
  public string challengeName;
  public int currentValue;
  public int originalValue;

  public ChallengeProgress()
  {
  }

  public ChallengeProgress(string challengeName, int value)
  {
    this.challengeName = challengeName;
    this.currentValue = value;
    this.originalValue = value;
  }
}
