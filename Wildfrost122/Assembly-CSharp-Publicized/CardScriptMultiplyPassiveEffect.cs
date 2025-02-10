// Decompiled with JetBrains decompiler
// Type: CardScriptMultiplyPassiveEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
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
