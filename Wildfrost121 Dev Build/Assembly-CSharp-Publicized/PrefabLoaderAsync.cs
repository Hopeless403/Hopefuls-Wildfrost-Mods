// Decompiled with JetBrains decompiler
// Type: PrefabLoaderAsync
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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
  public bool onAwake;
  [ShowIf("onAwake")]
  [SerializeField]
  public AssetReferenceGameObject prefabRef;
  [ShowIf("onAwake")]
  [SerializeField]
  public UnityEvent<GameObject> onComplete;
  public AsyncOperationHandle<GameObject> handle;
  public bool busy;

  public void Awake()
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

  public void OnDestroy()
  {
    if (!this.handle.IsValid())
      return;
    Addressables.Release<GameObject>(this.handle);
  }
}
