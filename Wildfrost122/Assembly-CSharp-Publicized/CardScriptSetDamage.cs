// Decompiled with JetBrains decompiler
// Type: CardScriptSetDamage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
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
