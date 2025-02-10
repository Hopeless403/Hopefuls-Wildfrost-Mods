// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.ChallengeListenerBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

#nullable disable
namespace Deadpan.Enums.Engine.Components.Modding
{
  public class ChallengeListenerBuilder : 
    DataFileBuilder<ChallengeListener, ChallengeListenerBuilder>
  {
    public ChallengeListenerBuilder(WildfrostMod mod)
      : base(mod)
    {
    }

    public ChallengeListenerBuilder()
    {
    }

    public ChallengeListenerBuilder WithKey(string key)
    {
      this._data.key = key;
      this._data.hasKey = true;
      return this;
    }

    public ChallengeListenerBuilder WithCheckType(ChallengeListener.CheckType type)
    {
      this._data.checkType = type;
      return this;
    }

    public ChallengeListenerBuilder WithStat(string stat)
    {
      this._data.stat = stat;
      return this;
    }

    public ChallengeListenerBuilder WithStat(int toReach)
    {
      this._data.target = toReach;
      return this;
    }
  }
}
