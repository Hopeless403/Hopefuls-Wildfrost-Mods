// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.ChallengeListenerBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

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

    public override ChallengeListenerBuilder Create(string name)
    {
      if (this.Mod != null)
        name = Extensions.PrefixGUID(name, this.Mod);
      if (this._data != null)
        Object.Destroy((Object) this._data);
      this._data = ScriptableObject.CreateInstance<ChallengeListener>();
      this._data.name = name;
      return this;
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
