// Decompiled with JetBrains decompiler
// Type: CrownHolderShop
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
public class CrownHolderShop : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_animator;
  private static readonly IntPtr NativeFieldInfoPtr_crown;
  private static readonly IntPtr NativeFieldInfoPtr_crownImage;
  private static readonly IntPtr NativeFieldInfoPtr_crownWhiteImage;
  private static readonly IntPtr NativeFieldInfoPtr_interaction;
  private static readonly IntPtr NativeFieldInfoPtr_popUpOffset;
  private static readonly IntPtr NativeFieldInfoPtr_crownData;
  private static readonly IntPtr NativeFieldInfoPtr_popUpName;
  private static readonly IntPtr NativeFieldInfoPtr_popUpTitle;
  private static readonly IntPtr NativeFieldInfoPtr_popUpBody;
  private static readonly IntPtr NativeFieldInfoPtr_hover;
  private static readonly IntPtr NativeFieldInfoPtr__hasCrown;
  private static readonly IntPtr NativeMethodInfoPtr_get_hasCrown_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_hasCrown_Public_set_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetCrownData_Public_Void_CardUpgradeData_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetCrownData_Public_CardUpgradeData_0;
  private static readonly IntPtr NativeMethodInfoPtr_CanTake_Public_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_Hover_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_UnHover_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_TakeCrown_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe bool hasCrown
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(CrownHolderShop.NativeMethodInfoPtr_get_hasCrown_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38269, XrefRangeEnd = 38272, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CrownHolderShop.NativeMethodInfoPtr_set_hasCrown_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 38282, RefRangeEnd = 38283, XrefRangeStart = 38272, XrefRangeEnd = 38282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetCrownData(CardUpgradeData crownData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) crownData)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CrownHolderShop.NativeMethodInfoPtr_SetCrownData_Public_Void_CardUpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe CardUpgradeData GetCrownData()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(CrownHolderShop.NativeMethodInfoPtr_GetCrownData_Public_CardUpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    IntPtr pointer = num;
    return pointer == IntPtr.Zero ? (CardUpgradeData) null : new CardUpgradeData(pointer);
  }

  [CallerCount(0)]
  public unsafe bool CanTake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(CrownHolderShop.NativeMethodInfoPtr_CanTake_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38283, XrefRangeEnd = 38290, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Hover()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CrownHolderShop.NativeMethodInfoPtr_Hover_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38290, XrefRangeEnd = 38294, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnHover()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CrownHolderShop.NativeMethodInfoPtr_UnHover_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 38297, RefRangeEnd = 38299, XrefRangeStart = 38294, XrefRangeEnd = 38297, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void TakeCrown()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CrownHolderShop.NativeMethodInfoPtr_TakeCrown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38299, XrefRangeEnd = 38300, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CrownHolderShop()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrownHolderShop>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CrownHolderShop.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CrownHolderShop()
  {
    Il2CppClassPointerStore<CrownHolderShop>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CrownHolderShop));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CrownHolderShop>.NativeClassPtr);
    CrownHolderShop.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrownHolderShop>.NativeClassPtr, nameof (animator));
    CrownHolderShop.NativeFieldInfoPtr_crown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrownHolderShop>.NativeClassPtr, nameof (crown));
    CrownHolderShop.NativeFieldInfoPtr_crownImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrownHolderShop>.NativeClassPtr, nameof (crownImage));
    CrownHolderShop.NativeFieldInfoPtr_crownWhiteImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrownHolderShop>.NativeClassPtr, nameof (crownWhiteImage));
    CrownHolderShop.NativeFieldInfoPtr_interaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrownHolderShop>.NativeClassPtr, nameof (interaction));
    CrownHolderShop.NativeFieldInfoPtr_popUpOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrownHolderShop>.NativeClassPtr, nameof (popUpOffset));
    CrownHolderShop.NativeFieldInfoPtr_crownData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrownHolderShop>.NativeClassPtr, nameof (crownData));
    CrownHolderShop.NativeFieldInfoPtr_popUpName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrownHolderShop>.NativeClassPtr, nameof (popUpName));
    CrownHolderShop.NativeFieldInfoPtr_popUpTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrownHolderShop>.NativeClassPtr, nameof (popUpTitle));
    CrownHolderShop.NativeFieldInfoPtr_popUpBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrownHolderShop>.NativeClassPtr, nameof (popUpBody));
    CrownHolderShop.NativeFieldInfoPtr_hover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrownHolderShop>.NativeClassPtr, nameof (hover));
    CrownHolderShop.NativeFieldInfoPtr__hasCrown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrownHolderShop>.NativeClassPtr, nameof (_hasCrown));
    CrownHolderShop.NativeMethodInfoPtr_get_hasCrown_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrownHolderShop>.NativeClassPtr, 100665886);
    CrownHolderShop.NativeMethodInfoPtr_set_hasCrown_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrownHolderShop>.NativeClassPtr, 100665887);
    CrownHolderShop.NativeMethodInfoPtr_SetCrownData_Public_Void_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrownHolderShop>.NativeClassPtr, 100665888);
    CrownHolderShop.NativeMethodInfoPtr_GetCrownData_Public_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrownHolderShop>.NativeClassPtr, 100665889);
    CrownHolderShop.NativeMethodInfoPtr_CanTake_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrownHolderShop>.NativeClassPtr, 100665890);
    CrownHolderShop.NativeMethodInfoPtr_Hover_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrownHolderShop>.NativeClassPtr, 100665891);
    CrownHolderShop.NativeMethodInfoPtr_UnHover_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrownHolderShop>.NativeClassPtr, 100665892);
    CrownHolderShop.NativeMethodInfoPtr_TakeCrown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrownHolderShop>.NativeClassPtr, 100665893);
    CrownHolderShop.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrownHolderShop>.NativeClassPtr, 100665894);
  }

  public CrownHolderShop(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe UnityEngine.Animator animator
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrownHolderShop.NativeFieldInfoPtr_animator));
      return pointer == IntPtr.Zero ? (UnityEngine.Animator) null : new UnityEngine.Animator(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CrownHolderShop.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject crown
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrownHolderShop.NativeFieldInfoPtr_crown));
      return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CrownHolderShop.NativeFieldInfoPtr_crown), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image crownImage
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrownHolderShop.NativeFieldInfoPtr_crownImage));
      return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CrownHolderShop.NativeFieldInfoPtr_crownImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image crownWhiteImage
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrownHolderShop.NativeFieldInfoPtr_crownWhiteImage));
      return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CrownHolderShop.NativeFieldInfoPtr_crownWhiteImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image interaction
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrownHolderShop.NativeFieldInfoPtr_interaction));
      return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CrownHolderShop.NativeFieldInfoPtr_interaction), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector2 popUpOffset
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrownHolderShop.NativeFieldInfoPtr_popUpOffset));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrownHolderShop.NativeFieldInfoPtr_popUpOffset)) = value;
    }
  }

  public unsafe CardUpgradeData crownData
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrownHolderShop.NativeFieldInfoPtr_crownData));
      return pointer == IntPtr.Zero ? (CardUpgradeData) null : new CardUpgradeData(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CrownHolderShop.NativeFieldInfoPtr_crownData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string popUpName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrownHolderShop.NativeFieldInfoPtr_popUpName)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CrownHolderShop.NativeFieldInfoPtr_popUpName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string popUpTitle
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrownHolderShop.NativeFieldInfoPtr_popUpTitle)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CrownHolderShop.NativeFieldInfoPtr_popUpTitle), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string popUpBody
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrownHolderShop.NativeFieldInfoPtr_popUpBody)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CrownHolderShop.NativeFieldInfoPtr_popUpBody), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe bool hover
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrownHolderShop.NativeFieldInfoPtr_hover));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrownHolderShop.NativeFieldInfoPtr_hover)) = value;
    }
  }

  public unsafe bool _hasCrown
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrownHolderShop.NativeFieldInfoPtr__hasCrown));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrownHolderShop.NativeFieldInfoPtr__hasCrown)) = value;
    }
  }
}
