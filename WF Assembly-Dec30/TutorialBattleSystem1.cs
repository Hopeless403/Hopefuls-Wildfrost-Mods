// Decompiled with JetBrains decompiler
// Type: TutorialBattleSystem1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class TutorialBattleSystem1 : TutorialBattleSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_startingHand;
  private static readonly System.IntPtr NativeMethodInfoPtr_BattleStart_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FindLastUnit_Private_Static_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BattleEnd_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78346, XrefRangeEnd = 78466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void BattleStart()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem1.NativeMethodInfoPtr_BattleStart_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 78551, RefRangeEnd = 78552, XrefRangeStart = 78466, XrefRangeEnd = 78551, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Entity FindLastUnit()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.NativeMethodInfoPtr_FindLastUnit_Private_Static_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78552, XrefRangeEnd = 78559, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void BattleEnd()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem1.NativeMethodInfoPtr_BattleEnd_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TutorialBattleSystem1()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem1>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static TutorialBattleSystem1()
  {
    Il2CppClassPointerStore<TutorialBattleSystem1>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (TutorialBattleSystem1));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem1>.NativeClassPtr);
    TutorialBattleSystem1.NativeFieldInfoPtr_startingHand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem1>.NativeClassPtr, nameof (startingHand));
    TutorialBattleSystem1.NativeMethodInfoPtr_BattleStart_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1>.NativeClassPtr, 100669560);
    TutorialBattleSystem1.NativeMethodInfoPtr_FindLastUnit_Private_Static_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1>.NativeClassPtr, 100669561);
    TutorialBattleSystem1.NativeMethodInfoPtr_BattleEnd_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1>.NativeClassPtr, 100669562);
    TutorialBattleSystem1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1>.NativeClassPtr, 100669563);
  }

  public TutorialBattleSystem1(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe Il2CppStringArray startingHand
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(TutorialBattleSystem1.NativeFieldInfoPtr_startingHand, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppStringArray) null : new Il2CppStringArray(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(TutorialBattleSystem1.NativeFieldInfoPtr_startingHand, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public class PhasePlaceLeader : TutorialParentSystem.Phase
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EntityMove_Private_Void_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PromptAfter_Private_IEnumerator_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77753, XrefRangeEnd = 77770, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnEnable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem1.PhasePlaceLeader.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77770, XrefRangeEnd = 77779, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem1.PhasePlaceLeader.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77779, XrefRangeEnd = 77786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void EntityMove(Entity entity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhasePlaceLeader.NativeMethodInfoPtr_EntityMove_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77786, XrefRangeEnd = 77791, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IEnumerator PromptAfter(float delay)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &delay
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhasePlaceLeader.NativeMethodInfoPtr_PromptAfter_Private_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
    }

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PhasePlaceLeader()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem1.PhasePlaceLeader>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhasePlaceLeader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PhasePlaceLeader()
    {
      Il2CppClassPointerStore<TutorialBattleSystem1.PhasePlaceLeader>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialBattleSystem1>.NativeClassPtr, nameof (PhasePlaceLeader));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem1.PhasePlaceLeader>.NativeClassPtr);
      TutorialBattleSystem1.PhasePlaceLeader.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhasePlaceLeader>.NativeClassPtr, 100669565);
      TutorialBattleSystem1.PhasePlaceLeader.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhasePlaceLeader>.NativeClassPtr, 100669566);
      TutorialBattleSystem1.PhasePlaceLeader.NativeMethodInfoPtr_EntityMove_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhasePlaceLeader>.NativeClassPtr, 100669567);
      TutorialBattleSystem1.PhasePlaceLeader.NativeMethodInfoPtr_PromptAfter_Private_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhasePlaceLeader>.NativeClassPtr, 100669568);
      TutorialBattleSystem1.PhasePlaceLeader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhasePlaceLeader>.NativeClassPtr, 100669569);
    }

    public PhasePlaceLeader(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [ObfuscatedName("TutorialBattleSystem1/PhasePlaceLeader/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__3_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PromptAfter_b__3_0_Internal_String_0;

      [CallerCount(1959)]
      [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem1.PhasePlaceLeader.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhasePlaceLeader.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77733, XrefRangeEnd = 77739, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string _PromptAfter_b__3_0()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhasePlaceLeader.__c.NativeMethodInfoPtr__PromptAfter_b__3_0_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      static __c()
      {
        Il2CppClassPointerStore<TutorialBattleSystem1.PhasePlaceLeader.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialBattleSystem1.PhasePlaceLeader>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem1.PhasePlaceLeader.__c>.NativeClassPtr);
        TutorialBattleSystem1.PhasePlaceLeader.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem1.PhasePlaceLeader.__c>.NativeClassPtr, "<>9");
        TutorialBattleSystem1.PhasePlaceLeader.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem1.PhasePlaceLeader.__c>.NativeClassPtr, "<>9__3_0");
        TutorialBattleSystem1.PhasePlaceLeader.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhasePlaceLeader.__c>.NativeClassPtr, 100669571);
        TutorialBattleSystem1.PhasePlaceLeader.__c.NativeMethodInfoPtr__PromptAfter_b__3_0_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhasePlaceLeader.__c>.NativeClassPtr, 100669572);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe TutorialBattleSystem1.PhasePlaceLeader.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TutorialBattleSystem1.PhasePlaceLeader.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (TutorialBattleSystem1.PhasePlaceLeader.__c) null : new TutorialBattleSystem1.PhasePlaceLeader.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TutorialBattleSystem1.PhasePlaceLeader.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Prompt.GetTextCallback __9__3_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TutorialBattleSystem1.PhasePlaceLeader.__c.NativeFieldInfoPtr___9__3_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Prompt.GetTextCallback) null : new Prompt.GetTextCallback(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TutorialBattleSystem1.PhasePlaceLeader.__c.NativeFieldInfoPtr___9__3_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("TutorialBattleSystem1/PhasePlaceLeader/<PromptAfter>d__3")]
    public sealed class _PromptAfter_d__3 : Il2CppSystem.Object
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
      public unsafe _PromptAfter_d__3(int _param1)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem1.PhasePlaceLeader._PromptAfter_d__3>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &_param1
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhasePlaceLeader._PromptAfter_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(12611)]
      [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_IDisposable_Dispose()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhasePlaceLeader._PromptAfter_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77739, XrefRangeEnd = 77747, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool MoveNext()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhasePlaceLeader._PromptAfter_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhasePlaceLeader._PromptAfter_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77747, XrefRangeEnd = 77753, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_Collections_IEnumerator_Reset()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhasePlaceLeader._PromptAfter_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
      {
        [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhasePlaceLeader._PromptAfter_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
      }

      static _PromptAfter_d__3()
      {
        Il2CppClassPointerStore<TutorialBattleSystem1.PhasePlaceLeader._PromptAfter_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialBattleSystem1.PhasePlaceLeader>.NativeClassPtr, "<PromptAfter>d__3");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem1.PhasePlaceLeader._PromptAfter_d__3>.NativeClassPtr);
        TutorialBattleSystem1.PhasePlaceLeader._PromptAfter_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem1.PhasePlaceLeader._PromptAfter_d__3>.NativeClassPtr, "<>1__state");
        TutorialBattleSystem1.PhasePlaceLeader._PromptAfter_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem1.PhasePlaceLeader._PromptAfter_d__3>.NativeClassPtr, "<>2__current");
        TutorialBattleSystem1.PhasePlaceLeader._PromptAfter_d__3.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem1.PhasePlaceLeader._PromptAfter_d__3>.NativeClassPtr, nameof (delay));
        TutorialBattleSystem1.PhasePlaceLeader._PromptAfter_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem1.PhasePlaceLeader._PromptAfter_d__3>.NativeClassPtr, "<>4__this");
        TutorialBattleSystem1.PhasePlaceLeader._PromptAfter_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhasePlaceLeader._PromptAfter_d__3>.NativeClassPtr, 100669573);
        TutorialBattleSystem1.PhasePlaceLeader._PromptAfter_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhasePlaceLeader._PromptAfter_d__3>.NativeClassPtr, 100669574);
        TutorialBattleSystem1.PhasePlaceLeader._PromptAfter_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhasePlaceLeader._PromptAfter_d__3>.NativeClassPtr, 100669575);
        TutorialBattleSystem1.PhasePlaceLeader._PromptAfter_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhasePlaceLeader._PromptAfter_d__3>.NativeClassPtr, 100669576);
        TutorialBattleSystem1.PhasePlaceLeader._PromptAfter_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhasePlaceLeader._PromptAfter_d__3>.NativeClassPtr, 100669577);
        TutorialBattleSystem1.PhasePlaceLeader._PromptAfter_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhasePlaceLeader._PromptAfter_d__3>.NativeClassPtr, 100669578);
      }

      public _PromptAfter_d__3(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe int __1__state
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem1.PhasePlaceLeader._PromptAfter_d__3.NativeFieldInfoPtr___1__state));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem1.PhasePlaceLeader._PromptAfter_d__3.NativeFieldInfoPtr___1__state)) = value;
        }
      }

      public unsafe Il2CppSystem.Object __2__current
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem1.PhasePlaceLeader._PromptAfter_d__3.NativeFieldInfoPtr___2__current));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem1.PhasePlaceLeader._PromptAfter_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe float delay
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem1.PhasePlaceLeader._PromptAfter_d__3.NativeFieldInfoPtr_delay));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem1.PhasePlaceLeader._PromptAfter_d__3.NativeFieldInfoPtr_delay)) = value;
        }
      }

      public unsafe TutorialBattleSystem1.PhasePlaceLeader __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem1.PhasePlaceLeader._PromptAfter_d__3.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (TutorialBattleSystem1.PhasePlaceLeader) null : new TutorialBattleSystem1.PhasePlaceLeader(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem1.PhasePlaceLeader._PromptAfter_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }

  public class PhasePlaceCompanion : TutorialParentSystem.Phase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_target;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_delay_Public_Virtual_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CardData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckAction_Private_Void_byref_PlayAction_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BattleTurnStart_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CorrectAction_Private_Boolean_PlayAction_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnEnable_b__4_0_Private_String_0;

    public override unsafe float delay
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem1.PhasePlaceCompanion.NativeMethodInfoPtr_get_delay_Public_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 77793, RefRangeEnd = 77796, XrefRangeStart = 77791, XrefRangeEnd = 77793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PhasePlaceCompanion(CardData target)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem1.PhasePlaceCompanion>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhasePlaceCompanion.NativeMethodInfoPtr__ctor_Public_Void_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77796, XrefRangeEnd = 77819, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnEnable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem1.PhasePlaceCompanion.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77819, XrefRangeEnd = 77835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem1.PhasePlaceCompanion.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77835, XrefRangeEnd = 77849, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CheckAction(ref PlayAction action, ref bool allow)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref allow;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhasePlaceCompanion.NativeMethodInfoPtr_CheckAction_Private_Void_byref_PlayAction_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref PlayAction local = ref action;
      System.IntPtr pointer = ptr;
      PlayAction playAction = pointer == System.IntPtr.Zero ? (PlayAction) null : new PlayAction(pointer);
      local = playAction;
    }

    [CallerCount(0)]
    public unsafe void BattleTurnStart(int turn)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &turn
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhasePlaceCompanion.NativeMethodInfoPtr_BattleTurnStart_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77849, XrefRangeEnd = 77855, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool CorrectAction(PlayAction action)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhasePlaceCompanion.NativeMethodInfoPtr_CorrectAction_Private_Boolean_PlayAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77855, XrefRangeEnd = 77863, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _OnEnable_b__4_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhasePlaceCompanion.NativeMethodInfoPtr__OnEnable_b__4_0_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static PhasePlaceCompanion()
    {
      Il2CppClassPointerStore<TutorialBattleSystem1.PhasePlaceCompanion>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialBattleSystem1>.NativeClassPtr, nameof (PhasePlaceCompanion));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem1.PhasePlaceCompanion>.NativeClassPtr);
      TutorialBattleSystem1.PhasePlaceCompanion.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem1.PhasePlaceCompanion>.NativeClassPtr, nameof (target));
      TutorialBattleSystem1.PhasePlaceCompanion.NativeMethodInfoPtr_get_delay_Public_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhasePlaceCompanion>.NativeClassPtr, 100669579);
      TutorialBattleSystem1.PhasePlaceCompanion.NativeMethodInfoPtr__ctor_Public_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhasePlaceCompanion>.NativeClassPtr, 100669580);
      TutorialBattleSystem1.PhasePlaceCompanion.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhasePlaceCompanion>.NativeClassPtr, 100669581);
      TutorialBattleSystem1.PhasePlaceCompanion.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhasePlaceCompanion>.NativeClassPtr, 100669582);
      TutorialBattleSystem1.PhasePlaceCompanion.NativeMethodInfoPtr_CheckAction_Private_Void_byref_PlayAction_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhasePlaceCompanion>.NativeClassPtr, 100669583);
      TutorialBattleSystem1.PhasePlaceCompanion.NativeMethodInfoPtr_BattleTurnStart_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhasePlaceCompanion>.NativeClassPtr, 100669584);
      TutorialBattleSystem1.PhasePlaceCompanion.NativeMethodInfoPtr_CorrectAction_Private_Boolean_PlayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhasePlaceCompanion>.NativeClassPtr, 100669585);
      TutorialBattleSystem1.PhasePlaceCompanion.NativeMethodInfoPtr__OnEnable_b__4_0_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhasePlaceCompanion>.NativeClassPtr, 100669586);
    }

    public PhasePlaceCompanion(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CardData target
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem1.PhasePlaceCompanion.NativeFieldInfoPtr_target));
        return pointer == System.IntPtr.Zero ? (CardData) null : new CardData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem1.PhasePlaceCompanion.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public class PhaseUseItem : TutorialParentSystem.Phase
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_get_delay_Public_Virtual_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckAction_Private_Void_byref_PlayAction_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BattleTurnStart_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CorrectAction_Private_Boolean_PlayAction_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public override unsafe float delay
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem1.PhaseUseItem.NativeMethodInfoPtr_get_delay_Public_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77869, XrefRangeEnd = 77901, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnEnable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem1.PhaseUseItem.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77901, XrefRangeEnd = 77917, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem1.PhaseUseItem.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77917, XrefRangeEnd = 77934, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CheckAction(ref PlayAction action, ref bool allow)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref allow;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseUseItem.NativeMethodInfoPtr_CheckAction_Private_Void_byref_PlayAction_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref PlayAction local = ref action;
      System.IntPtr pointer = ptr;
      PlayAction playAction = pointer == System.IntPtr.Zero ? (PlayAction) null : new PlayAction(pointer);
      local = playAction;
    }

    [CallerCount(0)]
    public unsafe void BattleTurnStart(int turn)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &turn
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseUseItem.NativeMethodInfoPtr_BattleTurnStart_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77934, XrefRangeEnd = 77944, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool CorrectAction(PlayAction action)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseUseItem.NativeMethodInfoPtr_CorrectAction_Private_Boolean_PlayAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PhaseUseItem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseUseItem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseUseItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PhaseUseItem()
    {
      Il2CppClassPointerStore<TutorialBattleSystem1.PhaseUseItem>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialBattleSystem1>.NativeClassPtr, nameof (PhaseUseItem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseUseItem>.NativeClassPtr);
      TutorialBattleSystem1.PhaseUseItem.NativeMethodInfoPtr_get_delay_Public_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseUseItem>.NativeClassPtr, 100669587);
      TutorialBattleSystem1.PhaseUseItem.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseUseItem>.NativeClassPtr, 100669588);
      TutorialBattleSystem1.PhaseUseItem.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseUseItem>.NativeClassPtr, 100669589);
      TutorialBattleSystem1.PhaseUseItem.NativeMethodInfoPtr_CheckAction_Private_Void_byref_PlayAction_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseUseItem>.NativeClassPtr, 100669590);
      TutorialBattleSystem1.PhaseUseItem.NativeMethodInfoPtr_BattleTurnStart_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseUseItem>.NativeClassPtr, 100669591);
      TutorialBattleSystem1.PhaseUseItem.NativeMethodInfoPtr_CorrectAction_Private_Boolean_PlayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseUseItem>.NativeClassPtr, 100669592);
      TutorialBattleSystem1.PhaseUseItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseUseItem>.NativeClassPtr, 100669593);
    }

    public PhaseUseItem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [ObfuscatedName("TutorialBattleSystem1/PhaseUseItem/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnEnable_b__2_0_Internal_String_0;

      [CallerCount(1959)]
      [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseUseItem.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseUseItem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77863, XrefRangeEnd = 77869, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string _OnEnable_b__2_0()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseUseItem.__c.NativeMethodInfoPtr__OnEnable_b__2_0_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      static __c()
      {
        Il2CppClassPointerStore<TutorialBattleSystem1.PhaseUseItem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseUseItem>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseUseItem.__c>.NativeClassPtr);
        TutorialBattleSystem1.PhaseUseItem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseUseItem.__c>.NativeClassPtr, "<>9");
        TutorialBattleSystem1.PhaseUseItem.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseUseItem.__c>.NativeClassPtr, "<>9__2_0");
        TutorialBattleSystem1.PhaseUseItem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseUseItem.__c>.NativeClassPtr, 100669595);
        TutorialBattleSystem1.PhaseUseItem.__c.NativeMethodInfoPtr__OnEnable_b__2_0_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseUseItem.__c>.NativeClassPtr, 100669596);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe TutorialBattleSystem1.PhaseUseItem.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TutorialBattleSystem1.PhaseUseItem.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (TutorialBattleSystem1.PhaseUseItem.__c) null : new TutorialBattleSystem1.PhaseUseItem.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TutorialBattleSystem1.PhaseUseItem.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Prompt.GetTextCallback __9__2_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TutorialBattleSystem1.PhaseUseItem.__c.NativeFieldInfoPtr___9__2_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Prompt.GetTextCallback) null : new Prompt.GetTextCallback(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TutorialBattleSystem1.PhaseUseItem.__c.NativeFieldInfoPtr___9__2_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }

  public class PhaseCounters : TutorialParentSystem.Phase
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_get_delay_Public_Virtual_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BattleTurnStart_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public override unsafe float delay
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem1.PhaseCounters.NativeMethodInfoPtr_get_delay_Public_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77950, XrefRangeEnd = 77975, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnEnable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem1.PhaseCounters.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77975, XrefRangeEnd = 77984, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem1.PhaseCounters.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void BattleTurnStart(int turn)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &turn
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseCounters.NativeMethodInfoPtr_BattleTurnStart_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PhaseCounters()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseCounters>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseCounters.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PhaseCounters()
    {
      Il2CppClassPointerStore<TutorialBattleSystem1.PhaseCounters>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialBattleSystem1>.NativeClassPtr, nameof (PhaseCounters));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseCounters>.NativeClassPtr);
      TutorialBattleSystem1.PhaseCounters.NativeMethodInfoPtr_get_delay_Public_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseCounters>.NativeClassPtr, 100669597);
      TutorialBattleSystem1.PhaseCounters.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseCounters>.NativeClassPtr, 100669598);
      TutorialBattleSystem1.PhaseCounters.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseCounters>.NativeClassPtr, 100669599);
      TutorialBattleSystem1.PhaseCounters.NativeMethodInfoPtr_BattleTurnStart_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseCounters>.NativeClassPtr, 100669600);
      TutorialBattleSystem1.PhaseCounters.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseCounters>.NativeClassPtr, 100669601);
    }

    public PhaseCounters(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [ObfuscatedName("TutorialBattleSystem1/PhaseCounters/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnEnable_b__2_0_Internal_String_0;

      [CallerCount(1959)]
      [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseCounters.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseCounters.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77944, XrefRangeEnd = 77950, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string _OnEnable_b__2_0()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseCounters.__c.NativeMethodInfoPtr__OnEnable_b__2_0_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      static __c()
      {
        Il2CppClassPointerStore<TutorialBattleSystem1.PhaseCounters.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseCounters>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseCounters.__c>.NativeClassPtr);
        TutorialBattleSystem1.PhaseCounters.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseCounters.__c>.NativeClassPtr, "<>9");
        TutorialBattleSystem1.PhaseCounters.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseCounters.__c>.NativeClassPtr, "<>9__2_0");
        TutorialBattleSystem1.PhaseCounters.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseCounters.__c>.NativeClassPtr, 100669603);
        TutorialBattleSystem1.PhaseCounters.__c.NativeMethodInfoPtr__OnEnable_b__2_0_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseCounters.__c>.NativeClassPtr, 100669604);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe TutorialBattleSystem1.PhaseCounters.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TutorialBattleSystem1.PhaseCounters.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (TutorialBattleSystem1.PhaseCounters.__c) null : new TutorialBattleSystem1.PhaseCounters.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TutorialBattleSystem1.PhaseCounters.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Prompt.GetTextCallback __9__2_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TutorialBattleSystem1.PhaseCounters.__c.NativeFieldInfoPtr___9__2_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Prompt.GetTextCallback) null : new Prompt.GetTextCallback(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TutorialBattleSystem1.PhaseCounters.__c.NativeFieldInfoPtr___9__2_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }

  public class PhaseEnemiesAttackFirst : TutorialParentSystem.Phase
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_get_delay_Public_Virtual_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BattlePhaseStart_Private_Static_Void_Phase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BattleTurnStart_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public override unsafe float delay
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 77990, RefRangeEnd = 77991, XrefRangeStart = 77990, XrefRangeEnd = 77990, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem1.PhaseEnemiesAttackFirst.NativeMethodInfoPtr_get_delay_Public_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77991, XrefRangeEnd = 78006, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnEnable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem1.PhaseEnemiesAttackFirst.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78006, XrefRangeEnd = 78022, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem1.PhaseEnemiesAttackFirst.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78022, XrefRangeEnd = 78039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void BattlePhaseStart(Battle.Phase phase)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &phase
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseEnemiesAttackFirst.NativeMethodInfoPtr_BattlePhaseStart_Private_Static_Void_Phase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void BattleTurnStart(int turn)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &turn
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseEnemiesAttackFirst.NativeMethodInfoPtr_BattleTurnStart_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PhaseEnemiesAttackFirst()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseEnemiesAttackFirst>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseEnemiesAttackFirst.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PhaseEnemiesAttackFirst()
    {
      Il2CppClassPointerStore<TutorialBattleSystem1.PhaseEnemiesAttackFirst>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialBattleSystem1>.NativeClassPtr, nameof (PhaseEnemiesAttackFirst));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseEnemiesAttackFirst>.NativeClassPtr);
      TutorialBattleSystem1.PhaseEnemiesAttackFirst.NativeMethodInfoPtr_get_delay_Public_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseEnemiesAttackFirst>.NativeClassPtr, 100669605);
      TutorialBattleSystem1.PhaseEnemiesAttackFirst.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseEnemiesAttackFirst>.NativeClassPtr, 100669606);
      TutorialBattleSystem1.PhaseEnemiesAttackFirst.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseEnemiesAttackFirst>.NativeClassPtr, 100669607);
      TutorialBattleSystem1.PhaseEnemiesAttackFirst.NativeMethodInfoPtr_BattlePhaseStart_Private_Static_Void_Phase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseEnemiesAttackFirst>.NativeClassPtr, 100669608);
      TutorialBattleSystem1.PhaseEnemiesAttackFirst.NativeMethodInfoPtr_BattleTurnStart_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseEnemiesAttackFirst>.NativeClassPtr, 100669609);
      TutorialBattleSystem1.PhaseEnemiesAttackFirst.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseEnemiesAttackFirst>.NativeClassPtr, 100669610);
    }

    public PhaseEnemiesAttackFirst(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [ObfuscatedName("TutorialBattleSystem1/PhaseEnemiesAttackFirst/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__4_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__BattlePhaseStart_b__4_0_Internal_String_0;

      [CallerCount(1959)]
      [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseEnemiesAttackFirst.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseEnemiesAttackFirst.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77984, XrefRangeEnd = 77990, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string _BattlePhaseStart_b__4_0()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseEnemiesAttackFirst.__c.NativeMethodInfoPtr__BattlePhaseStart_b__4_0_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      static __c()
      {
        Il2CppClassPointerStore<TutorialBattleSystem1.PhaseEnemiesAttackFirst.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseEnemiesAttackFirst>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseEnemiesAttackFirst.__c>.NativeClassPtr);
        TutorialBattleSystem1.PhaseEnemiesAttackFirst.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseEnemiesAttackFirst.__c>.NativeClassPtr, "<>9");
        TutorialBattleSystem1.PhaseEnemiesAttackFirst.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseEnemiesAttackFirst.__c>.NativeClassPtr, "<>9__4_0");
        TutorialBattleSystem1.PhaseEnemiesAttackFirst.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseEnemiesAttackFirst.__c>.NativeClassPtr, 100669612);
        TutorialBattleSystem1.PhaseEnemiesAttackFirst.__c.NativeMethodInfoPtr__BattlePhaseStart_b__4_0_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseEnemiesAttackFirst.__c>.NativeClassPtr, 100669613);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe TutorialBattleSystem1.PhaseEnemiesAttackFirst.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TutorialBattleSystem1.PhaseEnemiesAttackFirst.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (TutorialBattleSystem1.PhaseEnemiesAttackFirst.__c) null : new TutorialBattleSystem1.PhaseEnemiesAttackFirst.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TutorialBattleSystem1.PhaseEnemiesAttackFirst.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Prompt.GetTextCallback __9__4_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TutorialBattleSystem1.PhaseEnemiesAttackFirst.__c.NativeFieldInfoPtr___9__4_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Prompt.GetTextCallback) null : new Prompt.GetTextCallback(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TutorialBattleSystem1.PhaseEnemiesAttackFirst.__c.NativeFieldInfoPtr___9__4_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }

  public class PhaseWaitForNewEnemies : TutorialParentSystem.Phase
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ActionPerform_Private_Void_PlayAction_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78039, XrefRangeEnd = 78047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnEnable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem1.PhaseWaitForNewEnemies.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78047, XrefRangeEnd = 78055, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem1.PhaseWaitForNewEnemies.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78055, XrefRangeEnd = 78063, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ActionPerform(PlayAction action)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseWaitForNewEnemies.NativeMethodInfoPtr_ActionPerform_Private_Void_PlayAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PhaseWaitForNewEnemies()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseWaitForNewEnemies>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseWaitForNewEnemies.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PhaseWaitForNewEnemies()
    {
      Il2CppClassPointerStore<TutorialBattleSystem1.PhaseWaitForNewEnemies>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialBattleSystem1>.NativeClassPtr, nameof (PhaseWaitForNewEnemies));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseWaitForNewEnemies>.NativeClassPtr);
      TutorialBattleSystem1.PhaseWaitForNewEnemies.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseWaitForNewEnemies>.NativeClassPtr, 100669614);
      TutorialBattleSystem1.PhaseWaitForNewEnemies.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseWaitForNewEnemies>.NativeClassPtr, 100669615);
      TutorialBattleSystem1.PhaseWaitForNewEnemies.NativeMethodInfoPtr_ActionPerform_Private_Void_PlayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseWaitForNewEnemies>.NativeClassPtr, 100669616);
      TutorialBattleSystem1.PhaseWaitForNewEnemies.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseWaitForNewEnemies>.NativeClassPtr, 100669617);
    }

    public PhaseWaitForNewEnemies(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }

  public class PhaseRedrawBell : TutorialParentSystem.Phase
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_get_delay_Public_Virtual_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckAction_Private_Static_Void_byref_PlayAction_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ActionPerform_Private_Void_PlayAction_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CorrectAction_Private_Static_Boolean_PlayAction_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PlayCardAction_Private_Static_Boolean_PlayAction_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public override unsafe float delay
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem1.PhaseRedrawBell.NativeMethodInfoPtr_get_delay_Public_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78069, XrefRangeEnd = 78109, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnEnable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem1.PhaseRedrawBell.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78109, XrefRangeEnd = 78125, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem1.PhaseRedrawBell.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78125, XrefRangeEnd = 78135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CheckAction(ref PlayAction action, ref bool allow)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref allow;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseRedrawBell.NativeMethodInfoPtr_CheckAction_Private_Static_Void_byref_PlayAction_byref_Boolean_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref PlayAction local = ref action;
      System.IntPtr pointer = ptr;
      PlayAction playAction = pointer == System.IntPtr.Zero ? (PlayAction) null : new PlayAction(pointer);
      local = playAction;
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78135, XrefRangeEnd = 78137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ActionPerform(PlayAction action)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseRedrawBell.NativeMethodInfoPtr_ActionPerform_Private_Void_PlayAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78137, XrefRangeEnd = 78138, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CorrectAction(PlayAction action)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseRedrawBell.NativeMethodInfoPtr_CorrectAction_Private_Static_Boolean_PlayAction_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78138, XrefRangeEnd = 78139, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool PlayCardAction(PlayAction action)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseRedrawBell.NativeMethodInfoPtr_PlayCardAction_Private_Static_Boolean_PlayAction_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PhaseRedrawBell()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseRedrawBell>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseRedrawBell.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PhaseRedrawBell()
    {
      Il2CppClassPointerStore<TutorialBattleSystem1.PhaseRedrawBell>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialBattleSystem1>.NativeClassPtr, nameof (PhaseRedrawBell));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseRedrawBell>.NativeClassPtr);
      TutorialBattleSystem1.PhaseRedrawBell.NativeMethodInfoPtr_get_delay_Public_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseRedrawBell>.NativeClassPtr, 100669618);
      TutorialBattleSystem1.PhaseRedrawBell.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseRedrawBell>.NativeClassPtr, 100669619);
      TutorialBattleSystem1.PhaseRedrawBell.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseRedrawBell>.NativeClassPtr, 100669620);
      TutorialBattleSystem1.PhaseRedrawBell.NativeMethodInfoPtr_CheckAction_Private_Static_Void_byref_PlayAction_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseRedrawBell>.NativeClassPtr, 100669621);
      TutorialBattleSystem1.PhaseRedrawBell.NativeMethodInfoPtr_ActionPerform_Private_Void_PlayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseRedrawBell>.NativeClassPtr, 100669622);
      TutorialBattleSystem1.PhaseRedrawBell.NativeMethodInfoPtr_CorrectAction_Private_Static_Boolean_PlayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseRedrawBell>.NativeClassPtr, 100669623);
      TutorialBattleSystem1.PhaseRedrawBell.NativeMethodInfoPtr_PlayCardAction_Private_Static_Boolean_PlayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseRedrawBell>.NativeClassPtr, 100669624);
      TutorialBattleSystem1.PhaseRedrawBell.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseRedrawBell>.NativeClassPtr, 100669625);
    }

    public PhaseRedrawBell(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [ObfuscatedName("TutorialBattleSystem1/PhaseRedrawBell/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnEnable_b__2_0_Internal_String_0;

      [CallerCount(1959)]
      [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseRedrawBell.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseRedrawBell.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78063, XrefRangeEnd = 78069, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string _OnEnable_b__2_0()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseRedrawBell.__c.NativeMethodInfoPtr__OnEnable_b__2_0_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      static __c()
      {
        Il2CppClassPointerStore<TutorialBattleSystem1.PhaseRedrawBell.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseRedrawBell>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseRedrawBell.__c>.NativeClassPtr);
        TutorialBattleSystem1.PhaseRedrawBell.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseRedrawBell.__c>.NativeClassPtr, "<>9");
        TutorialBattleSystem1.PhaseRedrawBell.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseRedrawBell.__c>.NativeClassPtr, "<>9__2_0");
        TutorialBattleSystem1.PhaseRedrawBell.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseRedrawBell.__c>.NativeClassPtr, 100669627);
        TutorialBattleSystem1.PhaseRedrawBell.__c.NativeMethodInfoPtr__OnEnable_b__2_0_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseRedrawBell.__c>.NativeClassPtr, 100669628);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe TutorialBattleSystem1.PhaseRedrawBell.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TutorialBattleSystem1.PhaseRedrawBell.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (TutorialBattleSystem1.PhaseRedrawBell.__c) null : new TutorialBattleSystem1.PhaseRedrawBell.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TutorialBattleSystem1.PhaseRedrawBell.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Prompt.GetTextCallback __9__2_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TutorialBattleSystem1.PhaseRedrawBell.__c.NativeFieldInfoPtr___9__2_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Prompt.GetTextCallback) null : new Prompt.GetTextCallback(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TutorialBattleSystem1.PhaseRedrawBell.__c.NativeFieldInfoPtr___9__2_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }

  public class PhaseRedrawBellPopUp : TutorialParentSystem.Phase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_tutorialSystem;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_delay_Public_Virtual_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Show_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_End_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public override unsafe float delay
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem1.PhaseRedrawBellPopUp.NativeMethodInfoPtr_get_delay_Public_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78139, XrefRangeEnd = 78154, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnEnable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem1.PhaseRedrawBellPopUp.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78154, XrefRangeEnd = 78162, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem1.PhaseRedrawBellPopUp.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78162, XrefRangeEnd = 78178, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Show(int turn)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &turn
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseRedrawBellPopUp.NativeMethodInfoPtr_Show_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void End()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseRedrawBellPopUp.NativeMethodInfoPtr_End_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PhaseRedrawBellPopUp()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseRedrawBellPopUp>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseRedrawBellPopUp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PhaseRedrawBellPopUp()
    {
      Il2CppClassPointerStore<TutorialBattleSystem1.PhaseRedrawBellPopUp>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialBattleSystem1>.NativeClassPtr, nameof (PhaseRedrawBellPopUp));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseRedrawBellPopUp>.NativeClassPtr);
      TutorialBattleSystem1.PhaseRedrawBellPopUp.NativeFieldInfoPtr_tutorialSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseRedrawBellPopUp>.NativeClassPtr, nameof (tutorialSystem));
      TutorialBattleSystem1.PhaseRedrawBellPopUp.NativeMethodInfoPtr_get_delay_Public_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseRedrawBellPopUp>.NativeClassPtr, 100669629);
      TutorialBattleSystem1.PhaseRedrawBellPopUp.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseRedrawBellPopUp>.NativeClassPtr, 100669630);
      TutorialBattleSystem1.PhaseRedrawBellPopUp.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseRedrawBellPopUp>.NativeClassPtr, 100669631);
      TutorialBattleSystem1.PhaseRedrawBellPopUp.NativeMethodInfoPtr_Show_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseRedrawBellPopUp>.NativeClassPtr, 100669632);
      TutorialBattleSystem1.PhaseRedrawBellPopUp.NativeMethodInfoPtr_End_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseRedrawBellPopUp>.NativeClassPtr, 100669633);
      TutorialBattleSystem1.PhaseRedrawBellPopUp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseRedrawBellPopUp>.NativeClassPtr, 100669634);
    }

    public PhaseRedrawBellPopUp(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TutorialSystem tutorialSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem1.PhaseRedrawBellPopUp.NativeFieldInfoPtr_tutorialSystem));
        return pointer == System.IntPtr.Zero ? (TutorialSystem) null : new TutorialSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem1.PhaseRedrawBellPopUp.NativeFieldInfoPtr_tutorialSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public class PhaseProtectLeader : TutorialParentSystem.Phase
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_get_delay_Public_Virtual_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Show_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_End_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public override unsafe float delay
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem1.PhaseProtectLeader.NativeMethodInfoPtr_get_delay_Public_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78184, XrefRangeEnd = 78209, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnEnable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem1.PhaseProtectLeader.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 40865, RefRangeEnd = 40866, XrefRangeStart = 40865, XrefRangeEnd = 40866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem1.PhaseProtectLeader.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Show()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseProtectLeader.NativeMethodInfoPtr_Show_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78209, XrefRangeEnd = 78217, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void End(int turn)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &turn
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseProtectLeader.NativeMethodInfoPtr_End_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PhaseProtectLeader()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseProtectLeader>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseProtectLeader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PhaseProtectLeader()
    {
      Il2CppClassPointerStore<TutorialBattleSystem1.PhaseProtectLeader>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialBattleSystem1>.NativeClassPtr, nameof (PhaseProtectLeader));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseProtectLeader>.NativeClassPtr);
      TutorialBattleSystem1.PhaseProtectLeader.NativeMethodInfoPtr_get_delay_Public_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseProtectLeader>.NativeClassPtr, 100669635);
      TutorialBattleSystem1.PhaseProtectLeader.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseProtectLeader>.NativeClassPtr, 100669636);
      TutorialBattleSystem1.PhaseProtectLeader.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseProtectLeader>.NativeClassPtr, 100669637);
      TutorialBattleSystem1.PhaseProtectLeader.NativeMethodInfoPtr_Show_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseProtectLeader>.NativeClassPtr, 100669638);
      TutorialBattleSystem1.PhaseProtectLeader.NativeMethodInfoPtr_End_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseProtectLeader>.NativeClassPtr, 100669639);
      TutorialBattleSystem1.PhaseProtectLeader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseProtectLeader>.NativeClassPtr, 100669640);
    }

    public PhaseProtectLeader(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [ObfuscatedName("TutorialBattleSystem1/PhaseProtectLeader/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__4_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Show_b__4_0_Internal_String_0;

      [CallerCount(1959)]
      [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseProtectLeader.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseProtectLeader.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78178, XrefRangeEnd = 78184, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string _Show_b__4_0()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseProtectLeader.__c.NativeMethodInfoPtr__Show_b__4_0_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      static __c()
      {
        Il2CppClassPointerStore<TutorialBattleSystem1.PhaseProtectLeader.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseProtectLeader>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseProtectLeader.__c>.NativeClassPtr);
        TutorialBattleSystem1.PhaseProtectLeader.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseProtectLeader.__c>.NativeClassPtr, "<>9");
        TutorialBattleSystem1.PhaseProtectLeader.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseProtectLeader.__c>.NativeClassPtr, "<>9__4_0");
        TutorialBattleSystem1.PhaseProtectLeader.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseProtectLeader.__c>.NativeClassPtr, 100669642);
        TutorialBattleSystem1.PhaseProtectLeader.__c.NativeMethodInfoPtr__Show_b__4_0_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseProtectLeader.__c>.NativeClassPtr, 100669643);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe TutorialBattleSystem1.PhaseProtectLeader.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TutorialBattleSystem1.PhaseProtectLeader.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (TutorialBattleSystem1.PhaseProtectLeader.__c) null : new TutorialBattleSystem1.PhaseProtectLeader.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TutorialBattleSystem1.PhaseProtectLeader.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Prompt.GetTextCallback __9__4_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TutorialBattleSystem1.PhaseProtectLeader.__c.NativeFieldInfoPtr___9__4_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Prompt.GetTextCallback) null : new Prompt.GetTextCallback(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TutorialBattleSystem1.PhaseProtectLeader.__c.NativeFieldInfoPtr___9__4_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }

  public class PhaseWaveDeploy : TutorialParentSystem.Phase
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_get_delay_Public_Virtual_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BattleTurnStart_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public override unsafe float delay
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem1.PhaseWaveDeploy.NativeMethodInfoPtr_get_delay_Public_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78223, XrefRangeEnd = 78256, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnEnable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem1.PhaseWaveDeploy.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78256, XrefRangeEnd = 78265, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem1.PhaseWaveDeploy.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void BattleTurnStart(int turn)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &turn
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseWaveDeploy.NativeMethodInfoPtr_BattleTurnStart_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PhaseWaveDeploy()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseWaveDeploy>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseWaveDeploy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PhaseWaveDeploy()
    {
      Il2CppClassPointerStore<TutorialBattleSystem1.PhaseWaveDeploy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialBattleSystem1>.NativeClassPtr, nameof (PhaseWaveDeploy));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseWaveDeploy>.NativeClassPtr);
      TutorialBattleSystem1.PhaseWaveDeploy.NativeMethodInfoPtr_get_delay_Public_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseWaveDeploy>.NativeClassPtr, 100669644);
      TutorialBattleSystem1.PhaseWaveDeploy.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseWaveDeploy>.NativeClassPtr, 100669645);
      TutorialBattleSystem1.PhaseWaveDeploy.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseWaveDeploy>.NativeClassPtr, 100669646);
      TutorialBattleSystem1.PhaseWaveDeploy.NativeMethodInfoPtr_BattleTurnStart_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseWaveDeploy>.NativeClassPtr, 100669647);
      TutorialBattleSystem1.PhaseWaveDeploy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseWaveDeploy>.NativeClassPtr, 100669648);
    }

    public PhaseWaveDeploy(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [ObfuscatedName("TutorialBattleSystem1/PhaseWaveDeploy/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnEnable_b__2_0_Internal_String_0;

      [CallerCount(1959)]
      [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseWaveDeploy.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseWaveDeploy.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78217, XrefRangeEnd = 78223, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string _OnEnable_b__2_0()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseWaveDeploy.__c.NativeMethodInfoPtr__OnEnable_b__2_0_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      static __c()
      {
        Il2CppClassPointerStore<TutorialBattleSystem1.PhaseWaveDeploy.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseWaveDeploy>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseWaveDeploy.__c>.NativeClassPtr);
        TutorialBattleSystem1.PhaseWaveDeploy.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseWaveDeploy.__c>.NativeClassPtr, "<>9");
        TutorialBattleSystem1.PhaseWaveDeploy.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseWaveDeploy.__c>.NativeClassPtr, "<>9__2_0");
        TutorialBattleSystem1.PhaseWaveDeploy.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseWaveDeploy.__c>.NativeClassPtr, 100669650);
        TutorialBattleSystem1.PhaseWaveDeploy.__c.NativeMethodInfoPtr__OnEnable_b__2_0_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseWaveDeploy.__c>.NativeClassPtr, 100669651);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe TutorialBattleSystem1.PhaseWaveDeploy.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TutorialBattleSystem1.PhaseWaveDeploy.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (TutorialBattleSystem1.PhaseWaveDeploy.__c) null : new TutorialBattleSystem1.PhaseWaveDeploy.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TutorialBattleSystem1.PhaseWaveDeploy.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Prompt.GetTextCallback __9__2_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TutorialBattleSystem1.PhaseWaveDeploy.__c.NativeFieldInfoPtr___9__2_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Prompt.GetTextCallback) null : new Prompt.GetTextCallback(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TutorialBattleSystem1.PhaseWaveDeploy.__c.NativeFieldInfoPtr___9__2_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }

  public class PhaseWaitForMiniboss : TutorialParentSystem.Phase
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ActionPerform_Private_Void_PlayAction_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78265, XrefRangeEnd = 78273, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnEnable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem1.PhaseWaitForMiniboss.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78273, XrefRangeEnd = 78281, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem1.PhaseWaitForMiniboss.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78281, XrefRangeEnd = 78289, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ActionPerform(PlayAction action)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseWaitForMiniboss.NativeMethodInfoPtr_ActionPerform_Private_Void_PlayAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PhaseWaitForMiniboss()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseWaitForMiniboss>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseWaitForMiniboss.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PhaseWaitForMiniboss()
    {
      Il2CppClassPointerStore<TutorialBattleSystem1.PhaseWaitForMiniboss>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialBattleSystem1>.NativeClassPtr, nameof (PhaseWaitForMiniboss));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseWaitForMiniboss>.NativeClassPtr);
      TutorialBattleSystem1.PhaseWaitForMiniboss.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseWaitForMiniboss>.NativeClassPtr, 100669652);
      TutorialBattleSystem1.PhaseWaitForMiniboss.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseWaitForMiniboss>.NativeClassPtr, 100669653);
      TutorialBattleSystem1.PhaseWaitForMiniboss.NativeMethodInfoPtr_ActionPerform_Private_Void_PlayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseWaitForMiniboss>.NativeClassPtr, 100669654);
      TutorialBattleSystem1.PhaseWaitForMiniboss.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseWaitForMiniboss>.NativeClassPtr, 100669655);
    }

    public PhaseWaitForMiniboss(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }

  public class PhaseMiniboss : TutorialParentSystem.Phase
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_get_delay_Public_Virtual_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EntityKilled_Private_Void_Entity_DeathType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PromptAfterDelay_Private_IEnumerator_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public override unsafe float delay
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem1.PhaseMiniboss.NativeMethodInfoPtr_get_delay_Public_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78309, XrefRangeEnd = 78326, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnEnable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem1.PhaseMiniboss.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78326, XrefRangeEnd = 78335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialBattleSystem1.PhaseMiniboss.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78335, XrefRangeEnd = 78341, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void EntityKilled(Entity entity, DeathType deathType)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &deathType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseMiniboss.NativeMethodInfoPtr_EntityKilled_Private_Void_Entity_DeathType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78341, XrefRangeEnd = 78346, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IEnumerator PromptAfterDelay(float delay)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &delay
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseMiniboss.NativeMethodInfoPtr_PromptAfterDelay_Private_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
    }

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PhaseMiniboss()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseMiniboss>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseMiniboss.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PhaseMiniboss()
    {
      Il2CppClassPointerStore<TutorialBattleSystem1.PhaseMiniboss>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialBattleSystem1>.NativeClassPtr, nameof (PhaseMiniboss));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseMiniboss>.NativeClassPtr);
      TutorialBattleSystem1.PhaseMiniboss.NativeMethodInfoPtr_get_delay_Public_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseMiniboss>.NativeClassPtr, 100669656);
      TutorialBattleSystem1.PhaseMiniboss.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseMiniboss>.NativeClassPtr, 100669657);
      TutorialBattleSystem1.PhaseMiniboss.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseMiniboss>.NativeClassPtr, 100669658);
      TutorialBattleSystem1.PhaseMiniboss.NativeMethodInfoPtr_EntityKilled_Private_Void_Entity_DeathType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseMiniboss>.NativeClassPtr, 100669659);
      TutorialBattleSystem1.PhaseMiniboss.NativeMethodInfoPtr_PromptAfterDelay_Private_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseMiniboss>.NativeClassPtr, 100669660);
      TutorialBattleSystem1.PhaseMiniboss.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseMiniboss>.NativeClassPtr, 100669661);
    }

    public PhaseMiniboss(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [ObfuscatedName("TutorialBattleSystem1/PhaseMiniboss/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__5_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__PromptAfterDelay_b__5_0_Internal_String_0;

      [CallerCount(1959)]
      [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseMiniboss.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseMiniboss.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78289, XrefRangeEnd = 78295, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string _PromptAfterDelay_b__5_0()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseMiniboss.__c.NativeMethodInfoPtr__PromptAfterDelay_b__5_0_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      static __c()
      {
        Il2CppClassPointerStore<TutorialBattleSystem1.PhaseMiniboss.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseMiniboss>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseMiniboss.__c>.NativeClassPtr);
        TutorialBattleSystem1.PhaseMiniboss.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseMiniboss.__c>.NativeClassPtr, "<>9");
        TutorialBattleSystem1.PhaseMiniboss.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseMiniboss.__c>.NativeClassPtr, "<>9__5_0");
        TutorialBattleSystem1.PhaseMiniboss.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseMiniboss.__c>.NativeClassPtr, 100669663);
        TutorialBattleSystem1.PhaseMiniboss.__c.NativeMethodInfoPtr__PromptAfterDelay_b__5_0_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseMiniboss.__c>.NativeClassPtr, 100669664);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe TutorialBattleSystem1.PhaseMiniboss.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TutorialBattleSystem1.PhaseMiniboss.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (TutorialBattleSystem1.PhaseMiniboss.__c) null : new TutorialBattleSystem1.PhaseMiniboss.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TutorialBattleSystem1.PhaseMiniboss.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Prompt.GetTextCallback __9__5_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TutorialBattleSystem1.PhaseMiniboss.__c.NativeFieldInfoPtr___9__5_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Prompt.GetTextCallback) null : new Prompt.GetTextCallback(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TutorialBattleSystem1.PhaseMiniboss.__c.NativeFieldInfoPtr___9__5_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("TutorialBattleSystem1/PhaseMiniboss/<PromptAfterDelay>d__5")]
    public sealed class _PromptAfterDelay_d__5 : Il2CppSystem.Object
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
      public unsafe _PromptAfterDelay_d__5(int _param1)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseMiniboss._PromptAfterDelay_d__5>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &_param1
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseMiniboss._PromptAfterDelay_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(12611)]
      [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_IDisposable_Dispose()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseMiniboss._PromptAfterDelay_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78295, XrefRangeEnd = 78303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool MoveNext()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseMiniboss._PromptAfterDelay_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseMiniboss._PromptAfterDelay_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78303, XrefRangeEnd = 78309, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_Collections_IEnumerator_Reset()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseMiniboss._PromptAfterDelay_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
      {
        [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.PhaseMiniboss._PromptAfterDelay_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
      }

      static _PromptAfterDelay_d__5()
      {
        Il2CppClassPointerStore<TutorialBattleSystem1.PhaseMiniboss._PromptAfterDelay_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseMiniboss>.NativeClassPtr, "<PromptAfterDelay>d__5");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseMiniboss._PromptAfterDelay_d__5>.NativeClassPtr);
        TutorialBattleSystem1.PhaseMiniboss._PromptAfterDelay_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseMiniboss._PromptAfterDelay_d__5>.NativeClassPtr, "<>1__state");
        TutorialBattleSystem1.PhaseMiniboss._PromptAfterDelay_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseMiniboss._PromptAfterDelay_d__5>.NativeClassPtr, "<>2__current");
        TutorialBattleSystem1.PhaseMiniboss._PromptAfterDelay_d__5.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseMiniboss._PromptAfterDelay_d__5>.NativeClassPtr, nameof (delay));
        TutorialBattleSystem1.PhaseMiniboss._PromptAfterDelay_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseMiniboss._PromptAfterDelay_d__5>.NativeClassPtr, "<>4__this");
        TutorialBattleSystem1.PhaseMiniboss._PromptAfterDelay_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseMiniboss._PromptAfterDelay_d__5>.NativeClassPtr, 100669665);
        TutorialBattleSystem1.PhaseMiniboss._PromptAfterDelay_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseMiniboss._PromptAfterDelay_d__5>.NativeClassPtr, 100669666);
        TutorialBattleSystem1.PhaseMiniboss._PromptAfterDelay_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseMiniboss._PromptAfterDelay_d__5>.NativeClassPtr, 100669667);
        TutorialBattleSystem1.PhaseMiniboss._PromptAfterDelay_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseMiniboss._PromptAfterDelay_d__5>.NativeClassPtr, 100669668);
        TutorialBattleSystem1.PhaseMiniboss._PromptAfterDelay_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseMiniboss._PromptAfterDelay_d__5>.NativeClassPtr, 100669669);
        TutorialBattleSystem1.PhaseMiniboss._PromptAfterDelay_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.PhaseMiniboss._PromptAfterDelay_d__5>.NativeClassPtr, 100669670);
      }

      public _PromptAfterDelay_d__5(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe int __1__state
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem1.PhaseMiniboss._PromptAfterDelay_d__5.NativeFieldInfoPtr___1__state));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem1.PhaseMiniboss._PromptAfterDelay_d__5.NativeFieldInfoPtr___1__state)) = value;
        }
      }

      public unsafe Il2CppSystem.Object __2__current
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem1.PhaseMiniboss._PromptAfterDelay_d__5.NativeFieldInfoPtr___2__current));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem1.PhaseMiniboss._PromptAfterDelay_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe float delay
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem1.PhaseMiniboss._PromptAfterDelay_d__5.NativeFieldInfoPtr_delay));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem1.PhaseMiniboss._PromptAfterDelay_d__5.NativeFieldInfoPtr_delay)) = value;
        }
      }

      public unsafe TutorialBattleSystem1.PhaseMiniboss __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem1.PhaseMiniboss._PromptAfterDelay_d__5.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (TutorialBattleSystem1.PhaseMiniboss) null : new TutorialBattleSystem1.PhaseMiniboss(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem1.PhaseMiniboss._PromptAfterDelay_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }

  [ObfuscatedName("TutorialBattleSystem1/<>c__DisplayClass2_0")]
  public sealed class __c__DisplayClass2_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_chosenUnitData;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__FindLastUnit_b__1_Internal_Boolean_Entity_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass2_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem1.__c__DisplayClass2_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _FindLastUnit_b__1(Entity a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.__c__DisplayClass2_0.NativeMethodInfoPtr__FindLastUnit_b__1_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass2_0()
    {
      Il2CppClassPointerStore<TutorialBattleSystem1.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialBattleSystem1>.NativeClassPtr, "<>c__DisplayClass2_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem1.__c__DisplayClass2_0>.NativeClassPtr);
      TutorialBattleSystem1.__c__DisplayClass2_0.NativeFieldInfoPtr_chosenUnitData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem1.__c__DisplayClass2_0>.NativeClassPtr, nameof (chosenUnitData));
      TutorialBattleSystem1.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.__c__DisplayClass2_0>.NativeClassPtr, 100669671);
      TutorialBattleSystem1.__c__DisplayClass2_0.NativeMethodInfoPtr__FindLastUnit_b__1_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.__c__DisplayClass2_0>.NativeClassPtr, 100669672);
    }

    public __c__DisplayClass2_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CardData chosenUnitData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem1.__c__DisplayClass2_0.NativeFieldInfoPtr_chosenUnitData));
        return pointer == System.IntPtr.Zero ? (CardData) null : new CardData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialBattleSystem1.__c__DisplayClass2_0.NativeFieldInfoPtr_chosenUnitData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("TutorialBattleSystem1/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__FindLastUnit_b__2_0_Internal_Boolean_CardData_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialBattleSystem1.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _FindLastUnit_b__2_0(CardData a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialBattleSystem1.__c.NativeMethodInfoPtr__FindLastUnit_b__2_0_Internal_Boolean_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<TutorialBattleSystem1.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialBattleSystem1>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialBattleSystem1.__c>.NativeClassPtr);
      TutorialBattleSystem1.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem1.__c>.NativeClassPtr, "<>9");
      TutorialBattleSystem1.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialBattleSystem1.__c>.NativeClassPtr, "<>9__2_0");
      TutorialBattleSystem1.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.__c>.NativeClassPtr, 100669674);
      TutorialBattleSystem1.__c.NativeMethodInfoPtr__FindLastUnit_b__2_0_Internal_Boolean_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialBattleSystem1.__c>.NativeClassPtr, 100669675);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe TutorialBattleSystem1.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(TutorialBattleSystem1.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (TutorialBattleSystem1.__c) null : new TutorialBattleSystem1.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TutorialBattleSystem1.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CardData, bool> __9__2_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(TutorialBattleSystem1.__c.NativeFieldInfoPtr___9__2_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardData, bool>) null : new Il2CppSystem.Func<CardData, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TutorialBattleSystem1.__c.NativeFieldInfoPtr___9__2_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
