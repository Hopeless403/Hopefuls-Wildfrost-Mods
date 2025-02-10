// Decompiled with JetBrains decompiler
// Type: BattleSaveData
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

#nullable disable
[Serializable]
public class BattleSaveData : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_campaignNodeId;
  private static readonly System.IntPtr NativeFieldInfoPtr_turnCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_redrawBellCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_playerRows;
  private static readonly System.IntPtr NativeFieldInfoPtr_enemyRows;
  private static readonly System.IntPtr NativeFieldInfoPtr_playerHand;
  private static readonly System.IntPtr NativeFieldInfoPtr_playerDraw;
  private static readonly System.IntPtr NativeFieldInfoPtr_playerDiscard;
  private static readonly System.IntPtr NativeFieldInfoPtr_playerReserve;
  private static readonly System.IntPtr NativeFieldInfoPtr_enemyReserve;
  private static readonly System.IntPtr NativeFieldInfoPtr_statuses;
  private static readonly System.IntPtr NativeFieldInfoPtr_destroyed;
  private static readonly System.IntPtr NativeFieldInfoPtr_enemyWaves;
  private static readonly System.IntPtr NativeFieldInfoPtr_battleMusicState;
  private static readonly System.IntPtr NativeFieldInfoPtr_storeStatusData;
  private static readonly System.IntPtr NativeFieldInfoPtr_gold;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 103540, RefRangeEnd = 103541, XrefRangeStart = 103531, XrefRangeEnd = 103540, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BattleSaveData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleSaveData>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleSaveData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BattleSaveData()
  {
    Il2CppClassPointerStore<BattleSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (BattleSaveData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleSaveData>.NativeClassPtr);
    BattleSaveData.NativeFieldInfoPtr_campaignNodeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData>.NativeClassPtr, nameof (campaignNodeId));
    BattleSaveData.NativeFieldInfoPtr_turnCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData>.NativeClassPtr, nameof (turnCount));
    BattleSaveData.NativeFieldInfoPtr_redrawBellCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData>.NativeClassPtr, nameof (redrawBellCount));
    BattleSaveData.NativeFieldInfoPtr_playerRows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData>.NativeClassPtr, nameof (playerRows));
    BattleSaveData.NativeFieldInfoPtr_enemyRows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData>.NativeClassPtr, nameof (enemyRows));
    BattleSaveData.NativeFieldInfoPtr_playerHand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData>.NativeClassPtr, nameof (playerHand));
    BattleSaveData.NativeFieldInfoPtr_playerDraw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData>.NativeClassPtr, nameof (playerDraw));
    BattleSaveData.NativeFieldInfoPtr_playerDiscard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData>.NativeClassPtr, nameof (playerDiscard));
    BattleSaveData.NativeFieldInfoPtr_playerReserve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData>.NativeClassPtr, nameof (playerReserve));
    BattleSaveData.NativeFieldInfoPtr_enemyReserve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData>.NativeClassPtr, nameof (enemyReserve));
    BattleSaveData.NativeFieldInfoPtr_statuses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData>.NativeClassPtr, nameof (statuses));
    BattleSaveData.NativeFieldInfoPtr_destroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData>.NativeClassPtr, nameof (destroyed));
    BattleSaveData.NativeFieldInfoPtr_enemyWaves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData>.NativeClassPtr, nameof (enemyWaves));
    BattleSaveData.NativeFieldInfoPtr_battleMusicState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData>.NativeClassPtr, nameof (battleMusicState));
    BattleSaveData.NativeFieldInfoPtr_storeStatusData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData>.NativeClassPtr, nameof (storeStatusData));
    BattleSaveData.NativeFieldInfoPtr_gold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData>.NativeClassPtr, nameof (gold));
    BattleSaveData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveData>.NativeClassPtr, 100672624);
  }

  public BattleSaveData(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe int campaignNodeId
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_campaignNodeId));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_campaignNodeId)) = value;
    }
  }

  public unsafe int turnCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_turnCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_turnCount)) = value;
    }
  }

  public unsafe int redrawBellCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_redrawBellCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_redrawBellCount)) = value;
    }
  }

  public unsafe BattleSaveData.ContainerGroup playerRows
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_playerRows));
      return pointer == System.IntPtr.Zero ? (BattleSaveData.ContainerGroup) null : new BattleSaveData.ContainerGroup(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_playerRows), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe BattleSaveData.ContainerGroup enemyRows
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_enemyRows));
      return pointer == System.IntPtr.Zero ? (BattleSaveData.ContainerGroup) null : new BattleSaveData.ContainerGroup(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_enemyRows), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe BattleSaveData.Container playerHand
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_playerHand));
      return pointer == System.IntPtr.Zero ? (BattleSaveData.Container) null : new BattleSaveData.Container(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_playerHand), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe BattleSaveData.Container playerDraw
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_playerDraw));
      return pointer == System.IntPtr.Zero ? (BattleSaveData.Container) null : new BattleSaveData.Container(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_playerDraw), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe BattleSaveData.Container playerDiscard
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_playerDiscard));
      return pointer == System.IntPtr.Zero ? (BattleSaveData.Container) null : new BattleSaveData.Container(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_playerDiscard), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe BattleSaveData.Container playerReserve
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_playerReserve));
      return pointer == System.IntPtr.Zero ? (BattleSaveData.Container) null : new BattleSaveData.Container(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_playerReserve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe BattleSaveData.Container enemyReserve
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_enemyReserve));
      return pointer == System.IntPtr.Zero ? (BattleSaveData.Container) null : new BattleSaveData.Container(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_enemyReserve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<BattleSaveData.Status> statuses
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_statuses));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<BattleSaveData.Status>) null : new Il2CppReferenceArray<BattleSaveData.Status>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_statuses), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<BattleEntityData> destroyed
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_destroyed));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<BattleEntityData>) null : new Il2CppReferenceArray<BattleEntityData>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_destroyed), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe BattleWaveData enemyWaves
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_enemyWaves));
      return pointer == System.IntPtr.Zero ? (BattleWaveData) null : new BattleWaveData(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_enemyWaves), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe BattleMusicSaveData battleMusicState
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_battleMusicState));
      return pointer == System.IntPtr.Zero ? (BattleMusicSaveData) null : new BattleMusicSaveData(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_battleMusicState), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<string, Il2CppSystem.Object> storeStatusData
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_storeStatusData));
      return pointer == System.IntPtr.Zero ? (Dictionary<string, Il2CppSystem.Object>) null : new Dictionary<string, Il2CppSystem.Object>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_storeStatusData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int gold
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_gold));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_gold)) = value;
    }
  }

  [Serializable]
  public class ContainerGroup : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_containers;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_CardContainer_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ContainerGroup()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleSaveData.ContainerGroup>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleSaveData.ContainerGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 103464, RefRangeEnd = 103466, XrefRangeStart = 103440, XrefRangeEnd = 103464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ContainerGroup(IEnumerable<CardContainer> containers)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleSaveData.ContainerGroup>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) containers)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleSaveData.ContainerGroup.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ContainerGroup()
    {
      Il2CppClassPointerStore<BattleSaveData.ContainerGroup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleSaveData>.NativeClassPtr, nameof (ContainerGroup));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleSaveData.ContainerGroup>.NativeClassPtr);
      BattleSaveData.ContainerGroup.NativeFieldInfoPtr_containers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData.ContainerGroup>.NativeClassPtr, nameof (containers));
      BattleSaveData.ContainerGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveData.ContainerGroup>.NativeClassPtr, 100672625);
      BattleSaveData.ContainerGroup.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveData.ContainerGroup>.NativeClassPtr, 100672626);
    }

    public ContainerGroup(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppReferenceArray<BattleSaveData.Container> containers
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveData.ContainerGroup.NativeFieldInfoPtr_containers));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<BattleSaveData.Container>) null : new Il2CppReferenceArray<BattleSaveData.Container>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveData.ContainerGroup.NativeFieldInfoPtr_containers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("BattleSaveData/ContainerGroup/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr___ctor_b__2_0_Internal_Container_CardContainer_0;

      [CallerCount(1959)]
      [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleSaveData.ContainerGroup.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BattleSaveData.ContainerGroup.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103436, XrefRangeEnd = 103440, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe BattleSaveData.Container __ctor_b__2_0(CardContainer a)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
        };
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleSaveData.ContainerGroup.__c.NativeMethodInfoPtr___ctor_b__2_0_Internal_Container_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (BattleSaveData.Container) null : new BattleSaveData.Container(pointer);
      }

      static __c()
      {
        Il2CppClassPointerStore<BattleSaveData.ContainerGroup.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleSaveData.ContainerGroup>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleSaveData.ContainerGroup.__c>.NativeClassPtr);
        BattleSaveData.ContainerGroup.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData.ContainerGroup.__c>.NativeClassPtr, "<>9");
        BattleSaveData.ContainerGroup.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData.ContainerGroup.__c>.NativeClassPtr, "<>9__2_0");
        BattleSaveData.ContainerGroup.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveData.ContainerGroup.__c>.NativeClassPtr, 100672628);
        BattleSaveData.ContainerGroup.__c.NativeMethodInfoPtr___ctor_b__2_0_Internal_Container_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveData.ContainerGroup.__c>.NativeClassPtr, 100672629);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe BattleSaveData.ContainerGroup.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(BattleSaveData.ContainerGroup.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (BattleSaveData.ContainerGroup.__c) null : new BattleSaveData.ContainerGroup.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BattleSaveData.ContainerGroup.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<CardContainer, BattleSaveData.Container> __9__2_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(BattleSaveData.ContainerGroup.__c.NativeFieldInfoPtr___9__2_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardContainer, BattleSaveData.Container>) null : new Il2CppSystem.Func<CardContainer, BattleSaveData.Container>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BattleSaveData.ContainerGroup.__c.NativeFieldInfoPtr___9__2_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }

  [Serializable]
  public class Container : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_cards;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CardContainer_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Container()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleSaveData.Container>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleSaveData.Container.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 103517, RefRangeEnd = 103523, XrefRangeStart = 103474, XrefRangeEnd = 103517, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Container(CardContainer container)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleSaveData.Container>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleSaveData.Container.NativeMethodInfoPtr__ctor_Public_Void_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Container()
    {
      Il2CppClassPointerStore<BattleSaveData.Container>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleSaveData>.NativeClassPtr, nameof (Container));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleSaveData.Container>.NativeClassPtr);
      BattleSaveData.Container.NativeFieldInfoPtr_cards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData.Container>.NativeClassPtr, nameof (cards));
      BattleSaveData.Container.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveData.Container>.NativeClassPtr, 100672630);
      BattleSaveData.Container.NativeMethodInfoPtr__ctor_Public_Void_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveData.Container>.NativeClassPtr, 100672631);
    }

    public Container(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppReferenceArray<BattleEntityData> cards
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveData.Container.NativeFieldInfoPtr_cards));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<BattleEntityData>) null : new Il2CppReferenceArray<BattleEntityData>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveData.Container.NativeFieldInfoPtr_cards), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("BattleSaveData/Container/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__2_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__2_1;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr___ctor_b__2_0_Internal_BattleEntityData_CardSlot_0;
      private static readonly System.IntPtr NativeMethodInfoPtr___ctor_b__2_1_Internal_BattleEntityData_Entity_0;

      [CallerCount(1959)]
      [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleSaveData.Container.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BattleSaveData.Container.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103466, XrefRangeEnd = 103470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe BattleEntityData __ctor_b__2_0(CardSlot a)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
        };
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleSaveData.Container.__c.NativeMethodInfoPtr___ctor_b__2_0_Internal_BattleEntityData_CardSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (BattleEntityData) null : new BattleEntityData(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103470, XrefRangeEnd = 103474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe BattleEntityData __ctor_b__2_1(Entity a)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
        };
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleSaveData.Container.__c.NativeMethodInfoPtr___ctor_b__2_1_Internal_BattleEntityData_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (BattleEntityData) null : new BattleEntityData(pointer);
      }

      static __c()
      {
        Il2CppClassPointerStore<BattleSaveData.Container.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleSaveData.Container>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleSaveData.Container.__c>.NativeClassPtr);
        BattleSaveData.Container.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData.Container.__c>.NativeClassPtr, "<>9");
        BattleSaveData.Container.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData.Container.__c>.NativeClassPtr, "<>9__2_0");
        BattleSaveData.Container.__c.NativeFieldInfoPtr___9__2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData.Container.__c>.NativeClassPtr, "<>9__2_1");
        BattleSaveData.Container.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveData.Container.__c>.NativeClassPtr, 100672633);
        BattleSaveData.Container.__c.NativeMethodInfoPtr___ctor_b__2_0_Internal_BattleEntityData_CardSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveData.Container.__c>.NativeClassPtr, 100672634);
        BattleSaveData.Container.__c.NativeMethodInfoPtr___ctor_b__2_1_Internal_BattleEntityData_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveData.Container.__c>.NativeClassPtr, 100672635);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe BattleSaveData.Container.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(BattleSaveData.Container.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (BattleSaveData.Container.__c) null : new BattleSaveData.Container.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BattleSaveData.Container.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<CardSlot, BattleEntityData> __9__2_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(BattleSaveData.Container.__c.NativeFieldInfoPtr___9__2_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardSlot, BattleEntityData>) null : new Il2CppSystem.Func<CardSlot, BattleEntityData>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BattleSaveData.Container.__c.NativeFieldInfoPtr___9__2_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<Entity, BattleEntityData> __9__2_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(BattleSaveData.Container.__c.NativeFieldInfoPtr___9__2_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Entity, BattleEntityData>) null : new Il2CppSystem.Func<Entity, BattleEntityData>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BattleSaveData.Container.__c.NativeFieldInfoPtr___9__2_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }

  [Serializable]
  public class Status : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_name;
    private static readonly System.IntPtr NativeFieldInfoPtr_count;
    private static readonly System.IntPtr NativeFieldInfoPtr_targetId;
    private static readonly System.IntPtr NativeFieldInfoPtr_hasApplier;
    private static readonly System.IntPtr NativeFieldInfoPtr_applierId;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_StatusEffectData_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Status()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleSaveData.Status>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleSaveData.Status.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 103530, RefRangeEnd = 103531, XrefRangeStart = 103523, XrefRangeEnd = 103530, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Status(StatusEffectData data)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleSaveData.Status>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleSaveData.Status.NativeMethodInfoPtr__ctor_Public_Void_StatusEffectData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Status()
    {
      Il2CppClassPointerStore<BattleSaveData.Status>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleSaveData>.NativeClassPtr, nameof (Status));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleSaveData.Status>.NativeClassPtr);
      BattleSaveData.Status.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData.Status>.NativeClassPtr, nameof (name));
      BattleSaveData.Status.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData.Status>.NativeClassPtr, nameof (count));
      BattleSaveData.Status.NativeFieldInfoPtr_targetId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData.Status>.NativeClassPtr, nameof (targetId));
      BattleSaveData.Status.NativeFieldInfoPtr_hasApplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData.Status>.NativeClassPtr, nameof (hasApplier));
      BattleSaveData.Status.NativeFieldInfoPtr_applierId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData.Status>.NativeClassPtr, nameof (applierId));
      BattleSaveData.Status.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveData.Status>.NativeClassPtr, 100672636);
      BattleSaveData.Status.NativeMethodInfoPtr__ctor_Public_Void_StatusEffectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveData.Status>.NativeClassPtr, 100672637);
    }

    public Status(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveData.Status.NativeFieldInfoPtr_name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveData.Status.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe int count
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveData.Status.NativeFieldInfoPtr_count));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveData.Status.NativeFieldInfoPtr_count)) = value;
      }
    }

    public unsafe ulong targetId
    {
      get
      {
        return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveData.Status.NativeFieldInfoPtr_targetId));
      }
      [param: In] set
      {
        *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveData.Status.NativeFieldInfoPtr_targetId)) = value;
      }
    }

    public unsafe bool hasApplier
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveData.Status.NativeFieldInfoPtr_hasApplier));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveData.Status.NativeFieldInfoPtr_hasApplier)) = value;
      }
    }

    public unsafe ulong applierId
    {
      get
      {
        return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveData.Status.NativeFieldInfoPtr_applierId));
      }
      [param: In] set
      {
        *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleSaveData.Status.NativeFieldInfoPtr_applierId)) = value;
      }
    }
  }
}
