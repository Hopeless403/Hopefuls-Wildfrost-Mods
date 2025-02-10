// Decompiled with JetBrains decompiler
// Type: AddressableReleaser
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

#nullable disable
public class AddressableReleaser : MonoBehaviour
{
  [SerializeField]
  public bool releaseOnDisable = true;
  [SerializeField]
  [HideIf("releaseOnDisable")]
  public bool releaseOnDestroy;
  [CompilerGenerated]
  [SerializeField]
  public int \u003CassetsToRelease\u003Ek__BackingField;
  public readonly List<AsyncOperationHandle> handles = new List<AsyncOperationHandle>();

  public int assetsToRelease
  {
    get => this.\u003CassetsToRelease\u003Ek__BackingField;
    set => this.\u003CassetsToRelease\u003Ek__BackingField = value;
  }

  public void Add(AsyncOperationHandle handle)
  {
    this.handles.Add(handle);
    ++this.assetsToRelease;
  }

  public void OnDisable()
  {
    if (!this.releaseOnDisable)
      return;
    this.ReleaseAll();
  }

  public void OnDestroy()
  {
    if (!this.releaseOnDestroy)
      return;
    this.ReleaseAll();
  }

  public void ReleaseAll()
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
