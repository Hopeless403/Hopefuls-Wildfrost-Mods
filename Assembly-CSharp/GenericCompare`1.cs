// Decompiled with JetBrains decompiler
// Type: GenericCompare`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;

public class GenericCompare<T> : IComparer<T>
{
  private Func<T, T, int> ComparerFunction { set; get; }

  public GenericCompare(Func<T, T, int> comparerFunction) => this.ComparerFunction = comparerFunction;

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
