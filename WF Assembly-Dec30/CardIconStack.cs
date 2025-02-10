// Decompiled with JetBrains decompiler
// Type: CardIconStack
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
public class CardIconStack : CardContainer
{
  private static readonly IntPtr NativeFieldInfoPtr_activeIcons;
  private static readonly IntPtr NativeFieldInfoPtr_iconPool;
  private static readonly IntPtr NativeFieldInfoPtr_iconCount;
  private static readonly IntPtr NativeFieldInfoPtr_randomAngleAmount;
  private static readonly IntPtr NativeFieldInfoPtr_insertAtBottom;
  private static readonly IntPtr NativeFieldInfoPtr_iconPrefab;
  private static readonly IntPtr NativeMethodInfoPtr_SetSize_Public_Virtual_Void_Int32_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetChildPosition_Public_Virtual_Vector3_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Void_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetChildRotation_Public_Virtual_Vector3_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_CardAdded_Protected_Virtual_Void_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_CardRemoved_Protected_Virtual_Void_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_AddIcon_Private_Void_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_RemoveIcon_Private_Void_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_UpdateIconPositions_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_PoolIcon_Private_Void_RectTransform_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetIcon_Private_RectTransform_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32287, XrefRangeEnd = 32293, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void SetSize(int size, float cardScale)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &size;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &cardScale;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardIconStack.NativeMethodInfoPtr_SetSize_Public_Virtual_Void_Int32_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public override unsafe Vector3 GetChildPosition(Entity child)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) child)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardIconStack.NativeMethodInfoPtr_GetChildPosition_Public_Virtual_Vector3_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32293, XrefRangeEnd = 32296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Add(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardIconStack.NativeMethodInfoPtr_Add_Public_Virtual_Void_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Vector3 GetChildRotation(Entity child)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) child)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardIconStack.NativeMethodInfoPtr_GetChildRotation_Public_Virtual_Vector3_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32296, XrefRangeEnd = 32304, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void CardAdded(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardIconStack.NativeMethodInfoPtr_CardAdded_Protected_Virtual_Void_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32304, XrefRangeEnd = 32319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void CardRemoved(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardIconStack.NativeMethodInfoPtr_CardRemoved_Protected_Virtual_Void_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 32349, RefRangeEnd = 32350, XrefRangeStart = 32319, XrefRangeEnd = 32349, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddIcon(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardIconStack.NativeMethodInfoPtr_AddIcon_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveIcon(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardIconStack.NativeMethodInfoPtr_RemoveIcon_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32350, XrefRangeEnd = 32356, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateIconPositions()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardIconStack.NativeMethodInfoPtr_UpdateIconPositions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32356, XrefRangeEnd = 32362, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PoolIcon(RectTransform icon)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) icon)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardIconStack.NativeMethodInfoPtr_PoolIcon_Private_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32362, XrefRangeEnd = 32383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RectTransform GetIcon()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardIconStack.NativeMethodInfoPtr_GetIcon_Private_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    IntPtr pointer = num;
    return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32383, XrefRangeEnd = 32399, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardIconStack()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardIconStack>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardIconStack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CardIconStack()
  {
    Il2CppClassPointerStore<CardIconStack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CardIconStack));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardIconStack>.NativeClassPtr);
    CardIconStack.NativeFieldInfoPtr_activeIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardIconStack>.NativeClassPtr, nameof (activeIcons));
    CardIconStack.NativeFieldInfoPtr_iconPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardIconStack>.NativeClassPtr, nameof (iconPool));
    CardIconStack.NativeFieldInfoPtr_iconCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardIconStack>.NativeClassPtr, nameof (iconCount));
    CardIconStack.NativeFieldInfoPtr_randomAngleAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardIconStack>.NativeClassPtr, nameof (randomAngleAmount));
    CardIconStack.NativeFieldInfoPtr_insertAtBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardIconStack>.NativeClassPtr, nameof (insertAtBottom));
    CardIconStack.NativeFieldInfoPtr_iconPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardIconStack>.NativeClassPtr, nameof (iconPrefab));
    CardIconStack.NativeMethodInfoPtr_SetSize_Public_Virtual_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardIconStack>.NativeClassPtr, 100665275);
    CardIconStack.NativeMethodInfoPtr_GetChildPosition_Public_Virtual_Vector3_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardIconStack>.NativeClassPtr, 100665276);
    CardIconStack.NativeMethodInfoPtr_Add_Public_Virtual_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardIconStack>.NativeClassPtr, 100665277);
    CardIconStack.NativeMethodInfoPtr_GetChildRotation_Public_Virtual_Vector3_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardIconStack>.NativeClassPtr, 100665278);
    CardIconStack.NativeMethodInfoPtr_CardAdded_Protected_Virtual_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardIconStack>.NativeClassPtr, 100665279);
    CardIconStack.NativeMethodInfoPtr_CardRemoved_Protected_Virtual_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardIconStack>.NativeClassPtr, 100665280);
    CardIconStack.NativeMethodInfoPtr_AddIcon_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardIconStack>.NativeClassPtr, 100665281);
    CardIconStack.NativeMethodInfoPtr_RemoveIcon_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardIconStack>.NativeClassPtr, 100665282);
    CardIconStack.NativeMethodInfoPtr_UpdateIconPositions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardIconStack>.NativeClassPtr, 100665283);
    CardIconStack.NativeMethodInfoPtr_PoolIcon_Private_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardIconStack>.NativeClassPtr, 100665284);
    CardIconStack.NativeMethodInfoPtr_GetIcon_Private_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardIconStack>.NativeClassPtr, 100665285);
    CardIconStack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardIconStack>.NativeClassPtr, 100665286);
  }

  public CardIconStack(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Dictionary<Entity, RectTransform> activeIcons
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardIconStack.NativeFieldInfoPtr_activeIcons));
      return pointer == IntPtr.Zero ? (Dictionary<Entity, RectTransform>) null : new Dictionary<Entity, RectTransform>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardIconStack.NativeFieldInfoPtr_activeIcons), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Queue<RectTransform> iconPool
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardIconStack.NativeFieldInfoPtr_iconPool));
      return pointer == IntPtr.Zero ? (Queue<RectTransform>) null : new Queue<RectTransform>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardIconStack.NativeFieldInfoPtr_iconPool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int iconCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardIconStack.NativeFieldInfoPtr_iconCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardIconStack.NativeFieldInfoPtr_iconCount)) = value;
    }
  }

  public unsafe Vector3 randomAngleAmount
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardIconStack.NativeFieldInfoPtr_randomAngleAmount));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardIconStack.NativeFieldInfoPtr_randomAngleAmount)) = value;
    }
  }

  public unsafe bool insertAtBottom
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardIconStack.NativeFieldInfoPtr_insertAtBottom));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardIconStack.NativeFieldInfoPtr_insertAtBottom)) = value;
    }
  }

  public unsafe RectTransform iconPrefab
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardIconStack.NativeFieldInfoPtr_iconPrefab));
      return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardIconStack.NativeFieldInfoPtr_iconPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
