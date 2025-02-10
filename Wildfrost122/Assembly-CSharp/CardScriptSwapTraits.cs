// Decompiled with JetBrains decompiler
// Type: CardScriptSwapTraits
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Swap Traits", menuName = "Card Scripts/Swap Traits")]
public class CardScriptSwapTraits : CardScript
{
  [SerializeField]
  private TraitData traitA;
  [SerializeField]
  private TraitData traitB;

  public override void Run(CardData target)
  {
    foreach (CardData.TraitStacks trait in target.traits)
    {
      if ((Object) trait.data == (Object) this.traitA)
        trait.data = this.traitB;
      else if ((Object) trait.data == (Object) this.traitB)
        trait.data = this.traitA;
    }
  }
}
