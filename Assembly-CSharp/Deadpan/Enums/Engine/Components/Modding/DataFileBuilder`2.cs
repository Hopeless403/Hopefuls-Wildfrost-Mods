// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.DataFileBuilder`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;

namespace Deadpan.Enums.Engine.Components.Modding
{
  public abstract class DataFileBuilder<T, Y>
    where T : DataFile
    where Y : DataFileBuilder<T, Y>, new()
  {
    internal T _data;
    public WildfrostMod Mod;

    protected virtual T BuildInstance() => this._data.InstantiateKeepName<T>();

    public T Build()
    {
      this.OnAfterBuildEvent(this._data);
      return this.BuildInstance();
    }

    protected DataFileBuilder(WildfrostMod mod) => this.Mod = mod;

    protected DataFileBuilder()
    {
    }

    public Y FreeModify(Action<T> action)
    {
      if (action != null)
        action(this._data);
      return (Y) this;
    }

    public Y FreeModify<D>(Action<D> action) where D : T
    {
      if (action != null)
        action((object) this._data as D);
      return (Y) this;
    }

    public event DataFileBuilder<T, Y>.AfterBuildDelegate AfterBuildEvent;

    public event DataFileBuilder<T, Y>.AfterBuildDelegate AfterAllModBuildsEvent;

    public abstract Y Create(string name);

    public static implicit operator T(DataFileBuilder<T, Y> t) => t.Build();

    public virtual Y SubscribeToBuildEvent(DataFileBuilder<T, Y>.AfterBuildDelegate d)
    {
      this.AfterBuildEvent += d;
      return (Y) this;
    }

    public virtual Y UnsubscribeToBuildEvent(DataFileBuilder<T, Y>.AfterBuildDelegate d)
    {
      this.AfterBuildEvent -= d;
      return (Y) this;
    }

    public virtual Y SubscribeToAfterAllBuildEvent(DataFileBuilder<T, Y>.AfterBuildDelegate d)
    {
      this.AfterAllModBuildsEvent += d;
      return (Y) this;
    }

    public virtual Y UnubscribeToAfterAllBuildEvent(DataFileBuilder<T, Y>.AfterBuildDelegate d)
    {
      this.AfterAllModBuildsEvent -= d;
      return (Y) this;
    }

    protected virtual void OnAfterBuildEvent(T d)
    {
      DataFileBuilder<T, Y>.AfterBuildDelegate afterBuildEvent = this.AfterBuildEvent;
      if (afterBuildEvent == null)
        return;
      afterBuildEvent(d);
    }

    internal virtual void OnAfterAllModBuildsEvent(T d)
    {
      DataFileBuilder<T, Y>.AfterBuildDelegate allModBuildsEvent = this.AfterAllModBuildsEvent;
      if (allModBuildsEvent == null)
        return;
      allModBuildsEvent(d);
    }

    public delegate void AfterBuildDelegate(T d)
      where T : DataFile
      where Y : DataFileBuilder<T, Y>, new();
  }
}
