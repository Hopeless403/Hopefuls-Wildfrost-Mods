// Decompiled with JetBrains decompiler
// Type: TraitSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;

[Serializable]
public class TraitSaveData : ILoadable<CardData.TraitStacks>
{
  public string name;
  public int count;

  public CardData.TraitStacks Load() => new CardData.TraitStacks()
  {
    data = AddressableLoader.Get<TraitData>("TraitData", this.name),
    count = this.count
  };
}
