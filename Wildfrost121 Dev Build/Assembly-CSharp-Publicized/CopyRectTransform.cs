// Decompiled with JetBrains decompiler
// Type: CopyRectTransform
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using UnityEngine;

#nullable disable
public class CopyRectTransform : MonoBehaviourRect
{
  [SerializeField]
  public RectTransform target;
  [SerializeField]
  [ShowIf("hasTarget")]
  public bool onEnable;
  [SerializeField]
  [ShowIf("hasTarget")]
  public bool onUpdate = true;
  [SerializeField]
  [ShowIf("hasTarget")]
  public bool onValidate;
  [SerializeField]
  [ShowIf("hasTarget")]
  public bool copyPosition = true;
  [SerializeField]
  [ShowIf("hasTarget")]
  public bool copyRotation = true;
  [SerializeField]
  [ShowIf("hasTarget")]
  public bool copySize;
  [SerializeField]
  [ShowIf("hasTarget")]
  public bool copyPivot;
  [SerializeField]
  [ShowIf("hasTarget")]
  public bool copyScale = true;
  [SerializeField]
  [ShowIf("hasTargetAndCopyScale")]
  public bool invertScale;

  public bool hasTarget => (Object) this.target != (Object) null;

  public bool hasTargetAndCopyScale => this.hasTarget && this.copyScale;

  public void OnEnable()
  {
    if (!this.onEnable)
      return;
    this.Copy();
  }

  public void LateUpdate()
  {
    if (!this.onUpdate)
      return;
    this.Copy();
  }

  [Button("Update", EButtonEnableMode.Always)]
  public void Copy()
  {
    if (!this.hasTarget)
      return;
    if (this.copyPosition)
      this.rectTransform.position = this.target.position;
    if (this.copyRotation)
      this.rectTransform.rotation = this.target.rotation;
    if (this.copySize)
      this.rectTransform.sizeDelta = this.target.sizeDelta;
    if (this.copyPivot)
      this.rectTransform.pivot = this.target.pivot;
    if (!this.copyScale)
      return;
    this.rectTransform.localScale = this.invertScale ? this.target.localScale.Invert() : this.target.localScale;
  }
}
