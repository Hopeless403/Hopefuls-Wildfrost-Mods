// Decompiled with JetBrains decompiler
// Type: ContinueScreen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization.Settings;

public class ContinueScreen : MonoBehaviour
{
  [SerializeField]
  public CardController cardController;
  [SerializeField]
  public CardContainer cardContainer;
  [SerializeField]
  public ModifierDisplay modifierDisplay;
  [SerializeField]
  public TMP_Text titleText;
  [SerializeField]
  public TMP_Text dateText;
  [SerializeField]
  public TMP_Text progressText;
  [SerializeField]
  public Menu menu;
  [SerializeField]
  public GameObject backButton;
  [SerializeField]
  public GameObject continueButton;
  [SerializeField]
  public HelpPanelShower giveUpHelpShower;
  [SerializeField]
  public GameObject missingDataDisplay;
  public CampaignSaveData data;
  public bool closing;

  public IEnumerator Start()
  {
    bool flag = true;
    List<CardData> cardDataList = (List<CardData>) null;
    try
    {
      if (SaveSystem.CampaignExists(Campaign.Data.GameMode))
      {
        if (SaveSystem.CampaignDataExists(Campaign.Data.GameMode, "data"))
        {
          this.data = SaveSystem.LoadCampaignData<CampaignSaveData>(Campaign.Data.GameMode, "data");
          global::Events.InvokeCampaignLoaded();
          string s = SaveSystem.LoadCampaignData<string>(Campaign.Data.GameMode, "startDate");
          if (s != null)
          {
            this.dateText.gameObject.SetActive(true);
            this.dateText.text = DateTime.ParseExact(s, "dd/MM/yyyy", (IFormatProvider) GameManager.CultureInfo).ToString("D", (IFormatProvider) LocalizationSettings.SelectedLocale.Identifier.CultureInfo);
          }
          bool mainGameMode = Campaign.Data.GameMode.mainGameMode;
          string[] modifiers = this.data.modifiers;
          if (modifiers == null || modifiers.Length <= 0)
          {
            this.modifierDisplay.gameObject.SetActive(false);
          }
          else
          {
            foreach (string modifier in this.data.modifiers)
            {
              GameModifierData data = AddressableLoader.Get<GameModifierData>("GameModifierData", modifier);
              if ((UnityEngine.Object) data != (UnityEngine.Object) null)
                this.modifierDisplay.CreateIcon(data, mainGameMode);
            }
          }
          cardDataList = this.data.characters[this.data.playerId].inventoryData.deck.LoadList<CardData, CardSaveData>();
          this.continueButton.SetActive(true);
        }
      }
    }
    catch (NullReferenceException ex)
    {
      flag = false;
      Debug.LogWarning((object) ex);
    }
    if (flag)
    {
      this.CheckMissingData(this.data);
      Routine.Clump clump = new Routine.Clump();
      List<Entity> cards = new List<Entity>();
      foreach (CardData data in cardDataList)
      {
        Card card = CardManager.Get(data, this.cardController, (Character) null, false, true);
        card.hover.enabled = false;
        cards.Add(card.entity);
        clump.Add(card.UpdateData(false));
      }
      yield return (object) clump.WaitForEnd();
      foreach (Entity entity in cards)
        entity.display.hover.enabled = true;
      cards.Sort((Comparison<Entity>) ((a, b) => a.data.cardType.sortPriority.CompareTo(b.data.cardType.sortPriority)));
      this.cardContainer.max = cards.Count;
      for (int index = cards.Count - 1; index >= 0; --index)
        this.cardContainer.Add(cards[index]);
      this.cardContainer.SetChildPositions();
      this.backButton.gameObject.SetActive(Campaign.Data.GameMode.canGoBack);
      cards = (List<Entity>) null;
    }
    else
    {
      Debug.LogWarning((object) "Failed to load campaign save...");
      SaveSystem.DeleteCampaign(Campaign.Data.GameMode);
      global::Events.InvokeCampaignDeleted();
      Campaign.Data = new CampaignData(Campaign.Data.GameMode);
      Routine routine = new Routine(Sequences.SceneChange(Campaign.Data.GameMode.startScene));
    }
  }

  public void Continue()
  {
    if (this.closing)
      return;
    this.closing = true;
    this.menu.GoTo("Campaign");
  }

  public void PromptGiveUp()
  {
    if (this.closing)
      return;
    this.giveUpHelpShower.Show();
    this.giveUpHelpShower.AddButton(0, HelpPanelSystem.ButtonType.Positive, new UnityAction(this.GiveUp));
    this.giveUpHelpShower.AddButton(1, HelpPanelSystem.ButtonType.Negative, (UnityAction) null);
  }

  public void GiveUp()
  {
    if (this.closing)
      return;
    this.closing = true;
    CampaignSaveData campaignSaveData = SaveSystem.LoadCampaignData<CampaignSaveData>(Campaign.Data.GameMode, "data");
    CharacterSaveData character = campaignSaveData.characters[campaignSaveData.playerId];
    if (character != null)
      global::Events.InvokeCampaignEnd(Campaign.Result.Restart, SaveSystem.LoadCampaignData<CampaignStats>(Campaign.Data.GameMode, "stats"), character.LoadPlayerData());
    SaveSystem.DeleteCampaign(Campaign.Data.GameMode);
    global::Events.InvokeCampaignDeleted();
    this.StartCoroutine(this.GiveUpSequence());
  }

  public IEnumerator GiveUpSequence()
  {
    if (global::Settings.Load<bool>("showJournalNameOnEnd", false))
      yield return (object) JournalVoidNameSequence.LoadAndRun(false);
    else
      JournalNameHistory.MostRecentNameKilled();
    Campaign.Data = new CampaignData(Campaign.Data.GameMode);
    this.ForceClose();
  }

  public void Close()
  {
    if (this.closing)
      return;
    this.ForceClose();
  }

  public void ForceClose()
  {
    this.closing = true;
    Routine routine = new Routine(SceneManager.Unload("ContinueRun"));
  }

  public void CheckMissingData(CampaignSaveData data)
  {
    if (!this.HasMissingData(data))
      return;
    this.continueButton.SetActive(false);
    this.missingDataDisplay.SetActive(true);
  }

  public bool HasMissingData(CampaignSaveData data)
  {
    CharacterSaveData character = data.characters[data.playerId];
    if (MissingCardSystem.HasMissingData(character.inventoryData.deck) || MissingCardSystem.HasMissingData(character.inventoryData.reserve))
      return true;
    foreach (CampaignNodeSaveData node1 in data.nodes)
    {
      if (!node1.cleared)
      {
        CampaignNode node2 = node1.Load();
        if (node2.type.HasMissingData(node2))
          return true;
      }
    }
    return false;
  }
}
