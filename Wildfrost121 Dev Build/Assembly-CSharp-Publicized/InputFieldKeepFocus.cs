﻿// Decompiled with JetBrains decompiler
// Type: InputFieldKeepFocus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
[RequireComponent(typeof (TMP_InputField))]
public class InputFieldKeepFocus : MonoBehaviour
{
  public TMP_InputField _i;
  public PointerEventData _e;
  public bool focused;

  public TMP_InputField i => this._i ?? (this._i = this.GetComponent<TMP_InputField>());

  public PointerEventData e => this._e ?? (this._e = new PointerEventData(EventSystem.current));

  public void Update()
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

  public void OnDisable() => this.focused = false;
}
