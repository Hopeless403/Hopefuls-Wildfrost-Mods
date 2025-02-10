// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.CampaignNodeTypeBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
namespace Deadpan.Enums.Engine.Components.Modding
{
  public class CampaignNodeTypeBuilder : DataFileBuilder<CampaignNodeType, CampaignNodeTypeBuilder>
  {
    public CampaignNodeTypeBuilder(WildfrostMod mod)
      : base(mod)
    {
    }

    public CampaignNodeTypeBuilder()
    {
    }

    public CampaignNodeTypeBuilder WithLetter(string letter)
    {
      this._data.letter = letter;
      return this;
    }

    public CampaignNodeTypeBuilder WithZoneName(string zoneName)
    {
      this._data.zoneName = zoneName;
      return this;
    }

    public CampaignNodeTypeBuilder WithMustClear(bool mustClear)
    {
      this._data.mustClear = mustClear;
      return this;
    }

    public CampaignNodeTypeBuilder WithCanSkip(bool canSkip)
    {
      this._data.canSkip = canSkip;
      return this;
    }

    public CampaignNodeTypeBuilder WithCanEnter(bool canEnter)
    {
      this._data.canEnter = canEnter;
      return this;
    }

    public CampaignNodeTypeBuilder WithIsBattle(bool isBattle)
    {
      this._data.isBattle = isBattle;
      return this;
    }

    public CampaignNodeTypeBuilder WithIsBoss(bool isBoss)
    {
      this._data.isBoss = isBoss;
      return this;
    }

    public CampaignNodeTypeBuilder WithModifierReward(bool modifierReward)
    {
      this._data.modifierReward = modifierReward;
      return this;
    }

    public CampaignNodeTypeBuilder WithInteractable(bool interactable)
    {
      this._data.interactable = interactable;
      return this;
    }

    public CampaignNodeTypeBuilder WithStartRevealed(bool startRevealed)
    {
      this._data.startRevealed = startRevealed;
      return this;
    }

    public CampaignNodeTypeBuilder WithFinalNode(bool finalNode)
    {
      this._data.finalNode = finalNode;
      return this;
    }

    public CampaignNodeTypeBuilder WithMapNodePrefab(MapNode mapNodePrefab)
    {
      this._data.mapNodePrefab = mapNodePrefab;
      return this;
    }

    public CampaignNodeTypeBuilder WithMapNodeSprite(Sprite mapNodeSprite)
    {
      this._data.mapNodeSprite = mapNodeSprite;
      return this;
    }

    public CampaignNodeTypeBuilder WithMapNodeSprite(string mapNodeSprite)
    {
      this._data.mapNodeSprite = this.Mod.GetImageSprite(mapNodeSprite);
      return this;
    }

    public CampaignNodeTypeBuilder WithSize(float size = 1f)
    {
      this._data.size = size;
      return this;
    }

    public CampaignNodeTypeBuilder WithCanLink(bool canLink)
    {
      this._data.canLink = canLink;
      return this;
    }
  }
}
