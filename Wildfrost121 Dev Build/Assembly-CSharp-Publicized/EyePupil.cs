// Decompiled with JetBrains decompiler
// Type: EyePupil
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class EyePupil : MonoBehaviour
{
  [SerializeField]
  public Transform target;
  [SerializeField]
  public AnimationCurve aimAmount;
  [SerializeField]
  public float lerp = 0.2f;
  public Vector3 targetPos;

  public void OnEnable() => global::Events.OnEntityHover += new UnityAction<Entity>(this.EntityHover);

  public void OnDisable() => global::Events.OnEntityHover -= new UnityAction<Entity>(this.EntityHover);

  public void Update()
  {
    this.target.localPosition = Delta.Lerp(this.target.localPosition, this.targetPos, this.lerp, Time.deltaTime);
  }

  public void EntityHover(Entity entity) => this.LookAt(entity.transform.position);

  public void LookAt(Vector3 worldPosition)
  {
    Vector3 vector3 = (worldPosition - this.transform.position).WithZ(0.0f);
    float num = this.aimAmount.Evaluate(vector3.magnitude);
    this.targetPos = vector3.normalized * num;
  }
}
