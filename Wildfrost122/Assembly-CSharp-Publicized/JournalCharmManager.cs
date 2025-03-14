﻿// Decompiled with JetBrains decompiler
// Type: JournalCharmManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

#nullable disable
public class JournalCharmManager : MonoBehaviour
{
  [SerializeField]
  public JournalCharm charmPrefab;
  [SerializeField]
  public Transform content;
  [SerializeField]
  public SmoothScrollRect scrollRect;
  public List<string> discovered;
  public readonly List<JournalCharm> charmIcons = new List<JournalCharm>();
  public Locale locale;

  public void OnEnable()
  {
    this.discovered = SaveSystem.LoadProgressData<List<string>>("charmsDiscovered");
    if (this.discovered != null)
    {
      foreach (JournalCharm charmIcon in this.charmIcons)
        charmIcon.CheckDiscovered(this.discovered);
    }
    else
      this.discovered = new List<string>();
    CardPopUp.SetCanvasLayer("PauseMenu", 1);
    CardPopUp.SetIgnoreTimeScale(true);
    if (!((UnityEngine.Object) this.locale == (UnityEngine.Object) null) && !((UnityEngine.Object) this.locale != (UnityEngine.Object) LocalizationSettings.SelectedLocale))
      return;
    this.locale = LocalizationSettings.SelectedLocale;
    this.CreateCharms();
  }

  public void OnDisable() => CardPopUp.Reset();

  public void CreateCharms()
  {
    this.content.DestroyAllChildren();
    this.charmIcons.Clear();
    foreach (KeyValuePair<string, CardUpgradeData> keyValuePair in JournalCharmManager.LoadCharmData())
    {
      JournalCharm journalCharm = UnityEngine.Object.Instantiate<JournalCharm>(this.charmPrefab, this.content);
      this.charmIcons.Add(journalCharm);
      journalCharm.Assign(keyValuePair.Value);
      if (this.discovered.Contains(keyValuePair.Value.name))
        journalCharm.SetDiscovered();
    }
    this.scrollRect.ScrollToTop();
  }

  public static List<KeyValuePair<string, CardUpgradeData>> LoadCharmData()
  {
    return AddressableLoader.GetGroup<CardUpgradeData>("CardUpgradeData").Where<CardUpgradeData>((Func<CardUpgradeData, bool>) (a => a.type == CardUpgradeData.Type.Charm && a.tier >= -2)).ToDictionary<CardUpgradeData, string, CardUpgradeData>((Func<CardUpgradeData, string>) (a => a.title), (Func<CardUpgradeData, CardUpgradeData>) (a => a)).OrderByDescending<KeyValuePair<string, CardUpgradeData>, bool>((Func<KeyValuePair<string, CardUpgradeData>, bool>) (a => a.Value.tier >= 0)).ThenBy<KeyValuePair<string, CardUpgradeData>, string>((Func<KeyValuePair<string, CardUpgradeData>, string>) (a => a.Key)).ToList<KeyValuePair<string, CardUpgradeData>>();
  }
}
