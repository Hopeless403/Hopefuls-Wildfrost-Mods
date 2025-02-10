// Decompiled with JetBrains decompiler
// Type: NoTargetTextSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using FMODUnity;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

#nullable disable
public class NoTargetTextSystem : GameSystem
{
  private static NoTargetTextSystem instance;
  [SerializeField]
  private AnimationCurve shakeCurve;
  [SerializeField]
  private Vector3 shakeAmount = new Vector3(1f, 0.0f, 0.0f);
  [SerializeField]
  private Vector2 shakeDurationRange = new Vector2(0.3f, 0.4f);
  [SerializeField]
  private TMP_Text textElement;
  [SerializeField]
  private Vector3 textPopOffset = new Vector3(0.0f, 1.5f, -1f);
  [SerializeField]
  private EventReference sfxEvent;
  [Header("Text")]
  [SerializeField]
  private LocalizedString noTargetToAttackText;
  [SerializeField]
  private LocalizedString noAlliesToHealText;
  [SerializeField]
  private LocalizedString noTargetForStatusText;
  [SerializeField]
  private LocalizedString noSpaceToSummonText;
  [SerializeField]
  private LocalizedString noCardsToDrawText;
  [SerializeField]
  private LocalizedString noAllyToBoostText;
  [SerializeField]
  private LocalizedString noEnemyToBoostText;
  [SerializeField]
  private LocalizedString requiresJunkText;
  [SerializeField]
  private LocalizedString cantSplitText;
  [SerializeField]
  private LocalizedString noSummonedAlliesText;
  [SerializeField]
  private LocalizedString playCrownCardsText;
  [SerializeField]
  private LocalizedString noAllyToAttackText;
  [SerializeField]
  private LocalizedString cantMoveText;
  private readonly Dictionary<NoTargetType, string> strings = new Dictionary<NoTargetType, string>();

  private void OnEnable()
  {
    NoTargetTextSystem.instance = this;
    LocalizationSettings.SelectedLocaleChanged += new Action<Locale>(this.LocaleChanged);
    this.PopulateStrings();
  }

  private void OnDisable()
  {
    LocalizationSettings.SelectedLocaleChanged -= new Action<Locale>(this.LocaleChanged);
  }

  private void LocaleChanged(Locale locale) => this.PopulateStrings();

  private void PopulateStrings()
  {
    this.strings.Clear();
    this.strings[NoTargetType.NoTargetToAttack] = this.noTargetToAttackText.GetLocalizedString();
    this.strings[NoTargetType.NoAllyToHeal] = this.noAlliesToHealText.GetLocalizedString();
    this.strings[NoTargetType.NoTargetForStatus] = this.noTargetForStatusText.GetLocalizedString();
    this.strings[NoTargetType.NoSpaceToSummon] = this.noSpaceToSummonText.GetLocalizedString();
    this.strings[NoTargetType.NoCardsToDraw] = this.noCardsToDrawText.GetLocalizedString();
    this.strings[NoTargetType.NoAllyToBoost] = this.noAllyToBoostText.GetLocalizedString();
    this.strings[NoTargetType.NoEnemyToBoost] = this.noEnemyToBoostText.GetLocalizedString();
    this.strings[NoTargetType.RequiresJunk] = this.requiresJunkText.GetLocalizedString();
    this.strings[NoTargetType.CantSplit] = this.cantSplitText.GetLocalizedString();
    this.strings[NoTargetType.NoSummonedAllies] = this.noSummonedAlliesText.GetLocalizedString();
    this.strings[NoTargetType.PlayCrownCardsFirst] = this.playCrownCardsText.GetLocalizedString();
    this.strings[NoTargetType.NoAllyToAttack] = this.noAllyToAttackText.GetLocalizedString();
    this.strings[NoTargetType.CantMove] = this.cantMoveText.GetLocalizedString();
  }

  public static bool Exists() => (bool) (UnityEngine.Object) NoTargetTextSystem.instance;

  public static IEnumerator Run(Entity entity, NoTargetType type, params object[] args)
  {
    return NoTargetTextSystem.instance._Run(entity, type, args);
  }

  private IEnumerator _Run(Entity entity, NoTargetType type, params object[] args)
  {
    NoTargetTextSystem targetTextSystem = this;
    if (targetTextSystem.enabled)
    {
      yield return (object) Sequences.WaitForAnimationEnd(entity);
      float num1 = targetTextSystem.shakeDurationRange.Random();
      double num2 = (double) entity.curveAnimator.Move(targetTextSystem.shakeAmount.WithX(targetTextSystem.shakeAmount.x.WithRandomSign()), targetTextSystem.shakeCurve, duration: num1);
      targetTextSystem.textElement.text = type == NoTargetType.None ? "" : targetTextSystem.strings[type].Format(args);
      targetTextSystem.PopText(entity.transform.position);
      yield return (object) new WaitForSeconds(num1);
    }
  }

  private void PopText(Vector3 fromPos)
  {
    GameObject obj = this.textElement.gameObject;
    obj.SetActive(true);
    LeanTween.cancel(obj);
    obj.transform.position = fromPos;
    LeanTween.move(obj, fromPos + this.textPopOffset, 1.5f).setEaseOutElastic();
    this.textElement.color = this.textElement.color.WithAlpha(1f);
    LeanTween.value(obj, 1f, 0.0f, 0.2f).setDelay(1.3f).setOnUpdate((Action<float>) (a => this.textElement.color = this.textElement.color.WithAlpha(a))).setOnComplete((System.Action) (() => obj.SetActive(false)));
    SfxSystem.OneShot(this.sfxEvent);
  }
}
