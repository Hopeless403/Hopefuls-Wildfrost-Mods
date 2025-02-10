// Decompiled with JetBrains decompiler
// Type: VfxDeathSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;

public class VfxDeathSystem : GameSystem
{
  [SerializeField]
  private GameObject sacrificeFX;

  private void OnEnable() => global::Events.OnEntityKilled += new UnityAction<Entity, DeathType>(this.EntityKilled);

  private void OnDisable() => global::Events.OnEntityKilled -= new UnityAction<Entity, DeathType>(this.EntityKilled);

  private void EntityKilled(Entity entity, DeathType deathType)
  {
    if (!DeathSystem.KilledByOwnTeam(entity) || !(bool) (Object) this.sacrificeFX)
      return;
    Transform transform = entity.transform;
    this.CreateEffect(this.sacrificeFX, transform.position, transform.lossyScale);
  }

  private void CreateEffect(GameObject prefab, Vector3 position, Vector3 scale)
  {
    if (!(bool) (Object) prefab)
      return;
    Object.Instantiate<GameObject>(prefab, position, Quaternion.identity, this.transform).transform.localScale = scale;
  }
}
