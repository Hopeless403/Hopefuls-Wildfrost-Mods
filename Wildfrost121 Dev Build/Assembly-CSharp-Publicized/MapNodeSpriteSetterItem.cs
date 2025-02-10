// Decompiled with JetBrains decompiler
// Type: MapNodeSpriteSetterItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public class MapNodeSpriteSetterItem : MapNodeSpriteSetter
{
  [SerializeField]
  public Sprite normalSprite;
  [SerializeField]
  public Sprite bigSprite;
  [SerializeField]
  public Sprite clearedSprite;

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
