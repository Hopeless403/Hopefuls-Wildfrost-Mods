// Decompiled with JetBrains decompiler
// Type: CardUpgradeSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
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
