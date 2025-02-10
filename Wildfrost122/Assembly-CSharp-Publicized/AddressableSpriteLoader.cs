// Decompiled with JetBrains decompiler
// Type: AddressableSpriteLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

#nullable disable
public class AddressableSpriteLoader : AddressableAssetLoader<Sprite>
{
  [SerializeField]
  public bool atlas = true;
  [ShowIf("atlas")]
  public AssetReferenceAtlasedSprite atlasedSpriteRef;
  [HideIf("atlas")]
  public AssetReferenceSprite spriteRef;
  [SerializeField]
  public AddressableSpriteLoader.Type type;
  [SerializeField]
  [ShowIf("IsSpriteRenderer")]
  public SpriteRenderer spriteRenderer;
  [SerializeField]
  [ShowIf("IsImage")]
  public Image image;
  [SerializeField]
  [ShowIf("IsImageSprite")]
  public ImageSprite imageSprite;

  public bool IsSpriteRenderer => this.type == AddressableSpriteLoader.Type.SpriteRenderer;

  public bool IsImage => this.type == AddressableSpriteLoader.Type.Image;

  public bool IsImageSprite => this.type == AddressableSpriteLoader.Type.ImageSprite;

  public override void Load()
  {
    if (this.loaded)
      return;
    this.operation = this.atlas ? this.atlasedSpriteRef.LoadAssetAsync() : this.spriteRef.LoadAssetAsync();
    if (this.instant)
    {
      this.operation.WaitForCompletion();
      this.SetSprite();
    }
    else
      this.operation.Completed += (Action<AsyncOperationHandle<Sprite>>) (_ => this.SetSprite());
    this.loaded = true;
  }

  public void SetSprite()
  {
    switch (this.type)
    {
      case AddressableSpriteLoader.Type.SpriteRenderer:
        this.spriteRenderer.sprite = this.operation.Result;
        break;
      case AddressableSpriteLoader.Type.Image:
        this.image.sprite = this.operation.Result;
        break;
      case AddressableSpriteLoader.Type.ImageSprite:
        this.imageSprite.SetSprite(this.operation.Result);
        break;
    }
  }

  [CompilerGenerated]
  public void \u003CLoad\u003Eb__14_0(AsyncOperationHandle<Sprite> _) => this.SetSprite();

  public enum Type
  {
    SpriteRenderer,
    Image,
    ImageSprite,
  }
}
