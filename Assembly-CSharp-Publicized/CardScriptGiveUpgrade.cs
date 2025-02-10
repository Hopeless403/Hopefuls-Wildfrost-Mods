// Decompiled with JetBrains decompiler
// Type: CardScriptGiveUpgrade
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

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
