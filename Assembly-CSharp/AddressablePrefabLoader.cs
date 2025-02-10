// Decompiled with JetBrains decompiler
// Type: AddressablePrefabLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.ResourceManagement.AsyncOperations;

public class AddressablePrefabLoader : AddressableAssetLoader<GameObject>
{
  [SerializeField]
  private AssetReferenceGameObject prefabRef;
  [SerializeField]
  private bool setChildIndex;
  [SerializeField]
  [ShowIf("setChildIndex")]
  private int childIndex;
  [SerializeField]
  private UnityEvent<GameObject> onLoad;

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

  private void Loaded()
  {
    if (this.setChildIndex)
      this.operation.Result.transform.SetSiblingIndex(this.childIndex);
    this.onLoad?.Invoke(this.operation.Result);
  }
}
