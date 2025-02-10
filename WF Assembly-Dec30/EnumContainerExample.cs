// Decompiled with JetBrains decompiler
// Type: EnumContainerExample
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class EnumContainerExample : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_objectInfos;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetEnums_Public_Virtual_Final_New_Il2CppReferenceArray_1_EnumInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15247, XrefRangeEnd = 15276, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppReferenceArray<BetaJester.EnumGenerator.EnumInfo> GetEnums()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EnumContainerExample.NativeMethodInfoPtr_GetEnums_Public_Virtual_Final_New_Il2CppReferenceArray_1_EnumInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr nativeObject = num;
    return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<BetaJester.EnumGenerator.EnumInfo>) null : new Il2CppReferenceArray<BetaJester.EnumGenerator.EnumInfo>(nativeObject);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15276, XrefRangeEnd = 15285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe EnumContainerExample()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumContainerExample>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(EnumContainerExample.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static EnumContainerExample()
  {
    Il2CppClassPointerStore<EnumContainerExample>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (EnumContainerExample));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumContainerExample>.NativeClassPtr);
    EnumContainerExample.NativeFieldInfoPtr_objectInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumContainerExample>.NativeClassPtr, nameof (objectInfos));
    EnumContainerExample.NativeMethodInfoPtr_GetEnums_Public_Virtual_Final_New_Il2CppReferenceArray_1_EnumInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumContainerExample>.NativeClassPtr, 100663329);
    EnumContainerExample.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumContainerExample>.NativeClassPtr, 100663330);
  }

  public EnumContainerExample(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe List<ObjectInfo> objectInfos
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnumContainerExample.NativeFieldInfoPtr_objectInfos));
      return pointer == System.IntPtr.Zero ? (List<ObjectInfo>) null : new List<ObjectInfo>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EnumContainerExample.NativeFieldInfoPtr_objectInfos), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("EnumContainerExample/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__1_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetEnums_b__1_0_Internal_String_ObjectInfo_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13287, XrefRangeEnd = 13288, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumContainerExample.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EnumContainerExample.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe string _GetEnums_b__1_0(ObjectInfo x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x)
      };
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(EnumContainerExample.__c.NativeMethodInfoPtr__GetEnums_b__1_0_Internal_String_ObjectInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static __c()
    {
      Il2CppClassPointerStore<EnumContainerExample.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnumContainerExample>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumContainerExample.__c>.NativeClassPtr);
      EnumContainerExample.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumContainerExample.__c>.NativeClassPtr, "<>9");
      EnumContainerExample.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumContainerExample.__c>.NativeClassPtr, "<>9__1_0");
      EnumContainerExample.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumContainerExample.__c>.NativeClassPtr, 100663332);
      EnumContainerExample.__c.NativeMethodInfoPtr__GetEnums_b__1_0_Internal_String_ObjectInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumContainerExample.__c>.NativeClassPtr, 100663333);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe EnumContainerExample.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(EnumContainerExample.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (EnumContainerExample.__c) null : new EnumContainerExample.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EnumContainerExample.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<ObjectInfo, string> __9__1_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(EnumContainerExample.__c.NativeFieldInfoPtr___9__1_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<ObjectInfo, string>) null : new Il2CppSystem.Func<ObjectInfo, string>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EnumContainerExample.__c.NativeFieldInfoPtr___9__1_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
