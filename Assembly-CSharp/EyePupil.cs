// Decompiled with JetBrains decompiler
// Type: EyePupil
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;

public class EyePupil : MonoBehaviour
{
  [SerializeField]
  private Transform target;
  [SerializeField]
  private AnimationCurve aimAmount;
  [SerializeField]
  private float lerp = 0.2f;
  private Vector3 targetPos;

  private void OnEnable() => global::Events.OnEntityHover += new UnityAction<Entity>(this.EntityHover);

  private void OnDisable() => global::Events.OnEntityHover -= new UnityAction<Entity>(this.EntityHover);

  private void Update() => this.target.localPosition = Delta.Lerp(this.target.localPosition, this.targetPos, this.lerp, Time.deltaTime);

  private void EntityHover(Entity entity) => this.LookAt(entity.transform.position);

  private void LookAt(Vector3 worldPosition)
  {
    Vector3 vector3 = (worldPosition - this.transform.position).WithZ(0.0f);
    float num = this.aimAmount.Evaluate(vector3.magnitude);
    this.targetPos = vector3.normalized * num;
  }
}
