// Decompiled with JetBrains decompiler
// Type: BossRewardData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;

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
