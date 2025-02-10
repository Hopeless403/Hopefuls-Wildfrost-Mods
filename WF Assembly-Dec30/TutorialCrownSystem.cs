// Decompiled with JetBrains decompiler
// Type: TutorialCrownSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class TutorialCrownSystem : TutorialParentSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_promptSystemNeedsReset;
  private static readonly System.IntPtr NativeFieldInfoPtr_deckpackOpen;
  private static readonly System.IntPtr NativeFieldInfoPtr_promptShown;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DeckpackOpen_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DeckpackClose_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpgradeAssign_Private_Void_Entity_CardUpgradeData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShowPrompt_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HidePrompt_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckPromptSystemReset_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80148, XrefRangeEnd = 80181, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialCrownSystem.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80181, XrefRangeEnd = 80204, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialCrownSystem.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe void DeckpackOpen()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TutorialCrownSystem.NativeMethodInfoPtr_DeckpackOpen_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80204, XrefRangeEnd = 80205, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DeckpackClose()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TutorialCrownSystem.NativeMethodInfoPtr_DeckpackClose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80205, XrefRangeEnd = 80236, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpgradeAssign(Entity entity, CardUpgradeData upgradeData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) upgradeData);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TutorialCrownSystem.NativeMethodInfoPtr_UpgradeAssign_Private_Void_Entity_CardUpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80236, XrefRangeEnd = 80259, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ShowPrompt()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TutorialCrownSystem.NativeMethodInfoPtr_ShowPrompt_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 80266, RefRangeEnd = 80268, XrefRangeStart = 80259, XrefRangeEnd = 80266, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void HidePrompt()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TutorialCrownSystem.NativeMethodInfoPtr_HidePrompt_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80268, XrefRangeEnd = 80274, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CheckPromptSystemReset()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TutorialCrownSystem.NativeMethodInfoPtr_CheckPromptSystemReset_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TutorialCrownSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialCrownSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TutorialCrownSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static TutorialCrownSystem()
  {
    Il2CppClassPointerStore<TutorialCrownSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (TutorialCrownSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialCrownSystem>.NativeClassPtr);
    TutorialCrownSystem.NativeFieldInfoPtr_promptSystemNeedsReset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCrownSystem>.NativeClassPtr, nameof (promptSystemNeedsReset));
    TutorialCrownSystem.NativeFieldInfoPtr_deckpackOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCrownSystem>.NativeClassPtr, nameof (deckpackOpen));
    TutorialCrownSystem.NativeFieldInfoPtr_promptShown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCrownSystem>.NativeClassPtr, nameof (promptShown));
    TutorialCrownSystem.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCrownSystem>.NativeClassPtr, 100669849);
    TutorialCrownSystem.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCrownSystem>.NativeClassPtr, 100669850);
    TutorialCrownSystem.NativeMethodInfoPtr_DeckpackOpen_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCrownSystem>.NativeClassPtr, 100669851);
    TutorialCrownSystem.NativeMethodInfoPtr_DeckpackClose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCrownSystem>.NativeClassPtr, 100669852);
    TutorialCrownSystem.NativeMethodInfoPtr_UpgradeAssign_Private_Void_Entity_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCrownSystem>.NativeClassPtr, 100669853);
    TutorialCrownSystem.NativeMethodInfoPtr_ShowPrompt_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCrownSystem>.NativeClassPtr, 100669854);
    TutorialCrownSystem.NativeMethodInfoPtr_HidePrompt_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCrownSystem>.NativeClassPtr, 100669855);
    TutorialCrownSystem.NativeMethodInfoPtr_CheckPromptSystemReset_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCrownSystem>.NativeClassPtr, 100669856);
    TutorialCrownSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCrownSystem>.NativeClassPtr, 100669857);
  }

  public TutorialCrownSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe bool promptSystemNeedsReset
  {
    get
    {
      bool systemNeedsReset;
      IL2CPP.il2cpp_field_static_get_value(TutorialCrownSystem.NativeFieldInfoPtr_promptSystemNeedsReset, (void*) &systemNeedsReset);
      return systemNeedsReset;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(TutorialCrownSystem.NativeFieldInfoPtr_promptSystemNeedsReset, (void*) &value);
    }
  }

  public unsafe bool deckpackOpen
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCrownSystem.NativeFieldInfoPtr_deckpackOpen));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCrownSystem.NativeFieldInfoPtr_deckpackOpen)) = value;
    }
  }

  public unsafe bool promptShown
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCrownSystem.NativeFieldInfoPtr_promptShown));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCrownSystem.NativeFieldInfoPtr_promptShown)) = value;
    }
  }

  [ObfuscatedName("TutorialCrownSystem/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__8_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ShowPrompt_b__8_0_Internal_String_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialCrownSystem.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialCrownSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80142, XrefRangeEnd = 80148, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _ShowPrompt_b__8_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(TutorialCrownSystem.__c.NativeMethodInfoPtr__ShowPrompt_b__8_0_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static __c()
    {
      Il2CppClassPointerStore<TutorialCrownSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialCrownSystem>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialCrownSystem.__c>.NativeClassPtr);
      TutorialCrownSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCrownSystem.__c>.NativeClassPtr, "<>9");
      TutorialCrownSystem.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCrownSystem.__c>.NativeClassPtr, "<>9__8_0");
      TutorialCrownSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCrownSystem.__c>.NativeClassPtr, 100669859);
      TutorialCrownSystem.__c.NativeMethodInfoPtr__ShowPrompt_b__8_0_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCrownSystem.__c>.NativeClassPtr, 100669860);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe TutorialCrownSystem.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(TutorialCrownSystem.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (TutorialCrownSystem.__c) null : new TutorialCrownSystem.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TutorialCrownSystem.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Prompt.GetTextCallback __9__8_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(TutorialCrownSystem.__c.NativeFieldInfoPtr___9__8_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Prompt.GetTextCallback) null : new Prompt.GetTextCallback(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TutorialCrownSystem.__c.NativeFieldInfoPtr___9__8_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
