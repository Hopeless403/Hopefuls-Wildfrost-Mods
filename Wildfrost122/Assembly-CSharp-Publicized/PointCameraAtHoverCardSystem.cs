// Decompiled with JetBrains decompiler
// Type: PointCameraAtHoverCardSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

#nullable disable
public class PointCameraAtHoverCardSystem : GameSystem
{
  [SerializeField]
  public Transform cameraMover;
  [SerializeField]
  public bool affectInPlay = true;
  [SerializeField]
  public bool affectNotInPlay = true;
  [Header("Rotate To Face Card")]
  [SerializeField]
  [Range(0.0f, 1f)]
  public float aimLerp = 0.05f;
  [SerializeField]
  [Range(0.0f, 1f)]
  public float aimResetLerp = 0.0125f;
  [SerializeField]
  [Range(0.0f, 1f)]
  public float aimAmount = 0.05f;
  [Header("Pull Position Towards Card")]
  [SerializeField]
  [Range(0.0f, 1f)]
  public float pullLerp = 0.05f;
  [SerializeField]
  [Range(0.0f, 1f)]
  public float pullResetLerp = 0.0125f;
  [SerializeField]
  [Range(0.0f, 1f)]
  public float pullAmount = 0.05f;
  [SerializeField]
  public float pullClamp = 10f;
  public Entity current;
  public float amount;
  public readonly Quaternion originalRotation = Quaternion.identity;
  public Quaternion toRotation;
  public readonly Vector3 originalPosition = Vector3.zero;
  public Vector3 toPosition;

  public void OnEnable()
  {
    this.amount = Settings.Load<float>("CameraSway", 1f);
    global::Events.OnEntityHover += new UnityAction<Entity>(this.EntityHover);
    global::Events.OnEntityUnHover += new UnityAction<Entity>(this.EntityUnHover);
    global::Events.OnEntityDestroyed += new UnityAction<Entity>(this.EntityUnHover);
    global::Events.OnSceneChanged += new UnityAction<Scene>(this.SceneChanged);
    global::Events.OnSettingChanged += new UnityAction<string, object>(this.SettingChanged);
  }

  public void OnDisable()
  {
    global::Events.OnEntityHover -= new UnityAction<Entity>(this.EntityHover);
    global::Events.OnEntityUnHover -= new UnityAction<Entity>(this.EntityUnHover);
    global::Events.OnEntityDestroyed -= new UnityAction<Entity>(this.EntityUnHover);
    global::Events.OnSceneChanged -= new UnityAction<Scene>(this.SceneChanged);
    global::Events.OnSettingChanged -= new UnityAction<string, object>(this.SettingChanged);
  }

  public void Update()
  {
    bool current = (bool) (Object) this.current;
    if ((double) this.aimAmount > 0.0)
    {
      if (current)
        this.toRotation = Quaternion.Lerp(this.originalRotation, Quaternion.FromToRotation(this.transform.forward, this.current.transform.position - this.cameraMover.position), this.aimAmount * this.amount);
      this.cameraMover.rotation = Delta.Lerp(this.cameraMover.rotation, this.toRotation, !current ? this.aimResetLerp : this.aimLerp, Time.deltaTime);
    }
    if ((double) this.pullAmount <= 0.0)
      return;
    if (current)
      this.toPosition = Vector3.Lerp(this.originalPosition, this.originalPosition + Vector3.ClampMagnitude(this.current.transform.position, this.pullClamp), this.pullAmount * this.amount);
    this.cameraMover.localPosition = Delta.Lerp(this.cameraMover.localPosition, this.toPosition, !current ? this.pullResetLerp : this.pullLerp, Time.deltaTime);
  }

  public void EntityHover(Entity entity)
  {
    if (!this.Check(entity))
      return;
    this.current = entity;
  }

  public void EntityUnHover(Entity entity)
  {
    if (!((Object) this.current == (Object) entity))
      return;
    this.toRotation = this.originalRotation;
    this.toPosition = this.originalPosition;
    this.current = (Entity) null;
  }

  public void SceneChanged(Scene scene)
  {
    this.cameraMover.SetLocalPositionAndRotation(this.originalPosition, this.originalRotation);
  }

  public bool Check(Entity entity)
  {
    if (entity.inPlay && this.affectInPlay)
      return true;
    return !entity.inPlay && this.affectNotInPlay;
  }

  public void SettingChanged(string key, object value)
  {
    if (!(key == "CameraSway") || !(value is float num))
      return;
    this.amount = num;
  }
}
