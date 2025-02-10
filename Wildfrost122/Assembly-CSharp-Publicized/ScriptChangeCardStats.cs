// Decompiled with JetBrains decompiler
// Type: ScriptChangeCardStats
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
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
