// Decompiled with JetBrains decompiler
// Type: LeaderProfileData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "New Leader Profile", menuName = "Leader Profile")]
public class LeaderProfileData : ScriptableObject
{
  [SerializeField]
  private SpriteCollection backgroundPool;
  [SerializeField]
  private LeaderProfileData.Collection[] collectionsToAdd;

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

    public enum Type
    {
      Prefab,
      Sprite,
      ColorSet,
    }
  }
}
