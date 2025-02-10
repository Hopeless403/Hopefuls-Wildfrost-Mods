// Decompiled with JetBrains decompiler
// Type: ProgressSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;

[Serializable]
public class ProgressSaveData
{
  public int nextSeed;
  public int tutorialProgress;
  public bool tutorialCharmDone;
  public bool tutorialInjuryDone;
  public CardSaveData[] finalBossEnemies;

  public static ProgressSaveData Default() => new ProgressSaveData()
  {
    nextSeed = Dead.Random.Seed()
  };
}
