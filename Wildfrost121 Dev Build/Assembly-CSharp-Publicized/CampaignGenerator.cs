// Decompiled with JetBrains decompiler
// Type: CampaignGenerator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "CampaignGenerator", menuName = "Campaign/Generator")]
public class CampaignGenerator : ScriptableObject
{
  [SerializeField]
  public string seed;
  [SerializeField]
  public Vector2 nodeSizeRange = new Vector2(1.8f, 2f);
  [SerializeField]
  public float nodeCreationRand = 1.5f;
  [SerializeField]
  public Vector2 nodeSpacing = new Vector2(3.2f, 2f);
  [SerializeField]
  public Vector2 battleDistanceRange = new Vector2(13f, 14f);
  [SerializeField]
  public Vector2 mapDirection = new Vector2(0.67f, 0.33f);
  [SerializeField]
  public TextAsset[] presets;
  [SerializeField]
  public bool instant = true;
  [SerializeField]
  public bool restart;
  [SerializeField]
  public bool restartOnError = true;

  public virtual IEnumerator Generate(Campaign campaign)
  {
    CampaignGenerator campaignGenerator1 = this;
    campaignGenerator1.SetSeed();
    Debug.Log((object) string.Format("[{0}] GENERATING", (object) campaignGenerator1));
    StopWatch.Start();
    campaign.nodes.Clear();
    Dictionary<string, CampaignNodeType> nodeDict = new Dictionary<string, CampaignNodeType>();
    foreach (CampaignNodeType campaignNodeType in AddressableLoader.GetGroup<CampaignNodeType>("CampaignNodeType"))
    {
      if (!campaignNodeType.letter.IsNullOrWhitespace())
        nodeDict[campaignNodeType.letter] = campaignNodeType;
    }
    List<CampaignGenerator.Node> nodes = new List<CampaignGenerator.Node>();
    int attempt = 0;
    while (true)
    {
      CampaignGenerator campaignGenerator = campaignGenerator1;
      Task<bool> task = campaignGenerator1.TryGenerate(campaign, attempt, nodes, (IReadOnlyDictionary<string, CampaignNodeType>) nodeDict);
      yield return (object) new WaitUntil((Func<bool>) (() => task.IsCompleted));
      bool error = task.Result;
      ++attempt;
      if (error)
      {
        Debug.Log((object) "Generation failed!");
        nodes.Clear();
        yield return (object) new WaitUntil((Func<bool>) (() =>
        {
          if (campaignGenerator.restart)
            return true;
          return error && campaignGenerator.restartOnError;
        }));
        campaignGenerator1.restart = false;
      }
      else
        break;
    }
    Debug.Log((object) string.Format("DONE! ({0}ms) [{1} attempts]", (object) StopWatch.Stop(), (object) attempt));
    foreach (CampaignGenerator.Node node in (IEnumerable<CampaignGenerator.Node>) nodes.OrderByDescending<CampaignGenerator.Node, bool>((Func<CampaignGenerator.Node, bool>) (a => a.interactable)))
    {
      CampaignNodeType type = nodeDict[node.type];
      node.campaignNode = new CampaignNode(type, node.x, node.y, node.tier, node.positionIndex, node.areaIndex, node.r);
      campaign.nodes.Add(node.campaignNode);
      node.campaignNode.id = campaign.nodes.Count - 1;
    }
    foreach (CampaignGenerator.Node node in nodes)
    {
      foreach (CampaignGenerator.Node.Connection connection in node.connections)
        node.campaignNode.ConnectTo(connection.node.campaignNode);
    }
    Stack<CampaignNode> campaignNodeStack = new Stack<CampaignNode>();
    List<int> intList = new List<int>();
    campaignNodeStack.Push(campaign.nodes[0]);
    while (campaignNodeStack.Count > 0)
    {
      CampaignNode campaignNode = campaignNodeStack.Pop();
      intList.Add(campaignNode.id);
      bool flag1 = campaignNode.connections.Count > 1;
      for (int index = 0; index < campaignNode.connections.Count; ++index)
      {
        CampaignNode.Connection connection = campaignNode.connections[index];
        if (!intList.Contains(connection.otherId))
        {
          CampaignNode node = Campaign.GetNode(connection.otherId);
          bool flag2 = node.connectedTo > 1;
          node.pathId = flag2 ? -1 : (flag1 ? index : campaignNode.pathId);
          campaignNodeStack.Push(node);
        }
      }
    }
  }

