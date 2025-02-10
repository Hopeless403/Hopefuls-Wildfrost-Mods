// Decompiled with JetBrains decompiler
// Type: CardScriptAddRandomDamage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

[CreateAssetMenu(fileName = "Add Random Damage", menuName = "Card Scripts/Add Damage")]
public class CardScriptAddRandomDamage : CardScript
{
  [SerializeField]
  public Vector2Int damageRange;

  public override void Run(CardData target)
  {
    if (!target.hasAttack)
      return;
    target.damage += this.damageRange.Random();
    target.damage = Mathf.Max(0, target.damage);
  }
}
