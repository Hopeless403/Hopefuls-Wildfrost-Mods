// Decompiled with JetBrains decompiler
// Type: DailyFetcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections;
using System.Runtime.InteropServices;

#nullable disable
public static class DailyFetcher : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_DayOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr__fetched_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr_dateTime;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_fetched_Public_Static_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_fetched_Private_Static_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FetchDateTime_Public_Static_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CancelFetch_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetContinueDateTime_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDateTime_Public_Static_DateTime_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetNextDateTime_Internal_Static_DateTime_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSeed_Public_Static_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDate_Public_Static_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetLeaderboardName_Public_Static_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetLeaderboardName_Public_Static_String_DateTime_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetLeaderboardName_Public_Static_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CanPlay_Public_Static_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SameDay_Private_Static_Boolean_DateTime_DateTime_0;

  public static unsafe bool fetched
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110955, XrefRangeEnd = 110957, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DailyFetcher.NativeMethodInfoPtr_get_fetched_Public_Static_get_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110957, XrefRangeEnd = 110959, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DailyFetcher.NativeMethodInfoPtr_set_fetched_Private_Static_set_Void_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110959, XrefRangeEnd = 110963, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IEnumerator FetchDateTime()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DailyFetcher.NativeMethodInfoPtr_FetchDateTime_Public_Static_IEnumerator_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 110965, RefRangeEnd = 110966, XrefRangeStart = 110963, XrefRangeEnd = 110965, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CancelFetch()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DailyFetcher.NativeMethodInfoPtr_CancelFetch_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110966, XrefRangeEnd = 110990, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetContinueDateTime()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DailyFetcher.NativeMethodInfoPtr_SetContinueDateTime_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110990, XrefRangeEnd = 110992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppSystem.DateTime GetDateTime()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DailyFetcher.NativeMethodInfoPtr_GetDateTime_Public_Static_DateTime_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Il2CppSystem.DateTime*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 110996, RefRangeEnd = 110997, XrefRangeStart = 110992, XrefRangeEnd = 110996, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppSystem.DateTime GetNextDateTime()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DailyFetcher.NativeMethodInfoPtr_GetNextDateTime_Internal_Static_DateTime_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Il2CppSystem.DateTime*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 111010, RefRangeEnd = 111011, XrefRangeStart = 110997, XrefRangeEnd = 111010, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetSeed()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DailyFetcher.NativeMethodInfoPtr_GetSeed_Public_Static_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111011, XrefRangeEnd = 111016, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetDate()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(DailyFetcher.NativeMethodInfoPtr_GetDate_Public_Static_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111016, XrefRangeEnd = 111024, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetLeaderboardName()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(DailyFetcher.NativeMethodInfoPtr_GetLeaderboardName_Public_Static_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111024, XrefRangeEnd = 111030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetLeaderboardName(Il2CppSystem.DateTime dateTime)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &dateTime
    };
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(DailyFetcher.NativeMethodInfoPtr_GetLeaderboardName_Public_Static_String_DateTime_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111030, XrefRangeEnd = 111033, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetLeaderboardName(string dateString)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(dateString)
    };
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(DailyFetcher.NativeMethodInfoPtr_GetLeaderboardName_Public_Static_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 111052, RefRangeEnd = 111053, XrefRangeStart = 111033, XrefRangeEnd = 111052, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool CanPlay()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DailyFetcher.NativeMethodInfoPtr_CanPlay_Public_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111053, XrefRangeEnd = 111055, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool SameDay(Il2CppSystem.DateTime a, Il2CppSystem.DateTime b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DailyFetcher.NativeMethodInfoPtr_SameDay_Private_Static_Boolean_DateTime_DateTime_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  static DailyFetcher()
  {
    Il2CppClassPointerStore<DailyFetcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (DailyFetcher));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyFetcher>.NativeClassPtr);
    DailyFetcher.NativeFieldInfoPtr_DayOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyFetcher>.NativeClassPtr, nameof (DayOffset));
    DailyFetcher.NativeFieldInfoPtr__fetched_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyFetcher>.NativeClassPtr, "<fetched>k__BackingField");
    DailyFetcher.NativeFieldInfoPtr_dateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyFetcher>.NativeClassPtr, nameof (dateTime));
    DailyFetcher.NativeMethodInfoPtr_get_fetched_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyFetcher>.NativeClassPtr, 100673674);
    DailyFetcher.NativeMethodInfoPtr_set_fetched_Private_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyFetcher>.NativeClassPtr, 100673675);
    DailyFetcher.NativeMethodInfoPtr_FetchDateTime_Public_Static_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyFetcher>.NativeClassPtr, 100673676);
    DailyFetcher.NativeMethodInfoPtr_CancelFetch_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyFetcher>.NativeClassPtr, 100673677);
    DailyFetcher.NativeMethodInfoPtr_SetContinueDateTime_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyFetcher>.NativeClassPtr, 100673678);
    DailyFetcher.NativeMethodInfoPtr_GetDateTime_Public_Static_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyFetcher>.NativeClassPtr, 100673679);
    DailyFetcher.NativeMethodInfoPtr_GetNextDateTime_Internal_Static_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyFetcher>.NativeClassPtr, 100673680);
    DailyFetcher.NativeMethodInfoPtr_GetSeed_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyFetcher>.NativeClassPtr, 100673681);
    DailyFetcher.NativeMethodInfoPtr_GetDate_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyFetcher>.NativeClassPtr, 100673682);
    DailyFetcher.NativeMethodInfoPtr_GetLeaderboardName_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyFetcher>.NativeClassPtr, 100673683);
    DailyFetcher.NativeMethodInfoPtr_GetLeaderboardName_Public_Static_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyFetcher>.NativeClassPtr, 100673684);
    DailyFetcher.NativeMethodInfoPtr_GetLeaderboardName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyFetcher>.NativeClassPtr, 100673685);
    DailyFetcher.NativeMethodInfoPtr_CanPlay_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyFetcher>.NativeClassPtr, 100673686);
    DailyFetcher.NativeMethodInfoPtr_SameDay_Private_Static_Boolean_DateTime_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyFetcher>.NativeClassPtr, 100673687);
  }

  public DailyFetcher(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe int DayOffset
  {
    get
    {
      int dayOffset;
      IL2CPP.il2cpp_field_static_get_value(DailyFetcher.NativeFieldInfoPtr_DayOffset, (void*) &dayOffset);
      return dayOffset;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DailyFetcher.NativeFieldInfoPtr_DayOffset, (void*) &value);
    }
  }

  public static unsafe bool _fetched_k__BackingField
  {
    get
    {
      bool fetchedKBackingField;
      IL2CPP.il2cpp_field_static_get_value(DailyFetcher.NativeFieldInfoPtr__fetched_k__BackingField, (void*) &fetchedKBackingField);
      return fetchedKBackingField;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DailyFetcher.NativeFieldInfoPtr__fetched_k__BackingField, (void*) &value);
    }
  }

  public static unsafe Il2CppSystem.DateTime dateTime
  {
    get
    {
      Il2CppSystem.DateTime dateTime;
      IL2CPP.il2cpp_field_static_get_value(DailyFetcher.NativeFieldInfoPtr_dateTime, (void*) &dateTime);
      return dateTime;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DailyFetcher.NativeFieldInfoPtr_dateTime, (void*) &value);
    }
  }

  [ObfuscatedName("DailyFetcher/<FetchDateTime>d__6")]
  public sealed class _FetchDateTime_d__6 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _FetchDateTime_d__6(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailyFetcher._FetchDateTime_d__6>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DailyFetcher._FetchDateTime_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DailyFetcher._FetchDateTime_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110939, XrefRangeEnd = 110949, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DailyFetcher._FetchDateTime_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DailyFetcher._FetchDateTime_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110949, XrefRangeEnd = 110955, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DailyFetcher._FetchDateTime_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DailyFetcher._FetchDateTime_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _FetchDateTime_d__6()
    {
      Il2CppClassPointerStore<DailyFetcher._FetchDateTime_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DailyFetcher>.NativeClassPtr, "<FetchDateTime>d__6");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyFetcher._FetchDateTime_d__6>.NativeClassPtr);
      DailyFetcher._FetchDateTime_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyFetcher._FetchDateTime_d__6>.NativeClassPtr, "<>1__state");
      DailyFetcher._FetchDateTime_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyFetcher._FetchDateTime_d__6>.NativeClassPtr, "<>2__current");
      DailyFetcher._FetchDateTime_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyFetcher._FetchDateTime_d__6>.NativeClassPtr, 100673688);
      DailyFetcher._FetchDateTime_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyFetcher._FetchDateTime_d__6>.NativeClassPtr, 100673689);
      DailyFetcher._FetchDateTime_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyFetcher._FetchDateTime_d__6>.NativeClassPtr, 100673690);
      DailyFetcher._FetchDateTime_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyFetcher._FetchDateTime_d__6>.NativeClassPtr, 100673691);
      DailyFetcher._FetchDateTime_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyFetcher._FetchDateTime_d__6>.NativeClassPtr, 100673692);
      DailyFetcher._FetchDateTime_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyFetcher._FetchDateTime_d__6>.NativeClassPtr, 100673693);
    }

    public _FetchDateTime_d__6(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DailyFetcher._FetchDateTime_d__6.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DailyFetcher._FetchDateTime_d__6.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DailyFetcher._FetchDateTime_d__6.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DailyFetcher._FetchDateTime_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
