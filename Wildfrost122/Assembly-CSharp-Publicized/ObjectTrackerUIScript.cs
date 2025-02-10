// Decompiled with JetBrains decompiler
// Type: ObjectTrackerUIScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public class ObjectTrackerUIScript : MonoBehaviour
{
  public RectTransform parentCanvas;
  public GameObject objToTrack;
  public Vector3 localOffset;
  public Vector3 targetPos;

  public virtual void Update()
  {
    this.targetPos = RectTransformUtility.WorldToScreenPoint(Camera.main, this.objToTrack.transform.position).WithZ(0.0f);
    this.GetComponent<RectTransform>().position = this.localOffset + this.targetPos;
  }
}
