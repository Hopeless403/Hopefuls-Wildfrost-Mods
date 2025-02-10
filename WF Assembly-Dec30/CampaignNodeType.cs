// Decompiled with JetBrains decompiler
// Type: CampaignNodeType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class CampaignNodeType : ScriptableObject
{
  private static readonly IntPtr NativeFieldInfoPtr_letter;
  private static readonly IntPtr NativeFieldInfoPtr_zoneName;
  private static readonly IntPtr NativeFieldInfoPtr_mustClear;
  private static readonly IntPtr NativeFieldInfoPtr_canSkip;
  private static readonly IntPtr NativeFieldInfoPtr_canEnter;
  private static readonly IntPtr NativeFieldInfoPtr_isBattle;
  private static readonly IntPtr NativeFieldInfoPtr_isBoss;
  private static readonly IntPtr NativeFieldInfoPtr_modifierReward;
  private static readonly IntPtr NativeFieldInfoPtr_interactable;
  private static readonly IntPtr NativeFieldInfoPtr_startRevealed;
  private static readonly IntPtr NativeFieldInfoPtr_finalNode;
  private static readonly IntPtr NativeFieldInfoPtr_mapNodePrefab;
  private static readonly IntPtr NativeFieldInfoPtr_mapNodeSprite;
  private static readonly IntPtr NativeFieldInfoPtr_size;
  private static readonly IntPtr NativeFieldInfoPtr_canLink;
  private static readonly IntPtr NativeMethodInfoPtr_SetUp_Public_Virtual_New_IEnumerator_CampaignNode_0;
  private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_New_IEnumerator_CampaignNode_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(44)]
  [CachedScanResults(RefRangeStart = 26224, RefRangeEnd = 26268, XrefRangeStart = 26224, XrefRangeEnd = 26268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe IEnumerator SetUp(CampaignNode node)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CampaignNodeType.NativeMethodInfoPtr_SetUp_Public_Virtual_New_IEnumerator_CampaignNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    IntPtr pointer = num;
    return pointer == IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(44)]
  [CachedScanResults(RefRangeStart = 26224, RefRangeEnd = 26268, XrefRangeStart = 26224, XrefRangeEnd = 26268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe IEnumerator Run(CampaignNode node)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CampaignNodeType.NativeMethodInfoPtr_Run_Public_Virtual_New_IEnumerator_CampaignNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    IntPtr pointer = num;
    return pointer == IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106112, XrefRangeEnd = 106113, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CampaignNodeType()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CampaignNodeType>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CampaignNodeType.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CampaignNodeType()
  {
    Il2CppClassPointerStore<CampaignNodeType>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CampaignNodeType));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CampaignNodeType>.NativeClassPtr);
    CampaignNodeType.NativeFieldInfoPtr_letter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNodeType>.NativeClassPtr, nameof (letter));
    CampaignNodeType.NativeFieldInfoPtr_zoneName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNodeType>.NativeClassPtr, nameof (zoneName));
    CampaignNodeType.NativeFieldInfoPtr_mustClear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNodeType>.NativeClassPtr, nameof (mustClear));
    CampaignNodeType.NativeFieldInfoPtr_canSkip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNodeType>.NativeClassPtr, nameof (canSkip));
    CampaignNodeType.NativeFieldInfoPtr_canEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNodeType>.NativeClassPtr, nameof (canEnter));
    CampaignNodeType.NativeFieldInfoPtr_isBattle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNodeType>.NativeClassPtr, nameof (isBattle));
    CampaignNodeType.NativeFieldInfoPtr_isBoss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNodeType>.NativeClassPtr, nameof (isBoss));
    CampaignNodeType.NativeFieldInfoPtr_modifierReward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNodeType>.NativeClassPtr, nameof (modifierReward));
    CampaignNodeType.NativeFieldInfoPtr_interactable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNodeType>.NativeClassPtr, nameof (interactable));
    CampaignNodeType.NativeFieldInfoPtr_startRevealed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNodeType>.NativeClassPtr, nameof (startRevealed));
    CampaignNodeType.NativeFieldInfoPtr_finalNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNodeType>.NativeClassPtr, nameof (finalNode));
    CampaignNodeType.NativeFieldInfoPtr_mapNodePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNodeType>.NativeClassPtr, nameof (mapNodePrefab));
    CampaignNodeType.NativeFieldInfoPtr_mapNodeSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNodeType>.NativeClassPtr, nameof (mapNodeSprite));
    CampaignNodeType.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNodeType>.NativeClassPtr, nameof (size));
    CampaignNodeType.NativeFieldInfoPtr_canLink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNodeType>.NativeClassPtr, nameof (canLink));
    CampaignNodeType.NativeMethodInfoPtr_SetUp_Public_Virtual_New_IEnumerator_CampaignNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignNodeType>.NativeClassPtr, 100672866);
    CampaignNodeType.NativeMethodInfoPtr_Run_Public_Virtual_New_IEnumerator_CampaignNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignNodeType>.NativeClassPtr, 100672867);
    CampaignNodeType.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignNodeType>.NativeClassPtr, 100672868);
  }

  public CampaignNodeType(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe string letter
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeType.NativeFieldInfoPtr_letter)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeType.NativeFieldInfoPtr_letter), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string zoneName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeType.NativeFieldInfoPtr_zoneName)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeType.NativeFieldInfoPtr_zoneName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe bool mustClear
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeType.NativeFieldInfoPtr_mustClear));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeType.NativeFieldInfoPtr_mustClear)) = value;
    }
  }

  public unsafe bool canSkip
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeType.NativeFieldInfoPtr_canSkip));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeType.NativeFieldInfoPtr_canSkip)) = value;
    }
  }

  public unsafe bool canEnter
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeType.NativeFieldInfoPtr_canEnter));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeType.NativeFieldInfoPtr_canEnter)) = value;
    }
  }

  public unsafe bool isBattle
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeType.NativeFieldInfoPtr_isBattle));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeType.NativeFieldInfoPtr_isBattle)) = value;
    }
  }

  public unsafe bool isBoss
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeType.NativeFieldInfoPtr_isBoss));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeType.NativeFieldInfoPtr_isBoss)) = value;
    }
  }

  public unsafe bool modifierReward
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeType.NativeFieldInfoPtr_modifierReward));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeType.NativeFieldInfoPtr_modifierReward)) = value;
    }
  }

  public unsafe bool interactable
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeType.NativeFieldInfoPtr_interactable));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeType.NativeFieldInfoPtr_interactable)) = value;
    }
  }

  public unsafe bool startRevealed
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeType.NativeFieldInfoPtr_startRevealed));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeType.NativeFieldInfoPtr_startRevealed)) = value;
    }
  }

  public unsafe bool finalNode
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeType.NativeFieldInfoPtr_finalNode));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeType.NativeFieldInfoPtr_finalNode)) = value;
    }
  }

  public unsafe MapNode mapNodePrefab
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeType.NativeFieldInfoPtr_mapNodePrefab));
      return pointer == IntPtr.Zero ? (MapNode) null : new MapNode(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeType.NativeFieldInfoPtr_mapNodePrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite mapNodeSprite
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeType.NativeFieldInfoPtr_mapNodeSprite));
      return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeType.NativeFieldInfoPtr_mapNodeSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float size
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeType.NativeFieldInfoPtr_size));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeType.NativeFieldInfoPtr_size)) = value;
    }
  }

  public unsafe bool canLink
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeType.NativeFieldInfoPtr_canLink));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeType.NativeFieldInfoPtr_canLink)) = value;
    }
  }
}
