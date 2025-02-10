// Decompiled with JetBrains decompiler
// Type: CardScriptAddRandomBoost
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

[CreateAssetMenu(fileName = "Add Random Boost", menuName = "Card Scripts/Add Boost")]
public class CardScriptAddRandomBoost : CardScript
{
  [SerializeField]
  private Vector2Int boostRange;

  public override void Run(CardData target)
  {
    int num = this.boostRange.Random();
    if (num == 0)
      return;
    foreach (CardData.StatusEffectStacks attackEffect in target.attackEffects)
      attackEffect.count = Mathf.Max(1, attackEffect.count + num);
    foreach (CardData.StatusEffectStacks startWithEffect in target.startWithEffects)
    {
      if (!startWithEffect.data.visible)
        startWithEffect.count = Mathf.Max(1, startWithEffect.count + num);
    }
    foreach (CardData.TraitStacks trait in target.traits)
    {
      if (trait.data.keyword.canStack)
        trait.count = Mathf.Max(1, trait.count + num);
    }
  }
}
