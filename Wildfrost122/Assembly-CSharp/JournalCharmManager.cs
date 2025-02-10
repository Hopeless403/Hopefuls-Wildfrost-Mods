// Decompiled with JetBrains decompiler
// Type: JournalCharmManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

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
  private JournalCharm charmPrefab;
  [SerializeField]
  private Transform content;
  [SerializeField]
  private SmoothScrollRect scrollRect;
  private List<string> discovered;
  private readonly List<JournalCharm> charmIcons = new List<JournalCharm>();
  private Locale locale;

  private void OnEnable()
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

  private void OnDisable() => CardPopUp.Reset();

  private void CreateCharms()
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

  private static List<KeyValuePair<string, CardUpgradeData>> LoadCharmData()
  {
    return AddressableLoader.GetGroup<CardUpgradeData>("CardUpgradeData").Where<CardUpgradeData>((Func<CardUpgradeData, bool>) (a => a.type == CardUpgradeData.Type.Charm && a.tier >= -2)).ToDictionary<CardUpgradeData, string, CardUpgradeData>((Func<CardUpgradeData, string>) (a => a.title), (Func<CardUpgradeData, CardUpgradeData>) (a => a)).OrderByDescending<KeyValuePair<string, CardUpgradeData>, bool>((Func<KeyValuePair<string, CardUpgradeData>, bool>) (a => a.Value.tier >= 0)).ThenBy<KeyValuePair<string, CardUpgradeData>, string>((Func<KeyValuePair<string, CardUpgradeData>, string>) (a => a.Key)).ToList<KeyValuePair<string, CardUpgradeData>>();
  }
}
