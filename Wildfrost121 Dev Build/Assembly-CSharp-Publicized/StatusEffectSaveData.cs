// Decompiled with JetBrains decompiler
// Type: StatusEffectSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
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
