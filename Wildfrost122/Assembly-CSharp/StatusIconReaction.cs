// Decompiled with JetBrains decompiler
// Type: StatusIconReaction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class StatusIconReaction : StatusIcon
{
  public Sprite snowSprite;
  private Image _image;
  private Sprite baseSprite;
  private int snowPre;

  private Image image
  {
    get
    {
      if ((UnityEngine.Object) this._image == (UnityEngine.Object) null)
      {
        this._image = this.GetComponent<Image>();
        this.baseSprite = this._image.sprite;
      }
      return this._image;
    }
  }

  public void UpdateDisplay()
  {
    int num = (bool) (UnityEngine.Object) this.target ? this.target.SnowAmount() : 0;
    this.image.sprite = num <= 0 || !(bool) (UnityEngine.Object) this.snowSprite ? this.baseSprite : this.snowSprite;
    this.snowPre = num;
  }

  public override void CheckRemove()
  {
    if (this.target.statusEffects.Any<StatusEffectData>((Func<StatusEffectData, bool>) (a => a.isReaction)))
      return;
    this.SetValue(new Stat());
    this.target.display.reactionIcon = (StatusIcon) null;
  }
}
