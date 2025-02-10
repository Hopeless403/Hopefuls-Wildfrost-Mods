// Decompiled with JetBrains decompiler
// Type: NavigationStateBattle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
public class NavigationStateBattle : INavigationState
{
  private readonly List<UINavigationItem> disabled = new List<UINavigationItem>();

  public void Begin()
  {
    foreach (CardSlotLane allRow in References.Battle.allRows)
    {
      this.Disable(allRow.nav);
      foreach (CardContainer slot in allRow.slots)
        this.Disable(slot.nav);
    }
    if (!(References.Battle.playerCardController is CardControllerBattle playerCardController))
      return;
    this.Disable(playerCardController.useOnHandAnchor);
  }

  public void End()
  {
    foreach (Behaviour behaviour in this.disabled.Where<UINavigationItem>((Func<UINavigationItem, bool>) (a => (bool) (UnityEngine.Object) a)))
      behaviour.enabled = true;
    this.disabled.Clear();
  }

  private void Disable(UINavigationItem item)
  {
    if (!(bool) (UnityEngine.Object) item)
      return;
    item.enabled = false;
    this.disabled.Add(item);
  }
}
