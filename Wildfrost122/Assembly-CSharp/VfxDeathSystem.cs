// Decompiled with JetBrains decompiler
// Type: VfxDeathSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class VfxDeathSystem : GameSystem
{
  [SerializeField]
  private GameObject sacrificeFX;

  private void OnEnable()
  {
    global::Events.OnEntityKilled += new UnityAction<Entity, DeathType>(this.EntityKilled);
  }

  private void OnDisable()
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

  private void CreateEffect(GameObject prefab, Vector3 position, Vector3 scale)
  {
    if (!(bool) (Object) prefab)
      return;
    Object.Instantiate<GameObject>(prefab, position, Quaternion.identity, this.transform).transform.localScale = scale;
  }
}
