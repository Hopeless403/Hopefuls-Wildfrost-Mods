// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.GameModeBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

namespace Deadpan.Enums.Engine.Components.Modding
{
  public class GameModeBuilder : DataFileBuilder<GameMode, GameModeBuilder>
  {
    public GameModeBuilder(WildfrostMod mod)
      : base(mod)
    {
    }

    public GameModeBuilder()
    {
    }

    public GameModeBuilder WithSaveFileName(string saveFileName)
    {
      this._data.saveFileName = saveFileName;
      return this;
    }

    public GameModeBuilder WithSeed(string seed)
    {
      this._data.seed = seed;
      return this;
    }

    public GameModeBuilder WithClasses(params ClassData[] classes)
    {
      this._data.classes = classes;
      return this;
    }

    public GameModeBuilder WithGenerator(CampaignGenerator generator)
    {
      this._data.generator = generator;
      return this;
    }

    public GameModeBuilder WithPopulator(CampaignPopulator populator)
    {
      this._data.populator = populator;
      return this;
    }

    public GameModeBuilder WithStartInNode(bool startInNode)
    {
      this._data.startInNode = startInNode;
      return this;
    }

    public GameModeBuilder WithTakeStartingPet(bool takeStartingPet = true)
    {
      this._data.takeStartingPet = takeStartingPet;
      return this;
    }

    public GameModeBuilder WithCountsAsWin(bool countsAsWin = true)
    {
      this._data.countsAsWin = countsAsWin;
      return this;
    }

    public GameModeBuilder WithShowStats(bool showStats = true)
    {
      this._data.showStats = showStats;
      return this;
    }

    public GameModeBuilder WithGainProgress(bool gainProgress = true)
    {
      this._data.gainProgress = gainProgress;
      return this;
    }

    public GameModeBuilder WithDoSave(bool doSave = true)
    {
      this._data.doSave = doSave;
      return this;
    }

    public GameModeBuilder WithCanRestart(bool canRestart = true)
    {
      this._data.canRestart = canRestart;
      return this;
    }

    public GameModeBuilder WithCanGoBack(bool canGoBack = true)
    {
      this._data.canGoBack = canGoBack;
      return this;
    }

    public GameModeBuilder WithSubmitScore(bool submitScore = false)
    {
      this._data.submitScore = submitScore;
      return this;
    }

    public GameModeBuilder WithMainGameMode(bool mainGameMode = true)
    {
      this._data.mainGameMode = mainGameMode;
      return this;
    }

    public GameModeBuilder WithDailyRun(bool dailyRun = false)
    {
      this._data.dailyRun = dailyRun;
      return this;
    }

    public GameModeBuilder WithTutorialRun(bool tutorialRun = false)
    {
      this._data.tutorialRun = tutorialRun;
      return this;
    }

    public GameModeBuilder WithLeaderboardType(Scores.Type leaderboardType)
    {
      this._data.leaderboardType = leaderboardType;
      return this;
    }

    public GameModeBuilder WithStartScene(string startScene)
    {
      this._data.startScene = startScene;
      return this;
    }

    public GameModeBuilder WithSceneAfterSelection(string sceneAfterSelection = "Campaign")
    {
      this._data.sceneAfterSelection = sceneAfterSelection;
      return this;
    }

    public GameModeBuilder WithCampaignSystemNames(params string[] campaignSystemNames)
    {
      this._data.campaignSystemNames = campaignSystemNames;
      return this;
    }

    public GameModeBuilder WithSystemsToDisable(params string[] systemsToDisable)
    {
      this._data.systemsToDisable = systemsToDisable;
      return this;
    }
  }
}