  public async Task<bool> TryGenerate(
    Campaign campaign,
    int attempt,
    List<CampaignGenerator.Node> nodes,
    IReadOnlyDictionary<string, CampaignNodeType> nodeDict)
  {
    Debug.Log((object) string.Format("Attempt #{0}", (object) (attempt + 1)));
    campaign.preset = this.ChoosePreset();
    string[] presetLines = CampaignGenerator.GetPresetLines(campaign.preset);
    Events.InvokeCampaignLoadPreset(ref presetLines);
    int campaignLength = CampaignGenerator.GetCampaignLength(presetLines);
    campaign.battleTiers = presetLines[2];
    List<int> intList = new List<int>();
    foreach (char battleTier in campaign.battleTiers)
    {
      int num = int.Parse(battleTier.ToString());
      intList.Add(num);
    }
    string str1 = presetLines[3];
    int num1 = 0;
    float x = 0.0f;
    List<CampaignGenerator.Node> nodeList1 = new List<CampaignGenerator.Node>();
    for (int index1 = 0; index1 < campaignLength; ++index1)
    {
      string str2 = str1[index1].ToString();
      int result;
      int.TryParse(str2, out result);
      List<string> stringList = new List<string>();
      for (int index2 = 0; index2 <= 1; ++index2)
      {
        string str3 = presetLines[index2][index1].ToString();
        if (!str3.IsNullOrWhitespace())
          stringList.Add(str3);
      }
      if (result != num1)
      {
        CampaignNodeType type = nodeDict["area" + str2];
        float y = this.nodeSpacing.y * 0.25f.WithRandomSign();
        CampaignGenerator.Node node = this.CreateNode(x - this.nodeSpacing.x * 0.5f, y, type, intList[index1], index1, result);
        nodes.Add(node);
        node.interactable = false;
      }
      num1 = result;
      float y1 = (float) ((double) -(stringList.Count - 1) * (double) this.nodeSpacing.y * 0.5);
      List<CampaignGenerator.Node> nodeList2 = new List<CampaignGenerator.Node>();
      foreach (string key in stringList)
      {
        CampaignNodeType type = nodeDict[key];
        CampaignGenerator.Node node = this.CreateNode(x, y1, type, intList[index1], index1, result);
        nodes.Add(node);
        nodeList2.Add(node);
        y1 += this.nodeSpacing.y;
      }
      CampaignNodeType type1 = nodeDict[str2];
      for (int index3 = 0; index3 < 2; ++index3)
      {
        CampaignGenerator.Node node = this.CreateNode(x, this.nodeSpacing.y * UnityEngine.Random.Range(-0.5f, 0.5f), type1, -1, 0, result);
        nodes.Add(node);
        node.interactable = false;
      }
      x += this.nodeSpacing.x;
      if (nodeList1.Count > 0)
      {
        int num2 = Mathf.Max(nodeList2.Count, nodeList1.Count);
        for (int index4 = 0; index4 < num2; ++index4)
        {
          CampaignGenerator.Node other = nodeList2[index4 % nodeList2.Count];
          nodeList1[index4 % nodeList1.Count].Connect(other);
        }
      }
      nodeList1 = nodeList2;
    }
    Events.InvokeCampaignNodesCreated(ref nodes, this.nodeSpacing);
    await Task.Run((System.Action) (() => CampaignGenerator.ShuffleNodes(nodes)));
    bool flag = false;
    foreach (CampaignGenerator.Node node1 in nodes)
    {
      if (node1.interactable)
      {
        foreach (CampaignGenerator.Node.Connection connection in node1.connections)
        {
          CampaignGenerator.Line line = new CampaignGenerator.Line(node1.x, node1.y, connection.node.x, connection.node.y);
          foreach (CampaignGenerator.Node node2 in nodes)
          {
            if (node2 != node1 && node2 != connection.node && node2.interactable && ((double) node2.x > (double) node1.x && (double) node2.x < (double) connection.node.x || (double) node2.x > (double) connection.node.x && (double) node2.x < (double) node1.x) && ((double) node2.y > (double) node1.y && (double) node2.y < (double) connection.node.y || (double) node2.y > (double) connection.node.y && (double) node2.y < (double) node1.y) && CampaignGenerator.LineIntersectsCircle(line, node2.x, node2.y, node2.r))
            {
              Debug.Log((object) string.Format("Error: [{0}] INTERSECTS [{1}]", (object) connection, (object) node2));
              connection.color = Color.yellow;
              node2.color = Color.red;
              flag = true;
              break;
            }
          }
          if (flag)
            break;
        }
        if (flag)
          break;
      }
    }
    return flag;
  }

