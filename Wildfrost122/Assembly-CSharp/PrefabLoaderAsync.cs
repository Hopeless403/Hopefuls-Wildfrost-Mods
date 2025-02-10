// Decompiled with JetBrains decompiler
// Type: PrefabLoaderAsync
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System.Collections;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.ResourceManagement.AsyncOperations;

#nullable disable
public class PrefabLoaderAsync : MonoBehaviour
{
  [SerializeField]
  private bool onAwake;
  [ShowIf("onAwake")]
  [SerializeField]
  private AssetReferenceGameObject prefabRef;
  [ShowIf("onAwake")]
  [SerializeField]
  private UnityEvent<GameObject> onComplete;
  private AsyncOperationHandle<GameObject> handle;
  private bool busy;

  private void Awake()
  {
    if (!this.onAwake)
      return;
    this.StartCoroutine(this.Load(this.prefabRef));
  }

  public IEnumerator Load(AssetReferenceGameObject prefabRef)
  {
    PrefabLoaderAsync prefabLoaderAsync = this;
    while (prefabLoaderAsync.busy)
      yield return (object) null;
    prefabLoaderAsync.busy = true;
    if (prefabLoaderAsync.handle.IsValid())
      Addressables.Release<GameObject>(prefabLoaderAsync.handle);
    prefabLoaderAsync.handle = prefabRef.InstantiateAsync(prefabLoaderAsync.transform);
    yield return (object) prefabLoaderAsync.handle;
    prefabLoaderAsync.onComplete?.Invoke(prefabLoaderAsync.handle.Result);
    prefabLoaderAsync.busy = false;
  }

  private void OnDestroy()
  {
    if (!this.handle.IsValid())
      return;
    Addressables.Release<GameObject>(this.handle);
  }
}
