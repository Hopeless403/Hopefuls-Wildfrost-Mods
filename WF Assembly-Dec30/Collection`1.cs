// Decompiled with JetBrains decompiler
// Type: Collection`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class Collection<T> : ScriptableObject where T : class
{
  private static readonly System.IntPtr NativeFieldInfoPtr_nullWeight;
  private static readonly System.IntPtr NativeFieldInfoPtr_weightedList;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddWeight_Public_Void_Int32_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RandomItem_Public_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RandomIndex_Public_Virtual_New_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe T this[int index]
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 109019, RefRangeEnd = 109022, XrefRangeStart = 109019, XrefRangeEnd = 109019, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &index
      };
      System.IntPtr exc;
      System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(Collection<T>.NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
    }
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 109022, RefRangeEnd = 109031, XrefRangeStart = 109022, XrefRangeEnd = 109022, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddWeight(int index, float weight)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &index;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &weight;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Collection<T>.NativeMethodInfoPtr_AddWeight_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 109031, RefRangeEnd = 109032, XrefRangeStart = 109031, XrefRangeEnd = 109031, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe T RandomItem()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(Collection<T>.NativeMethodInfoPtr_RandomItem_Public_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109032, XrefRangeEnd = 109035, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe int RandomIndex()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Collection<T>.NativeMethodInfoPtr_RandomIndex_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(110)]
  [CachedScanResults(RefRangeStart = 104608, RefRangeEnd = 104718, XrefRangeStart = 104608, XrefRangeEnd = 104718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Collection()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Collection<T>>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Collection<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static Collection()
  {
    // ISSUE: explicit non-virtual call
    // ISSUE: explicit non-virtual call
    Il2CppClassPointerStore<Collection<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Collection`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))).TypeHandle).value);
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Collection<T>>.NativeClassPtr);
    Collection<T>.NativeFieldInfoPtr_nullWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collection<T>>.NativeClassPtr, nameof (nullWeight));
    Collection<T>.NativeFieldInfoPtr_weightedList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collection<T>>.NativeClassPtr, nameof (weightedList));
    Collection<T>.NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection<T>>.NativeClassPtr, 100673348);
    Collection<T>.NativeMethodInfoPtr_AddWeight_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection<T>>.NativeClassPtr, 100673349);
    Collection<T>.NativeMethodInfoPtr_RandomItem_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection<T>>.NativeClassPtr, 100673350);
    Collection<T>.NativeMethodInfoPtr_RandomIndex_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection<T>>.NativeClassPtr, 100673351);
    Collection<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collection<T>>.NativeClassPtr, 100673352);
  }

  public Collection(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe float nullWeight
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Collection<T>.NativeFieldInfoPtr_nullWeight));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Collection<T>.NativeFieldInfoPtr_nullWeight)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<Collection<T>.Entry<T>> weightedList
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Collection<T>.NativeFieldInfoPtr_weightedList));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Collection<T>.Entry<T>>) null : new Il2CppReferenceArray<Collection<T>.Entry<T>>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Collection<T>.NativeFieldInfoPtr_weightedList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public sealed class Entry<T1> : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_value;
    private static readonly System.IntPtr NativeFieldInfoPtr_weight;

    static Entry()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<Collection<T>.Entry<T1>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Collection<T>>.NativeClassPtr, "Entry`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Collection<T>.Entry<T1>>.NativeClassPtr);
      Collection<T>.Entry<T1>.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collection<T>.Entry<T1>>.NativeClassPtr, nameof (value));
      Collection<T>.Entry<T1>.NativeFieldInfoPtr_weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collection<T>.Entry<T1>>.NativeClassPtr, nameof (weight));
    }

    public Entry(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Entry()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Collection<T>.Entry<T1>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Collection<T>.Entry<T1>>.NativeClassPtr, data));
    }

    public unsafe T1 value
    {
      get
      {
        return IL2CPP.PointerToValueGeneric<T1>(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Collection<T>.Entry<T1>.NativeFieldInfoPtr_value), true, false);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr targetAddress = ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Collection<T>.Entry<T1>.NativeFieldInfoPtr_value);
        System.Type type = typeof (T1);
        if (!type.IsValueType)
        {
          if (!string.Equals(type.FullName, "System.String"))
          {
            System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((object) value as Il2CppObjectBase);
            if (ptr != System.IntPtr.Zero && IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ptr)))
            {
              System.IntPtr num1 = ptr;
              System.IntPtr num2 = IL2CPP.il2cpp_object_unbox(ptr);
              int num3 = IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(num1), (uint&) System.IntPtr.Zero);
              __memcpy(targetAddress, num2, num3);
            }
            else
              IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, targetAddress, ptr);
          }
          else
          {
            System.IntPtr il2Cpp = IL2CPP.ManagedStringToIl2Cpp((object) value as string);
            IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, targetAddress, il2Cpp);
          }
        }
        else
        {
          T1 obj = value;
          *(T1*) targetAddress = obj;
        }
      }
    }

    public unsafe float weight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Collection<T>.Entry<T1>.NativeFieldInfoPtr_weight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Collection<T>.Entry<T1>.NativeFieldInfoPtr_weight)) = value;
      }
    }
  }
}
