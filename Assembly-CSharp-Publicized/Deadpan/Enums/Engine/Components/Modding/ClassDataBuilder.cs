// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.ClassDataBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using FMODUnity;
using UnityEngine;

namespace Deadpan.Enums.Engine.Components.Modding
{
  public class ClassDataBuilder : DataFileBuilder<ClassData, ClassDataBuilder>
  {
    public ClassDataBuilder(WildfrostMod mod)
      : base(mod)
    {
    }

    public ClassDataBuilder()
    {
    }

    public ClassDataBuilder WithRequiresUnlock(UnlockData requiresUnlock)
    {
      this._data.requiresUnlock = requiresUnlock;
      return this;
    }

    public ClassDataBuilder WithStartingInventory(Inventory startingInventory)
    {
      this._data.startingInventory = startingInventory;
      return this;
    }

    public ClassDataBuilder WithLeaders(params CardData[] leaders)
    {
      this._data.leaders = leaders;
      return this;
    }

    public ClassDataBuilder WithCharacterPrefab(Character characterPrefab)
    {
      this._data.characterPrefab = characterPrefab;
      return this;
    }

    public ClassDataBuilder WithRewardPools(params RewardPool[] rewardPools)
    {
      this._data.rewardPools = rewardPools;
      return this;
    }

    public ClassDataBuilder WithSelectSfxEvent(EventReference selectSfxEvent)
    {
      this._data.selectSfxEvent = selectSfxEvent;
      return this;
    }

    public ClassDataBuilder WithFlag(Sprite flag)
    {
      this._data.flag = flag;
      return this;
    }

    public ClassDataBuilder WithFlag(string flag)
    {
      this._data.flag = this.Mod.GetImageSprite(flag);
      return this;
    }
  }
}
