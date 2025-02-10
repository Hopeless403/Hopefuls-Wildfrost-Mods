// Decompiled with JetBrains decompiler
// Type: GenericCompare`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

#nullable disable
public class GenericCompare<T> : IComparer<T>
{
  [CompilerGenerated]
  public Func<T, T, int> \u003CComparerFunction\u003Ek__BackingField;

  public Func<T, T, int> ComparerFunction
  {
    set => this.\u003CComparerFunction\u003Ek__BackingField = value;
    get => this.\u003CComparerFunction\u003Ek__BackingField;
  }

  public GenericCompare(Func<T, T, int> comparerFunction)
  {
    this.ComparerFunction = comparerFunction;
  }

  public int Compare(T x, T y)
  {
    if ((object) x == null || (object) y == null)
    {
      if ((object) y == null && (object) x == null)
        return 0;
      if ((object) y == null)
        return 1;
      if ((object) x == null)
        return -1;
    }
    try
    {
      return this.ComparerFunction(x, y);
    }
    catch (Exception ex)
    {
    }
    return 0;
  }
}
