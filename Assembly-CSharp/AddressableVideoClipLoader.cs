// Decompiled with JetBrains decompiler
// Type: AddressableVideoClipLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.Video;

public class AddressableVideoClipLoader : AddressableAssetLoader<VideoClip>
{
  public AssetReferenceT<VideoClip> videoClipRef;
  [SerializeField]
  private VideoPlayer videoPlayer;

  public override void Load()
  {
    if (this.loaded)
      return;
    this.operation = this.videoClipRef.LoadAssetAsync();
    if (this.instant)
    {
      this.operation.WaitForCompletion();
      this.SetVideoClip();
    }
    else
      this.operation.Completed += (Action<AsyncOperationHandle<VideoClip>>) (_ => this.SetVideoClip());
    this.loaded = true;
  }

  private void SetVideoClip()
  {
    this.videoPlayer.clip = this.operation.Result;
    this.videoPlayer.Play();
  }
}
