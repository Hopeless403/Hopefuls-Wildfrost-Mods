// Decompiled with JetBrains decompiler
// Type: DictionaryExt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;

#nullable disable
public static class DictionaryExt
{
  public static T[] GetSaveCollection<T>(this Dictionary<string, object> dict, string key)
  {
    return ((SaveCollection<T>) dict[key]).collection;
  }
}
