// Decompiled with JetBrains decompiler
// Type: ShadowManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class ShadowManager : MonoBehaviour
{
  [SerializeField]
  public Shadow shadowPrefab;
  [SerializeField]
  public Vector2 limitX = new Vector2(-999f, 999f);
  [SerializeField]
  public Vector2 limitY = new Vector2(-999f, 999f);
  [SerializeField]
  public Vector2 limitZ = new Vector2(0.0f, 999f);
  [Header("Offset")]
  [SerializeField]
  public Vector3 offset = new Vector3(0.18f, -3.1f, 0.0f);
  [SerializeField]
  public Vector3 offsetBasedOnScale = new Vector3(0.0f, 0.0f, 0.0f);
  [Header("Scale")]
  [SerializeField]
  [Range(0.0f, 1f)]
  public float considerScale = 0.5f;
  [SerializeField]
  public Vector3 baseScale = new Vector3(0.6666667f, 0.6666667f, 0.6666667f);
  public readonly Dictionary<ulong, Shadow> active = new Dictionary<ulong, Shadow>();
  public readonly Queue<Shadow> pool = new Queue<Shadow>();

  public void OnEnable()
  {
    global::Events.OnEntityCreated += new UnityAction<Entity>(this.Assign);
    global::Events.OnEntityDestroyed += new UnityAction<Entity>(this.EntityDestroyed);
  }

  public void OnDisable()
  {
    global::Events.OnEntityCreated -= new UnityAction<Entity>(this.Assign);
    global::Events.OnEntityDestroyed -= new UnityAction<Entity>(this.EntityDestroyed);
  }

  public void Assign(Entity entity)
  {
    if (!entity.inPlay)
      return;
    Shadow shadow = this.Get();
    this.active[entity.data.id] = shadow;
    shadow.Assign(entity);
  }

  public void EntityDestroyed(Entity entity)
  {
    Shadow shadow;
    if (!(bool) (Object) entity.data || !this.active.TryGetValue(entity.data.id, out shadow))
      return;
    this.active.Remove(entity.data.id);
    this.Pool(shadow);
  }

  public void LateUpdate()
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

  public Shadow Get()
  {
    Shadow shadow = this.pool.Count > 0 ? this.pool.Dequeue() : Object.Instantiate<Shadow>(this.shadowPrefab, this.transform);
    shadow.gameObject.SetActive(true);
    return shadow;
  }

  public void Pool(Shadow shadow)
  {
    shadow.gameObject.SetActive(false);
    this.pool.Enqueue(shadow);
  }
}
