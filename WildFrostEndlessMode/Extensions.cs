// Decompiled with JetBrains decompiler
// Type: WildFrostEndlessMode.Extensions
// Assembly: WildFrostEndlessMode, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D76FD999-83C4-43C3-B678-69DE97BDCC32
// Assembly location: C:\Users\harri\Downloads\WildFrostEndlessMode.dll

using BepInEx.Logging;
using Il2CppSystem.Collections.Generic;
using System;


#nullable enable
namespace WildFrostEndlessMode
{
  public static class Extensions
  {
    public static T Find<T>(this List<T> l, Predicate<T> p)
    {
      T obj1;
      for (int index = 0; index < l.Count; ++index)
      {
        T obj2 = l.ToArray()[index];
        ManualLogSource log = EndlessModeMod.Instance.Log;
        obj1 = obj2;
        string str = obj1?.ToString() + " " + index.ToString();
        log.LogInfo((object) str);
        if (p(obj2))
          return obj2;
      }
      obj1 = default (T);
      return obj1;
    }
  }
}
