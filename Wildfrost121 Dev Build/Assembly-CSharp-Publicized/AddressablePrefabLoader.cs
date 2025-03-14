﻿// Decompiled with JetBrains decompiler
// Type: AddressablePrefabLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.ResourceManagement.AsyncOperations;

#nullable disable
public class AddressablePrefabLoader : AddressableAssetLoader<GameObject>
{
  [SerializeField]
  public AssetReferenceGameObject prefabRef;
  [SerializeField]
  public bool setChildIndex;
  [SerializeField]
  [ShowIf("setChildIndex")]
  public int childIndex;
  [SerializeField]
  public UnityEvent<GameObject> onLoad;

  public override void Load()
  {
    if (this.loaded)
      return;
    this.operation = this.prefabRef.InstantiateAsync(this.transform);
    if (this.instant)
    {
      this.operation.WaitForCompletion();
      this.Loaded();
    }
    else
      this.operation.Completed += (Action<AsyncOperationHandle<GameObject>>) (_ => this.Loaded());
    this.loaded = true;
  }

  public void Loaded()
  {
    if (this.setChildIndex)
      this.operation.Result.transform.SetSiblingIndex(this.childIndex);
    this.onLoad?.Invoke(this.operation.Result);
  }

  [CompilerGenerated]
  public void \u003CLoad\u003Eb__4_0(AsyncOperationHandle<GameObject> _) => this.Loaded();
}
