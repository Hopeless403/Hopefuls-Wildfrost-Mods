// Decompiled with JetBrains decompiler
// Type: JournalCardManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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

#nullable disable
public class JournalCardManager : MonoBehaviour
{
  [SerializeField]
  public JournalCardManager.Category[] categories;
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

  public void OnEnable()
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

  public void Start()
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
