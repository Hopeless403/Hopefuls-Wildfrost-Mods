// Decompiled with JetBrains decompiler
// Type: StatusIconHealth
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class StatusIconHealth : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_types;
  private static readonly System.IntPtr NativeFieldInfoPtr_current;
  private static readonly System.IntPtr NativeFieldInfoPtr__icon;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_icon_Private_get_StatusIcon_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetType_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe StatusIcon icon
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 54390, RefRangeEnd = 54391, XrefRangeStart = 54386, XrefRangeEnd = 54390, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusIconHealth.NativeMethodInfoPtr_get_icon_Private_get_StatusIcon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (StatusIcon) null : new StatusIcon(pointer);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54391, XrefRangeEnd = 54429, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetType()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusIconHealth.NativeMethodInfoPtr_SetType_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StatusIconHealth()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusIconHealth>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusIconHealth.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static StatusIconHealth()
  {
    Il2CppClassPointerStore<StatusIconHealth>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (StatusIconHealth));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusIconHealth>.NativeClassPtr);
    StatusIconHealth.NativeFieldInfoPtr_types = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusIconHealth>.NativeClassPtr, nameof (types));
    StatusIconHealth.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusIconHealth>.NativeClassPtr, nameof (current));
    StatusIconHealth.NativeFieldInfoPtr__icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusIconHealth>.NativeClassPtr, nameof (_icon));
    StatusIconHealth.NativeMethodInfoPtr_get_icon_Private_get_StatusIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusIconHealth>.NativeClassPtr, 100667769);
    StatusIconHealth.NativeMethodInfoPtr_SetType_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusIconHealth>.NativeClassPtr, 100667770);
    StatusIconHealth.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusIconHealth>.NativeClassPtr, 100667771);
  }

  public StatusIconHealth(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppReferenceArray<StatusIconHealth.Type> types
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusIconHealth.NativeFieldInfoPtr_types));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<StatusIconHealth.Type>) null : new Il2CppReferenceArray<StatusIconHealth.Type>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusIconHealth.NativeFieldInfoPtr_types), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject current
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusIconHealth.NativeFieldInfoPtr_current));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusIconHealth.NativeFieldInfoPtr_current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StatusIcon _icon
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusIconHealth.NativeFieldInfoPtr__icon));
      return pointer == System.IntPtr.Zero ? (StatusIcon) null : new StatusIcon(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusIconHealth.NativeFieldInfoPtr__icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class Type : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_name;
    private static readonly System.IntPtr NativeFieldInfoPtr_group;
    private static readonly System.IntPtr NativeFieldInfoPtr_textElement;
    private static readonly System.IntPtr NativeFieldInfoPtr_fill;
    private static readonly System.IntPtr NativeMethodInfoPtr_Assign_Public_Void_StatusIcon_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54382, XrefRangeEnd = 54386, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Assign(StatusIcon icon)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) icon)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatusIconHealth.Type.NativeMethodInfoPtr_Assign_Public_Void_StatusIcon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Type()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusIconHealth.Type>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatusIconHealth.Type.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Type()
    {
      Il2CppClassPointerStore<StatusIconHealth.Type>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatusIconHealth>.NativeClassPtr, nameof (Type));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusIconHealth.Type>.NativeClassPtr);
      StatusIconHealth.Type.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusIconHealth.Type>.NativeClassPtr, nameof (name));
      StatusIconHealth.Type.NativeFieldInfoPtr_group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusIconHealth.Type>.NativeClassPtr, nameof (group));
      StatusIconHealth.Type.NativeFieldInfoPtr_textElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusIconHealth.Type>.NativeClassPtr, nameof (textElement));
      StatusIconHealth.Type.NativeFieldInfoPtr_fill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusIconHealth.Type>.NativeClassPtr, nameof (fill));
      StatusIconHealth.Type.NativeMethodInfoPtr_Assign_Public_Void_StatusIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusIconHealth.Type>.NativeClassPtr, 100667772);
      StatusIconHealth.Type.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusIconHealth.Type>.NativeClassPtr, 100667773);
    }

    public Type(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusIconHealth.Type.NativeFieldInfoPtr_name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusIconHealth.Type.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe GameObject group
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusIconHealth.Type.NativeFieldInfoPtr_group));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusIconHealth.Type.NativeFieldInfoPtr_group), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text textElement
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusIconHealth.Type.NativeFieldInfoPtr_textElement));
        return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusIconHealth.Type.NativeFieldInfoPtr_textElement), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image fill
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusIconHealth.Type.NativeFieldInfoPtr_fill));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusIconHealth.Type.NativeFieldInfoPtr_fill), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("StatusIconHealth/<>c__DisplayClass5_0")]
  public sealed class __c__DisplayClass5_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_cardTypeName;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__SetType_b__0_Internal_Boolean_Type_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass5_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusIconHealth.__c__DisplayClass5_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatusIconHealth.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _SetType_b__0(StatusIconHealth.Type a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusIconHealth.__c__DisplayClass5_0.NativeMethodInfoPtr__SetType_b__0_Internal_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass5_0()
    {
      Il2CppClassPointerStore<StatusIconHealth.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatusIconHealth>.NativeClassPtr, "<>c__DisplayClass5_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusIconHealth.__c__DisplayClass5_0>.NativeClassPtr);
      StatusIconHealth.__c__DisplayClass5_0.NativeFieldInfoPtr_cardTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusIconHealth.__c__DisplayClass5_0>.NativeClassPtr, nameof (cardTypeName));
      StatusIconHealth.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusIconHealth.__c__DisplayClass5_0>.NativeClassPtr, 100667774);
      StatusIconHealth.__c__DisplayClass5_0.NativeMethodInfoPtr__SetType_b__0_Internal_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusIconHealth.__c__DisplayClass5_0>.NativeClassPtr, 100667775);
    }

    public __c__DisplayClass5_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string cardTypeName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusIconHealth.__c__DisplayClass5_0.NativeFieldInfoPtr_cardTypeName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusIconHealth.__c__DisplayClass5_0.NativeFieldInfoPtr_cardTypeName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