  public void SetSeed()
  {
    if (this.seed.IsNullOrWhitespace())
      return;
    UnityEngine.Random.InitState(this.seed.ToSeed());
  }

  public TextAsset ChoosePreset()
  {
    return this.presets.Length != 0 ? this.presets.RandomItem<TextAsset>() : throw new Exception("Campaign Generation Error: No Presets Found!");
  }

  public static string[] GetPresetLines(TextAsset preset)
  {
    string[] strArray = Regex.Split(preset.text, "\r\n|\n|\r");
    int length = strArray.Length > 1 ? strArray.Length : throw new Exception("Campaign Generation Error: Preset [" + preset.name + "] Must Contain AT LEAST 2 lines (1st for nodes, last for battle tiers)");
    string[] presetLines = new string[length];
    for (int index = 0; index < length; ++index)
      presetLines[index] = strArray[index];
    return presetLines;
  }

  public static int GetCampaignLength(string[] lines)
  {
    int length = lines[0].Length;
    for (int index = 1; index < lines.Length; ++index)
    {
      if (lines[index].Length != length)
        throw new Exception("Campaign Generation Error: Preset line length mismatch — all lines in the preset file must be the same length");
    }
    return length;
  }

  public CampaignGenerator.Node CreateNode(
    float x,
    float y,
    CampaignNodeType type,
    int tier,
    int positionIndex,
    int areaIndex,
    float r = 1f)
  {
    Vector2 vector2 = new Vector2(UnityEngine.Random.Range(-1f, 1f), UnityEngine.Random.Range(-1f, 1f)).normalized * UnityEngine.Random.Range(0.0f, this.nodeCreationRand);
    x += vector2.x;
    y += vector2.y;
    return new CampaignGenerator.Node(x, y, this.nodeSizeRange.Random() * type.size * r, tier, positionIndex, areaIndex, type.letter);
  }

  public static void ShuffleNodes(List<CampaignGenerator.Node> nodes)
  {
    bool flag = true;
    for (int index = 10000; flag && index > 0; --index)
    {
      flag = false;
      foreach (CampaignGenerator.Node node1 in nodes)
      {
        foreach (CampaignGenerator.Node node2 in nodes)
        {
          if (node1 != node2)
          {
            Vector2 vector2_1 = new Vector2(node1.x - node2.x, node1.y - node2.y);
            if ((double) vector2_1.magnitude < (double) node1.r + (double) node2.r)
            {
              Vector2 vector2_2 = vector2_1.normalized * 0.01f;
              node1.x += vector2_2.x;
              node1.y += vector2_2.y;
              node2.x -= vector2_2.x;
              node2.y -= vector2_2.y;
              flag = true;
            }
          }
        }
        foreach (CampaignGenerator.Node.Connection connection in node1.connections)
        {
          Vector2 vector2_3 = new Vector2(node1.x - connection.node.x, node1.y - connection.node.y);
          float num = vector2_3.magnitude - (node1.r + connection.node.r);
          if ((double) num > 0.0)
          {
            Vector2 vector2_4 = vector2_3.normalized * (1f / 1000f) * num;
            node1.x -= vector2_4.x;
            node1.y -= vector2_4.y;
            connection.node.x += vector2_4.x;
            connection.node.y += vector2_4.y;
          }
        }
      }
    }
  }

