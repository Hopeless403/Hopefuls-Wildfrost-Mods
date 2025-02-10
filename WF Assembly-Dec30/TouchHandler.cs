// Decompiled with JetBrains decompiler
// Type: TouchHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
public class TouchHandler : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_hoverBeforePress;
  private static readonly IntPtr NativeMethodInfoPtr_CanTouchPress_Public_Boolean_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_HandleTouchPress_Public_Void_PointerEventData_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  public unsafe bool CanTouchPress(bool alreadyHovered)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &alreadyHovered
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(TouchHandler.NativeMethodInfoPtr_CanTouchPress_Public_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17396, XrefRangeEnd = 17426, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void HandleTouchPress(PointerEventData pointer, bool alreadyHovered)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pointer);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &alreadyHovered;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TouchHandler.NativeMethodInfoPtr_HandleTouchPress_Public_Void_PointerEventData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TouchHandler()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchHandler>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TouchHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static TouchHandler()
  {
    Il2CppClassPointerStore<TouchHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (TouchHandler));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchHandler>.NativeClassPtr);
    TouchHandler.NativeFieldInfoPtr_hoverBeforePress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchHandler>.NativeClassPtr, nameof (hoverBeforePress));
    TouchHandler.NativeMethodInfoPtr_CanTouchPress_Public_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchHandler>.NativeClassPtr, 100663476);
    TouchHandler.NativeMethodInfoPtr_HandleTouchPress_Public_Void_PointerEventData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchHandler>.NativeClassPtr, 100663477);
    TouchHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchHandler>.NativeClassPtr, 100663478);
  }

  public TouchHandler(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool hoverBeforePress
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchHandler.NativeFieldInfoPtr_hoverBeforePress));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchHandler.NativeFieldInfoPtr_hoverBeforePress)) = value;
    }
  }
}
