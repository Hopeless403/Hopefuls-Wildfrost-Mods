// Decompiled with JetBrains decompiler
// Type: JournalCharmManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class JournalCharmManager : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_charmPrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_content;
  private static readonly System.IntPtr NativeFieldInfoPtr_discovered;
  private static readonly System.IntPtr NativeFieldInfoPtr_charmIcons;
  private static readonly System.IntPtr NativeFieldInfoPtr_locale;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateCharms_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadCharmData_Private_List_1_KeyValuePair_2_String_CardUpgradeData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91106, XrefRangeEnd = 91155, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JournalCharmManager.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91155, XrefRangeEnd = 91156, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JournalCharmManager.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 91191, RefRangeEnd = 91192, XrefRangeStart = 91156, XrefRangeEnd = 91191, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CreateCharms()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JournalCharmManager.NativeMethodInfoPtr_CreateCharms_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 91287, RefRangeEnd = 91288, XrefRangeStart = 91192, XrefRangeEnd = 91287, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe List<KeyValuePair<string, CardUpgradeData>> LoadCharmData()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JournalCharmManager.NativeMethodInfoPtr_LoadCharmData_Private_List_1_KeyValuePair_2_String_CardUpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (List<KeyValuePair<string, CardUpgradeData>>) null : new List<KeyValuePair<string, CardUpgradeData>>(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91288, XrefRangeEnd = 91297, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe JournalCharmManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JournalCharmManager>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JournalCharmManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static JournalCharmManager()
  {
    Il2CppClassPointerStore<JournalCharmManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (JournalCharmManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JournalCharmManager>.NativeClassPtr);
    JournalCharmManager.NativeFieldInfoPtr_charmPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCharmManager>.NativeClassPtr, nameof (charmPrefab));
    JournalCharmManager.NativeFieldInfoPtr_content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCharmManager>.NativeClassPtr, nameof (content));
    JournalCharmManager.NativeFieldInfoPtr_discovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCharmManager>.NativeClassPtr, nameof (discovered));
    JournalCharmManager.NativeFieldInfoPtr_charmIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCharmManager>.NativeClassPtr, nameof (charmIcons));
    JournalCharmManager.NativeFieldInfoPtr_locale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCharmManager>.NativeClassPtr, nameof (locale));
    JournalCharmManager.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCharmManager>.NativeClassPtr, 100671132);
    JournalCharmManager.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCharmManager>.NativeClassPtr, 100671133);
    JournalCharmManager.NativeMethodInfoPtr_CreateCharms_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCharmManager>.NativeClassPtr, 100671134);
    JournalCharmManager.NativeMethodInfoPtr_LoadCharmData_Private_List_1_KeyValuePair_2_String_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCharmManager>.NativeClassPtr, 100671135);
    JournalCharmManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCharmManager>.NativeClassPtr, 100671136);
  }

  public JournalCharmManager(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe JournalCharm charmPrefab
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCharmManager.NativeFieldInfoPtr_charmPrefab));
      return pointer == System.IntPtr.Zero ? (JournalCharm) null : new JournalCharm(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalCharmManager.NativeFieldInfoPtr_charmPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform content
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCharmManager.NativeFieldInfoPtr_content));
      return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalCharmManager.NativeFieldInfoPtr_content), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<string> discovered
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCharmManager.NativeFieldInfoPtr_discovered));
      return pointer == System.IntPtr.Zero ? (List<string>) null : new List<string>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalCharmManager.NativeFieldInfoPtr_discovered), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<JournalCharm> charmIcons
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCharmManager.NativeFieldInfoPtr_charmIcons));
      return pointer == System.IntPtr.Zero ? (List<JournalCharm>) null : new List<JournalCharm>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalCharmManager.NativeFieldInfoPtr_charmIcons), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEngine.Localization.Locale locale
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCharmManager.NativeFieldInfoPtr_locale));
      return pointer == System.IntPtr.Zero ? (UnityEngine.Localization.Locale) null : new UnityEngine.Localization.Locale(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalCharmManager.NativeFieldInfoPtr_locale), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("JournalCharmManager/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__8_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__8_1;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__8_2;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__8_3;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__8_4;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__LoadCharmData_b__8_0_Internal_Boolean_CardUpgradeData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__LoadCharmData_b__8_1_Internal_String_CardUpgradeData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__LoadCharmData_b__8_2_Internal_CardUpgradeData_CardUpgradeData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__LoadCharmData_b__8_3_Internal_Boolean_KeyValuePair_2_String_CardUpgradeData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__LoadCharmData_b__8_4_Internal_String_KeyValuePair_2_String_CardUpgradeData_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JournalCharmManager.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JournalCharmManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _LoadCharmData_b__8_0(CardUpgradeData a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JournalCharmManager.__c.NativeMethodInfoPtr__LoadCharmData_b__8_0_Internal_Boolean_CardUpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91102, XrefRangeEnd = 91104, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _LoadCharmData_b__8_1(CardUpgradeData a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(JournalCharmManager.__c.NativeMethodInfoPtr__LoadCharmData_b__8_1_Internal_String_CardUpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    public unsafe CardUpgradeData _LoadCharmData_b__8_2(CardUpgradeData a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JournalCharmManager.__c.NativeMethodInfoPtr__LoadCharmData_b__8_2_Internal_CardUpgradeData_CardUpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CardUpgradeData) null : new CardUpgradeData(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91104, XrefRangeEnd = 91105, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _LoadCharmData_b__8_3(KeyValuePair<string, CardUpgradeData> a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) a))
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JournalCharmManager.__c.NativeMethodInfoPtr__LoadCharmData_b__8_3_Internal_Boolean_KeyValuePair_2_String_CardUpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91105, XrefRangeEnd = 91106, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _LoadCharmData_b__8_4(KeyValuePair<string, CardUpgradeData> a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) a))
      };
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(JournalCharmManager.__c.NativeMethodInfoPtr__LoadCharmData_b__8_4_Internal_String_KeyValuePair_2_String_CardUpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static __c()
    {
      Il2CppClassPointerStore<JournalCharmManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JournalCharmManager>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JournalCharmManager.__c>.NativeClassPtr);
      JournalCharmManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCharmManager.__c>.NativeClassPtr, "<>9");
      JournalCharmManager.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCharmManager.__c>.NativeClassPtr, "<>9__8_0");
      JournalCharmManager.__c.NativeFieldInfoPtr___9__8_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCharmManager.__c>.NativeClassPtr, "<>9__8_1");
      JournalCharmManager.__c.NativeFieldInfoPtr___9__8_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCharmManager.__c>.NativeClassPtr, "<>9__8_2");
      JournalCharmManager.__c.NativeFieldInfoPtr___9__8_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCharmManager.__c>.NativeClassPtr, "<>9__8_3");
      JournalCharmManager.__c.NativeFieldInfoPtr___9__8_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCharmManager.__c>.NativeClassPtr, "<>9__8_4");
      JournalCharmManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCharmManager.__c>.NativeClassPtr, 100671138);
      JournalCharmManager.__c.NativeMethodInfoPtr__LoadCharmData_b__8_0_Internal_Boolean_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCharmManager.__c>.NativeClassPtr, 100671139);
      JournalCharmManager.__c.NativeMethodInfoPtr__LoadCharmData_b__8_1_Internal_String_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCharmManager.__c>.NativeClassPtr, 100671140);
      JournalCharmManager.__c.NativeMethodInfoPtr__LoadCharmData_b__8_2_Internal_CardUpgradeData_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCharmManager.__c>.NativeClassPtr, 100671141);
      JournalCharmManager.__c.NativeMethodInfoPtr__LoadCharmData_b__8_3_Internal_Boolean_KeyValuePair_2_String_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCharmManager.__c>.NativeClassPtr, 100671142);
      JournalCharmManager.__c.NativeMethodInfoPtr__LoadCharmData_b__8_4_Internal_String_KeyValuePair_2_String_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCharmManager.__c>.NativeClassPtr, 100671143);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe JournalCharmManager.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(JournalCharmManager.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (JournalCharmManager.__c) null : new JournalCharmManager.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(JournalCharmManager.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CardUpgradeData, bool> __9__8_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(JournalCharmManager.__c.NativeFieldInfoPtr___9__8_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardUpgradeData, bool>) null : new Il2CppSystem.Func<CardUpgradeData, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(JournalCharmManager.__c.NativeFieldInfoPtr___9__8_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CardUpgradeData, string> __9__8_1
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(JournalCharmManager.__c.NativeFieldInfoPtr___9__8_1, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardUpgradeData, string>) null : new Il2CppSystem.Func<CardUpgradeData, string>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(JournalCharmManager.__c.NativeFieldInfoPtr___9__8_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CardUpgradeData, CardUpgradeData> __9__8_2
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(JournalCharmManager.__c.NativeFieldInfoPtr___9__8_2, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardUpgradeData, CardUpgradeData>) null : new Il2CppSystem.Func<CardUpgradeData, CardUpgradeData>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(JournalCharmManager.__c.NativeFieldInfoPtr___9__8_2, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<KeyValuePair<string, CardUpgradeData>, bool> __9__8_3
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(JournalCharmManager.__c.NativeFieldInfoPtr___9__8_3, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<KeyValuePair<string, CardUpgradeData>, bool>) null : new Il2CppSystem.Func<KeyValuePair<string, CardUpgradeData>, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(JournalCharmManager.__c.NativeFieldInfoPtr___9__8_3, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<KeyValuePair<string, CardUpgradeData>, string> __9__8_4
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(JournalCharmManager.__c.NativeFieldInfoPtr___9__8_4, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<KeyValuePair<string, CardUpgradeData>, string>) null : new Il2CppSystem.Func<KeyValuePair<string, CardUpgradeData>, string>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(JournalCharmManager.__c.NativeFieldInfoPtr___9__8_4, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
