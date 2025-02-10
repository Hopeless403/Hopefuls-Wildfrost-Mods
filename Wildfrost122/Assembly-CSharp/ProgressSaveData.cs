// Decompiled with JetBrains decompiler
// Type: ProgressSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;

#nullable disable
[Serializable]
public class ProgressSaveData
{
  public int nextSeed;
  public int tutorialProgress;
  public bool tutorialCharmDone;
  public bool tutorialInjuryDone;
  public CardSaveData[] finalBossEnemies;

  public static ProgressSaveData Default()
  {
    return new ProgressSaveData()
    {
      nextSeed = Dead.Random.Seed()
    };
  }
}
