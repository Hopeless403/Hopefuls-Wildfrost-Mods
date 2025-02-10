// Decompiled with JetBrains decompiler
// Type: StatusEffectSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;

[Serializable]
public class StatusEffectSaveData : ILoadable<CardData.StatusEffectStacks>
{
  public string name;
  public int count;

  public CardData.StatusEffectStacks Load() => new CardData.StatusEffectStacks()
  {
    data = AddressableLoader.Get<StatusEffectData>("StatusEffectData", this.name),
    count = this.count
  };
}
