// Decompiled with JetBrains decompiler
// Type: StopWatch
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
public static class StopWatch : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_startTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_stopTime;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Milliseconds_Public_Static_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Seconds_Public_Static_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_StopTime_Public_Static_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Stop_Public_Static_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetMilliseconds_Private_Static_Int32_0;

  public static unsafe int Milliseconds
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 127510, RefRangeEnd = 127512, XrefRangeStart = 127506, XrefRangeEnd = 127510, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StopWatch.NativeMethodInfoPtr_get_Milliseconds_Public_Static_get_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public static unsafe float Seconds
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127512, XrefRangeEnd = 127513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StopWatch.NativeMethodInfoPtr_get_Seconds_Public_Static_get_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public static unsafe float StopTime
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127513, XrefRangeEnd = 127517, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StopWatch.NativeMethodInfoPtr_get_StopTime_Public_Static_get_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 127524, RefRangeEnd = 127533, XrefRangeStart = 127517, XrefRangeEnd = 127524, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Start()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StopWatch.NativeMethodInfoPtr_Start_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 127540, RefRangeEnd = 127551, XrefRangeStart = 127533, XrefRangeEnd = 127540, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int Stop()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StopWatch.NativeMethodInfoPtr_Stop_Public_Static_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 127510, RefRangeEnd = 127512, XrefRangeStart = 127510, XrefRangeEnd = 127512, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetMilliseconds()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StopWatch.NativeMethodInfoPtr_GetMilliseconds_Private_Static_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  static StopWatch()
  {
    Il2CppClassPointerStore<StopWatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (StopWatch));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StopWatch>.NativeClassPtr);
    StopWatch.NativeFieldInfoPtr_startTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StopWatch>.NativeClassPtr, nameof (startTime));
    StopWatch.NativeFieldInfoPtr_stopTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StopWatch>.NativeClassPtr, nameof (stopTime));
    StopWatch.NativeMethodInfoPtr_get_Milliseconds_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopWatch>.NativeClassPtr, 100676505);
    StopWatch.NativeMethodInfoPtr_get_Seconds_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopWatch>.NativeClassPtr, 100676506);
    StopWatch.NativeMethodInfoPtr_get_StopTime_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopWatch>.NativeClassPtr, 100676507);
    StopWatch.NativeMethodInfoPtr_Start_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopWatch>.NativeClassPtr, 100676508);
    StopWatch.NativeMethodInfoPtr_Stop_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopWatch>.NativeClassPtr, 100676509);
    StopWatch.NativeMethodInfoPtr_GetMilliseconds_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopWatch>.NativeClassPtr, 100676510);
  }

  public StopWatch(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe Il2CppSystem.Nullable<float> startTime
  {
    get
    {
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<float>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      IL2CPP.il2cpp_field_static_get_value(StopWatch.NativeFieldInfoPtr_startTime, (void*) data);
      return new Il2CppSystem.Nullable<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<float>>.NativeClassPtr, data));
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(StopWatch.NativeFieldInfoPtr_startTime, (void*) IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value)));
    }
  }

  public static unsafe Il2CppSystem.Nullable<float> stopTime
  {
    get
    {
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<float>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      IL2CPP.il2cpp_field_static_get_value(StopWatch.NativeFieldInfoPtr_stopTime, (void*) data);
      return new Il2CppSystem.Nullable<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<float>>.NativeClassPtr, data));
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(StopWatch.NativeFieldInfoPtr_stopTime, (void*) IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value)));
    }
  }
}
