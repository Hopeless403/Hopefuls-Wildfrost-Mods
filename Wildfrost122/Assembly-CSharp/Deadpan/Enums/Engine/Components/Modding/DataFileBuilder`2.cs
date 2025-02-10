// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.DataFileBuilder`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using UnityEngine;

#nullable disable
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
      T d = this.BuildInstance();
      this.OnAfterBuildEvent(d);
      return d;
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

    public virtual Y Create(string name)
    {
      if (this.Mod != null)
        name = Extensions.PrefixGUID(name, this.Mod);
      if ((object) this._data != null)
        UnityEngine.Object.Destroy((UnityEngine.Object) this._data);
      this._data = ScriptableObject.CreateInstance<T>();
      this._data.name = name;
      return this as Y;
    }

    public virtual Y Create<X>(string name) where X : T
    {
      if (this.Mod != null)
        name = Extensions.PrefixGUID(name, this.Mod);
      if ((object) this._data != null)
        UnityEngine.Object.Destroy((UnityEngine.Object) this._data);
      this._data = (T) ScriptableObject.CreateInstance<X>();
      this._data.name = name;
      return this as Y;
    }

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
