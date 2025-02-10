// Decompiled with JetBrains decompiler
// Type: GameMode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using UnityEngine;

[CreateAssetMenu(fileName = "GameMode", menuName = "Game Mode")]
public class GameMode : DataFile
{
  public string saveFileName = "";
  public string seed;
  public ClassData[] classes;
  public CampaignGenerator generator;
  public CampaignPopulator populator;
  public bool startInNode;
  public bool takeStartingPet = true;
  public bool countsAsWin = true;
  public bool showStats = true;
  public bool gainProgress = true;
  public bool doSave = true;
  public bool canRestart = true;
  public bool canGoBack = true;
  public bool submitScore;
  public bool mainGameMode = true;
  public bool dailyRun;
  public bool tutorialRun;
  [ShowIf("submitScore")]
  public Scores.Type leaderboardType;
  public string startScene;
  public string sceneAfterSelection = "Campaign";
  public string[] campaignSystemNames;
  public string[] systemsToDisable;
}
