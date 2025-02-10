// Decompiled with JetBrains decompiler
// Type: Rewired.Integration.UnityUI.PlayerPointerEventData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Rewired.UI;
using System;
using System.Runtime.InteropServices;
using UnityEngine.EventSystems;

#nullable disable
namespace Rewired.Integration.UnityUI
{
  public class PlayerPointerEventData : PointerEventData
  {
    private static readonly IntPtr NativeFieldInfoPtr__playerId_k__BackingField;
    private static readonly IntPtr NativeFieldInfoPtr__inputSourceIndex_k__BackingField;
    private static readonly IntPtr NativeFieldInfoPtr__mouseSource_k__BackingField;
    private static readonly IntPtr NativeFieldInfoPtr__touchSource_k__BackingField;
    private static readonly IntPtr NativeFieldInfoPtr__sourceType_k__BackingField;
    private static readonly IntPtr NativeFieldInfoPtr__buttonIndex_k__BackingField;
    private static readonly IntPtr NativeMethodInfoPtr_get_playerId_Public_get_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_playerId_Public_set_Void_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_inputSourceIndex_Public_get_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_inputSourceIndex_Public_set_Void_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_mouseSource_Public_get_IMouseInputSource_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_mouseSource_Public_set_Void_IMouseInputSource_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_touchSource_Public_get_ITouchInputSource_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_touchSource_Public_set_Void_ITouchInputSource_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_sourceType_Public_get_PointerEventType_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_sourceType_Public_set_Void_PointerEventType_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_buttonIndex_Public_get_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_buttonIndex_Public_set_Void_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EventSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

