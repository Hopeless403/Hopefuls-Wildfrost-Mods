// Decompiled with JetBrains decompiler
// Type: CardScriptAddTrait
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Add Trait", menuName = "Card Scripts/Add Trait")]
public class CardScriptAddTrait : CardScript
{
  [SerializeField]
  public TraitData trait;
  [SerializeField]
  public Vector2Int countRange;
  [SerializeField]
  public bool @override = true;

  public override void Run(CardData target)
  {
    if (this.countRange.Random() <= 0)
      return;
    for (int index = target.traits.Count - 1; index >= 0; --index)
    {
      CardData.TraitStacks trait = target.traits[index];
      if (this.trait.overrides.Contains<TraitData>(trait.data))
      {
        if (this.@override)
        {
          target.traits.RemoveAt(index);
          Debug.Log((object) ("[" + this.trait.name + "] overrides [" + trait.data.name + "]"));
        }
        else
        {
          Debug.Log((object) ("Cannot add [" + this.trait.name + "] because of [" + trait.data.name + "]"));
          return;
        }
      }
    }
    target.traits.Add(new CardData.TraitStacks()
    {
      data = this.trait,
      count = this.countRange.Random()
    });
  }
}
