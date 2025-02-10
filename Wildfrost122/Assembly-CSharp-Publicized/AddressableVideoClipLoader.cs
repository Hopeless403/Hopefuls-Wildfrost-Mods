// Decompiled with JetBrains decompiler
// Type: AddressableVideoClipLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.Video;

#nullable disable
public class AddressableVideoClipLoader : AddressableAssetLoader<VideoClip>
{
  public AssetReferenceT<VideoClip> videoClipRef;
  [SerializeField]
  public VideoPlayer videoPlayer;

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

  public void SetVideoClip()
  {
    this.videoPlayer.clip = this.operation.Result;
    this.videoPlayer.Play();
  }

  [CompilerGenerated]
  public void \u003CLoad\u003Eb__2_0(AsyncOperationHandle<VideoClip> _) => this.SetVideoClip();
}
