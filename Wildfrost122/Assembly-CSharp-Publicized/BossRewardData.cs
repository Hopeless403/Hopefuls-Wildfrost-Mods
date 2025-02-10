// Decompiled with JetBrains decompiler
// Type: BossRewardData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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
