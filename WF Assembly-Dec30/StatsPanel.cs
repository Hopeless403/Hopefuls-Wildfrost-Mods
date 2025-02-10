// Decompiled with JetBrains decompiler
// Type: StatsPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

#nullable disable
public class StatsPanel : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_titleElement;
  private static readonly System.IntPtr NativeFieldInfoPtr_subtitleElement;
  private static readonly System.IntPtr NativeFieldInfoPtr_statsGroup;
  private static readonly System.IntPtr NativeFieldInfoPtr_statPrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_maxStats;
  private static readonly System.IntPtr NativeFieldInfoPtr_stats;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95276, XrefRangeEnd = 95378, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatsPanel.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95378, XrefRangeEnd = 95379, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StatsPanel()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatsPanel>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatsPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static StatsPanel()
  {
    Il2CppClassPointerStore<StatsPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (StatsPanel));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatsPanel>.NativeClassPtr);
    StatsPanel.NativeFieldInfoPtr_titleElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsPanel>.NativeClassPtr, nameof (titleElement));
    StatsPanel.NativeFieldInfoPtr_subtitleElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsPanel>.NativeClassPtr, nameof (subtitleElement));
    StatsPanel.NativeFieldInfoPtr_statsGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsPanel>.NativeClassPtr, nameof (statsGroup));
    StatsPanel.NativeFieldInfoPtr_statPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsPanel>.NativeClassPtr, nameof (statPrefab));
    StatsPanel.NativeFieldInfoPtr_maxStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsPanel>.NativeClassPtr, nameof (maxStats));
    StatsPanel.NativeFieldInfoPtr_stats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsPanel>.NativeClassPtr, nameof (stats));
    StatsPanel.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsPanel>.NativeClassPtr, 100671589);
    StatsPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsPanel>.NativeClassPtr, 100671590);
  }

  public StatsPanel(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe TMP_Text titleElement
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsPanel.NativeFieldInfoPtr_titleElement));
      return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatsPanel.NativeFieldInfoPtr_titleElement), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text subtitleElement
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsPanel.NativeFieldInfoPtr_subtitleElement));
      return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatsPanel.NativeFieldInfoPtr_subtitleElement), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform statsGroup
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsPanel.NativeFieldInfoPtr_statsGroup));
      return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatsPanel.NativeFieldInfoPtr_statsGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StatDisplay statPrefab
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsPanel.NativeFieldInfoPtr_statPrefab));
      return pointer == System.IntPtr.Zero ? (StatDisplay) null : new StatDisplay(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatsPanel.NativeFieldInfoPtr_statPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int maxStats
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsPanel.NativeFieldInfoPtr_maxStats));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsPanel.NativeFieldInfoPtr_maxStats)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<GameStatData> stats
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsPanel.NativeFieldInfoPtr_stats));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<GameStatData>) null : new Il2CppReferenceArray<GameStatData>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatsPanel.NativeFieldInfoPtr_stats), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public sealed class Stat : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_statData;
    private static readonly System.IntPtr NativeFieldInfoPtr_value;
    private static readonly System.IntPtr NativeFieldInfoPtr_stringValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_priority;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameStatData_CampaignStats_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95265, XrefRangeEnd = 95270, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Stat(GameStatData statData, CampaignStats runStats)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatsPanel.Stat>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) statData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) runStats);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatsPanel.Stat.NativeMethodInfoPtr__ctor_Public_Void_GameStatData_CampaignStats_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Stat()
    {
      Il2CppClassPointerStore<StatsPanel.Stat>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatsPanel>.NativeClassPtr, nameof (Stat));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatsPanel.Stat>.NativeClassPtr);
      StatsPanel.Stat.NativeFieldInfoPtr_statData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsPanel.Stat>.NativeClassPtr, nameof (statData));
      StatsPanel.Stat.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsPanel.Stat>.NativeClassPtr, nameof (value));
      StatsPanel.Stat.NativeFieldInfoPtr_stringValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsPanel.Stat>.NativeClassPtr, nameof (stringValue));
      StatsPanel.Stat.NativeFieldInfoPtr_priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsPanel.Stat>.NativeClassPtr, nameof (priority));
      StatsPanel.Stat.NativeMethodInfoPtr__ctor_Public_Void_GameStatData_CampaignStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsPanel.Stat>.NativeClassPtr, 100671591);
    }

    public Stat(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Stat()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StatsPanel.Stat>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatsPanel.Stat>.NativeClassPtr, data));
    }

    public unsafe GameStatData statData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsPanel.Stat.NativeFieldInfoPtr_statData));
        return pointer == System.IntPtr.Zero ? (GameStatData) null : new GameStatData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatsPanel.Stat.NativeFieldInfoPtr_statData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float value
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsPanel.Stat.NativeFieldInfoPtr_value));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsPanel.Stat.NativeFieldInfoPtr_value)) = value;
      }
    }

    public unsafe string stringValue
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsPanel.Stat.NativeFieldInfoPtr_stringValue)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatsPanel.Stat.NativeFieldInfoPtr_stringValue), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe float priority
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsPanel.Stat.NativeFieldInfoPtr_priority));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsPanel.Stat.NativeFieldInfoPtr_priority)) = value;
      }
    }
  }

  [ObfuscatedName("StatsPanel/<>c__DisplayClass6_0")]
  public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_runStats;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__0_Internal_Stat_GameStatData_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass6_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatsPanel.__c__DisplayClass6_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatsPanel.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95270, XrefRangeEnd = 95275, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StatsPanel.Stat _Awake_b__0(GameStatData s)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) s)
      };
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(StatsPanel.__c__DisplayClass6_0.NativeMethodInfoPtr__Awake_b__0_Internal_Stat_GameStatData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new StatsPanel.Stat(pointer);
    }

    static __c__DisplayClass6_0()
    {
      Il2CppClassPointerStore<StatsPanel.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatsPanel>.NativeClassPtr, "<>c__DisplayClass6_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatsPanel.__c__DisplayClass6_0>.NativeClassPtr);
      StatsPanel.__c__DisplayClass6_0.NativeFieldInfoPtr_runStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsPanel.__c__DisplayClass6_0>.NativeClassPtr, nameof (runStats));
      StatsPanel.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsPanel.__c__DisplayClass6_0>.NativeClassPtr, 100671592);
      StatsPanel.__c__DisplayClass6_0.NativeMethodInfoPtr__Awake_b__0_Internal_Stat_GameStatData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsPanel.__c__DisplayClass6_0>.NativeClassPtr, 100671593);
    }

    public __c__DisplayClass6_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CampaignStats runStats
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsPanel.__c__DisplayClass6_0.NativeFieldInfoPtr_runStats));
        return pointer == System.IntPtr.Zero ? (CampaignStats) null : new CampaignStats(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatsPanel.__c__DisplayClass6_0.NativeFieldInfoPtr_runStats), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("StatsPanel/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__6_1;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__6_2;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__6_3;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__6_1_Internal_Boolean_Stat_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__6_2_Internal_Single_Stat_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__6_3_Internal_Single_Stat_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatsPanel.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatsPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _Awake_b__6_1(StatsPanel.Stat s)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) s))
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatsPanel.__c.NativeMethodInfoPtr__Awake_b__6_1_Internal_Boolean_Stat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95275, XrefRangeEnd = 95276, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float _Awake_b__6_2(StatsPanel.Stat s)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) s))
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatsPanel.__c.NativeMethodInfoPtr__Awake_b__6_2_Internal_Single_Stat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe float _Awake_b__6_3(StatsPanel.Stat s)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) s))
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatsPanel.__c.NativeMethodInfoPtr__Awake_b__6_3_Internal_Single_Stat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<StatsPanel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatsPanel>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatsPanel.__c>.NativeClassPtr);
      StatsPanel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsPanel.__c>.NativeClassPtr, "<>9");
      StatsPanel.__c.NativeFieldInfoPtr___9__6_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsPanel.__c>.NativeClassPtr, "<>9__6_1");
      StatsPanel.__c.NativeFieldInfoPtr___9__6_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsPanel.__c>.NativeClassPtr, "<>9__6_2");
      StatsPanel.__c.NativeFieldInfoPtr___9__6_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsPanel.__c>.NativeClassPtr, "<>9__6_3");
      StatsPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsPanel.__c>.NativeClassPtr, 100671595);
      StatsPanel.__c.NativeMethodInfoPtr__Awake_b__6_1_Internal_Boolean_Stat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsPanel.__c>.NativeClassPtr, 100671596);
      StatsPanel.__c.NativeMethodInfoPtr__Awake_b__6_2_Internal_Single_Stat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsPanel.__c>.NativeClassPtr, 100671597);
      StatsPanel.__c.NativeMethodInfoPtr__Awake_b__6_3_Internal_Single_Stat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsPanel.__c>.NativeClassPtr, 100671598);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe StatsPanel.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(StatsPanel.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (StatsPanel.__c) null : new StatsPanel.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StatsPanel.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<StatsPanel.Stat, bool> __9__6_1
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(StatsPanel.__c.NativeFieldInfoPtr___9__6_1, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<StatsPanel.Stat, bool>) null : new Il2CppSystem.Func<StatsPanel.Stat, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StatsPanel.__c.NativeFieldInfoPtr___9__6_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<StatsPanel.Stat, float> __9__6_2
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(StatsPanel.__c.NativeFieldInfoPtr___9__6_2, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<StatsPanel.Stat, float>) null : new Il2CppSystem.Func<StatsPanel.Stat, float>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StatsPanel.__c.NativeFieldInfoPtr___9__6_2, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<StatsPanel.Stat, float> __9__6_3
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(StatsPanel.__c.NativeFieldInfoPtr___9__6_3, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<StatsPanel.Stat, float>) null : new Il2CppSystem.Func<StatsPanel.Stat, float>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StatsPanel.__c.NativeFieldInfoPtr___9__6_3, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
