// Decompiled with JetBrains decompiler
// Type: MapNodeSpriteSetterItem
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
public class MapNodeSpriteSetterItem : MapNodeSpriteSetter
{
  private static readonly IntPtr NativeFieldInfoPtr_normalSprite;
  private static readonly IntPtr NativeFieldInfoPtr_bigSprite;
  private static readonly IntPtr NativeFieldInfoPtr_clearedSprite;
  private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Void_MapNode_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52367, XrefRangeEnd = 52379, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Set(MapNode mapNode)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mapNode)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MapNodeSpriteSetterItem.NativeMethodInfoPtr_Set_Public_Virtual_Void_MapNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MapNodeSpriteSetterItem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapNodeSpriteSetterItem>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MapNodeSpriteSetterItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static MapNodeSpriteSetterItem()
  {
    Il2CppClassPointerStore<MapNodeSpriteSetterItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (MapNodeSpriteSetterItem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapNodeSpriteSetterItem>.NativeClassPtr);
    MapNodeSpriteSetterItem.NativeFieldInfoPtr_normalSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNodeSpriteSetterItem>.NativeClassPtr, nameof (normalSprite));
    MapNodeSpriteSetterItem.NativeFieldInfoPtr_bigSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNodeSpriteSetterItem>.NativeClassPtr, nameof (bigSprite));
    MapNodeSpriteSetterItem.NativeFieldInfoPtr_clearedSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNodeSpriteSetterItem>.NativeClassPtr, nameof (clearedSprite));
    MapNodeSpriteSetterItem.NativeMethodInfoPtr_Set_Public_Virtual_Void_MapNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapNodeSpriteSetterItem>.NativeClassPtr, 100667527);
    MapNodeSpriteSetterItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapNodeSpriteSetterItem>.NativeClassPtr, 100667528);
  }

  public MapNodeSpriteSetterItem(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Sprite normalSprite
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapNodeSpriteSetterItem.NativeFieldInfoPtr_normalSprite));
      return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapNodeSpriteSetterItem.NativeFieldInfoPtr_normalSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite bigSprite
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapNodeSpriteSetterItem.NativeFieldInfoPtr_bigSprite));
      return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapNodeSpriteSetterItem.NativeFieldInfoPtr_bigSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite clearedSprite
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapNodeSpriteSetterItem.NativeFieldInfoPtr_clearedSprite));
      return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapNodeSpriteSetterItem.NativeFieldInfoPtr_clearedSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
