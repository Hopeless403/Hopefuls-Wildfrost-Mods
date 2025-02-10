// Decompiled with JetBrains decompiler
// Type: EnableIfSetting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class EnableIfSetting : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_key;
  private static readonly IntPtr NativeFieldInfoPtr_type;
  private static readonly IntPtr NativeFieldInfoPtr_expectedBool;
  private static readonly IntPtr NativeFieldInfoPtr_defaultBool;
  private static readonly IntPtr NativeFieldInfoPtr_expectedString;
  private static readonly IntPtr NativeFieldInfoPtr_defaultString;
  private static readonly IntPtr NativeFieldInfoPtr_expectedInt;
  private static readonly IntPtr NativeFieldInfoPtr_defaultInt;
  private static readonly IntPtr NativeFieldInfoPtr_minFloat;
  private static readonly IntPtr NativeFieldInfoPtr_maxFloat;
  private static readonly IntPtr NativeFieldInfoPtr_defaultFloat;
  private static readonly IntPtr NativeMethodInfoPtr_get_TypeBool_Private_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_TypeString_Private_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_TypeInt_Private_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_TypeFloat_Private_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_TypeFloatMin_Private_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_TypeFloatMax_Private_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe bool TypeBool
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(EnableIfSetting.NativeMethodInfoPtr_get_TypeBool_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public unsafe bool TypeString
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 42854, RefRangeEnd = 42855, XrefRangeStart = 42854, XrefRangeEnd = 42854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(EnableIfSetting.NativeMethodInfoPtr_get_TypeString_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public unsafe bool TypeInt
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(EnableIfSetting.NativeMethodInfoPtr_get_TypeInt_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public unsafe bool TypeFloat
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(EnableIfSetting.NativeMethodInfoPtr_get_TypeFloat_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public unsafe bool TypeFloatMin
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 42855, RefRangeEnd = 42857, XrefRangeStart = 42855, XrefRangeEnd = 42855, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(EnableIfSetting.NativeMethodInfoPtr_get_TypeFloatMin_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public unsafe bool TypeFloatMax
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(EnableIfSetting.NativeMethodInfoPtr_get_TypeFloatMax_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42857, XrefRangeEnd = 42867, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(EnableIfSetting.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42867, XrefRangeEnd = 42868, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe EnableIfSetting()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnableIfSetting>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(EnableIfSetting.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static EnableIfSetting()
  {
    Il2CppClassPointerStore<EnableIfSetting>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (EnableIfSetting));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnableIfSetting>.NativeClassPtr);
    EnableIfSetting.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnableIfSetting>.NativeClassPtr, nameof (key));
    EnableIfSetting.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnableIfSetting>.NativeClassPtr, nameof (type));
    EnableIfSetting.NativeFieldInfoPtr_expectedBool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnableIfSetting>.NativeClassPtr, nameof (expectedBool));
    EnableIfSetting.NativeFieldInfoPtr_defaultBool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnableIfSetting>.NativeClassPtr, nameof (defaultBool));
    EnableIfSetting.NativeFieldInfoPtr_expectedString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnableIfSetting>.NativeClassPtr, nameof (expectedString));
    EnableIfSetting.NativeFieldInfoPtr_defaultString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnableIfSetting>.NativeClassPtr, nameof (defaultString));
    EnableIfSetting.NativeFieldInfoPtr_expectedInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnableIfSetting>.NativeClassPtr, nameof (expectedInt));
    EnableIfSetting.NativeFieldInfoPtr_defaultInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnableIfSetting>.NativeClassPtr, nameof (defaultInt));
    EnableIfSetting.NativeFieldInfoPtr_minFloat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnableIfSetting>.NativeClassPtr, nameof (minFloat));
    EnableIfSetting.NativeFieldInfoPtr_maxFloat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnableIfSetting>.NativeClassPtr, nameof (maxFloat));
    EnableIfSetting.NativeFieldInfoPtr_defaultFloat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnableIfSetting>.NativeClassPtr, nameof (defaultFloat));
    EnableIfSetting.NativeMethodInfoPtr_get_TypeBool_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnableIfSetting>.NativeClassPtr, 100666491);
    EnableIfSetting.NativeMethodInfoPtr_get_TypeString_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnableIfSetting>.NativeClassPtr, 100666492);
    EnableIfSetting.NativeMethodInfoPtr_get_TypeInt_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnableIfSetting>.NativeClassPtr, 100666493);
    EnableIfSetting.NativeMethodInfoPtr_get_TypeFloat_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnableIfSetting>.NativeClassPtr, 100666494);
    EnableIfSetting.NativeMethodInfoPtr_get_TypeFloatMin_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnableIfSetting>.NativeClassPtr, 100666495);
    EnableIfSetting.NativeMethodInfoPtr_get_TypeFloatMax_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnableIfSetting>.NativeClassPtr, 100666496);
    EnableIfSetting.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnableIfSetting>.NativeClassPtr, 100666497);
    EnableIfSetting.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnableIfSetting>.NativeClassPtr, 100666498);
  }

  public EnableIfSetting(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe string key
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnableIfSetting.NativeFieldInfoPtr_key)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EnableIfSetting.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe EnableIfSetting.Type type
  {
    get
    {
      return *(EnableIfSetting.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnableIfSetting.NativeFieldInfoPtr_type));
    }
    [param: In] set
    {
      *(EnableIfSetting.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnableIfSetting.NativeFieldInfoPtr_type)) = value;
    }
  }

  public unsafe bool expectedBool
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnableIfSetting.NativeFieldInfoPtr_expectedBool));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnableIfSetting.NativeFieldInfoPtr_expectedBool)) = value;
    }
  }

  public unsafe bool defaultBool
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnableIfSetting.NativeFieldInfoPtr_defaultBool));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnableIfSetting.NativeFieldInfoPtr_defaultBool)) = value;
    }
  }

  public unsafe string expectedString
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnableIfSetting.NativeFieldInfoPtr_expectedString)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EnableIfSetting.NativeFieldInfoPtr_expectedString), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string defaultString
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnableIfSetting.NativeFieldInfoPtr_defaultString)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EnableIfSetting.NativeFieldInfoPtr_defaultString), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string expectedInt
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnableIfSetting.NativeFieldInfoPtr_expectedInt)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EnableIfSetting.NativeFieldInfoPtr_expectedInt), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string defaultInt
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnableIfSetting.NativeFieldInfoPtr_defaultInt)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EnableIfSetting.NativeFieldInfoPtr_defaultInt), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe float minFloat
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnableIfSetting.NativeFieldInfoPtr_minFloat));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnableIfSetting.NativeFieldInfoPtr_minFloat)) = value;
    }
  }

  public unsafe float maxFloat
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnableIfSetting.NativeFieldInfoPtr_maxFloat));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnableIfSetting.NativeFieldInfoPtr_maxFloat)) = value;
    }
  }

  public unsafe float defaultFloat
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnableIfSetting.NativeFieldInfoPtr_defaultFloat));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnableIfSetting.NativeFieldInfoPtr_defaultFloat)) = value;
    }
  }

  public enum Type
  {
    Bool,
    String,
    Int,
    FloatMin,
    FloatMax,
  }
}
