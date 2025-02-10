// Decompiled with JetBrains decompiler
// Type: AddressableGroup`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.SceneManagement;

public class AddressableGroup<T> : IEnumerable<T>, IEnumerable, IDisposable where T : UnityEngine.Object
{
  public readonly List<AsyncOperationHandle<T>> handles;
  public bool subbed;

  public AddressableGroup(params AssetReferenceT<T>[] assetRefs)
  {
    this.handles = new List<AsyncOperationHandle<T>>();
    foreach (AssetReferenceT<T> assetRef in assetRefs)
      this.handles.Add(assetRef.LoadAssetAsync());
  }

  public void WaitForCompletion()
  {
    foreach (AsyncOperationHandle<T> handle in this.handles)
      handle.WaitForCompletion();
  }

  public void Dispose()
  {
    this.Release();
    if (!this.subbed)
      return;
    global::Events.OnSceneChanged -= new UnityAction<Scene>(this.SceneChanged);
  }

  public void DisposeOnSceneChange()
  {
    global::Events.OnSceneChanged += new UnityAction<Scene>(this.SceneChanged);
    this.subbed = true;
  }

  public void SceneChanged(Scene scene) => this.Dispose();

  public void Release()
  {
    foreach (AsyncOperationHandle<T> handle in this.handles)
      Addressables.Release<T>(handle);
  }

  public IEnumerator<T> GetEnumerator() => this.handles.Select<AsyncOperationHandle<T>, T>((Func<AsyncOperationHandle<T>, T>) (a =>
  {
    a.WaitForCompletion();
    return a.Result;
  })).GetEnumerator();

  IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this.handles.GetEnumerator();
}
