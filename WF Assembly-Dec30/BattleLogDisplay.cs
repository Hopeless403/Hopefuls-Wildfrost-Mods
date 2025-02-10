// Decompiled with JetBrains decompiler
// Type: BattleLogDisplay
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
public class BattleLogDisplay : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_builder;
  private static readonly IntPtr NativeFieldInfoPtr_scroll;
  private static readonly IntPtr NativeFieldInfoPtr_loadingWidget;
  private static readonly IntPtr NativeFieldInfoPtr_promptScrollToBottom;
  private static readonly IntPtr NativeFieldInfoPtr_loadingWidgetActive;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckScrollToBottom_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_PromptScrollToBottom_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86197, XrefRangeEnd = 86200, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleLogDisplay.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86200, XrefRangeEnd = 86202, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleLogDisplay.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 86205, RefRangeEnd = 86207, XrefRangeStart = 86202, XrefRangeEnd = 86205, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CheckScrollToBottom()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleLogDisplay.NativeMethodInfoPtr_CheckScrollToBottom_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe void PromptScrollToBottom()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleLogDisplay.NativeMethodInfoPtr_PromptScrollToBottom_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BattleLogDisplay()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleLogDisplay>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleLogDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BattleLogDisplay()
  {
    Il2CppClassPointerStore<BattleLogDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (BattleLogDisplay));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleLogDisplay>.NativeClassPtr);
    BattleLogDisplay.NativeFieldInfoPtr_builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplay>.NativeClassPtr, nameof (builder));
    BattleLogDisplay.NativeFieldInfoPtr_scroll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplay>.NativeClassPtr, nameof (scroll));
    BattleLogDisplay.NativeFieldInfoPtr_loadingWidget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplay>.NativeClassPtr, nameof (loadingWidget));
    BattleLogDisplay.NativeFieldInfoPtr_promptScrollToBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplay>.NativeClassPtr, nameof (promptScrollToBottom));
    BattleLogDisplay.NativeFieldInfoPtr_loadingWidgetActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogDisplay>.NativeClassPtr, nameof (loadingWidgetActive));
    BattleLogDisplay.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogDisplay>.NativeClassPtr, 100670565);
    BattleLogDisplay.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogDisplay>.NativeClassPtr, 100670566);
    BattleLogDisplay.NativeMethodInfoPtr_CheckScrollToBottom_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogDisplay>.NativeClassPtr, 100670567);
    BattleLogDisplay.NativeMethodInfoPtr_PromptScrollToBottom_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogDisplay>.NativeClassPtr, 100670568);
    BattleLogDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogDisplay>.NativeClassPtr, 100670569);
  }

  public BattleLogDisplay(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe BattleLogDisplayBuilder builder
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplay.NativeFieldInfoPtr_builder));
      return pointer == IntPtr.Zero ? (BattleLogDisplayBuilder) null : new BattleLogDisplayBuilder(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplay.NativeFieldInfoPtr_builder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ScrollRect scroll
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplay.NativeFieldInfoPtr_scroll));
      return pointer == IntPtr.Zero ? (ScrollRect) null : new ScrollRect(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplay.NativeFieldInfoPtr_scroll), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject loadingWidget
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplay.NativeFieldInfoPtr_loadingWidget));
      return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplay.NativeFieldInfoPtr_loadingWidget), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool promptScrollToBottom
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplay.NativeFieldInfoPtr_promptScrollToBottom));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplay.NativeFieldInfoPtr_promptScrollToBottom)) = value;
    }
  }

  public unsafe bool loadingWidgetActive
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplay.NativeFieldInfoPtr_loadingWidgetActive));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogDisplay.NativeFieldInfoPtr_loadingWidgetActive)) = value;
    }
  }
}
