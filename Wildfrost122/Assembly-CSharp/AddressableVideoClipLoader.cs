// Decompiled with JetBrains decompiler
// Type: AddressableVideoClipLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.Video;

#nullable disable
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
