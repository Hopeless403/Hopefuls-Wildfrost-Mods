// Decompiled with JetBrains decompiler
// Type: CharacterData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
[Serializable]
public class CharacterData
{
  public string title;
  public string race;
  public string gender;
  [Header("Part Indices")]
  public int headIndex;
  public int bodyIndex;
  public int weapon1Index;
  public int weapon2Index;
  public int eyesIndex;
  public int mouthIndex;
  public int noseIndex;
  public int eyebrowIndex;
  public int earIndex;
  public int hairBackIndex;
  public int hairTopIndex;
  public int beardIndex;
  public int markingsIndex;
  public int clothingColorIndex;
  public int hairColorIndex;
  public int eyeColorIndex;
  public int skinColorIndex;
  public int markingsColorIndex;
  [Header("Scale")]
  public Vector2 bodyScale = Vector2.one;
  public Vector2 headScale = Vector2.one;
  public Vector2 eyeScale = Vector2.one;
  public Vector2 eyebrowScale = Vector2.one;
  public Vector2 noseScale = Vector2.one;
  public Vector2 mouthScale = Vector2.one;
  public Vector2 earScale = Vector2.one;
  public Vector2 hairScale = Vector2.one;

  public void Randomize(
    CharacterType type,
    bool lockTitle = false,
    bool lockBody = false,
    bool lockHead = false,
    bool lockEyes = false,
    bool lockEyebrows = false,
    bool lockMouth = false,
    bool lockNose = false,
    bool lockEars = false,
    bool lockHair = false,
    bool lockHairBack = false,
    bool lockBeard = false,
    bool lockHairColour = false,
    bool lockEyeColour = false,
    bool lockSkinColour = false,
    bool lockClothingColour = false,
    bool lockWeapon = false,
    bool lockMarkings = false,
    bool lockMarkingsColour = false)
  {
    if (!lockTitle)
      this.title = Names.Pull(this.race, this.gender);
    this.SetRandomPrefab(lockBody, type, "Body", ref this.bodyIndex);
    this.SetRandomPrefab(lockHead, type, "Head", ref this.headIndex);
    this.SetRandomPrefab(lockWeapon, type, "Weapon1", ref this.weapon1Index);
    this.SetRandomPrefab(lockWeapon, type, "Weapon2", ref this.weapon2Index);
    this.SetRandomPrefab(lockEyes, type, "Eyes", ref this.eyesIndex);
    this.SetRandomSprite(lockEyebrows, type, "Eyebrows", ref this.eyebrowIndex);
    this.SetRandomSprite(lockMouth, type, "Mouth", ref this.mouthIndex);
    this.SetRandomSprite(lockNose, type, "Nose", ref this.noseIndex);
    this.SetRandomSprite(lockEars, type, "Ears", ref this.earIndex);
    this.SetRandomSprite(lockHair, type, "HairTop", ref this.hairTopIndex);
    this.SetRandomSprite(lockHairBack, type, "HairBack", ref this.hairBackIndex);
    this.SetRandomSprite(lockBeard, type, "Beard", ref this.beardIndex);
    this.SetRandomSprite(lockMarkings, type, "Markings", ref this.markingsIndex);
    this.SetRandomColorSet(lockHairColour, type, "HairColour", ref this.hairColorIndex);
    this.SetRandomColorSet(lockEyeColour, type, "EyeColour", ref this.eyeColorIndex);
    this.SetRandomColorSet(lockSkinColour, type, "SkinColour", ref this.skinColorIndex);
    this.SetRandomColorSet(lockClothingColour, type, "ClothingColour", ref this.clothingColorIndex);
    this.SetRandomColorSet(lockMarkingsColour, type, "MarkingColour", ref this.markingsColorIndex);
    this.SetScale(false, type, "Body", ref this.bodyScale);
    this.SetScale(false, type, "Head", ref this.headScale);
    this.SetScale(false, type, "Eyes", ref this.eyeScale);
    this.SetScale(false, type, "Mouth", ref this.mouthScale);
    this.SetScale(false, type, "Nose", ref this.noseScale);
    this.SetScale(false, type, "Eyebrows", ref this.eyebrowScale);
    this.SetScale(false, type, "Ears", ref this.earScale);
    this.SetScale(false, type, "Hair", ref this.hairScale);
  }

  private void SetRandomPrefab(bool locked, CharacterType type, string name, ref int index)
  {
    if (locked)
      return;
    CharacterType.PrefabGroup prefabGroup = ((IEnumerable<CharacterType.PrefabGroup>) type.prefabs).FirstOrDefault<CharacterType.PrefabGroup>((Func<CharacterType.PrefabGroup, bool>) (a => a.name == name));
    if (prefabGroup == null)
      return;
    index = prefabGroup.collection.RandomIndex();
  }

  private void SetRandomSprite(bool locked, CharacterType type, string name, ref int index)
  {
    if (locked)
      return;
    CharacterType.SpriteGroup spriteGroup = ((IEnumerable<CharacterType.SpriteGroup>) type.sprites).FirstOrDefault<CharacterType.SpriteGroup>((Func<CharacterType.SpriteGroup, bool>) (a => a.name == name));
    if (spriteGroup == null)
      return;
    index = spriteGroup.collection.RandomIndex();
  }

  private void SetRandomColorSet(bool locked, CharacterType type, string name, ref int index)
  {
    if (locked)
      return;
    CharacterType.ColorSetGroup colorSetGroup = ((IEnumerable<CharacterType.ColorSetGroup>) type.colorSets).FirstOrDefault<CharacterType.ColorSetGroup>((Func<CharacterType.ColorSetGroup, bool>) (a => a.name == name));
    if (colorSetGroup == null)
      return;
    index = colorSetGroup.collection.RandomIndex();
  }

  private void SetScale(bool locked, CharacterType type, string name, ref Vector2 scale)
  {
    if (locked)
      return;
    CharacterType.ScaleRange scaleRange = ((IEnumerable<CharacterType.ScaleRange>) type.scales).FirstOrDefault<CharacterType.ScaleRange>((Func<CharacterType.ScaleRange, bool>) (a => a.name == name));
    if (scaleRange == null)
      return;
    scale = scaleRange.Convert();
  }
}
