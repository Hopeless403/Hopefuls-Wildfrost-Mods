// Decompiled with JetBrains decompiler
// Type: CampaignNodeSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
[Serializable]
public class CampaignNodeSaveData : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_name;
  private static readonly System.IntPtr NativeFieldInfoPtr_id;
  private static readonly System.IntPtr NativeFieldInfoPtr_typeName;
  private static readonly System.IntPtr NativeFieldInfoPtr_seed;
  private static readonly System.IntPtr NativeFieldInfoPtr_position;
  private static readonly System.IntPtr NativeFieldInfoPtr_tier;
  private static readonly System.IntPtr NativeFieldInfoPtr_positionIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_areaIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_connections;
  private static readonly System.IntPtr NativeFieldInfoPtr_characters;
  private static readonly System.IntPtr NativeFieldInfoPtr_revealed;
  private static readonly System.IntPtr NativeFieldInfoPtr_cleared;
  private static readonly System.IntPtr NativeFieldInfoPtr_glow;
  private static readonly System.IntPtr NativeFieldInfoPtr_finalNode;
  private static readonly System.IntPtr NativeFieldInfoPtr_data;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CampaignNode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Final_New_CampaignNode_0;

  [CallerCount(1959)]
  [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CampaignNodeSaveData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CampaignNodeSaveData>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CampaignNodeSaveData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103586, XrefRangeEnd = 103594, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CampaignNodeSaveData(CampaignNode node)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CampaignNodeSaveData>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CampaignNodeSaveData.NativeMethodInfoPtr__ctor_Public_Void_CampaignNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103594, XrefRangeEnd = 103616, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe CampaignNode Load()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignNodeSaveData.NativeMethodInfoPtr_Load_Public_Virtual_Final_New_CampaignNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (CampaignNode) null : new CampaignNode(pointer);
  }

  static CampaignNodeSaveData()
  {
    Il2CppClassPointerStore<CampaignNodeSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CampaignNodeSaveData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CampaignNodeSaveData>.NativeClassPtr);
    CampaignNodeSaveData.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNodeSaveData>.NativeClassPtr, nameof (name));
    CampaignNodeSaveData.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNodeSaveData>.NativeClassPtr, nameof (id));
    CampaignNodeSaveData.NativeFieldInfoPtr_typeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNodeSaveData>.NativeClassPtr, nameof (typeName));
    CampaignNodeSaveData.NativeFieldInfoPtr_seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNodeSaveData>.NativeClassPtr, nameof (seed));
    CampaignNodeSaveData.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNodeSaveData>.NativeClassPtr, nameof (position));
    CampaignNodeSaveData.NativeFieldInfoPtr_tier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNodeSaveData>.NativeClassPtr, nameof (tier));
    CampaignNodeSaveData.NativeFieldInfoPtr_positionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNodeSaveData>.NativeClassPtr, nameof (positionIndex));
    CampaignNodeSaveData.NativeFieldInfoPtr_areaIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNodeSaveData>.NativeClassPtr, nameof (areaIndex));
    CampaignNodeSaveData.NativeFieldInfoPtr_connections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNodeSaveData>.NativeClassPtr, nameof (connections));
    CampaignNodeSaveData.NativeFieldInfoPtr_characters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNodeSaveData>.NativeClassPtr, nameof (characters));
    CampaignNodeSaveData.NativeFieldInfoPtr_revealed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNodeSaveData>.NativeClassPtr, nameof (revealed));
    CampaignNodeSaveData.NativeFieldInfoPtr_cleared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNodeSaveData>.NativeClassPtr, nameof (cleared));
    CampaignNodeSaveData.NativeFieldInfoPtr_glow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNodeSaveData>.NativeClassPtr, nameof (glow));
    CampaignNodeSaveData.NativeFieldInfoPtr_finalNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNodeSaveData>.NativeClassPtr, nameof (finalNode));
    CampaignNodeSaveData.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignNodeSaveData>.NativeClassPtr, nameof (data));
    CampaignNodeSaveData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignNodeSaveData>.NativeClassPtr, 100672645);
    CampaignNodeSaveData.NativeMethodInfoPtr__ctor_Public_Void_CampaignNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignNodeSaveData>.NativeClassPtr, 100672646);
    CampaignNodeSaveData.NativeMethodInfoPtr_Load_Public_Virtual_Final_New_CampaignNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignNodeSaveData>.NativeClassPtr, 100672647);
  }

  public CampaignNodeSaveData(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe string name
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeSaveData.NativeFieldInfoPtr_name)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeSaveData.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe int id
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeSaveData.NativeFieldInfoPtr_id));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeSaveData.NativeFieldInfoPtr_id)) = value;
    }
  }

  public unsafe string typeName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeSaveData.NativeFieldInfoPtr_typeName)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeSaveData.NativeFieldInfoPtr_typeName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe int seed
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeSaveData.NativeFieldInfoPtr_seed));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeSaveData.NativeFieldInfoPtr_seed)) = value;
    }
  }

  public unsafe Vector2 position
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeSaveData.NativeFieldInfoPtr_position));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeSaveData.NativeFieldInfoPtr_position)) = value;
    }
  }

  public unsafe int tier
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeSaveData.NativeFieldInfoPtr_tier));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeSaveData.NativeFieldInfoPtr_tier)) = value;
    }
  }

  public unsafe int positionIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeSaveData.NativeFieldInfoPtr_positionIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeSaveData.NativeFieldInfoPtr_positionIndex)) = value;
    }
  }

  public unsafe int areaIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeSaveData.NativeFieldInfoPtr_areaIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeSaveData.NativeFieldInfoPtr_areaIndex)) = value;
    }
  }

  public unsafe List<CampaignNode.Connection> connections
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeSaveData.NativeFieldInfoPtr_connections));
      return pointer == System.IntPtr.Zero ? (List<CampaignNode.Connection>) null : new List<CampaignNode.Connection>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeSaveData.NativeFieldInfoPtr_connections), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<int> characters
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeSaveData.NativeFieldInfoPtr_characters));
      return pointer == System.IntPtr.Zero ? (List<int>) null : new List<int>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeSaveData.NativeFieldInfoPtr_characters), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool revealed
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeSaveData.NativeFieldInfoPtr_revealed));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeSaveData.NativeFieldInfoPtr_revealed)) = value;
    }
  }

  public unsafe bool cleared
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeSaveData.NativeFieldInfoPtr_cleared));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeSaveData.NativeFieldInfoPtr_cleared)) = value;
    }
  }

  public unsafe bool glow
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeSaveData.NativeFieldInfoPtr_glow));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeSaveData.NativeFieldInfoPtr_glow)) = value;
    }
  }

  public unsafe bool finalNode
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeSaveData.NativeFieldInfoPtr_finalNode));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeSaveData.NativeFieldInfoPtr_finalNode)) = value;
    }
  }

  public unsafe Dictionary<string, Il2CppSystem.Object> data
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeSaveData.NativeFieldInfoPtr_data));
      return pointer == System.IntPtr.Zero ? (Dictionary<string, Il2CppSystem.Object>) null : new Dictionary<string, Il2CppSystem.Object>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignNodeSaveData.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
