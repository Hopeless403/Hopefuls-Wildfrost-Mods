// Decompiled with JetBrains decompiler
// Type: CardScriptAddAttackEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

[CreateAssetMenu(fileName = "Add Attack Effect", menuName = "Card Scripts/Add Attack Effect")]
public class CardScriptAddAttackEffect : CardScript
{
  [SerializeField]
  private StatusEffectData effect;
  [SerializeField]
  private Vector2Int countRange;

  public override void Run(CardData target) => target.attackEffects = target.attackEffects.With<CardData.StatusEffectStacks>(new CardData.StatusEffectStacks(this.effect, this.countRange.Random()));
}
