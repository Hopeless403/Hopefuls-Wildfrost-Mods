// Decompiled with JetBrains decompiler
// Type: PointAtCard
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class PointAtCard : MonoBehaviour
{
  [SerializeField]
  public Transform holder;
  [SerializeField]
  public float moveAmount = 0.25f;
  [SerializeField]
  public float lerp = 0.1f;
  public Vector3 targetPos;
  public Transform t;
  public Camera cam;

  public void OnEnable()
  {
    this.cam = Camera.main;
    this.t = this.transform;
    global::Events.OnEntityHover += new UnityAction<Entity>(this.EntityHover);
  }

  public void OnDisable() => global::Events.OnEntityHover -= new UnityAction<Entity>(this.EntityHover);

  public void Update()
  {
    if (MonoBehaviourSingleton<Cursor3d>.instance.usingMouse)
      this.SetTargetPos(MonoBehaviourSingleton<Cursor3d>.instance.transform.position);
    this.t.localPosition = Delta.Lerp(this.t.localPosition, this.targetPos, this.lerp, Time.deltaTime);
  }

  public void EntityHover(Entity entity) => this.SetTargetPos(entity.transform.position);

  public void SetTargetPos(Vector3 target)
  {
    this.targetPos = this.GetVectorTo(target) * this.moveAmount;
  }

  public Vector3 GetVectorTo(Vector3 to)
  {
    Vector3 vectorTo = this.cam.WorldToScreenPoint(to) - this.cam.WorldToScreenPoint(this.holder.position);
    if ((double) vectorTo.magnitude > 1.0)
      vectorTo.Normalize();
    return vectorTo;
  }
}
