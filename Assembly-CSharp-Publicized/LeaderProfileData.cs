// Decompiled with JetBrains decompiler
// Type: LeaderProfileData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(fileName = "New Leader Profile", menuName = "Leader Profile")]
public class LeaderProfileData : ScriptableObject
{
  [SerializeField]
  public SpriteCollection backgroundPool;
  [SerializeField]
  public LeaderProfileData.Collection[] collectionsToAdd;

  public Sprite GetRandomBackground() => this.backgroundPool.RandomItem();

  public void Apply(CharacterType type)
  {
    foreach (LeaderProfileData.Collection collection in this.collectionsToAdd)
      collection.AddTo(type);
  }

  public void UnApply(CharacterType type)
  {
    foreach (LeaderProfileData.Collection collection in this.collectionsToAdd)
      collection.AddTo(type, -1f);
  }

  [Serializable]
  public class Collection
  {
    public string collectionName;
    public LeaderProfileData.Collection.Type type;
    public CollectionModifier modifier;

    public void AddTo(CharacterType characterType, float multiply = 1f)
    {
      switch (this.type)
      {
        case LeaderProfileData.Collection.Type.Prefab:
          PrefabCollection collection1 = ((IEnumerable<CharacterType.PrefabGroup>) characterType.prefabs).First<CharacterType.PrefabGroup>((Func<CharacterType.PrefabGroup, bool>) (a => a.name == this.collectionName)).collection;
          foreach (CollectionModifier.Modify modify in this.modifier.list)
            collection1.AddWeight(modify.index, modify.addWeight * multiply);
          break;
        case LeaderProfileData.Collection.Type.Sprite:
          SpriteCollection collection2 = ((IEnumerable<CharacterType.SpriteGroup>) characterType.sprites).First<CharacterType.SpriteGroup>((Func<CharacterType.SpriteGroup, bool>) (a => a.name == this.collectionName)).collection;
          foreach (CollectionModifier.Modify modify in this.modifier.list)
            collection2.AddWeight(modify.index, modify.addWeight * multiply);
          break;
        case LeaderProfileData.Collection.Type.ColorSet:
          ColorSetCollection collection3 = ((IEnumerable<CharacterType.ColorSetGroup>) characterType.colorSets).First<CharacterType.ColorSetGroup>((Func<CharacterType.ColorSetGroup, bool>) (a => a.name == this.collectionName)).collection;
          foreach (CollectionModifier.Modify modify in this.modifier.list)
            collection3.AddWeight(modify.index, modify.addWeight * multiply);
          break;
      }
    }

    [CompilerGenerated]
    public bool \u003CAddTo\u003Eb__4_0(CharacterType.PrefabGroup a) => a.name == this.collectionName;

    [CompilerGenerated]
    public bool \u003CAddTo\u003Eb__4_1(CharacterType.SpriteGroup a) => a.name == this.collectionName;

    [CompilerGenerated]
    public bool \u003CAddTo\u003Eb__4_2(CharacterType.ColorSetGroup a) => a.name == this.collectionName;

    public enum Type
    {
      Prefab,
      Sprite,
      ColorSet,
    }
  }
}
