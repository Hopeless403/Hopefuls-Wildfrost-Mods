// Decompiled with JetBrains decompiler
// Type: CardScriptAddRandomDamage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

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
