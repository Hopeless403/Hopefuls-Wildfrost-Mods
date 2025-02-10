// Decompiled with JetBrains decompiler
// Type: ShadowManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class ShadowManager : MonoBehaviour
{
  [SerializeField]
  private Shadow shadowPrefab;
  [SerializeField]
  private Vector2 limitX = new Vector2(-999f, 999f);
  [SerializeField]
  private Vector2 limitY = new Vector2(-999f, 999f);
  [SerializeField]
  private Vector2 limitZ = new Vector2(0.0f, 999f);
  [Header("Offset")]
  [SerializeField]
  private Vector3 offset = new Vector3(0.18f, -3.1f, 0.0f);
  [SerializeField]
  private Vector3 offsetBasedOnScale = new Vector3(0.0f, 0.0f, 0.0f);
  [Header("Scale")]
  [SerializeField]
  [Range(0.0f, 1f)]
  private float considerScale = 0.5f;
  [SerializeField]
  private Vector3 baseScale = new Vector3(0.6666667f, 0.6666667f, 0.6666667f);
  private readonly Dictionary<ulong, Shadow> active = new Dictionary<ulong, Shadow>();
  private readonly Queue<Shadow> pool = new Queue<Shadow>();

  private void OnEnable()
  {
    global::Events.OnEntityCreated += new UnityAction<Entity>(this.Assign);
    global::Events.OnEntityDestroyed += new UnityAction<Entity>(this.EntityDestroyed);
  }

  private void OnDisable()
  {
    global::Events.OnEntityCreated -= new UnityAction<Entity>(this.Assign);
    global::Events.OnEntityDestroyed -= new UnityAction<Entity>(this.EntityDestroyed);
  }

  private void Assign(Entity entity)
  {
    if (!entity.inPlay)
      return;
    Shadow shadow = this.Get();
    this.active[entity.data.id] = shadow;
    shadow.Assign(entity);
  }

  private void EntityDestroyed(Entity entity)
  {
    Shadow shadow;
    if (!(bool) (Object) entity.data || !this.active.TryGetValue(entity.data.id, out shadow))
      return;
    this.active.Remove(entity.data.id);
    this.Pool(shadow);
  }

  private void LateUpdate()
  {
    foreach (Shadow shadow in this.active.Values)
    {
      Transform transform = shadow.transform;
      Vector3 b1 = shadow.target.lossyScale - this.baseScale;
      Vector3 b2 = this.baseScale + b1 * this.considerScale;
      Vector3 vector3_1 = Vector3.Scale(this.offset, b2) + Vector3.Scale(this.offsetBasedOnScale, b1);
      transform.localScale = b2;
      Vector3 vector3_2 = shadow.target.position + vector3_1;
      vector3_2.x = Mathf.Clamp(vector3_2.x, this.limitX.x, this.limitX.y);
      vector3_2.y = Mathf.Clamp(vector3_2.y, this.limitY.x, this.limitY.y);
      vector3_2.z = Mathf.Clamp(vector3_2.z, this.limitZ.x, this.limitZ.y);
      transform.position = vector3_2;
      transform.localEulerAngles = new Vector3(0.0f, 0.0f, shadow.target.eulerAngles.z);
      shadow.UpdateAlpha();
    }
  }

  private Shadow Get()
  {
    Shadow shadow = this.pool.Count > 0 ? this.pool.Dequeue() : Object.Instantiate<Shadow>(this.shadowPrefab, this.transform);
    shadow.gameObject.SetActive(true);
    return shadow;
  }

  private void Pool(Shadow shadow)
  {
    shadow.gameObject.SetActive(false);
    this.pool.Enqueue(shadow);
  }
}
