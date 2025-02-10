// Decompiled with JetBrains decompiler
// Type: HandOverlay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class HandOverlay : MonoBehaviour
{
  [SerializeField]
  [ReadOnly]
  public Character owner;
  [SerializeField]
  public CardContainer drawContainer;
  [SerializeField]
  public CardContainer handContainer;
  [SerializeField]
  public CardContainer discardContainer;
  [SerializeField]
  public TweenUI showTween;
  [SerializeField]
  public TweenUI hideTween;
  [SerializeField]
  public SpriteSetter[] spriteSetters;
  [Header("Shadow For Battle Phase")]
  [SerializeField]
  public CanvasGroup shadow;
  [SerializeField]
  public LeanTweenType shadowFadeEase = LeanTweenType.easeInOutQuart;
  [SerializeField]
  public float shadowFadeDur = 1f;
  public bool shadowActive;

  public void Start()
  {
    global::Events.OnBattlePhaseStart += new UnityAction<Battle.Phase>(this.BattlePhaseStart);
    global::Events.OnSettingChanged += new UnityAction<string, object>(this.SettingChanged);
    this.UpdateVisibility(Settings.Load<bool>("HideHandOverlay", false));
  }

  public void OnDestroy()
  {
    global::Events.OnBattlePhaseStart -= new UnityAction<Battle.Phase>(this.BattlePhaseStart);
    global::Events.OnSettingChanged -= new UnityAction<string, object>(this.SettingChanged);
  }

  public void BattlePhaseStart(Battle.Phase phase)
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

  public void SettingChanged(string key, object value)
  {
    if (!(key == "HideHandOverlay") || !(value is bool hidden))
      return;
    this.UpdateVisibility(hidden);
  }

  public void UpdateVisibility(bool hidden) => this.gameObject.SetActive(!hidden);

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
