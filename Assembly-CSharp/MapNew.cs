// Decompiled with JetBrains decompiler
// Type: MapNew
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MapNew : MonoBehaviour
{
  [SerializeField]
  private Transform positioner;
  [SerializeField]
  private Transform nodesGroup;
  [SerializeField]
  private MapPath pathPrefab;
  [SerializeField]
  private MapStamp stamp;
  private static Vector3 prePosition = Vector3.zero;
  private readonly List<MapNode> nodes = new List<MapNode>();
  private readonly List<MapPath> paths = new List<MapPath>();
  [SerializeField]
  private Sprite[] detailSprites;
  private bool active = true;
  private MapPath[] fadedPaths;
  private MapNode hoverNode;
  private MapNode[] fadedNodes;
  private bool interactable = true;

  private void OnEnable()
  {
    global::Events.OnMapNodeHover += new UnityAction<MapNode>(this.HoverNode);
    global::Events.OnMapNodeUnHover += new UnityAction<MapNode>(this.UnHoverNode);
  }

  private void OnDisable()
  {
    global::Events.OnMapNodeHover -= new UnityAction<MapNode>(this.HoverNode);
    global::Events.OnMapNodeUnHover -= new UnityAction<MapNode>(this.UnHoverNode);
  }

  public IEnumerator Start()
  {
    MapNew mapNew = this;
    yield return (object) new WaitUntil((Func<bool>) (() => !Transition.Running));
    References.Map = mapNew;
    mapNew.nodesGroup.DestroyAllChildren();
    mapNew.nodes.Clear();
    mapNew.paths.Clear();
    foreach (CampaignNode node in Campaign.instance.nodes)
      mapNew.CreateNode(node);
    foreach (MapNode node1 in mapNew.nodes)
    {
      List<MapNode> mapNodeList = new List<MapNode>();
      if (node1.campaignNode.connections != null)
      {
        foreach (CampaignNode.Connection connection in node1.campaignNode.connections)
        {
          MapNode node2 = mapNew.FindNode(Campaign.GetNode(connection.otherId));
          mapNodeList.Add(node2);
          ++node2.connectedTo;
        }
      }
      node1.connections = mapNodeList.ToArray();
    }
    foreach (MapNode node in mapNew.nodes)
    {
      if (!node.campaignNode.revealed)
        node.gameObject.SetActive(false);
    }
    mapNew.CreatePaths();
    mapNew.positioner.localPosition = MapNew.prePosition;
    yield return (object) Sequences.Wait(0.5f);
    mapNew.Continue();
  }

  private IEnumerator Restart()
  {
    yield return (object) SceneManager.Unload("Campaign");
    Routine routine = new Routine(Transition.To("Campaign"));
  }

  private MapNode CreateNode(CampaignNode campaignNode)
  {
    MapNode node = UnityEngine.Object.Instantiate<MapNode>(campaignNode.type.mapNodePrefab, this.nodesGroup);
    node.transform.localPosition = campaignNode.position.WithZ(0.0f);
    node.Assign(campaignNode);
    this.nodes.Add(node);
    node.map = this;
    node.name = string.Format("MapNode{0}", (object) this.nodes.Count);
    return node;
  }

  public MapNode FindNode(CampaignNode campaignNode) => this.nodes.Find((Predicate<MapNode>) (a => a.campaignNode == campaignNode));

  private List<MapPath> FindPaths(MapNode fromNode) => this.paths.FindAll((Predicate<MapPath>) (a => (UnityEngine.Object) a.StartNode == (UnityEngine.Object) fromNode));

  private void CreatePaths()
  {
    MapNode mapNode1 = (MapNode) null;
    foreach (MapNode node in this.nodes)
    {
      if (node.connections.Length != 0)
      {
        mapNode1 = node;
        break;
      }
    }
    List<MapNode> mapNodeList1 = new List<MapNode>();
    while ((UnityEngine.Object) mapNode1 != (UnityEngine.Object) null)
    {
      if (mapNode1.connections.Length == 1)
      {
        this.CreatePath(mapNode1, mapNode1.connections[0]);
        mapNode1 = mapNode1.connections[0];
      }
      else if (mapNode1.connections.Length > 1)
      {
        MapNode mapNode2 = (MapNode) null;
        foreach (MapNode connection in mapNode1.connections)
        {
          List<MapNode> mapNodeList2 = new List<MapNode>()
          {
            mapNode1,
            connection
          };
          MapNode mapNode3 = connection;
          while ((UnityEngine.Object) mapNode3 != (UnityEngine.Object) null)
          {
            if (mapNode3.connectedTo == 1 && mapNode3.connections.Length != 0)
            {
              mapNodeList2.Add(mapNode3.connections[0]);
              mapNode3 = mapNode3.connections[0];
            }
            else
            {
              mapNode2 = mapNode3;
              mapNode3 = (MapNode) null;
            }
          }
          this.CreatePath(mapNodeList2.ToArray());
        }
        if ((UnityEngine.Object) mapNode2 != (UnityEngine.Object) null)
          mapNode1 = mapNode2;
      }
      else
        mapNode1 = (MapNode) null;
    }
  }

  private MapPath CreatePath(params MapNode[] nodes)
  {
    MapPath path = UnityEngine.Object.Instantiate<MapPath>(this.pathPrefab, this.nodesGroup);
    foreach (MapNode node in nodes)
      path.Add(node);
    path.Setup();
    this.paths.Add(path);
    return path;
  }

  private IEnumerator Reveal()
  {
    MapNode currentNode = this.FindNode(Campaign.FindCharacterNode(References.Player));
    yield return (object) Sequences.Wait(0.5f);
    yield return (object) this.Reveal(currentNode);
  }

  private IEnumerator Reveal(MapNode fromNode)
  {
    if (!fromNode.campaignNode.type.isBattle || fromNode.campaignNode.cleared)
    {
      fromNode.Reveal();
      List<MapNode> endNodes = new List<MapNode>();
      foreach (MapPath path in this.FindPaths(fromNode))
      {
        yield return (object) path.Reveal();
        MapNode endNode = path.EndNode;
        if (!endNodes.Contains(endNode))
          endNodes.Add(endNode);
      }
      foreach (MapNode fromNode1 in endNodes)
      {
        if (!fromNode1.campaignNode.type.isBattle)
          yield return (object) this.Reveal(fromNode1);
      }
    }
  }

  private void UpdateInteractability(bool forceCanSkip = false)
  {
    MapNode node1 = this.FindNode(Campaign.FindCharacterNode(References.Player));
    List<MapNode> allConnections = this.GetAllConnections(node1, forceCanSkip);
    foreach (MapNode node2 in this.nodes)
    {
      bool flag1 = allConnections.Contains(node2);
      node2.reachable = flag1 || node2.campaignNode.cleared;
      node2.hoverable = this.interactable & flag1;
      bool flag2 = node1.connections.Contains<MapNode>(node2);
      bool flag3 = node1.campaignNode.cleared || !node1.campaignNode.type.mustClear;
      node2.SetSelectable(this.interactable & flag2 & flag3);
    }
    node1.SetSelectable(this.interactable && node1.interactable && !node1.campaignNode.cleared);
    foreach (MapPath path in this.paths)
    {
      if (path.gameObject.activeSelf)
        path.CheckReachable();
    }
  }

  private void Focus()
  {
    MapNode[] array = this.GetAllConnections(this.FindNode(Campaign.FindCharacterNode(References.Player))).ToArray();
    if (array.Length == 0)
      return;
    this.FocusOn(array);
  }

  private void FocusOn(params MapNode[] nodes)
  {
    Vector3 zero = Vector3.zero;
    foreach (MapNode node in nodes)
      zero += node.transform.localPosition;
    Vector3 to = -(zero / (float) nodes.Length);
    LeanTween.moveLocal(this.positioner.gameObject, to, 0.5f).setEase(LeanTweenType.easeInOutQuad);
    MapNew.prePosition = to;
  }

  private List<MapNode> GetAllConnections(MapNode startNode, bool forceCanSkip = false)
  {
    List<MapNode> allConnections = new List<MapNode>();
    List<MapNode> mapNodeList = new List<MapNode>()
    {
      startNode
    };
    while (mapNodeList.Count > 0)
    {
      MapNode mapNode = mapNodeList[0];
      mapNodeList.RemoveAt(0);
      if (!allConnections.Contains(mapNode))
        allConnections.Add(mapNode);
      if (mapNode.campaignNode.cleared | forceCanSkip || mapNode.campaignNode.type.canSkip)
      {
        foreach (MapNode connection in mapNode.connections)
        {
          if (!mapNodeList.Contains(connection))
            mapNodeList.Add(connection);
        }
      }
    }
    return allConnections;
  }

  public bool TryMoveTo(MapNode node)
  {
    Character player = References.Player;
    CampaignNode characterNode = Campaign.FindCharacterNode(player);
    if (characterNode != node.campaignNode && !characterNode.connections.Exists((Predicate<CampaignNode.Connection>) (a => a.otherId == node.campaignNode.id)))
      return false;
    if (!node.campaignNode.type.isBattle || player.GetCompanionCount() <= player.data.companionLimit)
    {
      MapNew.MoveTo(player, node);
      this.Enter(player, node);
      return true;
    }
    if (player.entity.display is CharacterDisplay display)
      display.deckDisplay.companionLimitSequence.Begin();
    return false;
  }

  public static void MoveTo(Character character, MapNode node) => Campaign.MoveCharacter(character, node.campaignNode);

  public void Enter(Character character, MapNode node)
  {
    this.interactable = false;
    this.UpdateInteractability();
    this.stamp.Stamp(node.transform.position);
    Campaign.TryEnterNode(node.campaignNode);
  }

  public static IEnumerator CheckCompanionLimit()
  {
    Character player = References.Player;
    CharacterDisplay playerDisplay = player.entity.display as CharacterDisplay;
    if (playerDisplay != null && player.GetCompanionCount() > player.data.companionLimit)
    {
      playerDisplay.deckDisplay.companionLimitSequence.Begin();
      yield return (object) new WaitUntil((Func<bool>) (() => !playerDisplay.deckDisplay.companionLimitSequence.IsRunning));
    }
  }

  [Button(null, EButtonEnableMode.Always)]
  public void Continue(bool forceCanSkip = false)
  {
    this.interactable = true;
    foreach (MapNode node in this.nodes)
      node.Refresh();
    this.StartCoroutine(this.Reveal(this.FindNode(Campaign.FindCharacterNode(References.Player))));
    this.UpdateInteractability(forceCanSkip);
    this.Focus();
    this.stamp.FadeOut();
  }

  private void HoverNode(MapNode node)
  {
    if ((UnityEngine.Object) this.hoverNode != (UnityEngine.Object) null)
      this.UnHoverNode(this.hoverNode);
    MapNode node1 = this.FindNode(Campaign.FindCharacterNode(References.Player));
    if (node1.connections.Length <= 1 || !((UnityEngine.Object) node != (UnityEngine.Object) node1) || node.connectedTo != 1)
      return;
    List<MapPath> paths = this.FindPaths(node1);
    MapPath mapPath1 = (MapPath) null;
    List<MapPath> mapPathList = new List<MapPath>();
    foreach (MapPath mapPath2 in paths)
    {
      if (mapPath2.ContainsNode(node))
        mapPath1 = mapPath2;
      else
        mapPathList.Add(mapPath2);
    }
    if (!((UnityEngine.Object) mapPath1 != (UnityEngine.Object) null))
      return;
    this.hoverNode = node;
    foreach (MapPath mapPath3 in paths)
    {
      if ((UnityEngine.Object) mapPath3 != (UnityEngine.Object) mapPath1)
        mapPath3.FadeTo(0.5f, 0.0f);
    }
    List<MapNode> allConnections = this.GetAllConnections(node);
    List<MapNode> mapNodeList = new List<MapNode>();
    foreach (MapNode node2 in this.nodes)
    {
      bool flag = allConnections.Contains(node2);
      if (!node2.campaignNode.cleared && !flag && !mapPath1.ContainsNode(node2))
      {
        mapNodeList.Add(node2);
        node2.color = new Color(1f, 1f, 1f, 0.5f);
      }
    }
    this.fadedPaths = mapPathList.ToArray();
    this.fadedNodes = mapNodeList.ToArray();
  }

  private void UnHoverNode(MapNode node)
  {
    if (!((UnityEngine.Object) this.hoverNode == (UnityEngine.Object) node))
      return;
    if (this.fadedPaths != null)
    {
      foreach (MapPath fadedPath in this.fadedPaths)
      {
        if (fadedPath.reachable)
          fadedPath.FadeTo(1f, 0.0f);
      }
      this.fadedPaths = (MapPath[]) null;
    }
    if (this.fadedNodes != null)
    {
      foreach (MapNode fadedNode in this.fadedNodes)
      {
        if (fadedNode.reachable)
          fadedNode.color = Color.white;
      }
      this.fadedNodes = (MapNode[]) null;
    }
    this.hoverNode = (MapNode) null;
  }
}
