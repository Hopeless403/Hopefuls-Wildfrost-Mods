// Decompiled with JetBrains decompiler
// Type: BlockForMinibossesModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class BlockForMinibossesModifierSystem : GameSystem
{
  public const float healthFactor = 0.75f;
  public const float blockPerHealthLost = 0.25f;
  public static StatusEffectData _effect;

  public static StatusEffectData effect
  {
    get
    {
      return BlockForMinibossesModifierSystem._effect ?? (BlockForMinibossesModifierSystem._effect = AddressableLoader.Get<StatusEffectData>("StatusEffectData", "Block"));
    }
  }

  public void OnEnable()
  {
    global::Events.OnCardDataCreated += new UnityAction<CardData>(BlockForMinibossesModifierSystem.CardDataCreated);
  }

  public void OnDisable()
  {
    global::Events.OnCardDataCreated -= new UnityAction<CardData>(BlockForMinibossesModifierSystem.CardDataCreated);
  }

  public static void CardDataCreated(CardData cardData)
  {
    if (!(cardData.cardType.name == "Miniboss") || !cardData.hasHealth)
      return;
    int hp1 = cardData.hp;
    cardData.hp = Mathf.CeilToInt((float) cardData.hp * 0.75f);
    int hp2 = cardData.hp;
    int count = Mathf.Max(1, Mathf.CeilToInt((float) (hp1 - hp2) * 0.25f));
    cardData.startWithEffects = CardData.StatusEffectStacks.Stack((IEnumerable<CardData.StatusEffectStacks>) cardData.startWithEffects, (IEnumerable<CardData.StatusEffectStacks>) new CardData.StatusEffectStacks[1]
    {
      new CardData.StatusEffectStacks(BlockForMinibossesModifierSystem.effect, count)
    });
  }
}
