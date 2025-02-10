// Decompiled with JetBrains decompiler
// Type: CardScriptMultiplyPassiveEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Multiply Passive Effect", menuName = "Card Scripts/Multiply Passive Effect")]
public class CardScriptMultiplyPassiveEffect : CardScript
{
  [SerializeField]
  private StatusEffectData effect;
  [SerializeField]
  private float multiply = 1f;

  public override void Run(CardData target)
  {
    foreach (CardData.StatusEffectStacks startWithEffect in target.startWithEffects)
    {
      if (startWithEffect.data.name == this.effect.name)
        startWithEffect.count = Mathf.RoundToInt((float) startWithEffect.count * this.multiply);
    }
  }
}
