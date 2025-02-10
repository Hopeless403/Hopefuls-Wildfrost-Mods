// Decompiled with JetBrains decompiler
// Type: CardScriptSwapTraits
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
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
