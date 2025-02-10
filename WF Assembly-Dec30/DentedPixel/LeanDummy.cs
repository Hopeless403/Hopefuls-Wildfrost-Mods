// Decompiled with JetBrains decompiler
// Type: DentedPixel.LeanDummy
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace DentedPixel
{
  public class LeanDummy : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LeanDummy()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeanDummy>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeanDummy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LeanDummy()
    {
      Il2CppClassPointerStore<LeanDummy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DentedPixel", nameof (LeanDummy));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeanDummy>.NativeClassPtr);
      LeanDummy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanDummy>.NativeClassPtr, 100678363);
    }

    public LeanDummy(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
