// Decompiled with JetBrains decompiler
// Type: ISaveableExt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;

public static class ISaveableExt
{
  public static D[] SaveArray<S, D>(this IEnumerable<S> list) where S : ISaveable<D> => list.Select<S, D>((Func<S, D>) (a => a.Save())).ToArray<D>();

  public static D[] SaveArray<S, D>(this S[] array) where S : ISaveable<D> => ((IEnumerable<S>) array).Select<S, D>((Func<S, D>) (a => a.Save())).ToArray<D>();
}
