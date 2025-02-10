// Decompiled with JetBrains decompiler
// Type: CardScriptGiveUpgrade
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Give Upgrade", menuName = "Card Scripts/Give Upgrade")]
public class CardScriptGiveUpgrade : CardScript
{
  [SerializeField]
  public CardUpgradeData upgradeData;

  public override void Run(CardData target)
  {
    if (!((Object) this.upgradeData != (Object) null))
      return;
    this.upgradeData.Clone().Assign(target);
  }
}
