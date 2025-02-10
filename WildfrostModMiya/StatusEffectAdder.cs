// Decompiled with JetBrains decompiler
// Type: WildfrostModMiya.StatusEffectAdder
// Assembly: WildfrostModMiya, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 51F56119-3F77-414A-8824-BFF112DF055A
// Assembly location: C:\Users\harri\Downloads\Wildfrost v1.0.4\BepInEx\plugins\WildfrostModMiya.dll

using System;
using UnityEngine;
using UnityEngine.Localization;

namespace WildfrostModMiya
{
  public static class StatusEffectAdder
  {
    public static event Action<int> OnAskForAddingStatusEffects;

    public static T ModifyFields<T>(this T t, Func<T, T> modifyFields) where T : StatusEffectData
    {
      t = modifyFields(t);
      return t;
    }

    public static T SetText<T>(this T t, string text) where T : StatusEffectData
    {
      t.textKey = LocalizationHelper.FromId(LocalizationHelper.CreateLocalizedString(((Object) (object) t).name + ".Text", text));
      return t;
    }

    public static T RegisterStatusEffectInApi<T>(this T t) where T : StatusEffectData
    {
      WildFrostAPIMod.StatusEffectDataAdditions.Add((StatusEffectData) t);
      return t;
    }

    public static T CreateStatusEffectData<T>(string modName, string cardName) where T : StatusEffectData
    {
      T instance = ScriptableObject.CreateInstance<T>();
      instance.textKey = new LocalizedString();
      ((Object) (object) instance).name = cardName.StartsWith(modName) ? cardName : modName + "." + cardName;
      if (modName == "")
        ((Object) (object) instance).name = cardName;
      return instance;
    }

    internal static void LaunchEvent()
    {
      Action<int> addingStatusEffects = StatusEffectAdder.OnAskForAddingStatusEffects;
      if (addingStatusEffects == null)
        return;
      addingStatusEffects(0);
    }
  }
}
