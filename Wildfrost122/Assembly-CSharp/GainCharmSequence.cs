// Decompiled with JetBrains decompiler
// Type: GainCharmSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using TMPro;
using UnityEngine;

#nullable disable
public class GainCharmSequence : UISequence
{
  [Header("Custom Values")]
  [SerializeField]
  private CardUpgradeData charmData;
  [SerializeField]
  private CardCharm charmPrefab;
  [SerializeField]
  private float charmScale = 2f;
  [SerializeField]
  private Vector2 charmPopUpOffset = new Vector2(1f, 0.0f);
  [SerializeField]
  private Transform charmHolder;
  [SerializeField]
  private CanvasGroup fade;
  [SerializeField]
  private float fadeInTime = 0.2f;
  [SerializeField]
  private float fadeOutTime = 0.2f;
  [SerializeField]
  private TweenUI[] startTweens;
  [SerializeField]
  private TweenUI[] endTweens;
  [SerializeField]
  private Character character;
  [SerializeField]
  private TMP_Text title;
  private CardCharmInteraction charmInteraction;

  public void SetCharm(CardUpgradeData charmData) => this.charmData = charmData;

  public void SetCharacter(Character character) => this.character = character;

  public void SetTitle(string text)
  {
    this.title.text = "<size=0.5><#A9AAD4>" + text + "</size></color>\n" + this.charmData.title;
  }

  public override IEnumerator Run()
  {
    GainCharmSequence gainCharmSequence = this;
    gainCharmSequence.character.data.inventory.upgrades.Add(gainCharmSequence.charmData);
    Events.InvokeUpgradeGained(gainCharmSequence.charmData);
    Campaign.PromptSave();
    gainCharmSequence.fade.gameObject.SetActive(false);
    gainCharmSequence.charmHolder.DestroyAllChildren();
    yield return (object) Sequences.Wait(gainCharmSequence.startDelay);
    gainCharmSequence.gameObject.SetActive(true);
    gainCharmSequence.fade.gameObject.SetActive(true);
    gainCharmSequence.fade.alpha = 0.0f;
    gainCharmSequence.fade.LeanAlpha(1f, gainCharmSequence.fadeInTime);
    gainCharmSequence.fade.blocksRaycasts = true;
    float a = 0.0f;
    foreach (TweenUI startTween in gainCharmSequence.startTweens)
    {
      startTween.Fire();
      a = Mathf.Max(a, startTween.GetDuration());
    }
    CardCharm cardCharm = Object.Instantiate<CardCharm>(gainCharmSequence.charmPrefab, gainCharmSequence.charmHolder);
    cardCharm.holder = gainCharmSequence.charmHolder;
    cardCharm.transform.localScale = Vector3.one * gainCharmSequence.charmScale;
    cardCharm.SetData(gainCharmSequence.charmData);
    gainCharmSequence.charmInteraction = cardCharm.GetComponent<CardCharmInteraction>();
    if ((bool) (Object) gainCharmSequence.charmInteraction)
    {
      gainCharmSequence.charmInteraction.popUpOffset = gainCharmSequence.charmPopUpOffset;
      gainCharmSequence.charmInteraction.PopUpDescription();
    }
    while (!gainCharmSequence.promptEnd)
      yield return (object) null;
    gainCharmSequence.promptEnd = false;
    gainCharmSequence.charmInteraction.HideDescription();
    gainCharmSequence.fade.LeanAlpha(0.0f, gainCharmSequence.fadeOutTime);
    gainCharmSequence.fade.blocksRaycasts = false;
    SfxSystem.OneShot("event:/sfx/ui/message_closing");
    float num = gainCharmSequence.fadeOutTime;
    foreach (TweenUI endTween in gainCharmSequence.endTweens)
    {
      endTween.Fire();
      num = Mathf.Max(num, endTween.GetDuration());
    }
    yield return (object) Sequences.Wait(num);
    gainCharmSequence.gameObject.SetActive(false);
    yield return (object) GainCharmSequence.WaitForInventoryClose();
  }

  public void CharacterOpenInventory()
  {
    if (!(this.character.entity.display is CharacterDisplay display))
      return;
    display.OpenInventory();
  }

  private static IEnumerator WaitForInventoryClose()
  {
    while (Deckpack.IsOpen)
      yield return (object) null;
  }
}
