// Decompiled with JetBrains decompiler
// Type: AddressableSpriteLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

public class AddressableSpriteLoader : AddressableAssetLoader<Sprite>
{
  [SerializeField]
  private bool atlas = true;
  [ShowIf("atlas")]
  public AssetReferenceAtlasedSprite atlasedSpriteRef;
  [HideIf("atlas")]
  public AssetReferenceSprite spriteRef;
  [SerializeField]
  private AddressableSpriteLoader.Type type;
  [SerializeField]
  [ShowIf("IsSpriteRenderer")]
  private SpriteRenderer spriteRenderer;
  [SerializeField]
  [ShowIf("IsImage")]
  private Image image;
  [SerializeField]
  [ShowIf("IsImageSprite")]
  private ImageSprite imageSprite;

  private bool IsSpriteRenderer => this.type == AddressableSpriteLoader.Type.SpriteRenderer;

  private bool IsImage => this.type == AddressableSpriteLoader.Type.Image;

  private bool IsImageSprite => this.type == AddressableSpriteLoader.Type.ImageSprite;

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

  private void SetSprite()
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

  private enum Type
  {
    SpriteRenderer,
    Image,
    ImageSprite,
  }
}
