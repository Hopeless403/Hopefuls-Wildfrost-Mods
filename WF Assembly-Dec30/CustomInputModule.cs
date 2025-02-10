// Decompiled with JetBrains decompiler
// Type: CustomInputModule
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
using UnityEngine.EventSystems;

#nullable disable
public class CustomInputModule : StandaloneInputModule
{
  private static readonly IntPtr NativeFieldInfoPtr_unhoverCache;
  private static readonly IntPtr NativeFieldInfoPtr_offscreen;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CardControllerEnabled_Private_Void_CardController_0;
  private static readonly IntPtr NativeMethodInfoPtr_ForceSetMousePosition_Private_Void_Vector2_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetMousePointerEventDataWithPosition_Private_MouseState_Vector2_0;
  private static readonly IntPtr NativeMethodInfoPtr_ProcessMove_Protected_Virtual_Void_PointerEventData_0;
  private static readonly IntPtr NativeMethodInfoPtr_CustomHandlePointerExitAndEnter_Private_Static_Void_PointerEventData_GameObject_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13064, XrefRangeEnd = 13073, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CustomInputModule.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13073, XrefRangeEnd = 13082, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CustomInputModule.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13082, XrefRangeEnd = 13087, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CardControllerEnabled(CardController controller)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) controller)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CustomInputModule.NativeMethodInfoPtr_CardControllerEnabled_Private_Void_CardController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 13111, RefRangeEnd = 13112, XrefRangeStart = 13087, XrefRangeEnd = 13111, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ForceSetMousePosition(Vector2 position)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &position
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CustomInputModule.NativeMethodInfoPtr_ForceSetMousePosition_Private_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 13137, RefRangeEnd = 13138, XrefRangeStart = 13112, XrefRangeEnd = 13137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PointerInputModule.MouseState GetMousePointerEventDataWithPosition(
    Vector2 forcePosition)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &forcePosition
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(CustomInputModule.NativeMethodInfoPtr_GetMousePointerEventDataWithPosition_Private_MouseState_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    IntPtr pointer = num;
    return pointer == IntPtr.Zero ? (PointerInputModule.MouseState) null : new PointerInputModule.MouseState(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13138, XrefRangeEnd = 13156, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void ProcessMove(PointerEventData pointerEvent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pointerEvent)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CustomInputModule.NativeMethodInfoPtr_ProcessMove_Protected_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 13285, RefRangeEnd = 13286, XrefRangeStart = 13156, XrefRangeEnd = 13285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CustomHandlePointerExitAndEnter(
    PointerEventData currentPointerData,
    GameObject newEnterTarget)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) currentPointerData);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) newEnterTarget);
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CustomInputModule.NativeMethodInfoPtr_CustomHandlePointerExitAndEnter_Private_Static_Void_PointerEventData_GameObject_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13286, XrefRangeEnd = 13287, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CustomInputModule()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomInputModule>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CustomInputModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CustomInputModule()
  {
    Il2CppClassPointerStore<CustomInputModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CustomInputModule));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomInputModule>.NativeClassPtr);
    CustomInputModule.NativeFieldInfoPtr_unhoverCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputModule>.NativeClassPtr, nameof (unhoverCache));
    CustomInputModule.NativeFieldInfoPtr_offscreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInputModule>.NativeClassPtr, nameof (offscreen));
    CustomInputModule.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputModule>.NativeClassPtr, 100663320);
    CustomInputModule.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputModule>.NativeClassPtr, 100663321);
    CustomInputModule.NativeMethodInfoPtr_CardControllerEnabled_Private_Void_CardController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputModule>.NativeClassPtr, 100663322);
    CustomInputModule.NativeMethodInfoPtr_ForceSetMousePosition_Private_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputModule>.NativeClassPtr, 100663323);
    CustomInputModule.NativeMethodInfoPtr_GetMousePointerEventDataWithPosition_Private_MouseState_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputModule>.NativeClassPtr, 100663324);
    CustomInputModule.NativeMethodInfoPtr_ProcessMove_Protected_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputModule>.NativeClassPtr, 100663325);
    CustomInputModule.NativeMethodInfoPtr_CustomHandlePointerExitAndEnter_Private_Static_Void_PointerEventData_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputModule>.NativeClassPtr, 100663326);
    CustomInputModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInputModule>.NativeClassPtr, 100663327);
  }

  public CustomInputModule(IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe List<GameObject> unhoverCache
  {
    get
    {
      IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(CustomInputModule.NativeFieldInfoPtr_unhoverCache, (void*) &num);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (List<GameObject>) null : new List<GameObject>(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CustomInputModule.NativeFieldInfoPtr_unhoverCache, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Vector2 offscreen
  {
    get
    {
      Vector2 offscreen;
      IL2CPP.il2cpp_field_static_get_value(CustomInputModule.NativeFieldInfoPtr_offscreen, (void*) &offscreen);
      return offscreen;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CustomInputModule.NativeFieldInfoPtr_offscreen, (void*) &value);
    }
  }
}
