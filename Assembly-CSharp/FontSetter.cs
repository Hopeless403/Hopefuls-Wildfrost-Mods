// Decompiled with JetBrains decompiler
// Type: FontSetter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using TMPro;
using UnityEngine;

[RequireComponent(typeof (TMP_Text))]
public class FontSetter : MonoBehaviour
{
  private TMP_Text _textElement;
  private bool registered;

  private TMP_Text textElement => this._textElement ?? (this._textElement = this.GetComponent<TMP_Text>());

  private void OnEnable()
  {
    FontSetterSystem.Register(this);
    this.registered = true;
  }

  private void OnDisable()
  {
    if (!this.registered)
      return;
    FontSetterSystem.Unregister(this);
    this.registered = false;
  }

  public void SetFont(TMP_FontAsset font) => this.textElement.font = font;
}
