// Decompiled with JetBrains decompiler
// Type: ObjectTrackerUIScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class ObjectTrackerUIScript : MonoBehaviour
{
  public RectTransform parentCanvas;
  public GameObject objToTrack;
  public Vector3 localOffset;
  private Vector3 targetPos;

  public virtual void Update()
  {
    this.targetPos = RectTransformUtility.WorldToScreenPoint(Camera.main, this.objToTrack.transform.position).WithZ(0.0f);
    this.GetComponent<RectTransform>().position = this.localOffset + this.targetPos;
  }
}
