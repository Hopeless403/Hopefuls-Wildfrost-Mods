// Decompiled with JetBrains decompiler
// Type: CardScriptGiveUpgrade
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

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
