// Decompiled with JetBrains decompiler
// Type: InspectCharmsSystem
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
using UnityEngine.UI;

#nullable disable
public class InspectCharmsSystem : GameSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_inspectSystem;
  private static readonly System.IntPtr NativeFieldInfoPtr_charmPrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_grid;
  private static readonly System.IntPtr NativeFieldInfoPtr_closeInputs;
  private static readonly System.IntPtr NativeFieldInfoPtr_charms;
  private static readonly System.IntPtr NativeFieldInfoPtr_maxCharms;
  private static readonly System.IntPtr NativeFieldInfoPtr_maxColumns;
  private static readonly System.IntPtr NativeFieldInfoPtr_wait;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Show_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Create_Private_Void_Il2CppReferenceArray_1_CardUpgradeData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetGridSize_Private_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryHide_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Hide_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61958, XrefRangeEnd = 61982, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InspectCharmsSystem.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61982, XrefRangeEnd = 62006, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Show()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InspectCharmsSystem.NativeMethodInfoPtr_Show_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 62026, RefRangeEnd = 62027, XrefRangeStart = 62006, XrefRangeEnd = 62026, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Create(Il2CppReferenceArray<CardUpgradeData> cardUpgrades)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cardUpgrades)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InspectCharmsSystem.NativeMethodInfoPtr_Create_Private_Void_Il2CppReferenceArray_1_CardUpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62027, XrefRangeEnd = 62035, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetGridSize(int count)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &count
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InspectCharmsSystem.NativeMethodInfoPtr_SetGridSize_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62035, XrefRangeEnd = 62036, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void TryHide()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InspectCharmsSystem.NativeMethodInfoPtr_TryHide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 62056, RefRangeEnd = 62058, XrefRangeStart = 62036, XrefRangeEnd = 62056, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Hide()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InspectCharmsSystem.NativeMethodInfoPtr_Hide_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62058, XrefRangeEnd = 62093, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe InspectCharmsSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InspectCharmsSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InspectCharmsSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static InspectCharmsSystem()
  {
    Il2CppClassPointerStore<InspectCharmsSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (InspectCharmsSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InspectCharmsSystem>.NativeClassPtr);
    InspectCharmsSystem.NativeFieldInfoPtr_inspectSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectCharmsSystem>.NativeClassPtr, nameof (inspectSystem));
    InspectCharmsSystem.NativeFieldInfoPtr_charmPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectCharmsSystem>.NativeClassPtr, nameof (charmPrefab));
    InspectCharmsSystem.NativeFieldInfoPtr_grid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectCharmsSystem>.NativeClassPtr, nameof (grid));
    InspectCharmsSystem.NativeFieldInfoPtr_closeInputs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectCharmsSystem>.NativeClassPtr, nameof (closeInputs));
    InspectCharmsSystem.NativeFieldInfoPtr_charms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectCharmsSystem>.NativeClassPtr, nameof (charms));
    InspectCharmsSystem.NativeFieldInfoPtr_maxCharms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectCharmsSystem>.NativeClassPtr, nameof (maxCharms));
    InspectCharmsSystem.NativeFieldInfoPtr_maxColumns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectCharmsSystem>.NativeClassPtr, nameof (maxColumns));
    InspectCharmsSystem.NativeFieldInfoPtr_wait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectCharmsSystem>.NativeClassPtr, nameof (wait));
    InspectCharmsSystem.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectCharmsSystem>.NativeClassPtr, 100668341);
    InspectCharmsSystem.NativeMethodInfoPtr_Show_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectCharmsSystem>.NativeClassPtr, 100668342);
    InspectCharmsSystem.NativeMethodInfoPtr_Create_Private_Void_Il2CppReferenceArray_1_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectCharmsSystem>.NativeClassPtr, 100668343);
    InspectCharmsSystem.NativeMethodInfoPtr_SetGridSize_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectCharmsSystem>.NativeClassPtr, 100668344);
    InspectCharmsSystem.NativeMethodInfoPtr_TryHide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectCharmsSystem>.NativeClassPtr, 100668345);
    InspectCharmsSystem.NativeMethodInfoPtr_Hide_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectCharmsSystem>.NativeClassPtr, 100668346);
    InspectCharmsSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectCharmsSystem>.NativeClassPtr, 100668347);
  }

  public InspectCharmsSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe InspectSystem inspectSystem
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectCharmsSystem.NativeFieldInfoPtr_inspectSystem));
      return pointer == System.IntPtr.Zero ? (InspectSystem) null : new InspectSystem(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectCharmsSystem.NativeFieldInfoPtr_inspectSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CardCharm charmPrefab
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectCharmsSystem.NativeFieldInfoPtr_charmPrefab));
      return pointer == System.IntPtr.Zero ? (CardCharm) null : new CardCharm(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectCharmsSystem.NativeFieldInfoPtr_charmPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GridLayoutGroup grid
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectCharmsSystem.NativeFieldInfoPtr_grid));
      return pointer == System.IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectCharmsSystem.NativeFieldInfoPtr_grid), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStringArray closeInputs
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectCharmsSystem.NativeFieldInfoPtr_closeInputs));
      return pointer == System.IntPtr.Zero ? (Il2CppStringArray) null : new Il2CppStringArray(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectCharmsSystem.NativeFieldInfoPtr_closeInputs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<CardCharm> charms
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectCharmsSystem.NativeFieldInfoPtr_charms));
      return pointer == System.IntPtr.Zero ? (List<CardCharm>) null : new List<CardCharm>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectCharmsSystem.NativeFieldInfoPtr_charms), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe int maxCharms
  {
    get
    {
      int maxCharms;
      IL2CPP.il2cpp_field_static_get_value(InspectCharmsSystem.NativeFieldInfoPtr_maxCharms, (void*) &maxCharms);
      return maxCharms;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(InspectCharmsSystem.NativeFieldInfoPtr_maxCharms, (void*) &value);
    }
  }

  public static unsafe int maxColumns
  {
    get
    {
      int maxColumns;
      IL2CPP.il2cpp_field_static_get_value(InspectCharmsSystem.NativeFieldInfoPtr_maxColumns, (void*) &maxColumns);
      return maxColumns;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(InspectCharmsSystem.NativeFieldInfoPtr_maxColumns, (void*) &value);
    }
  }

  public unsafe float wait
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectCharmsSystem.NativeFieldInfoPtr_wait));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectCharmsSystem.NativeFieldInfoPtr_wait)) = value;
    }
  }

  [ObfuscatedName("InspectCharmsSystem/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__8_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__9_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Update_b__8_0_Internal_Boolean_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Show_b__9_0_Internal_Boolean_CardUpgradeData_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InspectCharmsSystem.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InspectCharmsSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61954, XrefRangeEnd = 61958, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _Update_b__8_0(string i)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(i)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InspectCharmsSystem.__c.NativeMethodInfoPtr__Update_b__8_0_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe bool _Show_b__9_0(CardUpgradeData a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InspectCharmsSystem.__c.NativeMethodInfoPtr__Show_b__9_0_Internal_Boolean_CardUpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<InspectCharmsSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InspectCharmsSystem>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InspectCharmsSystem.__c>.NativeClassPtr);
      InspectCharmsSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectCharmsSystem.__c>.NativeClassPtr, "<>9");
      InspectCharmsSystem.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectCharmsSystem.__c>.NativeClassPtr, "<>9__8_0");
      InspectCharmsSystem.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectCharmsSystem.__c>.NativeClassPtr, "<>9__9_0");
      InspectCharmsSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectCharmsSystem.__c>.NativeClassPtr, 100668349);
      InspectCharmsSystem.__c.NativeMethodInfoPtr__Update_b__8_0_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectCharmsSystem.__c>.NativeClassPtr, 100668350);
      InspectCharmsSystem.__c.NativeMethodInfoPtr__Show_b__9_0_Internal_Boolean_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectCharmsSystem.__c>.NativeClassPtr, 100668351);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe InspectCharmsSystem.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(InspectCharmsSystem.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (InspectCharmsSystem.__c) null : new InspectCharmsSystem.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(InspectCharmsSystem.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<string, bool> __9__8_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(InspectCharmsSystem.__c.NativeFieldInfoPtr___9__8_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<string, bool>) null : new Il2CppSystem.Func<string, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(InspectCharmsSystem.__c.NativeFieldInfoPtr___9__8_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CardUpgradeData, bool> __9__9_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(InspectCharmsSystem.__c.NativeFieldInfoPtr___9__9_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardUpgradeData, bool>) null : new Il2CppSystem.Func<CardUpgradeData, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(InspectCharmsSystem.__c.NativeFieldInfoPtr___9__9_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
