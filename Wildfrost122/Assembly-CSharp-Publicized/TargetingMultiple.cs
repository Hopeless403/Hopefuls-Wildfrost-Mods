// Decompiled with JetBrains decompiler
// Type: TargetingMultiple
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class TargetingMultiple : TargetingDisplay
{
  [SerializeField]
  public GameObject targetPrefab;
  public readonly List<GameObject> targets = new List<GameObject>();
  public Entity target;
  public Entity[] entitiesToHit;
  public bool showingTargets;

  public override void Show(TargetingArrowSystem system)
  {
    this.target = system.target;
    this.entitiesToHit = this.target.targetMode.GetTargets(this.target, (Entity) null, (CardContainer) null);
    global::Events.OnContainerHover += new UnityAction<CardContainer>(this.ContainerHover);
    global::Events.OnContainerUnHover += new UnityAction<CardContainer>(this.ContainerUnHover);
  }

  public override void Hide()
  {
    this.HideTargets();
    global::Events.OnContainerHover -= new UnityAction<CardContainer>(this.ContainerHover);
    global::Events.OnContainerUnHover -= new UnityAction<CardContainer>(this.ContainerUnHover);
  }

  public void ContainerHover(CardContainer cardContainer)
  {
    if (!(bool) (Object) cardContainer || this.target.containers.Length == 0 || !((Object) cardContainer == (Object) this.target.containers[0]))
      return;
    this.HideTargets();
  }

  public void ContainerUnHover(CardContainer cardContainer)
  {
    if (this.showingTargets || !(bool) (Object) this.target || this.target.containers.Length == 0 || !((Object) cardContainer == (Object) this.target.containers[0]))
      return;
    this.ShowTargets();
  }

  public void ShowTargets()
  {
    if (this.showingTargets)
      return;
    if (this.entitiesToHit != null)
    {
      foreach (MonoBehaviourCacheTransform behaviourCacheTransform in this.entitiesToHit)
        this.targets.Add(Object.Instantiate<GameObject>(this.targetPrefab, behaviourCacheTransform.transform.position, Quaternion.identity, this.transform));
    }
    this.showingTargets = true;
  }

  public void HideTargets()
  {
    if (!this.showingTargets)
      return;
    foreach (GameObject target in this.targets)
      target.Destroy();
    this.targets.Clear();
    this.showingTargets = false;
  }
}
