// Decompiled with JetBrains decompiler
// Type: ModifierIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class ModifierIcon : MonoBehaviourRect
{
  private static readonly IntPtr NativeFieldInfoPtr_layoutElement;
  private static readonly IntPtr NativeFieldInfoPtr_bellHolder;
  private static readonly IntPtr NativeFieldInfoPtr_bellImage;
  private static readonly IntPtr NativeFieldInfoPtr_dingerImage;
  private static readonly IntPtr NativeFieldInfoPtr_activeIcon;
  private static readonly IntPtr NativeFieldInfoPtr_inactiveIcon;
  private static readonly IntPtr NativeFieldInfoPtr_dingTweens;
  private static readonly IntPtr NativeFieldInfoPtr_playDingSfx;
  private static readonly IntPtr NativeFieldInfoPtr_title;
  private static readonly IntPtr NativeFieldInfoPtr_body;
  private static readonly IntPtr NativeFieldInfoPtr_modifier;
  private static readonly IntPtr NativeFieldInfoPtr_popUpName;
  private static readonly IntPtr NativeFieldInfoPtr_poppedUp;
  private static readonly IntPtr NativeFieldInfoPtr_popUpOffset;
  private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Virtual_New_Void_GameModifierData_Vector2_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_String_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_AddText_Public_Void_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_Pop_Public_Virtual_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_UnPop_Public_Virtual_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Ding_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 93147, RefRangeEnd = 93148, XrefRangeStart = 93124, XrefRangeEnd = 93147, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(GameModifierData modifier, Vector2 popUpOffset)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) modifier);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &popUpOffset;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ModifierIcon.NativeMethodInfoPtr_Set_Public_Virtual_New_Void_GameModifierData_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93148, XrefRangeEnd = 93150, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetText(string title, string body)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(title);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(body);
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ModifierIcon.NativeMethodInfoPtr_SetText_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93150, XrefRangeEnd = 93152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddText(string toBody)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(toBody)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ModifierIcon.NativeMethodInfoPtr_AddText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93152, XrefRangeEnd = 93155, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Pop()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ModifierIcon.NativeMethodInfoPtr_Pop_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93155, XrefRangeEnd = 93156, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void UnPop()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ModifierIcon.NativeMethodInfoPtr_UnPop_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 93156, RefRangeEnd = 93160, XrefRangeStart = 93156, XrefRangeEnd = 93156, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ModifierIcon.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 93163, RefRangeEnd = 93169, XrefRangeStart = 93160, XrefRangeEnd = 93163, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Ding()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ModifierIcon.NativeMethodInfoPtr_Ding_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93169, XrefRangeEnd = 93170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ModifierIcon()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModifierIcon>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ModifierIcon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ModifierIcon()
  {
    Il2CppClassPointerStore<ModifierIcon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ModifierIcon));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifierIcon>.NativeClassPtr);
    ModifierIcon.NativeFieldInfoPtr_layoutElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifierIcon>.NativeClassPtr, nameof (layoutElement));
    ModifierIcon.NativeFieldInfoPtr_bellHolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifierIcon>.NativeClassPtr, nameof (bellHolder));
    ModifierIcon.NativeFieldInfoPtr_bellImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifierIcon>.NativeClassPtr, nameof (bellImage));
    ModifierIcon.NativeFieldInfoPtr_dingerImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifierIcon>.NativeClassPtr, nameof (dingerImage));
    ModifierIcon.NativeFieldInfoPtr_activeIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifierIcon>.NativeClassPtr, nameof (activeIcon));
    ModifierIcon.NativeFieldInfoPtr_inactiveIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifierIcon>.NativeClassPtr, nameof (inactiveIcon));
    ModifierIcon.NativeFieldInfoPtr_dingTweens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifierIcon>.NativeClassPtr, nameof (dingTweens));
    ModifierIcon.NativeFieldInfoPtr_playDingSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifierIcon>.NativeClassPtr, nameof (playDingSfx));
    ModifierIcon.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifierIcon>.NativeClassPtr, nameof (title));
    ModifierIcon.NativeFieldInfoPtr_body = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifierIcon>.NativeClassPtr, nameof (body));
    ModifierIcon.NativeFieldInfoPtr_modifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifierIcon>.NativeClassPtr, nameof (modifier));
    ModifierIcon.NativeFieldInfoPtr_popUpName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifierIcon>.NativeClassPtr, nameof (popUpName));
    ModifierIcon.NativeFieldInfoPtr_poppedUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifierIcon>.NativeClassPtr, nameof (poppedUp));
    ModifierIcon.NativeFieldInfoPtr_popUpOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifierIcon>.NativeClassPtr, nameof (popUpOffset));
    ModifierIcon.NativeMethodInfoPtr_Set_Public_Virtual_New_Void_GameModifierData_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifierIcon>.NativeClassPtr, 100671338);
    ModifierIcon.NativeMethodInfoPtr_SetText_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifierIcon>.NativeClassPtr, 100671339);
    ModifierIcon.NativeMethodInfoPtr_AddText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifierIcon>.NativeClassPtr, 100671340);
    ModifierIcon.NativeMethodInfoPtr_Pop_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifierIcon>.NativeClassPtr, 100671341);
    ModifierIcon.NativeMethodInfoPtr_UnPop_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifierIcon>.NativeClassPtr, 100671342);
    ModifierIcon.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifierIcon>.NativeClassPtr, 100671343);
    ModifierIcon.NativeMethodInfoPtr_Ding_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifierIcon>.NativeClassPtr, 100671344);
    ModifierIcon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifierIcon>.NativeClassPtr, 100671345);
  }

  public ModifierIcon(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe LayoutElement layoutElement
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifierIcon.NativeFieldInfoPtr_layoutElement));
      return pointer == IntPtr.Zero ? (LayoutElement) null : new LayoutElement(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ModifierIcon.NativeFieldInfoPtr_layoutElement), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform bellHolder
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifierIcon.NativeFieldInfoPtr_bellHolder));
      return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ModifierIcon.NativeFieldInfoPtr_bellHolder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ImageSprite bellImage
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifierIcon.NativeFieldInfoPtr_bellImage));
      return pointer == IntPtr.Zero ? (ImageSprite) null : new ImageSprite(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ModifierIcon.NativeFieldInfoPtr_bellImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ImageSprite dingerImage
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifierIcon.NativeFieldInfoPtr_dingerImage));
      return pointer == IntPtr.Zero ? (ImageSprite) null : new ImageSprite(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ModifierIcon.NativeFieldInfoPtr_dingerImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject activeIcon
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifierIcon.NativeFieldInfoPtr_activeIcon));
      return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ModifierIcon.NativeFieldInfoPtr_activeIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject inactiveIcon
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifierIcon.NativeFieldInfoPtr_inactiveIcon));
      return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ModifierIcon.NativeFieldInfoPtr_inactiveIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<TweenUI> dingTweens
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifierIcon.NativeFieldInfoPtr_dingTweens));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<TweenUI>) null : new Il2CppReferenceArray<TweenUI>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ModifierIcon.NativeFieldInfoPtr_dingTweens), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool playDingSfx
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifierIcon.NativeFieldInfoPtr_playDingSfx));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifierIcon.NativeFieldInfoPtr_playDingSfx)) = value;
    }
  }

  public unsafe string title
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifierIcon.NativeFieldInfoPtr_title)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ModifierIcon.NativeFieldInfoPtr_title), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string body
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifierIcon.NativeFieldInfoPtr_body)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ModifierIcon.NativeFieldInfoPtr_body), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe GameModifierData modifier
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifierIcon.NativeFieldInfoPtr_modifier));
      return pointer == IntPtr.Zero ? (GameModifierData) null : new GameModifierData(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ModifierIcon.NativeFieldInfoPtr_modifier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string popUpName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifierIcon.NativeFieldInfoPtr_popUpName)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ModifierIcon.NativeFieldInfoPtr_popUpName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe bool poppedUp
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifierIcon.NativeFieldInfoPtr_poppedUp));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifierIcon.NativeFieldInfoPtr_poppedUp)) = value;
    }
  }

  public unsafe Vector2 popUpOffset
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifierIcon.NativeFieldInfoPtr_popUpOffset));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifierIcon.NativeFieldInfoPtr_popUpOffset)) = value;
    }
  }
}
