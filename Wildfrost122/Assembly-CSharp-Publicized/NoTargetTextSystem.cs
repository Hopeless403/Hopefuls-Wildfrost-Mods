// Decompiled with JetBrains decompiler
// Type: NoTargetTextSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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
  public static NoTargetTextSystem instance;
  [SerializeField]
  public AnimationCurve shakeCurve;
  [SerializeField]
  public Vector3 shakeAmount = new Vector3(1f, 0.0f, 0.0f);
  [SerializeField]
  public Vector2 shakeDurationRange = new Vector2(0.3f, 0.4f);
  [SerializeField]
  public TMP_Text textElement;
  [SerializeField]
  public Vector3 textPopOffset = new Vector3(0.0f, 1.5f, -1f);
  [SerializeField]
  public EventReference sfxEvent;
  [Header("Text")]
  [SerializeField]
  public LocalizedString noTargetToAttackText;
  [SerializeField]
  public LocalizedString noAlliesToHealText;
  [SerializeField]
  public LocalizedString noTargetForStatusText;
  [SerializeField]
  public LocalizedString noSpaceToSummonText;
  [SerializeField]
  public LocalizedString noCardsToDrawText;
  [SerializeField]
  public LocalizedString noAllyToBoostText;
  [SerializeField]
  public LocalizedString noEnemyToBoostText;
  [SerializeField]
  public LocalizedString requiresJunkText;
  [SerializeField]
  public LocalizedString cantSplitText;
  [SerializeField]
  public LocalizedString noSummonedAlliesText;
  [SerializeField]
  public LocalizedString playCrownCardsText;
  [SerializeField]
  public LocalizedString noAllyToAttackText;
  [SerializeField]
  public LocalizedString cantMoveText;
  public readonly Dictionary<NoTargetType, string> strings = new Dictionary<NoTargetType, string>();

  public void OnEnable()
  {
    NoTargetTextSystem.instance = this;
    LocalizationSettings.SelectedLocaleChanged += new Action<Locale>(this.LocaleChanged);
    this.PopulateStrings();
  }

  public void OnDisable()
  {
    LocalizationSettings.SelectedLocaleChanged -= new Action<Locale>(this.LocaleChanged);
  }

  public void LocaleChanged(Locale locale) => this.PopulateStrings();

  public void PopulateStrings()
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

  public IEnumerator _Run(Entity entity, NoTargetType type, params object[] args)
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

  public void PopText(Vector3 fromPos)
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
