// Decompiled with JetBrains decompiler
// Type: CardScriptSwapTraits
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Swap Traits", menuName = "Card Scripts/Swap Traits")]
public class CardScriptSwapTraits : CardScript
{
  [SerializeField]
  public TraitData traitA;
  [SerializeField]
  public TraitData traitB;

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
