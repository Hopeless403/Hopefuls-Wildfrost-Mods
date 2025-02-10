// Decompiled with JetBrains decompiler
// Type: WildfrostModMiya.LocalizationHelper
// Assembly: WildfrostModMiya, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 51F56119-3F77-414A-8824-BFF112DF055A
// Assembly location: C:\Users\harri\Downloads\Wildfrost v1.0.4\BepInEx\plugins\WildfrostModMiya.dll

using UnityEngine.Localization;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;

namespace WildfrostModMiya
{
  public static class LocalizationHelper
  {
    public static LocalizedString FromId(long id) => new LocalizedString(TableReference.TableReferenceFromString("Card Text"), new TableEntryReference()
    {
      KeyId = id,
      ReferenceType = (TableEntryReference.Type) 2
    });

    public static long CreateLocalizedString(string key, string localized) => ((TableEntry) ((DetailedLocalizationTable<StringTableEntry>) ((LocalizedDatabase<StringTable, StringTableEntry>) LocalizationSettings.StringDatabase).GetTable(TableReference.TableReferenceFromString("Card Text"), (Locale) null)).AddEntry(key, localized)).KeyId;
  }
}
