// Decompiled with JetBrains decompiler
// Type: FontSetter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
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
