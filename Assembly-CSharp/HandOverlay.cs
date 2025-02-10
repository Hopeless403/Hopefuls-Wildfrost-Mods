// Decompiled with JetBrains decompiler
// Type: HandOverlay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class HandOverlay : MonoBehaviour
{
  [SerializeField]
  [ReadOnly]
  private Character owner;
  [SerializeField]
  private CardContainer drawContainer;
  [SerializeField]
  private CardContainer handContainer;
  [SerializeField]
  private CardContainer discardContainer;
  [SerializeField]
  private TweenUI showTween;
  [SerializeField]
  private TweenUI hideTween;
  [SerializeField]
  private SpriteSetter[] spriteSetters;
  [Header("Shadow For Battle Phase")]
  [SerializeField]
  private CanvasGroup shadow;
  [SerializeField]
  private LeanTweenType shadowFadeEase = LeanTweenType.easeInOutQuart;
  [SerializeField]
  private float shadowFadeDur = 1f;
  private bool shadowActive;

  private void Start()
  {
    global::Events.OnBattlePhaseStart += new UnityAction<Battle.Phase>(this.BattlePhaseStart);
    global::Events.OnSettingChanged += new UnityAction<string, object>(this.SettingChanged);
    this.UpdateVisibility(Settings.Load<bool>("HideHandOverlay", false));
  }

  private void OnDestroy()
  {
    global::Events.OnBattlePhaseStart -= new UnityAction<Battle.Phase>(this.BattlePhaseStart);
    global::Events.OnSettingChanged -= new UnityAction<string, object>(this.SettingChanged);
  }

  private void BattlePhaseStart(Battle.Phase phase)
  {
    if (phase == Battle.Phase.Battle)
    {
      if (this.shadowActive)
        return;
      LeanTween.cancel(this.shadow.gameObject);
      this.shadow.LeanAlpha(1f, this.shadowFadeDur).setEase(this.shadowFadeEase);
      this.shadowActive = true;
    }
    else
    {
      if (!this.shadowActive)
        return;
      LeanTween.cancel(this.shadow.gameObject);
      this.shadow.LeanAlpha(0.0f, this.shadowFadeDur).setEase(this.shadowFadeEase);
      this.shadowActive = false;
    }
  }

  private void SettingChanged(string key, object value)
  {
    if (!(key == "HideHandOverlay") || !(value is bool hidden))
      return;
    this.UpdateVisibility(hidden);
  }

  private void UpdateVisibility(bool hidden) => this.gameObject.SetActive(!hidden);

  public void SetOwner(Character character)
  {
    this.owner = character;
    this.drawContainer.owner = this.owner;
    this.handContainer.owner = this.owner;
    this.discardContainer.owner = this.owner;
    this.owner.drawContainer = this.drawContainer;
    this.owner.handContainer = this.handContainer;
    this.owner.discardContainer = this.discardContainer;
    this.handContainer.SetSize(this.owner.data.handSize, this.handContainer.CardScale);
    foreach (SpriteSetter spriteSetter in this.spriteSetters)
      spriteSetter.Set(character.data.classData.name);
  }

  public IEnumerator Show()
  {
    SfxSystem.OneShot("event:/sfx/inventory/showup");
    this.showTween.Fire();
    yield return (object) Sequences.Wait(this.showTween.GetDuration());
  }

  public IEnumerator Hide()
  {
    this.hideTween.Fire();
    yield return (object) Sequences.Wait(this.hideTween.GetDuration());
  }
}
