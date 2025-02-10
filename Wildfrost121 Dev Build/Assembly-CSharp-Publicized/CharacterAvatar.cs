// Decompiled with JetBrains decompiler
// Type: CharacterAvatar
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;
using Unity.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class CharacterAvatar : MonoBehaviour
{
  public AvatarPart root;
  public Texture2D paletteTexture;
  public Material recolourMaterial;
  public Material recolourMaterialCopy;

  public void OnDestroy()
  {
    if ((bool) (UnityEngine.Object) this.paletteTexture)
      UnityEngine.Object.Destroy((UnityEngine.Object) this.paletteTexture);
    if (!(bool) (UnityEngine.Object) this.recolourMaterialCopy)
      return;
    UnityEngine.Object.Destroy((UnityEngine.Object) this.recolourMaterialCopy);
  }

  public void UpdateDisplay(CharacterData data)
  {
    CharacterType type = AssetLoader.Lookup<CharacterType>("CharacterTypes", data.race + data.gender);
    if (!(bool) (UnityEngine.Object) type)
      return;
    Transform anchor1 = this.root.GetAnchor("body");
    if (anchor1 == null)
      return;
    anchor1.DestroyAllChildren();
    UnityEngine.Object.Destroy((UnityEngine.Object) this.paletteTexture);
    GameObject prefab1 = CharacterAvatar.GetPrefab(type, "Body", data.bodyIndex);
    if (!(bool) (UnityEngine.Object) prefab1)
      return;
    GameObject gameObject1 = UnityEngine.Object.Instantiate<GameObject>(prefab1, anchor1);
    Transform transform = gameObject1.transform;
    transform.localScale = (Vector3) ((Vector2) transform.localScale * data.bodyScale);
    AvatarPart component1 = gameObject1.GetComponent<AvatarPart>();
    if (component1 != null)
    {
      GameObject prefab2 = CharacterAvatar.GetPrefab(type, "Head", data.headIndex);
      if ((bool) (UnityEngine.Object) prefab2)
      {
        Transform anchor2 = component1.GetAnchor("head");
        if (anchor2 != null)
        {
          GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(prefab2, anchor2);
          gameObject2.transform.localScale = (Vector3) ((Vector2) gameObject2.transform.localScale * data.headScale / (Vector2) gameObject1.transform.localScale);
          AvatarPart component2 = gameObject2.GetComponent<AvatarPart>();
          if (component2 != null)
          {
            Sprite sprite1 = CharacterAvatar.GetSprite(type, "Mouth", data.mouthIndex);
            Sprite sprite2 = CharacterAvatar.GetSprite(type, "Nose", data.noseIndex);
            Sprite sprite3 = CharacterAvatar.GetSprite(type, "Eyebrows", data.eyebrowIndex);
            Sprite sprite4 = CharacterAvatar.GetSprite(type, "Ears", data.earIndex);
            Sprite sprite5 = CharacterAvatar.GetSprite(type, "HairTop", data.hairTopIndex);
            Sprite sprite6 = CharacterAvatar.GetSprite(type, "HairBack", data.hairBackIndex);
            Sprite sprite7 = CharacterAvatar.GetSprite(type, "Beard", data.beardIndex);
            Sprite sprite8 = CharacterAvatar.GetSprite(type, "Markings", data.markingsIndex);
            CharacterAvatar.SetSprite(type, component2, "mouth", sprite1, data.mouthScale);
            CharacterAvatar.SetSprite(type, component2, "nose", sprite2, data.noseScale);
            CharacterAvatar.SetSprite(type, component2, "eyebrows", sprite3, data.eyebrowScale);
            CharacterAvatar.SetSprite(type, component2, "ears", sprite4, data.earScale);
            CharacterAvatar.SetSprite(type, component2, "hairtop", sprite5, data.hairScale);
            CharacterAvatar.SetSprite(type, component2, "hairback", sprite6, data.hairScale);
            CharacterAvatar.SetSprite(type, component2, "beard", sprite7, Vector2.one);
            CharacterAvatar.SetSprite(type, component2, "markings", sprite8, Vector2.one);
            GameObject prefab3 = CharacterAvatar.GetPrefab(type, "Eyes", data.eyesIndex);
            if ((bool) (UnityEngine.Object) prefab3)
            {
              Transform anchor3 = component2.GetAnchor("eyes");
              if (anchor3 != null)
                UnityEngine.Object.Instantiate<GameObject>(prefab3, anchor3);
            }
          }
        }
      }
      GameObject prefab4 = CharacterAvatar.GetPrefab(type, "Weapon1", data.weapon1Index);
      if (prefab4 != null)
      {
        Transform anchor4 = component1.GetAnchor("weapon1");
        if (anchor4 != null)
        {
          UnityEngine.Object.Instantiate<GameObject>(prefab4, anchor4);
          goto label_16;
        }
      }
      GameObject prefab5 = CharacterAvatar.GetPrefab(type, "Weapon2", data.weapon2Index);
      if (prefab5 != null)
      {
        Transform anchor5 = component1.GetAnchor("weapon2");
        if (anchor5 != null)
          UnityEngine.Object.Instantiate<GameObject>(prefab5, anchor5);
      }
    }
label_16:
    Texture2D texture2D = new Texture2D(25, 1, TextureFormat.RGBA32, false);
    texture2D.filterMode = FilterMode.Point;
    this.paletteTexture = texture2D;
    NativeArray<Color32> rawTextureData = this.paletteTexture.GetRawTextureData<Color32>();
    ColorSet colorSet1 = CharacterAvatar.GetColorSet(type, "ClothingColour", data.clothingColorIndex);
    ColorSet colorSet2 = CharacterAvatar.GetColorSet(type, "HairColour", data.hairColorIndex);
    ColorSet colorSet3 = CharacterAvatar.GetColorSet(type, "EyeColour", data.eyeColorIndex);
    ColorSet colorSet4 = CharacterAvatar.GetColorSet(type, "SkinColour", data.skinColorIndex);
    ColorSet colorSet5 = CharacterAvatar.GetColorSet(type, "MarkingColour", data.markingsColorIndex);
    CharacterAvatar.SetTexturePixels(type, this.paletteTexture, rawTextureData, 0, colorSet1);
    CharacterAvatar.SetTexturePixels(type, this.paletteTexture, rawTextureData, 4, colorSet2);
    CharacterAvatar.SetTexturePixels(type, this.paletteTexture, rawTextureData, 13, colorSet3);
    CharacterAvatar.SetTexturePixels(type, this.paletteTexture, rawTextureData, 14, colorSet4);
    CharacterAvatar.SetTexturePixels(type, this.paletteTexture, rawTextureData, 17, colorSet5);
    this.paletteTexture.Apply();
    if ((bool) (UnityEngine.Object) this.recolourMaterialCopy)
      UnityEngine.Object.Destroy((UnityEngine.Object) this.recolourMaterialCopy);
    this.recolourMaterialCopy = UnityEngine.Object.Instantiate<Material>(this.recolourMaterial);
    this.recolourMaterialCopy.SetTexture("_PaletteTex", (Texture) this.paletteTexture);
    foreach (Image componentsInChild in this.GetComponentsInChildren<Image>())
    {
      if (!componentsInChild.TryGetComponent<Mask>(out Mask _))
        componentsInChild.material = this.recolourMaterialCopy;
    }
  }

  public static GameObject GetPrefab(CharacterType type, string name, int index)
  {
    if (index >= 0)
    {
      CharacterType.PrefabGroup prefabGroup = ((IEnumerable<CharacterType.PrefabGroup>) type.prefabs).FirstOrDefault<CharacterType.PrefabGroup>((Func<CharacterType.PrefabGroup, bool>) (a => a.name == name));
      if (prefabGroup != null)
        return prefabGroup.collection[index];
    }
    return (GameObject) null;
  }

  public static Sprite GetSprite(CharacterType type, string name, int index)
  {
    if (index >= 0)
    {
      CharacterType.SpriteGroup spriteGroup = ((IEnumerable<CharacterType.SpriteGroup>) type.sprites).FirstOrDefault<CharacterType.SpriteGroup>((Func<CharacterType.SpriteGroup, bool>) (a => a.name == name));
      if (spriteGroup != null)
        return spriteGroup.collection[index];
    }
    return (Sprite) null;
  }

  public static ColorSet GetColorSet(CharacterType type, string name, int index)
  {
    if (index >= 0)
    {
      CharacterType.ColorSetGroup colorSetGroup = ((IEnumerable<CharacterType.ColorSetGroup>) type.colorSets).FirstOrDefault<CharacterType.ColorSetGroup>((Func<CharacterType.ColorSetGroup, bool>) (a => a.name == name));
      if (colorSetGroup != null)
        return colorSetGroup.collection[index];
    }
    return (ColorSet) null;
  }

  public static void SetSprite(
    CharacterType type,
    AvatarPart part,
    string partName,
    Sprite sprite,
    Vector2 scale)
  {
    AvatarPart.Part part1 = part.Get(partName);
    if (!(bool) (UnityEngine.Object) sprite)
      part1.Disable();
    else
      part1.Set(sprite, scale);
  }

  public static void SetSprite(
    CharacterType type,
    AvatarPart part,
    Sprite sprite,
    Vector2 scale,
    params string[] partNames)
  {
    foreach (string partName in partNames)
    {
      AvatarPart.Part part1 = part.Get(partName);
      if (!(bool) (UnityEngine.Object) sprite)
        part1.Disable();
      else
        part1.Set(sprite, scale);
    }
  }

  public static void SetTexturePixels(
    CharacterType type,
    Texture2D texture,
    NativeArray<Color32> data,
    int startX,
    ColorSet colorSet)
  {
    foreach (Color color in colorSet.set)
    {
      Color32 color32 = (Color32) color;
      data[startX++] = color32;
    }
  }
}
