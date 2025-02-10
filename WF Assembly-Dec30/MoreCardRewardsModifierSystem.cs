// Decompiled with JetBrains decompiler
// Type: MoreCardRewardsModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class MoreCardRewardsModifierSystem : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_toAdd;
  private static readonly System.IntPtr NativeFieldInfoPtr_tiersToAddTo;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PullRewards_Private_Void_Object_byref_String_byref_Int32_byref_List_1_DataFile_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65452, XrefRangeEnd = 65504, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MoreCardRewardsModifierSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65504, XrefRangeEnd = 65512, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MoreCardRewardsModifierSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65512, XrefRangeEnd = 65543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PullRewards(
    Il2CppSystem.Object pulledBy,
    ref string poolName,
    ref int itemCount,
    ref List<DataFile> result)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pulledBy);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr il2Cpp = IL2CPP.ManagedStringToIl2Cpp(poolName);
    System.IntPtr* numPtr2 = &il2Cpp;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref itemCount;
    System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
    System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
    System.IntPtr* numPtr3 = &ptr;
    *(System.IntPtr*) num2 = (System.IntPtr) numPtr3;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MoreCardRewardsModifierSystem.NativeMethodInfoPtr_PullRewards_Private_Void_Object_byref_String_byref_Int32_byref_List_1_DataFile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    poolName = IL2CPP.Il2CppStringToManaged(il2Cpp);
    ref List<DataFile> local = ref result;
    System.IntPtr pointer = ptr;
    List<> list = pointer == System.IntPtr.Zero ? (List<>) null : new List<>(pointer);
    local = (List<DataFile>) list;
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65543, XrefRangeEnd = 65552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MoreCardRewardsModifierSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoreCardRewardsModifierSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MoreCardRewardsModifierSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static MoreCardRewardsModifierSystem()
  {
    Il2CppClassPointerStore<MoreCardRewardsModifierSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (MoreCardRewardsModifierSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoreCardRewardsModifierSystem>.NativeClassPtr);
    MoreCardRewardsModifierSystem.NativeFieldInfoPtr_toAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoreCardRewardsModifierSystem>.NativeClassPtr, nameof (toAdd));
    MoreCardRewardsModifierSystem.NativeFieldInfoPtr_tiersToAddTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoreCardRewardsModifierSystem>.NativeClassPtr, nameof (tiersToAddTo));
    MoreCardRewardsModifierSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoreCardRewardsModifierSystem>.NativeClassPtr, 100668684);
    MoreCardRewardsModifierSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoreCardRewardsModifierSystem>.NativeClassPtr, 100668685);
    MoreCardRewardsModifierSystem.NativeMethodInfoPtr_PullRewards_Private_Void_Object_byref_String_byref_Int32_byref_List_1_DataFile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoreCardRewardsModifierSystem>.NativeClassPtr, 100668686);
    MoreCardRewardsModifierSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoreCardRewardsModifierSystem>.NativeClassPtr, 100668687);
  }

  public MoreCardRewardsModifierSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe int toAdd
  {
    get
    {
      int toAdd;
      IL2CPP.il2cpp_field_static_get_value(MoreCardRewardsModifierSystem.NativeFieldInfoPtr_toAdd, (void*) &toAdd);
      return toAdd;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(MoreCardRewardsModifierSystem.NativeFieldInfoPtr_toAdd, (void*) &value);
    }
  }

  public unsafe List<int> tiersToAddTo
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoreCardRewardsModifierSystem.NativeFieldInfoPtr_tiersToAddTo));
      return pointer == System.IntPtr.Zero ? (List<int>) null : new List<int>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MoreCardRewardsModifierSystem.NativeFieldInfoPtr_tiersToAddTo), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
