// Decompiled with JetBrains decompiler
// Type: PauseMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class PauseMenu : Menu
{
  private static readonly IntPtr NativeFieldInfoPtr_backToMenuButton;
  private static readonly IntPtr NativeFieldInfoPtr_quickRestartButton;
  private static readonly IntPtr NativeFieldInfoPtr_freezeTimeScale;
  private static readonly IntPtr NativeFieldInfoPtr_battleLogTab;
  private static readonly IntPtr NativeFieldInfoPtr_settingsTab;
  private static readonly IntPtr NativeFieldInfoPtr_lorePageTab;
  private static readonly IntPtr NativeFieldInfoPtr_blocked;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_BackToMainMenu_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_QuickRestart_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_BattleLog_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Settings_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OpenLorePages_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Block_Public_Static_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Unblock_Public_Static_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92450, XrefRangeEnd = 92483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92483, XrefRangeEnd = 92488, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92488, XrefRangeEnd = 92510, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BackToMainMenu()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr_BackToMainMenu_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92510, XrefRangeEnd = 92538, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void QuickRestart()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr_QuickRestart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92538, XrefRangeEnd = 92541, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BattleLog()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr_BattleLog_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92541, XrefRangeEnd = 92544, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Settings()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr_Settings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 92547, RefRangeEnd = 92548, XrefRangeStart = 92544, XrefRangeEnd = 92547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OpenLorePages()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr_OpenLorePages_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92548, XrefRangeEnd = 92552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Open()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PauseMenu.NativeMethodInfoPtr_Open_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 92563, RefRangeEnd = 92568, XrefRangeStart = 92552, XrefRangeEnd = 92563, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Block()
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr_Block_Public_Static_Void_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 92570, RefRangeEnd = 92577, XrefRangeStart = 92568, XrefRangeEnd = 92570, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Unblock()
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr_Unblock_Public_Static_Void_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PauseMenu()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static PauseMenu()
  {
    Il2CppClassPointerStore<PauseMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (PauseMenu));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr);
    PauseMenu.NativeFieldInfoPtr_backToMenuButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, nameof (backToMenuButton));
    PauseMenu.NativeFieldInfoPtr_quickRestartButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, nameof (quickRestartButton));
    PauseMenu.NativeFieldInfoPtr_freezeTimeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, nameof (freezeTimeScale));
    PauseMenu.NativeFieldInfoPtr_battleLogTab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, nameof (battleLogTab));
    PauseMenu.NativeFieldInfoPtr_settingsTab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, nameof (settingsTab));
    PauseMenu.NativeFieldInfoPtr_lorePageTab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, nameof (lorePageTab));
    PauseMenu.NativeFieldInfoPtr_blocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, nameof (blocked));
    PauseMenu.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100671286);
    PauseMenu.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100671287);
    PauseMenu.NativeMethodInfoPtr_BackToMainMenu_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100671288);
    PauseMenu.NativeMethodInfoPtr_QuickRestart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100671289);
    PauseMenu.NativeMethodInfoPtr_BattleLog_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100671290);
    PauseMenu.NativeMethodInfoPtr_Settings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100671291);
    PauseMenu.NativeMethodInfoPtr_OpenLorePages_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100671292);
    PauseMenu.NativeMethodInfoPtr_Open_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100671293);
    PauseMenu.NativeMethodInfoPtr_Block_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100671294);
    PauseMenu.NativeMethodInfoPtr_Unblock_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100671295);
    PauseMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100671296);
  }

  public PauseMenu(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe ButtonAnimator backToMenuButton
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_backToMenuButton));
      return pointer == IntPtr.Zero ? (ButtonAnimator) null : new ButtonAnimator(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_backToMenuButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ButtonAnimator quickRestartButton
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_quickRestartButton));
      return pointer == IntPtr.Zero ? (ButtonAnimator) null : new ButtonAnimator(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_quickRestartButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool freezeTimeScale
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_freezeTimeScale));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_freezeTimeScale)) = value;
    }
  }

  public unsafe JournalTab battleLogTab
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_battleLogTab));
      return pointer == IntPtr.Zero ? (JournalTab) null : new JournalTab(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_battleLogTab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe JournalTab settingsTab
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_settingsTab));
      return pointer == IntPtr.Zero ? (JournalTab) null : new JournalTab(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_settingsTab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe JournalTab lorePageTab
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_lorePageTab));
      return pointer == IntPtr.Zero ? (JournalTab) null : new JournalTab(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_lorePageTab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe int blocked
  {
    get
    {
      int blocked;
      IL2CPP.il2cpp_field_static_get_value(PauseMenu.NativeFieldInfoPtr_blocked, (void*) &blocked);
      return blocked;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PauseMenu.NativeFieldInfoPtr_blocked, (void*) &value);
    }
  }
}
