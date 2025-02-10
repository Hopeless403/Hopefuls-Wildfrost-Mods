// Decompiled with JetBrains decompiler
// Type: JournalCardManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Deadpan.Enums.Engine.Components.Modding;
using FMODUnity;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

public class JournalCardManager : MonoBehaviour
{
  [SerializeField]
  private JournalCardManager.Category[] categories;
  [SerializeField]
  private JournalCard cardPrefab;
  [SerializeField]
  private Transform content;
  [SerializeField]
  private Scroller scroller;
  [SerializeField]
  private JournalCardDisplay cardDisplay;
  [SerializeField]
  private Button[] tabs;
  [SerializeField]
  private GameObject[] tabSelected;
  [SerializeField]
  private RewiredHotKeyController hotKeyTabLeft;
  [SerializeField]
  private RewiredHotKeyController hotKeyTabRight;
  [SerializeField]
  private EventReference selectCardSfxEvent;
  private List<string> discovered;
  private int currentCategory;
  private readonly List<AsyncOperationHandle<CardData>> handles = new List<AsyncOperationHandle<CardData>>();
  private readonly List<JournalCard> cardIcons = new List<JournalCard>();
  private Locale locale;
  private static readonly Dictionary<string, float> scaleOverride = new Dictionary<string, float>()
  {
    {
      "FinalBoss2",
      1.3f
    }
  };

  private void OnEnable()
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

  private void Start()
  {
    this.CreateCards(0);
    this.locale = LocalizationSettings.SelectedLocale;
  }

  public void CreateCards(string categoryName)
  {
    for (int categoryIndex = 0; categoryIndex < this.categories.Length; ++categoryIndex)
    {
      if (this.categories[categoryIndex].name == categoryName)
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
    foreach (CardData cardData in Extensions.GetCategoryCardData(this.categories[this.currentCategory].name))
    {
      string title = cardData.title;
      JournalCard journalCard = UnityEngine.Object.Instantiate<JournalCard>(this.cardPrefab, this.content);
      this.cardIcons.Add(journalCard);
      float num;
      float scale = JournalCardManager.scaleOverride.TryGetValue(cardData.name, out num) ? num : 1f;
      journalCard.SetCardArt(cardData, scale);
      if (this.discovered.Contains(cardData.name))
        journalCard.SetDiscovered(title, this);
    }
    this.StartCoroutine(this.ScrollToTop());
  }

  private IEnumerator ScrollToTop()
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
    if (this.currentCategory >= this.categories.Length)
      this.currentCategory -= this.categories.Length;
    this.SelectTab(this.currentCategory);
  }

  public void PreviousTab()
  {
    --this.currentCategory;
    if (this.currentCategory < 0)
      this.currentCategory += this.categories.Length;
    this.SelectTab(this.currentCategory);
  }

  [Serializable]
  public struct Category
  {
    public string name;
    public AssetReferenceT<CardData>[] cards;
  }
}
