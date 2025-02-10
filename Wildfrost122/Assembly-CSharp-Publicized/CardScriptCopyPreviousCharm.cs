// Decompiled with JetBrains decompiler
// Type: CardScriptCopyPreviousCharm
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Copy Previous Charm", menuName = "Card Scripts/Copy Previous Charm")]
public class CardScriptCopyPreviousCharm : CardScript
{
  [SerializeField]
  public string[] illegal;

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

  [CompilerGenerated]
  public bool \u003CRun\u003Eb__1_0(CardUpgradeData a)
  {
    return a.type == CardUpgradeData.Type.Charm && !this.illegal.Contains<string>(a.name);
  }
}
