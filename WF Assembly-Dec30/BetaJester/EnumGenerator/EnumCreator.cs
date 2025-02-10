// Decompiled with JetBrains decompiler
// Type: BetaJester.EnumGenerator.EnumCreator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace BetaJester.EnumGenerator
{
  public class EnumCreator : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_isPerScene;
    private static readonly System.IntPtr NativeFieldInfoPtr_whiteSpaceReplacement;
    private static readonly System.IntPtr NativeFieldInfoPtr_namespaceName;
    private static readonly System.IntPtr NativeFieldInfoPtr_filePathOverride;
    private static readonly System.IntPtr NativeFieldInfoPtr_enumInfo;
    private static readonly System.IntPtr NativeFieldInfoPtr_enumContainers;
    private static readonly System.IntPtr NativeFieldInfoPtr_createdValues;
    private static readonly System.IntPtr NativeMethodInfoPtr_StringToEnum_Public_Static_T_String_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EnumToString_Public_Static_String_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    public static unsafe T StringToEnum<T>(string value, T defaultValue) where T : new()
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(value);
      System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) defaultValue;
        if (!(local2 is string))
        {
          System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
          // ISSUE: cast to a reference type
          // ISSUE: cast to a reference type
          // ISSUE: cast to a reference type
          local1 = ptr == System.IntPtr.Zero ? (T&) ptr : (!IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ptr)) ? (T&) ptr : (T&) IL2CPP.il2cpp_object_unbox(ptr));
        }
        else
        {
          // ISSUE: cast to a reference type
          local1 = (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string);
        }
      }
      else
        local1 = ref defaultValue;
      *(System.IntPtr*) num = (System.IntPtr) ref local1;
      System.IntPtr exc;
      System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(EnumCreator.MethodInfoStoreGeneric_StringToEnum_Public_Static_T_String_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142884, XrefRangeEnd = 142898, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string EnumToString<T>(T value)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) value;
        if (!(local2 is string))
        {
          System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
          // ISSUE: cast to a reference type
          // ISSUE: cast to a reference type
          // ISSUE: cast to a reference type
          local1 = ptr == System.IntPtr.Zero ? (T&) ptr : (!IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ptr)) ? (T&) ptr : (T&) IL2CPP.il2cpp_object_unbox(ptr));
        }
        else
        {
          // ISSUE: cast to a reference type
          local1 = (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string);
        }
      }
      else
        local1 = ref value;
      *numPtr2 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(EnumCreator.MethodInfoStoreGeneric_EnumToString_Public_Static_String_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142898, XrefRangeEnd = 142915, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EnumCreator()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumCreator>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EnumCreator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static EnumCreator()
    {
      Il2CppClassPointerStore<EnumCreator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "BetaJester.EnumGenerator", nameof (EnumCreator));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumCreator>.NativeClassPtr);
      EnumCreator.NativeFieldInfoPtr_isPerScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumCreator>.NativeClassPtr, nameof (isPerScene));
      EnumCreator.NativeFieldInfoPtr_whiteSpaceReplacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumCreator>.NativeClassPtr, nameof (whiteSpaceReplacement));
      EnumCreator.NativeFieldInfoPtr_namespaceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumCreator>.NativeClassPtr, nameof (namespaceName));
      EnumCreator.NativeFieldInfoPtr_filePathOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumCreator>.NativeClassPtr, nameof (filePathOverride));
      EnumCreator.NativeFieldInfoPtr_enumInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumCreator>.NativeClassPtr, nameof (enumInfo));
      EnumCreator.NativeFieldInfoPtr_enumContainers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumCreator>.NativeClassPtr, nameof (enumContainers));
      EnumCreator.NativeFieldInfoPtr_createdValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumCreator>.NativeClassPtr, nameof (createdValues));
      EnumCreator.NativeMethodInfoPtr_StringToEnum_Public_Static_T_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumCreator>.NativeClassPtr, 100678461);
      EnumCreator.NativeMethodInfoPtr_EnumToString_Public_Static_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumCreator>.NativeClassPtr, 100678462);
      EnumCreator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumCreator>.NativeClassPtr, 100678463);
    }

    public EnumCreator(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool isPerScene
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnumCreator.NativeFieldInfoPtr_isPerScene));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnumCreator.NativeFieldInfoPtr_isPerScene)) = value;
      }
    }

    public static unsafe char whiteSpaceReplacement
    {
      get
      {
        char spaceReplacement;
        IL2CPP.il2cpp_field_static_get_value(EnumCreator.NativeFieldInfoPtr_whiteSpaceReplacement, (void*) &spaceReplacement);
        return spaceReplacement;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EnumCreator.NativeFieldInfoPtr_whiteSpaceReplacement, (void*) &value);
      }
    }

    public unsafe string namespaceName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnumCreator.NativeFieldInfoPtr_namespaceName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EnumCreator.NativeFieldInfoPtr_namespaceName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string filePathOverride
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnumCreator.NativeFieldInfoPtr_filePathOverride)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EnumCreator.NativeFieldInfoPtr_filePathOverride), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe Il2CppReferenceArray<EnumInfo> enumInfo
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnumCreator.NativeFieldInfoPtr_enumInfo));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<EnumInfo>) null : new Il2CppReferenceArray<EnumInfo>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EnumCreator.NativeFieldInfoPtr_enumInfo), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<GameObject> enumContainers
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnumCreator.NativeFieldInfoPtr_enumContainers));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<GameObject>) null : new Il2CppReferenceArray<GameObject>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EnumCreator.NativeFieldInfoPtr_enumContainers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<EnumCreator.EnumValRef> createdValues
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnumCreator.NativeFieldInfoPtr_createdValues));
        return pointer == System.IntPtr.Zero ? (List<EnumCreator.EnumValRef>) null : new List<EnumCreator.EnumValRef>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EnumCreator.NativeFieldInfoPtr_createdValues), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public sealed class EnumValRef : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_enumName;
      private static readonly System.IntPtr NativeFieldInfoPtr_enumVal;
      private static readonly System.IntPtr NativeFieldInfoPtr_enumIntVal;

      static EnumValRef()
      {
        Il2CppClassPointerStore<EnumCreator.EnumValRef>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnumCreator>.NativeClassPtr, nameof (EnumValRef));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumCreator.EnumValRef>.NativeClassPtr);
        EnumCreator.EnumValRef.NativeFieldInfoPtr_enumName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumCreator.EnumValRef>.NativeClassPtr, nameof (enumName));
        EnumCreator.EnumValRef.NativeFieldInfoPtr_enumVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumCreator.EnumValRef>.NativeClassPtr, nameof (enumVal));
        EnumCreator.EnumValRef.NativeFieldInfoPtr_enumIntVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumCreator.EnumValRef>.NativeClassPtr, nameof (enumIntVal));
      }

      public EnumValRef(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public EnumValRef()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<EnumCreator.EnumValRef>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EnumCreator.EnumValRef>.NativeClassPtr, data));
      }

      public unsafe string enumName
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnumCreator.EnumValRef.NativeFieldInfoPtr_enumName)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EnumCreator.EnumValRef.NativeFieldInfoPtr_enumName), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe string enumVal
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnumCreator.EnumValRef.NativeFieldInfoPtr_enumVal)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EnumCreator.EnumValRef.NativeFieldInfoPtr_enumVal), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe int enumIntVal
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnumCreator.EnumValRef.NativeFieldInfoPtr_enumIntVal));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnumCreator.EnumValRef.NativeFieldInfoPtr_enumIntVal)) = value;
        }
      }
    }

    private sealed class MethodInfoStoreGeneric_StringToEnum_Public_Static_T_String_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(EnumCreator.NativeMethodInfoPtr_StringToEnum_Public_Static_T_String_T_0, Il2CppClassPointerStore<EnumCreator>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_EnumToString_Public_Static_String_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(EnumCreator.NativeMethodInfoPtr_EnumToString_Public_Static_String_T_0, Il2CppClassPointerStore<EnumCreator>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
