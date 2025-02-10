// Decompiled with JetBrains decompiler
// Type: CardScriptRoundHealth
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Round Health", menuName = "Card Scripts/Round Health")]
public class CardScriptRoundHealth : CardScript
{
  [SerializeField]
  [HideIf("floor")]
  private bool ceil = true;
  [SerializeField]
  [HideIf("ceil")]
  private bool floor;
  [SerializeField]
  private int round = 10;

  public override void Run(CardData target)
  {
    float f = (float) target.hp / (float) this.round;
    target.hp = !this.ceil ? (!this.floor ? Mathf.RoundToInt(f) * this.round : Mathf.FloorToInt(f) * this.round) : Mathf.CeilToInt(f) * this.round;
    target.hp = Mathf.Max(1, target.hp);
  }
}
