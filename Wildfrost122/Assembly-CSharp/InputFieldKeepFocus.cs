// Decompiled with JetBrains decompiler
// Type: InputFieldKeepFocus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
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
