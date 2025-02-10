// Decompiled with JetBrains decompiler
// Type: NavigationStateAssignUpgrade
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
public class NavigationStateAssignUpgrade : INavigationState
{
  public readonly List<UINavigationItem> disabled = new List<UINavigationItem>();
  public readonly List<Entity> eligibleCards;

  public NavigationStateAssignUpgrade(List<Entity> eligibleCards)
  {
    this.eligibleCards = eligibleCards;
  }

  public void Begin()
  {
    foreach (UpgradeDisplay upgradeDisplay in UnityEngine.Object.FindObjectsOfType<UpgradeDisplay>())
      this.Disable(upgradeDisplay.navigationItem);
    DeckDisplay objectOfType = UnityEngine.Object.FindObjectOfType<DeckDisplay>();
    if (objectOfType != null)
      this.Disable(objectOfType.backButtonNavigationItem);
    Dictionary<UINavigationItem, UINavigationItem.SelectionPriority> dictionary = new Dictionary<UINavigationItem, UINavigationItem.SelectionPriority>();
    foreach (UINavigationItem key in this.eligibleCards.Select<Entity, UINavigationItem>((Func<Entity, UINavigationItem>) (a => a.uINavigationItem)))
    {
      dictionary[key] = key.selectionPriority;
      key.selectionPriority = UINavigationItem.SelectionPriority.Mega;
    }
    UINavigationDefaultSystem.SetStartingItem(false);
    foreach (KeyValuePair<UINavigationItem, UINavigationItem.SelectionPriority> keyValuePair in dictionary)
      keyValuePair.Key.selectionPriority = keyValuePair.Value;
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
