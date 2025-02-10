// Decompiled with JetBrains decompiler
// Type: CardFramesSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Events;

public class CardFramesSystem : GameSystem
{
  public static CardFramesSystem instance;
  public Dictionary<string, int> frameLevels = new Dictionary<string, int>();
  public Dictionary<string, int> newFrameLevels = new Dictionary<string, int>();
  public bool show;

  public void OnEnable()
  {
    this.frameLevels = SaveSystem.LoadProgressData<Dictionary<string, int>>("frameLevels") ?? new Dictionary<string, int>();
    this.newFrameLevels = SaveSystem.LoadProgressData<Dictionary<string, int>>("newFrameLevels") ?? new Dictionary<string, int>();
    CardFramesSystem.instance = this;
    global::Events.OnCampaignEnd += new UnityAction<Campaign.Result, CampaignStats, PlayerData>(this.CampaignEnd);
    global::Events.OnSettingChanged += new UnityAction<string, object>(this.SettingChanged);
    this.show = Settings.Load<int>("SpecialCardFrames", 1) == 1;
  }

  public void OnDisable()
  {
    global::Events.OnCampaignEnd -= new UnityAction<Campaign.Result, CampaignStats, PlayerData>(this.CampaignEnd);
    global::Events.OnSettingChanged -= new UnityAction<string, object>(this.SettingChanged);
  }

  public void SettingChanged(string key, object value)
  {
    if (key != "SpecialCardFrames" || !(value is int num))
      return;
    this.show = num == 1;
  }

  public static int GetFrameLevel(string cardDataName)
  {
    if (!CardFramesSystem.instance.show)
      return 0;
    int frameLevel;
    CardFramesSystem.instance.frameLevels.TryGetValue(cardDataName, out frameLevel);
    return frameLevel;
  }

  public void CampaignEnd(Campaign.Result result, CampaignStats stats, PlayerData playerData)
  {
    if (result != Campaign.Result.Win)
      return;
    bool anyChange = false;
    if (CardFramesSystem.CheckTrueWin())
      this.SetFrameLevel(2, out anyChange);
    else
      this.SetFrameLevel(1, out anyChange);
    if (!anyChange)
      return;
    SaveSystem.SaveProgressData<Dictionary<string, int>>("frameLevels", this.frameLevels);
    SaveSystem.SaveProgressData<Dictionary<string, int>>("newFrameLevels", this.newFrameLevels);
  }

  public static bool CheckTrueWin() => SaveSystem.LoadCampaignData<bool>(Campaign.Data.GameMode, "trueWin", false);

  public void SetFrameLevel(int level, out bool anyChange)
  {
    anyChange = false;
    foreach (CardData cardData in References.PlayerData.inventory.deck)
    {
      if (this.TrySetFrameLevel(cardData, level))
        anyChange = true;
    }
  }

  public bool TrySetFrameLevel(CardData cardData, int level)
  {
    int num;
    if (cardData.cardType.miniboss || this.frameLevels.TryGetValue(cardData.name, out num) && num >= level)
      return false;
    this.frameLevels[cardData.name] = level;
    this.newFrameLevels[cardData.name] = level;
    return true;
  }

  public bool AnyNewFrames() => this.newFrameLevels.Count > 0;

  public IEnumerator DisplayNewFrames()
  {
    yield return (object) this.DisplayNewFrames(2);
    yield return (object) this.DisplayNewFrames(1);
    this.newFrameLevels.Clear();
    SaveSystem.SaveProgressData<Dictionary<string, int>>("newFrameLevels", this.newFrameLevels);
  }

  public IEnumerator DisplayNewFrames(int level)
  {
    string[] cards = this.GetNewCards(level);
    if (cards.Length != 0)
    {
      InputSystem.Disable();
      yield return (object) SceneManager.Load("CardFramesUnlocked", SceneType.Temporary);
      InputSystem.Enable();
      yield return (object) UnityEngine.Object.FindObjectOfType<CardFramesUnlockedSequence>().Run(level, cards);
      yield return (object) SceneManager.WaitUntilUnloaded("CardFramesUnlocked");
    }
  }

  public string[] GetNewCards(int level) => this.newFrameLevels.Where<KeyValuePair<string, int>>((Func<KeyValuePair<string, int>, bool>) (a => a.Value == level)).Select<KeyValuePair<string, int>, string>((Func<KeyValuePair<string, int>, string>) (a => a.Key)).ToArray<string>();
}
