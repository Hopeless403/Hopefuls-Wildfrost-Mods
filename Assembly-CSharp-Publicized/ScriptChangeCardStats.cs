// Decompiled with JetBrains decompiler
// Type: ScriptChangeCardStats
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Change Card Stats", menuName = "Scripts/Change Card Stats")]
public class ScriptChangeCardStats : Script
{
  [SerializeField]
  public int cardIndex;
  [SerializeField]
  public CardScript[] scriptPool;
  [SerializeField]
  public Vector2Int countRange;

  public override IEnumerator Run()
  {
    int num = this.countRange.Random();
    CardData target = References.PlayerData.inventory.deck[this.cardIndex];
    foreach (CardScript cardScript in (IEnumerable<CardScript>) ((IEnumerable<CardScript>) this.scriptPool).InRandomOrder<CardScript>())
    {
      if (num <= 0)
      {
        yield break;
      }
      else
      {
        cardScript.Run(target);
        --num;
      }
    }
  }
}
