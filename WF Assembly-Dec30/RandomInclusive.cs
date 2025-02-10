// Decompiled with JetBrains decompiler
// Type: RandomInclusive
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

#nullable disable
public static class RandomInclusive : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_Range_Public_Static_Int32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Range_Public_Static_Single_Single_Single_0;

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 127503, RefRangeEnd = 127505, XrefRangeStart = 127502, XrefRangeEnd = 127503, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int Range(int min, int max)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &min;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &max;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RandomInclusive.NativeMethodInfoPtr_Range_Public_Static_Int32_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127505, XrefRangeEnd = 127506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Range(float min, float max)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &min;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &max;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RandomInclusive.NativeMethodInfoPtr_Range_Public_Static_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  static RandomInclusive()
  {
    Il2CppClassPointerStore<RandomInclusive>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (RandomInclusive));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomInclusive>.NativeClassPtr);
    RandomInclusive.NativeMethodInfoPtr_Range_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomInclusive>.NativeClassPtr, 100676503);
    RandomInclusive.NativeMethodInfoPtr_Range_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomInclusive>.NativeClassPtr, 100676504);
  }

  public RandomInclusive(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
