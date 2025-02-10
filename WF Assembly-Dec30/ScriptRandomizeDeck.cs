// Decompiled with JetBrains decompiler
// Type: ScriptRandomizeDeck
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
public class ScriptRandomizeDeck : Script
{
  private static readonly System.IntPtr NativeFieldInfoPtr_cardsToRemove;
  private static readonly System.IntPtr NativeFieldInfoPtr_cardsToAdd;
  private static readonly System.IntPtr NativeFieldInfoPtr_charmsToAdd;
  private static readonly System.IntPtr NativeFieldInfoPtr_addCharmChance;
  private static readonly System.IntPtr NativeFieldInfoPtr_replaceChance;
  private static readonly System.IntPtr NativeMethodInfoPtr_Run_Public_Virtual_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPools_Private_Static_Void_byref_List_1_CardData_byref_List_1_CardUpgradeData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveCards_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddCards_Private_Void_List_1_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddCard_Private_Void_CardDataList_CardData_List_1_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddCharms_Private_Void_List_1_CardUpgradeData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryAddCharm_Private_Static_Boolean_CardDataList_CardUpgradeData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22942, XrefRangeEnd = 22947, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IEnumerator Run()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ScriptRandomizeDeck.NativeMethodInfoPtr_Run_Public_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 22989, RefRangeEnd = 22990, XrefRangeStart = 22947, XrefRangeEnd = 22989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetPools(out List<CardData> cards, out List<CardUpgradeData> charms)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr zero1 = System.IntPtr.Zero;
    System.IntPtr* numPtr3 = &zero1;
    *numPtr2 = (System.IntPtr) numPtr3;
    System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero2 = System.IntPtr.Zero;
    System.IntPtr* numPtr4 = &zero2;
    *(System.IntPtr*) num = (System.IntPtr) numPtr4;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScriptRandomizeDeck.NativeMethodInfoPtr_GetPools_Private_Static_Void_byref_List_1_CardData_byref_List_1_CardUpgradeData_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    ref List<CardData> local1 = ref cards;
    System.IntPtr pointer1 = zero1;
    List<> list1 = pointer1 == System.IntPtr.Zero ? (List<>) null : new List<>(pointer1);
    local1 = (List<CardData>) list1;
    ref List<CardUpgradeData> local2 = ref charms;
    System.IntPtr pointer2 = zero2;
    List<> list2 = pointer2 == System.IntPtr.Zero ? (List<>) null : new List<>(pointer2);
    local2 = (List<CardUpgradeData>) list2;
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22990, XrefRangeEnd = 22997, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveCards()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScriptRandomizeDeck.NativeMethodInfoPtr_RemoveCards_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22997, XrefRangeEnd = 23019, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddCards(List<CardData> cards)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cards)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScriptRandomizeDeck.NativeMethodInfoPtr_AddCards_Private_Void_List_1_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23019, XrefRangeEnd = 23029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddCard(CardDataList deck, CardData cardDataClone, List<CardData> added)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) deck);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cardDataClone);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) added);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScriptRandomizeDeck.NativeMethodInfoPtr_AddCard_Private_Void_CardDataList_CardData_List_1_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23029, XrefRangeEnd = 23037, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddCharms(List<CardUpgradeData> charms)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) charms)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScriptRandomizeDeck.NativeMethodInfoPtr_AddCharms_Private_Void_List_1_CardUpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 23061, RefRangeEnd = 23063, XrefRangeStart = 23037, XrefRangeEnd = 23061, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryAddCharm(CardDataList deck, CardUpgradeData upgradeData)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) deck);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) upgradeData);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScriptRandomizeDeck.NativeMethodInfoPtr_TryAddCharm_Private_Static_Boolean_CardDataList_CardUpgradeData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23063, XrefRangeEnd = 23064, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ScriptRandomizeDeck()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptRandomizeDeck>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScriptRandomizeDeck.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ScriptRandomizeDeck()
  {
    Il2CppClassPointerStore<ScriptRandomizeDeck>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ScriptRandomizeDeck));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptRandomizeDeck>.NativeClassPtr);
    ScriptRandomizeDeck.NativeFieldInfoPtr_cardsToRemove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptRandomizeDeck>.NativeClassPtr, nameof (cardsToRemove));
    ScriptRandomizeDeck.NativeFieldInfoPtr_cardsToAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptRandomizeDeck>.NativeClassPtr, nameof (cardsToAdd));
    ScriptRandomizeDeck.NativeFieldInfoPtr_charmsToAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptRandomizeDeck>.NativeClassPtr, nameof (charmsToAdd));
    ScriptRandomizeDeck.NativeFieldInfoPtr_addCharmChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptRandomizeDeck>.NativeClassPtr, nameof (addCharmChance));
    ScriptRandomizeDeck.NativeFieldInfoPtr_replaceChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptRandomizeDeck>.NativeClassPtr, nameof (replaceChance));
    ScriptRandomizeDeck.NativeMethodInfoPtr_Run_Public_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRandomizeDeck>.NativeClassPtr, 100664098);
    ScriptRandomizeDeck.NativeMethodInfoPtr_GetPools_Private_Static_Void_byref_List_1_CardData_byref_List_1_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRandomizeDeck>.NativeClassPtr, 100664099);
    ScriptRandomizeDeck.NativeMethodInfoPtr_RemoveCards_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRandomizeDeck>.NativeClassPtr, 100664100);
    ScriptRandomizeDeck.NativeMethodInfoPtr_AddCards_Private_Void_List_1_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRandomizeDeck>.NativeClassPtr, 100664101);
    ScriptRandomizeDeck.NativeMethodInfoPtr_AddCard_Private_Void_CardDataList_CardData_List_1_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRandomizeDeck>.NativeClassPtr, 100664102);
    ScriptRandomizeDeck.NativeMethodInfoPtr_AddCharms_Private_Void_List_1_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRandomizeDeck>.NativeClassPtr, 100664103);
    ScriptRandomizeDeck.NativeMethodInfoPtr_TryAddCharm_Private_Static_Boolean_CardDataList_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRandomizeDeck>.NativeClassPtr, 100664104);
    ScriptRandomizeDeck.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRandomizeDeck>.NativeClassPtr, 100664105);
  }

  public ScriptRandomizeDeck(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Vector2Int cardsToRemove
  {
    get
    {
      return *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptRandomizeDeck.NativeFieldInfoPtr_cardsToRemove));
    }
    [param: In] set
    {
      *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptRandomizeDeck.NativeFieldInfoPtr_cardsToRemove)) = value;
    }
  }

  public unsafe Vector2Int cardsToAdd
  {
    get
    {
      return *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptRandomizeDeck.NativeFieldInfoPtr_cardsToAdd));
    }
    [param: In] set
    {
      *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptRandomizeDeck.NativeFieldInfoPtr_cardsToAdd)) = value;
    }
  }

  public unsafe Vector2Int charmsToAdd
  {
    get
    {
      return *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptRandomizeDeck.NativeFieldInfoPtr_charmsToAdd));
    }
    [param: In] set
    {
      *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptRandomizeDeck.NativeFieldInfoPtr_charmsToAdd)) = value;
    }
  }

  public unsafe float addCharmChance
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptRandomizeDeck.NativeFieldInfoPtr_addCharmChance));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptRandomizeDeck.NativeFieldInfoPtr_addCharmChance)) = value;
    }
  }

  public unsafe float replaceChance
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptRandomizeDeck.NativeFieldInfoPtr_replaceChance));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptRandomizeDeck.NativeFieldInfoPtr_replaceChance)) = value;
    }
  }

  [ObfuscatedName("ScriptRandomizeDeck/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__5_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Run_b__5_0_Internal_Int32_CardData_CardData_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptRandomizeDeck.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScriptRandomizeDeck.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22877, XrefRangeEnd = 22879, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int _Run_b__5_0(CardData a, CardData b)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) b);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScriptRandomizeDeck.__c.NativeMethodInfoPtr__Run_b__5_0_Internal_Int32_CardData_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<ScriptRandomizeDeck.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptRandomizeDeck>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptRandomizeDeck.__c>.NativeClassPtr);
      ScriptRandomizeDeck.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptRandomizeDeck.__c>.NativeClassPtr, "<>9");
      ScriptRandomizeDeck.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptRandomizeDeck.__c>.NativeClassPtr, "<>9__5_0");
      ScriptRandomizeDeck.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRandomizeDeck.__c>.NativeClassPtr, 100664107);
      ScriptRandomizeDeck.__c.NativeMethodInfoPtr__Run_b__5_0_Internal_Int32_CardData_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRandomizeDeck.__c>.NativeClassPtr, 100664108);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe ScriptRandomizeDeck.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ScriptRandomizeDeck.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (ScriptRandomizeDeck.__c) null : new ScriptRandomizeDeck.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ScriptRandomizeDeck.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Comparison<CardData> __9__5_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ScriptRandomizeDeck.__c.NativeFieldInfoPtr___9__5_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Comparison<CardData>) null : new Il2CppSystem.Comparison<CardData>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ScriptRandomizeDeck.__c.NativeFieldInfoPtr___9__5_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("ScriptRandomizeDeck/<Run>d__5")]
  public sealed class _Run_d__5 : Il2CppSystem.Object
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
    public unsafe _Run_d__5(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptRandomizeDeck._Run_d__5>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScriptRandomizeDeck._Run_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScriptRandomizeDeck._Run_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22879, XrefRangeEnd = 22936, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScriptRandomizeDeck._Run_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScriptRandomizeDeck._Run_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22936, XrefRangeEnd = 22942, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScriptRandomizeDeck._Run_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScriptRandomizeDeck._Run_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _Run_d__5()
    {
      Il2CppClassPointerStore<ScriptRandomizeDeck._Run_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptRandomizeDeck>.NativeClassPtr, "<Run>d__5");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptRandomizeDeck._Run_d__5>.NativeClassPtr);
      ScriptRandomizeDeck._Run_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptRandomizeDeck._Run_d__5>.NativeClassPtr, "<>1__state");
      ScriptRandomizeDeck._Run_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptRandomizeDeck._Run_d__5>.NativeClassPtr, "<>2__current");
      ScriptRandomizeDeck._Run_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptRandomizeDeck._Run_d__5>.NativeClassPtr, "<>4__this");
      ScriptRandomizeDeck._Run_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRandomizeDeck._Run_d__5>.NativeClassPtr, 100664109);
      ScriptRandomizeDeck._Run_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRandomizeDeck._Run_d__5>.NativeClassPtr, 100664110);
      ScriptRandomizeDeck._Run_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRandomizeDeck._Run_d__5>.NativeClassPtr, 100664111);
      ScriptRandomizeDeck._Run_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRandomizeDeck._Run_d__5>.NativeClassPtr, 100664112);
      ScriptRandomizeDeck._Run_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRandomizeDeck._Run_d__5>.NativeClassPtr, 100664113);
      ScriptRandomizeDeck._Run_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRandomizeDeck._Run_d__5>.NativeClassPtr, 100664114);
    }

    public _Run_d__5(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptRandomizeDeck._Run_d__5.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptRandomizeDeck._Run_d__5.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptRandomizeDeck._Run_d__5.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScriptRandomizeDeck._Run_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ScriptRandomizeDeck __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptRandomizeDeck._Run_d__5.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (ScriptRandomizeDeck) null : new ScriptRandomizeDeck(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScriptRandomizeDeck._Run_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
