// Decompiled with JetBrains decompiler
// Type: LayoutLink
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

#nullable disable
[ExecuteInEditMode]
public class LayoutLink : MonoBehaviourRect
{
  [FormerlySerializedAs("layoutTransform")]
  public RectTransform link;
  public float lerp = 0.1f;
  public bool setPositionOnEnable = true;
  public Vector3 offset;
  [Header("Link to layout element to update layout element size")]
  public LayoutElement layoutElement;
  [ShowIf("HasLayoutElement")]
  public bool setLayoutWidth;
  [ShowIf("HasLayoutElement")]
  public bool setLayoutHeight;

  public bool HasLayoutElement => (Object) this.layoutElement != (Object) null;

  public void OnEnable()
  {
    if (!this.setPositionOnEnable || !((Object) this.link != (Object) null))
      return;
    this.rectTransform.position = this.link.position + this.offset;
  }

  public void LateUpdate()
  {
    this.rectTransform.position = Delta.Lerp(this.rectTransform.position, this.link.position + this.offset, this.lerp, Time.deltaTime);
  }

  public void Update()
  {
    if (!this.HasLayoutElement)
      return;
    Vector2 sizeDelta = this.rectTransform.sizeDelta;
    if (this.setLayoutWidth)
      this.layoutElement.preferredWidth = sizeDelta.x;
    if (!this.setLayoutHeight)
      return;
    this.layoutElement.preferredHeight = sizeDelta.y;
  }
}
