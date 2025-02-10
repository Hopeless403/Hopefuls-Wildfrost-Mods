// Decompiled with JetBrains decompiler
// Type: MapNodeSpriteSetterBattle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Localization.Components;

#nullable disable
public class MapNodeSpriteSetterBattle : MapNodeSpriteSetter
{
  [SerializeField]
  public SpriteRenderer @base;
  [SerializeField]
  public SpriteRenderer icon;
  [SerializeField]
  public LocalizeStringEvent battleNameString;
  [SerializeField]
  public GameObject iconObj;
  [SerializeField]
  public GameObject flagObj;

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
