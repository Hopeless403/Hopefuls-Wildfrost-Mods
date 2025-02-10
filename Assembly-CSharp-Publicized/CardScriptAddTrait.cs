// Decompiled with JetBrains decompiler
// Type: CardScriptAddTrait
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

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
