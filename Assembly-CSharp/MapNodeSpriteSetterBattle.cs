// Decompiled with JetBrains decompiler
// Type: MapNodeSpriteSetterBattle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Localization.Components;

public class MapNodeSpriteSetterBattle : MapNodeSpriteSetter
{
  [SerializeField]
  private SpriteRenderer @base;
  [SerializeField]
  private SpriteRenderer icon;
  [SerializeField]
  private LocalizeStringEvent battleNameString;
  [SerializeField]
  private GameObject iconObj;
  [SerializeField]
  private GameObject flagObj;

  public override void Set(MapNode mapNode)
  {
    if ((bool) (Object) this.@base)
      this.@base.sprite = References.Areas[mapNode.campaignNode.areaIndex].battleBaseSprite;
    object obj;
    if (mapNode.campaignNode.type is CampaignNodeTypeBattle && mapNode.campaignNode.data.TryGetValue("battle", out obj) && obj is string assetName)
    {
      BattleData battleData = AddressableLoader.Get<BattleData>("BattleData", assetName);
      if (battleData != null)
      {
        this.icon.sprite = battleData.sprite;
        if ((bool) (Object) this.battleNameString)
          this.battleNameString.StringReference = battleData.nameRef;
      }
    }
    if (!mapNode.campaignNode.cleared || !(bool) (Object) this.flagObj)
      return;
    this.flagObj.SetActive(true);
    this.iconObj.SetActive(false);
  }
}
