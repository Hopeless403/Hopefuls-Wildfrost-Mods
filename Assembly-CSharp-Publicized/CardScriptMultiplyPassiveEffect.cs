// Decompiled with JetBrains decompiler
// Type: CardScriptMultiplyPassiveEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

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
