// Decompiled with JetBrains decompiler
// Type: TextMeshFitter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using TMPro;
using UnityEngine;

#nullable disable
[RequireComponent(typeof (TMP_Text))]
public class TextMeshFitter : MonoBehaviour
{
  private TMP_Text _textElement;
  private RectTransform _rectTransform;
  [SerializeField]
  private SpriteRenderer parentSprite;
  [SerializeField]
  private bool autoUpdate = true;
  [SerializeField]
  private Vector2 minSize;
  private bool dirty = true;

  public string text
  {
    get => this.textElement.text;
    set
    {
      this.textElement.text = value;
      this.dirty = true;
    }
  }

  private TMP_Text textElement
  {
    get => this._textElement ?? (this._textElement = this.GetComponent<TMP_Text>());
  }

  private RectTransform rectTransform
  {
    get => this._rectTransform ?? (this._rectTransform = this.transform as RectTransform);
  }

  private void Update()
  {
    if (!this.dirty && (!this.autoUpdate || !this.textElement.havePropertiesChanged))
      return;
    this.Run();
    this.dirty = false;
  }

  private void Run()
  {
    TMP_LineInfo[] lineInfo = this.textElement.textInfo.lineInfo;
    float a = 0.0f;
    float num = 0.0f;
    foreach (TMP_LineInfo tmpLineInfo in lineInfo)
    {
      if (tmpLineInfo.characterCount > 0)
      {
        a = Mathf.Max(a, tmpLineInfo.length);
        num += tmpLineInfo.lineHeight;
      }
    }
    Vector4 margin = this.textElement.margin;
    float b1 = a + (margin.x + margin.z);
    float b2 = num + (margin.y + margin.w);
    float x = Mathf.Max(this.minSize.x, b1);
    float y = Mathf.Max(this.minSize.y, b2);
    if ((Object) this.parentSprite != (Object) null)
    {
      Vector3 localScale = this.rectTransform.localScale;
      this.parentSprite.size = new Vector2(x * localScale.x, y * localScale.y);
    }
    this.rectTransform.sizeDelta = new Vector2(x, y);
  }

  [Button("Force Update", EButtonEnableMode.Always)]
  public void ForceUpdate() => this.Run();
}
