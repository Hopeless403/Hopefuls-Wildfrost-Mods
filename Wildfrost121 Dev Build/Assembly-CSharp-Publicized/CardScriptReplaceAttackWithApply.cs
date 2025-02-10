// Decompiled with JetBrains decompiler
// Type: CardScriptReplaceAttackWithApply
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Replace Attack With Apply", menuName = "Card Scripts/Replace Attack With Apply")]
public class CardScriptReplaceAttackWithApply : CardScript
{
  [SerializeField]
  public StatusEffectData effect;

  public override void Run(CardData target)
  {
    if (!target.hasAttack || target.damage <= 0)
      return;
    CardData.StatusEffectStacks[] newEffects = new CardData.StatusEffectStacks[1]
    {
      new CardData.StatusEffectStacks(this.effect, target.damage)
    };
    target.attackEffects = CardData.StatusEffectStacks.Stack((IEnumerable<CardData.StatusEffectStacks>) target.attackEffects, (IEnumerable<CardData.StatusEffectStacks>) newEffects);
    target.damage = 0;
  }
}
