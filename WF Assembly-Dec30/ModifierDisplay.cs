// Decompiled with JetBrains decompiler
// Type: ModifierDisplay
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
public class ModifierDisplay : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_iconPrefab;
  private static readonly IntPtr NativeFieldInfoPtr_stormLevelIconPrefab;
  private static readonly IntPtr NativeFieldInfoPtr_popUpOffset;
  private static readonly IntPtr NativeFieldInfoPtr_icons;
  private static readonly IntPtr NativeFieldInfoPtr__modifierCount_k__BackingField;
  private static readonly IntPtr NativeFieldInfoPtr_stormLevelIcon;
  private static readonly IntPtr NativeMethodInfoPtr_get_modifierCount_Protected_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_modifierCount_Protected_set_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreateIcon_Public_ModifierIcon_GameModifierData_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_ClearIcons_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_AddToStormLevelIcon_Private_ModifierIcon_GameModifierData_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreateStormLevelIcon_Private_ModifierIcon_GameModifierData_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe int modifierCount
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifierDisplay.NativeMethodInfoPtr_get_modifierCount_Protected_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModifierDisplay.NativeMethodInfoPtr_set_modifierCount_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 93037, RefRangeEnd = 93041, XrefRangeStart = 93011, XrefRangeEnd = 93037, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ModifierIcon CreateIcon(GameModifierData data, bool combineStormBells = true)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &combineStormBells;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifierDisplay.NativeMethodInfoPtr_CreateIcon_Public_ModifierIcon_GameModifierData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    IntPtr pointer = num;
    return pointer == IntPtr.Zero ? (ModifierIcon) null : new ModifierIcon(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93041, XrefRangeEnd = 93053, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ClearIcons()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ModifierDisplay.NativeMethodInfoPtr_ClearIcons_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93053, XrefRangeEnd = 93058, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ModifierIcon AddToStormLevelIcon(GameModifierData modifier)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) modifier)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifierDisplay.NativeMethodInfoPtr_AddToStormLevelIcon_Private_ModifierIcon_GameModifierData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    IntPtr pointer = num;
    return pointer == IntPtr.Zero ? (ModifierIcon) null : new ModifierIcon(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93058, XrefRangeEnd = 93069, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ModifierIcon CreateStormLevelIcon(GameModifierData firstModifier)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) firstModifier)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifierDisplay.NativeMethodInfoPtr_CreateStormLevelIcon_Private_ModifierIcon_GameModifierData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    IntPtr pointer = num;
    return pointer == IntPtr.Zero ? (ModifierIcon) null : new ModifierIcon(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 93078, RefRangeEnd = 93080, XrefRangeStart = 93069, XrefRangeEnd = 93078, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ModifierDisplay()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModifierDisplay>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ModifierDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ModifierDisplay()
  {
    Il2CppClassPointerStore<ModifierDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ModifierDisplay));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifierDisplay>.NativeClassPtr);
    ModifierDisplay.NativeFieldInfoPtr_iconPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifierDisplay>.NativeClassPtr, nameof (iconPrefab));
    ModifierDisplay.NativeFieldInfoPtr_stormLevelIconPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifierDisplay>.NativeClassPtr, nameof (stormLevelIconPrefab));
    ModifierDisplay.NativeFieldInfoPtr_popUpOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifierDisplay>.NativeClassPtr, nameof (popUpOffset));
    ModifierDisplay.NativeFieldInfoPtr_icons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifierDisplay>.NativeClassPtr, nameof (icons));
    ModifierDisplay.NativeFieldInfoPtr__modifierCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifierDisplay>.NativeClassPtr, "<modifierCount>k__BackingField");
    ModifierDisplay.NativeFieldInfoPtr_stormLevelIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifierDisplay>.NativeClassPtr, nameof (stormLevelIcon));
    ModifierDisplay.NativeMethodInfoPtr_get_modifierCount_Protected_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifierDisplay>.NativeClassPtr, 100671327);
    ModifierDisplay.NativeMethodInfoPtr_set_modifierCount_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifierDisplay>.NativeClassPtr, 100671328);
    ModifierDisplay.NativeMethodInfoPtr_CreateIcon_Public_ModifierIcon_GameModifierData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifierDisplay>.NativeClassPtr, 100671329);
    ModifierDisplay.NativeMethodInfoPtr_ClearIcons_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifierDisplay>.NativeClassPtr, 100671330);
    ModifierDisplay.NativeMethodInfoPtr_AddToStormLevelIcon_Private_ModifierIcon_GameModifierData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifierDisplay>.NativeClassPtr, 100671331);
    ModifierDisplay.NativeMethodInfoPtr_CreateStormLevelIcon_Private_ModifierIcon_GameModifierData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifierDisplay>.NativeClassPtr, 100671332);
    ModifierDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifierDisplay>.NativeClassPtr, 100671333);
  }

  public ModifierDisplay(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe ModifierIcon iconPrefab
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifierDisplay.NativeFieldInfoPtr_iconPrefab));
      return pointer == IntPtr.Zero ? (ModifierIcon) null : new ModifierIcon(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ModifierDisplay.NativeFieldInfoPtr_iconPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ModifierIconMultiple stormLevelIconPrefab
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifierDisplay.NativeFieldInfoPtr_stormLevelIconPrefab));
      return pointer == IntPtr.Zero ? (ModifierIconMultiple) null : new ModifierIconMultiple(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ModifierDisplay.NativeFieldInfoPtr_stormLevelIconPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector2 popUpOffset
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifierDisplay.NativeFieldInfoPtr_popUpOffset));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifierDisplay.NativeFieldInfoPtr_popUpOffset)) = value;
    }
  }

  public unsafe List<ModifierIcon> icons
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifierDisplay.NativeFieldInfoPtr_icons));
      return pointer == IntPtr.Zero ? (List<ModifierIcon>) null : new List<ModifierIcon>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ModifierDisplay.NativeFieldInfoPtr_icons), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _modifierCount_k__BackingField
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifierDisplay.NativeFieldInfoPtr__modifierCount_k__BackingField));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifierDisplay.NativeFieldInfoPtr__modifierCount_k__BackingField)) = value;
    }
  }

  public unsafe ModifierIconMultiple stormLevelIcon
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifierDisplay.NativeFieldInfoPtr_stormLevelIcon));
      return pointer == IntPtr.Zero ? (ModifierIconMultiple) null : new ModifierIconMultiple(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ModifierDisplay.NativeFieldInfoPtr_stormLevelIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
