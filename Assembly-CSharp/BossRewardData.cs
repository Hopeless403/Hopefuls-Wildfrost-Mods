// Decompiled with JetBrains decompiler
// Type: BossRewardData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

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
