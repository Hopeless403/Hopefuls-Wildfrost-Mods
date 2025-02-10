// Decompiled with JetBrains decompiler
// Type: CharacterType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterType", menuName = "Character/Type")]
public class CharacterType : ScriptableObject
{
  public string race;
  public string gender;
  public CharacterType.PrefabGroup[] prefabs;
  public CharacterType.SpriteGroup[] sprites;
  public CharacterType.ColorSetGroup[] colorSets;
  public CharacterType.ScaleRange[] scales;

  [Serializable]
  public class PrefabGroup
  {
    public string name;
    public PrefabCollection collection;
  }

  [Serializable]
  public class SpriteGroup
  {
    public string name;
    public SpriteCollection collection;
  }

  [Serializable]
  public class ColorSetGroup
  {
    public string name;
    public ColorSetCollection collection;
  }

  [Serializable]
  public class ScaleRange
  {
    public string name;
    public bool lockRatio;
    public Vector2 xRange;
    public Vector2 yRange;

    public Vector2 Convert()
    {
      if (!this.lockRatio)
        return new Vector2(this.xRange.Random(), this.yRange.Random());
      double num = (double) this.xRange.Random();
      return new Vector2((float) num, (float) num);
    }
  }
}
