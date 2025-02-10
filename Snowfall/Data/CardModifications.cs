// Decompiled with JetBrains decompiler
// Type: Snowfall2.Data.CardModifications
// Assembly: Snowfall, Version=0.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 26AFE777-3FAB-4D6F-AF6C-494837402D4A
// Assembly location: C:\Users\harri\AppData\Local\Temp\Temp1_Snowfall_-_Alpha_2.1.2.zip\Snowfall.dll

using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using Snowfall2.Util;
using System.Collections.Generic;
using UnityEngine;

namespace Snowfall2.Data
{
  public static class CardModifications
  {
    private static Dictionary<string, CardScript> NewScripts = new Dictionary<string, CardScript>()
    {
      {
        "SpiceStones",
        (CardScript) ScriptableObject.CreateInstance<CardScriptAddTrait>().Set<CardScriptAddTrait>("trait", (object) SnowfallMod.Instance.Get<TraitData>("Consume")).Set<CardScriptAddTrait>("countRange", (object) new Vector2Int(1, 1))
      }
    };

    public static void Load(WildfrostMod mod)
    {
      foreach (KeyValuePair<string, CardScript> newScript in CardModifications.NewScripts)
      {
        CardData cardData = mod.Get<CardData>(newScript.Key);
        cardData.createScripts = cardData.createScripts.AddToArray<CardScript>(newScript.Value);
      }
    }

    public static void Unload(WildfrostMod mod)
    {
      foreach (KeyValuePair<string, CardScript> newScript in CardModifications.NewScripts)
      {
        CardData cardData = mod.Get<CardData>(newScript.Key);
        cardData.createScripts = cardData.createScripts.RemoveFromArray<CardScript>(newScript.Value);
      }
    }
  }
}
