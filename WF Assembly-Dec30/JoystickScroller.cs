// Decompiled with JetBrains decompiler
// Type: JoystickScroller
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class JoystickScroller : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_scrollAction;
  private static readonly IntPtr NativeFieldInfoPtr__scrollRect;
  private static readonly IntPtr NativeFieldInfoPtr_add;
  private static readonly IntPtr NativeMethodInfoPtr_get_scrollRect_Private_get_ScrollRect_0;
  private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe ScrollRect scrollRect
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 15535, RefRangeEnd = 15538, XrefRangeStart = 15531, XrefRangeEnd = 15535, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(JoystickScroller.NativeMethodInfoPtr_get_scrollRect_Private_get_ScrollRect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (ScrollRect) null : new ScrollRect(pointer);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15538, XrefRangeEnd = 15558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LateUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JoystickScroller.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15558, XrefRangeEnd = 15563, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe JoystickScroller()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JoystickScroller>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JoystickScroller.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static JoystickScroller()
  {
    Il2CppClassPointerStore<JoystickScroller>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (JoystickScroller));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JoystickScroller>.NativeClassPtr);
    JoystickScroller.NativeFieldInfoPtr_scrollAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoystickScroller>.NativeClassPtr, nameof (scrollAction));
    JoystickScroller.NativeFieldInfoPtr__scrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoystickScroller>.NativeClassPtr, nameof (_scrollRect));
    JoystickScroller.NativeFieldInfoPtr_add = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoystickScroller>.NativeClassPtr, nameof (add));
    JoystickScroller.NativeMethodInfoPtr_get_scrollRect_Private_get_ScrollRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickScroller>.NativeClassPtr, 100663353);
    JoystickScroller.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickScroller>.NativeClassPtr, 100663354);
    JoystickScroller.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickScroller>.NativeClassPtr, 100663355);
  }

  public JoystickScroller(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe string scrollAction
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoystickScroller.NativeFieldInfoPtr_scrollAction)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JoystickScroller.NativeFieldInfoPtr_scrollAction), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe ScrollRect _scrollRect
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoystickScroller.NativeFieldInfoPtr__scrollRect));
      return pointer == IntPtr.Zero ? (ScrollRect) null : new ScrollRect(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JoystickScroller.NativeFieldInfoPtr__scrollRect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector2 add
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoystickScroller.NativeFieldInfoPtr_add));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoystickScroller.NativeFieldInfoPtr_add)) = value;
    }
  }
}
