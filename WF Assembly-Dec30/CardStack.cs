// Decompiled with JetBrains decompiler
// Type: CardStack
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
public class CardStack : CardContainer
{
  private static readonly IntPtr NativeFieldInfoPtr_randomAngleAmount;
  private static readonly IntPtr NativeFieldInfoPtr_insertAtBottom;
  private static readonly IntPtr NativeFieldInfoPtr_flipOnAdd;
  private static readonly IntPtr NativeMethodInfoPtr_SetSize_Public_Virtual_Void_Int32_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetChildPosition_Public_Virtual_Vector3_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Void_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetChildRotation_Public_Virtual_Vector3_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_CardAdded_Protected_Virtual_Void_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33178, XrefRangeEnd = 33184, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void SetSize(int size, float cardScale)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &size;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &cardScale;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardStack.NativeMethodInfoPtr_SetSize_Public_Virtual_Void_Int32_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardStack.NativeMethodInfoPtr_GetChildPosition_Public_Virtual_Vector3_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33184, XrefRangeEnd = 33187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Add(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardStack.NativeMethodInfoPtr_Add_Public_Virtual_Void_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public override unsafe Vector3 GetChildRotation(Entity child)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) child)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardStack.NativeMethodInfoPtr_GetChildRotation_Public_Virtual_Vector3_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33187, XrefRangeEnd = 33193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void CardAdded(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardStack.NativeMethodInfoPtr_CardAdded_Protected_Virtual_Void_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33193, XrefRangeEnd = 33194, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardStack()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardStack>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardStack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CardStack()
  {
    Il2CppClassPointerStore<CardStack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CardStack));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardStack>.NativeClassPtr);
    CardStack.NativeFieldInfoPtr_randomAngleAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardStack>.NativeClassPtr, nameof (randomAngleAmount));
    CardStack.NativeFieldInfoPtr_insertAtBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardStack>.NativeClassPtr, nameof (insertAtBottom));
    CardStack.NativeFieldInfoPtr_flipOnAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardStack>.NativeClassPtr, nameof (flipOnAdd));
    CardStack.NativeMethodInfoPtr_SetSize_Public_Virtual_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardStack>.NativeClassPtr, 100665371);
    CardStack.NativeMethodInfoPtr_GetChildPosition_Public_Virtual_Vector3_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardStack>.NativeClassPtr, 100665372);
    CardStack.NativeMethodInfoPtr_Add_Public_Virtual_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardStack>.NativeClassPtr, 100665373);
    CardStack.NativeMethodInfoPtr_GetChildRotation_Public_Virtual_Vector3_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardStack>.NativeClassPtr, 100665374);
    CardStack.NativeMethodInfoPtr_CardAdded_Protected_Virtual_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardStack>.NativeClassPtr, 100665375);
    CardStack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardStack>.NativeClassPtr, 100665376);
  }

  public CardStack(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Vector3 randomAngleAmount
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardStack.NativeFieldInfoPtr_randomAngleAmount));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardStack.NativeFieldInfoPtr_randomAngleAmount)) = value;
    }
  }

  public unsafe bool insertAtBottom
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardStack.NativeFieldInfoPtr_insertAtBottom));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardStack.NativeFieldInfoPtr_insertAtBottom)) = value;
    }
  }

  public unsafe bool flipOnAdd
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardStack.NativeFieldInfoPtr_flipOnAdd));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardStack.NativeFieldInfoPtr_flipOnAdd)) = value;
    }
  }
}
