// Decompiled with JetBrains decompiler
// Type: BossRewardData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;

#nullable disable
public abstract class BossRewardData : DataFile
{
  public abstract BossRewardData.Data Pull();

  public enum Type
  {
    Modifier,
    Charm,
    Crown,
  }

  [Serializable]
  public abstract class Data
  {
    public BossRewardData.Type type;

    public abstract void Select();
  }
}
