// Decompiled with JetBrains decompiler
// Type: LargeUIScaleUpdater
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

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
