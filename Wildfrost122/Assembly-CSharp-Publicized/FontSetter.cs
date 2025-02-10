// Decompiled with JetBrains decompiler
// Type: FontSetter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using TMPro;
using UnityEngine;

#nullable disable
[RequireComponent(typeof (TMP_Text))]
public class FontSetter : MonoBehaviour
{
  public TMP_Text _textElement;
  public bool registered;

  public TMP_Text textElement
  {
    get => this._textElement ?? (this._textElement = this.GetComponent<TMP_Text>());
  }

  public void OnEnable()
  {
    FontSetterSystem.Register(this);
    this.registered = true;
  }

  public void OnDisable()
  {
    if (!this.registered)
      return;
    FontSetterSystem.Unregister(this);
    this.registered = false;
  }

  public void SetFont(TMP_FontAsset font) => this.textElement.font = font;
}
