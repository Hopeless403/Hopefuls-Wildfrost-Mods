// Decompiled with JetBrains decompiler
// Type: GenericCompare`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
public class GenericCompare<T> : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr__ComparerFunction_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ComparerFunction_Private_set_Void_Func_3_T_T_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ComparerFunction_Private_get_Func_3_T_T_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_3_T_T_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_T_T_0;

  public unsafe Il2CppSystem.Func<T, T, int> ComparerFunction
  {
    [CallerCount(21), CachedScanResults(RefRangeStart = 20073, RefRangeEnd = 20094, XrefRangeStart = 20072, XrefRangeEnd = 20073, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GenericCompare<T>.NativeMethodInfoPtr_set_ComparerFunction_Private_set_Void_Func_3_T_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
    [CallerCount(10), CachedScanResults(RefRangeStart = 20094, RefRangeEnd = 20104, XrefRangeStart = 20094, XrefRangeEnd = 20094, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GenericCompare<T>.NativeMethodInfoPtr_get_ComparerFunction_Private_get_Func_3_T_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<T, T, int>) null : new Il2CppSystem.Func<T, T, int>(pointer);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20104, XrefRangeEnd = 20106, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GenericCompare(Il2CppSystem.Func<T, T, int> comparerFunction)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericCompare<T>>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) comparerFunction)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(GenericCompare<T>.NativeMethodInfoPtr__ctor_Public_Void_Func_3_T_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public virtual unsafe int Compare(T x, T y)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) x;
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
      local1 = ref x;
    *numPtr2 = (System.IntPtr) ref local1;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    T& local3;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local4 = (object) y;
      if (!(local4 is string))
      {
        System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr(local4 as Il2CppObjectBase);
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local3 = ptr == System.IntPtr.Zero ? (T&) ptr : (!IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ptr)) ? (T&) ptr : (T&) IL2CPP.il2cpp_object_unbox(ptr));
      }
      else
      {
        // ISSUE: cast to a reference type
        local3 = (T&) IL2CPP.ManagedStringToIl2Cpp(local4 as string);
      }
    }
    else
      local3 = ref y;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local3;
    System.IntPtr exc;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GenericCompare<T>.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_T_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  static GenericCompare()
  {
    // ISSUE: explicit non-virtual call
    // ISSUE: explicit non-virtual call
    Il2CppClassPointerStore<GenericCompare<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GenericCompare`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))).TypeHandle).value);
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericCompare<T>>.NativeClassPtr);
    GenericCompare<T>.NativeFieldInfoPtr__ComparerFunction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericCompare<T>>.NativeClassPtr, "<ComparerFunction>k__BackingField");
    GenericCompare<T>.NativeMethodInfoPtr_set_ComparerFunction_Private_set_Void_Func_3_T_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericCompare<T>>.NativeClassPtr, 100663756);
    GenericCompare<T>.NativeMethodInfoPtr_get_ComparerFunction_Private_get_Func_3_T_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericCompare<T>>.NativeClassPtr, 100663757);
    GenericCompare<T>.NativeMethodInfoPtr__ctor_Public_Void_Func_3_T_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericCompare<T>>.NativeClassPtr, 100663758);
    GenericCompare<T>.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericCompare<T>>.NativeClassPtr, 100663759);
  }

  public GenericCompare(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppSystem.Func<T, T, int> _ComparerFunction_k__BackingField
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericCompare<T>.NativeFieldInfoPtr__ComparerFunction_k__BackingField));
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<T, T, int>) null : new Il2CppSystem.Func<T, T, int>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GenericCompare<T>.NativeFieldInfoPtr__ComparerFunction_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
