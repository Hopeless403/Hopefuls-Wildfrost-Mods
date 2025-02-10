// Decompiled with JetBrains decompiler
// Type: CardScriptGiveUpgrade
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Give Upgrade", menuName = "Card Scripts/Give Upgrade")]
public class CardScriptGiveUpgrade : CardScript
{
  [SerializeField]
  private CardUpgradeData upgradeData;

  public override void Run(CardData target)
  {
    if (!((Object) this.upgradeData != (Object) null))
      return;
    this.upgradeData.Clone().Assign(target);
  }
}
