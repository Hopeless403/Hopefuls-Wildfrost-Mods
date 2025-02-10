// Decompiled with JetBrains decompiler
// Type: CardScriptAddRandomDamage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Add Random Damage", menuName = "Card Scripts/Add Damage")]
public class CardScriptAddRandomDamage : CardScript
{
  [SerializeField]
  private Vector2Int damageRange;

  public override void Run(CardData target)
  {
    if (!target.hasAttack)
      return;
    target.damage += this.damageRange.Random();
    target.damage = Mathf.Max(0, target.damage);
  }
}
