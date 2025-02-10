// Decompiled with JetBrains decompiler
// Type: ChallengeProgress
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;

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
