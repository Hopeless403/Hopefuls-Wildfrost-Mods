// Decompiled with JetBrains decompiler
// Type: Snowfall2.Classes.CardScripts.CardScriptTransform
// Assembly: Snowfall, Version=0.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 26AFE777-3FAB-4D6F-AF6C-494837402D4A
// Assembly location: C:\Users\harri\AppData\Local\Temp\Temp1_Snowfall_-_Alpha_2.1.2.zip\Snowfall.dll

using HarmonyLib;
using Snowfall2.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Snowfall2.Classes.CardScripts
{
  public class CardScriptTransform : CardScript
  {
    public Func<string, string> transformFunc;

    public override void Run(CardData target)
    {
      string name = this.transformFunc(target.name);
      if (name == null)
        return;
      CardData cardData1 = SnowfallMod.Instance.Get<CardData>(name);
      if (cardData1 == null)
        return;
      SnowfallMod.Log("Transforming Unit: " + target.name + " -> " + name);
      CardData cardData2 = target.Clone();
      CardData cardData3 = cardData1.Clone();
      System.Type type1 = target.GetType();
      foreach (FieldInfo field1 in type1.GetFields())
      {
        FieldInfo field2 = type1.GetField(field1.Name, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.ExactBinding);
        if (field2 != (FieldInfo) null)
        {
          System.Type type2 = field2.FieldType;
          System.Type type3 = field1.FieldType;
          if (type2.IsGenericType && type2.GetGenericTypeDefinition() == typeof (Nullable<>))
            type2 = type2.GetGenericArguments()[0];
          if (type3.IsGenericType && type3.GetGenericTypeDefinition() == typeof (Nullable<>))
            type3 = type3.GetGenericArguments()[0];
          if (type3 == type2)
          {
            object obj = field1.GetValue((object) cardData3);
            field1.SetValue((object) target, obj);
          }
        }
      }
      target.name = cardData3.name;
      target.upgrades = cardData2.upgrades.Where<CardUpgradeData>((Func<CardUpgradeData, bool>) (upg => upg.type != CardUpgradeData.Type.Charm)).ToList<CardUpgradeData>();
      target.injuries = cardData2.injuries;
      target.tokenSlots = cardData2.tokenSlots;
      target.crownSlots = cardData2.crownSlots;
      if (!CardDiscoverSystem.instance.discoveredCards.Contains(target.name))
        CardDiscoverSystem.instance.DiscoverCard(target.name);
      target.createScripts = ((IEnumerable<CardScript>) target.createScripts).AddItem<CardScript>((CardScript) SFUtils.CreateCardScript<CardScriptModifyCharmSlots>("CardScriptEmptyCharmSlots").Set<CardScriptModifyCharmSlots>("addCharmSlots", (object) (1 - target.charmSlots))).ToArray<CardScript>();
      target.RunCreateScripts();
    }
  }
}
