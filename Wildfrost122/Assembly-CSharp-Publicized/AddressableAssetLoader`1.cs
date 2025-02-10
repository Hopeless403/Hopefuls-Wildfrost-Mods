// Decompiled with JetBrains decompiler
// Type: AddressableAssetLoader`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

#nullable disable
public abstract class AddressableAssetLoader<T> : MonoBehaviour
{
  [SerializeField]
  public bool instant = true;
  [SerializeField]
  public bool onEnable = true;
  [SerializeField]
  public bool releaseOnDisable = true;
  public AsyncOperationHandle<T> operation;
  public bool loaded;

  public void OnEnable()
  {
    if (!this.onEnable)
      return;
    this.Load();
  }

  public void OnDisable()
  {
    if (!this.releaseOnDisable)
      return;
    this.Release();
  }

  public void OnDestroy()
  {
    if (this.releaseOnDisable)
      return;
    this.Release();
  }

  public void Release()
  {
    if (this.operation.IsValid())
      Addressables.Release<T>(this.operation);
    this.loaded = false;
  }

  public virtual void Load()
  {
  }
}
