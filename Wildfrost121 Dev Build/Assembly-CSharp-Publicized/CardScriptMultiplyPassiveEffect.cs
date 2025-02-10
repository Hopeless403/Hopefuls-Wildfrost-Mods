// Decompiled with JetBrains decompiler
// Type: CardScriptMultiplyPassiveEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Multiply Passive Effect", menuName = "Card Scripts/Multiply Passive Effect")]
public class CardScriptMultiplyPassiveEffect : CardScript
{
  [SerializeField]
  public StatusEffectData effect;
  [SerializeField]
  public float multiply = 1f;

  public override void Run(CardData target)
  {
    foreach (CardData.StatusEffectStacks startWithEffect in target.startWithEffects)
    {
      if (startWithEffect.data.name == this.effect.name)
        startWithEffect.count = Mathf.RoundToInt((float) startWithEffect.count * this.multiply);
    }
  }
}
