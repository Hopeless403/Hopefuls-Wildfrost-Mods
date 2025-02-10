// Decompiled with JetBrains decompiler
// Type: UnitTargetSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class UnitTargetSystem : GameSystem
{
  [SerializeField]
  private UnitTarget targetPrefab;
  private Entity dragging;
  private Entity hover;
  private readonly List<GameObject> targets = new List<GameObject>();

  private void OnEnable()
  {
    global::Events.OnEntityDrag += new UnityAction<Entity>(this.EntityDrag);
    global::Events.OnEntityRelease += new UnityAction<Entity>(this.EntityRelease);
    global::Events.OnEntityHover += new UnityAction<Entity>(this.EntityHover);
    global::Events.OnEntityUnHover += new UnityAction<Entity>(this.EntityUnHover);
  }

  private void OnDisable()
  {
    global::Events.OnEntityDrag -= new UnityAction<Entity>(this.EntityDrag);
    global::Events.OnEntityRelease -= new UnityAction<Entity>(this.EntityRelease);
    global::Events.OnEntityHover -= new UnityAction<Entity>(this.EntityHover);
    global::Events.OnEntityUnHover -= new UnityAction<Entity>(this.EntityUnHover);
  }

  private void Start()
  {
    global::Events.OnSettingChanged += new UnityAction<string, object>(this.SettingChanged);
    if (Settings.Load<int>("UnitTargets", 1) == 1)
      return;
    this.enabled = false;
  }

  private void OnDestroy()
  {
    global::Events.OnSettingChanged -= new UnityAction<string, object>(this.SettingChanged);
  }

  private void EntityDrag(Entity entity)
  {
    this.dragging = entity;
    if (!(bool) (Object) this.hover)
      return;
    this.HideTargets();
  }

  private void EntityRelease(Entity entity)
  {
    if (!((Object) this.dragging == (Object) entity))
      return;
    this.dragging = (Entity) null;
  }

  private void EntityHover(Entity entity)
  {
    if ((bool) (Object) this.dragging)
      return;
    if ((bool) (Object) this.hover)
      this.EntityUnHover(this.hover);
    this.hover = entity;
    if (!entity.inPlay || entity.counter.max <= 0 || !entity.HasAttackIcon() || !Battle.IsOnBoard(this.hover))
      return;
    this.ShowTargets(this.hover);
  }

  private void EntityUnHover(Entity entity)
  {
    if (!((Object) this.hover == (Object) entity))
      return;
    this.hover = (Entity) null;
    this.HideTargets();
  }

  private void SettingChanged(string key, object value)
  {
    if (!(key == "UnitTargets") || !(value is int num))
      return;
    if (num == 0 && this.enabled)
    {
      this.enabled = false;
    }
    else
    {
      if (num != 1 || this.enabled)
        return;
      this.enabled = true;
    }
  }

  private void ShowTargets(Entity entity)
  {
    Entity[] potentialTargets = entity.targetMode.GetPotentialTargets(entity, (Entity) null, (CardContainer) null);
    if (potentialTargets == null)
      return;
    bool random = entity.targetMode.Random;
    StatusEffectData status = entity.FindStatus("frenzy");
    bool frenzy = status != null && status.count > 0;
    foreach (MonoBehaviourCacheTransform behaviourCacheTransform in potentialTargets)
    {
      UnitTarget unitTarget = Object.Instantiate<UnitTarget>(this.targetPrefab, behaviourCacheTransform.transform.position, Quaternion.identity, this.transform);
      unitTarget.SetAimless(random);
      unitTarget.SetFrenzy(frenzy);
      this.targets.Add(unitTarget.gameObject);
    }
  }

  private void HideTargets()
  {
    foreach (GameObject target in this.targets)
      target.Destroy();
    this.targets.Clear();
  }
}
