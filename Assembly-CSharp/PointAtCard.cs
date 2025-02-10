// Decompiled with JetBrains decompiler
// Type: PointAtCard
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;

public class PointAtCard : MonoBehaviour
{
  [SerializeField]
  private Transform holder;
  [SerializeField]
  private float moveAmount = 0.25f;
  [SerializeField]
  private float lerp = 0.1f;
  private Vector3 targetPos;
  private Transform t;
  private Camera cam;

  private void OnEnable()
  {
    this.cam = Camera.main;
    this.t = this.transform;
    global::Events.OnEntityHover += new UnityAction<Entity>(this.EntityHover);
  }

  private void OnDisable() => global::Events.OnEntityHover -= new UnityAction<Entity>(this.EntityHover);

  private void Update()
  {
    if (MonoBehaviourSingleton<Cursor3d>.instance.usingMouse)
      this.SetTargetPos(MonoBehaviourSingleton<Cursor3d>.instance.transform.position);
    this.t.localPosition = Delta.Lerp(this.t.localPosition, this.targetPos, this.lerp, Time.deltaTime);
  }

  private void EntityHover(Entity entity) => this.SetTargetPos(entity.transform.position);

  private void SetTargetPos(Vector3 target) => this.targetPos = this.GetVectorTo(target) * this.moveAmount;

  private Vector3 GetVectorTo(Vector3 to)
  {
    Vector3 vectorTo = this.cam.WorldToScreenPoint(to) - this.cam.WorldToScreenPoint(this.holder.position);
    if ((double) vectorTo.magnitude > 1.0)
      vectorTo.Normalize();
    return vectorTo;
  }
}
