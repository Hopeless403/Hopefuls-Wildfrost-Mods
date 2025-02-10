// Decompiled with JetBrains decompiler
// Type: CardPopUpTarget
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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
  public Card card;
  [HideIf("IsCard")]
  public KeywordData[] keywords;
  [SerializeField]
  [HideIf("IsCard")]
  [Range(-1f, 1f)]
  public float posX = 1f;
  [SerializeField]
  [HideIf("IsCard")]
  [Range(-1f, 1f)]
  public float posY;
  public readonly HashSet<string> current = new HashSet<string>();

  public bool IsCard => (Object) this.card != (Object) null;

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

  public void OnDisable() => this.current.Clear();
}