    public unsafe int playerId
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayerPointerEventData.NativeMethodInfoPtr_get_playerId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1]
        {
          (IntPtr) &value
        };
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayerPointerEventData.NativeMethodInfoPtr_set_playerId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe int inputSourceIndex
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayerPointerEventData.NativeMethodInfoPtr_get_inputSourceIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1]
        {
          (IntPtr) &value
        };
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayerPointerEventData.NativeMethodInfoPtr_set_inputSourceIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe IMouseInputSource mouseSource
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayerPointerEventData.NativeMethodInfoPtr_get_mouseSource_Public_get_IMouseInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IMouseInputSource) null : new IMouseInputSource(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139654, XrefRangeEnd = 139655, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
        };
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayerPointerEventData.NativeMethodInfoPtr_set_mouseSource_Public_set_Void_IMouseInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ITouchInputSource touchSource
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayerPointerEventData.NativeMethodInfoPtr_get_touchSource_Public_get_ITouchInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (ITouchInputSource) null : new ITouchInputSource(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139655, XrefRangeEnd = 139656, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
        };
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayerPointerEventData.NativeMethodInfoPtr_set_touchSource_Public_set_Void_ITouchInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe PointerEventType sourceType
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayerPointerEventData.NativeMethodInfoPtr_get_sourceType_Public_get_PointerEventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PointerEventType*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1]
        {
          (IntPtr) &value
        };
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayerPointerEventData.NativeMethodInfoPtr_set_sourceType_Public_set_Void_PointerEventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe int buttonIndex
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayerPointerEventData.NativeMethodInfoPtr_get_buttonIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1]
        {
          (IntPtr) &value
        };
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayerPointerEventData.NativeMethodInfoPtr_set_buttonIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139656, XrefRangeEnd = 139657, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PlayerPointerEventData(EventSystem eventSystem)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventSystem)
      };
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerPointerEventData.NativeMethodInfoPtr__ctor_Public_Void_EventSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139657, XrefRangeEnd = 139694, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PlayerPointerEventData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static PlayerPointerEventData()
    {
      Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Integration.UnityUI", nameof (PlayerPointerEventData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr);
      PlayerPointerEventData.NativeFieldInfoPtr__playerId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, "<playerId>k__BackingField");
      PlayerPointerEventData.NativeFieldInfoPtr__inputSourceIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, "<inputSourceIndex>k__BackingField");
      PlayerPointerEventData.NativeFieldInfoPtr__mouseSource_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, "<mouseSource>k__BackingField");
      PlayerPointerEventData.NativeFieldInfoPtr__touchSource_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, "<touchSource>k__BackingField");
      PlayerPointerEventData.NativeFieldInfoPtr__sourceType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, "<sourceType>k__BackingField");
      PlayerPointerEventData.NativeFieldInfoPtr__buttonIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, "<buttonIndex>k__BackingField");
      PlayerPointerEventData.NativeMethodInfoPtr_get_playerId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100678178);
      PlayerPointerEventData.NativeMethodInfoPtr_set_playerId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100678179);
      PlayerPointerEventData.NativeMethodInfoPtr_get_inputSourceIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100678180);
      PlayerPointerEventData.NativeMethodInfoPtr_set_inputSourceIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100678181);
      PlayerPointerEventData.NativeMethodInfoPtr_get_mouseSource_Public_get_IMouseInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100678182);
      PlayerPointerEventData.NativeMethodInfoPtr_set_mouseSource_Public_set_Void_IMouseInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100678183);
      PlayerPointerEventData.NativeMethodInfoPtr_get_touchSource_Public_get_ITouchInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100678184);
      PlayerPointerEventData.NativeMethodInfoPtr_set_touchSource_Public_set_Void_ITouchInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100678185);
      PlayerPointerEventData.NativeMethodInfoPtr_get_sourceType_Public_get_PointerEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100678186);
      PlayerPointerEventData.NativeMethodInfoPtr_set_sourceType_Public_set_Void_PointerEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100678187);
      PlayerPointerEventData.NativeMethodInfoPtr_get_buttonIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100678188);
      PlayerPointerEventData.NativeMethodInfoPtr_set_buttonIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100678189);
      PlayerPointerEventData.NativeMethodInfoPtr__ctor_Public_Void_EventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100678190);
      PlayerPointerEventData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100678191);
    }

    public PlayerPointerEventData(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int _playerId_k__BackingField
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerPointerEventData.NativeFieldInfoPtr__playerId_k__BackingField));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerPointerEventData.NativeFieldInfoPtr__playerId_k__BackingField)) = value;
      }
    }

    public unsafe int _inputSourceIndex_k__BackingField
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerPointerEventData.NativeFieldInfoPtr__inputSourceIndex_k__BackingField));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerPointerEventData.NativeFieldInfoPtr__inputSourceIndex_k__BackingField)) = value;
      }
    }

    public unsafe IMouseInputSource _mouseSource_k__BackingField
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerPointerEventData.NativeFieldInfoPtr__mouseSource_k__BackingField));
        return pointer == IntPtr.Zero ? (IMouseInputSource) null : new IMouseInputSource(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayerPointerEventData.NativeFieldInfoPtr__mouseSource_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ITouchInputSource _touchSource_k__BackingField
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerPointerEventData.NativeFieldInfoPtr__touchSource_k__BackingField));
        return pointer == IntPtr.Zero ? (ITouchInputSource) null : new ITouchInputSource(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayerPointerEventData.NativeFieldInfoPtr__touchSource_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PointerEventType _sourceType_k__BackingField
    {
      get
      {
        return *(PointerEventType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerPointerEventData.NativeFieldInfoPtr__sourceType_k__BackingField));
      }
      [param: In] set
      {
        *(PointerEventType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerPointerEventData.NativeFieldInfoPtr__sourceType_k__BackingField)) = value;
      }
    }

    public unsafe int _buttonIndex_k__BackingField
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerPointerEventData.NativeFieldInfoPtr__buttonIndex_k__BackingField));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerPointerEventData.NativeFieldInfoPtr__buttonIndex_k__BackingField)) = value;
      }
    }
  }
}
