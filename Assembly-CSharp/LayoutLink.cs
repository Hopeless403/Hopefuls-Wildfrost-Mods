// Decompiled with JetBrains decompiler
// Type: LayoutLink
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

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

  private bool HasLayoutElement => (Object) this.layoutElement != (Object) null;

  private void OnEnable()
  {
    if (!this.setPositionOnEnable || !((Object) this.link != (Object) null))
      return;
    this.rectTransform.position = this.link.position + this.offset;
  }

  private void LateUpdate() => this.rectTransform.position = Delta.Lerp(this.rectTransform.position, this.link.position + this.offset, this.lerp, Time.deltaTime);

  private void Update()
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
