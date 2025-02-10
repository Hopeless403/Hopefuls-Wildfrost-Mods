// Decompiled with JetBrains decompiler
// Type: GainCrownSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GainCrownSequence : UISequence
{
  [Header("Custom Values")]
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
  public Image crownImage;
  [SerializeField]
  public CardUpgradeData defaultCrownData;
  public CardUpgradeData crownData;

  public void SetData(CardUpgradeData crownData) => this.crownData = crownData;

  public override IEnumerator Run()
  {
    GainCrownSequence gainCrownSequence = this;
    if (!(bool) (Object) gainCrownSequence.crownData)
      gainCrownSequence.crownData = gainCrownSequence.defaultCrownData.Clone();
    gainCrownSequence.crownImage.sprite = gainCrownSequence.crownData.image;
    References.PlayerData.inventory.upgrades.Add(gainCrownSequence.crownData);
    Events.InvokeUpgradeGained(gainCrownSequence.crownData);
    gainCrownSequence.fade.gameObject.SetActive(false);
    yield return (object) Sequences.Wait(gainCrownSequence.startDelay);
    gainCrownSequence.gameObject.SetActive(true);
    gainCrownSequence.fade.gameObject.SetActive(true);
    gainCrownSequence.fade.alpha = 0.0f;
    gainCrownSequence.fade.LeanAlpha(1f, gainCrownSequence.fadeInTime);
    gainCrownSequence.fade.blocksRaycasts = true;
    float a = 0.0f;
    foreach (TweenUI startTween in gainCrownSequence.startTweens)
    {
      startTween.Fire();
      a = Mathf.Max(a, startTween.GetDuration());
    }
    while (!gainCrownSequence.promptEnd)
      yield return (object) null;
    gainCrownSequence.promptEnd = false;
    gainCrownSequence.fade.LeanAlpha(0.0f, gainCrownSequence.fadeOutTime);
    gainCrownSequence.fade.blocksRaycasts = false;
    SfxSystem.OneShot("event:/sfx/ui/message_closing");
    float num = gainCrownSequence.fadeOutTime;
    foreach (TweenUI endTween in gainCrownSequence.endTweens)
    {
      endTween.Fire();
      num = Mathf.Max(num, endTween.GetDuration());
    }
    yield return (object) Sequences.Wait(num);
    gainCrownSequence.gameObject.SetActive(false);
  }

  public void CharacterOpenInventory()
  {
    if (!(References.Player.entity.display is CharacterDisplay display))
      return;
    display.OpenInventory();
  }
}
