// Decompiled with JetBrains decompiler
// Type: MapNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
public class MapNode : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_map;
  private static readonly IntPtr NativeFieldInfoPtr_campaignNode;
  private static readonly IntPtr NativeFieldInfoPtr_connections;
  private static readonly IntPtr NativeFieldInfoPtr_connectedTo;
  private static readonly IntPtr NativeFieldInfoPtr_interactable;
  private static readonly IntPtr NativeFieldInfoPtr_animator;
  private static readonly IntPtr NativeFieldInfoPtr_highlight;
  private static readonly IntPtr NativeFieldInfoPtr_glow;
  private static readonly IntPtr NativeFieldInfoPtr_uINavigationItem;
  private static readonly IntPtr NativeFieldInfoPtr_spriteSetter;
  private static readonly IntPtr NativeFieldInfoPtr_spriteOptions;
  private static readonly IntPtr NativeFieldInfoPtr_clearedSpriteOptions;
  private static readonly IntPtr NativeFieldInfoPtr_spriteIndex;
  private static readonly IntPtr NativeFieldInfoPtr_highlightSfx;
  private static readonly IntPtr NativeFieldInfoPtr_selectable;
  private static readonly IntPtr NativeFieldInfoPtr__hoverable;
  private static readonly IntPtr NativeFieldInfoPtr__pressable;
  private static readonly IntPtr NativeFieldInfoPtr_reachable;
  private static readonly IntPtr NativeFieldInfoPtr_hasSprite;
  private static readonly IntPtr NativeFieldInfoPtr_hover;
  private static readonly IntPtr NativeFieldInfoPtr_press;
  private static readonly IntPtr NativeFieldInfoPtr_scaler;
  private static readonly IntPtr NativeFieldInfoPtr_spriteRenderer;
  private static readonly IntPtr NativeFieldInfoPtr_label;
  private static readonly IntPtr NativeMethodInfoPtr_get_HasSpriteSetter_Private_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_hoverable_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_hoverable_Public_set_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_pressable_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_pressable_Public_set_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_IsHovered_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_color_Public_set_Void_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_Assign_Public_Void_CampaignNode_0;
  private static readonly IntPtr NativeMethodInfoPtr_Refresh_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetSprite_Public_Void_Sprite_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckForFocus_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Reveal_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Hover_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_UnHover_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Press_Public_Void_BaseEventData_0;
  private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_BaseEventData_0;
  private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetSelectable_Public_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe bool HasSpriteSetter
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52038, XrefRangeEnd = 52042, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapNode.NativeMethodInfoPtr_get_HasSpriteSetter_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public unsafe bool hoverable
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapNode.NativeMethodInfoPtr_get_hoverable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 52093, RefRangeEnd = 52094, XrefRangeStart = 52042, XrefRangeEnd = 52093, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapNode.NativeMethodInfoPtr_set_hoverable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe bool pressable
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapNode.NativeMethodInfoPtr_get_pressable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapNode.NativeMethodInfoPtr_set_pressable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe bool IsHovered
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapNode.NativeMethodInfoPtr_get_IsHovered_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public unsafe Color color
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52094, XrefRangeEnd = 52095, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapNode.NativeMethodInfoPtr_set_color_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 52119, RefRangeEnd = 52121, XrefRangeStart = 52095, XrefRangeEnd = 52119, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Assign(CampaignNode node)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MapNode.NativeMethodInfoPtr_Assign_Public_Void_CampaignNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 52130, RefRangeEnd = 52132, XrefRangeStart = 52121, XrefRangeEnd = 52130, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Refresh()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MapNode.NativeMethodInfoPtr_Refresh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52132, XrefRangeEnd = 52134, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetSprite(Sprite sprite)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sprite)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MapNode.NativeMethodInfoPtr_SetSprite_Public_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52134, XrefRangeEnd = 52135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MapNode.NativeMethodInfoPtr_OnEnable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 52153, RefRangeEnd = 52155, XrefRangeStart = 52135, XrefRangeEnd = 52153, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CheckForFocus()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MapNode.NativeMethodInfoPtr_CheckForFocus_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 52205, RefRangeEnd = 52208, XrefRangeStart = 52155, XrefRangeEnd = 52205, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Reveal()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MapNode.NativeMethodInfoPtr_Reveal_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52208, XrefRangeEnd = 52224, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Hover()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MapNode.NativeMethodInfoPtr_Hover_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52224, XrefRangeEnd = 52241, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnHover()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MapNode.NativeMethodInfoPtr_UnHover_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52241, XrefRangeEnd = 52244, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Press(BaseEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MapNode.NativeMethodInfoPtr_Press_Public_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52244, XrefRangeEnd = 52254, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release(BaseEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MapNode.NativeMethodInfoPtr_Release_Public_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52254, XrefRangeEnd = 52265, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Select()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MapNode.NativeMethodInfoPtr_Select_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 52304, RefRangeEnd = 52306, XrefRangeStart = 52265, XrefRangeEnd = 52304, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetSelectable(bool value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MapNode.NativeMethodInfoPtr_SetSelectable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52306, XrefRangeEnd = 52307, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MapNode.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52307, XrefRangeEnd = 52308, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MapNode()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapNode>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MapNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static MapNode()
  {
    Il2CppClassPointerStore<MapNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (MapNode));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapNode>.NativeClassPtr);
    MapNode.NativeFieldInfoPtr_map = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNode>.NativeClassPtr, nameof (map));
    MapNode.NativeFieldInfoPtr_campaignNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNode>.NativeClassPtr, nameof (campaignNode));
    MapNode.NativeFieldInfoPtr_connections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNode>.NativeClassPtr, nameof (connections));
    MapNode.NativeFieldInfoPtr_connectedTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNode>.NativeClassPtr, nameof (connectedTo));
    MapNode.NativeFieldInfoPtr_interactable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNode>.NativeClassPtr, nameof (interactable));
    MapNode.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNode>.NativeClassPtr, nameof (animator));
    MapNode.NativeFieldInfoPtr_highlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNode>.NativeClassPtr, nameof (highlight));
    MapNode.NativeFieldInfoPtr_glow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNode>.NativeClassPtr, nameof (glow));
    MapNode.NativeFieldInfoPtr_uINavigationItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNode>.NativeClassPtr, nameof (uINavigationItem));
    MapNode.NativeFieldInfoPtr_spriteSetter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNode>.NativeClassPtr, nameof (spriteSetter));
    MapNode.NativeFieldInfoPtr_spriteOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNode>.NativeClassPtr, nameof (spriteOptions));
    MapNode.NativeFieldInfoPtr_clearedSpriteOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNode>.NativeClassPtr, nameof (clearedSpriteOptions));
    MapNode.NativeFieldInfoPtr_spriteIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNode>.NativeClassPtr, nameof (spriteIndex));
    MapNode.NativeFieldInfoPtr_highlightSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNode>.NativeClassPtr, nameof (highlightSfx));
    MapNode.NativeFieldInfoPtr_selectable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNode>.NativeClassPtr, nameof (selectable));
    MapNode.NativeFieldInfoPtr__hoverable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNode>.NativeClassPtr, nameof (_hoverable));
    MapNode.NativeFieldInfoPtr__pressable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNode>.NativeClassPtr, nameof (_pressable));
    MapNode.NativeFieldInfoPtr_reachable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNode>.NativeClassPtr, nameof (reachable));
    MapNode.NativeFieldInfoPtr_hasSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNode>.NativeClassPtr, nameof (hasSprite));
    MapNode.NativeFieldInfoPtr_hover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNode>.NativeClassPtr, nameof (hover));
    MapNode.NativeFieldInfoPtr_press = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNode>.NativeClassPtr, nameof (press));
    MapNode.NativeFieldInfoPtr_scaler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNode>.NativeClassPtr, nameof (scaler));
    MapNode.NativeFieldInfoPtr_spriteRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNode>.NativeClassPtr, nameof (spriteRenderer));
    MapNode.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapNode>.NativeClassPtr, nameof (label));
    MapNode.NativeMethodInfoPtr_get_HasSpriteSetter_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapNode>.NativeClassPtr, 100667498);
    MapNode.NativeMethodInfoPtr_get_hoverable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapNode>.NativeClassPtr, 100667499);
    MapNode.NativeMethodInfoPtr_set_hoverable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapNode>.NativeClassPtr, 100667500);
    MapNode.NativeMethodInfoPtr_get_pressable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapNode>.NativeClassPtr, 100667501);
    MapNode.NativeMethodInfoPtr_set_pressable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapNode>.NativeClassPtr, 100667502);
    MapNode.NativeMethodInfoPtr_get_IsHovered_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapNode>.NativeClassPtr, 100667503);
    MapNode.NativeMethodInfoPtr_set_color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapNode>.NativeClassPtr, 100667504);
    MapNode.NativeMethodInfoPtr_Assign_Public_Void_CampaignNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapNode>.NativeClassPtr, 100667505);
    MapNode.NativeMethodInfoPtr_Refresh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapNode>.NativeClassPtr, 100667506);
    MapNode.NativeMethodInfoPtr_SetSprite_Public_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapNode>.NativeClassPtr, 100667507);
    MapNode.NativeMethodInfoPtr_OnEnable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapNode>.NativeClassPtr, 100667508);
    MapNode.NativeMethodInfoPtr_CheckForFocus_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapNode>.NativeClassPtr, 100667509);
    MapNode.NativeMethodInfoPtr_Reveal_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapNode>.NativeClassPtr, 100667510);
    MapNode.NativeMethodInfoPtr_Hover_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapNode>.NativeClassPtr, 100667511);
    MapNode.NativeMethodInfoPtr_UnHover_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapNode>.NativeClassPtr, 100667512);
    MapNode.NativeMethodInfoPtr_Press_Public_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapNode>.NativeClassPtr, 100667513);
    MapNode.NativeMethodInfoPtr_Release_Public_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapNode>.NativeClassPtr, 100667514);
    MapNode.NativeMethodInfoPtr_Select_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapNode>.NativeClassPtr, 100667515);
    MapNode.NativeMethodInfoPtr_SetSelectable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapNode>.NativeClassPtr, 100667516);
    MapNode.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapNode>.NativeClassPtr, 100667517);
    MapNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapNode>.NativeClassPtr, 100667518);
  }

  public MapNode(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe MapNew map
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapNode.NativeFieldInfoPtr_map));
      return pointer == IntPtr.Zero ? (MapNew) null : new MapNew(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapNode.NativeFieldInfoPtr_map), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CampaignNode campaignNode
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapNode.NativeFieldInfoPtr_campaignNode));
      return pointer == IntPtr.Zero ? (CampaignNode) null : new CampaignNode(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapNode.NativeFieldInfoPtr_campaignNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<MapNode> connections
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapNode.NativeFieldInfoPtr_connections));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<MapNode>) null : new Il2CppReferenceArray<MapNode>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapNode.NativeFieldInfoPtr_connections), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int connectedTo
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapNode.NativeFieldInfoPtr_connectedTo));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapNode.NativeFieldInfoPtr_connectedTo)) = value;
    }
  }

  public unsafe bool interactable
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapNode.NativeFieldInfoPtr_interactable));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapNode.NativeFieldInfoPtr_interactable)) = value;
    }
  }

  public unsafe Animator animator
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapNode.NativeFieldInfoPtr_animator));
      return pointer == IntPtr.Zero ? (Animator) null : new Animator(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapNode.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject highlight
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapNode.NativeFieldInfoPtr_highlight));
      return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapNode.NativeFieldInfoPtr_highlight), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject glow
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapNode.NativeFieldInfoPtr_glow));
      return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapNode.NativeFieldInfoPtr_glow), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UINavigationItem uINavigationItem
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapNode.NativeFieldInfoPtr_uINavigationItem));
      return pointer == IntPtr.Zero ? (UINavigationItem) null : new UINavigationItem(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapNode.NativeFieldInfoPtr_uINavigationItem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MapNodeSpriteSetter spriteSetter
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapNode.NativeFieldInfoPtr_spriteSetter));
      return pointer == IntPtr.Zero ? (MapNodeSpriteSetter) null : new MapNodeSpriteSetter(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapNode.NativeFieldInfoPtr_spriteSetter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<Sprite> spriteOptions
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapNode.NativeFieldInfoPtr_spriteOptions));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<Sprite>) null : new Il2CppReferenceArray<Sprite>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapNode.NativeFieldInfoPtr_spriteOptions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<Sprite> clearedSpriteOptions
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapNode.NativeFieldInfoPtr_clearedSpriteOptions));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<Sprite>) null : new Il2CppReferenceArray<Sprite>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapNode.NativeFieldInfoPtr_clearedSpriteOptions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int spriteIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapNode.NativeFieldInfoPtr_spriteIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapNode.NativeFieldInfoPtr_spriteIndex)) = value;
    }
  }

  public unsafe EventReference highlightSfx
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapNode.NativeFieldInfoPtr_highlightSfx));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapNode.NativeFieldInfoPtr_highlightSfx)) = value;
    }
  }

  public unsafe bool selectable
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapNode.NativeFieldInfoPtr_selectable));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapNode.NativeFieldInfoPtr_selectable)) = value;
    }
  }

  public unsafe bool _hoverable
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapNode.NativeFieldInfoPtr__hoverable));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapNode.NativeFieldInfoPtr__hoverable)) = value;
    }
  }

  public unsafe bool _pressable
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapNode.NativeFieldInfoPtr__pressable));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapNode.NativeFieldInfoPtr__pressable)) = value;
    }
  }

  public unsafe bool reachable
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapNode.NativeFieldInfoPtr_reachable));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapNode.NativeFieldInfoPtr_reachable)) = value;
    }
  }

  public unsafe bool hasSprite
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapNode.NativeFieldInfoPtr_hasSprite));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapNode.NativeFieldInfoPtr_hasSprite)) = value;
    }
  }

  public unsafe bool hover
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapNode.NativeFieldInfoPtr_hover));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapNode.NativeFieldInfoPtr_hover)) = value;
    }
  }

  public unsafe bool press
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapNode.NativeFieldInfoPtr_press));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapNode.NativeFieldInfoPtr_press)) = value;
    }
  }

  public unsafe Transform scaler
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapNode.NativeFieldInfoPtr_scaler));
      return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapNode.NativeFieldInfoPtr_scaler), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SpriteRenderer spriteRenderer
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapNode.NativeFieldInfoPtr_spriteRenderer));
      return pointer == IntPtr.Zero ? (SpriteRenderer) null : new SpriteRenderer(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapNode.NativeFieldInfoPtr_spriteRenderer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MapNodeLabel label
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapNode.NativeFieldInfoPtr_label));
      return pointer == IntPtr.Zero ? (MapNodeLabel) null : new MapNodeLabel(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapNode.NativeFieldInfoPtr_label), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
