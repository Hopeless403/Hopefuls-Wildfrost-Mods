// Decompiled with JetBrains decompiler
// Type: CinemaBarSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections;
using System;
using TMPro;
using UnityEngine;

#nullable disable
public class CinemaBarSystem : GameSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr__instance;
  private static readonly System.IntPtr NativeFieldInfoPtr_canvas;
  private static readonly System.IntPtr NativeFieldInfoPtr_top;
  private static readonly System.IntPtr NativeFieldInfoPtr_bottom;
  private static readonly System.IntPtr NativeFieldInfoPtr_Top;
  private static readonly System.IntPtr NativeFieldInfoPtr_Bottom;
  private static readonly System.IntPtr NativeFieldInfoPtr_from;
  private static readonly System.IntPtr NativeFieldInfoPtr_to;
  private static readonly System.IntPtr NativeFieldInfoPtr_inDur;
  private static readonly System.IntPtr NativeFieldInfoPtr_inEase;
  private static readonly System.IntPtr NativeFieldInfoPtr_outDur;
  private static readonly System.IntPtr NativeFieldInfoPtr_outEase;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_instance_Private_Static_get_CinemaBarSystem_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CampaignFinal_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetScript_Public_Static_Void_String_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Typewrite_Private_Static_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsActive_Public_Static_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_In_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InInstant_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Out_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OutInstant_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetSortingLayer_Public_Static_Void_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResetSortingLayer_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetPosition_Private_Static_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public static unsafe CinemaBarSystem instance
  {
    [CallerCount(33), CachedScanResults(RefRangeStart = 57553, RefRangeEnd = 57586, XrefRangeStart = 57542, XrefRangeEnd = 57553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CinemaBarSystem.NativeMethodInfoPtr_get_instance_Private_Static_get_CinemaBarSystem_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CinemaBarSystem) null : new CinemaBarSystem(pointer);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57586, XrefRangeEnd = 57593, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CinemaBarSystem.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57593, XrefRangeEnd = 57601, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CinemaBarSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57601, XrefRangeEnd = 57609, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CinemaBarSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57609, XrefRangeEnd = 57634, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CampaignFinal()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CinemaBarSystem.NativeMethodInfoPtr_CampaignFinal_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(19)]
  [CachedScanResults(RefRangeStart = 57642, RefRangeEnd = 57661, XrefRangeStart = 57634, XrefRangeEnd = 57642, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Clear()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CinemaBarSystem.NativeMethodInfoPtr_Clear_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 57680, RefRangeEnd = 57681, XrefRangeStart = 57661, XrefRangeEnd = 57680, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetScript(string text, bool typewriterAnimation)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &typewriterAnimation;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CinemaBarSystem.NativeMethodInfoPtr_SetScript_Public_Static_Void_String_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57681, XrefRangeEnd = 57685, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IEnumerator Typewrite()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CinemaBarSystem.NativeMethodInfoPtr_Typewrite_Private_Static_IEnumerator_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57685, XrefRangeEnd = 57689, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsActive()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CinemaBarSystem.NativeMethodInfoPtr_IsActive_Public_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 57708, RefRangeEnd = 57713, XrefRangeStart = 57689, XrefRangeEnd = 57708, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void In()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CinemaBarSystem.NativeMethodInfoPtr_In_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 57723, RefRangeEnd = 57726, XrefRangeStart = 57713, XrefRangeEnd = 57723, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void InInstant()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CinemaBarSystem.NativeMethodInfoPtr_InInstant_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 57773, RefRangeEnd = 57778, XrefRangeStart = 57726, XrefRangeEnd = 57773, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Out()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CinemaBarSystem.NativeMethodInfoPtr_Out_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 57802, RefRangeEnd = 57804, XrefRangeStart = 57778, XrefRangeEnd = 57802, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OutInstant()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CinemaBarSystem.NativeMethodInfoPtr_OutInstant_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 57809, RefRangeEnd = 57813, XrefRangeStart = 57804, XrefRangeEnd = 57809, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetSortingLayer(string name, int orderInLayer = 0)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &orderInLayer;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CinemaBarSystem.NativeMethodInfoPtr_SetSortingLayer_Public_Static_Void_String_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 57820, RefRangeEnd = 57823, XrefRangeStart = 57813, XrefRangeEnd = 57820, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ResetSortingLayer()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CinemaBarSystem.NativeMethodInfoPtr_ResetSortingLayer_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 57833, RefRangeEnd = 57839, XrefRangeStart = 57823, XrefRangeEnd = 57833, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetPosition(float value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CinemaBarSystem.NativeMethodInfoPtr_SetPosition_Private_Static_Void_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemaBarSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemaBarSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CinemaBarSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CinemaBarSystem()
  {
    Il2CppClassPointerStore<CinemaBarSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CinemaBarSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemaBarSystem>.NativeClassPtr);
    CinemaBarSystem.NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemaBarSystem>.NativeClassPtr, nameof (_instance));
    CinemaBarSystem.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemaBarSystem>.NativeClassPtr, nameof (canvas));
    CinemaBarSystem.NativeFieldInfoPtr_top = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemaBarSystem>.NativeClassPtr, nameof (top));
    CinemaBarSystem.NativeFieldInfoPtr_bottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemaBarSystem>.NativeClassPtr, nameof (bottom));
    CinemaBarSystem.NativeFieldInfoPtr_Top = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemaBarSystem>.NativeClassPtr, nameof (Top));
    CinemaBarSystem.NativeFieldInfoPtr_Bottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemaBarSystem>.NativeClassPtr, nameof (Bottom));
    CinemaBarSystem.NativeFieldInfoPtr_from = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemaBarSystem>.NativeClassPtr, nameof (from));
    CinemaBarSystem.NativeFieldInfoPtr_to = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemaBarSystem>.NativeClassPtr, nameof (to));
    CinemaBarSystem.NativeFieldInfoPtr_inDur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemaBarSystem>.NativeClassPtr, nameof (inDur));
    CinemaBarSystem.NativeFieldInfoPtr_inEase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemaBarSystem>.NativeClassPtr, nameof (inEase));
    CinemaBarSystem.NativeFieldInfoPtr_outDur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemaBarSystem>.NativeClassPtr, nameof (outDur));
    CinemaBarSystem.NativeFieldInfoPtr_outEase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemaBarSystem>.NativeClassPtr, nameof (outEase));
    CinemaBarSystem.NativeMethodInfoPtr_get_instance_Private_Static_get_CinemaBarSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemaBarSystem>.NativeClassPtr, 100667996);
    CinemaBarSystem.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemaBarSystem>.NativeClassPtr, 100667997);
    CinemaBarSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemaBarSystem>.NativeClassPtr, 100667998);
    CinemaBarSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemaBarSystem>.NativeClassPtr, 100667999);
    CinemaBarSystem.NativeMethodInfoPtr_CampaignFinal_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemaBarSystem>.NativeClassPtr, 100668000);
    CinemaBarSystem.NativeMethodInfoPtr_Clear_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemaBarSystem>.NativeClassPtr, 100668001);
    CinemaBarSystem.NativeMethodInfoPtr_SetScript_Public_Static_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemaBarSystem>.NativeClassPtr, 100668002);
    CinemaBarSystem.NativeMethodInfoPtr_Typewrite_Private_Static_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemaBarSystem>.NativeClassPtr, 100668003);
    CinemaBarSystem.NativeMethodInfoPtr_IsActive_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemaBarSystem>.NativeClassPtr, 100668004);
    CinemaBarSystem.NativeMethodInfoPtr_In_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemaBarSystem>.NativeClassPtr, 100668005);
    CinemaBarSystem.NativeMethodInfoPtr_InInstant_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemaBarSystem>.NativeClassPtr, 100668006);
    CinemaBarSystem.NativeMethodInfoPtr_Out_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemaBarSystem>.NativeClassPtr, 100668007);
    CinemaBarSystem.NativeMethodInfoPtr_OutInstant_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemaBarSystem>.NativeClassPtr, 100668008);
    CinemaBarSystem.NativeMethodInfoPtr_SetSortingLayer_Public_Static_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemaBarSystem>.NativeClassPtr, 100668009);
    CinemaBarSystem.NativeMethodInfoPtr_ResetSortingLayer_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemaBarSystem>.NativeClassPtr, 100668010);
    CinemaBarSystem.NativeMethodInfoPtr_SetPosition_Private_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemaBarSystem>.NativeClassPtr, 100668011);
    CinemaBarSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemaBarSystem>.NativeClassPtr, 100668012);
  }

  public CinemaBarSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe CinemaBarSystem _instance
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(CinemaBarSystem.NativeFieldInfoPtr__instance, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CinemaBarSystem) null : new CinemaBarSystem(pointer);
    }
    [param: System.Runtime.InteropServices.In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CinemaBarSystem.NativeFieldInfoPtr__instance, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Canvas canvas
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarSystem.NativeFieldInfoPtr_canvas));
      return pointer == System.IntPtr.Zero ? (Canvas) null : new Canvas(pointer);
    }
    [param: System.Runtime.InteropServices.In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarSystem.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CinemaBarSystem.Section top
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarSystem.NativeFieldInfoPtr_top));
      return pointer == System.IntPtr.Zero ? (CinemaBarSystem.Section) null : new CinemaBarSystem.Section(pointer);
    }
    [param: System.Runtime.InteropServices.In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarSystem.NativeFieldInfoPtr_top), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CinemaBarSystem.Section bottom
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarSystem.NativeFieldInfoPtr_bottom));
      return pointer == System.IntPtr.Zero ? (CinemaBarSystem.Section) null : new CinemaBarSystem.Section(pointer);
    }
    [param: System.Runtime.InteropServices.In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarSystem.NativeFieldInfoPtr_bottom), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe CinemaBarSystem.Section Top
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(CinemaBarSystem.NativeFieldInfoPtr_Top, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CinemaBarSystem.Section) null : new CinemaBarSystem.Section(pointer);
    }
    [param: System.Runtime.InteropServices.In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CinemaBarSystem.NativeFieldInfoPtr_Top, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe CinemaBarSystem.Section Bottom
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(CinemaBarSystem.NativeFieldInfoPtr_Bottom, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CinemaBarSystem.Section) null : new CinemaBarSystem.Section(pointer);
    }
    [param: System.Runtime.InteropServices.In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CinemaBarSystem.NativeFieldInfoPtr_Bottom, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe float from
  {
    get
    {
      float from;
      IL2CPP.il2cpp_field_static_get_value(CinemaBarSystem.NativeFieldInfoPtr_from, (void*) &from);
      return from;
    }
    [param: System.Runtime.InteropServices.In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CinemaBarSystem.NativeFieldInfoPtr_from, (void*) &value);
    }
  }

  public static unsafe float to
  {
    get
    {
      float to;
      IL2CPP.il2cpp_field_static_get_value(CinemaBarSystem.NativeFieldInfoPtr_to, (void*) &to);
      return to;
    }
    [param: System.Runtime.InteropServices.In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CinemaBarSystem.NativeFieldInfoPtr_to, (void*) &value);
    }
  }

  public static unsafe float inDur
  {
    get
    {
      float inDur;
      IL2CPP.il2cpp_field_static_get_value(CinemaBarSystem.NativeFieldInfoPtr_inDur, (void*) &inDur);
      return inDur;
    }
    [param: System.Runtime.InteropServices.In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CinemaBarSystem.NativeFieldInfoPtr_inDur, (void*) &value);
    }
  }

  public static unsafe LeanTweenType inEase
  {
    get
    {
      LeanTweenType inEase;
      IL2CPP.il2cpp_field_static_get_value(CinemaBarSystem.NativeFieldInfoPtr_inEase, (void*) &inEase);
      return inEase;
    }
    [param: System.Runtime.InteropServices.In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CinemaBarSystem.NativeFieldInfoPtr_inEase, (void*) &value);
    }
  }

  public static unsafe float outDur
  {
    get
    {
      float outDur;
      IL2CPP.il2cpp_field_static_get_value(CinemaBarSystem.NativeFieldInfoPtr_outDur, (void*) &outDur);
      return outDur;
    }
    [param: System.Runtime.InteropServices.In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CinemaBarSystem.NativeFieldInfoPtr_outDur, (void*) &value);
    }
  }

  public static unsafe LeanTweenType outEase
  {
    get
    {
      LeanTweenType outEase;
      IL2CPP.il2cpp_field_static_get_value(CinemaBarSystem.NativeFieldInfoPtr_outEase, (void*) &outEase);
      return outEase;
    }
    [param: System.Runtime.InteropServices.In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CinemaBarSystem.NativeFieldInfoPtr_outEase, (void*) &value);
    }
  }

  public class State : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_wasActive;
    private static readonly System.IntPtr NativeFieldInfoPtr_topScript;
    private static readonly System.IntPtr NativeFieldInfoPtr_topPrompt;
    private static readonly System.IntPtr NativeFieldInfoPtr_topPromptAction;
    private static readonly System.IntPtr NativeFieldInfoPtr_bottomScript;
    private static readonly System.IntPtr NativeFieldInfoPtr_bottomPrompt;
    private static readonly System.IntPtr NativeFieldInfoPtr_bottomPromptAction;
    private static readonly System.IntPtr NativeFieldInfoPtr_sortingLayerName;
    private static readonly System.IntPtr NativeFieldInfoPtr_sortingOrderInLayer;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Restore_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57433, XrefRangeEnd = 57455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe State()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemaBarSystem.State>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CinemaBarSystem.State.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57455, XrefRangeEnd = 57490, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Restore()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CinemaBarSystem.State.NativeMethodInfoPtr_Restore_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static State()
    {
      Il2CppClassPointerStore<CinemaBarSystem.State>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemaBarSystem>.NativeClassPtr, nameof (State));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemaBarSystem.State>.NativeClassPtr);
      CinemaBarSystem.State.NativeFieldInfoPtr_wasActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemaBarSystem.State>.NativeClassPtr, nameof (wasActive));
      CinemaBarSystem.State.NativeFieldInfoPtr_topScript = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemaBarSystem.State>.NativeClassPtr, nameof (topScript));
      CinemaBarSystem.State.NativeFieldInfoPtr_topPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemaBarSystem.State>.NativeClassPtr, nameof (topPrompt));
      CinemaBarSystem.State.NativeFieldInfoPtr_topPromptAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemaBarSystem.State>.NativeClassPtr, nameof (topPromptAction));
      CinemaBarSystem.State.NativeFieldInfoPtr_bottomScript = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemaBarSystem.State>.NativeClassPtr, nameof (bottomScript));
      CinemaBarSystem.State.NativeFieldInfoPtr_bottomPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemaBarSystem.State>.NativeClassPtr, nameof (bottomPrompt));
      CinemaBarSystem.State.NativeFieldInfoPtr_bottomPromptAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemaBarSystem.State>.NativeClassPtr, nameof (bottomPromptAction));
      CinemaBarSystem.State.NativeFieldInfoPtr_sortingLayerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemaBarSystem.State>.NativeClassPtr, nameof (sortingLayerName));
      CinemaBarSystem.State.NativeFieldInfoPtr_sortingOrderInLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemaBarSystem.State>.NativeClassPtr, nameof (sortingOrderInLayer));
      CinemaBarSystem.State.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemaBarSystem.State>.NativeClassPtr, 100668013);
      CinemaBarSystem.State.NativeMethodInfoPtr_Restore_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemaBarSystem.State>.NativeClassPtr, 100668014);
    }

    public State(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool wasActive
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarSystem.State.NativeFieldInfoPtr_wasActive));
      }
      [param: System.Runtime.InteropServices.In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarSystem.State.NativeFieldInfoPtr_wasActive)) = value;
      }
    }

    public unsafe string topScript
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarSystem.State.NativeFieldInfoPtr_topScript)));
      }
      [param: System.Runtime.InteropServices.In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarSystem.State.NativeFieldInfoPtr_topScript), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string topPrompt
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarSystem.State.NativeFieldInfoPtr_topPrompt)));
      }
      [param: System.Runtime.InteropServices.In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarSystem.State.NativeFieldInfoPtr_topPrompt), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string topPromptAction
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarSystem.State.NativeFieldInfoPtr_topPromptAction)));
      }
      [param: System.Runtime.InteropServices.In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarSystem.State.NativeFieldInfoPtr_topPromptAction), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string bottomScript
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarSystem.State.NativeFieldInfoPtr_bottomScript)));
      }
      [param: System.Runtime.InteropServices.In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarSystem.State.NativeFieldInfoPtr_bottomScript), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string bottomPrompt
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarSystem.State.NativeFieldInfoPtr_bottomPrompt)));
      }
      [param: System.Runtime.InteropServices.In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarSystem.State.NativeFieldInfoPtr_bottomPrompt), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string bottomPromptAction
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarSystem.State.NativeFieldInfoPtr_bottomPromptAction)));
      }
      [param: System.Runtime.InteropServices.In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarSystem.State.NativeFieldInfoPtr_bottomPromptAction), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string sortingLayerName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarSystem.State.NativeFieldInfoPtr_sortingLayerName)));
      }
      [param: System.Runtime.InteropServices.In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarSystem.State.NativeFieldInfoPtr_sortingLayerName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe int sortingOrderInLayer
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarSystem.State.NativeFieldInfoPtr_sortingOrderInLayer));
      }
      [param: System.Runtime.InteropServices.In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarSystem.State.NativeFieldInfoPtr_sortingOrderInLayer)) = value;
      }
    }
  }

  [Serializable]
  public class Section : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_transform;
    private static readonly System.IntPtr NativeFieldInfoPtr_prompt;
    private static readonly System.IntPtr NativeFieldInfoPtr_buttonImage;
    private static readonly System.IntPtr NativeFieldInfoPtr_script;
    private static readonly System.IntPtr NativeFieldInfoPtr_typewriter;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetPrompt_Public_Void_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemovePrompt_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetScript_Public_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveScript_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(17)]
    [CachedScanResults(RefRangeStart = 57492, RefRangeEnd = 57509, XrefRangeStart = 57490, XrefRangeEnd = 57492, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetPrompt(string text, string actionName)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(actionName);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CinemaBarSystem.Section.NativeMethodInfoPtr_SetPrompt_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 57513, RefRangeEnd = 57514, XrefRangeStart = 57509, XrefRangeEnd = 57513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemovePrompt()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CinemaBarSystem.Section.NativeMethodInfoPtr_RemovePrompt_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 57515, RefRangeEnd = 57519, XrefRangeStart = 57514, XrefRangeEnd = 57515, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetScript(string text)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(text)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CinemaBarSystem.Section.NativeMethodInfoPtr_SetScript_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57519, XrefRangeEnd = 57522, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveScript()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CinemaBarSystem.Section.NativeMethodInfoPtr_RemoveScript_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 57527, RefRangeEnd = 57529, XrefRangeStart = 57522, XrefRangeEnd = 57527, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Clear()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CinemaBarSystem.Section.NativeMethodInfoPtr_Clear_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Section()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemaBarSystem.Section>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CinemaBarSystem.Section.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Section()
    {
      Il2CppClassPointerStore<CinemaBarSystem.Section>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemaBarSystem>.NativeClassPtr, nameof (Section));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemaBarSystem.Section>.NativeClassPtr);
      CinemaBarSystem.Section.NativeFieldInfoPtr_transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemaBarSystem.Section>.NativeClassPtr, nameof (transform));
      CinemaBarSystem.Section.NativeFieldInfoPtr_prompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemaBarSystem.Section>.NativeClassPtr, nameof (prompt));
      CinemaBarSystem.Section.NativeFieldInfoPtr_buttonImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemaBarSystem.Section>.NativeClassPtr, nameof (buttonImage));
      CinemaBarSystem.Section.NativeFieldInfoPtr_script = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemaBarSystem.Section>.NativeClassPtr, nameof (script));
      CinemaBarSystem.Section.NativeFieldInfoPtr_typewriter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemaBarSystem.Section>.NativeClassPtr, nameof (typewriter));
      CinemaBarSystem.Section.NativeMethodInfoPtr_SetPrompt_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemaBarSystem.Section>.NativeClassPtr, 100668015);
      CinemaBarSystem.Section.NativeMethodInfoPtr_RemovePrompt_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemaBarSystem.Section>.NativeClassPtr, 100668016);
      CinemaBarSystem.Section.NativeMethodInfoPtr_SetScript_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemaBarSystem.Section>.NativeClassPtr, 100668017);
      CinemaBarSystem.Section.NativeMethodInfoPtr_RemoveScript_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemaBarSystem.Section>.NativeClassPtr, 100668018);
      CinemaBarSystem.Section.NativeMethodInfoPtr_Clear_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemaBarSystem.Section>.NativeClassPtr, 100668019);
      CinemaBarSystem.Section.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemaBarSystem.Section>.NativeClassPtr, 100668020);
    }

    public Section(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe RectTransform transform
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarSystem.Section.NativeFieldInfoPtr_transform));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: System.Runtime.InteropServices.In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarSystem.Section.NativeFieldInfoPtr_transform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text prompt
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarSystem.Section.NativeFieldInfoPtr_prompt));
        return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: System.Runtime.InteropServices.In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarSystem.Section.NativeFieldInfoPtr_prompt), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ControllerButtonImage buttonImage
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarSystem.Section.NativeFieldInfoPtr_buttonImage));
        return pointer == System.IntPtr.Zero ? (ControllerButtonImage) null : new ControllerButtonImage(pointer);
      }
      [param: System.Runtime.InteropServices.In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarSystem.Section.NativeFieldInfoPtr_buttonImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text script
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarSystem.Section.NativeFieldInfoPtr_script));
        return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: System.Runtime.InteropServices.In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarSystem.Section.NativeFieldInfoPtr_script), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TextTypewrite typewriter
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarSystem.Section.NativeFieldInfoPtr_typewriter));
        return pointer == System.IntPtr.Zero ? (TextTypewrite) null : new TextTypewrite(pointer);
      }
      [param: System.Runtime.InteropServices.In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarSystem.Section.NativeFieldInfoPtr_typewriter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("CinemaBarSystem/<Typewrite>d__20")]
  public sealed class _Typewrite_d__20 : Il2CppSystem.Object
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
    public unsafe _Typewrite_d__20(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemaBarSystem._Typewrite_d__20>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CinemaBarSystem._Typewrite_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CinemaBarSystem._Typewrite_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57529, XrefRangeEnd = 57531, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CinemaBarSystem._Typewrite_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CinemaBarSystem._Typewrite_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57531, XrefRangeEnd = 57537, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CinemaBarSystem._Typewrite_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CinemaBarSystem._Typewrite_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _Typewrite_d__20()
    {
      Il2CppClassPointerStore<CinemaBarSystem._Typewrite_d__20>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemaBarSystem>.NativeClassPtr, "<Typewrite>d__20");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemaBarSystem._Typewrite_d__20>.NativeClassPtr);
      CinemaBarSystem._Typewrite_d__20.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemaBarSystem._Typewrite_d__20>.NativeClassPtr, "<>1__state");
      CinemaBarSystem._Typewrite_d__20.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemaBarSystem._Typewrite_d__20>.NativeClassPtr, "<>2__current");
      CinemaBarSystem._Typewrite_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemaBarSystem._Typewrite_d__20>.NativeClassPtr, 100668021);
      CinemaBarSystem._Typewrite_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemaBarSystem._Typewrite_d__20>.NativeClassPtr, 100668022);
      CinemaBarSystem._Typewrite_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemaBarSystem._Typewrite_d__20>.NativeClassPtr, 100668023);
      CinemaBarSystem._Typewrite_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemaBarSystem._Typewrite_d__20>.NativeClassPtr, 100668024);
      CinemaBarSystem._Typewrite_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemaBarSystem._Typewrite_d__20>.NativeClassPtr, 100668025);
      CinemaBarSystem._Typewrite_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemaBarSystem._Typewrite_d__20>.NativeClassPtr, 100668026);
    }

    public _Typewrite_d__20(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarSystem._Typewrite_d__20.NativeFieldInfoPtr___1__state));
      }
      [param: System.Runtime.InteropServices.In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarSystem._Typewrite_d__20.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarSystem._Typewrite_d__20.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: System.Runtime.InteropServices.In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemaBarSystem._Typewrite_d__20.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("CinemaBarSystem/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__24_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Out_b__24_0_Internal_Void_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemaBarSystem.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CinemaBarSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57537, XrefRangeEnd = 57542, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Out_b__24_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CinemaBarSystem.__c.NativeMethodInfoPtr__Out_b__24_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static __c()
    {
      Il2CppClassPointerStore<CinemaBarSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemaBarSystem>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemaBarSystem.__c>.NativeClassPtr);
      CinemaBarSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemaBarSystem.__c>.NativeClassPtr, "<>9");
      CinemaBarSystem.__c.NativeFieldInfoPtr___9__24_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemaBarSystem.__c>.NativeClassPtr, "<>9__24_0");
      CinemaBarSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemaBarSystem.__c>.NativeClassPtr, 100668028);
      CinemaBarSystem.__c.NativeMethodInfoPtr__Out_b__24_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemaBarSystem.__c>.NativeClassPtr, 100668029);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe CinemaBarSystem.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CinemaBarSystem.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (CinemaBarSystem.__c) null : new CinemaBarSystem.__c(pointer);
      }
      [param: System.Runtime.InteropServices.In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CinemaBarSystem.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Action __9__24_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CinemaBarSystem.__c.NativeFieldInfoPtr___9__24_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action) null : new Il2CppSystem.Action(pointer);
      }
      [param: System.Runtime.InteropServices.In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CinemaBarSystem.__c.NativeFieldInfoPtr___9__24_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
