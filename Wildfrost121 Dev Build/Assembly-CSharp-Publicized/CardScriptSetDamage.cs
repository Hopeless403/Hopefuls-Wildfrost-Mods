// Decompiled with JetBrains decompiler
// Type: CardScriptSetDamage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Set Damage", menuName = "Card Scripts/Set Damage")]
public class CardScriptSetDamage : CardScript
{
  [SerializeField]
  public Vector2Int damageRange;

  public override void Run(CardData target)
  {
    if (!target.hasAttack)
      return;
    target.damage = this.damageRange.Random();
    target.damage = Mathf.Max(0, target.damage);
  }
}
