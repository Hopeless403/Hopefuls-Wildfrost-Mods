// Decompiled with JetBrains decompiler
// Type: CardScriptMultiplyHealth
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Multiply Health", menuName = "Card Scripts/Multiply Health")]
public class CardScriptMultiplyHealth : CardScript
{
  [SerializeField]
  private float multiply;
  [SerializeField]
  private bool roundUp;

  public override void Run(CardData target)
  {
    target.hp = this.roundUp ? Mathf.CeilToInt((float) target.hp * this.multiply) : Mathf.RoundToInt((float) target.hp * this.multiply);
    target.hp = Mathf.Max(1, target.hp);
  }
}
