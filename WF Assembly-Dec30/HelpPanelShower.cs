// Decompiled with JetBrains decompiler
// Type: HelpPanelShower
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;

#nullable disable
public class HelpPanelShower : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_key;
  private static readonly System.IntPtr NativeFieldInfoPtr_emote;
  private static readonly System.IntPtr NativeFieldInfoPtr_buttonTextKeys;
  private static readonly System.IntPtr NativeFieldInfoPtr_buttonHotKeys;
  private static readonly System.IntPtr NativeFieldInfoPtr_canGoBack;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetKey_Public_Void_LocalizedString_Nullable_1_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Show_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddButton_Public_Void_Int32_ButtonType_UnityAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 50894, RefRangeEnd = 50896, XrefRangeStart = 50889, XrefRangeEnd = 50894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetKey(LocalizedString key, Il2CppSystem.Nullable<Prompt.Emote.Type> emoteType = null)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) key);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) emoteType));
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HelpPanelShower.NativeMethodInfoPtr_SetKey_Public_Void_LocalizedString_Nullable_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 50902, RefRangeEnd = 50906, XrefRangeStart = 50896, XrefRangeEnd = 50902, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Show()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HelpPanelShower.NativeMethodInfoPtr_Show_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 50912, RefRangeEnd = 50916, XrefRangeStart = 50906, XrefRangeEnd = 50912, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddButton(int index, HelpPanelSystem.ButtonType type, UnityAction action)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &index;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HelpPanelShower.NativeMethodInfoPtr_AddButton_Public_Void_Int32_ButtonType_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50916, XrefRangeEnd = 50917, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe HelpPanelShower()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HelpPanelShower>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HelpPanelShower.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static HelpPanelShower()
  {
    Il2CppClassPointerStore<HelpPanelShower>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (HelpPanelShower));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HelpPanelShower>.NativeClassPtr);
    HelpPanelShower.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpPanelShower>.NativeClassPtr, nameof (key));
    HelpPanelShower.NativeFieldInfoPtr_emote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpPanelShower>.NativeClassPtr, nameof (emote));
    HelpPanelShower.NativeFieldInfoPtr_buttonTextKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpPanelShower>.NativeClassPtr, nameof (buttonTextKeys));
    HelpPanelShower.NativeFieldInfoPtr_buttonHotKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpPanelShower>.NativeClassPtr, nameof (buttonHotKeys));
    HelpPanelShower.NativeFieldInfoPtr_canGoBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpPanelShower>.NativeClassPtr, nameof (canGoBack));
    HelpPanelShower.NativeMethodInfoPtr_SetKey_Public_Void_LocalizedString_Nullable_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelpPanelShower>.NativeClassPtr, 100667375);
    HelpPanelShower.NativeMethodInfoPtr_Show_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelpPanelShower>.NativeClassPtr, 100667376);
    HelpPanelShower.NativeMethodInfoPtr_AddButton_Public_Void_Int32_ButtonType_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelpPanelShower>.NativeClassPtr, 100667377);
    HelpPanelShower.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelpPanelShower>.NativeClassPtr, 100667378);
  }

  public HelpPanelShower(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe LocalizedString key
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HelpPanelShower.NativeFieldInfoPtr_key));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HelpPanelShower.NativeFieldInfoPtr_key), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Prompt.Emote.Type emote
  {
    get
    {
      return *(Prompt.Emote.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HelpPanelShower.NativeFieldInfoPtr_emote));
    }
    [param: In] set
    {
      *(Prompt.Emote.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HelpPanelShower.NativeFieldInfoPtr_emote)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<LocalizedString> buttonTextKeys
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HelpPanelShower.NativeFieldInfoPtr_buttonTextKeys));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<LocalizedString>) null : new Il2CppReferenceArray<LocalizedString>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HelpPanelShower.NativeFieldInfoPtr_buttonTextKeys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStringArray buttonHotKeys
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HelpPanelShower.NativeFieldInfoPtr_buttonHotKeys));
      return pointer == System.IntPtr.Zero ? (Il2CppStringArray) null : new Il2CppStringArray(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HelpPanelShower.NativeFieldInfoPtr_buttonHotKeys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool canGoBack
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HelpPanelShower.NativeFieldInfoPtr_canGoBack));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HelpPanelShower.NativeFieldInfoPtr_canGoBack)) = value;
    }
  }
}
