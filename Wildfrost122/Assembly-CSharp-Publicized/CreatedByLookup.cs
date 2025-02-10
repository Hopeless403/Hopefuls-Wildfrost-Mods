// Decompiled with JetBrains decompiler
// Type: CreatedByLookup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;

#nullable disable
public static class CreatedByLookup
{
  public static readonly Dictionary<string, string> lookup = new Dictionary<string, string>()
  {
    {
      "Dregg",
      "Egg"
    },
    {
      "TailsOne",
      "TailsTwo"
    },
    {
      "TailsTwo",
      "TailsThree"
    },
    {
      "TailsThree",
      "TailsFour"
    },
    {
      "TailsFour",
      "TailsFive"
    },
    {
      "Beepop",
      "BeepopMask"
    },
    {
      "Plep",
      "JunjunMask"
    },
    {
      "Fallow",
      "FallowMask"
    },
    {
      "Tigris",
      "TigrisMask"
    },
    {
      "Leech",
      "Leecher"
    },
    {
      "Pigeon",
      "PigeonCage"
    },
    {
      "Popper",
      "PopPopper"
    },
    {
      "Snuffer",
      "SnufferMask"
    }
  };

  public static bool TryGetCreatedBy(string cardDataName, out string parentCardDataName)
  {
    string str;
    if (CreatedByLookup.lookup.TryGetValue(cardDataName, out str))
    {
      parentCardDataName = str;
      return true;
    }
    parentCardDataName = cardDataName;
    return false;
  }

  public static void TryGetCreatedByRoot(string cardDataName, out string rootCardDataName)
  {
    rootCardDataName = cardDataName;
    do
      ;
    while (CreatedByLookup.TryGetCreatedBy(rootCardDataName, out rootCardDataName));
  }

  public static List<string> GetCreatedByThis(string cardDataName)
  {
    List<string> createdByThis = new List<string>();
    foreach (KeyValuePair<string, string> keyValuePair in CreatedByLookup.lookup)
    {
      string str1;
      string str2;
      keyValuePair.Deconstruct(ref str1, ref str2);
      string cardDataName1 = str1;
      if (str2 == cardDataName)
      {
        createdByThis.Add(cardDataName1);
        createdByThis.AddRange((IEnumerable<string>) CreatedByLookup.GetCreatedByThis(cardDataName1));
      }
    }
    return createdByThis;
  }

  public static void Add(string cardDataName, string parentCardDataName)
  {
    CreatedByLookup.lookup.Add(cardDataName, parentCardDataName);
  }
}
