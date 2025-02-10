// Decompiled with JetBrains decompiler
// Type: SpecialEventsSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SpecialEventsSystem : MonoBehaviour
{
  [SerializeField]
  public SpecialEventsSystem.Event[] events;

  public void OnEnable() => global::Events.OnPreCampaignPopulate += new UnityAction(this.PreCampaignPopulate);

  public void OnDisable() => global::Events.OnPreCampaignPopulate -= new UnityAction(this.PreCampaignPopulate);

  public void PreCampaignPopulate()
  {
    List<List<CampaignNode>> listOfNodes = SpecialEventsSystem.CreateListOfNodes();
    foreach (SpecialEventsSystem.Event specialEvent in this.events)
      SpecialEventsSystem.InsertSpecialEvent(listOfNodes, specialEvent);
  }

  public static void InsertSpecialEvent(
    List<List<CampaignNode>> tiers,
    SpecialEventsSystem.Event specialEvent)
  {
    if ((bool) (UnityEngine.Object) specialEvent.requiresUnlock && Campaign.Data.GameMode.mainGameMode && !MetaprogressionSystem.IsUnlocked(specialEvent.requiresUnlock))
      return;
    int num1 = specialEvent.perRun.Random();
    int num2 = 0;
    int[] numArray = new int[tiers.Count];
    do
    {
      foreach (List<CampaignNode> campaignNodeList in (IEnumerable<List<CampaignNode>>) tiers.InRandomOrder<List<CampaignNode>>())
      {
        int num3 = specialEvent.perTier.Random();
        if (num3 > 0)
        {
          foreach (CampaignNode campaignNode in campaignNodeList)
          {
            if (campaignNode.tier >= specialEvent.minTier)
            {
              if (numArray[campaignNode.tier] < specialEvent.perTier.y)
              {
                if (specialEvent.replaceNodeTypes.Contains<string>(campaignNode.type.name))
                {
                  Debug.Log((object) string.Format("SpecialEventSystem → Replacing [{0} ({1}) tier {2}] with ({3})", (object) campaignNode, (object) campaignNode.type.name, (object) campaignNode.tier, (object) specialEvent.nodeType.name));
                  campaignNode.SetType(specialEvent.nodeType);
                  ++numArray[campaignNode.tier];
                  ++num2;
                  if (numArray[campaignNode.tier] < num3)
                  {
                    if (num2 >= num1)
                      break;
                  }
                  else
                    break;
                }
              }
              else
                break;
            }
            else
              break;
          }
        }
        if (num2 >= num1)
          break;
      }
    }
    while (num2 < specialEvent.perRun.x);
  }

  public static List<List<CampaignNode>> CreateListOfNodes()
  {
    List<List<CampaignNode>> listOfNodes = new List<List<CampaignNode>>();
    int a = 0;
    foreach (CampaignNode node in Campaign.instance.nodes)
    {
      if (node.tier >= 0)
      {
        a = Mathf.Max(a, node.tier + 1);
        while (listOfNodes.Count <= node.tier)
          listOfNodes.Add(new List<CampaignNode>());
        int index = UnityEngine.Random.Range(0, listOfNodes[node.tier].Count - 1);
        listOfNodes[node.tier].Insert(index, node);
      }
    }
    return listOfNodes;
  }

  [Serializable]
  public struct Event
  {
    public CampaignNodeType nodeType;
    public UnlockData requiresUnlock;
    public string[] replaceNodeTypes;
    public int minTier;
    public Vector2Int perTier;
    public Vector2Int perRun;
  }
}
