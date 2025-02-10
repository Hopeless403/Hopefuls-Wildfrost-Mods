// Decompiled with JetBrains decompiler
// Type: FinalBossEffectSwapper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
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
