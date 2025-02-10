// Decompiled with JetBrains decompiler
// Type: CampaignNodeTypeGold
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CampaignNodeTypeGold", menuName = "Campaign/Node Type/Gold")]
public class CampaignNodeTypeGold : CampaignNodeType
{
  [SerializeField]
  public Vector2Int amountRange = new Vector2Int(40, 80);
  [SerializeField]
  public float pauseAfter = 1.5f;

  public override IEnumerator SetUp(CampaignNode node)
  {
    node.data = new Dictionary<string, object>()
    {
      {
        "amount",
        (object) this.amountRange.Random()
      }
    };
    yield return (object) null;
  }

  public override IEnumerator Run(CampaignNode node)
  {
    Character player = References.Player;
    Vector3 position = Vector3.zero;
    MapNew objectOfType = Object.FindObjectOfType<MapNew>();
    if (objectOfType != null)
    {
      MapNode node1 = objectOfType.FindNode(node);
      if (node1 != null)
        position = node1.transform.position;
    }
    if ((bool) (Object) player && (bool) (Object) player.data?.inventory)
      Events.InvokeDropGold(node.data.Get<int>("amount"), "GoldCave", player, position);
    node.data["amount"] = (object) 0;
    node.SetCleared();
    yield return (object) Sequences.Wait(this.pauseAfter);
    References.Map.Continue();
  }

  public override bool HasMissingData(CampaignNode node) => false;
}
