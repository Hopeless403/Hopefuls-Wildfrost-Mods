// Decompiled with JetBrains decompiler
// Type: Pokefrost.AddressableExtMethods
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using BattleEditor;
using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.Linq;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.U2D;

#nullable disable
namespace Pokefrost
{
  internal static class AddressableExtMethods
  {
    internal static SpriteAtlas Sprites;

    internal static void LoadAtlas()
    {
      if (!Addressables.ResourceLocators.Any<IResourceLocator>((Func<IResourceLocator, bool>) (r => r is ResourceLocationMap resourceLocationMap && resourceLocationMap.LocatorId == Pokefrost.Pokefrost.CatalogPath)))
        Addressables.LoadContentCatalogAsync(Pokefrost.Pokefrost.CatalogPath).WaitForCompletion();
      AddressableExtMethods.Sprites = (SpriteAtlas) Addressables.LoadAssetAsync<UnityEngine.Object>((object) "Assets/websiteofsites.pokefrost/PokefrostAtlas.spriteatlas").WaitForCompletion();
    }

    internal static Sprite SaferASprite(string spriteName)
    {
      Sprite sprite = AddressableExtMethods.ASprite(spriteName);
      if ((UnityEngine.Object) sprite == (UnityEngine.Object) null || sprite.texture.width < 10)
        sprite = Pokefrost.Pokefrost.instance.ImagePath(spriteName).ToSprite();
      return sprite;
    }

    internal static Sprite ASprite(string spriteName)
    {
      return AddressableExtMethods.Sprites.GetSprite(spriteName.Replace(".png", ""));
    }

    internal static CardDataBuilder SetASprites(
      this CardDataBuilder b,
      string mainImage,
      string backgroundImage)
    {
      return b.SetSprites(AddressableExtMethods.ASprite(mainImage), AddressableExtMethods.ASprite(backgroundImage));
    }

    internal static CardUpgradeDataBuilder WithAImage(this CardUpgradeDataBuilder b, string image)
    {
      return b.WithImage(AddressableExtMethods.ASprite(image));
    }

    internal static GameModifierDataBuilder ChangeASprites(
      this GameModifierDataBuilder b,
      string bell,
      string dinger)
    {
      b.WithBellSprite(AddressableExtMethods.ASprite(bell));
      if (!dinger.IsNullOrEmpty())
        b.WithDingerSprite(AddressableExtMethods.ASprite(dinger));
      else
        b.WithDingerSprite(Sprite.Create(b._data.bellSprite.texture, new Rect(0.0f, 0.0f, 0.0f, 0.0f), 0.5f * Vector2.one));
      return b.WithBellSprite(AddressableExtMethods.ASprite(bell));
    }

    internal static BattleDataEditor SetASprite(this BattleDataEditor b, string sprite)
    {
      return b.SetSprite(AddressableExtMethods.ASprite(sprite));
    }
  }
}
