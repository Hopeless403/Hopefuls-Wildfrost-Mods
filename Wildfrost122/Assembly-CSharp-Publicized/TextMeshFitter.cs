// Decompiled with JetBrains decompiler
// Type: TextMeshFitter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using TMPro;
using UnityEngine;

#nullable disable
[RequireComponent(typeof (TMP_Text))]
public class TextMeshFitter : MonoBehaviour
{
  public TMP_Text _textElement;
  public RectTransform _rectTransform;
  [SerializeField]
  public SpriteRenderer parentSprite;
  [SerializeField]
  public bool autoUpdate = true;
  [SerializeField]
  public Vector2 minSize;
  public bool dirty = true;

  public string text
  {
    get => this.textElement.text;
    set
    {
      this.textElement.text = value;
      this.dirty = true;
    }
  }

  public TMP_Text textElement
  {
    get => this._textElement ?? (this._textElement = this.GetComponent<TMP_Text>());
  }

  public RectTransform rectTransform
  {
    get => this._rectTransform ?? (this._rectTransform = this.transform as RectTransform);
  }

  public void Update()
  {
    if (!this.dirty && (!this.autoUpdate || !this.textElement.havePropertiesChanged))
      return;
    this.Run();
    this.dirty = false;
  }

  public void Run()
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
