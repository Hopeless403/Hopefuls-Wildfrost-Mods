// Decompiled with JetBrains decompiler
// Type: SettingsLocaleSelector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine.Localization.Settings;

#nullable disable
[Serializable]
public class SettingsLocaleSelector : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_settingsKey;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetStartupLocale_Public_Virtual_Final_New_Locale_ILocalesProvider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127850, XrefRangeEnd = 127866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe UnityEngine.Localization.Locale GetStartupLocale(
    ILocalesProvider availableLocales)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) availableLocales)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SettingsLocaleSelector.NativeMethodInfoPtr_GetStartupLocale_Public_Virtual_Final_New_Locale_ILocalesProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (UnityEngine.Localization.Locale) null : new UnityEngine.Localization.Locale(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127866, XrefRangeEnd = 127871, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SettingsLocaleSelector()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsLocaleSelector>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SettingsLocaleSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static SettingsLocaleSelector()
  {
    Il2CppClassPointerStore<SettingsLocaleSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (SettingsLocaleSelector));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsLocaleSelector>.NativeClassPtr);
    SettingsLocaleSelector.NativeFieldInfoPtr_settingsKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsLocaleSelector>.NativeClassPtr, nameof (settingsKey));
    SettingsLocaleSelector.NativeMethodInfoPtr_GetStartupLocale_Public_Virtual_Final_New_Locale_ILocalesProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsLocaleSelector>.NativeClassPtr, 100676524);
    SettingsLocaleSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsLocaleSelector>.NativeClassPtr, 100676525);
  }

  public SettingsLocaleSelector(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe string settingsKey
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SettingsLocaleSelector.NativeFieldInfoPtr_settingsKey)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SettingsLocaleSelector.NativeFieldInfoPtr_settingsKey), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
