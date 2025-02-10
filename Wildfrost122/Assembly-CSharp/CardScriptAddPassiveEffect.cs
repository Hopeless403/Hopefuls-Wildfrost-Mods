// Decompiled with JetBrains decompiler
// Type: CardScriptAddPassiveEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Add Passive Effect", menuName = "Card Scripts/Add Passive Effect")]
public class CardScriptAddPassiveEffect : CardScript
{
  [SerializeField]
  private StatusEffectData effect;
  [SerializeField]
  private Vector2Int countRange;

  public override void Run(CardData target)
  {
    target.startWithEffects = target.startWithEffects.With<CardData.StatusEffectStacks>(new CardData.StatusEffectStacks(this.effect, this.countRange.Random()));
  }
}
