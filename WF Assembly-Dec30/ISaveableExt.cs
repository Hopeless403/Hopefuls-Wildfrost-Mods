// Decompiled with JetBrains decompiler
// Type: ISaveableExt
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

#nullable disable
public static class ISaveableExt : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_SaveArray_Public_Static_Il2CppArrayBase_1_D_IEnumerable_1_S_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SaveArray_Public_Static_Il2CppArrayBase_1_D_Il2CppArrayBase_1_S_0;

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 101886, RefRangeEnd = 101897, XrefRangeStart = 101874, XrefRangeEnd = 101886, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppArrayBase<D> SaveArray<S, D>(this IEnumerable<S> list)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) list)
    };
    System.IntPtr exc;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ISaveableExt.MethodInfoStoreGeneric_SaveArray_Public_Static_Il2CppArrayBase_1_D_IEnumerable_1_S_0<S, D>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return Il2CppArrayBase<D>.WrapNativeGenericArrayPointer(pointer);
  }

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 101886, RefRangeEnd = 101897, XrefRangeStart = 101886, XrefRangeEnd = 101897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppArrayBase<D> SaveArray<S, D>(this Il2CppArrayBase<S> array)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) array)
    };
    System.IntPtr exc;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ISaveableExt.MethodInfoStoreGeneric_SaveArray_Public_Static_Il2CppArrayBase_1_D_Il2CppArrayBase_1_S_0<S, D>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return Il2CppArrayBase<D>.WrapNativeGenericArrayPointer(pointer);
  }

  static ISaveableExt()
  {
    Il2CppClassPointerStore<ISaveableExt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ISaveableExt));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISaveableExt>.NativeClassPtr);
    ISaveableExt.NativeMethodInfoPtr_SaveArray_Public_Static_Il2CppArrayBase_1_D_IEnumerable_1_S_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveableExt>.NativeClassPtr, 100672431);
    ISaveableExt.NativeMethodInfoPtr_SaveArray_Public_Static_Il2CppArrayBase_1_D_Il2CppArrayBase_1_S_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveableExt>.NativeClassPtr, 100672432);
  }

  public ISaveableExt(System.IntPtr pointer)
    : base(pointer)
  {
  }

  [ObfuscatedName("ISaveableExt/<>c__0`2")]
  [Serializable]
  public sealed class __c__0<S, D> : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__0_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__SaveArray_b__0_0_Internal_D_S_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISaveableExt.__c__0<S, D>>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ISaveableExt.__c__0<S, D>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101871, XrefRangeEnd = 101874, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe D _SaveArray_b__0_0(S a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      // ISSUE: variable of a reference type
      S& local1;
      if (!typeof (S).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<S> local2 = (object) a;
        if (!(local2 is string))
        {
          System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
          // ISSUE: cast to a reference type
          // ISSUE: cast to a reference type
          // ISSUE: cast to a reference type
          local1 = ptr == System.IntPtr.Zero ? (S&) ptr : (!IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ptr)) ? (S&) ptr : (S&) IL2CPP.il2cpp_object_unbox(ptr));
        }
        else
        {
          // ISSUE: cast to a reference type
          local1 = (S&) IL2CPP.ManagedStringToIl2Cpp(local2 as string);
        }
      }
      else
        local1 = ref a;
      *numPtr2 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(ISaveableExt.__c__0<S, D>.NativeMethodInfoPtr__SaveArray_b__0_0_Internal_D_S_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.PointerToValueGeneric<D>(objectPointer, false, true);
    }

    static __c__0()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<ISaveableExt.__c__0<S, D>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISaveableExt>.NativeClassPtr, "<>c__0`2"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<S>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<D>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISaveableExt.__c__0<S, D>>.NativeClassPtr);
      ISaveableExt.__c__0<S, D>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISaveableExt.__c__0<S, D>>.NativeClassPtr, "<>9");
      ISaveableExt.__c__0<S, D>.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISaveableExt.__c__0<S, D>>.NativeClassPtr, "<>9__0_0");
      ISaveableExt.__c__0<S, D>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveableExt.__c__0<S, D>>.NativeClassPtr, 100672434);
      ISaveableExt.__c__0<S, D>.NativeMethodInfoPtr__SaveArray_b__0_0_Internal_D_S_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveableExt.__c__0<S, D>>.NativeClassPtr, 100672435);
    }

    public __c__0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe ISaveableExt.__c__0<S, D> __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ISaveableExt.__c__0<S, D>.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (ISaveableExt.__c__0<S, D>) null : new ISaveableExt.__c__0<S, D>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ISaveableExt.__c__0<S, D>.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<S, D> __9__0_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ISaveableExt.__c__0<S, D>.NativeFieldInfoPtr___9__0_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<S, D>) null : new Il2CppSystem.Func<S, D>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ISaveableExt.__c__0<S, D>.NativeFieldInfoPtr___9__0_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("ISaveableExt/<>c__1`2")]
  [Serializable]
  public sealed class __c__1<S, D> : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__1_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__SaveArray_b__1_0_Internal_D_S_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__1()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISaveableExt.__c__1<S, D>>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ISaveableExt.__c__1<S, D>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe D _SaveArray_b__1_0(S a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      // ISSUE: variable of a reference type
      S& local1;
      if (!typeof (S).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<S> local2 = (object) a;
        if (!(local2 is string))
        {
          System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
          // ISSUE: cast to a reference type
          // ISSUE: cast to a reference type
          // ISSUE: cast to a reference type
          local1 = ptr == System.IntPtr.Zero ? (S&) ptr : (!IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ptr)) ? (S&) ptr : (S&) IL2CPP.il2cpp_object_unbox(ptr));
        }
        else
        {
          // ISSUE: cast to a reference type
          local1 = (S&) IL2CPP.ManagedStringToIl2Cpp(local2 as string);
        }
      }
      else
        local1 = ref a;
      *numPtr2 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(ISaveableExt.__c__1<S, D>.NativeMethodInfoPtr__SaveArray_b__1_0_Internal_D_S_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.PointerToValueGeneric<D>(objectPointer, false, true);
    }

    static __c__1()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<ISaveableExt.__c__1<S, D>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISaveableExt>.NativeClassPtr, "<>c__1`2"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<S>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<D>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISaveableExt.__c__1<S, D>>.NativeClassPtr);
      ISaveableExt.__c__1<S, D>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISaveableExt.__c__1<S, D>>.NativeClassPtr, "<>9");
      ISaveableExt.__c__1<S, D>.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISaveableExt.__c__1<S, D>>.NativeClassPtr, "<>9__1_0");
      ISaveableExt.__c__1<S, D>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveableExt.__c__1<S, D>>.NativeClassPtr, 100672437);
      ISaveableExt.__c__1<S, D>.NativeMethodInfoPtr__SaveArray_b__1_0_Internal_D_S_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveableExt.__c__1<S, D>>.NativeClassPtr, 100672438);
    }

    public __c__1(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe ISaveableExt.__c__1<S, D> __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ISaveableExt.__c__1<S, D>.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (ISaveableExt.__c__1<S, D>) null : new ISaveableExt.__c__1<S, D>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ISaveableExt.__c__1<S, D>.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<S, D> __9__1_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ISaveableExt.__c__1<S, D>.NativeFieldInfoPtr___9__1_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<S, D>) null : new Il2CppSystem.Func<S, D>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ISaveableExt.__c__1<S, D>.NativeFieldInfoPtr___9__1_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  private sealed class MethodInfoStoreGeneric_SaveArray_Public_Static_Il2CppArrayBase_1_D_IEnumerable_1_S_0<S, D>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ISaveableExt.NativeMethodInfoPtr_SaveArray_Public_Static_Il2CppArrayBase_1_D_IEnumerable_1_S_0, Il2CppClassPointerStore<ISaveableExt>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<S>.NativeClassPtr)),
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<D>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_SaveArray_Public_Static_Il2CppArrayBase_1_D_Il2CppArrayBase_1_S_0<S, D>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ISaveableExt.NativeMethodInfoPtr_SaveArray_Public_Static_Il2CppArrayBase_1_D_Il2CppArrayBase_1_S_0, Il2CppClassPointerStore<ISaveableExt>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<S>.NativeClassPtr)),
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<D>.NativeClassPtr))
    }))));
  }
}
