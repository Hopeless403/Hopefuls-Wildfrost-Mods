// Decompiled with JetBrains decompiler
// Type: ScriptAddRandomCards
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Add Random Cards", menuName = "Scripts/Add Random Cards")]
public class ScriptAddRandomCards : Script
{
  [SerializeField]
  public int replaceIndex = -1;
  [SerializeField]
  public bool anyCard;
  [SerializeField]
  [ShowIf("anyCard")]
  public CardType[] ofType;
  [SerializeField]
  [HideIf("anyCard")]
  public CardData[] pool;
  [SerializeField]
  public Vector2Int countRange;

  public override IEnumerator Run()
  {
    // ISSUE: reference to a compiler-generated field
    int num1 = this.\u003C\u003E1__state;
    ScriptAddRandomCards scriptAddRandomCards = this;
    if (num1 != 0)
      return false;
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = -1;
    CardDataList deck = References.PlayerData.inventory.deck;
    if (scriptAddRandomCards.replaceIndex >= 0)
      deck.RemoveAt(scriptAddRandomCards.replaceIndex);
    List<CardData> list = new List<CardData>();
    int num2 = scriptAddRandomCards.countRange.Random();
    for (int index = 0; index < num2; ++index)
    {
      if (list.Count <= 0)
        scriptAddRandomCards.PopulateCardList(list);
      CardData cardData = list.TakeRandom<CardData>().Clone();
      Debug.Log((object) (scriptAddRandomCards.name + " → Adding [" + cardData.name + "] to player's deck"));
      if (scriptAddRandomCards.replaceIndex >= 0)
        deck.Insert(scriptAddRandomCards.replaceIndex, cardData);
      else
        deck.Add(cardData);
    }
    return false;
  }

  public void PopulateCardList(List<CardData> list)
  {
    if (this.anyCard)
    {
      foreach (RewardPool rewardPool in References.PlayerData.classData.rewardPools)
      {
        foreach (DataFile dataFile in rewardPool.list)
        {
          if (dataFile is CardData cardData && this.ofType.Contains<CardType>(cardData.cardType))
            list.Add(cardData);
        }
      }
    }
    else
      list.AddRange((IEnumerable<CardData>) this.pool);
  }
}
