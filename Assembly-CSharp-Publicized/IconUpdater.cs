// Decompiled with JetBrains decompiler
// Type: IconUpdater
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof (Image))]
[RequireComponent(typeof (StatusIcon))]
public class IconUpdater : MonoBehaviour
{
  public Sprite iconIfValueBelowMax;
  public Sprite iconIfValueAboveMax;
  public Image image;
  public Sprite defaultIcon;

  public void Awake()
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
