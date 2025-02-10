// Decompiled with JetBrains decompiler
// Type: NavigationStateCard
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class NavigationStateCard : INavigationState
{
  private readonly List<UINavigationItem> disabled = new List<UINavigationItem>();
  private readonly Entity entity;

  public NavigationStateCard(Entity entity) => this.entity = entity;

  public void Begin()
  {
    List<CardContainer> cardContainerList = new List<CardContainer>();
    foreach (CardContainer container in ((IEnumerable<CardContainer>) UnityEngine.Object.FindObjectsOfType<CardContainer>()).Where<CardContainer>((Func<CardContainer, bool>) (c => (bool) (UnityEngine.Object) c.nav && c.nav.enabled)))
    {
      if (this.entity.CanPlayOn(container))
        cardContainerList.Add(container);
      else
        this.Disable(container.nav);
    }
    foreach (Entity card in References.Battle.cards)
    {
      if ((bool) (UnityEngine.Object) card.uINavigationItem && card.uINavigationItem.enabled && (this.entity.data.playType != Card.PlayType.Play || !this.entity.CanPlayOn(card)))
        this.Disable(card.uINavigationItem);
    }
    this.Disable(RedrawBellSystem.nav);
    this.Disable(WaveDeploySystem.nav);
    if (References.Battle.playerCardController is CardControllerBattle playerCardController)
    {
      UINavigationItem useOnHandAnchor = playerCardController.useOnHandAnchor;
      if (useOnHandAnchor != null && this.entity.NeedsTarget)
        this.Disable(useOnHandAnchor);
    }
    Dictionary<UINavigationItem, UINavigationItem.SelectionPriority> dictionary = new Dictionary<UINavigationItem, UINavigationItem.SelectionPriority>();
    foreach (CardContainer cardContainer in cardContainerList)
    {
      if (cardContainer is CardSlot && cardContainer.Empty)
      {
        UINavigationItem nav = cardContainer.nav;
        if (nav != null && nav.enabled)
        {
          dictionary[nav] = nav.selectionPriority;
          nav.selectionPriority = UINavigationItem.SelectionPriority.Mega;
        }
      }
    }
    UINavigationDefaultSystem.SetDefaultTarget(this.entity);
    foreach (KeyValuePair<UINavigationItem, UINavigationItem.SelectionPriority> keyValuePair in dictionary)
      keyValuePair.Key.selectionPriority = keyValuePair.Value;
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
