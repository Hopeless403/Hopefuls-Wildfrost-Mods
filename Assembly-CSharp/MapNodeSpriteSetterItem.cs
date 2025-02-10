// Decompiled with JetBrains decompiler
// Type: MapNodeSpriteSetterItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

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
