// Decompiled with JetBrains decompiler
// Type: CopyRectTransform
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using UnityEngine;

#nullable disable
public class CopyRectTransform : MonoBehaviourRect
{
  [SerializeField]
  private RectTransform target;
  [SerializeField]
  [ShowIf("hasTarget")]
  private bool onEnable;
  [SerializeField]
  [ShowIf("hasTarget")]
  private bool onUpdate = true;
  [SerializeField]
  [ShowIf("hasTarget")]
  private bool onValidate;
  [SerializeField]
  [ShowIf("hasTarget")]
  private bool copyPosition = true;
  [SerializeField]
  [ShowIf("hasTarget")]
  private bool copyRotation = true;
  [SerializeField]
  [ShowIf("hasTarget")]
  private bool copySize;
  [SerializeField]
  [ShowIf("hasTarget")]
  private bool copyPivot;
  [SerializeField]
  [ShowIf("hasTarget")]
  private bool copyScale = true;
  [SerializeField]
  [ShowIf("hasTargetAndCopyScale")]
  private bool invertScale;

  private bool hasTarget => (Object) this.target != (Object) null;

  private bool hasTargetAndCopyScale => this.hasTarget && this.copyScale;

  private void OnEnable()
  {
    if (!this.onEnable)
      return;
    this.Copy();
  }

  private void LateUpdate()
  {
    if (!this.onUpdate)
      return;
    this.Copy();
  }

  [Button("Update", EButtonEnableMode.Always)]
  private void Copy()
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
