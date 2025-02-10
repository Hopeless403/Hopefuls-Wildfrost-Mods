// Decompiled with JetBrains decompiler
// Type: ChallengeListener
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class ChallengeListener : ScriptableObject
{
  private static readonly IntPtr NativeFieldInfoPtr_checkType;
  private static readonly IntPtr NativeFieldInfoPtr_stat;
  private static readonly IntPtr NativeFieldInfoPtr_hasKey;
  private static readonly IntPtr NativeFieldInfoPtr_key;
  private static readonly IntPtr NativeFieldInfoPtr_target;
  private static readonly IntPtr NativeMethodInfoPtr_Check_Public_Virtual_New_Boolean_String_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckComplete_Public_Virtual_New_Boolean_CampaignStats_0;
  private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Virtual_New_Void_String_Int32_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_Add_Protected_Static_Void_String_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108997, XrefRangeEnd = 108998, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Check(string stat, string key)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(stat);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(key);
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ChallengeListener.NativeMethodInfoPtr_Check_Public_Virtual_New_Boolean_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108998, XrefRangeEnd = 109002, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool CheckComplete(CampaignStats stats)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stats)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ChallengeListener.NativeMethodInfoPtr_CheckComplete_Public_Virtual_New_Boolean_CampaignStats_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109002, XrefRangeEnd = 109003, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(string challengeName, int oldValue, int newValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(challengeName);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &oldValue;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &newValue;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ChallengeListener.NativeMethodInfoPtr_Set_Public_Virtual_New_Void_String_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109003, XrefRangeEnd = 109004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Add(string challengeName, int value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(challengeName);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChallengeListener.NativeMethodInfoPtr_Add_Protected_Static_Void_String_Int32_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(110)]
  [CachedScanResults(RefRangeStart = 104608, RefRangeEnd = 104718, XrefRangeStart = 104608, XrefRangeEnd = 104718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ChallengeListener()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChallengeListener>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChallengeListener.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ChallengeListener()
  {
    Il2CppClassPointerStore<ChallengeListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ChallengeListener));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengeListener>.NativeClassPtr);
    ChallengeListener.NativeFieldInfoPtr_checkType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListener>.NativeClassPtr, nameof (checkType));
    ChallengeListener.NativeFieldInfoPtr_stat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListener>.NativeClassPtr, nameof (stat));
    ChallengeListener.NativeFieldInfoPtr_hasKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListener>.NativeClassPtr, nameof (hasKey));
    ChallengeListener.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListener>.NativeClassPtr, nameof (key));
    ChallengeListener.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeListener>.NativeClassPtr, nameof (target));
    ChallengeListener.NativeMethodInfoPtr_Check_Public_Virtual_New_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeListener>.NativeClassPtr, 100673329);
    ChallengeListener.NativeMethodInfoPtr_CheckComplete_Public_Virtual_New_Boolean_CampaignStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeListener>.NativeClassPtr, 100673330);
    ChallengeListener.NativeMethodInfoPtr_Set_Public_Virtual_New_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeListener>.NativeClassPtr, 100673331);
    ChallengeListener.NativeMethodInfoPtr_Add_Protected_Static_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeListener>.NativeClassPtr, 100673332);
    ChallengeListener.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeListener>.NativeClassPtr, 100673333);
  }

  public ChallengeListener(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe ChallengeListener.CheckType checkType
  {
    get
    {
      return *(ChallengeListener.CheckType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListener.NativeFieldInfoPtr_checkType));
    }
    [param: In] set
    {
      *(ChallengeListener.CheckType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListener.NativeFieldInfoPtr_checkType)) = value;
    }
  }

  public unsafe string stat
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListener.NativeFieldInfoPtr_stat)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListener.NativeFieldInfoPtr_stat), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe bool hasKey
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListener.NativeFieldInfoPtr_hasKey));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListener.NativeFieldInfoPtr_hasKey)) = value;
    }
  }

  public unsafe string key
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListener.NativeFieldInfoPtr_key)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListener.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe int target
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListener.NativeFieldInfoPtr_target));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeListener.NativeFieldInfoPtr_target)) = value;
    }
  }

  public enum CheckType
  {
    MidRun,
    EndOfRun,
  }
}
