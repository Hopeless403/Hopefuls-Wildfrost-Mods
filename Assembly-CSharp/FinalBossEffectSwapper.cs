// Decompiled with JetBrains decompiler
// Type: FinalBossEffectSwapper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Campaign/Final Boss Effect Swapper", fileName = "Final Boss Effect Swapper")]
public class FinalBossEffectSwapper : ScriptableObject
{
  public StatusEffectData effect;
  public bool remove = true;
  [ShowIf("remove")]
  public StatusEffectData[] replaceWithOptions;
  [ShowIf("remove")]
  public StatusEffectData replaceWithAttackEffect;
  public Vector2Int boostRange;

  public void Process(CardData card, CardData.StatusEffectStacks stack, int stackIndex)
  {
    if (this.remove)
    {
      List<CardData.StatusEffectStacks> list = card.startWithEffects.ToList<CardData.StatusEffectStacks>();
      if (this.replaceWithOptions.Length != 0)
        stack.data = this.replaceWithOptions.RandomItem<StatusEffectData>();
      else
        list.RemoveAt(stackIndex);
      if ((bool) (Object) this.replaceWithAttackEffect)
      {
        CardData.StatusEffectStacks statusEffectStacks = new CardData.StatusEffectStacks(this.replaceWithAttackEffect, stack.count + this.boostRange.Random());
        card.attackEffects = CardData.StatusEffectStacks.Stack((IEnumerable<CardData.StatusEffectStacks>) card.attackEffects, (IEnumerable<CardData.StatusEffectStacks>) new CardData.StatusEffectStacks[1]
        {
          statusEffectStacks
        });
      }
      card.startWithEffects = list.ToArray();
    }
    stack.count += this.boostRange.Random();
  }
}
