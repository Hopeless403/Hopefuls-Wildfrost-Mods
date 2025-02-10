// Decompiled with JetBrains decompiler
// Type: MapNodeSpriteSetterItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
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
