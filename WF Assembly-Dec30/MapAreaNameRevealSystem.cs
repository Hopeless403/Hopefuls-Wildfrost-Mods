// Decompiled with JetBrains decompiler
// Type: MapAreaNameRevealSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class MapAreaNameRevealSystem : GameSystem
{
  private static readonly IntPtr NativeFieldInfoPtr_areaNameNodes;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_MapNodeReveal_Private_Void_MapNode_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63710, XrefRangeEnd = 63739, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MapAreaNameRevealSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63739, XrefRangeEnd = 63747, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MapAreaNameRevealSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63747, XrefRangeEnd = 63757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void MapNodeReveal(MapNode mapNode)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mapNode)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MapAreaNameRevealSystem.NativeMethodInfoPtr_MapNodeReveal_Private_Void_MapNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63757, XrefRangeEnd = 63766, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MapAreaNameRevealSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapAreaNameRevealSystem>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MapAreaNameRevealSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static MapAreaNameRevealSystem()
  {
    Il2CppClassPointerStore<MapAreaNameRevealSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (MapAreaNameRevealSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapAreaNameRevealSystem>.NativeClassPtr);
    MapAreaNameRevealSystem.NativeFieldInfoPtr_areaNameNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapAreaNameRevealSystem>.NativeClassPtr, nameof (areaNameNodes));
    MapAreaNameRevealSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapAreaNameRevealSystem>.NativeClassPtr, 100668508);
    MapAreaNameRevealSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapAreaNameRevealSystem>.NativeClassPtr, 100668509);
    MapAreaNameRevealSystem.NativeMethodInfoPtr_MapNodeReveal_Private_Void_MapNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapAreaNameRevealSystem>.NativeClassPtr, 100668510);
    MapAreaNameRevealSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapAreaNameRevealSystem>.NativeClassPtr, 100668511);
  }

  public MapAreaNameRevealSystem(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Dictionary<int, CampaignNode> areaNameNodes
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapAreaNameRevealSystem.NativeFieldInfoPtr_areaNameNodes));
      return pointer == IntPtr.Zero ? (Dictionary<int, CampaignNode>) null : new Dictionary<int, CampaignNode>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapAreaNameRevealSystem.NativeFieldInfoPtr_areaNameNodes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
