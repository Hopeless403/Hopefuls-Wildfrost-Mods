// Decompiled with JetBrains decompiler
// Type: LargeUIScaleUpdater
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
public class LargeUIScaleUpdater : MonoBehaviour
{
  [SerializeField]
  private Vector3 scaleMin = Vector3.one;
  [SerializeField]
  private Vector3 scaleMax = Vector3.one;
  [SerializeField]
  private Vector3 positionMin;
  [SerializeField]
  private Vector3 positionMax;
  private Transform _transform;

  private Transform t => this._transform ?? (this._transform = this.transform);

  public void PromptUpdate()
  {
    this.t.localScale = Vector3.Lerp(this.scaleMin, this.scaleMax, 0.0f);
    this.t.localPosition = Vector3.Lerp(this.positionMin, this.positionMax, 0.0f);
  }
}
