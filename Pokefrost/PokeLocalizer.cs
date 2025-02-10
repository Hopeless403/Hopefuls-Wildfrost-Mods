// Decompiled with JetBrains decompiler
// Type: Pokefrost.PokeLocalizer
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
  public class PokeLocalizer : Attribute
  {
    public static void Run()
    {
      MethodInfo[] array = ((IEnumerable<Type>) typeof (PokeLocalizer).Assembly.GetTypes()).SelectMany<Type, MethodInfo>((Func<Type, IEnumerable<MethodInfo>>) (t => (IEnumerable<MethodInfo>) t.GetMethods())).Where<MethodInfo>((Func<MethodInfo, bool>) (m => m.GetCustomAttribute<PokeLocalizer>() != null)).ToArray<MethodInfo>();
      Debug.Log((object) string.Format("[Pokefrost] {0}", (object) array.Length));
      foreach (MethodBase methodBase in array)
        methodBase.Invoke((object) null, (object[]) null);
    }
  }
}
