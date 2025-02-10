// Decompiled with JetBrains decompiler
// Type: UpgradeDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class UpgradeDisplay : MonoBehaviour
{
  [CompilerGenerated]
  public CardUpgradeData \u003Cdata\u003Ek__BackingField;
  [SerializeField]
  public Image image;
  public UINavigationItem navigationItem;
  public Image _raycast;

  public CardUpgradeData data
  {
    get => this.\u003Cdata\u003Ek__BackingField;
    set => this.\u003Cdata\u003Ek__BackingField = value;
  }

  public Image raycast => this._raycast ?? (this._raycast = this.GetComponent<Image>());

  public bool CanRaycast
  {
    set => this.raycast.raycastTarget = value;
  }

  public virtual void SetData(CardUpgradeData data)
  {
    this.data = data;
    this.image.sprite = data.image;
  }
}
