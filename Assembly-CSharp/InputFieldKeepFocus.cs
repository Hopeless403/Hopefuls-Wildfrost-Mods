// Decompiled with JetBrains decompiler
// Type: InputFieldKeepFocus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof (TMP_InputField))]
public class InputFieldKeepFocus : MonoBehaviour
{
  private TMP_InputField _i;
  private PointerEventData _e;
  private bool focused;

  private TMP_InputField i => this._i ?? (this._i = this.GetComponent<TMP_InputField>());

  private PointerEventData e => this._e ?? (this._e = new PointerEventData(EventSystem.current));

  private void Update()
  {
    if (this.focused)
      return;
    if (!this.i.isFocused)
    {
      Debug.Log((object) ("[" + this.name + "] is not focused! Attempting to select"));
      this.i.OnPointerClick(this.e);
    }
    if (!this.i.isFocused)
      return;
    this.focused = true;
  }

  private void OnDisable() => this.focused = false;
}
