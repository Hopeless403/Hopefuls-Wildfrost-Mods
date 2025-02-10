// Decompiled with JetBrains decompiler
// Type: CustomEventSystem
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
public class CustomEventSystem : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_current;
  private static readonly IntPtr NativeFieldInfoPtr_press;
  private static readonly IntPtr NativeFieldInfoPtr_buttonData;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Hover_Public_Void_GameObject_0;
  private static readonly IntPtr NativeMethodInfoPtr_Unhover_Public_Void_GameObject_0;
  private static readonly IntPtr NativeMethodInfoPtr_Press_Private_Void_GameObject_0;
  private static readonly IntPtr NativeMethodInfoPtr_Release_Private_Void_GameObject_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12962, XrefRangeEnd = 12994, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CustomEventSystem.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12994, XrefRangeEnd = 13005, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Hover(GameObject obj)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CustomEventSystem.NativeMethodInfoPtr_Hover_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13005, XrefRangeEnd = 13021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Unhover(GameObject obj)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CustomEventSystem.NativeMethodInfoPtr_Unhover_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13021, XrefRangeEnd = 13032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Press(GameObject obj)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CustomEventSystem.NativeMethodInfoPtr_Press_Private_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13032, XrefRangeEnd = 13057, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release(GameObject obj)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CustomEventSystem.NativeMethodInfoPtr_Release_Private_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13057, XrefRangeEnd = 13064, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CustomEventSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomEventSystem>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CustomEventSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CustomEventSystem()
  {
    Il2CppClassPointerStore<CustomEventSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CustomEventSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomEventSystem>.NativeClassPtr);
    CustomEventSystem.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomEventSystem>.NativeClassPtr, nameof (current));
    CustomEventSystem.NativeFieldInfoPtr_press = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomEventSystem>.NativeClassPtr, nameof (press));
    CustomEventSystem.NativeFieldInfoPtr_buttonData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomEventSystem>.NativeClassPtr, nameof (buttonData));
    CustomEventSystem.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomEventSystem>.NativeClassPtr, 100663314);
    CustomEventSystem.NativeMethodInfoPtr_Hover_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomEventSystem>.NativeClassPtr, 100663315);
    CustomEventSystem.NativeMethodInfoPtr_Unhover_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomEventSystem>.NativeClassPtr, 100663316);
    CustomEventSystem.NativeMethodInfoPtr_Press_Private_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomEventSystem>.NativeClassPtr, 100663317);
    CustomEventSystem.NativeMethodInfoPtr_Release_Private_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomEventSystem>.NativeClassPtr, 100663318);
    CustomEventSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomEventSystem>.NativeClassPtr, 100663319);
  }

  public CustomEventSystem(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe GameObject current
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomEventSystem.NativeFieldInfoPtr_current));
      return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomEventSystem.NativeFieldInfoPtr_current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject press
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomEventSystem.NativeFieldInfoPtr_press));
      return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomEventSystem.NativeFieldInfoPtr_press), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PointerEventData buttonData
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomEventSystem.NativeFieldInfoPtr_buttonData));
      return pointer == IntPtr.Zero ? (PointerEventData) null : new PointerEventData(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomEventSystem.NativeFieldInfoPtr_buttonData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
