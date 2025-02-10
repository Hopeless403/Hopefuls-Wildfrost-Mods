// Decompiled with JetBrains decompiler
// Type: AddressableTieredSpriteLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

#nullable disable
public class AddressableTieredSpriteLoader : AddressableAssetLoader<Sprite>
{
  [SerializeField]
  private AddressableTieredSpriteLoader.Tier[] tiers;
  [SerializeField]
  private AddressableTieredSpriteLoader.Type type;
  [SerializeField]
  [ShowIf("IsSpriteRenderer")]
  private SpriteRenderer spriteRenderer;
  [SerializeField]
  [ShowIf("IsImage")]
  private Image image;
  [SerializeField]
  [ShowIf("IsImageSprite")]
  private ImageSprite imageSprite;

  private bool IsSpriteRenderer => this.type == AddressableTieredSpriteLoader.Type.SpriteRenderer;

  private bool IsImage => this.type == AddressableTieredSpriteLoader.Type.Image;

  private bool IsImageSprite => this.type == AddressableTieredSpriteLoader.Type.ImageSprite;

  public override void Load() => this.Load(0);

  public void Load(int tier)
  {
    tier = Mathf.Clamp(tier, 0, this.tiers.Length - 1);
    this.Load(this.tiers[tier]);
  }

  private void Load(AddressableTieredSpriteLoader.Tier tier)
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

  private void SetSprite()
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

  private enum Type
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
