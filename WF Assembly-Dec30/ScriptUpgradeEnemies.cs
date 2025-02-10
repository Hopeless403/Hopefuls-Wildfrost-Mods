// Decompiled with JetBrains decompiler
// Type: ScriptUpgradeEnemies
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

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
public class ScriptUpgradeEnemies : Script
{
  private static readonly System.IntPtr NativeFieldInfoPtr_illegalCards;
  private static readonly System.IntPtr NativeFieldInfoPtr_upgradePool;
  private static readonly System.IntPtr NativeFieldInfoPtr_tiers;
  private static readonly System.IntPtr NativeMethodInfoPtr_Run_Public_Virtual_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddUpgrades_Private_Void_List_1_CardUpgradeData_Il2CppReferenceArray_1_WaveData_Int32_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryAddUpgrade_Private_Boolean_List_1_CardUpgradeData_WaveData_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryAddUpgrade_Private_Boolean_List_1_CardUpgradeData_WaveData_Int32_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IllegalCard_Private_Boolean_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23426, XrefRangeEnd = 23431, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IEnumerator Run()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ScriptUpgradeEnemies.NativeMethodInfoPtr_Run_Public_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 23433, RefRangeEnd = 23434, XrefRangeStart = 23431, XrefRangeEnd = 23433, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddUpgrades(
    List<CardUpgradeData> currentPool,
    Il2CppReferenceArray<BattleWaveManager.WaveData> waves,
    int upgradeCount,
    bool canUpgradeMiniboss)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) currentPool);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) waves);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &upgradeCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &canUpgradeMiniboss;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScriptUpgradeEnemies.NativeMethodInfoPtr_AddUpgrades_Private_Void_List_1_CardUpgradeData_Il2CppReferenceArray_1_WaveData_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 23474, RefRangeEnd = 23475, XrefRangeStart = 23434, XrefRangeEnd = 23474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool TryAddUpgrade(
    List<CardUpgradeData> currentPool,
    BattleWaveManager.WaveData wave,
    bool canUpgradeMiniboss)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) currentPool);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) wave);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &canUpgradeMiniboss;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScriptUpgradeEnemies.NativeMethodInfoPtr_TryAddUpgrade_Private_Boolean_List_1_CardUpgradeData_WaveData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 23517, RefRangeEnd = 23518, XrefRangeStart = 23475, XrefRangeEnd = 23517, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool TryAddUpgrade(
    List<CardUpgradeData> currentPool,
    BattleWaveManager.WaveData wave,
    int cardIndex,
    bool canUpgradeMiniboss)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) currentPool);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) wave);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &cardIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &canUpgradeMiniboss;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScriptUpgradeEnemies.NativeMethodInfoPtr_TryAddUpgrade_Private_Boolean_List_1_CardUpgradeData_WaveData_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23518, XrefRangeEnd = 23521, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IllegalCard(string cardDataName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(cardDataName)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScriptUpgradeEnemies.NativeMethodInfoPtr_IllegalCard_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23521, XrefRangeEnd = 23535, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ScriptUpgradeEnemies()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptUpgradeEnemies>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScriptUpgradeEnemies.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ScriptUpgradeEnemies()
  {
    Il2CppClassPointerStore<ScriptUpgradeEnemies>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ScriptUpgradeEnemies));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptUpgradeEnemies>.NativeClassPtr);
    ScriptUpgradeEnemies.NativeFieldInfoPtr_illegalCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptUpgradeEnemies>.NativeClassPtr, nameof (illegalCards));
    ScriptUpgradeEnemies.NativeFieldInfoPtr_upgradePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptUpgradeEnemies>.NativeClassPtr, nameof (upgradePool));
    ScriptUpgradeEnemies.NativeFieldInfoPtr_tiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptUpgradeEnemies>.NativeClassPtr, nameof (tiers));
    ScriptUpgradeEnemies.NativeMethodInfoPtr_Run_Public_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptUpgradeEnemies>.NativeClassPtr, 100664137);
    ScriptUpgradeEnemies.NativeMethodInfoPtr_AddUpgrades_Private_Void_List_1_CardUpgradeData_Il2CppReferenceArray_1_WaveData_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptUpgradeEnemies>.NativeClassPtr, 100664138);
    ScriptUpgradeEnemies.NativeMethodInfoPtr_TryAddUpgrade_Private_Boolean_List_1_CardUpgradeData_WaveData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptUpgradeEnemies>.NativeClassPtr, 100664139);
    ScriptUpgradeEnemies.NativeMethodInfoPtr_TryAddUpgrade_Private_Boolean_List_1_CardUpgradeData_WaveData_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptUpgradeEnemies>.NativeClassPtr, 100664140);
    ScriptUpgradeEnemies.NativeMethodInfoPtr_IllegalCard_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptUpgradeEnemies>.NativeClassPtr, 100664141);
    ScriptUpgradeEnemies.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptUpgradeEnemies>.NativeClassPtr, 100664142);
  }

  public ScriptUpgradeEnemies(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppStringArray illegalCards
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptUpgradeEnemies.NativeFieldInfoPtr_illegalCards));
      return pointer == System.IntPtr.Zero ? (Il2CppStringArray) null : new Il2CppStringArray(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScriptUpgradeEnemies.NativeFieldInfoPtr_illegalCards), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<CardUpgradeData> upgradePool
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptUpgradeEnemies.NativeFieldInfoPtr_upgradePool));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CardUpgradeData>) null : new Il2CppReferenceArray<CardUpgradeData>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScriptUpgradeEnemies.NativeFieldInfoPtr_upgradePool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<ScriptUpgradeEnemies.Tier> tiers
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptUpgradeEnemies.NativeFieldInfoPtr_tiers));
      return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<ScriptUpgradeEnemies.Tier>) null : new Il2CppStructArray<ScriptUpgradeEnemies.Tier>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScriptUpgradeEnemies.NativeFieldInfoPtr_tiers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct Tier
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_upgradesRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_canAffectMiniboss;
    [FieldOffset(0)]
    public Vector2Int upgradesRange;
    [FieldOffset(8)]
    public bool canAffectMiniboss;

    static Tier()
    {
      Il2CppClassPointerStore<ScriptUpgradeEnemies.Tier>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptUpgradeEnemies>.NativeClassPtr, nameof (Tier));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptUpgradeEnemies.Tier>.NativeClassPtr);
      ScriptUpgradeEnemies.Tier.NativeFieldInfoPtr_upgradesRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptUpgradeEnemies.Tier>.NativeClassPtr, nameof (upgradesRange));
      ScriptUpgradeEnemies.Tier.NativeFieldInfoPtr_canAffectMiniboss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptUpgradeEnemies.Tier>.NativeClassPtr, nameof (canAffectMiniboss));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptUpgradeEnemies.Tier>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [ObfuscatedName("ScriptUpgradeEnemies/<Run>d__3")]
  public sealed class _Run_d__3 : Il2CppSystem.Object
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
    public unsafe _Run_d__3(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptUpgradeEnemies._Run_d__3>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScriptUpgradeEnemies._Run_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScriptUpgradeEnemies._Run_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23267, XrefRangeEnd = 23296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScriptUpgradeEnemies._Run_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScriptUpgradeEnemies._Run_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23296, XrefRangeEnd = 23302, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScriptUpgradeEnemies._Run_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScriptUpgradeEnemies._Run_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _Run_d__3()
    {
      Il2CppClassPointerStore<ScriptUpgradeEnemies._Run_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptUpgradeEnemies>.NativeClassPtr, "<Run>d__3");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptUpgradeEnemies._Run_d__3>.NativeClassPtr);
      ScriptUpgradeEnemies._Run_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptUpgradeEnemies._Run_d__3>.NativeClassPtr, "<>1__state");
      ScriptUpgradeEnemies._Run_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptUpgradeEnemies._Run_d__3>.NativeClassPtr, "<>2__current");
      ScriptUpgradeEnemies._Run_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptUpgradeEnemies._Run_d__3>.NativeClassPtr, "<>4__this");
      ScriptUpgradeEnemies._Run_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptUpgradeEnemies._Run_d__3>.NativeClassPtr, 100664143);
      ScriptUpgradeEnemies._Run_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptUpgradeEnemies._Run_d__3>.NativeClassPtr, 100664144);
      ScriptUpgradeEnemies._Run_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptUpgradeEnemies._Run_d__3>.NativeClassPtr, 100664145);
      ScriptUpgradeEnemies._Run_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptUpgradeEnemies._Run_d__3>.NativeClassPtr, 100664146);
      ScriptUpgradeEnemies._Run_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptUpgradeEnemies._Run_d__3>.NativeClassPtr, 100664147);
      ScriptUpgradeEnemies._Run_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptUpgradeEnemies._Run_d__3>.NativeClassPtr, 100664148);
    }

    public _Run_d__3(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptUpgradeEnemies._Run_d__3.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptUpgradeEnemies._Run_d__3.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptUpgradeEnemies._Run_d__3.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScriptUpgradeEnemies._Run_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ScriptUpgradeEnemies __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptUpgradeEnemies._Run_d__3.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (ScriptUpgradeEnemies) null : new ScriptUpgradeEnemies(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScriptUpgradeEnemies._Run_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("ScriptUpgradeEnemies/<>c__DisplayClass6_0")]
  public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_wave;
    private static readonly System.IntPtr NativeFieldInfoPtr_cardIndex;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__TryAddUpgrade_b__0_Internal_Boolean_CardUpgradeData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__TryAddUpgrade_b__1_Internal_Boolean_CardUpgradeData_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass6_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptUpgradeEnemies.__c__DisplayClass6_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScriptUpgradeEnemies.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23302, XrefRangeEnd = 23426, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _TryAddUpgrade_b__0(CardUpgradeData a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScriptUpgradeEnemies.__c__DisplayClass6_0.NativeMethodInfoPtr__TryAddUpgrade_b__0_Internal_Boolean_CardUpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _TryAddUpgrade_b__1(CardUpgradeData a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScriptUpgradeEnemies.__c__DisplayClass6_0.NativeMethodInfoPtr__TryAddUpgrade_b__1_Internal_Boolean_CardUpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass6_0()
    {
      Il2CppClassPointerStore<ScriptUpgradeEnemies.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptUpgradeEnemies>.NativeClassPtr, "<>c__DisplayClass6_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptUpgradeEnemies.__c__DisplayClass6_0>.NativeClassPtr);
      ScriptUpgradeEnemies.__c__DisplayClass6_0.NativeFieldInfoPtr_wave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptUpgradeEnemies.__c__DisplayClass6_0>.NativeClassPtr, nameof (wave));
      ScriptUpgradeEnemies.__c__DisplayClass6_0.NativeFieldInfoPtr_cardIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptUpgradeEnemies.__c__DisplayClass6_0>.NativeClassPtr, nameof (cardIndex));
      ScriptUpgradeEnemies.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptUpgradeEnemies.__c__DisplayClass6_0>.NativeClassPtr, 100664149);
      ScriptUpgradeEnemies.__c__DisplayClass6_0.NativeMethodInfoPtr__TryAddUpgrade_b__0_Internal_Boolean_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptUpgradeEnemies.__c__DisplayClass6_0>.NativeClassPtr, 100664150);
      ScriptUpgradeEnemies.__c__DisplayClass6_0.NativeMethodInfoPtr__TryAddUpgrade_b__1_Internal_Boolean_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptUpgradeEnemies.__c__DisplayClass6_0>.NativeClassPtr, 100664151);
    }

    public __c__DisplayClass6_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe BattleWaveManager.WaveData wave
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptUpgradeEnemies.__c__DisplayClass6_0.NativeFieldInfoPtr_wave));
        return pointer == System.IntPtr.Zero ? (BattleWaveManager.WaveData) null : new BattleWaveManager.WaveData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScriptUpgradeEnemies.__c__DisplayClass6_0.NativeFieldInfoPtr_wave), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int cardIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptUpgradeEnemies.__c__DisplayClass6_0.NativeFieldInfoPtr_cardIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptUpgradeEnemies.__c__DisplayClass6_0.NativeFieldInfoPtr_cardIndex)) = value;
      }
    }
  }
}
