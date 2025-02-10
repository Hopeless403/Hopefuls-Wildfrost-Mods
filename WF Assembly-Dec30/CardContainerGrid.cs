// Decompiled with JetBrains decompiler
// Type: CardContainerGrid
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class CardContainerGrid : CardContainer
{
  private static readonly System.IntPtr NativeFieldInfoPtr_fixedWidth;
  private static readonly System.IntPtr NativeFieldInfoPtr_minHeight;
  private static readonly System.IntPtr NativeFieldInfoPtr_cellSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_spacing;
  private static readonly System.IntPtr NativeFieldInfoPtr_columnCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_align;
  private static readonly System.IntPtr NativeFieldInfoPtr_sort;
  private static readonly System.IntPtr NativeFieldInfoPtr_randomOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_randomRotation;
  private static readonly System.IntPtr NativeMethodInfoPtr_DestroyAll_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CardAdded_Protected_Virtual_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CardRemoved_Protected_Virtual_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CardScale_Public_Virtual_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetChildPosition_Public_Virtual_Vector3_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RowCount_Private_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetChildRotation_Public_Virtual_Vector3_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetSize_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Sort_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetColumnCount_Private_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetRowCount_Private_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 32199, RefRangeEnd = 32200, XrefRangeStart = 32179, XrefRangeEnd = 32199, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public new unsafe void DestroyAll()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardContainerGrid.NativeMethodInfoPtr_DestroyAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32200, XrefRangeEnd = 32202, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void CardAdded(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardContainerGrid.NativeMethodInfoPtr_CardAdded_Protected_Virtual_Void_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void CardRemoved(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardContainerGrid.NativeMethodInfoPtr_CardRemoved_Protected_Virtual_Void_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  public override unsafe float CardScale
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardContainerGrid.NativeMethodInfoPtr_get_CardScale_Public_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32202, XrefRangeEnd = 32210, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Vector3 GetChildPosition(Entity child)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) child)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardContainerGrid.NativeMethodInfoPtr_GetChildPosition_Public_Virtual_Vector3_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public unsafe int RowCount(int rowIndex)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &rowIndex
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardContainerGrid.NativeMethodInfoPtr_RowCount_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public override unsafe Vector3 GetChildRotation(Entity child)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) child)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardContainerGrid.NativeMethodInfoPtr_GetChildRotation_Public_Virtual_Vector3_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 32223, RefRangeEnd = 32225, XrefRangeStart = 32210, XrefRangeEnd = 32223, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetSize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardContainerGrid.NativeMethodInfoPtr_SetSize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 32243, RefRangeEnd = 32245, XrefRangeStart = 32225, XrefRangeEnd = 32243, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Sort()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardContainerGrid.NativeMethodInfoPtr_Sort_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe int GetColumnCount()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardContainerGrid.NativeMethodInfoPtr_GetColumnCount_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32245, XrefRangeEnd = 32249, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int GetRowCount()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardContainerGrid.NativeMethodInfoPtr_GetRowCount_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32249, XrefRangeEnd = 32250, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardContainerGrid()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardContainerGrid>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardContainerGrid.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CardContainerGrid()
  {
    Il2CppClassPointerStore<CardContainerGrid>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CardContainerGrid));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardContainerGrid>.NativeClassPtr);
    CardContainerGrid.NativeFieldInfoPtr_fixedWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardContainerGrid>.NativeClassPtr, nameof (fixedWidth));
    CardContainerGrid.NativeFieldInfoPtr_minHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardContainerGrid>.NativeClassPtr, nameof (minHeight));
    CardContainerGrid.NativeFieldInfoPtr_cellSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardContainerGrid>.NativeClassPtr, nameof (cellSize));
    CardContainerGrid.NativeFieldInfoPtr_spacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardContainerGrid>.NativeClassPtr, nameof (spacing));
    CardContainerGrid.NativeFieldInfoPtr_columnCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardContainerGrid>.NativeClassPtr, nameof (columnCount));
    CardContainerGrid.NativeFieldInfoPtr_align = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardContainerGrid>.NativeClassPtr, nameof (align));
    CardContainerGrid.NativeFieldInfoPtr_sort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardContainerGrid>.NativeClassPtr, nameof (sort));
    CardContainerGrid.NativeFieldInfoPtr_randomOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardContainerGrid>.NativeClassPtr, nameof (randomOffset));
    CardContainerGrid.NativeFieldInfoPtr_randomRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardContainerGrid>.NativeClassPtr, nameof (randomRotation));
    CardContainerGrid.NativeMethodInfoPtr_DestroyAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardContainerGrid>.NativeClassPtr, 100665252);
    CardContainerGrid.NativeMethodInfoPtr_CardAdded_Protected_Virtual_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardContainerGrid>.NativeClassPtr, 100665253);
    CardContainerGrid.NativeMethodInfoPtr_CardRemoved_Protected_Virtual_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardContainerGrid>.NativeClassPtr, 100665254);
    CardContainerGrid.NativeMethodInfoPtr_get_CardScale_Public_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardContainerGrid>.NativeClassPtr, 100665255);
    CardContainerGrid.NativeMethodInfoPtr_GetChildPosition_Public_Virtual_Vector3_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardContainerGrid>.NativeClassPtr, 100665256);
    CardContainerGrid.NativeMethodInfoPtr_RowCount_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardContainerGrid>.NativeClassPtr, 100665257);
    CardContainerGrid.NativeMethodInfoPtr_GetChildRotation_Public_Virtual_Vector3_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardContainerGrid>.NativeClassPtr, 100665258);
    CardContainerGrid.NativeMethodInfoPtr_SetSize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardContainerGrid>.NativeClassPtr, 100665259);
    CardContainerGrid.NativeMethodInfoPtr_Sort_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardContainerGrid>.NativeClassPtr, 100665260);
    CardContainerGrid.NativeMethodInfoPtr_GetColumnCount_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardContainerGrid>.NativeClassPtr, 100665261);
    CardContainerGrid.NativeMethodInfoPtr_GetRowCount_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardContainerGrid>.NativeClassPtr, 100665262);
    CardContainerGrid.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardContainerGrid>.NativeClassPtr, 100665263);
  }

  public CardContainerGrid(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool fixedWidth
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardContainerGrid.NativeFieldInfoPtr_fixedWidth));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardContainerGrid.NativeFieldInfoPtr_fixedWidth)) = value;
    }
  }

  public unsafe float minHeight
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardContainerGrid.NativeFieldInfoPtr_minHeight));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardContainerGrid.NativeFieldInfoPtr_minHeight)) = value;
    }
  }

  public unsafe Vector2 cellSize
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardContainerGrid.NativeFieldInfoPtr_cellSize));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardContainerGrid.NativeFieldInfoPtr_cellSize)) = value;
    }
  }

  public unsafe Vector2 spacing
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardContainerGrid.NativeFieldInfoPtr_spacing));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardContainerGrid.NativeFieldInfoPtr_spacing)) = value;
    }
  }

  public unsafe int columnCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardContainerGrid.NativeFieldInfoPtr_columnCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardContainerGrid.NativeFieldInfoPtr_columnCount)) = value;
    }
  }

  public unsafe TextAlignment align
  {
    get
    {
      return *(TextAlignment*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardContainerGrid.NativeFieldInfoPtr_align));
    }
    [param: In] set
    {
      *(TextAlignment*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardContainerGrid.NativeFieldInfoPtr_align)) = value;
    }
  }

  public unsafe bool sort
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardContainerGrid.NativeFieldInfoPtr_sort));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardContainerGrid.NativeFieldInfoPtr_sort)) = value;
    }
  }

  public unsafe Vector3 randomOffset
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardContainerGrid.NativeFieldInfoPtr_randomOffset));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardContainerGrid.NativeFieldInfoPtr_randomOffset)) = value;
    }
  }

  public unsafe Vector3 randomRotation
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardContainerGrid.NativeFieldInfoPtr_randomRotation));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardContainerGrid.NativeFieldInfoPtr_randomRotation)) = value;
    }
  }

  [ObfuscatedName("CardContainerGrid/<>c")]
  [Serializable]
  public new sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__18_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Sort_b__18_0_Internal_Int32_Entity_Entity_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardContainerGrid.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardContainerGrid.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32177, XrefRangeEnd = 32179, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int _Sort_b__18_0(Entity a, Entity b)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) b);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardContainerGrid.__c.NativeMethodInfoPtr__Sort_b__18_0_Internal_Int32_Entity_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<CardContainerGrid.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CardContainerGrid>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardContainerGrid.__c>.NativeClassPtr);
      CardContainerGrid.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardContainerGrid.__c>.NativeClassPtr, "<>9");
      CardContainerGrid.__c.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardContainerGrid.__c>.NativeClassPtr, "<>9__18_0");
      CardContainerGrid.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardContainerGrid.__c>.NativeClassPtr, 100665265);
      CardContainerGrid.__c.NativeMethodInfoPtr__Sort_b__18_0_Internal_Int32_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardContainerGrid.__c>.NativeClassPtr, 100665266);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe CardContainerGrid.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CardContainerGrid.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (CardContainerGrid.__c) null : new CardContainerGrid.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CardContainerGrid.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Comparison<Entity> __9__18_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CardContainerGrid.__c.NativeFieldInfoPtr___9__18_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Comparison<Entity>) null : new Il2CppSystem.Comparison<Entity>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CardContainerGrid.__c.NativeFieldInfoPtr___9__18_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
