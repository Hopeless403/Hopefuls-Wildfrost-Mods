// Decompiled with JetBrains decompiler
// Type: AddressableReleaser
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

#nullable disable
public class AddressableReleaser : MonoBehaviour
{
  [SerializeField]
  private bool releaseOnDisable = true;
  [SerializeField]
  [HideIf("releaseOnDisable")]
  private bool releaseOnDestroy;
  private readonly List<AsyncOperationHandle> handles = new List<AsyncOperationHandle>();

  [field: SerializeField]
  public int assetsToRelease { get; private set; }

  public void Add(AsyncOperationHandle handle)
  {
    this.handles.Add(handle);
    ++this.assetsToRelease;
  }

  private void OnDisable()
  {
    if (!this.releaseOnDisable)
      return;
    this.ReleaseAll();
  }

  private void OnDestroy()
  {
    if (!this.releaseOnDestroy)
      return;
    this.ReleaseAll();
  }

  private void ReleaseAll()
  {
    foreach (AsyncOperationHandle handle in this.handles)
    {
      Debug.Log((object) string.Format("→ Asset Releaser Releasing Asset: {0}", handle.Result));
      Addressables.Release(handle);
    }
    this.handles.Clear();
    this.assetsToRelease = 0;
  }
}
