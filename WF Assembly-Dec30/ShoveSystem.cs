// Decompiled with JetBrains decompiler
// Type: ShoveSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class ShoveSystem : GameSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr__Active_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__Slot_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__Fix_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr_shovedFrom;
  private static readonly System.IntPtr NativeFieldInfoPtr_dragging;
  private static readonly System.IntPtr NativeFieldInfoPtr_shoveDirs;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Active_Public_Static_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Active_Private_Static_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Slot_Public_Static_get_CardSlot_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Slot_Private_Static_set_Void_CardSlot_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Position_Public_Static_get_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Fix_Public_Static_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Fix_Public_Static_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DragStart_Private_Static_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DragEnd_Private_Static_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SlotHover_Private_Static_Void_CardSlot_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SlotUnHover_Private_Static_Void_CardSlot_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CanShove_Public_Static_Boolean_Entity_Entity_byref_Dictionary_2_Entity_List_1_CardSlot_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FindSlots_Private_Static_Il2CppReferenceArray_1_CardSlot_Entity_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CanShoveTo_Private_Static_Boolean_Entity_Entity_Int32_Il2CppReferenceArray_1_CardSlot_byref_Dictionary_2_Entity_List_1_CardSlot_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CanShoveToOtherRow_Private_Static_Boolean_Entity_Entity_byref_Dictionary_2_Entity_List_1_CardSlot_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShowShove_Public_Static_Void_CardSlot_Dictionary_2_Entity_List_1_CardSlot_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DoShove_Public_Static_IEnumerator_Dictionary_2_Entity_List_1_CardSlot_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClearShove_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Deactivate_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public static unsafe bool Active
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73855, XrefRangeEnd = 73859, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ShoveSystem.NativeMethodInfoPtr_get_Active_Public_Static_get_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73859, XrefRangeEnd = 73863, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ShoveSystem.NativeMethodInfoPtr_set_Active_Private_Static_set_Void_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public static unsafe CardSlot Slot
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73863, XrefRangeEnd = 73867, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ShoveSystem.NativeMethodInfoPtr_get_Slot_Public_Static_get_CardSlot_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CardSlot) null : new CardSlot(pointer);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73867, XrefRangeEnd = 73873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ShoveSystem.NativeMethodInfoPtr_set_Slot_Private_Static_set_Void_CardSlot_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public static unsafe Vector3 Position
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 73887, RefRangeEnd = 73888, XrefRangeStart = 73873, XrefRangeEnd = 73887, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ShoveSystem.NativeMethodInfoPtr_get_Position_Public_Static_get_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public static unsafe bool Fix
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73888, XrefRangeEnd = 73892, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ShoveSystem.NativeMethodInfoPtr_get_Fix_Public_Static_get_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73892, XrefRangeEnd = 73896, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ShoveSystem.NativeMethodInfoPtr_set_Fix_Public_Static_set_Void_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73896, XrefRangeEnd = 73923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ShoveSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73923, XrefRangeEnd = 73950, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ShoveSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73950, XrefRangeEnd = 73956, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DragStart(Entity entity)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ShoveSystem.NativeMethodInfoPtr_DragStart_Private_Static_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73956, XrefRangeEnd = 73974, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DragEnd(Entity entity)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ShoveSystem.NativeMethodInfoPtr_DragEnd_Private_Static_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73974, XrefRangeEnd = 73997, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SlotHover(CardSlot slot)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) slot)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ShoveSystem.NativeMethodInfoPtr_SlotHover_Private_Static_Void_CardSlot_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73997, XrefRangeEnd = 74028, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SlotUnHover(CardSlot slot)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) slot)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ShoveSystem.NativeMethodInfoPtr_SlotUnHover_Private_Static_Void_CardSlot_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 74081, RefRangeEnd = 74086, XrefRangeStart = 74028, XrefRangeEnd = 74081, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool CanShove(
    Entity shovee,
    Entity shover,
    out Dictionary<Entity, List<CardSlot>> shoveData)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) shovee);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) shover);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr exc;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ShoveSystem.NativeMethodInfoPtr_CanShove_Public_Static_Boolean_Entity_Entity_byref_Dictionary_2_Entity_List_1_CardSlot_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    ref Dictionary<Entity, List<CardSlot>> local = ref shoveData;
    System.IntPtr pointer = zero;
    Dictionary<,> dictionary = pointer == System.IntPtr.Zero ? (Dictionary<,>) null : new Dictionary<,>(pointer);
    local = (Dictionary<Entity, List<CardSlot>>) dictionary;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 74103, RefRangeEnd = 74105, XrefRangeStart = 74086, XrefRangeEnd = 74103, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppReferenceArray<CardSlot> FindSlots(Entity shovee, int dir)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) shovee);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dir;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ShoveSystem.NativeMethodInfoPtr_FindSlots_Private_Static_Il2CppReferenceArray_1_CardSlot_Entity_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr nativeObject = num;
    return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CardSlot>) null : new Il2CppReferenceArray<CardSlot>(nativeObject);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 74215, RefRangeEnd = 74217, XrefRangeStart = 74105, XrefRangeEnd = 74215, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool CanShoveTo(
    Entity shovee,
    Entity shover,
    int dir,
    Il2CppReferenceArray<CardSlot> slots,
    out Dictionary<Entity, List<CardSlot>> shoveData)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[5];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) shovee);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) shover);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &dir;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) slots);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr exc;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ShoveSystem.NativeMethodInfoPtr_CanShoveTo_Private_Static_Boolean_Entity_Entity_Int32_Il2CppReferenceArray_1_CardSlot_byref_Dictionary_2_Entity_List_1_CardSlot_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    ref Dictionary<Entity, List<CardSlot>> local = ref shoveData;
    System.IntPtr pointer = zero;
    Dictionary<,> dictionary = pointer == System.IntPtr.Zero ? (Dictionary<,>) null : new Dictionary<,>(pointer);
    local = (Dictionary<Entity, List<CardSlot>>) dictionary;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 74262, RefRangeEnd = 74263, XrefRangeStart = 74217, XrefRangeEnd = 74262, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool CanShoveToOtherRow(
    Entity shovee,
    Entity shover,
    out Dictionary<Entity, List<CardSlot>> shoveData)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) shovee);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) shover);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr exc;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ShoveSystem.NativeMethodInfoPtr_CanShoveToOtherRow_Private_Static_Boolean_Entity_Entity_byref_Dictionary_2_Entity_List_1_CardSlot_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    ref Dictionary<Entity, List<CardSlot>> local = ref shoveData;
    System.IntPtr pointer = zero;
    Dictionary<,> dictionary = pointer == System.IntPtr.Zero ? (Dictionary<,>) null : new Dictionary<,>(pointer);
    local = (Dictionary<Entity, List<CardSlot>>) dictionary;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 74326, RefRangeEnd = 74328, XrefRangeStart = 74263, XrefRangeEnd = 74326, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ShowShove(
    CardSlot fromContainer,
    Dictionary<Entity, List<CardSlot>> shoveData)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) fromContainer);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) shoveData);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ShoveSystem.NativeMethodInfoPtr_ShowShove_Public_Static_Void_CardSlot_Dictionary_2_Entity_List_1_CardSlot_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 74333, RefRangeEnd = 74335, XrefRangeStart = 74328, XrefRangeEnd = 74333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IEnumerator DoShove(
    Dictionary<Entity, List<CardSlot>> shoveData,
    bool updatePositions = false)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) shoveData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &updatePositions;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ShoveSystem.NativeMethodInfoPtr_DoShove_Public_Static_IEnumerator_Dictionary_2_Entity_List_1_CardSlot_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 74370, RefRangeEnd = 74373, XrefRangeStart = 74335, XrefRangeEnd = 74370, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ClearShove()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ShoveSystem.NativeMethodInfoPtr_ClearShove_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 74393, RefRangeEnd = 74395, XrefRangeStart = 74373, XrefRangeEnd = 74393, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Deactivate()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ShoveSystem.NativeMethodInfoPtr_Deactivate_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ShoveSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShoveSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ShoveSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ShoveSystem()
  {
    Il2CppClassPointerStore<ShoveSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ShoveSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShoveSystem>.NativeClassPtr);
    ShoveSystem.NativeFieldInfoPtr__Active_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShoveSystem>.NativeClassPtr, "<Active>k__BackingField");
    ShoveSystem.NativeFieldInfoPtr__Slot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShoveSystem>.NativeClassPtr, "<Slot>k__BackingField");
    ShoveSystem.NativeFieldInfoPtr__Fix_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShoveSystem>.NativeClassPtr, "<Fix>k__BackingField");
    ShoveSystem.NativeFieldInfoPtr_shovedFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShoveSystem>.NativeClassPtr, nameof (shovedFrom));
    ShoveSystem.NativeFieldInfoPtr_dragging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShoveSystem>.NativeClassPtr, nameof (dragging));
    ShoveSystem.NativeFieldInfoPtr_shoveDirs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShoveSystem>.NativeClassPtr, nameof (shoveDirs));
    ShoveSystem.NativeMethodInfoPtr_get_Active_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShoveSystem>.NativeClassPtr, 100669281);
    ShoveSystem.NativeMethodInfoPtr_set_Active_Private_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShoveSystem>.NativeClassPtr, 100669282);
    ShoveSystem.NativeMethodInfoPtr_get_Slot_Public_Static_get_CardSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShoveSystem>.NativeClassPtr, 100669283);
    ShoveSystem.NativeMethodInfoPtr_set_Slot_Private_Static_set_Void_CardSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShoveSystem>.NativeClassPtr, 100669284);
    ShoveSystem.NativeMethodInfoPtr_get_Position_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShoveSystem>.NativeClassPtr, 100669285);
    ShoveSystem.NativeMethodInfoPtr_get_Fix_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShoveSystem>.NativeClassPtr, 100669286);
    ShoveSystem.NativeMethodInfoPtr_set_Fix_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShoveSystem>.NativeClassPtr, 100669287);
    ShoveSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShoveSystem>.NativeClassPtr, 100669288);
    ShoveSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShoveSystem>.NativeClassPtr, 100669289);
    ShoveSystem.NativeMethodInfoPtr_DragStart_Private_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShoveSystem>.NativeClassPtr, 100669290);
    ShoveSystem.NativeMethodInfoPtr_DragEnd_Private_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShoveSystem>.NativeClassPtr, 100669291);
    ShoveSystem.NativeMethodInfoPtr_SlotHover_Private_Static_Void_CardSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShoveSystem>.NativeClassPtr, 100669292);
    ShoveSystem.NativeMethodInfoPtr_SlotUnHover_Private_Static_Void_CardSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShoveSystem>.NativeClassPtr, 100669293);
    ShoveSystem.NativeMethodInfoPtr_CanShove_Public_Static_Boolean_Entity_Entity_byref_Dictionary_2_Entity_List_1_CardSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShoveSystem>.NativeClassPtr, 100669294);
    ShoveSystem.NativeMethodInfoPtr_FindSlots_Private_Static_Il2CppReferenceArray_1_CardSlot_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShoveSystem>.NativeClassPtr, 100669295);
    ShoveSystem.NativeMethodInfoPtr_CanShoveTo_Private_Static_Boolean_Entity_Entity_Int32_Il2CppReferenceArray_1_CardSlot_byref_Dictionary_2_Entity_List_1_CardSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShoveSystem>.NativeClassPtr, 100669296);
    ShoveSystem.NativeMethodInfoPtr_CanShoveToOtherRow_Private_Static_Boolean_Entity_Entity_byref_Dictionary_2_Entity_List_1_CardSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShoveSystem>.NativeClassPtr, 100669297);
    ShoveSystem.NativeMethodInfoPtr_ShowShove_Public_Static_Void_CardSlot_Dictionary_2_Entity_List_1_CardSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShoveSystem>.NativeClassPtr, 100669298);
    ShoveSystem.NativeMethodInfoPtr_DoShove_Public_Static_IEnumerator_Dictionary_2_Entity_List_1_CardSlot_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShoveSystem>.NativeClassPtr, 100669299);
    ShoveSystem.NativeMethodInfoPtr_ClearShove_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShoveSystem>.NativeClassPtr, 100669300);
    ShoveSystem.NativeMethodInfoPtr_Deactivate_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShoveSystem>.NativeClassPtr, 100669301);
    ShoveSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShoveSystem>.NativeClassPtr, 100669302);
  }

  public ShoveSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe bool _Active_k__BackingField
  {
    get
    {
      bool activeKBackingField;
      IL2CPP.il2cpp_field_static_get_value(ShoveSystem.NativeFieldInfoPtr__Active_k__BackingField, (void*) &activeKBackingField);
      return activeKBackingField;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ShoveSystem.NativeFieldInfoPtr__Active_k__BackingField, (void*) &value);
    }
  }

  public static unsafe CardSlot _Slot_k__BackingField
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ShoveSystem.NativeFieldInfoPtr__Slot_k__BackingField, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CardSlot) null : new CardSlot(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ShoveSystem.NativeFieldInfoPtr__Slot_k__BackingField, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe bool _Fix_k__BackingField
  {
    get
    {
      bool fixKBackingField;
      IL2CPP.il2cpp_field_static_get_value(ShoveSystem.NativeFieldInfoPtr__Fix_k__BackingField, (void*) &fixKBackingField);
      return fixKBackingField;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ShoveSystem.NativeFieldInfoPtr__Fix_k__BackingField, (void*) &value);
    }
  }

  public static unsafe List<Entity> shovedFrom
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ShoveSystem.NativeFieldInfoPtr_shovedFrom, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (List<Entity>) null : new List<Entity>(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ShoveSystem.NativeFieldInfoPtr_shovedFrom, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Entity dragging
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ShoveSystem.NativeFieldInfoPtr_dragging, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ShoveSystem.NativeFieldInfoPtr_dragging, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppStructArray<int> shoveDirs
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ShoveSystem.NativeFieldInfoPtr_shoveDirs, (void*) &num);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<int>) null : new Il2CppStructArray<int>(nativeObject);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ShoveSystem.NativeFieldInfoPtr_shoveDirs, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("ShoveSystem/<>c__DisplayClass25_0")]
  public sealed class __c__DisplayClass25_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_blockingEntity;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CanShoveTo_b__0_Internal_Boolean_KeyValuePair_2_Entity_Il2CppReferenceArray_1_CardSlot_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass25_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShoveSystem.__c__DisplayClass25_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ShoveSystem.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73753, XrefRangeEnd = 73758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _CanShoveTo_b__0(
      KeyValuePair<Entity, Il2CppReferenceArray<CardSlot>> p)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) p))
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ShoveSystem.__c__DisplayClass25_0.NativeMethodInfoPtr__CanShoveTo_b__0_Internal_Boolean_KeyValuePair_2_Entity_Il2CppReferenceArray_1_CardSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass25_0()
    {
      Il2CppClassPointerStore<ShoveSystem.__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShoveSystem>.NativeClassPtr, "<>c__DisplayClass25_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShoveSystem.__c__DisplayClass25_0>.NativeClassPtr);
      ShoveSystem.__c__DisplayClass25_0.NativeFieldInfoPtr_blockingEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShoveSystem.__c__DisplayClass25_0>.NativeClassPtr, nameof (blockingEntity));
      ShoveSystem.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShoveSystem.__c__DisplayClass25_0>.NativeClassPtr, 100669304);
      ShoveSystem.__c__DisplayClass25_0.NativeMethodInfoPtr__CanShoveTo_b__0_Internal_Boolean_KeyValuePair_2_Entity_Il2CppReferenceArray_1_CardSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShoveSystem.__c__DisplayClass25_0>.NativeClassPtr, 100669305);
    }

    public __c__DisplayClass25_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Entity blockingEntity
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShoveSystem.__c__DisplayClass25_0.NativeFieldInfoPtr_blockingEntity));
        return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShoveSystem.__c__DisplayClass25_0.NativeFieldInfoPtr_blockingEntity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("ShoveSystem/<DoShove>d__28")]
  public sealed class _DoShove_d__28 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr_shoveData;
    private static readonly System.IntPtr NativeFieldInfoPtr_updatePositions;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _DoShove_d__28(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShoveSystem._DoShove_d__28>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ShoveSystem._DoShove_d__28.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ShoveSystem._DoShove_d__28.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73758, XrefRangeEnd = 73849, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ShoveSystem._DoShove_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ShoveSystem._DoShove_d__28.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73849, XrefRangeEnd = 73855, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ShoveSystem._DoShove_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ShoveSystem._DoShove_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _DoShove_d__28()
    {
      Il2CppClassPointerStore<ShoveSystem._DoShove_d__28>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShoveSystem>.NativeClassPtr, "<DoShove>d__28");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShoveSystem._DoShove_d__28>.NativeClassPtr);
      ShoveSystem._DoShove_d__28.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShoveSystem._DoShove_d__28>.NativeClassPtr, "<>1__state");
      ShoveSystem._DoShove_d__28.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShoveSystem._DoShove_d__28>.NativeClassPtr, "<>2__current");
      ShoveSystem._DoShove_d__28.NativeFieldInfoPtr_shoveData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShoveSystem._DoShove_d__28>.NativeClassPtr, nameof (shoveData));
      ShoveSystem._DoShove_d__28.NativeFieldInfoPtr_updatePositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShoveSystem._DoShove_d__28>.NativeClassPtr, nameof (updatePositions));
      ShoveSystem._DoShove_d__28.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShoveSystem._DoShove_d__28>.NativeClassPtr, 100669306);
      ShoveSystem._DoShove_d__28.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShoveSystem._DoShove_d__28>.NativeClassPtr, 100669307);
      ShoveSystem._DoShove_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShoveSystem._DoShove_d__28>.NativeClassPtr, 100669308);
      ShoveSystem._DoShove_d__28.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShoveSystem._DoShove_d__28>.NativeClassPtr, 100669309);
      ShoveSystem._DoShove_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShoveSystem._DoShove_d__28>.NativeClassPtr, 100669310);
      ShoveSystem._DoShove_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShoveSystem._DoShove_d__28>.NativeClassPtr, 100669311);
    }

    public _DoShove_d__28(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShoveSystem._DoShove_d__28.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShoveSystem._DoShove_d__28.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShoveSystem._DoShove_d__28.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShoveSystem._DoShove_d__28.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<Entity, List<CardSlot>> shoveData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShoveSystem._DoShove_d__28.NativeFieldInfoPtr_shoveData));
        return pointer == System.IntPtr.Zero ? (Dictionary<Entity, List<CardSlot>>) null : new Dictionary<Entity, List<CardSlot>>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShoveSystem._DoShove_d__28.NativeFieldInfoPtr_shoveData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool updatePositions
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShoveSystem._DoShove_d__28.NativeFieldInfoPtr_updatePositions));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShoveSystem._DoShove_d__28.NativeFieldInfoPtr_updatePositions)) = value;
      }
    }
  }
}
