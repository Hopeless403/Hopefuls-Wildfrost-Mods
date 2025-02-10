// Decompiled with JetBrains decompiler
// Type: CardScriptRoundHealth
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using UnityEngine;

[CreateAssetMenu(fileName = "Round Health", menuName = "Card Scripts/Round Health")]
public class CardScriptRoundHealth : CardScript
{
  [SerializeField]
  [HideIf("floor")]
  public bool ceil = true;
  [SerializeField]
  [HideIf("ceil")]
  public bool floor;
  [SerializeField]
  public int round = 10;

  public override void Run(CardData target)
  {
    float f = (float) target.hp / (float) this.round;
    target.hp = !this.ceil ? (!this.floor ? Mathf.RoundToInt(f) * this.round : Mathf.FloorToInt(f) * this.round) : Mathf.CeilToInt(f) * this.round;
    target.hp = Mathf.Max(1, target.hp);
  }
}
