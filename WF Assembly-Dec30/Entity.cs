// Decompiled with JetBrains decompiler
// Type: Entity
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Dead;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class Entity : MonoBehaviourCacheTransform
{
  private static readonly System.IntPtr NativeFieldInfoPtr_inPlay;
  private static readonly System.IntPtr NativeFieldInfoPtr__data;
  private static readonly System.IntPtr NativeFieldInfoPtr_display;
  private static readonly System.IntPtr NativeFieldInfoPtr_height;
  private static readonly System.IntPtr NativeFieldInfoPtr_paused;
  private static readonly System.IntPtr NativeFieldInfoPtr_wobbler;
  private static readonly System.IntPtr NativeFieldInfoPtr_flipper;
  private static readonly System.IntPtr NativeFieldInfoPtr_uINavigationItem;
  private static readonly System.IntPtr NativeFieldInfoPtr_curveAnimator;
  private static readonly System.IntPtr NativeFieldInfoPtr_imminentAnimation;
  private static readonly System.IntPtr NativeFieldInfoPtr_offset;
  private static readonly System.IntPtr NativeFieldInfoPtr_dragging;
  private static readonly System.IntPtr NativeFieldInfoPtr_blockRecall;
  private static readonly System.IntPtr NativeFieldInfoPtr__containers;
  private static readonly System.IntPtr NativeFieldInfoPtr__preContainers;
  private static readonly System.IntPtr NativeFieldInfoPtr_alive;
  private static readonly System.IntPtr NativeFieldInfoPtr_owner;
  private static readonly System.IntPtr NativeFieldInfoPtr_splatterSurface;
  private static readonly System.IntPtr NativeFieldInfoPtr_inCardPool;
  private static readonly System.IntPtr NativeFieldInfoPtr_returnToPool;
  private static readonly System.IntPtr NativeFieldInfoPtr_attackEffects;
  private static readonly System.IntPtr NativeFieldInfoPtr_statusEffects;
  private static readonly System.IntPtr NativeFieldInfoPtr_damage;
  private static readonly System.IntPtr NativeFieldInfoPtr_tempDamage;
  private static readonly System.IntPtr NativeFieldInfoPtr_hp;
  private static readonly System.IntPtr NativeFieldInfoPtr_counter;
  private static readonly System.IntPtr NativeFieldInfoPtr_uses;
  private static readonly System.IntPtr NativeFieldInfoPtr_effectBonus;
  private static readonly System.IntPtr NativeFieldInfoPtr_effectFactor;
  private static readonly System.IntPtr NativeFieldInfoPtr_lastHit;
  private static readonly System.IntPtr NativeFieldInfoPtr_promptUpdate;
  private static readonly System.IntPtr NativeFieldInfoPtr_random3;
  private static readonly System.IntPtr NativeFieldInfoPtr_forceKill;
  private static readonly System.IntPtr NativeFieldInfoPtr_targetMode;
  private static readonly System.IntPtr NativeFieldInfoPtr_positionPriority;
  private static readonly System.IntPtr NativeFieldInfoPtr_startingEffectsApplied;
  private static readonly System.IntPtr NativeFieldInfoPtr_triggeredBy;
  private static readonly System.IntPtr NativeFieldInfoPtr_cannotBeHitCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_silenceCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_traits;
  private static readonly System.IntPtr NativeFieldInfoPtr_canvas;
  private static readonly System.IntPtr NativeFieldInfoPtr_traitUpdateRunning;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_data_Public_get_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_data_Public_set_Void_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_containers_Public_get_Il2CppReferenceArray_1_CardContainer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_actualContainers_Public_get_List_1_CardContainer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_preContainers_Public_get_Il2CppReferenceArray_1_CardContainer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_preActualContainers_Public_get_Il2CppReferenceArray_1_CardContainer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddTo_Public_Void_CardContainer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveFrom_Public_Void_CardContainer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_NeedsTarget_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_canBeHit_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_silenced_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DrawOrder_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_DrawOrder_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAllAllies_Public_List_1_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAllies_Public_List_1_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAlliesInRow_Public_List_1_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAlliesInRow_Public_List_1_Entity_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAllEnemies_Public_List_1_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetEnemies_Public_List_1_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetEnemiesInRow_Public_List_1_Entity_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FindStatus_Public_StatusEffectData_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FindStatus_Public_StatusEffectData_StatusEffectData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClearStatuses_Public_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SnowAmount_Public_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsSnowed_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetScaleFromContainers_Public_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPositionFromContainers_Public_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveFromContainers_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResetDrawOrder_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InHand_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InContainer_Public_Boolean_CardContainer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InContainerGroup_Public_Boolean_CardContainer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ReadyToDie_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PromptUpdate_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CanPlayOn_Public_Boolean_Entity_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CanPlayOn_Public_Boolean_CardContainer_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Kill_Public_IEnumerator_DeathType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GainTrait_Public_TraitStacks_TraitData_Int32_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTraits_Public_IEnumerator_TraitStacks_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnGetFromPool_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnReturnToPool_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__UpdateTraits_b__95_0_Private_Boolean_0;

  public unsafe CardData data
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 35469, RefRangeEnd = 35472, XrefRangeStart = 35469, XrefRangeEnd = 35472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_get_data_Public_get_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CardData) null : new CardData(pointer);
    }
    [CallerCount(6), CachedScanResults(RefRangeStart = 44947, RefRangeEnd = 44953, XrefRangeStart = 44941, XrefRangeEnd = 44947, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_set_data_Public_set_Void_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe Il2CppReferenceArray<CardContainer> containers
  {
    [CallerCount(94), CachedScanResults(RefRangeStart = 44974, RefRangeEnd = 45068, XrefRangeStart = 44953, XrefRangeEnd = 44974, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_get_containers_Public_get_Il2CppReferenceArray_1_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CardContainer>) null : new Il2CppReferenceArray<CardContainer>(nativeObject);
    }
  }

  public unsafe List<CardContainer> actualContainers
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_get_actualContainers_Public_get_List_1_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (List<CardContainer>) null : new List<CardContainer>(pointer);
    }
  }

  public unsafe Il2CppReferenceArray<CardContainer> preContainers
  {
    [CallerCount(22), CachedScanResults(RefRangeStart = 45089, RefRangeEnd = 45111, XrefRangeStart = 45068, XrefRangeEnd = 45089, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_get_preContainers_Public_get_Il2CppReferenceArray_1_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CardContainer>) null : new Il2CppReferenceArray<CardContainer>(nativeObject);
    }
  }

  public unsafe Il2CppReferenceArray<CardContainer> preActualContainers
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_get_preActualContainers_Public_get_Il2CppReferenceArray_1_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CardContainer>) null : new Il2CppReferenceArray<CardContainer>(nativeObject);
    }
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 45115, RefRangeEnd = 45118, XrefRangeStart = 45111, XrefRangeEnd = 45115, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddTo(CardContainer container)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_AddTo_Public_Void_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 45122, RefRangeEnd = 45123, XrefRangeStart = 45118, XrefRangeEnd = 45122, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveFrom(CardContainer container)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_RemoveFrom_Public_Void_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  public unsafe bool NeedsTarget
  {
    [CallerCount(12), CachedScanResults(RefRangeStart = 45123, RefRangeEnd = 45135, XrefRangeStart = 45123, XrefRangeEnd = 45123, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_get_NeedsTarget_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public unsafe bool canBeHit
  {
    [CallerCount(20), CachedScanResults(RefRangeStart = 45135, RefRangeEnd = 45155, XrefRangeStart = 45135, XrefRangeEnd = 45135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_get_canBeHit_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public unsafe bool silenced
  {
    [CallerCount(17), CachedScanResults(RefRangeStart = 45155, RefRangeEnd = 45172, XrefRangeStart = 45155, XrefRangeEnd = 45155, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_get_silenced_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public unsafe int DrawOrder
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45172, XrefRangeEnd = 45184, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_get_DrawOrder_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(6), CachedScanResults(RefRangeStart = 45207, RefRangeEnd = 45213, XrefRangeStart = 45184, XrefRangeEnd = 45207, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_set_DrawOrder_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 45217, RefRangeEnd = 45221, XrefRangeStart = 45213, XrefRangeEnd = 45217, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe List<Entity> GetAllAllies()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_GetAllAllies_Public_List_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (List<Entity>) null : new List<Entity>(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 45251, RefRangeEnd = 45253, XrefRangeStart = 45221, XrefRangeEnd = 45251, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe List<Entity> GetAllies()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_GetAllies_Public_List_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (List<Entity>) null : new List<Entity>(pointer);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 45269, RefRangeEnd = 45273, XrefRangeStart = 45253, XrefRangeEnd = 45269, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe List<Entity> GetAlliesInRow()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_GetAlliesInRow_Public_List_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (List<Entity>) null : new List<Entity>(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 45303, RefRangeEnd = 45304, XrefRangeStart = 45273, XrefRangeEnd = 45303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe List<Entity> GetAlliesInRow(int rowIndex)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &rowIndex
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_GetAlliesInRow_Public_List_1_Entity_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (List<Entity>) null : new List<Entity>(pointer);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 45306, RefRangeEnd = 45311, XrefRangeStart = 45304, XrefRangeEnd = 45306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe List<Entity> GetAllEnemies()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_GetAllEnemies_Public_List_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (List<Entity>) null : new List<Entity>(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45311, XrefRangeEnd = 45385, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe List<Entity> GetEnemies()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_GetEnemies_Public_List_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (List<Entity>) null : new List<Entity>(pointer);
  }

  [CallerCount(15)]
  [CachedScanResults(RefRangeStart = 45454, RefRangeEnd = 45469, XrefRangeStart = 45385, XrefRangeEnd = 45454, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe List<Entity> GetEnemiesInRow(int rowIndex)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &rowIndex
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_GetEnemiesInRow_Public_List_1_Entity_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (List<Entity>) null : new List<Entity>(pointer);
  }

  [CallerCount(18)]
  [CachedScanResults(RefRangeStart = 45484, RefRangeEnd = 45502, XrefRangeStart = 45469, XrefRangeEnd = 45484, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StatusEffectData FindStatus(string type)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(type)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_FindStatus_Public_StatusEffectData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (StatusEffectData) null : new StatusEffectData(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 45517, RefRangeEnd = 45519, XrefRangeStart = 45502, XrefRangeEnd = 45517, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StatusEffectData FindStatus(StatusEffectData dataType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) dataType)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_FindStatus_Public_StatusEffectData_StatusEffectData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (StatusEffectData) null : new StatusEffectData(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45519, XrefRangeEnd = 45524, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator ClearStatuses()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_ClearStatuses_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 45544, RefRangeEnd = 45545, XrefRangeStart = 45524, XrefRangeEnd = 45544, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int SnowAmount()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_SnowAmount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  public unsafe bool IsSnowed
  {
    [CallerCount(10), CachedScanResults(RefRangeStart = 45566, RefRangeEnd = 45576, XrefRangeStart = 45545, XrefRangeEnd = 45566, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_get_IsSnowed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45576, XrefRangeEnd = 45586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 GetScaleFromContainers()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_GetScaleFromContainers_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 45593, RefRangeEnd = 45595, XrefRangeStart = 45586, XrefRangeEnd = 45593, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 GetPositionFromContainers()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_GetPositionFromContainers_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(33)]
  [CachedScanResults(RefRangeStart = 45610, RefRangeEnd = 45643, XrefRangeStart = 45595, XrefRangeEnd = 45610, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveFromContainers()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_RemoveFromContainers_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 45648, RefRangeEnd = 45654, XrefRangeStart = 45643, XrefRangeEnd = 45648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ResetDrawOrder()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_ResetDrawOrder_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 45666, RefRangeEnd = 45673, XrefRangeStart = 45654, XrefRangeEnd = 45666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool InHand()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_InHand_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45673, XrefRangeEnd = 45687, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool InContainer(CardContainer container)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_InContainer_Public_Boolean_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 45693, RefRangeEnd = 45701, XrefRangeStart = 45687, XrefRangeEnd = 45693, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool InContainerGroup(CardContainer container)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_InContainerGroup_Public_Boolean_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45701, XrefRangeEnd = 45702, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45702, XrefRangeEnd = 45716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 45742, RefRangeEnd = 45744, XrefRangeStart = 45716, XrefRangeEnd = 45742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool ReadyToDie()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_ReadyToDie_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 45749, RefRangeEnd = 45750, XrefRangeStart = 45744, XrefRangeEnd = 45749, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator Reset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_Reset_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(45)]
  [CachedScanResults(RefRangeStart = 45750, RefRangeEnd = 45795, XrefRangeStart = 45750, XrefRangeEnd = 45750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PromptUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_PromptUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 45831, RefRangeEnd = 45837, XrefRangeStart = 45795, XrefRangeEnd = 45831, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CanPlayOn(Entity target, bool ignoreRowCheck = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreRowCheck;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_CanPlayOn_Public_Boolean_Entity_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 45886, RefRangeEnd = 45892, XrefRangeStart = 45837, XrefRangeEnd = 45886, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CanPlayOn(CardContainer container, bool ignoreRowCheck = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreRowCheck;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_CanPlayOn_Public_Boolean_CardContainer_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 45897, RefRangeEnd = 45900, XrefRangeStart = 45892, XrefRangeEnd = 45897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator Kill(DeathType deathType = DeathType.Normal)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &deathType
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_Kill_Public_IEnumerator_DeathType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45900, XrefRangeEnd = 45901, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45901, XrefRangeEnd = 45952, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 45977, RefRangeEnd = 45983, XrefRangeStart = 45952, XrefRangeEnd = 45977, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Entity.TraitStacks GainTrait(TraitData traitData, int count, bool temporary = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) traitData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &temporary;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_GainTrait_Public_TraitStacks_TraitData_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Entity.TraitStacks) null : new Entity.TraitStacks(pointer);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 45989, RefRangeEnd = 45997, XrefRangeStart = 45983, XrefRangeEnd = 45989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator UpdateTraits(Entity.TraitStacks moveToFront = null)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) moveToFront)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_UpdateTraits_Public_IEnumerator_TraitStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 46011, RefRangeEnd = 46012, XrefRangeStart = 45997, XrefRangeEnd = 46011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnGetFromPool()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_OnGetFromPool_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 46076, RefRangeEnd = 46077, XrefRangeStart = 46012, XrefRangeEnd = 46076, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnReturnToPool()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_OnReturnToPool_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46077, XrefRangeEnd = 46086, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Entity()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Entity>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe bool _UpdateTraits_b__95_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr__UpdateTraits_b__95_0_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  static Entity()
  {
    Il2CppClassPointerStore<Entity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (Entity));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Entity>.NativeClassPtr);
    Entity.NativeFieldInfoPtr_inPlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, nameof (inPlay));
    Entity.NativeFieldInfoPtr__data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, nameof (_data));
    Entity.NativeFieldInfoPtr_display = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, nameof (display));
    Entity.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, nameof (height));
    Entity.NativeFieldInfoPtr_paused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, nameof (paused));
    Entity.NativeFieldInfoPtr_wobbler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, nameof (wobbler));
    Entity.NativeFieldInfoPtr_flipper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, nameof (flipper));
    Entity.NativeFieldInfoPtr_uINavigationItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, nameof (uINavigationItem));
    Entity.NativeFieldInfoPtr_curveAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, nameof (curveAnimator));
    Entity.NativeFieldInfoPtr_imminentAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, nameof (imminentAnimation));
    Entity.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, nameof (offset));
    Entity.NativeFieldInfoPtr_dragging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, nameof (dragging));
    Entity.NativeFieldInfoPtr_blockRecall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, nameof (blockRecall));
    Entity.NativeFieldInfoPtr__containers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, nameof (_containers));
    Entity.NativeFieldInfoPtr__preContainers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, nameof (_preContainers));
    Entity.NativeFieldInfoPtr_alive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, nameof (alive));
    Entity.NativeFieldInfoPtr_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, nameof (owner));
    Entity.NativeFieldInfoPtr_splatterSurface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, nameof (splatterSurface));
    Entity.NativeFieldInfoPtr_inCardPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, nameof (inCardPool));
    Entity.NativeFieldInfoPtr_returnToPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, nameof (returnToPool));
    Entity.NativeFieldInfoPtr_attackEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, nameof (attackEffects));
    Entity.NativeFieldInfoPtr_statusEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, nameof (statusEffects));
    Entity.NativeFieldInfoPtr_damage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, nameof (damage));
    Entity.NativeFieldInfoPtr_tempDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, nameof (tempDamage));
    Entity.NativeFieldInfoPtr_hp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, nameof (hp));
    Entity.NativeFieldInfoPtr_counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, nameof (counter));
    Entity.NativeFieldInfoPtr_uses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, nameof (uses));
    Entity.NativeFieldInfoPtr_effectBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, nameof (effectBonus));
    Entity.NativeFieldInfoPtr_effectFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, nameof (effectFactor));
    Entity.NativeFieldInfoPtr_lastHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, nameof (lastHit));
    Entity.NativeFieldInfoPtr_promptUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, nameof (promptUpdate));
    Entity.NativeFieldInfoPtr_random3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, nameof (random3));
    Entity.NativeFieldInfoPtr_forceKill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, nameof (forceKill));
    Entity.NativeFieldInfoPtr_targetMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, nameof (targetMode));
    Entity.NativeFieldInfoPtr_positionPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, nameof (positionPriority));
    Entity.NativeFieldInfoPtr_startingEffectsApplied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, nameof (startingEffectsApplied));
    Entity.NativeFieldInfoPtr_triggeredBy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, nameof (triggeredBy));
    Entity.NativeFieldInfoPtr_cannotBeHitCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, nameof (cannotBeHitCount));
    Entity.NativeFieldInfoPtr_silenceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, nameof (silenceCount));
    Entity.NativeFieldInfoPtr_traits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, nameof (traits));
    Entity.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, nameof (canvas));
    Entity.NativeFieldInfoPtr_traitUpdateRunning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, nameof (traitUpdateRunning));
    Entity.NativeMethodInfoPtr_get_data_Public_get_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666621);
    Entity.NativeMethodInfoPtr_set_data_Public_set_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666622);
    Entity.NativeMethodInfoPtr_get_containers_Public_get_Il2CppReferenceArray_1_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666623);
    Entity.NativeMethodInfoPtr_get_actualContainers_Public_get_List_1_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666624);
    Entity.NativeMethodInfoPtr_get_preContainers_Public_get_Il2CppReferenceArray_1_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666625);
    Entity.NativeMethodInfoPtr_get_preActualContainers_Public_get_Il2CppReferenceArray_1_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666626);
    Entity.NativeMethodInfoPtr_AddTo_Public_Void_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666627);
    Entity.NativeMethodInfoPtr_RemoveFrom_Public_Void_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666628);
    Entity.NativeMethodInfoPtr_get_NeedsTarget_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666629);
    Entity.NativeMethodInfoPtr_get_canBeHit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666630);
    Entity.NativeMethodInfoPtr_get_silenced_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666631);
    Entity.NativeMethodInfoPtr_get_DrawOrder_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666632);
    Entity.NativeMethodInfoPtr_set_DrawOrder_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666633);
    Entity.NativeMethodInfoPtr_GetAllAllies_Public_List_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666634);
    Entity.NativeMethodInfoPtr_GetAllies_Public_List_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666635);
    Entity.NativeMethodInfoPtr_GetAlliesInRow_Public_List_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666636);
    Entity.NativeMethodInfoPtr_GetAlliesInRow_Public_List_1_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666637);
    Entity.NativeMethodInfoPtr_GetAllEnemies_Public_List_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666638);
    Entity.NativeMethodInfoPtr_GetEnemies_Public_List_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666639);
    Entity.NativeMethodInfoPtr_GetEnemiesInRow_Public_List_1_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666640);
    Entity.NativeMethodInfoPtr_FindStatus_Public_StatusEffectData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666641);
    Entity.NativeMethodInfoPtr_FindStatus_Public_StatusEffectData_StatusEffectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666642);
    Entity.NativeMethodInfoPtr_ClearStatuses_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666643);
    Entity.NativeMethodInfoPtr_SnowAmount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666644);
    Entity.NativeMethodInfoPtr_get_IsSnowed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666645);
    Entity.NativeMethodInfoPtr_GetScaleFromContainers_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666646);
    Entity.NativeMethodInfoPtr_GetPositionFromContainers_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666647);
    Entity.NativeMethodInfoPtr_RemoveFromContainers_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666648);
    Entity.NativeMethodInfoPtr_ResetDrawOrder_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666649);
    Entity.NativeMethodInfoPtr_InHand_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666650);
    Entity.NativeMethodInfoPtr_InContainer_Public_Boolean_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666651);
    Entity.NativeMethodInfoPtr_InContainerGroup_Public_Boolean_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666652);
    Entity.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666653);
    Entity.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666654);
    Entity.NativeMethodInfoPtr_ReadyToDie_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666655);
    Entity.NativeMethodInfoPtr_Reset_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666656);
    Entity.NativeMethodInfoPtr_PromptUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666657);
    Entity.NativeMethodInfoPtr_CanPlayOn_Public_Boolean_Entity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666658);
    Entity.NativeMethodInfoPtr_CanPlayOn_Public_Boolean_CardContainer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666659);
    Entity.NativeMethodInfoPtr_Kill_Public_IEnumerator_DeathType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666660);
    Entity.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666661);
    Entity.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666662);
    Entity.NativeMethodInfoPtr_GainTrait_Public_TraitStacks_TraitData_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666663);
    Entity.NativeMethodInfoPtr_UpdateTraits_Public_IEnumerator_TraitStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666664);
    Entity.NativeMethodInfoPtr_OnGetFromPool_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666665);
    Entity.NativeMethodInfoPtr_OnReturnToPool_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666666);
    Entity.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666667);
    Entity.NativeMethodInfoPtr__UpdateTraits_b__95_0_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666668);
  }

  public Entity(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool inPlay
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_inPlay));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_inPlay)) = value;
    }
  }

  public unsafe CardData _data
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr__data));
      return pointer == System.IntPtr.Zero ? (CardData) null : new CardData(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr__data), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EntityDisplay display
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_display));
      return pointer == System.IntPtr.Zero ? (EntityDisplay) null : new EntityDisplay(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_display), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int height
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_height));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_height)) = value;
    }
  }

  public unsafe bool paused
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_paused));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_paused)) = value;
    }
  }

  public unsafe Wobbler wobbler
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_wobbler));
      return pointer == System.IntPtr.Zero ? (Wobbler) null : new Wobbler(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_wobbler), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Flipper flipper
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_flipper));
      return pointer == System.IntPtr.Zero ? (Flipper) null : new Flipper(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_flipper), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UINavigationItem uINavigationItem
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_uINavigationItem));
      return pointer == System.IntPtr.Zero ? (UINavigationItem) null : new UINavigationItem(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_uINavigationItem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CurveAnimator curveAnimator
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_curveAnimator));
      return pointer == System.IntPtr.Zero ? (CurveAnimator) null : new CurveAnimator(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_curveAnimator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CardIdleAnimation imminentAnimation
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_imminentAnimation));
      return pointer == System.IntPtr.Zero ? (CardIdleAnimation) null : new CardIdleAnimation(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_imminentAnimation), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform offset
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_offset));
      return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_offset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool dragging
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_dragging));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_dragging)) = value;
    }
  }

  public unsafe int blockRecall
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_blockRecall));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_blockRecall)) = value;
    }
  }

  public unsafe List<CardContainer> _containers
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr__containers));
      return pointer == System.IntPtr.Zero ? (List<CardContainer>) null : new List<CardContainer>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr__containers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<CardContainer> _preContainers
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr__preContainers));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CardContainer>) null : new Il2CppReferenceArray<CardContainer>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr__preContainers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool alive
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_alive));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_alive)) = value;
    }
  }

  public unsafe Character owner
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_owner));
      return pointer == System.IntPtr.Zero ? (Character) null : new Character(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_owner), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SplatterSurface splatterSurface
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_splatterSurface));
      return pointer == System.IntPtr.Zero ? (SplatterSurface) null : new SplatterSurface(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_splatterSurface), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool inCardPool
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_inCardPool));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_inCardPool)) = value;
    }
  }

  public unsafe bool returnToPool
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_returnToPool));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_returnToPool)) = value;
    }
  }

  public unsafe List<CardData.StatusEffectStacks> attackEffects
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_attackEffects));
      return pointer == System.IntPtr.Zero ? (List<CardData.StatusEffectStacks>) null : new List<CardData.StatusEffectStacks>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_attackEffects), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<StatusEffectData> statusEffects
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_statusEffects));
      return pointer == System.IntPtr.Zero ? (List<StatusEffectData>) null : new List<StatusEffectData>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_statusEffects), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Stat damage
  {
    get
    {
      return *(Stat*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_damage));
    }
    [param: In] set
    {
      *(Stat*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_damage)) = value;
    }
  }

  public unsafe SafeInt tempDamage
  {
    get
    {
      return *(SafeInt*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_tempDamage));
    }
    [param: In] set
    {
      *(SafeInt*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_tempDamage)) = value;
    }
  }

  public unsafe Stat hp
  {
    get
    {
      return *(Stat*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_hp));
    }
    [param: In] set
    {
      *(Stat*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_hp)) = value;
    }
  }

  public unsafe Stat counter
  {
    get
    {
      return *(Stat*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_counter));
    }
    [param: In] set
    {
      *(Stat*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_counter)) = value;
    }
  }

  public unsafe Stat uses
  {
    get
    {
      return *(Stat*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_uses));
    }
    [param: In] set
    {
      *(Stat*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_uses)) = value;
    }
  }

  public unsafe int effectBonus
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_effectBonus));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_effectBonus)) = value;
    }
  }

  public unsafe float effectFactor
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_effectFactor));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_effectFactor)) = value;
    }
  }

  public unsafe Hit lastHit
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_lastHit));
      return pointer == System.IntPtr.Zero ? (Hit) null : new Hit(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_lastHit), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool promptUpdate
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_promptUpdate));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_promptUpdate)) = value;
    }
  }

  public unsafe Vector3 random3
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_random3));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_random3)) = value;
    }
  }

  public unsafe bool forceKill
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_forceKill));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_forceKill)) = value;
    }
  }

  public unsafe TargetMode targetMode
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_targetMode));
      return pointer == System.IntPtr.Zero ? (TargetMode) null : new TargetMode(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_targetMode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int positionPriority
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_positionPriority));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_positionPriority)) = value;
    }
  }

  public unsafe bool startingEffectsApplied
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_startingEffectsApplied));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_startingEffectsApplied)) = value;
    }
  }

  public unsafe Entity triggeredBy
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_triggeredBy));
      return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_triggeredBy), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int cannotBeHitCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_cannotBeHitCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_cannotBeHitCount)) = value;
    }
  }

  public unsafe int silenceCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_silenceCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_silenceCount)) = value;
    }
  }

  public unsafe List<Entity.TraitStacks> traits
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_traits));
      return pointer == System.IntPtr.Zero ? (List<Entity.TraitStacks>) null : new List<Entity.TraitStacks>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_traits), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Canvas canvas
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_canvas));
      return pointer == System.IntPtr.Zero ? (Canvas) null : new Canvas(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int traitUpdateRunning
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_traitUpdateRunning));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_traitUpdateRunning)) = value;
    }
  }

  [Serializable]
  public class TraitStacks : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_data;
    private static readonly System.IntPtr NativeFieldInfoPtr_count;
    private static readonly System.IntPtr NativeFieldInfoPtr_silenceCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_tempCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_init;
    private static readonly System.IntPtr NativeFieldInfoPtr_effectsDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_passiveEffects;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_silenced_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ReadyToInit_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_MustDisable_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_MustEnable_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_StacksRemoved_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_TraitData_Int32_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DisableEffects_Public_IEnumerator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EnableEffects_Public_IEnumerator_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddEffectStacks_Public_IEnumerator_Entity_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveEffectStacks_Public_IEnumerator_Entity_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__AddEffectStacks_b__20_0_Private_Void_StatusEffectData_0;

    public unsafe bool silenced
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 44470, RefRangeEnd = 44471, XrefRangeStart = 44470, XrefRangeEnd = 44470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks.NativeMethodInfoPtr_get_silenced_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool ReadyToInit
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks.NativeMethodInfoPtr_get_ReadyToInit_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool MustDisable
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks.NativeMethodInfoPtr_get_MustDisable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool MustEnable
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks.NativeMethodInfoPtr_get_MustEnable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool StacksRemoved
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks.NativeMethodInfoPtr_get_StacksRemoved_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 44480, RefRangeEnd = 44483, XrefRangeStart = 44471, XrefRangeEnd = 44480, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TraitStacks(TraitData data, int count, bool temporary = false)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &temporary;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks.NativeMethodInfoPtr__ctor_Public_Void_TraitData_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 44488, RefRangeEnd = 44490, XrefRangeStart = 44483, XrefRangeEnd = 44488, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IEnumerator DisableEffects()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks.NativeMethodInfoPtr_DisableEffects_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44490, XrefRangeEnd = 44496, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IEnumerator EnableEffects(Entity entity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks.NativeMethodInfoPtr_EnableEffects_Public_IEnumerator_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44496, XrefRangeEnd = 44502, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IEnumerator AddEffectStacks(Entity entity, int stacks)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &stacks;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks.NativeMethodInfoPtr_AddEffectStacks_Public_IEnumerator_Entity_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44502, XrefRangeEnd = 44508, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IEnumerator RemoveEffectStacks(Entity entity, int removeStacks)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &removeStacks;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks.NativeMethodInfoPtr_RemoveEffectStacks_Public_IEnumerator_Entity_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44508, XrefRangeEnd = 44512, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _AddEffectStacks_b__20_0(StatusEffectData a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks.NativeMethodInfoPtr__AddEffectStacks_b__20_0_Private_Void_StatusEffectData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TraitStacks()
    {
      Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Entity>.NativeClassPtr, nameof (TraitStacks));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr);
      Entity.TraitStacks.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr, nameof (data));
      Entity.TraitStacks.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr, nameof (count));
      Entity.TraitStacks.NativeFieldInfoPtr_silenceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr, nameof (silenceCount));
      Entity.TraitStacks.NativeFieldInfoPtr_tempCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr, nameof (tempCount));
      Entity.TraitStacks.NativeFieldInfoPtr_init = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr, nameof (init));
      Entity.TraitStacks.NativeFieldInfoPtr_effectsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr, nameof (effectsDisabled));
      Entity.TraitStacks.NativeFieldInfoPtr_passiveEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr, nameof (passiveEffects));
      Entity.TraitStacks.NativeMethodInfoPtr_get_silenced_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr, 100666669);
      Entity.TraitStacks.NativeMethodInfoPtr_get_ReadyToInit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr, 100666670);
      Entity.TraitStacks.NativeMethodInfoPtr_get_MustDisable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr, 100666671);
      Entity.TraitStacks.NativeMethodInfoPtr_get_MustEnable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr, 100666672);
      Entity.TraitStacks.NativeMethodInfoPtr_get_StacksRemoved_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr, 100666673);
      Entity.TraitStacks.NativeMethodInfoPtr__ctor_Public_Void_TraitData_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr, 100666674);
      Entity.TraitStacks.NativeMethodInfoPtr_DisableEffects_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr, 100666675);
      Entity.TraitStacks.NativeMethodInfoPtr_EnableEffects_Public_IEnumerator_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr, 100666676);
      Entity.TraitStacks.NativeMethodInfoPtr_AddEffectStacks_Public_IEnumerator_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr, 100666677);
      Entity.TraitStacks.NativeMethodInfoPtr_RemoveEffectStacks_Public_IEnumerator_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr, 100666678);
      Entity.TraitStacks.NativeMethodInfoPtr__AddEffectStacks_b__20_0_Private_Void_StatusEffectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr, 100666679);
    }

    public TraitStacks(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TraitData data
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks.NativeFieldInfoPtr_data));
        return pointer == System.IntPtr.Zero ? (TraitData) null : new TraitData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int count
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks.NativeFieldInfoPtr_count));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks.NativeFieldInfoPtr_count)) = value;
      }
    }

    public unsafe int silenceCount
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks.NativeFieldInfoPtr_silenceCount));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks.NativeFieldInfoPtr_silenceCount)) = value;
      }
    }

    public unsafe int tempCount
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks.NativeFieldInfoPtr_tempCount));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks.NativeFieldInfoPtr_tempCount)) = value;
      }
    }

    public unsafe int init
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks.NativeFieldInfoPtr_init));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks.NativeFieldInfoPtr_init)) = value;
      }
    }

    public unsafe bool effectsDisabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks.NativeFieldInfoPtr_effectsDisabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks.NativeFieldInfoPtr_effectsDisabled)) = value;
      }
    }

    public unsafe List<StatusEffectData> passiveEffects
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks.NativeFieldInfoPtr_passiveEffects));
        return pointer == System.IntPtr.Zero ? (List<StatusEffectData>) null : new List<StatusEffectData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks.NativeFieldInfoPtr_passiveEffects), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("Entity/TraitStacks/<DisableEffects>d__18")]
    public sealed class _DisableEffects_d__18 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
      private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap1;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

      [CallerCount(53)]
      [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe _DisableEffects_d__18(int _param1)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Entity.TraitStacks._DisableEffects_d__18>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &_param1
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._DisableEffects_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 44393, RefRangeEnd = 44394, XrefRangeStart = 44386, XrefRangeEnd = 44393, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_IDisposable_Dispose()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._DisableEffects_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44394, XrefRangeEnd = 44413, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool MoveNext()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._DisableEffects_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44413, XrefRangeEnd = 44416, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void __m__Finally1()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._DisableEffects_d__18.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
      {
        [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._DisableEffects_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44416, XrefRangeEnd = 44422, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_Collections_IEnumerator_Reset()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._DisableEffects_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
      {
        [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._DisableEffects_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
      }

      static _DisableEffects_d__18()
      {
        Il2CppClassPointerStore<Entity.TraitStacks._DisableEffects_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr, "<DisableEffects>d__18");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Entity.TraitStacks._DisableEffects_d__18>.NativeClassPtr);
        Entity.TraitStacks._DisableEffects_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks._DisableEffects_d__18>.NativeClassPtr, "<>1__state");
        Entity.TraitStacks._DisableEffects_d__18.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks._DisableEffects_d__18>.NativeClassPtr, "<>2__current");
        Entity.TraitStacks._DisableEffects_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks._DisableEffects_d__18>.NativeClassPtr, "<>4__this");
        Entity.TraitStacks._DisableEffects_d__18.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks._DisableEffects_d__18>.NativeClassPtr, "<>7__wrap1");
        Entity.TraitStacks._DisableEffects_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._DisableEffects_d__18>.NativeClassPtr, 100666680);
        Entity.TraitStacks._DisableEffects_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._DisableEffects_d__18>.NativeClassPtr, 100666681);
        Entity.TraitStacks._DisableEffects_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._DisableEffects_d__18>.NativeClassPtr, 100666682);
        Entity.TraitStacks._DisableEffects_d__18.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._DisableEffects_d__18>.NativeClassPtr, 100666683);
        Entity.TraitStacks._DisableEffects_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._DisableEffects_d__18>.NativeClassPtr, 100666684);
        Entity.TraitStacks._DisableEffects_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._DisableEffects_d__18>.NativeClassPtr, 100666685);
        Entity.TraitStacks._DisableEffects_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._DisableEffects_d__18>.NativeClassPtr, 100666686);
      }

      public _DisableEffects_d__18(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe int __1__state
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._DisableEffects_d__18.NativeFieldInfoPtr___1__state));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._DisableEffects_d__18.NativeFieldInfoPtr___1__state)) = value;
        }
      }

      public unsafe Il2CppSystem.Object __2__current
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._DisableEffects_d__18.NativeFieldInfoPtr___2__current));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._DisableEffects_d__18.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Entity.TraitStacks __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._DisableEffects_d__18.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (Entity.TraitStacks) null : new Entity.TraitStacks(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._DisableEffects_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public List<StatusEffectData>.Enumerator __7__wrap1
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._DisableEffects_d__18.NativeFieldInfoPtr___7__wrap1);
          return new List<StatusEffectData>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<StatusEffectData>.Enumerator>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._DisableEffects_d__18.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<StatusEffectData>.Enumerator>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("Entity/TraitStacks/<EnableEffects>d__19")]
    public sealed class _EnableEffects_d__19 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
      private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_entity;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

      [CallerCount(53)]
      [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe _EnableEffects_d__19(int _param1)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Entity.TraitStacks._EnableEffects_d__19>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &_param1
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._EnableEffects_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(12611)]
      [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_IDisposable_Dispose()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._EnableEffects_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44422, XrefRangeEnd = 44429, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool MoveNext()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._EnableEffects_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._EnableEffects_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44429, XrefRangeEnd = 44435, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_Collections_IEnumerator_Reset()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._EnableEffects_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
      {
        [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._EnableEffects_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
      }

      static _EnableEffects_d__19()
      {
        Il2CppClassPointerStore<Entity.TraitStacks._EnableEffects_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr, "<EnableEffects>d__19");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Entity.TraitStacks._EnableEffects_d__19>.NativeClassPtr);
        Entity.TraitStacks._EnableEffects_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks._EnableEffects_d__19>.NativeClassPtr, "<>1__state");
        Entity.TraitStacks._EnableEffects_d__19.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks._EnableEffects_d__19>.NativeClassPtr, "<>2__current");
        Entity.TraitStacks._EnableEffects_d__19.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks._EnableEffects_d__19>.NativeClassPtr, "<>4__this");
        Entity.TraitStacks._EnableEffects_d__19.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks._EnableEffects_d__19>.NativeClassPtr, nameof (entity));
        Entity.TraitStacks._EnableEffects_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._EnableEffects_d__19>.NativeClassPtr, 100666687);
        Entity.TraitStacks._EnableEffects_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._EnableEffects_d__19>.NativeClassPtr, 100666688);
        Entity.TraitStacks._EnableEffects_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._EnableEffects_d__19>.NativeClassPtr, 100666689);
        Entity.TraitStacks._EnableEffects_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._EnableEffects_d__19>.NativeClassPtr, 100666690);
        Entity.TraitStacks._EnableEffects_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._EnableEffects_d__19>.NativeClassPtr, 100666691);
        Entity.TraitStacks._EnableEffects_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._EnableEffects_d__19>.NativeClassPtr, 100666692);
      }

      public _EnableEffects_d__19(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe int __1__state
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._EnableEffects_d__19.NativeFieldInfoPtr___1__state));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._EnableEffects_d__19.NativeFieldInfoPtr___1__state)) = value;
        }
      }

      public unsafe Il2CppSystem.Object __2__current
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._EnableEffects_d__19.NativeFieldInfoPtr___2__current));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._EnableEffects_d__19.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Entity.TraitStacks __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._EnableEffects_d__19.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (Entity.TraitStacks) null : new Entity.TraitStacks(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._EnableEffects_d__19.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Entity entity
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._EnableEffects_d__19.NativeFieldInfoPtr_entity));
          return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._EnableEffects_d__19.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("Entity/TraitStacks/<AddEffectStacks>d__20")]
    public sealed class _AddEffectStacks_d__20 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
      private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_entity;
      private static readonly System.IntPtr NativeFieldInfoPtr_stacks;
      private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap1;
      private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap2;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

      [CallerCount(53)]
      [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe _AddEffectStacks_d__20(int _param1)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Entity.TraitStacks._AddEffectStacks_d__20>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &_param1
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._AddEffectStacks_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(12611)]
      [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_IDisposable_Dispose()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._AddEffectStacks_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44435, XrefRangeEnd = 44450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool MoveNext()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._AddEffectStacks_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._AddEffectStacks_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44450, XrefRangeEnd = 44456, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_Collections_IEnumerator_Reset()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._AddEffectStacks_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
      {
        [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._AddEffectStacks_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
      }

      static _AddEffectStacks_d__20()
      {
        Il2CppClassPointerStore<Entity.TraitStacks._AddEffectStacks_d__20>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr, "<AddEffectStacks>d__20");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Entity.TraitStacks._AddEffectStacks_d__20>.NativeClassPtr);
        Entity.TraitStacks._AddEffectStacks_d__20.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks._AddEffectStacks_d__20>.NativeClassPtr, "<>1__state");
        Entity.TraitStacks._AddEffectStacks_d__20.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks._AddEffectStacks_d__20>.NativeClassPtr, "<>2__current");
        Entity.TraitStacks._AddEffectStacks_d__20.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks._AddEffectStacks_d__20>.NativeClassPtr, "<>4__this");
        Entity.TraitStacks._AddEffectStacks_d__20.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks._AddEffectStacks_d__20>.NativeClassPtr, nameof (entity));
        Entity.TraitStacks._AddEffectStacks_d__20.NativeFieldInfoPtr_stacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks._AddEffectStacks_d__20>.NativeClassPtr, nameof (stacks));
        Entity.TraitStacks._AddEffectStacks_d__20.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks._AddEffectStacks_d__20>.NativeClassPtr, "<>7__wrap1");
        Entity.TraitStacks._AddEffectStacks_d__20.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks._AddEffectStacks_d__20>.NativeClassPtr, "<>7__wrap2");
        Entity.TraitStacks._AddEffectStacks_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._AddEffectStacks_d__20>.NativeClassPtr, 100666693);
        Entity.TraitStacks._AddEffectStacks_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._AddEffectStacks_d__20>.NativeClassPtr, 100666694);
        Entity.TraitStacks._AddEffectStacks_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._AddEffectStacks_d__20>.NativeClassPtr, 100666695);
        Entity.TraitStacks._AddEffectStacks_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._AddEffectStacks_d__20>.NativeClassPtr, 100666696);
        Entity.TraitStacks._AddEffectStacks_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._AddEffectStacks_d__20>.NativeClassPtr, 100666697);
        Entity.TraitStacks._AddEffectStacks_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._AddEffectStacks_d__20>.NativeClassPtr, 100666698);
      }

      public _AddEffectStacks_d__20(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe int __1__state
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._AddEffectStacks_d__20.NativeFieldInfoPtr___1__state));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._AddEffectStacks_d__20.NativeFieldInfoPtr___1__state)) = value;
        }
      }

      public unsafe Il2CppSystem.Object __2__current
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._AddEffectStacks_d__20.NativeFieldInfoPtr___2__current));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._AddEffectStacks_d__20.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Entity.TraitStacks __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._AddEffectStacks_d__20.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (Entity.TraitStacks) null : new Entity.TraitStacks(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._AddEffectStacks_d__20.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Entity entity
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._AddEffectStacks_d__20.NativeFieldInfoPtr_entity));
          return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._AddEffectStacks_d__20.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int stacks
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._AddEffectStacks_d__20.NativeFieldInfoPtr_stacks));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._AddEffectStacks_d__20.NativeFieldInfoPtr_stacks)) = value;
        }
      }

      public unsafe Il2CppReferenceArray<StatusEffectData> __7__wrap1
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._AddEffectStacks_d__20.NativeFieldInfoPtr___7__wrap1));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<StatusEffectData>) null : new Il2CppReferenceArray<StatusEffectData>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._AddEffectStacks_d__20.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int __7__wrap2
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._AddEffectStacks_d__20.NativeFieldInfoPtr___7__wrap2));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._AddEffectStacks_d__20.NativeFieldInfoPtr___7__wrap2)) = value;
        }
      }
    }

    [ObfuscatedName("Entity/TraitStacks/<RemoveEffectStacks>d__21")]
    public sealed class _RemoveEffectStacks_d__21 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
      private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_entity;
      private static readonly System.IntPtr NativeFieldInfoPtr_removeStacks;
      private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap1;
      private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap2;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

      [CallerCount(53)]
      [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe _RemoveEffectStacks_d__21(int _param1)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Entity.TraitStacks._RemoveEffectStacks_d__21>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &_param1
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._RemoveEffectStacks_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(12611)]
      [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_IDisposable_Dispose()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._RemoveEffectStacks_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44456, XrefRangeEnd = 44464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool MoveNext()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._RemoveEffectStacks_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._RemoveEffectStacks_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44464, XrefRangeEnd = 44470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_Collections_IEnumerator_Reset()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._RemoveEffectStacks_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
      {
        [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._RemoveEffectStacks_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
      }

      static _RemoveEffectStacks_d__21()
      {
        Il2CppClassPointerStore<Entity.TraitStacks._RemoveEffectStacks_d__21>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr, "<RemoveEffectStacks>d__21");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Entity.TraitStacks._RemoveEffectStacks_d__21>.NativeClassPtr);
        Entity.TraitStacks._RemoveEffectStacks_d__21.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks._RemoveEffectStacks_d__21>.NativeClassPtr, "<>1__state");
        Entity.TraitStacks._RemoveEffectStacks_d__21.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks._RemoveEffectStacks_d__21>.NativeClassPtr, "<>2__current");
        Entity.TraitStacks._RemoveEffectStacks_d__21.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks._RemoveEffectStacks_d__21>.NativeClassPtr, "<>4__this");
        Entity.TraitStacks._RemoveEffectStacks_d__21.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks._RemoveEffectStacks_d__21>.NativeClassPtr, nameof (entity));
        Entity.TraitStacks._RemoveEffectStacks_d__21.NativeFieldInfoPtr_removeStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks._RemoveEffectStacks_d__21>.NativeClassPtr, nameof (removeStacks));
        Entity.TraitStacks._RemoveEffectStacks_d__21.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks._RemoveEffectStacks_d__21>.NativeClassPtr, "<>7__wrap1");
        Entity.TraitStacks._RemoveEffectStacks_d__21.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks._RemoveEffectStacks_d__21>.NativeClassPtr, "<>7__wrap2");
        Entity.TraitStacks._RemoveEffectStacks_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._RemoveEffectStacks_d__21>.NativeClassPtr, 100666699);
        Entity.TraitStacks._RemoveEffectStacks_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._RemoveEffectStacks_d__21>.NativeClassPtr, 100666700);
        Entity.TraitStacks._RemoveEffectStacks_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._RemoveEffectStacks_d__21>.NativeClassPtr, 100666701);
        Entity.TraitStacks._RemoveEffectStacks_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._RemoveEffectStacks_d__21>.NativeClassPtr, 100666702);
        Entity.TraitStacks._RemoveEffectStacks_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._RemoveEffectStacks_d__21>.NativeClassPtr, 100666703);
        Entity.TraitStacks._RemoveEffectStacks_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._RemoveEffectStacks_d__21>.NativeClassPtr, 100666704);
      }

      public _RemoveEffectStacks_d__21(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe int __1__state
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._RemoveEffectStacks_d__21.NativeFieldInfoPtr___1__state));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._RemoveEffectStacks_d__21.NativeFieldInfoPtr___1__state)) = value;
        }
      }

      public unsafe Il2CppSystem.Object __2__current
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._RemoveEffectStacks_d__21.NativeFieldInfoPtr___2__current));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._RemoveEffectStacks_d__21.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Entity.TraitStacks __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._RemoveEffectStacks_d__21.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (Entity.TraitStacks) null : new Entity.TraitStacks(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._RemoveEffectStacks_d__21.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Entity entity
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._RemoveEffectStacks_d__21.NativeFieldInfoPtr_entity));
          return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._RemoveEffectStacks_d__21.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int removeStacks
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._RemoveEffectStacks_d__21.NativeFieldInfoPtr_removeStacks));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._RemoveEffectStacks_d__21.NativeFieldInfoPtr_removeStacks)) = value;
        }
      }

      public unsafe Il2CppReferenceArray<StatusEffectData> __7__wrap1
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._RemoveEffectStacks_d__21.NativeFieldInfoPtr___7__wrap1));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<StatusEffectData>) null : new Il2CppReferenceArray<StatusEffectData>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._RemoveEffectStacks_d__21.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int __7__wrap2
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._RemoveEffectStacks_d__21.NativeFieldInfoPtr___7__wrap2));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._RemoveEffectStacks_d__21.NativeFieldInfoPtr___7__wrap2)) = value;
        }
      }
    }
  }

  [ObfuscatedName("Entity/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__18_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__23_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__85_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__92_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__95_1;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__95_2;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__95_3;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__get_containers_b__18_0_Internal_CardContainer_CardContainer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__get_preContainers_b__23_0_Internal_CardContainer_CardContainer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ReadyToDie_b__85_0_Internal_Boolean_StatusEffectData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnDestroy_b__92_0_Internal_Boolean_StatusEffectData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__UpdateTraits_b__95_1_Internal_Boolean_TraitStacks_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__UpdateTraits_b__95_2_Internal_Boolean_TraitStacks_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__UpdateTraits_b__95_3_Internal_Boolean_TraitStacks_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Entity.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Entity.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44512, XrefRangeEnd = 44513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CardContainer _get_containers_b__18_0(CardContainer c)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) c)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.__c.NativeMethodInfoPtr__get_containers_b__18_0_Internal_CardContainer_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CardContainer) null : new CardContainer(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CardContainer _get_preContainers_b__23_0(CardContainer c)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) c)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.__c.NativeMethodInfoPtr__get_preContainers_b__23_0_Internal_CardContainer_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CardContainer) null : new CardContainer(pointer);
    }

    [CallerCount(0)]
    public unsafe bool _ReadyToDie_b__85_0(StatusEffectData a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.__c.NativeMethodInfoPtr__ReadyToDie_b__85_0_Internal_Boolean_StatusEffectData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44513, XrefRangeEnd = 44517, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _OnDestroy_b__92_0(StatusEffectData status)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) status)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.__c.NativeMethodInfoPtr__OnDestroy_b__92_0_Internal_Boolean_StatusEffectData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe bool _UpdateTraits_b__95_1(Entity.TraitStacks a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.__c.NativeMethodInfoPtr__UpdateTraits_b__95_1_Internal_Boolean_TraitStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe bool _UpdateTraits_b__95_2(Entity.TraitStacks a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.__c.NativeMethodInfoPtr__UpdateTraits_b__95_2_Internal_Boolean_TraitStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe bool _UpdateTraits_b__95_3(Entity.TraitStacks a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.__c.NativeMethodInfoPtr__UpdateTraits_b__95_3_Internal_Boolean_TraitStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<Entity.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Entity>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Entity.__c>.NativeClassPtr);
      Entity.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.__c>.NativeClassPtr, "<>9");
      Entity.__c.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.__c>.NativeClassPtr, "<>9__18_0");
      Entity.__c.NativeFieldInfoPtr___9__23_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.__c>.NativeClassPtr, "<>9__23_0");
      Entity.__c.NativeFieldInfoPtr___9__85_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.__c>.NativeClassPtr, "<>9__85_0");
      Entity.__c.NativeFieldInfoPtr___9__92_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.__c>.NativeClassPtr, "<>9__92_0");
      Entity.__c.NativeFieldInfoPtr___9__95_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.__c>.NativeClassPtr, "<>9__95_1");
      Entity.__c.NativeFieldInfoPtr___9__95_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.__c>.NativeClassPtr, "<>9__95_2");
      Entity.__c.NativeFieldInfoPtr___9__95_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.__c>.NativeClassPtr, "<>9__95_3");
      Entity.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.__c>.NativeClassPtr, 100666706);
      Entity.__c.NativeMethodInfoPtr__get_containers_b__18_0_Internal_CardContainer_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.__c>.NativeClassPtr, 100666707);
      Entity.__c.NativeMethodInfoPtr__get_preContainers_b__23_0_Internal_CardContainer_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.__c>.NativeClassPtr, 100666708);
      Entity.__c.NativeMethodInfoPtr__ReadyToDie_b__85_0_Internal_Boolean_StatusEffectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.__c>.NativeClassPtr, 100666709);
      Entity.__c.NativeMethodInfoPtr__OnDestroy_b__92_0_Internal_Boolean_StatusEffectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.__c>.NativeClassPtr, 100666710);
      Entity.__c.NativeMethodInfoPtr__UpdateTraits_b__95_1_Internal_Boolean_TraitStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.__c>.NativeClassPtr, 100666711);
      Entity.__c.NativeMethodInfoPtr__UpdateTraits_b__95_2_Internal_Boolean_TraitStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.__c>.NativeClassPtr, 100666712);
      Entity.__c.NativeMethodInfoPtr__UpdateTraits_b__95_3_Internal_Boolean_TraitStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.__c>.NativeClassPtr, 100666713);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe Entity.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(Entity.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Entity.__c) null : new Entity.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Entity.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CardContainer, CardContainer> __9__18_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(Entity.__c.NativeFieldInfoPtr___9__18_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardContainer, CardContainer>) null : new Il2CppSystem.Func<CardContainer, CardContainer>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Entity.__c.NativeFieldInfoPtr___9__18_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CardContainer, CardContainer> __9__23_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(Entity.__c.NativeFieldInfoPtr___9__23_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardContainer, CardContainer>) null : new Il2CppSystem.Func<CardContainer, CardContainer>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Entity.__c.NativeFieldInfoPtr___9__23_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Predicate<StatusEffectData> __9__85_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(Entity.__c.NativeFieldInfoPtr___9__85_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Predicate<StatusEffectData>) null : new Il2CppSystem.Predicate<StatusEffectData>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Entity.__c.NativeFieldInfoPtr___9__85_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<StatusEffectData, bool> __9__92_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(Entity.__c.NativeFieldInfoPtr___9__92_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<StatusEffectData, bool>) null : new Il2CppSystem.Func<StatusEffectData, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Entity.__c.NativeFieldInfoPtr___9__92_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<Entity.TraitStacks, bool> __9__95_1
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(Entity.__c.NativeFieldInfoPtr___9__95_1, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Entity.TraitStacks, bool>) null : new Il2CppSystem.Func<Entity.TraitStacks, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Entity.__c.NativeFieldInfoPtr___9__95_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<Entity.TraitStacks, bool> __9__95_2
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(Entity.__c.NativeFieldInfoPtr___9__95_2, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Entity.TraitStacks, bool>) null : new Il2CppSystem.Func<Entity.TraitStacks, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Entity.__c.NativeFieldInfoPtr___9__95_2, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<Entity.TraitStacks, bool> __9__95_3
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(Entity.__c.NativeFieldInfoPtr___9__95_3, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Entity.TraitStacks, bool>) null : new Il2CppSystem.Func<Entity.TraitStacks, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Entity.__c.NativeFieldInfoPtr___9__95_3, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("Entity/<>c__DisplayClass70_0")]
  public sealed class __c__DisplayClass70_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_type;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__FindStatus_b__0_Internal_Boolean_StatusEffectData_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass70_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Entity.__c__DisplayClass70_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Entity.__c__DisplayClass70_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44517, XrefRangeEnd = 44519, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _FindStatus_b__0(StatusEffectData a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.__c__DisplayClass70_0.NativeMethodInfoPtr__FindStatus_b__0_Internal_Boolean_StatusEffectData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass70_0()
    {
      Il2CppClassPointerStore<Entity.__c__DisplayClass70_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Entity>.NativeClassPtr, "<>c__DisplayClass70_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Entity.__c__DisplayClass70_0>.NativeClassPtr);
      Entity.__c__DisplayClass70_0.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.__c__DisplayClass70_0>.NativeClassPtr, nameof (type));
      Entity.__c__DisplayClass70_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.__c__DisplayClass70_0>.NativeClassPtr, 100666714);
      Entity.__c__DisplayClass70_0.NativeMethodInfoPtr__FindStatus_b__0_Internal_Boolean_StatusEffectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.__c__DisplayClass70_0>.NativeClassPtr, 100666715);
    }

    public __c__DisplayClass70_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string type
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.__c__DisplayClass70_0.NativeFieldInfoPtr_type)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity.__c__DisplayClass70_0.NativeFieldInfoPtr_type), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }

  [ObfuscatedName("Entity/<>c__DisplayClass71_0")]
  public sealed class __c__DisplayClass71_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_dataType;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__FindStatus_b__0_Internal_Boolean_StatusEffectData_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass71_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Entity.__c__DisplayClass71_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Entity.__c__DisplayClass71_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _FindStatus_b__0(StatusEffectData a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.__c__DisplayClass71_0.NativeMethodInfoPtr__FindStatus_b__0_Internal_Boolean_StatusEffectData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass71_0()
    {
      Il2CppClassPointerStore<Entity.__c__DisplayClass71_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Entity>.NativeClassPtr, "<>c__DisplayClass71_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Entity.__c__DisplayClass71_0>.NativeClassPtr);
      Entity.__c__DisplayClass71_0.NativeFieldInfoPtr_dataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.__c__DisplayClass71_0>.NativeClassPtr, nameof (dataType));
      Entity.__c__DisplayClass71_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.__c__DisplayClass71_0>.NativeClassPtr, 100666716);
      Entity.__c__DisplayClass71_0.NativeMethodInfoPtr__FindStatus_b__0_Internal_Boolean_StatusEffectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.__c__DisplayClass71_0>.NativeClassPtr, 100666717);
    }

    public __c__DisplayClass71_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe StatusEffectData dataType
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.__c__DisplayClass71_0.NativeFieldInfoPtr_dataType));
        return pointer == System.IntPtr.Zero ? (StatusEffectData) null : new StatusEffectData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity.__c__DisplayClass71_0.NativeFieldInfoPtr_dataType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("Entity/<ClearStatuses>d__72")]
  public sealed class _ClearStatuses_d__72 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr__i_5__2;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _ClearStatuses_d__72(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Entity._ClearStatuses_d__72>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Entity._ClearStatuses_d__72.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Entity._ClearStatuses_d__72.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44519, XrefRangeEnd = 44527, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity._ClearStatuses_d__72.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity._ClearStatuses_d__72.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44527, XrefRangeEnd = 44533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Entity._ClearStatuses_d__72.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity._ClearStatuses_d__72.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _ClearStatuses_d__72()
    {
      Il2CppClassPointerStore<Entity._ClearStatuses_d__72>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Entity>.NativeClassPtr, "<ClearStatuses>d__72");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Entity._ClearStatuses_d__72>.NativeClassPtr);
      Entity._ClearStatuses_d__72.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._ClearStatuses_d__72>.NativeClassPtr, "<>1__state");
      Entity._ClearStatuses_d__72.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._ClearStatuses_d__72>.NativeClassPtr, "<>2__current");
      Entity._ClearStatuses_d__72.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._ClearStatuses_d__72>.NativeClassPtr, "<>4__this");
      Entity._ClearStatuses_d__72.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._ClearStatuses_d__72>.NativeClassPtr, "<i>5__2");
      Entity._ClearStatuses_d__72.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._ClearStatuses_d__72>.NativeClassPtr, 100666718);
      Entity._ClearStatuses_d__72.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._ClearStatuses_d__72>.NativeClassPtr, 100666719);
      Entity._ClearStatuses_d__72.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._ClearStatuses_d__72>.NativeClassPtr, 100666720);
      Entity._ClearStatuses_d__72.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._ClearStatuses_d__72>.NativeClassPtr, 100666721);
      Entity._ClearStatuses_d__72.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._ClearStatuses_d__72>.NativeClassPtr, 100666722);
      Entity._ClearStatuses_d__72.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._ClearStatuses_d__72>.NativeClassPtr, 100666723);
    }

    public _ClearStatuses_d__72(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity._ClearStatuses_d__72.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity._ClearStatuses_d__72.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity._ClearStatuses_d__72.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity._ClearStatuses_d__72.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity._ClearStatuses_d__72.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity._ClearStatuses_d__72.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int _i_5__2
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity._ClearStatuses_d__72.NativeFieldInfoPtr__i_5__2));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity._ClearStatuses_d__72.NativeFieldInfoPtr__i_5__2)) = value;
      }
    }
  }

  [ObfuscatedName("Entity/<Reset>d__86")]
  public sealed class _Reset_d__86 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _Reset_d__86(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Entity._Reset_d__86>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Entity._Reset_d__86.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Entity._Reset_d__86.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44533, XrefRangeEnd = 44534, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity._Reset_d__86.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity._Reset_d__86.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44534, XrefRangeEnd = 44540, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Entity._Reset_d__86.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity._Reset_d__86.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _Reset_d__86()
    {
      Il2CppClassPointerStore<Entity._Reset_d__86>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Entity>.NativeClassPtr, "<Reset>d__86");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Entity._Reset_d__86>.NativeClassPtr);
      Entity._Reset_d__86.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._Reset_d__86>.NativeClassPtr, "<>1__state");
      Entity._Reset_d__86.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._Reset_d__86>.NativeClassPtr, "<>2__current");
      Entity._Reset_d__86.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._Reset_d__86>.NativeClassPtr, "<>4__this");
      Entity._Reset_d__86.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._Reset_d__86>.NativeClassPtr, 100666724);
      Entity._Reset_d__86.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._Reset_d__86>.NativeClassPtr, 100666725);
      Entity._Reset_d__86.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._Reset_d__86>.NativeClassPtr, 100666726);
      Entity._Reset_d__86.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._Reset_d__86>.NativeClassPtr, 100666727);
      Entity._Reset_d__86.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._Reset_d__86>.NativeClassPtr, 100666728);
      Entity._Reset_d__86.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._Reset_d__86>.NativeClassPtr, 100666729);
    }

    public _Reset_d__86(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity._Reset_d__86.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity._Reset_d__86.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity._Reset_d__86.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity._Reset_d__86.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity._Reset_d__86.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity._Reset_d__86.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("Entity/<>c__DisplayClass88_0")]
  public sealed class __c__DisplayClass88_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_target;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CanPlayOn_b__0_Internal_Boolean_TargetConstraint_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CanPlayOn_b__1_Internal_Boolean_StatusEffectStacks_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass88_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Entity.__c__DisplayClass88_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Entity.__c__DisplayClass88_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _CanPlayOn_b__0(TargetConstraint c)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) c)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.__c__DisplayClass88_0.NativeMethodInfoPtr__CanPlayOn_b__0_Internal_Boolean_TargetConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44540, XrefRangeEnd = 44541, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _CanPlayOn_b__1(CardData.StatusEffectStacks s)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) s)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.__c__DisplayClass88_0.NativeMethodInfoPtr__CanPlayOn_b__1_Internal_Boolean_StatusEffectStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass88_0()
    {
      Il2CppClassPointerStore<Entity.__c__DisplayClass88_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Entity>.NativeClassPtr, "<>c__DisplayClass88_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Entity.__c__DisplayClass88_0>.NativeClassPtr);
      Entity.__c__DisplayClass88_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.__c__DisplayClass88_0>.NativeClassPtr, nameof (target));
      Entity.__c__DisplayClass88_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.__c__DisplayClass88_0>.NativeClassPtr, 100666730);
      Entity.__c__DisplayClass88_0.NativeMethodInfoPtr__CanPlayOn_b__0_Internal_Boolean_TargetConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.__c__DisplayClass88_0>.NativeClassPtr, 100666731);
      Entity.__c__DisplayClass88_0.NativeMethodInfoPtr__CanPlayOn_b__1_Internal_Boolean_StatusEffectStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.__c__DisplayClass88_0>.NativeClassPtr, 100666732);
    }

    public __c__DisplayClass88_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Entity target
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.__c__DisplayClass88_0.NativeFieldInfoPtr_target));
        return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity.__c__DisplayClass88_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("Entity/<Kill>d__90")]
  public sealed class _Kill_d__90 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_deathType;
    private static readonly System.IntPtr NativeFieldInfoPtr__clump_5__2;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _Kill_d__90(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Entity._Kill_d__90>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Entity._Kill_d__90.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Entity._Kill_d__90.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44541, XrefRangeEnd = 44554, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity._Kill_d__90.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity._Kill_d__90.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44554, XrefRangeEnd = 44560, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Entity._Kill_d__90.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity._Kill_d__90.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _Kill_d__90()
    {
      Il2CppClassPointerStore<Entity._Kill_d__90>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Entity>.NativeClassPtr, "<Kill>d__90");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Entity._Kill_d__90>.NativeClassPtr);
      Entity._Kill_d__90.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._Kill_d__90>.NativeClassPtr, "<>1__state");
      Entity._Kill_d__90.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._Kill_d__90>.NativeClassPtr, "<>2__current");
      Entity._Kill_d__90.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._Kill_d__90>.NativeClassPtr, "<>4__this");
      Entity._Kill_d__90.NativeFieldInfoPtr_deathType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._Kill_d__90>.NativeClassPtr, nameof (deathType));
      Entity._Kill_d__90.NativeFieldInfoPtr__clump_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._Kill_d__90>.NativeClassPtr, "<clump>5__2");
      Entity._Kill_d__90.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._Kill_d__90>.NativeClassPtr, 100666733);
      Entity._Kill_d__90.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._Kill_d__90>.NativeClassPtr, 100666734);
      Entity._Kill_d__90.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._Kill_d__90>.NativeClassPtr, 100666735);
      Entity._Kill_d__90.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._Kill_d__90>.NativeClassPtr, 100666736);
      Entity._Kill_d__90.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._Kill_d__90>.NativeClassPtr, 100666737);
      Entity._Kill_d__90.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._Kill_d__90>.NativeClassPtr, 100666738);
    }

    public _Kill_d__90(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity._Kill_d__90.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity._Kill_d__90.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity._Kill_d__90.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity._Kill_d__90.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity._Kill_d__90.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity._Kill_d__90.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe DeathType deathType
    {
      get
      {
        return *(DeathType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity._Kill_d__90.NativeFieldInfoPtr_deathType));
      }
      [param: In] set
      {
        *(DeathType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity._Kill_d__90.NativeFieldInfoPtr_deathType)) = value;
      }
    }

    public unsafe Routine.Clump _clump_5__2
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity._Kill_d__90.NativeFieldInfoPtr__clump_5__2));
        return pointer == System.IntPtr.Zero ? (Routine.Clump) null : new Routine.Clump(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity._Kill_d__90.NativeFieldInfoPtr__clump_5__2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("Entity/<>c__DisplayClass93_0")]
  public sealed class __c__DisplayClass93_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_traitData;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GainTrait_b__0_Internal_Boolean_TraitStacks_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass93_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Entity.__c__DisplayClass93_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Entity.__c__DisplayClass93_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44560, XrefRangeEnd = 44605, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GainTrait_b__0(Entity.TraitStacks a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity.__c__DisplayClass93_0.NativeMethodInfoPtr__GainTrait_b__0_Internal_Boolean_TraitStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass93_0()
    {
      Il2CppClassPointerStore<Entity.__c__DisplayClass93_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Entity>.NativeClassPtr, "<>c__DisplayClass93_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Entity.__c__DisplayClass93_0>.NativeClassPtr);
      Entity.__c__DisplayClass93_0.NativeFieldInfoPtr_traitData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.__c__DisplayClass93_0>.NativeClassPtr, nameof (traitData));
      Entity.__c__DisplayClass93_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.__c__DisplayClass93_0>.NativeClassPtr, 100666739);
      Entity.__c__DisplayClass93_0.NativeMethodInfoPtr__GainTrait_b__0_Internal_Boolean_TraitStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.__c__DisplayClass93_0>.NativeClassPtr, 100666740);
    }

    public __c__DisplayClass93_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TraitData traitData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity.__c__DisplayClass93_0.NativeFieldInfoPtr_traitData));
        return pointer == System.IntPtr.Zero ? (TraitData) null : new TraitData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity.__c__DisplayClass93_0.NativeFieldInfoPtr_traitData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("Entity/<UpdateTraits>d__95")]
  public sealed class _UpdateTraits_d__95 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_moveToFront;
    private static readonly System.IntPtr NativeFieldInfoPtr__i_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap2;
    private static readonly System.IntPtr NativeFieldInfoPtr__t_5__4;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___m__Finally3_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _UpdateTraits_d__95(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Entity._UpdateTraits_d__95>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Entity._UpdateTraits_d__95.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 44626, RefRangeEnd = 44627, XrefRangeStart = 44605, XrefRangeEnd = 44626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Entity._UpdateTraits_d__95.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44627, XrefRangeEnd = 44925, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity._UpdateTraits_d__95.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 44928, RefRangeEnd = 44929, XrefRangeStart = 44925, XrefRangeEnd = 44928, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void __m__Finally1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Entity._UpdateTraits_d__95.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44929, XrefRangeEnd = 44932, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void __m__Finally2()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Entity._UpdateTraits_d__95.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44932, XrefRangeEnd = 44935, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void __m__Finally3()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Entity._UpdateTraits_d__95.NativeMethodInfoPtr___m__Finally3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity._UpdateTraits_d__95.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44935, XrefRangeEnd = 44941, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Entity._UpdateTraits_d__95.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Entity._UpdateTraits_d__95.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _UpdateTraits_d__95()
    {
      Il2CppClassPointerStore<Entity._UpdateTraits_d__95>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Entity>.NativeClassPtr, "<UpdateTraits>d__95");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Entity._UpdateTraits_d__95>.NativeClassPtr);
      Entity._UpdateTraits_d__95.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._UpdateTraits_d__95>.NativeClassPtr, "<>1__state");
      Entity._UpdateTraits_d__95.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._UpdateTraits_d__95>.NativeClassPtr, "<>2__current");
      Entity._UpdateTraits_d__95.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._UpdateTraits_d__95>.NativeClassPtr, "<>4__this");
      Entity._UpdateTraits_d__95.NativeFieldInfoPtr_moveToFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._UpdateTraits_d__95>.NativeClassPtr, nameof (moveToFront));
      Entity._UpdateTraits_d__95.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._UpdateTraits_d__95>.NativeClassPtr, "<i>5__2");
      Entity._UpdateTraits_d__95.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._UpdateTraits_d__95>.NativeClassPtr, "<>7__wrap2");
      Entity._UpdateTraits_d__95.NativeFieldInfoPtr__t_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._UpdateTraits_d__95>.NativeClassPtr, "<t>5__4");
      Entity._UpdateTraits_d__95.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._UpdateTraits_d__95>.NativeClassPtr, 100666741);
      Entity._UpdateTraits_d__95.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._UpdateTraits_d__95>.NativeClassPtr, 100666742);
      Entity._UpdateTraits_d__95.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._UpdateTraits_d__95>.NativeClassPtr, 100666743);
      Entity._UpdateTraits_d__95.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._UpdateTraits_d__95>.NativeClassPtr, 100666744);
      Entity._UpdateTraits_d__95.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._UpdateTraits_d__95>.NativeClassPtr, 100666745);
      Entity._UpdateTraits_d__95.NativeMethodInfoPtr___m__Finally3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._UpdateTraits_d__95>.NativeClassPtr, 100666746);
      Entity._UpdateTraits_d__95.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._UpdateTraits_d__95>.NativeClassPtr, 100666747);
      Entity._UpdateTraits_d__95.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._UpdateTraits_d__95>.NativeClassPtr, 100666748);
      Entity._UpdateTraits_d__95.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._UpdateTraits_d__95>.NativeClassPtr, 100666749);
    }

    public _UpdateTraits_d__95(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity._UpdateTraits_d__95.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity._UpdateTraits_d__95.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity._UpdateTraits_d__95.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity._UpdateTraits_d__95.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity._UpdateTraits_d__95.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity._UpdateTraits_d__95.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity.TraitStacks moveToFront
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity._UpdateTraits_d__95.NativeFieldInfoPtr_moveToFront));
        return pointer == System.IntPtr.Zero ? (Entity.TraitStacks) null : new Entity.TraitStacks(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity._UpdateTraits_d__95.NativeFieldInfoPtr_moveToFront), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int _i_5__2
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity._UpdateTraits_d__95.NativeFieldInfoPtr__i_5__2));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity._UpdateTraits_d__95.NativeFieldInfoPtr__i_5__2)) = value;
      }
    }

    public unsafe IEnumerator<Entity.TraitStacks> __7__wrap2
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity._UpdateTraits_d__95.NativeFieldInfoPtr___7__wrap2));
        return pointer == System.IntPtr.Zero ? (IEnumerator<Entity.TraitStacks>) null : new IEnumerator<Entity.TraitStacks>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity._UpdateTraits_d__95.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity.TraitStacks _t_5__4
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Entity._UpdateTraits_d__95.NativeFieldInfoPtr__t_5__4));
        return pointer == System.IntPtr.Zero ? (Entity.TraitStacks) null : new Entity.TraitStacks(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Entity._UpdateTraits_d__95.NativeFieldInfoPtr__t_5__4), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
