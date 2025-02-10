// Decompiled with JetBrains decompiler
// Type: CardFramesSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Events;

#nullable disable
public class CardFramesSystem : GameSystem
{
  public static CardFramesSystem instance;
  private Dictionary<string, int> frameLevels = new Dictionary<string, int>();
  private Dictionary<string, int> newFrameLevels = new Dictionary<string, int>();
  private bool show;

  private void OnEnable()
  {
    this.frameLevels = SaveSystem.LoadProgressData<Dictionary<string, int>>("frameLevels") ?? new Dictionary<string, int>();
    this.newFrameLevels = SaveSystem.LoadProgressData<Dictionary<string, int>>("newFrameLevels") ?? new Dictionary<string, int>();
    CardFramesSystem.instance = this;
    global::Events.OnCampaignEnd += new UnityAction<Campaign.Result, CampaignStats, PlayerData>(this.CampaignEnd);
    global::Events.OnSettingChanged += new UnityAction<string, object>(this.SettingChanged);
    this.show = Settings.Load<int>("SpecialCardFrames", 1) == 1;
  }

  private void OnDisable()
  {
    global::Events.OnCampaignEnd -= new UnityAction<Campaign.Result, CampaignStats, PlayerData>(this.CampaignEnd);
    global::Events.OnSettingChanged -= new UnityAction<string, object>(this.SettingChanged);
  }

  private void SettingChanged(string key, object value)
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

  private void CampaignEnd(Campaign.Result result, CampaignStats stats, PlayerData playerData)
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

  private static bool CheckTrueWin()
  {
    return SaveSystem.LoadCampaignData<bool>(Campaign.Data.GameMode, "trueWin", false);
  }

  private void SetFrameLevel(int level, out bool anyChange)
  {
    anyChange = false;
    foreach (CardData cardData in References.PlayerData.inventory.deck)
    {
      if (this.TrySetFrameLevel(cardData, level))
        anyChange = true;
    }
  }

  private bool TrySetFrameLevel(CardData cardData, int level)
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

  private IEnumerator DisplayNewFrames(int level)
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

  private string[] GetNewCards(int level)
  {
    return this.newFrameLevels.Where<KeyValuePair<string, int>>((Func<KeyValuePair<string, int>, bool>) (a => a.Value == level)).Select<KeyValuePair<string, int>, string>((Func<KeyValuePair<string, int>, string>) (a => a.Key)).ToArray<string>();
  }
}
