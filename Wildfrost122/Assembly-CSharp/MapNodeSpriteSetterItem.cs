// Decompiled with JetBrains decompiler
// Type: MapNodeSpriteSetterItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
public class MapNodeSpriteSetterItem : MapNodeSpriteSetter
{
  [SerializeField]
  private Sprite normalSprite;
  [SerializeField]
  private Sprite bigSprite;
  [SerializeField]
  private Sprite clearedSprite;

  public override void Set(MapNode mapNode)
  {
    if (mapNode.campaignNode.cleared)
    {
      mapNode.SetSprite(this.clearedSprite);
    }
    else
    {
      object obj;
      if (mapNode.campaignNode.data.TryGetValue("cards", out obj) && obj is SaveCollection<string> saveCollection && saveCollection.Count > 3)
        mapNode.SetSprite(this.bigSprite);
      else
        mapNode.SetSprite(this.normalSprite);
    }
  }
}
