// Decompiled with JetBrains decompiler
// Type: CardScriptGiveUpgrade
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
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
