// Decompiled with JetBrains decompiler
// Type: CardPopUpTarget
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
public class CardPopUpTarget : MonoBehaviourRect
{
  [SerializeField]
  [ReadOnly]
  public bool popped;
  [SerializeField]
  private Card card;
  [HideIf("IsCard")]
  public KeywordData[] keywords;
  [SerializeField]
  [HideIf("IsCard")]
  [Range(-1f, 1f)]
  private float posX = 1f;
  [SerializeField]
  [HideIf("IsCard")]
  [Range(-1f, 1f)]
  private float posY;
  private readonly HashSet<string> current = new HashSet<string>();

  private bool IsCard => (Object) this.card != (Object) null;

  public void Pop()
  {
    if (this.IsCard)
    {
      CardPopUp.AssignToCard(this.card);
      if (this.card.mentionedCards != null)
      {
        foreach (CardData mentionedCard in this.card.mentionedCards)
        {
          if (this.current.Add(mentionedCard.name))
            CardPopUp.AddPanel(mentionedCard);
        }
      }
      if (this.card.keywords != null)
      {
        foreach (KeywordData keyword in this.card.keywords)
        {
          if (this.current.Add(keyword.name))
            CardPopUp.AddPanel(keyword);
        }
      }
    }
    else if (this.keywords.Length != 0)
    {
      CardPopUp.AssignTo(this.rectTransform, this.posX, this.posY);
      foreach (KeywordData keyword in this.keywords)
      {
        if (this.current.Add(keyword.name))
          CardPopUp.AddPanel(keyword);
      }
    }
    this.popped = true;
  }

  public void UnPop()
  {
    if (this.current.Count > 0)
    {
      foreach (string name in this.current)
        CardPopUp.RemovePanel(name);
      this.current.Clear();
    }
    this.popped = false;
  }

  private void OnDisable() => this.current.Clear();
}
