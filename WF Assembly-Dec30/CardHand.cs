// Decompiled with JetBrains decompiler
// Type: CardHand
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
public class CardHand : CardContainer
{
  private static readonly IntPtr NativeFieldInfoPtr_fanCircleRadius;
  private static readonly IntPtr NativeFieldInfoPtr_fanCircleStartPos;
  private static readonly IntPtr NativeFieldInfoPtr_staticAngleAdd;
  private static readonly IntPtr NativeFieldInfoPtr_fanCircleAngleAdd;
  private static readonly IntPtr NativeFieldInfoPtr_fanCircleAngleAddCurve;
  private static readonly IntPtr NativeFieldInfoPtr_dynamicGap;
  private static readonly IntPtr NativeFieldInfoPtr_dynamicGapCurve;
  private static readonly IntPtr NativeMethodInfoPtr_TweenChildPosition_Public_Virtual_Void_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetSize_Public_Virtual_Void_Int32_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetChildPosition_Public_Virtual_Vector3_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetChildRotation_Public_Virtual_Vector3_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetGap_Private_Vector3_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetAngleAdd_Private_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetAngle_Private_Single_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32250, XrefRangeEnd = 32253, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void TweenChildPosition(Entity child)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) child)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardHand.NativeMethodInfoPtr_TweenChildPosition_Public_Virtual_Void_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32253, XrefRangeEnd = 32256, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void SetSize(int size, float cardScale)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &size;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &cardScale;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardHand.NativeMethodInfoPtr_SetSize_Public_Virtual_Void_Int32_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32256, XrefRangeEnd = 32259, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Vector3 GetChildPosition(Entity child)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) child)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardHand.NativeMethodInfoPtr_GetChildPosition_Public_Virtual_Vector3_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32259, XrefRangeEnd = 32260, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Vector3 GetChildRotation(Entity child)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) child)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardHand.NativeMethodInfoPtr_GetChildRotation_Public_Virtual_Vector3_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 32269, RefRangeEnd = 32271, XrefRangeStart = 32260, XrefRangeEnd = 32269, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 GetGap(int cardCount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &cardCount
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardHand.NativeMethodInfoPtr_GetGap_Private_Vector3_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32271, XrefRangeEnd = 32276, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float GetAngleAdd()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardHand.NativeMethodInfoPtr_GetAngleAdd_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 32284, RefRangeEnd = 32286, XrefRangeStart = 32276, XrefRangeEnd = 32284, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float GetAngle(int childIndex)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &childIndex
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardHand.NativeMethodInfoPtr_GetAngle_Private_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32286, XrefRangeEnd = 32287, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardHand()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardHand>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardHand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CardHand()
  {
    Il2CppClassPointerStore<CardHand>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CardHand));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardHand>.NativeClassPtr);
    CardHand.NativeFieldInfoPtr_fanCircleRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardHand>.NativeClassPtr, nameof (fanCircleRadius));
    CardHand.NativeFieldInfoPtr_fanCircleStartPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardHand>.NativeClassPtr, nameof (fanCircleStartPos));
    CardHand.NativeFieldInfoPtr_staticAngleAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardHand>.NativeClassPtr, nameof (staticAngleAdd));
    CardHand.NativeFieldInfoPtr_fanCircleAngleAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardHand>.NativeClassPtr, nameof (fanCircleAngleAdd));
    CardHand.NativeFieldInfoPtr_fanCircleAngleAddCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardHand>.NativeClassPtr, nameof (fanCircleAngleAddCurve));
    CardHand.NativeFieldInfoPtr_dynamicGap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardHand>.NativeClassPtr, nameof (dynamicGap));
    CardHand.NativeFieldInfoPtr_dynamicGapCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardHand>.NativeClassPtr, nameof (dynamicGapCurve));
    CardHand.NativeMethodInfoPtr_TweenChildPosition_Public_Virtual_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardHand>.NativeClassPtr, 100665267);
    CardHand.NativeMethodInfoPtr_SetSize_Public_Virtual_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardHand>.NativeClassPtr, 100665268);
    CardHand.NativeMethodInfoPtr_GetChildPosition_Public_Virtual_Vector3_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardHand>.NativeClassPtr, 100665269);
    CardHand.NativeMethodInfoPtr_GetChildRotation_Public_Virtual_Vector3_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardHand>.NativeClassPtr, 100665270);
    CardHand.NativeMethodInfoPtr_GetGap_Private_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardHand>.NativeClassPtr, 100665271);
    CardHand.NativeMethodInfoPtr_GetAngleAdd_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardHand>.NativeClassPtr, 100665272);
    CardHand.NativeMethodInfoPtr_GetAngle_Private_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardHand>.NativeClassPtr, 100665273);
    CardHand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardHand>.NativeClassPtr, 100665274);
  }

  public CardHand(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe float fanCircleRadius
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardHand.NativeFieldInfoPtr_fanCircleRadius));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardHand.NativeFieldInfoPtr_fanCircleRadius)) = value;
    }
  }

  public unsafe Vector3 fanCircleStartPos
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardHand.NativeFieldInfoPtr_fanCircleStartPos));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardHand.NativeFieldInfoPtr_fanCircleStartPos)) = value;
    }
  }

  public unsafe bool staticAngleAdd
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardHand.NativeFieldInfoPtr_staticAngleAdd));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardHand.NativeFieldInfoPtr_staticAngleAdd)) = value;
    }
  }

  public unsafe float fanCircleAngleAdd
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardHand.NativeFieldInfoPtr_fanCircleAngleAdd));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardHand.NativeFieldInfoPtr_fanCircleAngleAdd)) = value;
    }
  }

  public unsafe AnimationCurve fanCircleAngleAddCurve
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardHand.NativeFieldInfoPtr_fanCircleAngleAddCurve));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardHand.NativeFieldInfoPtr_fanCircleAngleAddCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool dynamicGap
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardHand.NativeFieldInfoPtr_dynamicGap));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardHand.NativeFieldInfoPtr_dynamicGap)) = value;
    }
  }

  public unsafe AnimationCurve dynamicGapCurve
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardHand.NativeFieldInfoPtr_dynamicGapCurve));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardHand.NativeFieldInfoPtr_dynamicGapCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
