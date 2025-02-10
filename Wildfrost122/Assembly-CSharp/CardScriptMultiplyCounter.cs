// Decompiled with JetBrains decompiler
// Type: CardScriptMultiplyCounter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Multiply Counter", menuName = "Card Scripts/Multiply Counter")]
public class CardScriptMultiplyCounter : CardScript
{
  [SerializeField]
  private float multiply;
  [SerializeField]
  private bool roundUp;

  public override void Run(CardData target)
  {
    target.counter = this.roundUp ? Mathf.CeilToInt((float) target.counter * this.multiply) : Mathf.RoundToInt((float) target.counter * this.multiply);
    target.counter = Mathf.Max(1, target.counter);
  }
}
