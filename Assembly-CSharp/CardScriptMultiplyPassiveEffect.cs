// Decompiled with JetBrains decompiler
// Type: CardScriptMultiplyPassiveEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

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
