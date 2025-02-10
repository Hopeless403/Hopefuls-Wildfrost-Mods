// Decompiled with JetBrains decompiler
// Type: JoystickButtonStyle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Rewired;
using Rewired.Data.Mapping;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Localization;

#nullable disable
public class JoystickButtonStyle : ScriptableObject
{
  private static readonly System.IntPtr NativeFieldInfoPtr_hardwareMaps;
  private static readonly System.IntPtr NativeFieldInfoPtr_hardwareIdentifier;
  private static readonly System.IntPtr NativeFieldInfoPtr_templateId;
  private static readonly System.IntPtr NativeFieldInfoPtr_tag;
  private static readonly System.IntPtr NativeFieldInfoPtr_elements;
  private static readonly System.IntPtr NativeFieldInfoPtr_type;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_guids_Public_get_IEnumerable_1_Guid_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetElement_Public_ElementButton_Player_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe IEnumerable<Il2CppSystem.Guid> guids
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 109707, RefRangeEnd = 109708, XrefRangeStart = 109688, XrefRangeEnd = 109707, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JoystickButtonStyle.NativeMethodInfoPtr_get_guids_Public_get_IEnumerable_1_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerable<Il2CppSystem.Guid>) null : new IEnumerable<Il2CppSystem.Guid>(pointer);
    }
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 109709, RefRangeEnd = 109712, XrefRangeStart = 109708, XrefRangeEnd = 109709, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe JoystickButtonStyle.ElementButton GetElement(Player player, string actionName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) player);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(actionName);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JoystickButtonStyle.NativeMethodInfoPtr_GetElement_Public_ElementButton_Player_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (JoystickButtonStyle.ElementButton) null : new JoystickButtonStyle.ElementButton(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109712, XrefRangeEnd = 109713, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe JoystickButtonStyle()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JoystickButtonStyle>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JoystickButtonStyle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static JoystickButtonStyle()
  {
    Il2CppClassPointerStore<JoystickButtonStyle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (JoystickButtonStyle));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JoystickButtonStyle>.NativeClassPtr);
    JoystickButtonStyle.NativeFieldInfoPtr_hardwareMaps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoystickButtonStyle>.NativeClassPtr, nameof (hardwareMaps));
    JoystickButtonStyle.NativeFieldInfoPtr_hardwareIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoystickButtonStyle>.NativeClassPtr, nameof (hardwareIdentifier));
    JoystickButtonStyle.NativeFieldInfoPtr_templateId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoystickButtonStyle>.NativeClassPtr, nameof (templateId));
    JoystickButtonStyle.NativeFieldInfoPtr_tag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoystickButtonStyle>.NativeClassPtr, nameof (tag));
    JoystickButtonStyle.NativeFieldInfoPtr_elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoystickButtonStyle>.NativeClassPtr, nameof (elements));
    JoystickButtonStyle.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoystickButtonStyle>.NativeClassPtr, nameof (type));
    JoystickButtonStyle.NativeMethodInfoPtr_get_guids_Public_get_IEnumerable_1_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickButtonStyle>.NativeClassPtr, 100673415);
    JoystickButtonStyle.NativeMethodInfoPtr_GetElement_Public_ElementButton_Player_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickButtonStyle>.NativeClassPtr, 100673416);
    JoystickButtonStyle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickButtonStyle>.NativeClassPtr, 100673417);
  }

  public JoystickButtonStyle(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppReferenceArray<HardwareJoystickMap> hardwareMaps
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoystickButtonStyle.NativeFieldInfoPtr_hardwareMaps));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<HardwareJoystickMap>) null : new Il2CppReferenceArray<HardwareJoystickMap>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JoystickButtonStyle.NativeFieldInfoPtr_hardwareMaps), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string hardwareIdentifier
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoystickButtonStyle.NativeFieldInfoPtr_hardwareIdentifier)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JoystickButtonStyle.NativeFieldInfoPtr_hardwareIdentifier), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe int templateId
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoystickButtonStyle.NativeFieldInfoPtr_templateId));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoystickButtonStyle.NativeFieldInfoPtr_templateId)) = value;
    }
  }

  public unsafe string tag
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoystickButtonStyle.NativeFieldInfoPtr_tag)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JoystickButtonStyle.NativeFieldInfoPtr_tag), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe Il2CppReferenceArray<JoystickButtonStyle.ElementButton> elements
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoystickButtonStyle.NativeFieldInfoPtr_elements));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<JoystickButtonStyle.ElementButton>) null : new Il2CppReferenceArray<JoystickButtonStyle.ElementButton>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JoystickButtonStyle.NativeFieldInfoPtr_elements), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ControllerType type
  {
    get
    {
      return *(ControllerType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoystickButtonStyle.NativeFieldInfoPtr_type));
    }
    [param: In] set
    {
      *(ControllerType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoystickButtonStyle.NativeFieldInfoPtr_type)) = value;
    }
  }

  [Serializable]
  public class ElementButton : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_elementName;
    private static readonly System.IntPtr NativeFieldInfoPtr_buttonSprite;
    private static readonly System.IntPtr NativeFieldInfoPtr_textKey;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_hasSprite_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_text_Public_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe bool hasSprite
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 109686, RefRangeEnd = 109687, XrefRangeStart = 109682, XrefRangeEnd = 109686, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JoystickButtonStyle.ElementButton.NativeMethodInfoPtr_get_hasSprite_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe string text
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 108561, RefRangeEnd = 108569, XrefRangeStart = 108561, XrefRangeEnd = 108569, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(JoystickButtonStyle.ElementButton.NativeMethodInfoPtr_get_text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ElementButton()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JoystickButtonStyle.ElementButton>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JoystickButtonStyle.ElementButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ElementButton()
    {
      Il2CppClassPointerStore<JoystickButtonStyle.ElementButton>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JoystickButtonStyle>.NativeClassPtr, nameof (ElementButton));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JoystickButtonStyle.ElementButton>.NativeClassPtr);
      JoystickButtonStyle.ElementButton.NativeFieldInfoPtr_elementName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoystickButtonStyle.ElementButton>.NativeClassPtr, nameof (elementName));
      JoystickButtonStyle.ElementButton.NativeFieldInfoPtr_buttonSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoystickButtonStyle.ElementButton>.NativeClassPtr, nameof (buttonSprite));
      JoystickButtonStyle.ElementButton.NativeFieldInfoPtr_textKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoystickButtonStyle.ElementButton>.NativeClassPtr, nameof (textKey));
      JoystickButtonStyle.ElementButton.NativeMethodInfoPtr_get_hasSprite_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickButtonStyle.ElementButton>.NativeClassPtr, 100673418);
      JoystickButtonStyle.ElementButton.NativeMethodInfoPtr_get_text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickButtonStyle.ElementButton>.NativeClassPtr, 100673419);
      JoystickButtonStyle.ElementButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickButtonStyle.ElementButton>.NativeClassPtr, 100673420);
    }

    public ElementButton(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string elementName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoystickButtonStyle.ElementButton.NativeFieldInfoPtr_elementName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JoystickButtonStyle.ElementButton.NativeFieldInfoPtr_elementName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe Sprite buttonSprite
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoystickButtonStyle.ElementButton.NativeFieldInfoPtr_buttonSprite));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JoystickButtonStyle.ElementButton.NativeFieldInfoPtr_buttonSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedString textKey
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoystickButtonStyle.ElementButton.NativeFieldInfoPtr_textKey));
        return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JoystickButtonStyle.ElementButton.NativeFieldInfoPtr_textKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("JoystickButtonStyle/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__get_guids_b__2_0_Internal_Guid_HardwareJoystickMap_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JoystickButtonStyle.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JoystickButtonStyle.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109687, XrefRangeEnd = 109688, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Il2CppSystem.Guid _get_guids_b__2_0(HardwareJoystickMap a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JoystickButtonStyle.__c.NativeMethodInfoPtr__get_guids_b__2_0_Internal_Guid_HardwareJoystickMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Il2CppSystem.Guid*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<JoystickButtonStyle.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JoystickButtonStyle>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JoystickButtonStyle.__c>.NativeClassPtr);
      JoystickButtonStyle.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoystickButtonStyle.__c>.NativeClassPtr, "<>9");
      JoystickButtonStyle.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoystickButtonStyle.__c>.NativeClassPtr, "<>9__2_0");
      JoystickButtonStyle.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickButtonStyle.__c>.NativeClassPtr, 100673422);
      JoystickButtonStyle.__c.NativeMethodInfoPtr__get_guids_b__2_0_Internal_Guid_HardwareJoystickMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickButtonStyle.__c>.NativeClassPtr, 100673423);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe JoystickButtonStyle.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(JoystickButtonStyle.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (JoystickButtonStyle.__c) null : new JoystickButtonStyle.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(JoystickButtonStyle.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<HardwareJoystickMap, Il2CppSystem.Guid> __9__2_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(JoystickButtonStyle.__c.NativeFieldInfoPtr___9__2_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<HardwareJoystickMap, Il2CppSystem.Guid>) null : new Il2CppSystem.Func<HardwareJoystickMap, Il2CppSystem.Guid>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(JoystickButtonStyle.__c.NativeFieldInfoPtr___9__2_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
