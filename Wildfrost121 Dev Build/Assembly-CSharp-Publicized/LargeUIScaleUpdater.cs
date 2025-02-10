// Decompiled with JetBrains decompiler
// Type: LargeUIScaleUpdater
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public class LargeUIScaleUpdater : MonoBehaviour
{
  [SerializeField]
  public Vector3 scaleMin = Vector3.one;
  [SerializeField]
  public Vector3 scaleMax = Vector3.one;
  [SerializeField]
  public Vector3 positionMin;
  [SerializeField]
  public Vector3 positionMax;
  public Transform _transform;

  public Transform t => this._transform ?? (this._transform = this.transform);

  public void PromptUpdate()
  {
    this.t.localScale = Vector3.Lerp(this.scaleMin, this.scaleMax, 0.0f);
    this.t.localPosition = Vector3.Lerp(this.positionMin, this.positionMax, 0.0f);
  }
}
