// Decompiled with JetBrains decompiler
// Type: ScriptChangeCardStats
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Change Card Stats", menuName = "Scripts/Change Card Stats")]
public class ScriptChangeCardStats : Script
{
  [SerializeField]
  private int cardIndex;
  [SerializeField]
  private CardScript[] scriptPool;
  [SerializeField]
  private Vector2Int countRange;

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
