// Decompiled with JetBrains decompiler
// Type: InspectNewUnitSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;
using UnityEngine.Localization;

public class InspectNewUnitSequence : UISequence
{
  [Header("Custom Values")]
  public bool takeCard;
  public Transform cardHolder;
  [SerializeField]
  public SpeechBubble speechBubble;
  [SerializeField]
  public LocalizedString[] defaultGreetMessages;
  [SerializeField]
  public Color nameHighlightColour;
  [SerializeField]
  public Color nameTextColour;
  public Entity unit;
  public string greeting;
  public Transform unitPreParent;
  public Vector3 unitPrePosition;
  public Vector3 unitPreRotation;
  public Vector3 unitPreScale;
  [SerializeField]
  public float unitMoveWobble = 1.5f;
  [SerializeField]
  public AnimationCurve unitMoveCurve;
  [SerializeField]
  public float unitMoveDur = 0.33f;
  public CardSelector cardSelector;
  [SerializeField]
  public RenameCompanionSequence renameSequence;
  public bool destroyOnEnd;

  public void SetUnit(Entity unit) => this.SetUnit(unit, true);

  public void SetUnit(Entity unit, bool updateGreeting)
  {
    this.unit = unit;
    if (updateGreeting && (Object) this.speechBubble != (Object) null)
      this.greeting = unit.data.greetMessages.Length > 0 ? unit.data.greetMessages.RandomItem<string>() : this.defaultGreetMessages.RandomItem<LocalizedString>().GetLocalizedString();
    this.UpdateUnit();
  }

  public void UpdateUnit()
  {
    if ((Object) this.speechBubble == (Object) null)
      return;
    string newValue = this.unit.data.title;
    if ((double) this.nameTextColour.a > 0.0)
      newValue = "<color=#" + this.nameTextColour.ToHexRGBA() + ">" + newValue + "</color>";
    if ((double) this.nameHighlightColour.a > 0.0)
      newValue = "<mark=#" + this.nameHighlightColour.ToHexRGBA() + ">" + newValue + "</mark>";
    this.speechBubble.SetText(this.greeting.Replace("<name>", newValue));
  }

  public void UnsetUnit() => this.unit = (Entity) null;

  public override IEnumerator Run()
  {
    InspectNewUnitSequence inspectNewUnitSequence = this;
    UIAnchors anchors = inspectNewUnitSequence.GetComponent<UIAnchors>();
    foreach (UIAnchors.AnchorPoint anchorPoint in anchors.list)
    {
      anchorPoint.Deactivate();
      anchorPoint.SetUp();
    }
    yield return (object) Sequences.Wait(inspectNewUnitSequence.startDelay);
    Events.InvokeInspectNewCard(inspectNewUnitSequence.unit);
    Events.InvokeEntityFocus(inspectNewUnitSequence.unit);
    if (inspectNewUnitSequence.gameObject.activeSelf)
      inspectNewUnitSequence.GetComponent<UINavigationLayer>().OnEnable();
    inspectNewUnitSequence.gameObject.SetActive(true);
    if ((double) inspectNewUnitSequence.unitMoveWobble != 0.0 && (Object) inspectNewUnitSequence.unit.wobbler != (Object) null)
      inspectNewUnitSequence.unit.wobbler.WobbleRandom(inspectNewUnitSequence.unitMoveWobble);
    Transform transform = inspectNewUnitSequence.unit.transform;
    inspectNewUnitSequence.unitPreParent = transform.parent;
    inspectNewUnitSequence.unitPrePosition = transform.localPosition;
    inspectNewUnitSequence.unitPreRotation = transform.localEulerAngles;
    inspectNewUnitSequence.unitPreScale = transform.localScale;
    transform.SetParent(inspectNewUnitSequence.cardHolder, true);
    LeanTween.cancel(inspectNewUnitSequence.unit.gameObject);
    LeanTween.moveLocal(inspectNewUnitSequence.unit.gameObject, Vector3.zero, inspectNewUnitSequence.unitMoveDur).setEase(inspectNewUnitSequence.unitMoveCurve);
    LeanTween.rotateLocal(inspectNewUnitSequence.unit.gameObject, Vector3.zero, inspectNewUnitSequence.unitMoveDur).setEase(inspectNewUnitSequence.unitMoveCurve);
    LeanTween.scale(inspectNewUnitSequence.unit.gameObject, Vector3.one, inspectNewUnitSequence.unitMoveDur).setEase(inspectNewUnitSequence.unitMoveCurve);
    int c = anchors.Count;
    for (int i = 0; i < c; ++i)
    {
      anchors.Activate(i);
      yield return (object) null;
      inspectNewUnitSequence.StartCoroutine(anchors.Reveal(i));
      yield return (object) Sequences.Wait(inspectNewUnitSequence.delayBetween);
    }
    inspectNewUnitSequence.StartCoroutine(anchors.UpdatePositions());
    while (!inspectNewUnitSequence.promptEnd)
      yield return (object) null;
    inspectNewUnitSequence.promptEnd = false;
    MonoBehaviourSingleton<UINavigationSystem>.instance.RemoveActiveLayer();
    if (!inspectNewUnitSequence.takeCard && (Object) inspectNewUnitSequence.unit != (Object) null)
    {
      inspectNewUnitSequence.unit.transform.SetParent(inspectNewUnitSequence.unitPreParent, true);
      LeanTween.cancel(inspectNewUnitSequence.unit.gameObject);
      LeanTween.moveLocal(inspectNewUnitSequence.unit.gameObject, inspectNewUnitSequence.unitPrePosition, inspectNewUnitSequence.unitMoveDur).setEase(inspectNewUnitSequence.unitMoveCurve);
      LeanTween.rotateLocal(inspectNewUnitSequence.unit.gameObject, inspectNewUnitSequence.unitPreRotation, inspectNewUnitSequence.unitMoveDur).setEase(inspectNewUnitSequence.unitMoveCurve);
      LeanTween.scale(inspectNewUnitSequence.unit.gameObject, inspectNewUnitSequence.unitPreScale, inspectNewUnitSequence.unitMoveDur).setEase(inspectNewUnitSequence.unitMoveCurve);
      if ((double) inspectNewUnitSequence.unitMoveWobble != 0.0 && (Object) inspectNewUnitSequence.unit.wobbler != (Object) null)
        inspectNewUnitSequence.unit.wobbler.WobbleRandom(inspectNewUnitSequence.unitMoveWobble);
    }
    if (inspectNewUnitSequence.destroyOnEnd)
      inspectNewUnitSequence.gameObject.Destroy();
    else
      inspectNewUnitSequence.gameObject.SetActive(false);
  }

  public void TakeCard()
  {
    if (this.takeCard)
      return;
    this.End();
    if (!((Object) this.unit != (Object) null))
      return;
    this.takeCard = true;
    this.cardSelector.TakeCard(this.unit);
  }

  public void StartRename()
  {
    if (this.takeCard)
      return;
    this.renameSequence.SetUnit(this.unit);
    this.renameSequence.Begin();
  }
}
