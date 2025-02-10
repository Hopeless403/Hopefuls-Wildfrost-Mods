// Decompiled with JetBrains decompiler
// Type: CardScriptAddAttackEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Add Attack Effect", menuName = "Card Scripts/Add Attack Effect")]
public class CardScriptAddAttackEffect : CardScript
{
  [SerializeField]
  public StatusEffectData effect;
  [SerializeField]
  public Vector2Int countRange;

  public override void Run(CardData target)
  {
    target.attackEffects = target.attackEffects.With<CardData.StatusEffectStacks>(new CardData.StatusEffectStacks(this.effect, this.countRange.Random()));
  }
}
