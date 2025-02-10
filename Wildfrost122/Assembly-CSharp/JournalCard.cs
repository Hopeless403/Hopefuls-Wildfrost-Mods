// Decompiled with JetBrains decompiler
// Type: JournalCard
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
public class JournalCard : MonoBehaviour
{
  [SerializeField]
  private TMP_Text nameText;
  [SerializeField]
  private Image background;
  [SerializeField]
  private Image image;
  [SerializeField]
  private Button button;
  [SerializeField]
  private Material discoveredMaterial;
  [SerializeField]
  private Image frame;
  [SerializeField]
  private Sprite[] frames;
  private CardData cardData;
  private bool discovered;

  public void SetCardArt(CardData cardData, float scale)
  {
    this.cardData = cardData;
    this.background.sprite = cardData.backgroundSprite;
    this.image.sprite = cardData.mainSprite;
    this.background.transform.localScale = Vector3.one * scale;
    this.image.transform.localScale = Vector3.one * scale;
    string rootCardDataName;
    CreatedByLookup.TryGetCreatedByRoot(cardData.name, out rootCardDataName);
    this.frame.sprite = this.frames[CardFramesSystem.GetFrameLevel(rootCardDataName)];
  }

  public void CheckDiscovered(List<string> discoveredCards, JournalCardManager manager)
  {
    if (this.discovered || !discoveredCards.Contains(this.cardData.name))
      return;
    this.SetDiscovered(this.cardData.title, manager);
  }

  public void SetDiscovered(string title, JournalCardManager manager)
  {
    this.discovered = true;
    this.nameText.text = title;
    this.background.enabled = true;
    this.image.material = this.discoveredMaterial;
    this.image.color = Color.white;
    this.button.onClick.AddListener((UnityAction) (() => manager.Select(this.cardData)));
  }
}
