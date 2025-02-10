// Decompiled with JetBrains decompiler
// Type: TargetingArrow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[RequireComponent(typeof (Bezier))]
public class TargetingArrow : TargetingDisplay
{
  [SerializeField]
  private Transform head;
  [SerializeField]
  [Range(0.0f, 1f)]
  private float curviness = 0.5f;
  [SerializeField]
  [Range(0.0f, 1f)]
  private float arch;
  [SerializeField]
  private TargetingArrow.ArrowHeadStyle[] headStyles;
  [SerializeField]
  private string defaultStyleName = "Default";
  private Dictionary<string, TargetingArrow.ArrowHeadStyle> _headStyleLookup;
  private TargetingArrow.ArrowHeadStyle currentHeadStyle;
  private Bezier _bezier;

  private Dictionary<string, TargetingArrow.ArrowHeadStyle> headStyleLookup
  {
    get
    {
      if (this._headStyleLookup == null)
      {
        this._headStyleLookup = new Dictionary<string, TargetingArrow.ArrowHeadStyle>();
        foreach (TargetingArrow.ArrowHeadStyle headStyle in this.headStyles)
          this._headStyleLookup[headStyle.name] = headStyle;
      }
      return this._headStyleLookup;
    }
  }

  private Bezier bezier => this._bezier ?? (this._bezier = this.GetComponent<Bezier>());

  public override void UpdatePosition(Transform target)
  {
    this.UpdatePosition(this.transform.position, target.position);
  }

  public override void UpdatePosition(Vector3 start, Vector3 end)
  {
    float y = Mathf.Lerp(start.y, end.y, this.curviness);
    Vector3 p1 = new Vector3(start.x, y, start.z - this.arch);
    this.bezier.UpdateCurve(start, p1, end);
    if (!(bool) (UnityEngine.Object) this.head)
      return;
    this.head.position = this.bezier.GetPoint(this.bezier.pointCount - 1);
    TargetingArrow.ArrowHeadStyle currentHeadStyle = this.currentHeadStyle;
    if (currentHeadStyle == null || !currentHeadStyle.directional)
      return;
    Transform transform = currentHeadStyle.transform;
    if (transform == null || this.bezier.pointCount <= 1)
      return;
    Vector3 point = this.bezier.GetPoint(this.bezier.pointCount - 2);
    Vector3 vector3 = transform.position - point;
    float num = Mathf.Atan(vector3.y / vector3.x) * 57.29578f;
    if ((double) vector3.x < 0.0)
      num += 180f;
    if (float.IsNaN(num))
      return;
    transform.localEulerAngles = new Vector3(0.0f, 0.0f, num);
  }

  public override void EntityHover(Entity entity) => this.SetStyle("Target");

  public override void ContainerHover(CardContainer cardContainer, TargetingArrowSystem system)
  {
    if ((UnityEngine.Object) cardContainer == (UnityEngine.Object) system.target.owner.discardContainer && system.target.CanRecall())
    {
      system.snapToContainer = cardContainer;
      this.SetStyle("Discard");
    }
    else
    {
      if (!system.target.targetMode.TargetRow || !system.target.CanPlayOn(cardContainer))
        return;
      system.snapToContainer = cardContainer;
      this.SetStyle("TargetRow");
    }
  }

  public override void SlotHover(CardSlot slot, TargetingArrowSystem system)
  {
    if (!system.target.data.playOnSlot || !system.target.CanPlayOn((CardContainer) slot))
      return;
    system.snapToContainer = (CardContainer) slot;
    this.SetStyle("Target");
  }

  private void SetStyle(string name)
  {
    if ((bool) (UnityEngine.Object) this.currentHeadStyle?.gameObject)
      this.currentHeadStyle.gameObject.SetActive(false);
    this.currentHeadStyle = this.headStyleLookup.ContainsKey(name) ? this.headStyleLookup[name] : this.headStyleLookup[this.defaultStyleName];
    if ((bool) (UnityEngine.Object) this.currentHeadStyle?.gameObject)
      this.currentHeadStyle.gameObject.SetActive(true);
    if ((bool) (UnityEngine.Object) this.currentHeadStyle.renderer)
      this.currentHeadStyle.renderer.color = this.currentHeadStyle.headColor;
    this.bezier.lineRenderer.colorGradient = this.currentHeadStyle.lineColor;
  }

  public override void ResetStyle() => this.SetStyle(this.defaultStyleName);

  [Serializable]
  public class ArrowHeadStyle
  {
    public string name;
    public GameObject gameObject;
    public Transform transform;
    public SpriteRenderer renderer;
    public bool directional;
    public Color headColor;
    public Gradient lineColor;
  }
}
