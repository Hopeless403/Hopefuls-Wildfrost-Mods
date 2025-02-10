// Decompiled with JetBrains decompiler
// Type: CampaignNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
[Serializable]
public class CampaignNode : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_name;
  private static readonly System.IntPtr NativeFieldInfoPtr_id;
  private static readonly System.IntPtr NativeFieldInfoPtr__type_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr_seed;
  private static readonly System.IntPtr NativeFieldInfoPtr_position;
  private static readonly System.IntPtr NativeFieldInfoPtr_tier;
  private static readonly System.IntPtr NativeFieldInfoPtr_positionIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_areaIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_connections;
  private static readonly System.IntPtr NativeFieldInfoPtr_characters;
  private static readonly System.IntPtr NativeFieldInfoPtr_revealed;
  private static readonly System.IntPtr NativeFieldInfoPtr_cleared;
  private static readonly System.IntPtr NativeFieldInfoPtr_radius;
  private static readonly System.IntPtr NativeFieldInfoPtr_glow;
  private static readonly System.IntPtr NativeFieldInfoPtr_finalNode;
  private static readonly System.IntPtr NativeFieldInfoPtr_data;
  private static readonly System.IntPtr NativeFieldInfoPtr_connectedTo;
  private static readonly System.IntPtr NativeFieldInfoPtr_pathId;
  private static readonly System.IntPtr NativeFieldInfoPtr_dataLinkedTo;
  private static readonly System.IntPtr NativeFieldInfoPtr_linkedToThis;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_type_Public_get_CampaignNodeType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_type_Private_set_Void_CampaignNodeType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyData_Public_Void_CampaignNode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneDataValue_Private_Object_KeyValuePair_2_String_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CampaignNodeType_Single_Single_Int32_Int32_Int32_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetUp_Public_Virtual_New_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Run_Public_Virtual_New_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ConnectTo_Public_Void_CampaignNode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CanReceiveCharacter_Public_Boolean_Character_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetType_Public_Void_CampaignNodeType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDesc_Public_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetCleared_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Virtual_Final_New_CampaignNodeSaveData_0;

  public unsafe CampaignNodeType type
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignNode.NativeMethodInfoPtr_get_type_Public_get_CampaignNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CampaignNodeType) null : new CampaignNodeType(pointer);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 54210, RefRangeEnd = 54212, XrefRangeStart = 54210, XrefRangeEnd = 54212, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CampaignNode.NativeMethodInfoPtr_set_type_Private_set_Void_CampaignNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 102075, RefRangeEnd = 102076, XrefRangeStart = 102049, XrefRangeEnd = 102075, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CopyData(CampaignNode otherNode)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) otherNode)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CampaignNode.NativeMethodInfoPtr_CopyData_Public_Void_CampaignNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102076, XrefRangeEnd = 102080, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Il2CppSystem.Object CloneDataValue(KeyValuePair<string, Il2CppSystem.Object> pair)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) pair))
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignNode.NativeMethodInfoPtr_CloneDataValue_Private_Object_KeyValuePair_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102080, XrefRangeEnd = 102085, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CampaignNode()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CampaignNode>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CampaignNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 102107, RefRangeEnd = 102109, XrefRangeStart = 102085, XrefRangeEnd = 102107, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CampaignNode(
    CampaignNodeType type,
    float x,
    float y,
    int tier,
    int positionIndex,
    int areaIndex,
    float radius)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CampaignNode>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &x;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &tier;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &positionIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &areaIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CampaignNode.NativeMethodInfoPtr__ctor_Public_Void_CampaignNodeType_Single_Single_Int32_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(44)]
  [CachedScanResults(RefRangeStart = 26224, RefRangeEnd = 26268, XrefRangeStart = 26224, XrefRangeEnd = 26268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe IEnumerator SetUp()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CampaignNode.NativeMethodInfoPtr_SetUp_Public_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(44)]
  [CachedScanResults(RefRangeStart = 26224, RefRangeEnd = 26268, XrefRangeStart = 26224, XrefRangeEnd = 26268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe IEnumerator Run()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CampaignNode.NativeMethodInfoPtr_Run_Public_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 102122, RefRangeEnd = 102124, XrefRangeStart = 102109, XrefRangeEnd = 102122, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ConnectTo(CampaignNode other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CampaignNode.NativeMethodInfoPtr_ConnectTo_Public_Void_CampaignNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102124, XrefRangeEnd = 102125, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CanReceiveCharacter(Character character)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) character)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignNode.NativeMethodInfoPtr_CanReceiveCharacter_Public_Boolean_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 102127, RefRangeEnd = 102128, XrefRangeStart = 102125, XrefRangeEnd = 102127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetType(CampaignNodeType type)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CampaignNode.NativeMethodInfoPtr_SetType_Public_Void_CampaignNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102128, XrefRangeEnd = 102204, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe string GetDesc()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CampaignNode.NativeMethodInfoPtr_GetDesc_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 102205, RefRangeEnd = 102214, XrefRangeStart = 102204, XrefRangeEnd = 102205, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetCleared()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CampaignNode.NativeMethodInfoPtr_SetCleared_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102214, XrefRangeEnd = 102224, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe CampaignNodeSaveData Save()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignNode.NativeMethodInfoPtr_Save_Public_Virtual_Final_New_CampaignNodeSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (CampaignNodeSaveData) null : new CampaignNodeSaveData(pointer);
  }

  static CampaignNode()
  {
    Il2CppClassPointerStore<CampaignNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CampaignNode));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CampaignNode>.NativeClassPtr);
    CampaignNode.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNode>.NativeClassPtr, nameof (name));
    CampaignNode.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNode>.NativeClassPtr, nameof (id));
    CampaignNode.NativeFieldInfoPtr__type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNode>.NativeClassPtr, "<type>k__BackingField");
    CampaignNode.NativeFieldInfoPtr_seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNode>.NativeClassPtr, nameof (seed));
    CampaignNode.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNode>.NativeClassPtr, nameof (position));
    CampaignNode.NativeFieldInfoPtr_tier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNode>.NativeClassPtr, nameof (tier));
    CampaignNode.NativeFieldInfoPtr_positionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNode>.NativeClassPtr, nameof (positionIndex));
    CampaignNode.NativeFieldInfoPtr_areaIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNode>.NativeClassPtr, nameof (areaIndex));
    CampaignNode.NativeFieldInfoPtr_connections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNode>.NativeClassPtr, nameof (connections));
    CampaignNode.NativeFieldInfoPtr_characters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNode>.NativeClassPtr, nameof (characters));
    CampaignNode.NativeFieldInfoPtr_revealed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNode>.NativeClassPtr, nameof (revealed));
    CampaignNode.NativeFieldInfoPtr_cleared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNode>.NativeClassPtr, nameof (cleared));
    CampaignNode.NativeFieldInfoPtr_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNode>.NativeClassPtr, nameof (radius));
    CampaignNode.NativeFieldInfoPtr_glow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNode>.NativeClassPtr, nameof (glow));
    CampaignNode.NativeFieldInfoPtr_finalNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNode>.NativeClassPtr, nameof (finalNode));
    CampaignNode.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNode>.NativeClassPtr, nameof (data));
    CampaignNode.NativeFieldInfoPtr_connectedTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNode>.NativeClassPtr, nameof (connectedTo));
    CampaignNode.NativeFieldInfoPtr_pathId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNode>.NativeClassPtr, nameof (pathId));
    CampaignNode.NativeFieldInfoPtr_dataLinkedTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNode>.NativeClassPtr, nameof (dataLinkedTo));
    CampaignNode.NativeFieldInfoPtr_linkedToThis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNode>.NativeClassPtr, nameof (linkedToThis));
    CampaignNode.NativeMethodInfoPtr_get_type_Public_get_CampaignNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignNode>.NativeClassPtr, 100672469);
    CampaignNode.NativeMethodInfoPtr_set_type_Private_set_Void_CampaignNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignNode>.NativeClassPtr, 100672470);
    CampaignNode.NativeMethodInfoPtr_CopyData_Public_Void_CampaignNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignNode>.NativeClassPtr, 100672471);
    CampaignNode.NativeMethodInfoPtr_CloneDataValue_Private_Object_KeyValuePair_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignNode>.NativeClassPtr, 100672472);
    CampaignNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignNode>.NativeClassPtr, 100672473);
    CampaignNode.NativeMethodInfoPtr__ctor_Public_Void_CampaignNodeType_Single_Single_Int32_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignNode>.NativeClassPtr, 100672474);
    CampaignNode.NativeMethodInfoPtr_SetUp_Public_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignNode>.NativeClassPtr, 100672475);
    CampaignNode.NativeMethodInfoPtr_Run_Public_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignNode>.NativeClassPtr, 100672476);
    CampaignNode.NativeMethodInfoPtr_ConnectTo_Public_Void_CampaignNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignNode>.NativeClassPtr, 100672477);
    CampaignNode.NativeMethodInfoPtr_CanReceiveCharacter_Public_Boolean_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignNode>.NativeClassPtr, 100672478);
    CampaignNode.NativeMethodInfoPtr_SetType_Public_Void_CampaignNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignNode>.NativeClassPtr, 100672479);
    CampaignNode.NativeMethodInfoPtr_GetDesc_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignNode>.NativeClassPtr, 100672480);
    CampaignNode.NativeMethodInfoPtr_SetCleared_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignNode>.NativeClassPtr, 100672481);
    CampaignNode.NativeMethodInfoPtr_Save_Public_Virtual_Final_New_CampaignNodeSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignNode>.NativeClassPtr, 100672482);
  }

  public CampaignNode(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe string name
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNode.NativeFieldInfoPtr_name)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignNode.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe int id
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNode.NativeFieldInfoPtr_id));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNode.NativeFieldInfoPtr_id)) = value;
    }
  }

  public unsafe CampaignNodeType _type_k__BackingField
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNode.NativeFieldInfoPtr__type_k__BackingField));
      return pointer == System.IntPtr.Zero ? (CampaignNodeType) null : new CampaignNodeType(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignNode.NativeFieldInfoPtr__type_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int seed
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNode.NativeFieldInfoPtr_seed));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNode.NativeFieldInfoPtr_seed)) = value;
    }
  }

  public unsafe Vector2 position
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNode.NativeFieldInfoPtr_position));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNode.NativeFieldInfoPtr_position)) = value;
    }
  }

  public unsafe int tier
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNode.NativeFieldInfoPtr_tier));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNode.NativeFieldInfoPtr_tier)) = value;
    }
  }

  public unsafe int positionIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNode.NativeFieldInfoPtr_positionIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNode.NativeFieldInfoPtr_positionIndex)) = value;
    }
  }

  public unsafe int areaIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNode.NativeFieldInfoPtr_areaIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNode.NativeFieldInfoPtr_areaIndex)) = value;
    }
  }

  public unsafe List<CampaignNode.Connection> connections
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNode.NativeFieldInfoPtr_connections));
      return pointer == System.IntPtr.Zero ? (List<CampaignNode.Connection>) null : new List<CampaignNode.Connection>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignNode.NativeFieldInfoPtr_connections), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<int> characters
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNode.NativeFieldInfoPtr_characters));
      return pointer == System.IntPtr.Zero ? (List<int>) null : new List<int>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignNode.NativeFieldInfoPtr_characters), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool revealed
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNode.NativeFieldInfoPtr_revealed));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNode.NativeFieldInfoPtr_revealed)) = value;
    }
  }

  public unsafe bool cleared
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNode.NativeFieldInfoPtr_cleared));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNode.NativeFieldInfoPtr_cleared)) = value;
    }
  }

  public unsafe float radius
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNode.NativeFieldInfoPtr_radius));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNode.NativeFieldInfoPtr_radius)) = value;
    }
  }

  public unsafe bool glow
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNode.NativeFieldInfoPtr_glow));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNode.NativeFieldInfoPtr_glow)) = value;
    }
  }

  public unsafe bool finalNode
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNode.NativeFieldInfoPtr_finalNode));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNode.NativeFieldInfoPtr_finalNode)) = value;
    }
  }

  public unsafe Dictionary<string, Il2CppSystem.Object> data
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNode.NativeFieldInfoPtr_data));
      return pointer == System.IntPtr.Zero ? (Dictionary<string, Il2CppSystem.Object>) null : new Dictionary<string, Il2CppSystem.Object>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignNode.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int connectedTo
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNode.NativeFieldInfoPtr_connectedTo));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNode.NativeFieldInfoPtr_connectedTo)) = value;
    }
  }

  public unsafe int pathId
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNode.NativeFieldInfoPtr_pathId));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNode.NativeFieldInfoPtr_pathId)) = value;
    }
  }

  public unsafe int dataLinkedTo
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNode.NativeFieldInfoPtr_dataLinkedTo));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNode.NativeFieldInfoPtr_dataLinkedTo)) = value;
    }
  }

  public unsafe List<int> linkedToThis
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNode.NativeFieldInfoPtr_linkedToThis));
      return pointer == System.IntPtr.Zero ? (List<int>) null : new List<int>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignNode.NativeFieldInfoPtr_linkedToThis), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class Connection : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_otherId;
    private static readonly System.IntPtr NativeFieldInfoPtr_direction;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Connection()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CampaignNode.Connection>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CampaignNode.Connection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Connection()
    {
      Il2CppClassPointerStore<CampaignNode.Connection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CampaignNode>.NativeClassPtr, nameof (Connection));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CampaignNode.Connection>.NativeClassPtr);
      CampaignNode.Connection.NativeFieldInfoPtr_otherId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNode.Connection>.NativeClassPtr, nameof (otherId));
      CampaignNode.Connection.NativeFieldInfoPtr_direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNode.Connection>.NativeClassPtr, nameof (direction));
      CampaignNode.Connection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignNode.Connection>.NativeClassPtr, 100672483);
    }

    public Connection(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int otherId
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNode.Connection.NativeFieldInfoPtr_otherId));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNode.Connection.NativeFieldInfoPtr_otherId)) = value;
      }
    }

    public unsafe float direction
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNode.Connection.NativeFieldInfoPtr_direction));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNode.Connection.NativeFieldInfoPtr_direction)) = value;
      }
    }
  }

  [ObfuscatedName("CampaignNode/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__23_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CopyData_b__23_0_Internal_String_KeyValuePair_2_String_Object_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CampaignNode.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CampaignNode.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102048, XrefRangeEnd = 102049, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _CopyData_b__23_0(KeyValuePair<string, Il2CppSystem.Object> entry)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) entry))
      };
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CampaignNode.__c.NativeMethodInfoPtr__CopyData_b__23_0_Internal_String_KeyValuePair_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static __c()
    {
      Il2CppClassPointerStore<CampaignNode.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CampaignNode>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CampaignNode.__c>.NativeClassPtr);
      CampaignNode.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNode.__c>.NativeClassPtr, "<>9");
      CampaignNode.__c.NativeFieldInfoPtr___9__23_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNode.__c>.NativeClassPtr, "<>9__23_0");
      CampaignNode.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignNode.__c>.NativeClassPtr, 100672485);
      CampaignNode.__c.NativeMethodInfoPtr__CopyData_b__23_0_Internal_String_KeyValuePair_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignNode.__c>.NativeClassPtr, 100672486);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe CampaignNode.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CampaignNode.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (CampaignNode.__c) null : new CampaignNode.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CampaignNode.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<KeyValuePair<string, Il2CppSystem.Object>, string> __9__23_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CampaignNode.__c.NativeFieldInfoPtr___9__23_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<KeyValuePair<string, Il2CppSystem.Object>, string>) null : new Il2CppSystem.Func<KeyValuePair<string, Il2CppSystem.Object>, string>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CampaignNode.__c.NativeFieldInfoPtr___9__23_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
