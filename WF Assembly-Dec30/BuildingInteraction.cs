// Decompiled with JetBrains decompiler
// Type: BuildingInteraction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
public class BuildingInteraction : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_spritesToOutline;
  private static readonly System.IntPtr NativeFieldInfoPtr__building;
  private static readonly System.IntPtr NativeFieldInfoPtr__outlineMaterial;
  private static readonly System.IntPtr NativeFieldInfoPtr_previous;
  private static readonly System.IntPtr NativeFieldInfoPtr_hover;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_building_Private_get_Building_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_outlineMaterial_Private_get_Material_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Hover_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnHover_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Select_Public_Void_BaseEventData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HoverTween_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnHoverTween_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe Building building
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85228, XrefRangeEnd = 85232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildingInteraction.NativeMethodInfoPtr_get_building_Private_get_Building_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Building) null : new Building(pointer);
    }
  }

  public unsafe Material outlineMaterial
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85232, XrefRangeEnd = 85240, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildingInteraction.NativeMethodInfoPtr_get_outlineMaterial_Private_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Material) null : new Material(pointer);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85240, XrefRangeEnd = 85285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Hover()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BuildingInteraction.NativeMethodInfoPtr_Hover_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85285, XrefRangeEnd = 85348, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnHover()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BuildingInteraction.NativeMethodInfoPtr_UnHover_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85348, XrefRangeEnd = 85372, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Select(BaseEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BuildingInteraction.NativeMethodInfoPtr_Select_Public_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85372, XrefRangeEnd = 85383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void HoverTween()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BuildingInteraction.NativeMethodInfoPtr_HoverTween_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85383, XrefRangeEnd = 85394, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnHoverTween()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BuildingInteraction.NativeMethodInfoPtr_UnHoverTween_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85394, XrefRangeEnd = 85403, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BuildingInteraction()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildingInteraction>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BuildingInteraction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BuildingInteraction()
  {
    Il2CppClassPointerStore<BuildingInteraction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (BuildingInteraction));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildingInteraction>.NativeClassPtr);
    BuildingInteraction.NativeFieldInfoPtr_spritesToOutline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingInteraction>.NativeClassPtr, nameof (spritesToOutline));
    BuildingInteraction.NativeFieldInfoPtr__building = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingInteraction>.NativeClassPtr, nameof (_building));
    BuildingInteraction.NativeFieldInfoPtr__outlineMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingInteraction>.NativeClassPtr, nameof (_outlineMaterial));
    BuildingInteraction.NativeFieldInfoPtr_previous = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingInteraction>.NativeClassPtr, nameof (previous));
    BuildingInteraction.NativeFieldInfoPtr_hover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingInteraction>.NativeClassPtr, nameof (hover));
    BuildingInteraction.NativeMethodInfoPtr_get_building_Private_get_Building_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingInteraction>.NativeClassPtr, 100670420);
    BuildingInteraction.NativeMethodInfoPtr_get_outlineMaterial_Private_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingInteraction>.NativeClassPtr, 100670421);
    BuildingInteraction.NativeMethodInfoPtr_Hover_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingInteraction>.NativeClassPtr, 100670422);
    BuildingInteraction.NativeMethodInfoPtr_UnHover_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingInteraction>.NativeClassPtr, 100670423);
    BuildingInteraction.NativeMethodInfoPtr_Select_Public_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingInteraction>.NativeClassPtr, 100670424);
    BuildingInteraction.NativeMethodInfoPtr_HoverTween_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingInteraction>.NativeClassPtr, 100670425);
    BuildingInteraction.NativeMethodInfoPtr_UnHoverTween_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingInteraction>.NativeClassPtr, 100670426);
    BuildingInteraction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingInteraction>.NativeClassPtr, 100670427);
  }

  public BuildingInteraction(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppReferenceArray<SpriteRenderer> spritesToOutline
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildingInteraction.NativeFieldInfoPtr_spritesToOutline));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpriteRenderer>) null : new Il2CppReferenceArray<SpriteRenderer>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildingInteraction.NativeFieldInfoPtr_spritesToOutline), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Building _building
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildingInteraction.NativeFieldInfoPtr__building));
      return pointer == System.IntPtr.Zero ? (Building) null : new Building(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildingInteraction.NativeFieldInfoPtr__building), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Material _outlineMaterial
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildingInteraction.NativeFieldInfoPtr__outlineMaterial));
      return pointer == System.IntPtr.Zero ? (Material) null : new Material(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildingInteraction.NativeFieldInfoPtr__outlineMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<SpriteRenderer, Material> previous
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildingInteraction.NativeFieldInfoPtr_previous));
      return pointer == System.IntPtr.Zero ? (Dictionary<SpriteRenderer, Material>) null : new Dictionary<SpriteRenderer, Material>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildingInteraction.NativeFieldInfoPtr_previous), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool hover
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildingInteraction.NativeFieldInfoPtr_hover));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildingInteraction.NativeFieldInfoPtr_hover)) = value;
    }
  }

  [ObfuscatedName("BuildingInteraction/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__10_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__UnHover_b__10_0_Internal_Boolean_KeyValuePair_2_SpriteRenderer_Material_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildingInteraction.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildingInteraction.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85223, XrefRangeEnd = 85228, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _UnHover_b__10_0(KeyValuePair<SpriteRenderer, Material> pair)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) pair))
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildingInteraction.__c.NativeMethodInfoPtr__UnHover_b__10_0_Internal_Boolean_KeyValuePair_2_SpriteRenderer_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<BuildingInteraction.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildingInteraction>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildingInteraction.__c>.NativeClassPtr);
      BuildingInteraction.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingInteraction.__c>.NativeClassPtr, "<>9");
      BuildingInteraction.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingInteraction.__c>.NativeClassPtr, "<>9__10_0");
      BuildingInteraction.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingInteraction.__c>.NativeClassPtr, 100670429);
      BuildingInteraction.__c.NativeMethodInfoPtr__UnHover_b__10_0_Internal_Boolean_KeyValuePair_2_SpriteRenderer_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingInteraction.__c>.NativeClassPtr, 100670430);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe BuildingInteraction.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(BuildingInteraction.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (BuildingInteraction.__c) null : new BuildingInteraction.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(BuildingInteraction.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<KeyValuePair<SpriteRenderer, Material>, bool> __9__10_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(BuildingInteraction.__c.NativeFieldInfoPtr___9__10_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<KeyValuePair<SpriteRenderer, Material>, bool>) null : new Il2CppSystem.Func<KeyValuePair<SpriteRenderer, Material>, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(BuildingInteraction.__c.NativeFieldInfoPtr___9__10_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
