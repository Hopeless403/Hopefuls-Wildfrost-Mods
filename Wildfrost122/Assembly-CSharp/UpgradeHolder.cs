﻿// Decompiled with JetBrains decompiler
// Type: UpgradeHolder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.ResourceManagement.AsyncOperations;

#nullable disable
public abstract class UpgradeHolder : MonoBehaviour
{
  [SerializeField]
  protected AssetReference prefabRef;
  [SerializeField]
  private CardCharmDragHandler dragHandler;
  [SerializeField]
  protected List<UpgradeDisplay> list = new List<UpgradeDisplay>();
  [SerializeField]
  private bool autoUpdateOverrideInputs;

  [Button(null, EButtonEnableMode.Always)]
  public virtual void SetPositions()
  {
    foreach (RectTransform rectTransform in this.transform)
      rectTransform.anchoredPosition = Vector2.zero;
  }

  public virtual UpgradeDisplay Create(CardUpgradeData upgradeData)
  {
    AsyncOperationHandle<GameObject> asyncOperationHandle = this.prefabRef.InstantiateAsync(this.transform);
    asyncOperationHandle.WaitForCompletion();
    UpgradeDisplay component1 = asyncOperationHandle.Result.GetComponent<UpgradeDisplay>();
    component1.gameObject.SetActive(true);
    component1.SetData(upgradeData);
    component1.name = upgradeData.name;
    if ((bool) (UnityEngine.Object) this.dragHandler)
    {
      CardCharmInteraction component2 = component1.GetComponent<CardCharmInteraction>();
      if (component2 != null)
      {
        component2.dragHandler = this.dragHandler;
        component2.onDrag.AddListener(new UnityAction<UpgradeDisplay>(this.dragHandler.Drag));
        component2.onDragEnd.AddListener(new UnityAction<UpgradeDisplay>(this.dragHandler.Release));
      }
    }
    this.Add(component1);
    return component1;
  }

  public virtual void Add(UpgradeDisplay upgrade) => this.Insert(0, upgrade);

  public virtual void Insert(int index, UpgradeDisplay upgrade)
  {
    this.list.Insert(index, upgrade);
    upgrade.transform.SetParent(this.transform, false);
    upgrade.transform.localPosition = Vector3.zero;
    upgrade.transform.localEulerAngles = Vector3.zero;
    if (!this.autoUpdateOverrideInputs)
      return;
    this.SetInputOverrides();
  }

  public virtual void Remove(UpgradeDisplay upgrade)
  {
    this.list.Remove(upgrade);
    upgrade.transform.SetParent((Transform) null, false);
    if (!this.autoUpdateOverrideInputs)
      return;
    this.SetInputOverrides();
  }

  public virtual void Remove(CardUpgradeData upgradeData)
  {
    UpgradeDisplay upgrade = this.list.Find((Predicate<UpgradeDisplay>) (a => (UnityEngine.Object) a.data == (UnityEngine.Object) upgradeData));
    if (!((UnityEngine.Object) upgrade != (UnityEngine.Object) null))
      return;
    this.Remove(upgrade);
  }

  public virtual int IndexOf(UpgradeDisplay upgrade) => this.list.IndexOf(upgrade);

  public virtual void Clear()
  {
    this.list.Clear();
    this.transform.DestroyAllChildren();
  }

  public abstract void SetInputOverrides();
}
