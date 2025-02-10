// Decompiled with JetBrains decompiler
// Type: UpgradeDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class UpgradeDisplay : MonoBehaviour
{
  [SerializeField]
  private Image image;
  public UINavigationItem navigationItem;
  private Image _raycast;

  public CardUpgradeData data { get; private set; }

  private Image raycast => this._raycast ?? (this._raycast = this.GetComponent<Image>());

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
