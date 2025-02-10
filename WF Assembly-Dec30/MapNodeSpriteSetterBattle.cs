// Decompiled with JetBrains decompiler
// Type: MapNodeSpriteSetterBattle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Localization.Components;

#nullable disable
public class MapNodeSpriteSetterBattle : MapNodeSpriteSetter
{
  private static readonly IntPtr NativeFieldInfoPtr_base;
  private static readonly IntPtr NativeFieldInfoPtr_icon;
  private static readonly IntPtr NativeFieldInfoPtr_battleNameString;
  private static readonly IntPtr NativeFieldInfoPtr_iconObj;
  private static readonly IntPtr NativeFieldInfoPtr_flagObj;
  private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Void_MapNode_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52333, XrefRangeEnd = 52367, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Set(MapNode mapNode)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mapNode)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MapNodeSpriteSetterBattle.NativeMethodInfoPtr_Set_Public_Virtual_Void_MapNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MapNodeSpriteSetterBattle()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapNodeSpriteSetterBattle>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MapNodeSpriteSetterBattle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static MapNodeSpriteSetterBattle()
  {
    Il2CppClassPointerStore<MapNodeSpriteSetterBattle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (MapNodeSpriteSetterBattle));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapNodeSpriteSetterBattle>.NativeClassPtr);
    MapNodeSpriteSetterBattle.NativeFieldInfoPtr_base = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNodeSpriteSetterBattle>.NativeClassPtr, nameof (@base));
    MapNodeSpriteSetterBattle.NativeFieldInfoPtr_icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNodeSpriteSetterBattle>.NativeClassPtr, nameof (icon));
    MapNodeSpriteSetterBattle.NativeFieldInfoPtr_battleNameString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNodeSpriteSetterBattle>.NativeClassPtr, nameof (battleNameString));
    MapNodeSpriteSetterBattle.NativeFieldInfoPtr_iconObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNodeSpriteSetterBattle>.NativeClassPtr, nameof (iconObj));
    MapNodeSpriteSetterBattle.NativeFieldInfoPtr_flagObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNodeSpriteSetterBattle>.NativeClassPtr, nameof (flagObj));
    MapNodeSpriteSetterBattle.NativeMethodInfoPtr_Set_Public_Virtual_Void_MapNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapNodeSpriteSetterBattle>.NativeClassPtr, 100667525);
    MapNodeSpriteSetterBattle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapNodeSpriteSetterBattle>.NativeClassPtr, 100667526);
  }

  public MapNodeSpriteSetterBattle(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe SpriteRenderer @base
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapNodeSpriteSetterBattle.NativeFieldInfoPtr_base));
      return pointer == IntPtr.Zero ? (SpriteRenderer) null : new SpriteRenderer(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapNodeSpriteSetterBattle.NativeFieldInfoPtr_base), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SpriteRenderer icon
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapNodeSpriteSetterBattle.NativeFieldInfoPtr_icon));
      return pointer == IntPtr.Zero ? (SpriteRenderer) null : new SpriteRenderer(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapNodeSpriteSetterBattle.NativeFieldInfoPtr_icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizeStringEvent battleNameString
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapNodeSpriteSetterBattle.NativeFieldInfoPtr_battleNameString));
      return pointer == IntPtr.Zero ? (LocalizeStringEvent) null : new LocalizeStringEvent(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapNodeSpriteSetterBattle.NativeFieldInfoPtr_battleNameString), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject iconObj
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapNodeSpriteSetterBattle.NativeFieldInfoPtr_iconObj));
      return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapNodeSpriteSetterBattle.NativeFieldInfoPtr_iconObj), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject flagObj
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapNodeSpriteSetterBattle.NativeFieldInfoPtr_flagObj));
      return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapNodeSpriteSetterBattle.NativeFieldInfoPtr_flagObj), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
