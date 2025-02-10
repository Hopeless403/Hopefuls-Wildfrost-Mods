// Decompiled with JetBrains decompiler
// Type: ItemHolderPetUsed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class ItemHolderPetUsed : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_headImage;
  private static readonly IntPtr NativeFieldInfoPtr_velocityRangeX;
  private static readonly IntPtr NativeFieldInfoPtr_velocityRangeY;
  private static readonly IntPtr NativeFieldInfoPtr_velocityRangeZ;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetUp_Public_Void_Sprite_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51020, XrefRangeEnd = 51028, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ItemHolderPetUsed.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51028, XrefRangeEnd = 51033, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetUp(Sprite headSprite)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) headSprite)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ItemHolderPetUsed.NativeMethodInfoPtr_SetUp_Public_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51033, XrefRangeEnd = 51034, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ItemHolderPetUsed()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemHolderPetUsed>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ItemHolderPetUsed.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ItemHolderPetUsed()
  {
    Il2CppClassPointerStore<ItemHolderPetUsed>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ItemHolderPetUsed));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemHolderPetUsed>.NativeClassPtr);
    ItemHolderPetUsed.NativeFieldInfoPtr_headImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemHolderPetUsed>.NativeClassPtr, nameof (headImage));
    ItemHolderPetUsed.NativeFieldInfoPtr_velocityRangeX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemHolderPetUsed>.NativeClassPtr, nameof (velocityRangeX));
    ItemHolderPetUsed.NativeFieldInfoPtr_velocityRangeY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemHolderPetUsed>.NativeClassPtr, nameof (velocityRangeY));
    ItemHolderPetUsed.NativeFieldInfoPtr_velocityRangeZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemHolderPetUsed>.NativeClassPtr, nameof (velocityRangeZ));
    ItemHolderPetUsed.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemHolderPetUsed>.NativeClassPtr, 100667390);
    ItemHolderPetUsed.NativeMethodInfoPtr_SetUp_Public_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemHolderPetUsed>.NativeClassPtr, 100667391);
    ItemHolderPetUsed.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemHolderPetUsed>.NativeClassPtr, 100667392);
  }

  public ItemHolderPetUsed(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Image headImage
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemHolderPetUsed.NativeFieldInfoPtr_headImage));
      return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemHolderPetUsed.NativeFieldInfoPtr_headImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector2 velocityRangeX
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemHolderPetUsed.NativeFieldInfoPtr_velocityRangeX));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemHolderPetUsed.NativeFieldInfoPtr_velocityRangeX)) = value;
    }
  }

  public unsafe Vector2 velocityRangeY
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemHolderPetUsed.NativeFieldInfoPtr_velocityRangeY));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemHolderPetUsed.NativeFieldInfoPtr_velocityRangeY)) = value;
    }
  }

  public unsafe Vector2 velocityRangeZ
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemHolderPetUsed.NativeFieldInfoPtr_velocityRangeZ));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemHolderPetUsed.NativeFieldInfoPtr_velocityRangeZ)) = value;
    }
  }
}
