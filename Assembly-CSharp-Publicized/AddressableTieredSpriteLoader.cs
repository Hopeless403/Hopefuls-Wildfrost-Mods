// Decompiled with JetBrains decompiler
// Type: AddressableTieredSpriteLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

public class AddressableTieredSpriteLoader : AddressableAssetLoader<Sprite>
{
  [SerializeField]
  public AddressableTieredSpriteLoader.Tier[] tiers;
  [SerializeField]
  public AddressableTieredSpriteLoader.Type type;
  [SerializeField]
  [ShowIf("IsSpriteRenderer")]
  public SpriteRenderer spriteRenderer;
  [SerializeField]
  [ShowIf("IsImage")]
  public Image image;
  [SerializeField]
  [ShowIf("IsImageSprite")]
  public ImageSprite imageSprite;

  public bool IsSpriteRenderer => this.type == AddressableTieredSpriteLoader.Type.SpriteRenderer;

  public bool IsImage => this.type == AddressableTieredSpriteLoader.Type.Image;

  public bool IsImageSprite => this.type == AddressableTieredSpriteLoader.Type.ImageSprite;

  public override void Load() => this.Load(0);

  public void Load(int tier)
  {
    tier = Mathf.Clamp(tier, 0, this.tiers.Length - 1);
    this.Load(this.tiers[tier]);
  }

  public void Load(AddressableTieredSpriteLoader.Tier tier)
  {
    if (this.loaded)
      return;
    this.operation = tier.atlas ? tier.atlasedSpriteRef.LoadAssetAsync() : tier.spriteRef.LoadAssetAsync();
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
      case AddressableTieredSpriteLoader.Type.SpriteRenderer:
        this.spriteRenderer.sprite = this.operation.Result;
        break;
      case AddressableTieredSpriteLoader.Type.Image:
        this.image.sprite = this.operation.Result;
        break;
      case AddressableTieredSpriteLoader.Type.ImageSprite:
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

  [Serializable]
  public struct Tier
  {
    public bool atlas;
    public AssetReferenceAtlasedSprite atlasedSpriteRef;
    public AssetReferenceSprite spriteRef;
  }
}
