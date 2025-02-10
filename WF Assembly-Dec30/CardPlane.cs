// Decompiled with JetBrains decompiler
// Type: CardPlane
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
public class CardPlane : CardContainer
{
  private static readonly IntPtr NativeFieldInfoPtr_positions;
  private static readonly IntPtr NativeMethodInfoPtr_get_CardScale_Public_Virtual_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Void_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Virtual_Void_Int32_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Void_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetChildPosition_Public_Virtual_Vector3_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_StorePosition_Public_Void_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_FreePosition_Public_Void_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public override unsafe float CardScale
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardPlane.NativeMethodInfoPtr_get_CardScale_Public_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32403, XrefRangeEnd = 32409, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Add(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardPlane.NativeMethodInfoPtr_Add_Public_Virtual_Void_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32409, XrefRangeEnd = 32425, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Insert(int index, Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &index;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardPlane.NativeMethodInfoPtr_Insert_Public_Virtual_Void_Int32_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32425, XrefRangeEnd = 32430, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Remove(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardPlane.NativeMethodInfoPtr_Remove_Public_Virtual_Void_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32430, XrefRangeEnd = 32436, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Vector3 GetChildPosition(Entity child)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) child)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardPlane.NativeMethodInfoPtr_GetChildPosition_Public_Virtual_Vector3_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 32441, RefRangeEnd = 32442, XrefRangeStart = 32436, XrefRangeEnd = 32441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StorePosition(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardPlane.NativeMethodInfoPtr_StorePosition_Public_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32442, XrefRangeEnd = 32446, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FreePosition(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardPlane.NativeMethodInfoPtr_FreePosition_Public_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32446, XrefRangeEnd = 32455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardPlane()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardPlane>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardPlane.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CardPlane()
  {
    Il2CppClassPointerStore<CardPlane>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CardPlane));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardPlane>.NativeClassPtr);
    CardPlane.NativeFieldInfoPtr_positions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPlane>.NativeClassPtr, nameof (positions));
    CardPlane.NativeMethodInfoPtr_get_CardScale_Public_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPlane>.NativeClassPtr, 100665291);
    CardPlane.NativeMethodInfoPtr_Add_Public_Virtual_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPlane>.NativeClassPtr, 100665292);
    CardPlane.NativeMethodInfoPtr_Insert_Public_Virtual_Void_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPlane>.NativeClassPtr, 100665293);
    CardPlane.NativeMethodInfoPtr_Remove_Public_Virtual_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPlane>.NativeClassPtr, 100665294);
    CardPlane.NativeMethodInfoPtr_GetChildPosition_Public_Virtual_Vector3_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPlane>.NativeClassPtr, 100665295);
    CardPlane.NativeMethodInfoPtr_StorePosition_Public_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPlane>.NativeClassPtr, 100665296);
    CardPlane.NativeMethodInfoPtr_FreePosition_Public_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPlane>.NativeClassPtr, 100665297);
    CardPlane.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPlane>.NativeClassPtr, 100665298);
  }

  public CardPlane(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Dictionary<Entity, Vector3> positions
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPlane.NativeFieldInfoPtr_positions));
      return pointer == IntPtr.Zero ? (Dictionary<Entity, Vector3>) null : new Dictionary<Entity, Vector3>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardPlane.NativeFieldInfoPtr_positions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
