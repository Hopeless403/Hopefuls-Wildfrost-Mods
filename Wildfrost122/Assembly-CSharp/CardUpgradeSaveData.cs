// Decompiled with JetBrains decompiler
// Type: CardUpgradeSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

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
