// Decompiled with JetBrains decompiler
// Type: DebugMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

#nullable disable
public class DebugMenu : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_menu;
  private static readonly IntPtr NativeFieldInfoPtr_holdTime;
  private static readonly IntPtr NativeFieldInfoPtr_resultText;
  private static readonly IntPtr NativeFieldInfoPtr_currentHoldTime;
  private static readonly IntPtr NativeFieldInfoPtr_active;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckMouse_Private_Static_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckController_Private_Static_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_Activate_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_DeleteSave_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_ResetTutorial_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_RunCommand_Public_Void_String_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42528, XrefRangeEnd = 42564, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugMenu.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42564, XrefRangeEnd = 42568, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool CheckMouse()
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenu.NativeMethodInfoPtr_CheckMouse_Private_Static_Boolean_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42568, XrefRangeEnd = 42585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool CheckController()
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugMenu.NativeMethodInfoPtr_CheckController_Private_Static_Boolean_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42585, XrefRangeEnd = 42590, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Activate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugMenu.NativeMethodInfoPtr_Activate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42590, XrefRangeEnd = 42593, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Deactivate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugMenu.NativeMethodInfoPtr_Deactivate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42593, XrefRangeEnd = 42631, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DeleteSave()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugMenu.NativeMethodInfoPtr_DeleteSave_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42631, XrefRangeEnd = 42640, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ResetTutorial()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugMenu.NativeMethodInfoPtr_ResetTutorial_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42640, XrefRangeEnd = 42649, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RunCommand(string command)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(command)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugMenu.NativeMethodInfoPtr_RunCommand_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42649, XrefRangeEnd = 42650, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DebugMenu()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugMenu>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static DebugMenu()
  {
    Il2CppClassPointerStore<DebugMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (DebugMenu));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugMenu>.NativeClassPtr);
    DebugMenu.NativeFieldInfoPtr_menu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenu>.NativeClassPtr, nameof (menu));
    DebugMenu.NativeFieldInfoPtr_holdTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenu>.NativeClassPtr, nameof (holdTime));
    DebugMenu.NativeFieldInfoPtr_resultText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenu>.NativeClassPtr, nameof (resultText));
    DebugMenu.NativeFieldInfoPtr_currentHoldTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenu>.NativeClassPtr, nameof (currentHoldTime));
    DebugMenu.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenu>.NativeClassPtr, nameof (active));
    DebugMenu.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenu>.NativeClassPtr, 100666451);
    DebugMenu.NativeMethodInfoPtr_CheckMouse_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenu>.NativeClassPtr, 100666452);
    DebugMenu.NativeMethodInfoPtr_CheckController_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenu>.NativeClassPtr, 100666453);
    DebugMenu.NativeMethodInfoPtr_Activate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenu>.NativeClassPtr, 100666454);
    DebugMenu.NativeMethodInfoPtr_Deactivate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenu>.NativeClassPtr, 100666455);
    DebugMenu.NativeMethodInfoPtr_DeleteSave_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenu>.NativeClassPtr, 100666456);
    DebugMenu.NativeMethodInfoPtr_ResetTutorial_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenu>.NativeClassPtr, 100666457);
    DebugMenu.NativeMethodInfoPtr_RunCommand_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenu>.NativeClassPtr, 100666458);
    DebugMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenu>.NativeClassPtr, 100666459);
  }

  public DebugMenu(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe GameObject menu
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugMenu.NativeFieldInfoPtr_menu));
      return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugMenu.NativeFieldInfoPtr_menu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float holdTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugMenu.NativeFieldInfoPtr_holdTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugMenu.NativeFieldInfoPtr_holdTime)) = value;
    }
  }

  public unsafe TMP_Text resultText
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugMenu.NativeFieldInfoPtr_resultText));
      return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugMenu.NativeFieldInfoPtr_resultText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float currentHoldTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugMenu.NativeFieldInfoPtr_currentHoldTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugMenu.NativeFieldInfoPtr_currentHoldTime)) = value;
    }
  }

  public unsafe bool active
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugMenu.NativeFieldInfoPtr_active));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugMenu.NativeFieldInfoPtr_active)) = value;
    }
  }
}
