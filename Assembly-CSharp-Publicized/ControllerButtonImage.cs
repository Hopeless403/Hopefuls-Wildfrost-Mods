﻿// Decompiled with JetBrains decompiler
// Type: ControllerButtonImage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof (Image))]
public class ControllerButtonImage : MonoBehaviour
{
  [SerializeField]
  public bool deactivateIfNull = true;
  [SerializeField]
  public bool disableIfNull;
  public Image image;
  [CompilerGenerated]
  public string \u003CactionName\u003Ek__BackingField;

  public string actionName
  {
    get => this.\u003CactionName\u003Ek__BackingField;
    set => this.\u003CactionName\u003Ek__BackingField = value;
  }

  public void OnEnable()
  {
    this.image = this.GetComponent<Image>();
    global::Events.OnButtonStyleChanged += new UnityAction(this.ButtonStyleChanged);
  }

  public void OnDisable() => global::Events.OnButtonStyleChanged -= new UnityAction(this.ButtonStyleChanged);

  public void Set(string actionName)
  {
    this.actionName = actionName;
    Sprite sprite = ControllerButtonSystem.Get(actionName);
    if (this.deactivateIfNull)
      this.gameObject.SetActive((bool) (Object) sprite);
    if (this.disableIfNull)
      this.image.enabled = (bool) (Object) sprite;
    if (!(bool) (Object) sprite)
      return;
    this.image.sprite = sprite;
  }

  public void ButtonStyleChanged()
  {
    if (this.actionName.IsNullOrWhitespace())
      return;
    this.Set(this.actionName);
  }
}
