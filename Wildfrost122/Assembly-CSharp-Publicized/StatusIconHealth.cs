// Decompiled with JetBrains decompiler
// Type: StatusIconHealth
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[RequireComponent(typeof (StatusIcon))]
public class StatusIconHealth : MonoBehaviour
{
  [SerializeField]
  public StatusIconHealth.Type[] types;
  [SerializeField]
  public GameObject current;
  public StatusIcon _icon;

  public StatusIcon icon => this._icon ?? (this._icon = this.GetComponent<StatusIcon>());

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