  public static void ShuffleNodes(List<CampaignNode> nodes)
  {
    bool flag = true;
    for (int index = 10000; flag && index > 0; --index)
    {
      flag = false;
      foreach (CampaignNode node1 in nodes)
      {
        foreach (CampaignNode node2 in nodes)
        {
          if (node1 != node2)
          {
            Vector2 vector2_1 = new Vector2(node1.position.x - node2.position.x, node1.position.y - node2.position.y);
            if ((double) vector2_1.magnitude < (double) node1.radius + (double) node2.radius)
            {
              Vector2 vector2_2 = vector2_1.normalized * 0.01f;
              node1.position.x += vector2_2.x;
              node1.position.y += vector2_2.y;
              node2.position.x -= vector2_2.x;
              node2.position.y -= vector2_2.y;
              flag = true;
            }
          }
        }
        foreach (CampaignNode.Connection connection in node1.connections)
        {
          CampaignNode.Connection c = connection;
          CampaignNode campaignNode = nodes.FirstOrDefault<CampaignNode>((Func<CampaignNode, bool>) (a => a.id == c.otherId));
          if (campaignNode != null)
          {
            Vector2 vector2_3 = new Vector2(node1.position.x - campaignNode.position.x, node1.position.y - campaignNode.position.y);
            float num = vector2_3.magnitude - (node1.radius + campaignNode.radius);
            if ((double) num > 0.0)
            {
              Vector2 vector2_4 = vector2_3.normalized * (1f / 1000f * num);
              node1.position.x -= vector2_4.x;
              node1.position.y -= vector2_4.y;
              campaignNode.position.x += vector2_4.x;
              campaignNode.position.y += vector2_4.y;
            }
          }
        }
      }
    }
  }

  public static bool LineIntersectsCircle(
    CampaignGenerator.Line line,
    float cx,
    float cy,
    float r)
  {
    float num1 = line.x1 - cx;
    float num2 = line.x2 - cx;
    float num3 = line.y1 - cy;
    float num4 = line.y2 - cy;
    double num5 = (double) num2 - (double) num1;
    float num6 = num4 - num3;
    float num7 = (float) (num5 * num5 + (double) num6 * (double) num6);
    float num8 = (float) ((double) num1 * (double) num4 - (double) num2 * (double) num3);
    return (double) r * (double) r * (double) num7 > (double) num8 * (double) num8;
  }

  public class Line
  {
    public float x1;
    public float y1;
    public float x2;
    public float y2;

    public Line(float x1, float y1, float x2, float y2)
    {
      this.x1 = x1;
      this.y1 = y1;
      this.x2 = x2;
      this.y2 = y2;
    }
  }

  public class Node
  {
    public float x;
    public float y;
    public float r;
    public int tier;
    public int positionIndex;
    public string type;
    public Color color = Color.white;
    public CampaignNode campaignNode;
    public int areaIndex;
    public readonly List<CampaignGenerator.Node.Connection> connections = new List<CampaignGenerator.Node.Connection>();
    public int connectionCount;
    public bool interactable = true;

    public Node(
      float x,
      float y,
      float r,
      int tier,
      int positionIndex,
      int areaIndex,
      string type)
    {
      this.x = x;
      this.y = y;
      this.r = r;
      this.tier = tier;
      this.positionIndex = positionIndex;
      this.areaIndex = areaIndex;
      this.type = type;
    }

    public void Connect(CampaignGenerator.Node other)
    {
      this.connections.Add(new CampaignGenerator.Node.Connection(other));
      ++this.connectionCount;
      ++other.connectionCount;
    }

    public override string ToString()
    {
      return string.Format("Node ({0}, {1})", (object) this.x, (object) this.y);
    }

    public class Connection
    {
      public CampaignGenerator.Node node;
      public Color color = Color.gray;

      public Connection(CampaignGenerator.Node node) => this.node = node;

      public override string ToString() => string.Format("Connection to {0}", (object) this.node);
    }
  }
}
