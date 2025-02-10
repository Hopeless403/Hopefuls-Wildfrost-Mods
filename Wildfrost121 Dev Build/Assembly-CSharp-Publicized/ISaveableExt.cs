// Decompiled with JetBrains decompiler
// Type: ISaveableExt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
public static class ISaveableExt
{
  public static D[] SaveArray<S, D>(this IEnumerable<S> list) where S : ISaveable<D>
  {
    return list.Select<S, D>((Func<S, D>) (a => a.Save())).ToArray<D>();
  }

  public static D[] SaveArray<S, D>(this S[] array) where S : ISaveable<D>
  {
    return ((IEnumerable<S>) array).Select<S, D>((Func<S, D>) (a => a.Save())).ToArray<D>();
  }
}
