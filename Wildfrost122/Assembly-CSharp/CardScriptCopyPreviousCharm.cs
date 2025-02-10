// Decompiled with JetBrains decompiler
// Type: CardScriptCopyPreviousCharm
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Copy Previous Charm", menuName = "Card Scripts/Copy Previous Charm")]
public class CardScriptCopyPreviousCharm : CardScript
{
  [SerializeField]
  private string[] illegal;

  public override void Run(CardData target)
  {
    CardUpgradeData last = target.upgrades.FindLast((Predicate<CardUpgradeData>) (a => a.type == CardUpgradeData.Type.Charm && !this.illegal.Contains<string>(a.name)));
    if (!(bool) (UnityEngine.Object) last)
      return;
    last.AdjustStats(target);
    last.RunScripts(target);
    last.AdjustEffectBonus(target);
    last.GainEffects(target);
  }
}
