// Decompiled with JetBrains decompiler
// Type: ScriptChangeCardStats
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
