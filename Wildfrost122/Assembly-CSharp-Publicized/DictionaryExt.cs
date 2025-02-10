// Decompiled with JetBrains decompiler
// Type: DictionaryExt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;

#nullable disable
public static class DictionaryExt
{
  public static T[] GetSaveCollection<T>(this Dictionary<string, object> dict, string key)
  {
    return ((SaveCollection<T>) dict[key]).collection;
  }
}
