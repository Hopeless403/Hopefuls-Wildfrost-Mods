// Decompiled with JetBrains decompiler
// Type: JournalCardManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using Deadpan.Enums.Engine.Components.Modding;
using FMODUnity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

#nullable disable
public class JournalCardManager : MonoBehaviour
{
  [SerializeField]
  public JournalCardManagerPopulator populator;
  [SerializeField]
  public string[] categoryNames = new string[3]
  {
    "Friendly",
    "Item",
    "Clunker"
  };
  [SerializeField]
  public JournalCard cardPrefab;
  [SerializeField]
  public Transform content;
  [SerializeField]
  public Scroller scroller;
  [SerializeField]
  public JournalCardDisplay cardDisplay;
  [SerializeField]
  public Button[] tabs;
  [SerializeField]
  public GameObject[] tabSelected;
  [SerializeField]
  public RewiredHotKeyController hotKeyTabLeft;
  [SerializeField]
  public RewiredHotKeyController hotKeyTabRight;
  [SerializeField]
  public EventReference selectCardSfxEvent;
  public List<string> discovered;
  public int currentCategory;
  public readonly List<AsyncOperationHandle<CardData>> handles = new List<AsyncOperationHandle<CardData>>();
  public readonly List<JournalCard> cardIcons = new List<JournalCard>();
  public Locale locale;
  public static readonly Dictionary<string, float> scaleOverride = new Dictionary<string, float>()
  {
    {
      "FinalBoss2",
      1.3f
    }
  };
  public bool requiresRebuild;
  public bool subbed;

  public void OnEnable()
  {
    if (!this.subbed)
    {
      global::Events.OnModLoaded += new UnityAction<WildfrostMod>(this.ModToggled);
      global::Events.OnModUnloaded += new UnityAction<WildfrostMod>(this.ModToggled);
      this.subbed = true;
    }
    if (this.requiresRebuild)
    {
      if (!this.populator.populated)
        this.populator.Populate();
      this.CreateCards(this.currentCategory);
      this.requiresRebuild = false;
      this.StartCoroutine(this.ScrollToTop());
    }
    else
    {
      this.discovered = SaveSystem.LoadProgressData<List<string>>("cardsDiscovered");
      if (this.discovered != null)
      {
        foreach (JournalCard cardIcon in this.cardIcons)
          cardIcon.CheckDiscovered(this.discovered, this);
      }
      else
        this.discovered = new List<string>();
      if (!((UnityEngine.Object) this.locale != (UnityEngine.Object) null) || !((UnityEngine.Object) this.locale != (UnityEngine.Object) LocalizationSettings.SelectedLocale))
        return;
      this.locale = LocalizationSettings.SelectedLocale;
      this.CreateCards(this.currentCategory);
    }
  }

  public void ModToggled(WildfrostMod mod) => this.requiresRebuild = true;

  public void Start()
  {
    this.CreateCards(0);
    this.locale = LocalizationSettings.SelectedLocale;
  }

  public void CreateCards(string categoryName)
  {
    for (int categoryIndex = 0; categoryIndex < this.categoryNames.Length; ++categoryIndex)
    {
      if (this.categoryNames[categoryIndex] == categoryName)
      {
        if (categoryIndex == this.currentCategory)
          break;
        this.CreateCards(categoryIndex);
        break;
      }
    }
  }

  public void CreateCards(int categoryIndex)
  {
    this.currentCategory = categoryIndex;
    this.content.DestroyAllChildren();
    this.cardIcons.Clear();
    foreach (KeyValuePair<string, CardData> keyValuePair in JournalCardManager.LoadCardData(this.populator.GetCategory(this.categoryNames[categoryIndex])))
    {
      string str;
      CardData cardData1;
      keyValuePair.Deconstruct(ref str, ref cardData1);
      string title = str;
      CardData cardData2 = cardData1;
      JournalCard journalCard = UnityEngine.Object.Instantiate<JournalCard>(this.cardPrefab, this.content);
      this.cardIcons.Add(journalCard);
      float num;
      float scale = JournalCardManager.scaleOverride.TryGetValue(cardData2.name, out num) ? num : 1f;
      journalCard.SetCardArt(cardData2, scale);
      if (this.discovered.Contains(cardData2.name))
        journalCard.SetDiscovered(title, this);
    }
    this.StartCoroutine(this.ScrollToTop());
  }

  public static List<KeyValuePair<string, CardData>> LoadCardData(
    JournalCardManagerPopulator.Category category)
  {
    List<KeyValuePair<string, CardData>> source = new List<KeyValuePair<string, CardData>>();
    foreach (string cardName in category.cardNames)
    {
      CardData cardData = AddressableLoader.Get<CardData>("CardData", cardName);
      source.Add(new KeyValuePair<string, CardData>(cardData.title, cardData));
    }
    return source.OrderBy<KeyValuePair<string, CardData>, string>((Func<KeyValuePair<string, CardData>, string>) (a => a.Key)).ToList<KeyValuePair<string, CardData>>();
  }

  public IEnumerator ScrollToTop()
  {
    yield return (object) new WaitForEndOfFrame();
    this.scroller.ScrollImmediate(100f);
  }

  public void Select(CardData cardData)
  {
    this.cardDisplay.Display(cardData);
    SfxSystem.OneShot(this.selectCardSfxEvent);
  }

  public void SelectTab(int index)
  {
    this.CreateCards(index);
    foreach (GameObject gameObject in this.tabSelected)
      gameObject.SetActive(false);
    this.tabSelected[index].SetActive(true);
  }

  public void NextTab()
  {
    ++this.currentCategory;
    if (this.currentCategory >= this.categoryNames.Length)
      this.currentCategory -= this.categoryNames.Length;
    this.SelectTab(this.currentCategory);
  }

  public void PreviousTab()
  {
    --this.currentCategory;
    if (this.currentCategory < 0)
      this.currentCategory += this.categoryNames.Length;
    this.SelectTab(this.currentCategory);
  }
}
