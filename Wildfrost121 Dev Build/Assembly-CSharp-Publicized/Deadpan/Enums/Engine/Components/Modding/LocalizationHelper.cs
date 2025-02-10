// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.LocalizationHelper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;

#nullable disable
namespace Deadpan.Enums.Engine.Components.Modding
{
  public static class LocalizationHelper
  {
    public static readonly Dictionary<string, StringTable> stringTables = new Dictionary<string, StringTable>();
    public static Harmony _harmony = new Harmony("wildfrost");

    public static Locale TryAddLocale(LocaleIdentifier locali)
    {
      if (!LocalizationSettings.AvailableLocales.Locales.All<Locale>((Func<Locale, bool>) (a => a.Identifier != locali)))
        return LocalizationSettings.AvailableLocales.Locales.Find((Predicate<Locale>) (a => a.Identifier == locali));
      Locale locale = Locale.CreateLocale(locali);
      locale.SortOrder = (ushort) LocalizationSettings.AvailableLocales.Locales.Count;
      LocalizationSettings.AvailableLocales.Locales.Add(locale);
      return locale;
    }

    static LocalizationHelper()
    {
      LocalizationHelper._harmony.PatchAll(typeof (LocalizationHelper).Assembly);
    }

    public static StringTable GetCollection(string name, LocaleIdentifier identifier)
    {
      string key = name + "_" + identifier.Code;
      StringTable collection1 = Addressables.LoadAssetAsync<StringTable>((object) key).WaitForCompletion();
      if (!((UnityEngine.Object) collection1 == (UnityEngine.Object) null))
        return collection1;
      StringTable collection2;
      if (LocalizationHelper.stringTables.TryGetValue(key, out collection2))
        return collection2;
      StringTable instance = ScriptableObject.CreateInstance<StringTable>();
      instance.name = key;
      instance.LocaleIdentifier = identifier;
      StringTable stringTable = Addressables.LoadAssetAsync<StringTable>((object) (name + "_" + new LocaleIdentifier(SystemLanguage.English).Code)).WaitForCompletion();
      instance.SharedData = stringTable.SharedData;
      LocalizationHelper.stringTables.Add(key, instance);
      return instance;
    }

    public static LocalizedString GetString(this StringTable table, string key)
    {
      TableReference tableCollectionName = (TableReference) table.TableCollectionName;
      LocalizedString localizedString = new LocalizedString();
      localizedString.SetReference(tableCollectionName, (TableEntryReference) key);
      return localizedString;
    }

    public static void SetString(this StringTable table, string key, string value)
    {
      long id = table.SharedData.GetId(key);
      if (id == 0L)
        id = table.SharedData.AddKey(key).Id;
      if (!table.ContainsKey(id))
        table.AddEntry(key, value);
      else
        table[id].Value = value;
    }

    [HarmonyPatch(typeof (LocalizedString), "GetLocalizedString", new System.Type[] {})]
    public class PatchLocalie1
    {
      [HarmonyPostfix]
      public static void Postfix(ref string __result, LocalizedString __instance)
      {
        if (!string.IsNullOrEmpty(__result))
          return;
        StringTable collection = LocalizationHelper.GetCollection(__instance.TableReference.TableCollectionName, LocalizationSettings.SelectedLocale.Identifier);
        TableEntryReference tableEntryReference = __instance.TableEntryReference;
        long num;
        if (tableEntryReference.ReferenceType != TableEntryReference.Type.Id)
        {
          SharedTableData sharedData = collection.SharedData;
          tableEntryReference = __instance.TableEntryReference;
          string key = tableEntryReference.Key;
          num = sharedData.GetId(key);
        }
        else
        {
          tableEntryReference = __instance.TableEntryReference;
          num = tableEntryReference.KeyId;
        }
        long keyId = num;
        StringTableEntry stringTableEntry;
        if (!collection.TryGetValue(keyId, out stringTableEntry))
          return;
        __result = stringTableEntry.Value;
      }
    }

    [HarmonyPatch(typeof (LocalizedStringDatabase), "GenerateLocalizedString", new System.Type[] {typeof (StringTable), typeof (StringTableEntry), typeof (TableReference), typeof (TableEntryReference), typeof (Locale), typeof (IList<object>)})]
    public class PatchLocalie2
    {
      [HarmonyPostfix]
      public static void Postfix(
        ref string __result,
        LocalizedStringDatabase __instance,
        StringTable table,
        StringTableEntry entry,
        TableReference tableReference,
        TableEntryReference tableEntryReference,
        Locale locale,
        IList<object> arguments)
      {
        if (!string.IsNullOrEmpty(__result))
          return;
        StringTable collection = LocalizationHelper.GetCollection(tableReference.TableCollectionName, locale.Identifier);
        long keyId = tableEntryReference.ReferenceType == TableEntryReference.Type.Id ? tableEntryReference.KeyId : collection.SharedData.GetId(tableEntryReference.Key);
        StringTableEntry stringTableEntry;
        if (!collection.TryGetValue(keyId, out stringTableEntry))
          return;
        __result = stringTableEntry.Value;
      }
    }

    [HarmonyPatch(typeof (LocalizedStringDatabase), "GetLocalizedString", new System.Type[] {typeof (TableReference), typeof (TableEntryReference), typeof (IList<object>), typeof (Locale), typeof (FallbackBehavior)})]
    public class PatchLocalie3
    {
      [HarmonyPostfix]
      public static void Postfix(
        ref string __result,
        LocalizedStringDatabase __instance,
        TableReference tableReference,
        TableEntryReference tableEntryReference,
        IList<object> arguments,
        Locale locale = null,
        FallbackBehavior fallbackBehavior = FallbackBehavior.UseProjectSettings)
      {
        if (!string.IsNullOrEmpty(__result))
          return;
        if ((UnityEngine.Object) locale == (UnityEngine.Object) null)
          locale = LocalizationSettings.SelectedLocale;
        StringTable collection = LocalizationHelper.GetCollection(tableReference.TableCollectionName, locale.Identifier);
        long keyId = tableEntryReference.ReferenceType == TableEntryReference.Type.Id ? tableEntryReference.KeyId : collection.SharedData.GetId(tableEntryReference.Key);
        StringTableEntry stringTableEntry;
        if (!collection.TryGetValue(keyId, out stringTableEntry))
          return;
        __result = stringTableEntry.Value;
      }
    }
  }
}
