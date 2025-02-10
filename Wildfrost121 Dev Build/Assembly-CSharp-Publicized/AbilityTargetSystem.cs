// Decompiled with JetBrains decompiler
// Type: AbilityTargetSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

#nullable disable
public class AbilityTargetSystem : GameSystem
{
  public Transform targetGroup;
  public GameObject targetPrefab;
  public Dictionary<CardContainer, GameObject> currentTargets;

  public void OnEnable()
  {
    global::Events.OnAbilityTargetAdd += new UnityAction<CardContainer>(this.AddTarget);
    global::Events.OnAbilityTargetRemove += new UnityAction<CardContainer>(this.RemoveTarget);
    global::Events.OnSceneChanged += new UnityAction<Scene>(this.SceneChanged);
  }

  public void OnDisable()
  {
    global::Events.OnAbilityTargetAdd -= new UnityAction<CardContainer>(this.AddTarget);
    global::Events.OnAbilityTargetRemove -= new UnityAction<CardContainer>(this.RemoveTarget);
    global::Events.OnSceneChanged -= new UnityAction<Scene>(this.SceneChanged);
    this.Clear();
  }

  public void AddTarget(CardContainer container)
  {
    GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.targetPrefab, this.targetGroup);
    gameObject.transform.position = container.transform.position;
    if (this.currentTargets == null)
      this.currentTargets = new Dictionary<CardContainer, GameObject>();
    this.currentTargets[container] = gameObject;
  }

  public void RemoveTarget(CardContainer container)
  {
    if (this.currentTargets == null || !this.currentTargets.ContainsKey(container))
      return;
    this.currentTargets[container].Destroy();
    this.currentTargets.Remove(container);
  }

  public void SceneChanged(Scene scene) => this.Clear();

  public void Clear()
  {
    if (this.currentTargets == null)
      return;
    foreach (KeyValuePair<CardContainer, GameObject> keyValuePair in this.currentTargets.Where<KeyValuePair<CardContainer, GameObject>>((Func<KeyValuePair<CardContainer, GameObject>, bool>) (pair => (UnityEngine.Object) pair.Value != (UnityEngine.Object) null)))
      keyValuePair.Value.Destroy();
    this.currentTargets = (Dictionary<CardContainer, GameObject>) null;
  }
}
