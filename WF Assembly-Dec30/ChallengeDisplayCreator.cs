// Decompiled with JetBrains decompiler
// Type: ChallengeDisplayCreator
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
public class ChallengeDisplayCreator : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_challenge;
  private static readonly IntPtr NativeFieldInfoPtr_displayPrefab;
  private static readonly IntPtr NativeFieldInfoPtr_checkOnEnable;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Check_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__Check_b__4_0_Private_Boolean_ChallengeProgress_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37110, XrefRangeEnd = 37111, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChallengeDisplayCreator.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 37164, RefRangeEnd = 37167, XrefRangeStart = 37111, XrefRangeEnd = 37164, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Check()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChallengeDisplayCreator.NativeMethodInfoPtr_Check_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37167, XrefRangeEnd = 37168, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ChallengeDisplayCreator()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChallengeDisplayCreator>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChallengeDisplayCreator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37168, XrefRangeEnd = 37171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool _Check_b__4_0(ChallengeProgress a)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChallengeDisplayCreator.NativeMethodInfoPtr__Check_b__4_0_Private_Boolean_ChallengeProgress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  static ChallengeDisplayCreator()
  {
    Il2CppClassPointerStore<ChallengeDisplayCreator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ChallengeDisplayCreator));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengeDisplayCreator>.NativeClassPtr);
    ChallengeDisplayCreator.NativeFieldInfoPtr_challenge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeDisplayCreator>.NativeClassPtr, nameof (challenge));
    ChallengeDisplayCreator.NativeFieldInfoPtr_displayPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeDisplayCreator>.NativeClassPtr, nameof (displayPrefab));
    ChallengeDisplayCreator.NativeFieldInfoPtr_checkOnEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeDisplayCreator>.NativeClassPtr, nameof (checkOnEnable));
    ChallengeDisplayCreator.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeDisplayCreator>.NativeClassPtr, 100665785);
    ChallengeDisplayCreator.NativeMethodInfoPtr_Check_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeDisplayCreator>.NativeClassPtr, 100665786);
    ChallengeDisplayCreator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeDisplayCreator>.NativeClassPtr, 100665787);
    ChallengeDisplayCreator.NativeMethodInfoPtr__Check_b__4_0_Private_Boolean_ChallengeProgress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeDisplayCreator>.NativeClassPtr, 100665788);
  }

  public ChallengeDisplayCreator(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe ChallengeData challenge
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeDisplayCreator.NativeFieldInfoPtr_challenge));
      return pointer == IntPtr.Zero ? (ChallengeData) null : new ChallengeData(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeDisplayCreator.NativeFieldInfoPtr_challenge), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ChallengeProgressDisplay displayPrefab
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeDisplayCreator.NativeFieldInfoPtr_displayPrefab));
      return pointer == IntPtr.Zero ? (ChallengeProgressDisplay) null : new ChallengeProgressDisplay(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeDisplayCreator.NativeFieldInfoPtr_displayPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool checkOnEnable
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeDisplayCreator.NativeFieldInfoPtr_checkOnEnable));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeDisplayCreator.NativeFieldInfoPtr_checkOnEnable)) = value;
    }
  }
}
