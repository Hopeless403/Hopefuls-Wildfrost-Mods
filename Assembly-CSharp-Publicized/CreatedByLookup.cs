// Decompiled with JetBrains decompiler
// Type: CreatedByLookup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;

public static class CreatedByLookup
{
  public static bool requiresRebuild = true;
  public static readonly Dictionary<string, string> lookup = new Dictionary<string, string>();

  public static bool TryGetCreatedBy(string cardDataName, out string parentCardDataName)
  {
    if (CreatedByLookup.requiresRebuild)
    {
      CreatedByLookup.Clear();
      CreatedByLookup.Build();
    }
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

  public static void Clear() => CreatedByLookup.lookup.Clear();

  public static void Build()
  {
    CreatedByLookup.Add("Dregg", "Egg");
    CreatedByLookup.Add("TailsOne", "TailsTwo");
    CreatedByLookup.Add("TailsTwo", "TailsThree");
    CreatedByLookup.Add("TailsThree", "TailsFour");
    CreatedByLookup.Add("TailsFour", "TailsFive");
    CreatedByLookup.Add("Beepop", "BeepopMask");
    CreatedByLookup.Add("Plep", "JunjunMask");
    CreatedByLookup.Add("Fallow", "FallowMask");
    CreatedByLookup.Add("Tigris", "TigrisMask");
    CreatedByLookup.Add("Leech", "Leecher");
    CreatedByLookup.Add("Pigeon", "PigeonCage");
    CreatedByLookup.Add("Sheepopper", "PopPopper");
    CreatedByLookup.requiresRebuild = false;
  }

  public static void Add(string cardDataName, string parentCardDataName) => CreatedByLookup.lookup.Add(cardDataName, parentCardDataName);
}
