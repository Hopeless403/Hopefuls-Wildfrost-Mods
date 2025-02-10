// Decompiled with JetBrains decompiler
// Type: SpecialEventsSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class SpecialEventsSystem : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_events;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PreCampaignPopulate_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InsertSpecialEvent_Private_Static_Void_List_1_List_1_CampaignNode_Event_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateListOfNodes_Private_Static_List_1_List_1_CampaignNode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74395, XrefRangeEnd = 74403, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SpecialEventsSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74403, XrefRangeEnd = 74411, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SpecialEventsSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74411, XrefRangeEnd = 74414, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PreCampaignPopulate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SpecialEventsSystem.NativeMethodInfoPtr_PreCampaignPopulate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 74501, RefRangeEnd = 74502, XrefRangeStart = 74414, XrefRangeEnd = 74501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void InsertSpecialEvent(
    List<List<CampaignNode>> tiers,
    SpecialEventsSystem.Event specialEvent)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tiers);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) specialEvent));
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SpecialEventsSystem.NativeMethodInfoPtr_InsertSpecialEvent_Private_Static_Void_List_1_List_1_CampaignNode_Event_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 74545, RefRangeEnd = 74546, XrefRangeStart = 74502, XrefRangeEnd = 74545, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe List<List<CampaignNode>> CreateListOfNodes()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpecialEventsSystem.NativeMethodInfoPtr_CreateListOfNodes_Private_Static_List_1_List_1_CampaignNode_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (List<List<CampaignNode>>) null : new List<List<CampaignNode>>(pointer);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SpecialEventsSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpecialEventsSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SpecialEventsSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static SpecialEventsSystem()
  {
    Il2CppClassPointerStore<SpecialEventsSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (SpecialEventsSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpecialEventsSystem>.NativeClassPtr);
    SpecialEventsSystem.NativeFieldInfoPtr_events = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialEventsSystem>.NativeClassPtr, nameof (events));
    SpecialEventsSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialEventsSystem>.NativeClassPtr, 100669312);
    SpecialEventsSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialEventsSystem>.NativeClassPtr, 100669313);
    SpecialEventsSystem.NativeMethodInfoPtr_PreCampaignPopulate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialEventsSystem>.NativeClassPtr, 100669314);
    SpecialEventsSystem.NativeMethodInfoPtr_InsertSpecialEvent_Private_Static_Void_List_1_List_1_CampaignNode_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialEventsSystem>.NativeClassPtr, 100669315);
    SpecialEventsSystem.NativeMethodInfoPtr_CreateListOfNodes_Private_Static_List_1_List_1_CampaignNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialEventsSystem>.NativeClassPtr, 100669316);
    SpecialEventsSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialEventsSystem>.NativeClassPtr, 100669317);
  }

  public SpecialEventsSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppReferenceArray<SpecialEventsSystem.Event> events
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpecialEventsSystem.NativeFieldInfoPtr_events));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpecialEventsSystem.Event>) null : new Il2CppReferenceArray<SpecialEventsSystem.Event>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpecialEventsSystem.NativeFieldInfoPtr_events), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public sealed class Event : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_nodeType;
    private static readonly System.IntPtr NativeFieldInfoPtr_requiresUnlock;
    private static readonly System.IntPtr NativeFieldInfoPtr_replaceNodeTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_minTier;
    private static readonly System.IntPtr NativeFieldInfoPtr_perTier;
    private static readonly System.IntPtr NativeFieldInfoPtr_perRun;

    static Event()
    {
      Il2CppClassPointerStore<SpecialEventsSystem.Event>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpecialEventsSystem>.NativeClassPtr, nameof (Event));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpecialEventsSystem.Event>.NativeClassPtr);
      SpecialEventsSystem.Event.NativeFieldInfoPtr_nodeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialEventsSystem.Event>.NativeClassPtr, nameof (nodeType));
      SpecialEventsSystem.Event.NativeFieldInfoPtr_requiresUnlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialEventsSystem.Event>.NativeClassPtr, nameof (requiresUnlock));
      SpecialEventsSystem.Event.NativeFieldInfoPtr_replaceNodeTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialEventsSystem.Event>.NativeClassPtr, nameof (replaceNodeTypes));
      SpecialEventsSystem.Event.NativeFieldInfoPtr_minTier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialEventsSystem.Event>.NativeClassPtr, nameof (minTier));
      SpecialEventsSystem.Event.NativeFieldInfoPtr_perTier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialEventsSystem.Event>.NativeClassPtr, nameof (perTier));
      SpecialEventsSystem.Event.NativeFieldInfoPtr_perRun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialEventsSystem.Event>.NativeClassPtr, nameof (perRun));
    }

    public Event(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Event()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpecialEventsSystem.Event>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpecialEventsSystem.Event>.NativeClassPtr, data));
    }

    public unsafe CampaignNodeType nodeType
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpecialEventsSystem.Event.NativeFieldInfoPtr_nodeType));
        return pointer == System.IntPtr.Zero ? (CampaignNodeType) null : new CampaignNodeType(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpecialEventsSystem.Event.NativeFieldInfoPtr_nodeType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UnlockData requiresUnlock
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpecialEventsSystem.Event.NativeFieldInfoPtr_requiresUnlock));
        return pointer == System.IntPtr.Zero ? (UnlockData) null : new UnlockData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpecialEventsSystem.Event.NativeFieldInfoPtr_requiresUnlock), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppStringArray replaceNodeTypes
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpecialEventsSystem.Event.NativeFieldInfoPtr_replaceNodeTypes));
        return pointer == System.IntPtr.Zero ? (Il2CppStringArray) null : new Il2CppStringArray(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpecialEventsSystem.Event.NativeFieldInfoPtr_replaceNodeTypes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int minTier
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpecialEventsSystem.Event.NativeFieldInfoPtr_minTier));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpecialEventsSystem.Event.NativeFieldInfoPtr_minTier)) = value;
      }
    }

    public unsafe Vector2Int perTier
    {
      get
      {
        return *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpecialEventsSystem.Event.NativeFieldInfoPtr_perTier));
      }
      [param: In] set
      {
        *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpecialEventsSystem.Event.NativeFieldInfoPtr_perTier)) = value;
      }
    }

    public unsafe Vector2Int perRun
    {
      get
      {
        return *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpecialEventsSystem.Event.NativeFieldInfoPtr_perRun));
      }
      [param: In] set
      {
        *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpecialEventsSystem.Event.NativeFieldInfoPtr_perRun)) = value;
      }
    }
  }
}
