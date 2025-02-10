// Decompiled with JetBrains decompiler
// Type: StatusEffectSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;

#nullable disable
[Serializable]
public class StatusEffectSaveData : ILoadable<CardData.StatusEffectStacks>
{
  public string name;
  public int count;

  public CardData.StatusEffectStacks Load()
  {
    StatusEffectData statusEffectData = AddressableLoader.Get<StatusEffectData>("StatusEffectData", this.name);
    if (!(bool) (UnityEngine.Object) statusEffectData)
      return (CardData.StatusEffectStacks) null;
    return new CardData.StatusEffectStacks()
    {
      data = statusEffectData,
      count = this.count
    };
  }
}
