// Decompiled with JetBrains decompiler
// Type: JournalIconGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class JournalIconGroup : MonoBehaviour
{
  [SerializeField]
  public List<ButtonAnimator> buttons;
  [SerializeField]
  public Image[] icons;
  [SerializeField]
  public Color baseColour = Color.white;
  [SerializeField]
  public Color highlightColour = Color.white;
  public ButtonAnimator currentHover;
  public Image highlightedIcon;

  public void Awake()
  {
    foreach (Graphic icon in this.icons)
      icon.color = this.baseColour;
  }

  public void Update()
  {
    if ((UnityEngine.Object) this.currentHover == (UnityEngine.Object) null)
    {
      ButtonAnimator buttonAnimator = this.buttons.FirstOrDefault<ButtonAnimator>((Func<ButtonAnimator, bool>) (a => a.IsHoveredOrPressed));
      if (!((UnityEngine.Object) buttonAnimator != (UnityEngine.Object) null))
        return;
      this.currentHover = buttonAnimator;
      this.Changed();
    }
    else
    {
      if (this.currentHover.IsHoveredOrPressed)
        return;
      this.currentHover = (ButtonAnimator) null;
      this.Changed();
    }
  }

  public void Changed()
  {
    if ((UnityEngine.Object) this.highlightedIcon != (UnityEngine.Object) null)
      this.highlightedIcon.color = this.baseColour;
    if (!((UnityEngine.Object) this.currentHover != (UnityEngine.Object) null))
      return;
    this.highlightedIcon = this.icons[this.buttons.IndexOf(this.currentHover)];
    this.highlightedIcon.color = this.highlightColour;
  }
}
