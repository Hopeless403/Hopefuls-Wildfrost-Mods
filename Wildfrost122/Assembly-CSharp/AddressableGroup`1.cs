// Decompiled with JetBrains decompiler
// Type: AddressableGroup`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.SceneManagement;

#nullable disable
public class AddressableGroup<T> : IEnumerable<T>, IEnumerable, IDisposable where T : UnityEngine.Object
{
  private readonly List<AsyncOperationHandle<T>> handles;
  private bool subbed;

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

  private void SceneChanged(Scene scene) => this.Dispose();

  private void Release()
  {
    foreach (AsyncOperationHandle<T> handle in this.handles)
      Addressables.Release<T>(handle);
  }

  public IEnumerator<T> GetEnumerator()
  {
    return this.handles.Select<AsyncOperationHandle<T>, T>((Func<AsyncOperationHandle<T>, T>) (a =>
    {
      a.WaitForCompletion();
      return a.Result;
    })).GetEnumerator();
  }

  IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this.handles.GetEnumerator();
}
