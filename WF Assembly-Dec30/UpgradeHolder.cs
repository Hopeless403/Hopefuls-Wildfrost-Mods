// Decompiled with JetBrains decompiler
// Type: UpgradeHolder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.AddressableAssets;

#nullable disable
public class UpgradeHolder : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_prefabRef;
  private static readonly System.IntPtr NativeFieldInfoPtr_dragHandler;
  private static readonly System.IntPtr NativeFieldInfoPtr_list;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetPositions_Public_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Virtual_New_UpgradeDisplay_CardUpgradeData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Virtual_New_Void_UpgradeDisplay_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Insert_Public_Virtual_New_Void_Int32_UpgradeDisplay_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_UpgradeDisplay_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_CardUpgradeData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IndexOf_Public_Virtual_New_Int32_UpgradeDisplay_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44243, XrefRangeEnd = 44268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void SetPositions()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UpgradeHolder.NativeMethodInfoPtr_SetPositions_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44268, XrefRangeEnd = 44306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe UpgradeDisplay Create(CardUpgradeData upgradeData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) upgradeData)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UpgradeHolder.NativeMethodInfoPtr_Create_Public_Virtual_New_UpgradeDisplay_CardUpgradeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (UpgradeDisplay) null : new UpgradeDisplay(pointer);
  }

  [CallerCount(0)]
  public virtual unsafe void Add(UpgradeDisplay upgrade)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) upgrade)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UpgradeHolder.NativeMethodInfoPtr_Add_Public_Virtual_New_Void_UpgradeDisplay_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44306, XrefRangeEnd = 44320, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Insert(int index, UpgradeDisplay upgrade)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &index;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) upgrade);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UpgradeHolder.NativeMethodInfoPtr_Insert_Public_Virtual_New_Void_Int32_UpgradeDisplay_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44320, XrefRangeEnd = 44326, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Remove(UpgradeDisplay upgrade)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) upgrade)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UpgradeHolder.NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_UpgradeDisplay_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44326, XrefRangeEnd = 44344, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Remove(CardUpgradeData upgradeData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) upgradeData)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UpgradeHolder.NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_CardUpgradeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44344, XrefRangeEnd = 44348, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe int IndexOf(UpgradeDisplay upgrade)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) upgrade)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UpgradeHolder.NativeMethodInfoPtr_IndexOf_Public_Virtual_New_Int32_UpgradeDisplay_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44348, XrefRangeEnd = 44353, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Clear()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UpgradeHolder.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 44365, RefRangeEnd = 44367, XrefRangeStart = 44353, XrefRangeEnd = 44365, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UpgradeHolder()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpgradeHolder>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UpgradeHolder.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static UpgradeHolder()
  {
    Il2CppClassPointerStore<UpgradeHolder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (UpgradeHolder));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpgradeHolder>.NativeClassPtr);
    UpgradeHolder.NativeFieldInfoPtr_prefabRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeHolder>.NativeClassPtr, nameof (prefabRef));
    UpgradeHolder.NativeFieldInfoPtr_dragHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeHolder>.NativeClassPtr, nameof (dragHandler));
    UpgradeHolder.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeHolder>.NativeClassPtr, nameof (list));
    UpgradeHolder.NativeMethodInfoPtr_SetPositions_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeHolder>.NativeClassPtr, 100666604);
    UpgradeHolder.NativeMethodInfoPtr_Create_Public_Virtual_New_UpgradeDisplay_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeHolder>.NativeClassPtr, 100666605);
    UpgradeHolder.NativeMethodInfoPtr_Add_Public_Virtual_New_Void_UpgradeDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeHolder>.NativeClassPtr, 100666606);
    UpgradeHolder.NativeMethodInfoPtr_Insert_Public_Virtual_New_Void_Int32_UpgradeDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeHolder>.NativeClassPtr, 100666607);
    UpgradeHolder.NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_UpgradeDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeHolder>.NativeClassPtr, 100666608);
    UpgradeHolder.NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeHolder>.NativeClassPtr, 100666609);
    UpgradeHolder.NativeMethodInfoPtr_IndexOf_Public_Virtual_New_Int32_UpgradeDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeHolder>.NativeClassPtr, 100666610);
    UpgradeHolder.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeHolder>.NativeClassPtr, 100666611);
    UpgradeHolder.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeHolder>.NativeClassPtr, 100666612);
  }

  public UpgradeHolder(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe AssetReference prefabRef
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpgradeHolder.NativeFieldInfoPtr_prefabRef));
      return pointer == System.IntPtr.Zero ? (AssetReference) null : new AssetReference(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UpgradeHolder.NativeFieldInfoPtr_prefabRef), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CardCharmDragHandler dragHandler
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpgradeHolder.NativeFieldInfoPtr_dragHandler));
      return pointer == System.IntPtr.Zero ? (CardCharmDragHandler) null : new CardCharmDragHandler(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UpgradeHolder.NativeFieldInfoPtr_dragHandler), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<UpgradeDisplay> list
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpgradeHolder.NativeFieldInfoPtr_list));
      return pointer == System.IntPtr.Zero ? (List<UpgradeDisplay>) null : new List<UpgradeDisplay>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UpgradeHolder.NativeFieldInfoPtr_list), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("UpgradeHolder/<>c__DisplayClass8_0")]
  public sealed class __c__DisplayClass8_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_upgradeData;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Remove_b__0_Internal_Boolean_UpgradeDisplay_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass8_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpgradeHolder.__c__DisplayClass8_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpgradeHolder.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44134, XrefRangeEnd = 44243, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _Remove_b__0(UpgradeDisplay a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpgradeHolder.__c__DisplayClass8_0.NativeMethodInfoPtr__Remove_b__0_Internal_Boolean_UpgradeDisplay_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass8_0()
    {
      Il2CppClassPointerStore<UpgradeHolder.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpgradeHolder>.NativeClassPtr, "<>c__DisplayClass8_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpgradeHolder.__c__DisplayClass8_0>.NativeClassPtr);
      UpgradeHolder.__c__DisplayClass8_0.NativeFieldInfoPtr_upgradeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeHolder.__c__DisplayClass8_0>.NativeClassPtr, nameof (upgradeData));
      UpgradeHolder.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeHolder.__c__DisplayClass8_0>.NativeClassPtr, 100666613);
      UpgradeHolder.__c__DisplayClass8_0.NativeMethodInfoPtr__Remove_b__0_Internal_Boolean_UpgradeDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeHolder.__c__DisplayClass8_0>.NativeClassPtr, 100666614);
    }

    public __c__DisplayClass8_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CardUpgradeData upgradeData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpgradeHolder.__c__DisplayClass8_0.NativeFieldInfoPtr_upgradeData));
        return pointer == System.IntPtr.Zero ? (CardUpgradeData) null : new CardUpgradeData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UpgradeHolder.__c__DisplayClass8_0.NativeFieldInfoPtr_upgradeData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
