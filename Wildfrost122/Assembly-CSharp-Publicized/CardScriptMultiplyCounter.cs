// Decompiled with JetBrains decompiler
// Type: CardScriptMultiplyCounter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Multiply Counter", menuName = "Card Scripts/Multiply Counter")]
public class CardScriptMultiplyCounter : CardScript
{
  [SerializeField]
  public float multiply;
  [SerializeField]
  public bool roundUp;

  public override void Run(CardData target)
  {
    target.counter = this.roundUp ? Mathf.CeilToInt((float) target.counter * this.multiply) : Mathf.RoundToInt((float) target.counter * this.multiply);
    target.counter = Mathf.Max(1, target.counter);
  }
}
