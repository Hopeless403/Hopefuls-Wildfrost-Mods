// Decompiled with JetBrains decompiler
// Type: JournalIconGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class JournalIconGroup : MonoBehaviour
{
  [SerializeField]
  private List<ButtonAnimator> buttons;
  [SerializeField]
  private Image[] icons;
  [SerializeField]
  private Color baseColour = Color.white;
  [SerializeField]
  private Color highlightColour = Color.white;
  private ButtonAnimator currentHover;
  private Image highlightedIcon;

  private void Awake()
  {
    foreach (Graphic icon in this.icons)
      icon.color = this.baseColour;
  }

  private void Update()
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

  private void Changed()
  {
    if ((UnityEngine.Object) this.highlightedIcon != (UnityEngine.Object) null)
      this.highlightedIcon.color = this.baseColour;
    if (!((UnityEngine.Object) this.currentHover != (UnityEngine.Object) null))
      return;
    this.highlightedIcon = this.icons[this.buttons.IndexOf(this.currentHover)];
    this.highlightedIcon.color = this.highlightColour;
  }
}
