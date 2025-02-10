// Decompiled with JetBrains decompiler
// Type: NexPlugin.StationURL
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace NexPlugin
{
  public class StationURL : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StationURL()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationURL>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StationURL.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static StationURL()
    {
      Il2CppClassPointerStore<StationURL>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NexPlugin", nameof (StationURL));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationURL>.NativeClassPtr);
      StationURL.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationURL>.NativeClassPtr, 100678365);
    }

    public StationURL(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public enum URLType
    {
      unknown,
      prudp,
      prudps,
      udp,
    }

    public enum Flags
    {
      BehindNAT = 1,
      Public = 2,
      DetectedByNatCheck = 4,
      DetectedByNgs = 8,
    }
  }
}
