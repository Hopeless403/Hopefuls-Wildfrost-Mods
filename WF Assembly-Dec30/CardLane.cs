// Decompiled with JetBrains decompiler
// Type: CardLane
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
public class CardLane : CardContainer
{
  private static readonly IntPtr NativeFieldInfoPtr_dir;
  private static readonly IntPtr NativeMethodInfoPtr_SetSize_Public_Virtual_Void_Int32_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetChildPosition_Public_Virtual_Vector3_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetDirection_Public_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32399, XrefRangeEnd = 32401, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void SetSize(int size, float cardScale)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &size;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &cardScale;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardLane.NativeMethodInfoPtr_SetSize_Public_Virtual_Void_Int32_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32401, XrefRangeEnd = 32402, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Vector3 GetChildPosition(Entity child)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) child)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardLane.NativeMethodInfoPtr_GetChildPosition_Public_Virtual_Vector3_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public unsafe void SetDirection(int dir)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &dir
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardLane.NativeMethodInfoPtr_SetDirection_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32402, XrefRangeEnd = 32403, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardLane()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardLane>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardLane.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CardLane()
  {
    Il2CppClassPointerStore<CardLane>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CardLane));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardLane>.NativeClassPtr);
    CardLane.NativeFieldInfoPtr_dir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardLane>.NativeClassPtr, nameof (dir));
    CardLane.NativeMethodInfoPtr_SetSize_Public_Virtual_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardLane>.NativeClassPtr, 100665287);
    CardLane.NativeMethodInfoPtr_GetChildPosition_Public_Virtual_Vector3_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardLane>.NativeClassPtr, 100665288);
    CardLane.NativeMethodInfoPtr_SetDirection_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardLane>.NativeClassPtr, 100665289);
    CardLane.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardLane>.NativeClassPtr, 100665290);
  }

  public CardLane(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe int dir
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardLane.NativeFieldInfoPtr_dir));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardLane.NativeFieldInfoPtr_dir)) = value;
    }
  }
}
