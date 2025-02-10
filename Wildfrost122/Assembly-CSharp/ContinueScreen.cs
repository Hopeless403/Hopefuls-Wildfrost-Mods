// Decompiled with JetBrains decompiler
// Type: ContinueScreen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization.Settings;

#nullable disable
public class ContinueScreen : MonoBehaviour
{
  [SerializeField]
  private CardController cardController;
  [SerializeField]
  private CardContainer cardContainer;
  [SerializeField]
  private ModifierDisplay modifierDisplay;
  [SerializeField]
  private TMP_Text titleText;
  [SerializeField]
  private TMP_Text dateText;
  [SerializeField]
  private TMP_Text progressText;
  [SerializeField]
  private Menu menu;
  [SerializeField]
  private GameObject backButton;
  [SerializeField]
  private GameObject continueButton;
  [SerializeField]
  private HelpPanelShower giveUpHelpShower;
  [SerializeField]
  private GameObject missingDataDisplay;
  private CampaignSaveData data;
  private bool closing;

  private IEnumerator Start()
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

  private void GiveUp()
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

  private IEnumerator GiveUpSequence()
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

  private void ForceClose()
  {
    this.closing = true;
    Routine routine = new Routine(SceneManager.Unload("ContinueRun"));
  }

  private void CheckMissingData(CampaignSaveData data)
  {
    if (!this.HasMissingData(data))
      return;
    this.continueButton.SetActive(false);
    this.missingDataDisplay.SetActive(true);
  }

  private bool HasMissingData(CampaignSaveData data)
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
