// Decompiled with JetBrains decompiler
// Type: CardScriptBoostAttackEffectsOrAttack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Boost Attack Effects Or Damage", menuName = "Card Scripts/Boost Attack Effects Or Damage")]
public class CardScriptBoostAttackEffectsOrAttack : CardScript
{
  [SerializeField]
  public Vector2Int range = new Vector2Int(2, 2);
  [SerializeField]
  public float reducePerCharm = 0.5f;

  public override void Run(CardData target)
  {
    int f1 = this.range.Random();
    List<CardUpgradeData> upgrades = target.upgrades;
    if (upgrades != null && upgrades.Count > 0)
    {
      float f2 = (float) f1;
      foreach (CardUpgradeData upgrade in target.upgrades)
      {
        if (upgrade.type == CardUpgradeData.Type.Charm)
        {
          f2 -= this.reducePerCharm;
          if ((double) f2 <= 0.0)
            break;
        }
      }
      f1 = Mathf.CeilToInt(f2);
    }
    if (f1 <= 0)
      return;
    int num = (int) Mathf.Sign((float) f1);
    if (target.attackEffects.Length != 0)
    {
      while (f1 > 0)
      {
        foreach (CardData.StatusEffectStacks attackEffect in target.attackEffects)
        {
          attackEffect.count = Mathf.Max(1, attackEffect.count + num);
          if (--f1 <= 0)
            break;
        }
      }
    }
    else
    {
      if (!target.hasAttack)
        return;
      target.damage += f1;
      target.damage = Mathf.Max(0, target.damage);
    }
  }
}
