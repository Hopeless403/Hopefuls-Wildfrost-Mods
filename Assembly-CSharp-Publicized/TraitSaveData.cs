// Decompiled with JetBrains decompiler
// Type: TraitSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;

[Serializable]
public class TraitSaveData : ILoadable<CardData.TraitStacks>
{
  public string name;
  public int count;

  public CardData.TraitStacks Load()
  {
    TraitData traitData = AddressableLoader.Get<TraitData>("TraitData", this.name);
    if (!(bool) (UnityEngine.Object) traitData)
      return (CardData.TraitStacks) null;
    return new CardData.TraitStacks()
    {
      data = traitData,
      count = this.count
    };
  }
}
