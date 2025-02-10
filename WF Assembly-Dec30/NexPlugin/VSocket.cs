// Decompiled with JetBrains decompiler
// Type: NexPlugin.VSocket
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace NexPlugin
{
  public class VSocket : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_DATA_SIZE;
    private static readonly System.IntPtr NativeFieldInfoPtr_MARGIN_SIZE;
    private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_MAX_RECV_PACKTES;
    private static readonly System.IntPtr NativeFieldInfoPtr_TOTAL_NAT_TRAVERSAL_TIMEOUT_MS;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VSocket()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VSocket>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VSocket.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static VSocket()
    {
      Il2CppClassPointerStore<VSocket>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NexPlugin", nameof (VSocket));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VSocket>.NativeClassPtr);
      VSocket.NativeFieldInfoPtr_MAX_DATA_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VSocket>.NativeClassPtr, nameof (MAX_DATA_SIZE));
      VSocket.NativeFieldInfoPtr_MARGIN_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VSocket>.NativeClassPtr, nameof (MARGIN_SIZE));
      VSocket.NativeFieldInfoPtr_DEFAULT_MAX_RECV_PACKTES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VSocket>.NativeClassPtr, nameof (DEFAULT_MAX_RECV_PACKTES));
      VSocket.NativeFieldInfoPtr_TOTAL_NAT_TRAVERSAL_TIMEOUT_MS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VSocket>.NativeClassPtr, nameof (TOTAL_NAT_TRAVERSAL_TIMEOUT_MS));
      VSocket.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VSocket>.NativeClassPtr, 100678364);
    }

    public VSocket(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe uint MAX_DATA_SIZE
    {
      get
      {
        uint maxDataSize;
        IL2CPP.il2cpp_field_static_get_value(VSocket.NativeFieldInfoPtr_MAX_DATA_SIZE, (void*) &maxDataSize);
        return maxDataSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VSocket.NativeFieldInfoPtr_MAX_DATA_SIZE, (void*) &value);
      }
    }

    public static unsafe uint MARGIN_SIZE
    {
      get
      {
        uint marginSize;
        IL2CPP.il2cpp_field_static_get_value(VSocket.NativeFieldInfoPtr_MARGIN_SIZE, (void*) &marginSize);
        return marginSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VSocket.NativeFieldInfoPtr_MARGIN_SIZE, (void*) &value);
      }
    }

    public static unsafe uint DEFAULT_MAX_RECV_PACKTES
    {
      get
      {
        uint defaultMaxRecvPacktes;
        IL2CPP.il2cpp_field_static_get_value(VSocket.NativeFieldInfoPtr_DEFAULT_MAX_RECV_PACKTES, (void*) &defaultMaxRecvPacktes);
        return defaultMaxRecvPacktes;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VSocket.NativeFieldInfoPtr_DEFAULT_MAX_RECV_PACKTES, (void*) &value);
      }
    }

    public static unsafe uint TOTAL_NAT_TRAVERSAL_TIMEOUT_MS
    {
      get
      {
        uint traversalTimeoutMs;
        IL2CPP.il2cpp_field_static_get_value(VSocket.NativeFieldInfoPtr_TOTAL_NAT_TRAVERSAL_TIMEOUT_MS, (void*) &traversalTimeoutMs);
        return traversalTimeoutMs;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VSocket.NativeFieldInfoPtr_TOTAL_NAT_TRAVERSAL_TIMEOUT_MS, (void*) &value);
      }
    }

    public enum Result
    {
      Success,
      Error,
      WouldBlock,
      PacketBufferFull,
    }
  }
}
