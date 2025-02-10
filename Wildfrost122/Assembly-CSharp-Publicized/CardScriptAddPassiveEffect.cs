// Decompiled with JetBrains decompiler
// Type: CardScriptAddPassiveEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Add Passive Effect", menuName = "Card Scripts/Add Passive Effect")]
public class CardScriptAddPassiveEffect : CardScript
{
  [SerializeField]
  public StatusEffectData effect;
  [SerializeField]
  public Vector2Int countRange;

  public override void Run(CardData target)
  {
    target.startWithEffects = target.startWithEffects.With<CardData.StatusEffectStacks>(new CardData.StatusEffectStacks(this.effect, this.countRange.Random()));
  }
}
