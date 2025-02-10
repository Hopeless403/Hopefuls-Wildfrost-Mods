// Decompiled with JetBrains decompiler
// Type: TextFitter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof (TMP_Text))]
public class TextFitter : MonoBehaviourRect
{
  private TMP_Text _textElement;
  [SerializeField]
  private LayoutElement layoutElement;
  [SerializeField]
  private RectTransform[] transforms;
  [SerializeField]
  private bool fitWidth = true;
  [SerializeField]
  [ShowIf("fitWidth")]
  private float minWidth = 3f;
  [SerializeField]
  [ShowIf("fitWidth")]
  private float maxWidth = 5f;
  [SerializeField]
  private bool fitHeight = true;
  [SerializeField]
  [ShowIf("fitHeight")]
  private float minHeight = 1f;
  [SerializeField]
  [ShowIf("fitHeight")]
  private float maxHeight = 1f;

  private TMP_Text textElement => this._textElement ?? (this._textElement = this.GetComponent<TMP_Text>());

  public void SetText(string text)
  {
    this.textElement.text = text;
    this.Fit();
  }

  private void Fit()
  {
    this.StopAllCoroutines();
    if (!this.fitWidth)
      return;
    this.StartCoroutine(this.FitRoutine());
  }

  private IEnumerator FitRoutine()
  {
    TextFitter textFitter = this;
    yield return (object) new WaitForEndOfFrame();
    Vector4 margin = textFitter.textElement.margin;
    Vector3 size = textFitter.textElement.textBounds.size;
    Vector2 sizeDelta = textFitter.rectTransform.sizeDelta;
    float num1 = textFitter.fitWidth ? Mathf.Clamp(size.x + margin.x + margin.z, textFitter.minWidth, textFitter.maxWidth) : sizeDelta.x;
    float num2 = textFitter.fitHeight ? Mathf.Clamp(size.y + margin.y + margin.w, textFitter.minHeight, textFitter.maxHeight) : sizeDelta.y;
    Vector2 vector2 = sizeDelta.With(new float?(num1), new float?(num2));
    textFitter.rectTransform.sizeDelta = vector2;
    if ((bool) (Object) textFitter.layoutElement)
    {
      if (textFitter.fitWidth)
        textFitter.layoutElement.preferredWidth = num1;
      if (textFitter.fitHeight)
        textFitter.layoutElement.preferredHeight = num2;
    }
    foreach (RectTransform transform in textFitter.transforms)
      transform.sizeDelta = vector2;
  }
}
