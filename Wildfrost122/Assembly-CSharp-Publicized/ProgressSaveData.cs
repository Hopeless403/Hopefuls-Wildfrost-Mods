// Decompiled with JetBrains decompiler
// Type: ProgressSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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
