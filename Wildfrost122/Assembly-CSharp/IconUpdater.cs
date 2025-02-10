// Decompiled with JetBrains decompiler
// Type: IconUpdater
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

#nullable disable
[RequireComponent(typeof (Image))]
[RequireComponent(typeof (StatusIcon))]
public class IconUpdater : MonoBehaviour
{
  public Sprite iconIfValueBelowMax;
  public Sprite iconIfValueAboveMax;
  private Image image;
  private Sprite defaultIcon;

  private void Awake()
  {
    this.image = this.GetComponent<Image>();
    this.defaultIcon = this.image.sprite;
  }

  public void CheckUpdate(Stat previousValue, Stat newValue)
  {
    StatusIcon component = this.GetComponent<StatusIcon>();
    if (!((Object) component != (Object) null) || !((Object) component.target != (Object) null))
      return;
    if (newValue.current < newValue.max && previousValue.current >= previousValue.max)
      this.image.sprite = (Object) this.iconIfValueBelowMax != (Object) null ? this.iconIfValueBelowMax : this.defaultIcon;
    else if ((Object) this.iconIfValueAboveMax != (Object) null && newValue.current > newValue.max && previousValue.current <= previousValue.max)
    {
      this.image.sprite = (Object) this.iconIfValueAboveMax != (Object) null ? this.iconIfValueAboveMax : this.defaultIcon;
    }
    else
    {
      if (newValue.current != newValue.max || previousValue.current == previousValue.max)
        return;
      this.image.sprite = this.defaultIcon;
    }
  }
}
