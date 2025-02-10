// Decompiled with JetBrains decompiler
// Type: ControllerButtonImage
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
public class ControllerButtonImage : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_deactivateIfNull;
  private static readonly IntPtr NativeFieldInfoPtr_disableIfNull;
  private static readonly IntPtr NativeFieldInfoPtr_image;
  private static readonly IntPtr NativeFieldInfoPtr__actionName_k__BackingField;
  private static readonly IntPtr NativeMethodInfoPtr_get_actionName_Public_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_actionName_Private_set_Void_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_ButtonStyleChanged_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe string actionName
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 35469, RefRangeEnd = 35472, XrefRangeStart = 35469, XrefRangeEnd = 35472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ControllerButtonImage.NativeMethodInfoPtr_get_actionName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 74975, RefRangeEnd = 74976, XrefRangeStart = 74975, XrefRangeEnd = 74976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ControllerButtonImage.NativeMethodInfoPtr_set_actionName_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89353, XrefRangeEnd = 89365, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ControllerButtonImage.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89365, XrefRangeEnd = 89373, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ControllerButtonImage.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 89389, RefRangeEnd = 89394, XrefRangeStart = 89373, XrefRangeEnd = 89389, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(string actionName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(actionName)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ControllerButtonImage.NativeMethodInfoPtr_Set_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89394, XrefRangeEnd = 89411, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ButtonStyleChanged()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ControllerButtonImage.NativeMethodInfoPtr_ButtonStyleChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ControllerButtonImage()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerButtonImage>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ControllerButtonImage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ControllerButtonImage()
  {
    Il2CppClassPointerStore<ControllerButtonImage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ControllerButtonImage));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerButtonImage>.NativeClassPtr);
    ControllerButtonImage.NativeFieldInfoPtr_deactivateIfNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerButtonImage>.NativeClassPtr, nameof (deactivateIfNull));
    ControllerButtonImage.NativeFieldInfoPtr_disableIfNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerButtonImage>.NativeClassPtr, nameof (disableIfNull));
    ControllerButtonImage.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerButtonImage>.NativeClassPtr, nameof (image));
    ControllerButtonImage.NativeFieldInfoPtr__actionName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerButtonImage>.NativeClassPtr, "<actionName>k__BackingField");
    ControllerButtonImage.NativeMethodInfoPtr_get_actionName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerButtonImage>.NativeClassPtr, 100670886);
    ControllerButtonImage.NativeMethodInfoPtr_set_actionName_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerButtonImage>.NativeClassPtr, 100670887);
    ControllerButtonImage.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerButtonImage>.NativeClassPtr, 100670888);
    ControllerButtonImage.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerButtonImage>.NativeClassPtr, 100670889);
    ControllerButtonImage.NativeMethodInfoPtr_Set_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerButtonImage>.NativeClassPtr, 100670890);
    ControllerButtonImage.NativeMethodInfoPtr_ButtonStyleChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerButtonImage>.NativeClassPtr, 100670891);
    ControllerButtonImage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerButtonImage>.NativeClassPtr, 100670892);
  }

  public ControllerButtonImage(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool deactivateIfNull
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerButtonImage.NativeFieldInfoPtr_deactivateIfNull));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerButtonImage.NativeFieldInfoPtr_deactivateIfNull)) = value;
    }
  }

  public unsafe bool disableIfNull
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerButtonImage.NativeFieldInfoPtr_disableIfNull));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerButtonImage.NativeFieldInfoPtr_disableIfNull)) = value;
    }
  }

  public unsafe Image image
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerButtonImage.NativeFieldInfoPtr_image));
      return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControllerButtonImage.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string _actionName_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerButtonImage.NativeFieldInfoPtr__actionName_k__BackingField)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControllerButtonImage.NativeFieldInfoPtr__actionName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
