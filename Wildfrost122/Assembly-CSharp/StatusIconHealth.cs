﻿// Decompiled with JetBrains decompiler
// Type: StatusIconHealth
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[RequireComponent(typeof (StatusIcon))]
public class StatusIconHealth : MonoBehaviour
{
  [SerializeField]
  private StatusIconHealth.Type[] types;
  [SerializeField]
  private GameObject current;
  private StatusIcon _icon;

  private StatusIcon icon => this._icon ?? (this._icon = this.GetComponent<StatusIcon>());

  public void SetType()
  {
    if ((UnityEngine.Object) this.icon.target == (UnityEngine.Object) null)
      return;
    string cardTypeName = this.icon.target.data.cardType.name;
    if (!((UnityEngine.Object) this.current == (UnityEngine.Object) null) && !(this.current.name != cardTypeName))
      return;
    StatusIconHealth.Type type = Array.Find<StatusIconHealth.Type>(this.types, (Predicate<StatusIconHealth.Type>) (a => a.name == cardTypeName));
    if (type == null)
      return;
    this.current.SetActive(false);
    type.Assign(this.icon);
    this.current = type.group;
  }

  [Serializable]
  public class Type
  {
    public string name;
    public GameObject group;
    public TMP_Text textElement;
    public Image fill;

    public void Assign(StatusIcon icon)
    {
      this.group.SetActive(true);
      icon.textElement = this.textElement;
      icon.fill = this.fill;
    }
  }
}
