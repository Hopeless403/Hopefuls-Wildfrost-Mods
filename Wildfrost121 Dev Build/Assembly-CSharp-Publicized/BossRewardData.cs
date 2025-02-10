// Decompiled with JetBrains decompiler
// Type: BossRewardData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
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
