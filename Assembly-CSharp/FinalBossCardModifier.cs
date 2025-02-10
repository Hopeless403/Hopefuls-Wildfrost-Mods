// Decompiled with JetBrains decompiler
// Type: FinalBossCardModifier
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

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
