// Decompiled with JetBrains decompiler
// Type: TargetingMultiple
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TargetingMultiple : TargetingDisplay
{
  [SerializeField]
  private GameObject targetPrefab;
  private readonly List<GameObject> targets = new List<GameObject>();
  private Entity target;
  private Entity[] entitiesToHit;
  private bool showingTargets;

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

  private void ContainerHover(CardContainer cardContainer)
  {
    if (!(bool) (Object) cardContainer || this.target.containers.Length == 0 || !((Object) cardContainer == (Object) this.target.containers[0]))
      return;
    this.HideTargets();
  }

  private void ContainerUnHover(CardContainer cardContainer)
  {
    if (this.showingTargets || !(bool) (Object) this.target || this.target.containers.Length == 0 || !((Object) cardContainer == (Object) this.target.containers[0]))
      return;
    this.ShowTargets();
  }

  private void ShowTargets()
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

  private void HideTargets()
  {
    if (!this.showingTargets)
      return;
    foreach (GameObject target in this.targets)
      target.Destroy();
    this.targets.Clear();
    this.showingTargets = false;
  }
}
