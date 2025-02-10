// Decompiled with JetBrains decompiler
// Type: FinalBossCardModifier
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

[CreateAssetMenu(menuName = "Campaign/Final Boss Card Modifier", fileName = "Final Boss Card Modifier")]
public class FinalBossCardModifier : ScriptableObject
{
  public CardData card;
  public CardScript[] runAll;

  public void Run(CardData card)
  {
    foreach (CardScript cardScript in this.runAll)
    {
      Debug.Log((object) ("Running [" + cardScript.name + "] on " + card.name));
      cardScript.Run(card);
    }
  }
}
