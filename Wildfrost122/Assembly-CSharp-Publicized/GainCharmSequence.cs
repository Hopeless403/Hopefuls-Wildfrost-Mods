// Decompiled with JetBrains decompiler
// Type: GainCharmSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using TMPro;
using UnityEngine;

#nullable disable
public class GainCharmSequence : UISequence
{
  [Header("Custom Values")]
  [SerializeField]
  public CardUpgradeData charmData;
  [SerializeField]
  public CardCharm charmPrefab;
  [SerializeField]
  public float charmScale = 2f;
  [SerializeField]
  public Vector2 charmPopUpOffset = new Vector2(1f, 0.0f);
  [SerializeField]
  public Transform charmHolder;
  [SerializeField]
  public CanvasGroup fade;
  [SerializeField]
  public float fadeInTime = 0.2f;
  [SerializeField]
  public float fadeOutTime = 0.2f;
  [SerializeField]
  public TweenUI[] startTweens;
  [SerializeField]
  public TweenUI[] endTweens;
  [SerializeField]
  public Character character;
  [SerializeField]
  public TMP_Text title;
  public CardCharmInteraction charmInteraction;

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

  public static IEnumerator WaitForInventoryClose()
  {
    while (Deckpack.IsOpen)
      yield return (object) null;
  }
}
