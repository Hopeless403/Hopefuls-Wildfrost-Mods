// Decompiled with JetBrains decompiler
// Type: TutorialCharmSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class TutorialCharmSystem : TutorialParentSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_promptSystemNeedsReset;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DeckpackOpen_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DeckpackClose_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckPromptSystemReset_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Done_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79864, XrefRangeEnd = 79890, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialCharmSystem.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79890, XrefRangeEnd = 79910, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialCharmSystem.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79910, XrefRangeEnd = 79950, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DeckpackOpen()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TutorialCharmSystem.NativeMethodInfoPtr_DeckpackOpen_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79950, XrefRangeEnd = 79970, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DeckpackClose()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TutorialCharmSystem.NativeMethodInfoPtr_DeckpackClose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79970, XrefRangeEnd = 79976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CheckPromptSystemReset()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TutorialCharmSystem.NativeMethodInfoPtr_CheckPromptSystemReset_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79976, XrefRangeEnd = 79984, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Done()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TutorialCharmSystem.NativeMethodInfoPtr_Done_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TutorialCharmSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialCharmSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TutorialCharmSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static TutorialCharmSystem()
  {
    Il2CppClassPointerStore<TutorialCharmSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (TutorialCharmSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialCharmSystem>.NativeClassPtr);
    TutorialCharmSystem.NativeFieldInfoPtr_promptSystemNeedsReset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCharmSystem>.NativeClassPtr, nameof (promptSystemNeedsReset));
    TutorialCharmSystem.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCharmSystem>.NativeClassPtr, 100669797);
    TutorialCharmSystem.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCharmSystem>.NativeClassPtr, 100669798);
    TutorialCharmSystem.NativeMethodInfoPtr_DeckpackOpen_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCharmSystem>.NativeClassPtr, 100669799);
    TutorialCharmSystem.NativeMethodInfoPtr_DeckpackClose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCharmSystem>.NativeClassPtr, 100669800);
    TutorialCharmSystem.NativeMethodInfoPtr_CheckPromptSystemReset_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCharmSystem>.NativeClassPtr, 100669801);
    TutorialCharmSystem.NativeMethodInfoPtr_Done_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCharmSystem>.NativeClassPtr, 100669802);
    TutorialCharmSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCharmSystem>.NativeClassPtr, 100669803);
  }

  public TutorialCharmSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe bool promptSystemNeedsReset
  {
    get
    {
      bool systemNeedsReset;
      IL2CPP.il2cpp_field_static_get_value(TutorialCharmSystem.NativeFieldInfoPtr_promptSystemNeedsReset, (void*) &systemNeedsReset);
      return systemNeedsReset;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(TutorialCharmSystem.NativeFieldInfoPtr_promptSystemNeedsReset, (void*) &value);
    }
  }

  public class PhaseEquipCharm : TutorialParentSystem.Phase
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpgradeAssign_Private_Void_Entity_CardUpgradeData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PromptAfterDelay_Private_IEnumerator_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79778, XrefRangeEnd = 79792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnEnable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialCharmSystem.PhaseEquipCharm.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79792, XrefRangeEnd = 79801, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialCharmSystem.PhaseEquipCharm.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void UpgradeAssign(Entity entity, CardUpgradeData upgradeData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) upgradeData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialCharmSystem.PhaseEquipCharm.NativeMethodInfoPtr_UpgradeAssign_Private_Void_Entity_CardUpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79801, XrefRangeEnd = 79806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IEnumerator PromptAfterDelay(float delay)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &delay
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialCharmSystem.PhaseEquipCharm.NativeMethodInfoPtr_PromptAfterDelay_Private_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
    }

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PhaseEquipCharm()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialCharmSystem.PhaseEquipCharm>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialCharmSystem.PhaseEquipCharm.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PhaseEquipCharm()
    {
      Il2CppClassPointerStore<TutorialCharmSystem.PhaseEquipCharm>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialCharmSystem>.NativeClassPtr, nameof (PhaseEquipCharm));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialCharmSystem.PhaseEquipCharm>.NativeClassPtr);
      TutorialCharmSystem.PhaseEquipCharm.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCharmSystem.PhaseEquipCharm>.NativeClassPtr, 100669804);
      TutorialCharmSystem.PhaseEquipCharm.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCharmSystem.PhaseEquipCharm>.NativeClassPtr, 100669805);
      TutorialCharmSystem.PhaseEquipCharm.NativeMethodInfoPtr_UpgradeAssign_Private_Void_Entity_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCharmSystem.PhaseEquipCharm>.NativeClassPtr, 100669806);
      TutorialCharmSystem.PhaseEquipCharm.NativeMethodInfoPtr_PromptAfterDelay_Private_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCharmSystem.PhaseEquipCharm>.NativeClassPtr, 100669807);
      TutorialCharmSystem.PhaseEquipCharm.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCharmSystem.PhaseEquipCharm>.NativeClassPtr, 100669808);
    }

    public PhaseEquipCharm(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [ObfuscatedName("TutorialCharmSystem/PhaseEquipCharm/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__3_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PromptAfterDelay_b__3_0_Internal_String_0;

      [CallerCount(1959)]
      [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialCharmSystem.PhaseEquipCharm.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TutorialCharmSystem.PhaseEquipCharm.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79756, XrefRangeEnd = 79762, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string _PromptAfterDelay_b__3_0()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(TutorialCharmSystem.PhaseEquipCharm.__c.NativeMethodInfoPtr__PromptAfterDelay_b__3_0_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      static __c()
      {
        Il2CppClassPointerStore<TutorialCharmSystem.PhaseEquipCharm.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialCharmSystem.PhaseEquipCharm>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialCharmSystem.PhaseEquipCharm.__c>.NativeClassPtr);
        TutorialCharmSystem.PhaseEquipCharm.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCharmSystem.PhaseEquipCharm.__c>.NativeClassPtr, "<>9");
        TutorialCharmSystem.PhaseEquipCharm.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCharmSystem.PhaseEquipCharm.__c>.NativeClassPtr, "<>9__3_0");
        TutorialCharmSystem.PhaseEquipCharm.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCharmSystem.PhaseEquipCharm.__c>.NativeClassPtr, 100669810);
        TutorialCharmSystem.PhaseEquipCharm.__c.NativeMethodInfoPtr__PromptAfterDelay_b__3_0_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCharmSystem.PhaseEquipCharm.__c>.NativeClassPtr, 100669811);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe TutorialCharmSystem.PhaseEquipCharm.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TutorialCharmSystem.PhaseEquipCharm.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (TutorialCharmSystem.PhaseEquipCharm.__c) null : new TutorialCharmSystem.PhaseEquipCharm.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TutorialCharmSystem.PhaseEquipCharm.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Prompt.GetTextCallback __9__3_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TutorialCharmSystem.PhaseEquipCharm.__c.NativeFieldInfoPtr___9__3_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Prompt.GetTextCallback) null : new Prompt.GetTextCallback(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TutorialCharmSystem.PhaseEquipCharm.__c.NativeFieldInfoPtr___9__3_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("TutorialCharmSystem/PhaseEquipCharm/<PromptAfterDelay>d__3")]
    public sealed class _PromptAfterDelay_d__3 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
      private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
      private static readonly System.IntPtr NativeFieldInfoPtr_delay;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

      [CallerCount(53)]
      [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe _PromptAfterDelay_d__3(int _param1)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialCharmSystem.PhaseEquipCharm._PromptAfterDelay_d__3>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &_param1
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TutorialCharmSystem.PhaseEquipCharm._PromptAfterDelay_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(12611)]
      [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_IDisposable_Dispose()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TutorialCharmSystem.PhaseEquipCharm._PromptAfterDelay_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79762, XrefRangeEnd = 79772, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool MoveNext()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialCharmSystem.PhaseEquipCharm._PromptAfterDelay_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
      {
        [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialCharmSystem.PhaseEquipCharm._PromptAfterDelay_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79772, XrefRangeEnd = 79778, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_Collections_IEnumerator_Reset()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TutorialCharmSystem.PhaseEquipCharm._PromptAfterDelay_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
      {
        [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialCharmSystem.PhaseEquipCharm._PromptAfterDelay_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
      }

      static _PromptAfterDelay_d__3()
      {
        Il2CppClassPointerStore<TutorialCharmSystem.PhaseEquipCharm._PromptAfterDelay_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialCharmSystem.PhaseEquipCharm>.NativeClassPtr, "<PromptAfterDelay>d__3");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialCharmSystem.PhaseEquipCharm._PromptAfterDelay_d__3>.NativeClassPtr);
        TutorialCharmSystem.PhaseEquipCharm._PromptAfterDelay_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCharmSystem.PhaseEquipCharm._PromptAfterDelay_d__3>.NativeClassPtr, "<>1__state");
        TutorialCharmSystem.PhaseEquipCharm._PromptAfterDelay_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCharmSystem.PhaseEquipCharm._PromptAfterDelay_d__3>.NativeClassPtr, "<>2__current");
        TutorialCharmSystem.PhaseEquipCharm._PromptAfterDelay_d__3.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCharmSystem.PhaseEquipCharm._PromptAfterDelay_d__3>.NativeClassPtr, nameof (delay));
        TutorialCharmSystem.PhaseEquipCharm._PromptAfterDelay_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCharmSystem.PhaseEquipCharm._PromptAfterDelay_d__3>.NativeClassPtr, "<>4__this");
        TutorialCharmSystem.PhaseEquipCharm._PromptAfterDelay_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCharmSystem.PhaseEquipCharm._PromptAfterDelay_d__3>.NativeClassPtr, 100669812);
        TutorialCharmSystem.PhaseEquipCharm._PromptAfterDelay_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCharmSystem.PhaseEquipCharm._PromptAfterDelay_d__3>.NativeClassPtr, 100669813);
        TutorialCharmSystem.PhaseEquipCharm._PromptAfterDelay_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCharmSystem.PhaseEquipCharm._PromptAfterDelay_d__3>.NativeClassPtr, 100669814);
        TutorialCharmSystem.PhaseEquipCharm._PromptAfterDelay_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCharmSystem.PhaseEquipCharm._PromptAfterDelay_d__3>.NativeClassPtr, 100669815);
        TutorialCharmSystem.PhaseEquipCharm._PromptAfterDelay_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCharmSystem.PhaseEquipCharm._PromptAfterDelay_d__3>.NativeClassPtr, 100669816);
        TutorialCharmSystem.PhaseEquipCharm._PromptAfterDelay_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCharmSystem.PhaseEquipCharm._PromptAfterDelay_d__3>.NativeClassPtr, 100669817);
      }

      public _PromptAfterDelay_d__3(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe int __1__state
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCharmSystem.PhaseEquipCharm._PromptAfterDelay_d__3.NativeFieldInfoPtr___1__state));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCharmSystem.PhaseEquipCharm._PromptAfterDelay_d__3.NativeFieldInfoPtr___1__state)) = value;
        }
      }

      public unsafe Il2CppSystem.Object __2__current
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCharmSystem.PhaseEquipCharm._PromptAfterDelay_d__3.NativeFieldInfoPtr___2__current));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialCharmSystem.PhaseEquipCharm._PromptAfterDelay_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe float delay
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCharmSystem.PhaseEquipCharm._PromptAfterDelay_d__3.NativeFieldInfoPtr_delay));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCharmSystem.PhaseEquipCharm._PromptAfterDelay_d__3.NativeFieldInfoPtr_delay)) = value;
        }
      }

      public unsafe TutorialCharmSystem.PhaseEquipCharm __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCharmSystem.PhaseEquipCharm._PromptAfterDelay_d__3.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (TutorialCharmSystem.PhaseEquipCharm) null : new TutorialCharmSystem.PhaseEquipCharm(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialCharmSystem.PhaseEquipCharm._PromptAfterDelay_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }

  public class PhaseCharmEquipped : TutorialParentSystem.Phase
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeckpackClose_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PromptAfterDelay_Private_IEnumerator_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79828, XrefRangeEnd = 79850, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnEnable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialCharmSystem.PhaseCharmEquipped.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79850, XrefRangeEnd = 79859, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialCharmSystem.PhaseCharmEquipped.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void DeckpackClose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialCharmSystem.PhaseCharmEquipped.NativeMethodInfoPtr_DeckpackClose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79859, XrefRangeEnd = 79864, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IEnumerator PromptAfterDelay(float delay)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &delay
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialCharmSystem.PhaseCharmEquipped.NativeMethodInfoPtr_PromptAfterDelay_Private_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
    }

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PhaseCharmEquipped()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialCharmSystem.PhaseCharmEquipped>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialCharmSystem.PhaseCharmEquipped.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PhaseCharmEquipped()
    {
      Il2CppClassPointerStore<TutorialCharmSystem.PhaseCharmEquipped>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialCharmSystem>.NativeClassPtr, nameof (PhaseCharmEquipped));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialCharmSystem.PhaseCharmEquipped>.NativeClassPtr);
      TutorialCharmSystem.PhaseCharmEquipped.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCharmSystem.PhaseCharmEquipped>.NativeClassPtr, 100669818);
      TutorialCharmSystem.PhaseCharmEquipped.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCharmSystem.PhaseCharmEquipped>.NativeClassPtr, 100669819);
      TutorialCharmSystem.PhaseCharmEquipped.NativeMethodInfoPtr_DeckpackClose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCharmSystem.PhaseCharmEquipped>.NativeClassPtr, 100669820);
      TutorialCharmSystem.PhaseCharmEquipped.NativeMethodInfoPtr_PromptAfterDelay_Private_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCharmSystem.PhaseCharmEquipped>.NativeClassPtr, 100669821);
      TutorialCharmSystem.PhaseCharmEquipped.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCharmSystem.PhaseCharmEquipped>.NativeClassPtr, 100669822);
    }

    public PhaseCharmEquipped(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [ObfuscatedName("TutorialCharmSystem/PhaseCharmEquipped/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__3_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PromptAfterDelay_b__3_0_Internal_String_0;

      [CallerCount(1959)]
      [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialCharmSystem.PhaseCharmEquipped.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TutorialCharmSystem.PhaseCharmEquipped.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79806, XrefRangeEnd = 79812, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string _PromptAfterDelay_b__3_0()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(TutorialCharmSystem.PhaseCharmEquipped.__c.NativeMethodInfoPtr__PromptAfterDelay_b__3_0_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      static __c()
      {
        Il2CppClassPointerStore<TutorialCharmSystem.PhaseCharmEquipped.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialCharmSystem.PhaseCharmEquipped>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialCharmSystem.PhaseCharmEquipped.__c>.NativeClassPtr);
        TutorialCharmSystem.PhaseCharmEquipped.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCharmSystem.PhaseCharmEquipped.__c>.NativeClassPtr, "<>9");
        TutorialCharmSystem.PhaseCharmEquipped.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCharmSystem.PhaseCharmEquipped.__c>.NativeClassPtr, "<>9__3_0");
        TutorialCharmSystem.PhaseCharmEquipped.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCharmSystem.PhaseCharmEquipped.__c>.NativeClassPtr, 100669824);
        TutorialCharmSystem.PhaseCharmEquipped.__c.NativeMethodInfoPtr__PromptAfterDelay_b__3_0_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCharmSystem.PhaseCharmEquipped.__c>.NativeClassPtr, 100669825);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe TutorialCharmSystem.PhaseCharmEquipped.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TutorialCharmSystem.PhaseCharmEquipped.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (TutorialCharmSystem.PhaseCharmEquipped.__c) null : new TutorialCharmSystem.PhaseCharmEquipped.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TutorialCharmSystem.PhaseCharmEquipped.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Prompt.GetTextCallback __9__3_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TutorialCharmSystem.PhaseCharmEquipped.__c.NativeFieldInfoPtr___9__3_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Prompt.GetTextCallback) null : new Prompt.GetTextCallback(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TutorialCharmSystem.PhaseCharmEquipped.__c.NativeFieldInfoPtr___9__3_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("TutorialCharmSystem/PhaseCharmEquipped/<PromptAfterDelay>d__3")]
    public sealed class _PromptAfterDelay_d__3 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
      private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
      private static readonly System.IntPtr NativeFieldInfoPtr_delay;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

      [CallerCount(53)]
      [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe _PromptAfterDelay_d__3(int _param1)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialCharmSystem.PhaseCharmEquipped._PromptAfterDelay_d__3>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &_param1
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TutorialCharmSystem.PhaseCharmEquipped._PromptAfterDelay_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(12611)]
      [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_IDisposable_Dispose()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TutorialCharmSystem.PhaseCharmEquipped._PromptAfterDelay_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79812, XrefRangeEnd = 79822, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool MoveNext()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialCharmSystem.PhaseCharmEquipped._PromptAfterDelay_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
      {
        [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialCharmSystem.PhaseCharmEquipped._PromptAfterDelay_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79822, XrefRangeEnd = 79828, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_Collections_IEnumerator_Reset()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TutorialCharmSystem.PhaseCharmEquipped._PromptAfterDelay_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
      {
        [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialCharmSystem.PhaseCharmEquipped._PromptAfterDelay_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
      }

      static _PromptAfterDelay_d__3()
      {
        Il2CppClassPointerStore<TutorialCharmSystem.PhaseCharmEquipped._PromptAfterDelay_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialCharmSystem.PhaseCharmEquipped>.NativeClassPtr, "<PromptAfterDelay>d__3");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialCharmSystem.PhaseCharmEquipped._PromptAfterDelay_d__3>.NativeClassPtr);
        TutorialCharmSystem.PhaseCharmEquipped._PromptAfterDelay_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCharmSystem.PhaseCharmEquipped._PromptAfterDelay_d__3>.NativeClassPtr, "<>1__state");
        TutorialCharmSystem.PhaseCharmEquipped._PromptAfterDelay_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCharmSystem.PhaseCharmEquipped._PromptAfterDelay_d__3>.NativeClassPtr, "<>2__current");
        TutorialCharmSystem.PhaseCharmEquipped._PromptAfterDelay_d__3.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCharmSystem.PhaseCharmEquipped._PromptAfterDelay_d__3>.NativeClassPtr, nameof (delay));
        TutorialCharmSystem.PhaseCharmEquipped._PromptAfterDelay_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCharmSystem.PhaseCharmEquipped._PromptAfterDelay_d__3>.NativeClassPtr, "<>4__this");
        TutorialCharmSystem.PhaseCharmEquipped._PromptAfterDelay_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCharmSystem.PhaseCharmEquipped._PromptAfterDelay_d__3>.NativeClassPtr, 100669826);
        TutorialCharmSystem.PhaseCharmEquipped._PromptAfterDelay_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCharmSystem.PhaseCharmEquipped._PromptAfterDelay_d__3>.NativeClassPtr, 100669827);
        TutorialCharmSystem.PhaseCharmEquipped._PromptAfterDelay_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCharmSystem.PhaseCharmEquipped._PromptAfterDelay_d__3>.NativeClassPtr, 100669828);
        TutorialCharmSystem.PhaseCharmEquipped._PromptAfterDelay_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCharmSystem.PhaseCharmEquipped._PromptAfterDelay_d__3>.NativeClassPtr, 100669829);
        TutorialCharmSystem.PhaseCharmEquipped._PromptAfterDelay_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCharmSystem.PhaseCharmEquipped._PromptAfterDelay_d__3>.NativeClassPtr, 100669830);
        TutorialCharmSystem.PhaseCharmEquipped._PromptAfterDelay_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCharmSystem.PhaseCharmEquipped._PromptAfterDelay_d__3>.NativeClassPtr, 100669831);
      }

      public _PromptAfterDelay_d__3(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe int __1__state
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCharmSystem.PhaseCharmEquipped._PromptAfterDelay_d__3.NativeFieldInfoPtr___1__state));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCharmSystem.PhaseCharmEquipped._PromptAfterDelay_d__3.NativeFieldInfoPtr___1__state)) = value;
        }
      }

      public unsafe Il2CppSystem.Object __2__current
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCharmSystem.PhaseCharmEquipped._PromptAfterDelay_d__3.NativeFieldInfoPtr___2__current));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialCharmSystem.PhaseCharmEquipped._PromptAfterDelay_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe float delay
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCharmSystem.PhaseCharmEquipped._PromptAfterDelay_d__3.NativeFieldInfoPtr_delay));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCharmSystem.PhaseCharmEquipped._PromptAfterDelay_d__3.NativeFieldInfoPtr_delay)) = value;
        }
      }

      public unsafe TutorialCharmSystem.PhaseCharmEquipped __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCharmSystem.PhaseCharmEquipped._PromptAfterDelay_d__3.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (TutorialCharmSystem.PhaseCharmEquipped) null : new TutorialCharmSystem.PhaseCharmEquipped(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialCharmSystem.PhaseCharmEquipped._PromptAfterDelay_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }

  [ObfuscatedName("TutorialCharmSystem/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__DeckpackOpen_b__3_0_Internal_Boolean_CardUpgradeData_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialCharmSystem.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialCharmSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _DeckpackOpen_b__3_0(CardUpgradeData a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialCharmSystem.__c.NativeMethodInfoPtr__DeckpackOpen_b__3_0_Internal_Boolean_CardUpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<TutorialCharmSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialCharmSystem>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialCharmSystem.__c>.NativeClassPtr);
      TutorialCharmSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCharmSystem.__c>.NativeClassPtr, "<>9");
      TutorialCharmSystem.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCharmSystem.__c>.NativeClassPtr, "<>9__3_0");
      TutorialCharmSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCharmSystem.__c>.NativeClassPtr, 100669833);
      TutorialCharmSystem.__c.NativeMethodInfoPtr__DeckpackOpen_b__3_0_Internal_Boolean_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCharmSystem.__c>.NativeClassPtr, 100669834);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe TutorialCharmSystem.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(TutorialCharmSystem.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (TutorialCharmSystem.__c) null : new TutorialCharmSystem.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TutorialCharmSystem.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CardUpgradeData, bool> __9__3_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(TutorialCharmSystem.__c.NativeFieldInfoPtr___9__3_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardUpgradeData, bool>) null : new Il2CppSystem.Func<CardUpgradeData, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TutorialCharmSystem.__c.NativeFieldInfoPtr___9__3_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
