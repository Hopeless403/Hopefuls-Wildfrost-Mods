// Decompiled with JetBrains decompiler
// Type: NavigationStateMuncher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class NavigationStateMuncher : INavigationState
{
  public readonly List<UINavigationItem> disabled = new List<UINavigationItem>();
  public readonly EventRoutineMuncher muncher;

  public NavigationStateMuncher(EventRoutineMuncher muncher) => this.muncher = muncher;

  public void Begin()
  {
    Button backButton = this.muncher.backButton;
    if (backButton != null)
      this.Disable(backButton.GetComponent<UINavigationItem>());
    foreach (Entity entity in this.muncher.cardContainer)
      this.Disable(entity.uINavigationItem);
    UINavigationDefaultSystem.SetStartingItem();
  }

  public void End()
  {
    foreach (Behaviour behaviour in this.disabled.Where<UINavigationItem>((Func<UINavigationItem, bool>) (a => (UnityEngine.Object) a != (UnityEngine.Object) null)))
      behaviour.enabled = true;
    this.disabled.Clear();
  }

  public void Disable(UINavigationItem item)
  {
    if ((UnityEngine.Object) item == (UnityEngine.Object) null)
      return;
    item.enabled = false;
    this.disabled.Add(item);
  }
}
