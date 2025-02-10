// Decompiled with JetBrains decompiler
// Type: ModifierIconMultiple
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

#nullable disable
public class ModifierIconMultiple : ModifierIcon
{
  private static readonly IntPtr NativeFieldInfoPtr_stormLevelText;
  private static readonly IntPtr NativeFieldInfoPtr_juiceLevel;
  private static readonly IntPtr NativeFieldInfoPtr_juiceLevelRange;
  private static readonly IntPtr NativeFieldInfoPtr_modifiers;
  private static readonly IntPtr NativeFieldInfoPtr__stormLevel;
  private static readonly IntPtr NativeMethodInfoPtr_get_stormLevel_Private_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_stormLevel_Private_set_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Void_GameModifierData_Vector2_0;
  private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_GameModifierData_0;
  private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Pop_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_UnPop_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe int stormLevel
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifierIconMultiple.NativeMethodInfoPtr_get_stormLevel_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(5), CachedScanResults(RefRangeStart = 93185, RefRangeEnd = 93190, XrefRangeStart = 93170, XrefRangeEnd = 93185, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModifierIconMultiple.NativeMethodInfoPtr_set_stormLevel_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93190, XrefRangeEnd = 93201, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Set(GameModifierData modifier, Vector2 popUpOffset)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) modifier);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &popUpOffset;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ModifierIconMultiple.NativeMethodInfoPtr_Set_Public_Virtual_Void_GameModifierData_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 93209, RefRangeEnd = 93212, XrefRangeStart = 93201, XrefRangeEnd = 93209, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Add(GameModifierData modifier)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) modifier)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ModifierIconMultiple.NativeMethodInfoPtr_Add_Public_Void_GameModifierData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93212, XrefRangeEnd = 93215, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Clear()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ModifierIconMultiple.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93215, XrefRangeEnd = 93235, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Pop()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ModifierIconMultiple.NativeMethodInfoPtr_Pop_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93235, XrefRangeEnd = 93251, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void UnPop()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ModifierIconMultiple.NativeMethodInfoPtr_UnPop_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93251, XrefRangeEnd = 93260, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ModifierIconMultiple()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModifierIconMultiple>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ModifierIconMultiple.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ModifierIconMultiple()
  {
    Il2CppClassPointerStore<ModifierIconMultiple>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ModifierIconMultiple));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifierIconMultiple>.NativeClassPtr);
    ModifierIconMultiple.NativeFieldInfoPtr_stormLevelText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifierIconMultiple>.NativeClassPtr, nameof (stormLevelText));
    ModifierIconMultiple.NativeFieldInfoPtr_juiceLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifierIconMultiple>.NativeClassPtr, nameof (juiceLevel));
    ModifierIconMultiple.NativeFieldInfoPtr_juiceLevelRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifierIconMultiple>.NativeClassPtr, nameof (juiceLevelRange));
    ModifierIconMultiple.NativeFieldInfoPtr_modifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifierIconMultiple>.NativeClassPtr, nameof (modifiers));
    ModifierIconMultiple.NativeFieldInfoPtr__stormLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifierIconMultiple>.NativeClassPtr, nameof (_stormLevel));
    ModifierIconMultiple.NativeMethodInfoPtr_get_stormLevel_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifierIconMultiple>.NativeClassPtr, 100671346);
    ModifierIconMultiple.NativeMethodInfoPtr_set_stormLevel_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifierIconMultiple>.NativeClassPtr, 100671347);
    ModifierIconMultiple.NativeMethodInfoPtr_Set_Public_Virtual_Void_GameModifierData_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifierIconMultiple>.NativeClassPtr, 100671348);
    ModifierIconMultiple.NativeMethodInfoPtr_Add_Public_Void_GameModifierData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifierIconMultiple>.NativeClassPtr, 100671349);
    ModifierIconMultiple.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifierIconMultiple>.NativeClassPtr, 100671350);
    ModifierIconMultiple.NativeMethodInfoPtr_Pop_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifierIconMultiple>.NativeClassPtr, 100671351);
    ModifierIconMultiple.NativeMethodInfoPtr_UnPop_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifierIconMultiple>.NativeClassPtr, 100671352);
    ModifierIconMultiple.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifierIconMultiple>.NativeClassPtr, 100671353);
  }

  public ModifierIconMultiple(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe TMP_Text stormLevelText
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifierIconMultiple.NativeFieldInfoPtr_stormLevelText));
      return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ModifierIconMultiple.NativeFieldInfoPtr_stormLevelText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform juiceLevel
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifierIconMultiple.NativeFieldInfoPtr_juiceLevel));
      return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ModifierIconMultiple.NativeFieldInfoPtr_juiceLevel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector2 juiceLevelRange
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifierIconMultiple.NativeFieldInfoPtr_juiceLevelRange));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifierIconMultiple.NativeFieldInfoPtr_juiceLevelRange)) = value;
    }
  }

  public unsafe List<GameModifierData> modifiers
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifierIconMultiple.NativeFieldInfoPtr_modifiers));
      return pointer == IntPtr.Zero ? (List<GameModifierData>) null : new List<GameModifierData>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ModifierIconMultiple.NativeFieldInfoPtr_modifiers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _stormLevel
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifierIconMultiple.NativeFieldInfoPtr__stormLevel));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifierIconMultiple.NativeFieldInfoPtr__stormLevel)) = value;
    }
  }
}
