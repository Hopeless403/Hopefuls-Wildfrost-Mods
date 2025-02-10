// Decompiled with JetBrains decompiler
// Type: VfxDeathSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class VfxDeathSystem : GameSystem
{
  [SerializeField]
  public GameObject sacrificeFX;

  public void OnEnable()
  {
    global::Events.OnEntityKilled += new UnityAction<Entity, DeathType>(this.EntityKilled);
  }

  public void OnDisable()
  {
    global::Events.OnEntityKilled -= new UnityAction<Entity, DeathType>(this.EntityKilled);
  }

  public void EntityKilled(Entity entity, DeathType deathType)
  {
    if (!DeathSystem.KilledByOwnTeam(entity) || !(bool) (Object) this.sacrificeFX)
      return;
    Transform transform = entity.transform;
    this.CreateEffect(this.sacrificeFX, transform.position, transform.lossyScale);
  }

  public void CreateEffect(GameObject prefab, Vector3 position, Vector3 scale)
  {
    if (!(bool) (Object) prefab)
      return;
    Object.Instantiate<GameObject>(prefab, position, Quaternion.identity, this.transform).transform.localScale = scale;
  }
}
