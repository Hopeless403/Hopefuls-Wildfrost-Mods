// Decompiled with JetBrains decompiler
// Type: AddressableAssetLoader`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public abstract class AddressableAssetLoader<T> : MonoBehaviour
{
  [SerializeField]
  protected bool instant = true;
  [SerializeField]
  private bool onEnable = true;
  [SerializeField]
  private bool releaseOnDisable = true;
  protected AsyncOperationHandle<T> operation;
  protected bool loaded;

  private void OnEnable()
  {
    if (!this.onEnable)
      return;
    this.Load();
  }

  private void OnDisable()
  {
    if (!this.releaseOnDisable)
      return;
    this.Release();
  }

  private void OnDestroy()
  {
    if (this.releaseOnDisable)
      return;
    this.Release();
  }

  protected void Release()
  {
    if (this.operation.IsValid())
      Addressables.Release<T>(this.operation);
    this.loaded = false;
  }

  public virtual void Load()
  {
  }
}
