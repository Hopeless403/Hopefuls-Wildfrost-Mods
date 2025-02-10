// Decompiled with JetBrains decompiler
// Type: GenericCompare`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;

#nullable disable
public class GenericCompare<T> : IComparer<T>
{
  private Func<T, T, int> ComparerFunction { set; get; }

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
