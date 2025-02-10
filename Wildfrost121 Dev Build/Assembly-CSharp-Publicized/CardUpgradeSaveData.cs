// Decompiled with JetBrains decompiler
// Type: CardUpgradeSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;

#nullable disable
[Serializable]
public class CardUpgradeSaveData : ILoadable<CardUpgradeData>
{
  public string name;

  public CardUpgradeSaveData()
  {
  }

  public CardUpgradeSaveData(string name) => this.name = name;

  public CardUpgradeData Load()
  {
    return AddressableLoader.Get<CardUpgradeData>("CardUpgradeData", this.name)?.Clone();
  }
}
