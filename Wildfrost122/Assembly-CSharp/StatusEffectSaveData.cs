// Decompiled with JetBrains decompiler
// Type: StatusEffectSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

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
