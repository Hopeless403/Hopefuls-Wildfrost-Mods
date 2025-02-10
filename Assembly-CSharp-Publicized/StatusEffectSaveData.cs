// Decompiled with JetBrains decompiler
// Type: StatusEffectSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;

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
