// Decompiled with JetBrains decompiler
// Type: RenameCompanionSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Steamworks;
using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class RenameCompanionSequence : UISequence
{
  [Header("Custom Values")]
  [SerializeField]
  private Transform cardHolder;
  [SerializeField]
  private TMP_InputField inputField;
  private Entity unit;
  private Transform unitPreParent;
  private Vector3 unitPrePosition;
  private Vector3 unitPreRotation;
  private Vector3 unitPreScale;
  [SerializeField]
  private float unitMoveWobble = 1.5f;
  [SerializeField]
  private AnimationCurve unitMoveCurve;
  [SerializeField]
  private float unitMoveDur = 0.33f;
  private bool endImmediate;

  private void OnEnable() => SteamUtils.OnGamepadTextInputDismissed += new Action<bool>(this.GamepadTextInputDismissed);

  private void OnDisable() => SteamUtils.OnGamepadTextInputDismissed -= new Action<bool>(this.GamepadTextInputDismissed);

  private void GamepadTextInputDismissed(bool success)
  {
    if (success)
    {
      this.inputField.text = SteamUtils.GetEnteredGamepadText();
      this.Confirm();
    }
    else
      this.Cancel();
  }

  public void SetUnit(Entity unit)
  {
    this.unit = unit;
    if (!(this.inputField.placeholder is TMP_Text placeholder))
      return;
    placeholder.text = unit.data.title;
  }

  public override IEnumerator Run()
  {
    RenameCompanionSequence companionSequence = this;
    companionSequence.endImmediate = false;
    companionSequence.inputField.text = "";
    UIAnchors anchors = companionSequence.GetComponent<UIAnchors>();
    foreach (UIAnchors.AnchorPoint anchorPoint in anchors.list)
    {
      anchorPoint.Deactivate();
      anchorPoint.SetUp();
    }
    yield return (object) Sequences.Wait(companionSequence.startDelay);
    companionSequence.gameObject.SetActive(true);
    if ((double) companionSequence.unitMoveWobble != 0.0 && (UnityEngine.Object) companionSequence.unit.wobbler != (UnityEngine.Object) null)
      companionSequence.unit.wobbler.WobbleRandom(companionSequence.unitMoveWobble);
    Transform transform = companionSequence.unit.transform;
    companionSequence.unitPreParent = transform.parent;
    companionSequence.unitPrePosition = transform.localPosition;
    companionSequence.unitPreRotation = transform.localEulerAngles;
    companionSequence.unitPreScale = transform.localScale;
    companionSequence.unit.transform.SetParent(companionSequence.cardHolder, true);
    LeanTween.cancel(companionSequence.unit.gameObject);
    LeanTween.moveLocal(companionSequence.unit.gameObject, Vector3.zero, companionSequence.unitMoveDur).setEase(companionSequence.unitMoveCurve);
    LeanTween.rotateLocal(companionSequence.unit.gameObject, Vector3.zero, companionSequence.unitMoveDur).setEase(companionSequence.unitMoveCurve);
    LeanTween.scale(companionSequence.unit.gameObject, Vector3.one, companionSequence.unitMoveDur).setEase(companionSequence.unitMoveCurve);
    SfxSystem.OneShot("event:/sfx/ui/card_renaming_open");
    int c = anchors.Count;
    for (int i = 0; i < c; ++i)
    {
      anchors.Activate(i);
      yield return (object) null;
      companionSequence.StartCoroutine(anchors.Reveal(i));
      yield return (object) Sequences.Wait(companionSequence.delayBetween);
    }
    companionSequence.StartCoroutine(anchors.UpdatePositions());
    if (SteamManager.init && SteamUtils.IsRunningOnSteamDeck)
      SteamUtils.ShowGamepadTextInput(GamepadTextInputMode.Normal, GamepadTextInputLineMode.SingleLine, "", 20, companionSequence.unit.data.title);
    while (!companionSequence.promptEnd)
      yield return (object) null;
    companionSequence.promptEnd = false;
    if (!companionSequence.endImmediate && (UnityEngine.Object) companionSequence.unit != (UnityEngine.Object) null)
    {
      companionSequence.unit.transform.SetParent(companionSequence.unitPreParent, true);
      LeanTween.cancel(companionSequence.unit.gameObject);
      LeanTween.moveLocal(companionSequence.unit.gameObject, companionSequence.unitPrePosition, companionSequence.unitMoveDur).setEase(companionSequence.unitMoveCurve);
      LeanTween.rotateLocal(companionSequence.unit.gameObject, companionSequence.unitPreRotation, companionSequence.unitMoveDur).setEase(companionSequence.unitMoveCurve);
      LeanTween.scale(companionSequence.unit.gameObject, companionSequence.unitPreScale, companionSequence.unitMoveDur).setEase(companionSequence.unitMoveCurve);
    }
    companionSequence.gameObject.SetActive(false);
  }

  public void Confirm()
  {
    if (!this.inputField.text.IsNullOrWhitespace())
    {
      Entity unit = this.unit;
      string text = this.inputField.text;
      if (Events.CheckRename(ref unit, ref text))
      {
        SfxSystem.OneShot("event:/sfx/ui/card_renaming_accept");
        unit.data.forceTitle = text;
        if (unit.display is Card display)
          display.SetName(unit.data.title);
        Events.InvokeRename(unit, text);
      }
    }
    this.End();
  }

  public void Cancel() => this.End();

  public void EndImmediate()
  {
    this.endImmediate = true;
    this.End();
  }
}
