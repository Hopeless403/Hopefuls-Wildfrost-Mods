// Decompiled with JetBrains decompiler
// Type: JournalCardDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using TMPro;
using UnityEngine;

#nullable disable
public class JournalCardDisplay : MonoBehaviour
{
  [SerializeField]
  public CardInspector inspector;
  [SerializeField]
  public JournalCardDisplay.PositionProfile normalPositionProfile;
  [SerializeField]
  public JournalCardDisplay.PositionProfile bigPositionProfile;
  [Header("Card Info Elements")]
  [SerializeField]
  public TMP_Text nameText;
  [SerializeField]
  public ImageSprite typeIcon;
  [SerializeField]
  public TMP_Text typeText;
  public CanvasGroup _canvasGroup;
  public Card current;
  public readonly Vector3 from = new Vector3(0.75f, 0.75f, 0.75f);

  public CanvasGroup canvasGroup
  {
    get => this._canvasGroup ?? (this._canvasGroup = this.gameObject.GetOrAdd<CanvasGroup>());
  }

  public void OnDisable()
  {
    if (!(bool) (UnityEngine.Object) this.current)
      return;
    this.nameText.text = "";
    this.typeIcon.enabled = false;
    this.typeText.text = "";
    this.inspector.ClearPopups();
    CardManager.ReturnToPoolNextFrame(this.current);
    this.current = (Card) null;
  }

  public void Display(CardData cardData)
  {
    if ((bool) (UnityEngine.Object) this.current)
    {
      if ((bool) (UnityEngine.Object) this.current.entity.data && (bool) (UnityEngine.Object) cardData && this.current.entity.data.name == cardData.name)
        return;
      CardManager.ReturnToPool(this.current);
    }
    this.current = CardManager.Get(cardData, (CardController) null, (Character) null, false, true);
    this.current.transform.SetParent(this.transform);
    if (this.current.entity.height == 2)
      this.bigPositionProfile.Set();
    else
      this.normalPositionProfile.Set();
    this.StopAllCoroutines();
    this.StartCoroutine(this.UpdateCard(this.current));
  }

  public IEnumerator UpdateCard(Card card)
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    JournalCardDisplay journalCardDisplay = this;
    if (num != 0)
    {
      if (num != 1)
        return false;
      // ISSUE: reference to a compiler-generated field
      this.\u003C\u003E1__state = -1;
      journalCardDisplay.nameText.text = card.entity.data.title;
      journalCardDisplay.typeIcon.enabled = true;
      journalCardDisplay.typeIcon.SetSprite(card.entity.data.cardType.icon);
      journalCardDisplay.typeText.text = card.entity.data.cardType.title;
      card.transform.SetLocalPositionAndRotation(Vector3.zero, Quaternion.identity);
      card.transform.localScale = Vector3.one;
      journalCardDisplay.inspector.ClearPopups();
      journalCardDisplay.inspector.CreatePopups(card.entity);
      LeanTween.cancel(journalCardDisplay.gameObject);
      journalCardDisplay.transform.localScale = journalCardDisplay.from;
      LeanTween.scale(journalCardDisplay.gameObject, Vector3.one, 0.2f).setEaseOutBack().setIgnoreTimeScale(true);
      journalCardDisplay.canvasGroup.alpha = 0.0f;
      LeanTween.alphaCanvas(journalCardDisplay.canvasGroup, 1f, 0.2f).setEaseOutBack().setIgnoreTimeScale(true);
      return false;
    }
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = -1;
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E2__current = (object) card.UpdateData(false);
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = 1;
    return true;
  }

  [Serializable]
  public struct PositionProfile
  {
    public RectTransform[] transforms;
    public Vector3[] anchoredPositions;

    public void Set()
    {
      for (int index = 0; index < this.transforms.Length; ++index)
        this.transforms[index].anchoredPosition = (Vector2) this.anchoredPositions[index];
    }
  }
}
