// Decompiled with JetBrains decompiler
// Type: TraitSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;

#nullable disable
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
