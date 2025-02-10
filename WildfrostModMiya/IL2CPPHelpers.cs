// Decompiled with JetBrains decompiler
// Type: WildfrostModMiya.IL2CPPHelpers
// Assembly: WildfrostModMiya, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 51F56119-3F77-414A-8824-BFF112DF055A
// Assembly location: C:\Users\harri\Downloads\Wildfrost v1.0.4\BepInEx\plugins\WildfrostModMiya.dll

using Il2CppSystem.Collections.Generic;
using System;

namespace WildfrostModMiya
{
  public static class IL2CPPHelpers
  {
    public static T Find<T>(this List<T> list, Predicate<T> p)
    {
      foreach (T obj in list)
      {
        if (p(obj))
          return obj;
      }
      return default (T);
    }
  }
}
