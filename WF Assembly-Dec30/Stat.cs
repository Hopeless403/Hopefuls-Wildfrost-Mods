// Decompiled with JetBrains decompiler
// Type: Stat
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Dead;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
[Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct Stat
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Default;
  private static readonly System.IntPtr NativeFieldInfoPtr_safeCurrent;
  private static readonly System.IntPtr NativeFieldInfoPtr_safeMax;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_current_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_current_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_max_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_max_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Max_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_Stat_Stat_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_Stat_Stat_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Stat_Stat_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_Stat_Stat_SafeInt_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_Stat_Stat_SafeInt_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Stat_Stat_SafeInt_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Stat_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Stat_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_Stat_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_Stat_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Stat_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_Stat_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Int32_Stat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Int32_Stat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_Int32_Stat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_Int32_Stat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Int32_Stat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_Int32_Stat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  [FieldOffset(0)]
  public SafeInt safeCurrent;
  [FieldOffset(8)]
  public SafeInt safeMax;

  public unsafe int current
  {
    [CallerCount(112), CachedScanResults(RefRangeStart = 104059, RefRangeEnd = 104171, XrefRangeStart = 104058, XrefRangeEnd = 104059, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Stat.NativeMethodInfoPtr_get_current_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(40), CachedScanResults(RefRangeStart = 104172, RefRangeEnd = 104212, XrefRangeStart = 104171, XrefRangeEnd = 104172, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Stat.NativeMethodInfoPtr_set_current_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe int max
  {
    [CallerCount(62), CachedScanResults(RefRangeStart = 104213, RefRangeEnd = 104275, XrefRangeStart = 104212, XrefRangeEnd = 104213, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Stat.NativeMethodInfoPtr_get_max_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(30), CachedScanResults(RefRangeStart = 104276, RefRangeEnd = 104306, XrefRangeStart = 104275, XrefRangeEnd = 104276, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Stat.NativeMethodInfoPtr_set_max_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 104308, RefRangeEnd = 104309, XrefRangeStart = 104306, XrefRangeEnd = 104308, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Stat(int value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Stat.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 104311, RefRangeEnd = 104312, XrefRangeStart = 104309, XrefRangeEnd = 104311, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Stat(int current, int max)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &current;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &max;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Stat.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 104314, RefRangeEnd = 104315, XrefRangeStart = 104312, XrefRangeEnd = 104314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Max()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Stat.NativeMethodInfoPtr_Max_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104315, XrefRangeEnd = 104319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Stat operator +(Stat a, int b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Stat.NativeMethodInfoPtr_op_Addition_Public_Static_Stat_Stat_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Stat*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104319, XrefRangeEnd = 104323, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Stat operator -(Stat a, int b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Stat.NativeMethodInfoPtr_op_Subtraction_Public_Static_Stat_Stat_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Stat*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104323, XrefRangeEnd = 104327, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Stat operator *(Stat a, int b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Stat.NativeMethodInfoPtr_op_Multiply_Public_Static_Stat_Stat_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Stat*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 104332, RefRangeEnd = 104334, XrefRangeStart = 104327, XrefRangeEnd = 104332, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Stat operator +(Stat a, SafeInt b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Stat.NativeMethodInfoPtr_op_Addition_Public_Static_Stat_Stat_SafeInt_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Stat*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104334, XrefRangeEnd = 104339, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Stat operator -(Stat a, SafeInt b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Stat.NativeMethodInfoPtr_op_Subtraction_Public_Static_Stat_Stat_SafeInt_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Stat*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104339, XrefRangeEnd = 104344, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Stat operator *(Stat a, SafeInt b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Stat.NativeMethodInfoPtr_op_Multiply_Public_Static_Stat_Stat_SafeInt_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Stat*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104344, XrefRangeEnd = 104345, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool operator ==(Stat a, int b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Stat.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Stat_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104345, XrefRangeEnd = 104346, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool operator !=(Stat a, int b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Stat.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Stat_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104346, XrefRangeEnd = 104347, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool operator >(Stat a, int b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Stat.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_Stat_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104347, XrefRangeEnd = 104348, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool operator >=(Stat a, int b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Stat.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_Stat_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104348, XrefRangeEnd = 104349, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool operator <(Stat a, int b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Stat.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Stat_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104349, XrefRangeEnd = 104350, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool operator <=(Stat a, int b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Stat.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_Stat_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104350, XrefRangeEnd = 104351, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool operator ==(int a, Stat b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Stat.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Int32_Stat_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104351, XrefRangeEnd = 104352, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool operator !=(int a, Stat b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Stat.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Int32_Stat_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104352, XrefRangeEnd = 104353, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool operator >(int a, Stat b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Stat.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_Int32_Stat_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104353, XrefRangeEnd = 104354, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool operator >=(int a, Stat b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Stat.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_Int32_Stat_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104354, XrefRangeEnd = 104355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool operator <(int a, Stat b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Stat.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Int32_Stat_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104355, XrefRangeEnd = 104356, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool operator <=(int a, Stat b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Stat.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_Int32_Stat_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104356, XrefRangeEnd = 104366, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Stat.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104366, XrefRangeEnd = 104371, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object obj)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Stat.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104371, XrefRangeEnd = 104375, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Stat.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  static Stat()
  {
    Il2CppClassPointerStore<Stat>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (Stat));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stat>.NativeClassPtr);
    Stat.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stat>.NativeClassPtr, nameof (Default));
    Stat.NativeFieldInfoPtr_safeCurrent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stat>.NativeClassPtr, nameof (safeCurrent));
    Stat.NativeFieldInfoPtr_safeMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stat>.NativeClassPtr, nameof (safeMax));
    Stat.NativeMethodInfoPtr_get_current_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat>.NativeClassPtr, 100672696);
    Stat.NativeMethodInfoPtr_set_current_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat>.NativeClassPtr, 100672697);
    Stat.NativeMethodInfoPtr_get_max_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat>.NativeClassPtr, 100672698);
    Stat.NativeMethodInfoPtr_set_max_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat>.NativeClassPtr, 100672699);
    Stat.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat>.NativeClassPtr, 100672700);
    Stat.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat>.NativeClassPtr, 100672701);
    Stat.NativeMethodInfoPtr_Max_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat>.NativeClassPtr, 100672702);
    Stat.NativeMethodInfoPtr_op_Addition_Public_Static_Stat_Stat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat>.NativeClassPtr, 100672703);
    Stat.NativeMethodInfoPtr_op_Subtraction_Public_Static_Stat_Stat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat>.NativeClassPtr, 100672704);
    Stat.NativeMethodInfoPtr_op_Multiply_Public_Static_Stat_Stat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat>.NativeClassPtr, 100672705);
    Stat.NativeMethodInfoPtr_op_Addition_Public_Static_Stat_Stat_SafeInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat>.NativeClassPtr, 100672706);
    Stat.NativeMethodInfoPtr_op_Subtraction_Public_Static_Stat_Stat_SafeInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat>.NativeClassPtr, 100672707);
    Stat.NativeMethodInfoPtr_op_Multiply_Public_Static_Stat_Stat_SafeInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat>.NativeClassPtr, 100672708);
    Stat.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Stat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat>.NativeClassPtr, 100672709);
    Stat.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Stat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat>.NativeClassPtr, 100672710);
    Stat.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_Stat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat>.NativeClassPtr, 100672711);
    Stat.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_Stat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat>.NativeClassPtr, 100672712);
    Stat.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Stat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat>.NativeClassPtr, 100672713);
    Stat.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_Stat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat>.NativeClassPtr, 100672714);
    Stat.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Int32_Stat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat>.NativeClassPtr, 100672715);
    Stat.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Int32_Stat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat>.NativeClassPtr, 100672716);
    Stat.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_Int32_Stat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat>.NativeClassPtr, 100672717);
    Stat.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_Int32_Stat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat>.NativeClassPtr, 100672718);
    Stat.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Int32_Stat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat>.NativeClassPtr, 100672719);
    Stat.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_Int32_Stat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat>.NativeClassPtr, 100672720);
    Stat.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat>.NativeClassPtr, 100672721);
    Stat.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat>.NativeClassPtr, 100672722);
    Stat.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat>.NativeClassPtr, 100672723);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Stat>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static unsafe Stat Default
  {
    get
    {
      Stat stat;
      IL2CPP.il2cpp_field_static_get_value(Stat.NativeFieldInfoPtr_Default, (void*) &stat);
      return stat;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Stat.NativeFieldInfoPtr_Default, (void*) &value);
    }
  }
}
