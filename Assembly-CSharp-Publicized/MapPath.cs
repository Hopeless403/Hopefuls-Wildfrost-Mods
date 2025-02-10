// Decompiled with JetBrains decompiler
// Type: MapPath
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MapPath : MonoBehaviour
{
  [SerializeField]
  public Transform linePointPrefab;
  [SerializeField]
  public Transform lastPoint;
  [SerializeField]
  public Vector2 midPointOffset = new Vector2(0.0f, 1f);
  [SerializeField]
  public float pathShort = 1f;
  [SerializeField]
  public Vector2 pathNodePull = new Vector2(0.75f, 1.2f);
  [SerializeField]
  public LineRenderer line;
  [SerializeField]
  public CurvedLineRenderer curve;
  [Header("Tweens")]
  [SerializeField]
  public LeanTweenType revealEase = LeanTweenType.easeInOutCubic;
  [SerializeField]
  public float revealSpeed = 1f;
  public List<MapPath.Node> nodes = new List<MapPath.Node>();
  [CompilerGenerated]
  public MapNode \u003CStartNode\u003Ek__BackingField;
  public bool reachable = true;
  public float alpha = 1f;
  public LTDescr alphaTween;

  public MapNode StartNode
  {
    get => this.\u003CStartNode\u003Ek__BackingField;
    set => this.\u003CStartNode\u003Ek__BackingField = value;
  }

  public MapNode EndNode => this.nodes[this.nodes.Count - 1].mapNode;

  public int NodeCount => this.nodes.Count;

  public bool ContainsNode(MapNode node) => this.nodes.Exists((Predicate<MapPath.Node>) (a => (UnityEngine.Object) a.mapNode == (UnityEngine.Object) node));

  public void Add(MapNode node)
  {
    Vector3 localPosition = node.transform.localPosition;
    if ((UnityEngine.Object) this.lastPoint != (UnityEngine.Object) null)
      this.AddPoint((this.lastPoint.localPosition + localPosition) * 0.5f + new Vector3(UnityEngine.Random.Range(-1f, 1f), UnityEngine.Random.Range(-1f, 1f)).normalized * this.midPointOffset.Random());
    if (this.StartNode == null)
    {
      MapNode mapNode;
      this.StartNode = mapNode = node;
    }
    Transform transform = this.AddPoint(localPosition);
    this.nodes.Add(new MapPath.Node()
    {
      mapNode = node,
      point = transform
    });
    this.lastPoint = transform;
  }

  public MapNode Get(int index) => this.nodes[index].mapNode;

  public MapNode[] GetNodes()
  {
    List<MapNode> mapNodeList = new List<MapNode>();
    foreach (MapPath.Node node in this.nodes)
      mapNodeList.Add(node.mapNode);
    return mapNodeList.ToArray();
  }

  public void Setup()
  {
    if (this.nodes.Count <= 1)
      throw new Exception("MapPath Error: MUST HAVE more than 1 node in the path");
    this.PullTowards(this.nodes[0].point.transform, this.nodes[1].point.transform.localPosition, this.pathShort);
    this.PullTowards(this.nodes[this.nodes.Count - 1].point.transform, this.nodes[this.nodes.Count - 2].point.transform.localPosition, this.pathShort);
    for (int index = 1; index < this.nodes.Count - 1; ++index)
    {
      Transform transform1 = this.nodes[index - 1].mapNode.transform;
      Transform transform2 = this.nodes[index].point.transform;
      Transform transform3 = this.nodes[index + 1].mapNode.transform;
      Vector3 towards = (transform1.localPosition + transform3.localPosition) * 0.5f;
      this.PullTowards(transform2, towards, this.pathNodePull.Random());
    }
    this.curve.UpdatePoints();
    bool flag = true;
    foreach (MapPath.Node node in this.nodes)
    {
      if (!node.mapNode.campaignNode.revealed)
      {
        flag = false;
        break;
      }
    }
    if (flag)
      return;
    this.Hide();
  }

  public void PullTowards(Transform point, Vector3 towards, float amount)
  {
    Vector3 localPosition = point.localPosition;
    Vector3 vector3 = (towards - localPosition).normalized * amount;
    point.localPosition += vector3;
  }

  public Transform AddPoint(Vector3 localPosition)
  {
    Transform transform = UnityEngine.Object.Instantiate<Transform>(this.linePointPrefab, this.transform);
    transform.localPosition = localPosition;
    transform.gameObject.SetActive(true);
    return transform;
  }

  public void Hide()
  {
    if (!this.gameObject.activeSelf)
      return;
    this.gameObject.SetActive(false);
  }

  public IEnumerator Reveal()
  {
    MapPath mapPath = this;
    if (!mapPath.gameObject.activeSelf)
    {
      mapPath.gameObject.SetActive(true);
      mapPath.SetAlpha(1f);
      mapPath.UpdatePathVisibility(0.0f);
      float delayPerNode = 0.2f / mapPath.revealSpeed;
      float num = (float) mapPath.nodes.Count * delayPerNode;
      LeanTween.value(mapPath.gameObject, 0.0f, 1f, num).setEase(mapPath.revealEase).setOnUpdate(new Action<float>(mapPath.\u003CReveal\u003Eb__29_0));
      Events.InvokeMapPathReveal(num);
      foreach (MapPath.Node node1 in mapPath.nodes)
      {
        MapPath.Node node = node1;
        yield return (object) Sequences.Wait(delayPerNode);
        node.mapNode.Reveal();
        node = new MapPath.Node();
      }
    }
  }

  public void CheckReachable()
  {
    if (!this.reachable)
      return;
    this.reachable = false;
    int num = Mathf.Max(2, this.nodes.Count - 1);
    for (int index = 1; index < num; ++index)
    {
      if (this.nodes[index].mapNode.reachable)
      {
        this.reachable = true;
        break;
      }
    }
    if (this.reachable)
      return;
    this.SetUnreachable();
  }

  public void SetUnreachable()
  {
    this.reachable = false;
    this.FadeTo(0.0f);
  }

  public void FadeTo(float alpha, float time = 0.3f)
  {
    if ((double) Mathf.Abs(this.alpha - alpha) <= 0.0099999997764825821)
      return;
    if ((double) time > 0.0)
      this.alphaTween = LeanTween.value(this.gameObject, this.alpha, alpha, time).setEase(LeanTweenType.easeInOutQuad).setOnUpdate(new Action<float>(this.SetAlpha));
    else
      this.SetAlpha(alpha);
    this.alpha = alpha;
  }

  public void UpdatePathVisibility(float value)
  {
    int num = 1;
    if ((double) value <= 0.0099999997764825821)
      this.line.widthCurve = new AnimationCurve(new Keyframe[2]
      {
        new Keyframe(0.0f, 0.0f, 0.0f, 0.0f),
        new Keyframe(1f, 0.0f, 0.0f, 0.0f)
      });
    else if ((double) value >= 0.99000000953674316)
      this.line.widthCurve = new AnimationCurve(new Keyframe[2]
      {
        new Keyframe(0.0f, (float) num, 0.0f, 0.0f),
        new Keyframe(1f, (float) num, 0.0f, 0.0f)
      });
    else
      this.line.widthCurve = new AnimationCurve(new Keyframe[3]
      {
        new Keyframe(0.0f, (float) num, 0.0f, 0.0f),
        new Keyframe(value - 0.01f, (float) num, 0.0f, 0.0f),
        new Keyframe(value, 0.0f, 0.0f, 0.0f)
      });
  }

  public void SetColour(Color value) => this.line.colorGradient.colorKeys = new GradientColorKey[2]
  {
    new GradientColorKey(value, 0.0f),
    new GradientColorKey(value, 1f)
  };

  public void SetAlpha(float value)
  {
    Gradient colorGradient = this.line.colorGradient;
    colorGradient.alphaKeys = new GradientAlphaKey[2]
    {
      new GradientAlphaKey(value, 0.0f),
      new GradientAlphaKey(value, 1f)
    };
    this.line.colorGradient = colorGradient;
  }

  [CompilerGenerated]
  public void \u003CReveal\u003Eb__29_0(float a) => this.UpdatePathVisibility(a);

  public struct Node
  {
    public MapNode mapNode;
    public Transform point;
  }
}
