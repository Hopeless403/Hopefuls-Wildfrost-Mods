// Decompiled with JetBrains decompiler
// Type: SecretNakedGnomeSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class SecretNakedGnomeSystem : GameSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_nakedGnomeDataName;
  private static readonly System.IntPtr NativeFieldInfoPtr_nakedGnomeFriendlyDataName;
  private static readonly System.IntPtr NativeFieldInfoPtr_nakedGnomeSaved;
  private static readonly System.IntPtr NativeFieldInfoPtr_gainNakedGnomeSequencePrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_startPos;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BattleEnd_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PostBattle_Private_Void_CampaignNode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Sequence_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70860, XrefRangeEnd = 70875, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SecretNakedGnomeSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70875, XrefRangeEnd = 70890, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SecretNakedGnomeSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70890, XrefRangeEnd = 70919, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void BattleEnd()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SecretNakedGnomeSystem.NativeMethodInfoPtr_BattleEnd_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70919, XrefRangeEnd = 70939, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PostBattle(CampaignNode campaignNode)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) campaignNode)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SecretNakedGnomeSystem.NativeMethodInfoPtr_PostBattle_Private_Void_CampaignNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70939, XrefRangeEnd = 70944, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator Sequence()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SecretNakedGnomeSystem.NativeMethodInfoPtr_Sequence_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SecretNakedGnomeSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SecretNakedGnomeSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SecretNakedGnomeSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static SecretNakedGnomeSystem()
  {
    Il2CppClassPointerStore<SecretNakedGnomeSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (SecretNakedGnomeSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SecretNakedGnomeSystem>.NativeClassPtr);
    SecretNakedGnomeSystem.NativeFieldInfoPtr_nakedGnomeDataName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecretNakedGnomeSystem>.NativeClassPtr, nameof (nakedGnomeDataName));
    SecretNakedGnomeSystem.NativeFieldInfoPtr_nakedGnomeFriendlyDataName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecretNakedGnomeSystem>.NativeClassPtr, nameof (nakedGnomeFriendlyDataName));
    SecretNakedGnomeSystem.NativeFieldInfoPtr_nakedGnomeSaved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecretNakedGnomeSystem>.NativeClassPtr, nameof (nakedGnomeSaved));
    SecretNakedGnomeSystem.NativeFieldInfoPtr_gainNakedGnomeSequencePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecretNakedGnomeSystem>.NativeClassPtr, nameof (gainNakedGnomeSequencePrefab));
    SecretNakedGnomeSystem.NativeFieldInfoPtr_startPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecretNakedGnomeSystem>.NativeClassPtr, nameof (startPos));
    SecretNakedGnomeSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecretNakedGnomeSystem>.NativeClassPtr, 100669085);
    SecretNakedGnomeSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecretNakedGnomeSystem>.NativeClassPtr, 100669086);
    SecretNakedGnomeSystem.NativeMethodInfoPtr_BattleEnd_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecretNakedGnomeSystem>.NativeClassPtr, 100669087);
    SecretNakedGnomeSystem.NativeMethodInfoPtr_PostBattle_Private_Void_CampaignNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecretNakedGnomeSystem>.NativeClassPtr, 100669088);
    SecretNakedGnomeSystem.NativeMethodInfoPtr_Sequence_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecretNakedGnomeSystem>.NativeClassPtr, 100669089);
    SecretNakedGnomeSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecretNakedGnomeSystem>.NativeClassPtr, 100669090);
  }

  public SecretNakedGnomeSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe string nakedGnomeDataName
  {
    get
    {
      System.IntPtr il2CppString;
      IL2CPP.il2cpp_field_static_get_value(SecretNakedGnomeSystem.NativeFieldInfoPtr_nakedGnomeDataName, (void*) &il2CppString);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SecretNakedGnomeSystem.NativeFieldInfoPtr_nakedGnomeDataName, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string nakedGnomeFriendlyDataName
  {
    get
    {
      System.IntPtr il2CppString;
      IL2CPP.il2cpp_field_static_get_value(SecretNakedGnomeSystem.NativeFieldInfoPtr_nakedGnomeFriendlyDataName, (void*) &il2CppString);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SecretNakedGnomeSystem.NativeFieldInfoPtr_nakedGnomeFriendlyDataName, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe bool nakedGnomeSaved
  {
    get
    {
      bool nakedGnomeSaved;
      IL2CPP.il2cpp_field_static_get_value(SecretNakedGnomeSystem.NativeFieldInfoPtr_nakedGnomeSaved, (void*) &nakedGnomeSaved);
      return nakedGnomeSaved;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SecretNakedGnomeSystem.NativeFieldInfoPtr_nakedGnomeSaved, (void*) &value);
    }
  }

  public unsafe InspectNewUnitSequence gainNakedGnomeSequencePrefab
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SecretNakedGnomeSystem.NativeFieldInfoPtr_gainNakedGnomeSequencePrefab));
      return pointer == System.IntPtr.Zero ? (InspectNewUnitSequence) null : new InspectNewUnitSequence(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SecretNakedGnomeSystem.NativeFieldInfoPtr_gainNakedGnomeSequencePrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Vector3 startPos
  {
    get
    {
      Vector3 startPos;
      IL2CPP.il2cpp_field_static_get_value(SecretNakedGnomeSystem.NativeFieldInfoPtr_startPos, (void*) &startPos);
      return startPos;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SecretNakedGnomeSystem.NativeFieldInfoPtr_startPos, (void*) &value);
    }
  }

  [ObfuscatedName("SecretNakedGnomeSystem/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__7_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__BattleEnd_b__7_0_Internal_Boolean_Entity_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SecretNakedGnomeSystem.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SecretNakedGnomeSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70832, XrefRangeEnd = 70837, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _BattleEnd_b__7_0(Entity a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SecretNakedGnomeSystem.__c.NativeMethodInfoPtr__BattleEnd_b__7_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<SecretNakedGnomeSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SecretNakedGnomeSystem>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SecretNakedGnomeSystem.__c>.NativeClassPtr);
      SecretNakedGnomeSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecretNakedGnomeSystem.__c>.NativeClassPtr, "<>9");
      SecretNakedGnomeSystem.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecretNakedGnomeSystem.__c>.NativeClassPtr, "<>9__7_0");
      SecretNakedGnomeSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecretNakedGnomeSystem.__c>.NativeClassPtr, 100669093);
      SecretNakedGnomeSystem.__c.NativeMethodInfoPtr__BattleEnd_b__7_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecretNakedGnomeSystem.__c>.NativeClassPtr, 100669094);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe SecretNakedGnomeSystem.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(SecretNakedGnomeSystem.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (SecretNakedGnomeSystem.__c) null : new SecretNakedGnomeSystem.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SecretNakedGnomeSystem.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<Entity, bool> __9__7_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(SecretNakedGnomeSystem.__c.NativeFieldInfoPtr___9__7_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Entity, bool>) null : new Il2CppSystem.Func<Entity, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SecretNakedGnomeSystem.__c.NativeFieldInfoPtr___9__7_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("SecretNakedGnomeSystem/<Sequence>d__9")]
  public sealed class _Sequence_d__9 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr__sequence_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__card_5__3;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _Sequence_d__9(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SecretNakedGnomeSystem._Sequence_d__9>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SecretNakedGnomeSystem._Sequence_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SecretNakedGnomeSystem._Sequence_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70837, XrefRangeEnd = 70854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SecretNakedGnomeSystem._Sequence_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SecretNakedGnomeSystem._Sequence_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70854, XrefRangeEnd = 70860, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SecretNakedGnomeSystem._Sequence_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SecretNakedGnomeSystem._Sequence_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _Sequence_d__9()
    {
      Il2CppClassPointerStore<SecretNakedGnomeSystem._Sequence_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SecretNakedGnomeSystem>.NativeClassPtr, "<Sequence>d__9");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SecretNakedGnomeSystem._Sequence_d__9>.NativeClassPtr);
      SecretNakedGnomeSystem._Sequence_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecretNakedGnomeSystem._Sequence_d__9>.NativeClassPtr, "<>1__state");
      SecretNakedGnomeSystem._Sequence_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecretNakedGnomeSystem._Sequence_d__9>.NativeClassPtr, "<>2__current");
      SecretNakedGnomeSystem._Sequence_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecretNakedGnomeSystem._Sequence_d__9>.NativeClassPtr, "<>4__this");
      SecretNakedGnomeSystem._Sequence_d__9.NativeFieldInfoPtr__sequence_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecretNakedGnomeSystem._Sequence_d__9>.NativeClassPtr, "<sequence>5__2");
      SecretNakedGnomeSystem._Sequence_d__9.NativeFieldInfoPtr__card_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecretNakedGnomeSystem._Sequence_d__9>.NativeClassPtr, "<card>5__3");
      SecretNakedGnomeSystem._Sequence_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecretNakedGnomeSystem._Sequence_d__9>.NativeClassPtr, 100669095);
      SecretNakedGnomeSystem._Sequence_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecretNakedGnomeSystem._Sequence_d__9>.NativeClassPtr, 100669096);
      SecretNakedGnomeSystem._Sequence_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecretNakedGnomeSystem._Sequence_d__9>.NativeClassPtr, 100669097);
      SecretNakedGnomeSystem._Sequence_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecretNakedGnomeSystem._Sequence_d__9>.NativeClassPtr, 100669098);
      SecretNakedGnomeSystem._Sequence_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecretNakedGnomeSystem._Sequence_d__9>.NativeClassPtr, 100669099);
      SecretNakedGnomeSystem._Sequence_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecretNakedGnomeSystem._Sequence_d__9>.NativeClassPtr, 100669100);
    }

    public _Sequence_d__9(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SecretNakedGnomeSystem._Sequence_d__9.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SecretNakedGnomeSystem._Sequence_d__9.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SecretNakedGnomeSystem._Sequence_d__9.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SecretNakedGnomeSystem._Sequence_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SecretNakedGnomeSystem __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SecretNakedGnomeSystem._Sequence_d__9.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (SecretNakedGnomeSystem) null : new SecretNakedGnomeSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SecretNakedGnomeSystem._Sequence_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InspectNewUnitSequence _sequence_5__2
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SecretNakedGnomeSystem._Sequence_d__9.NativeFieldInfoPtr__sequence_5__2));
        return pointer == System.IntPtr.Zero ? (InspectNewUnitSequence) null : new InspectNewUnitSequence(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SecretNakedGnomeSystem._Sequence_d__9.NativeFieldInfoPtr__sequence_5__2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Card _card_5__3
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SecretNakedGnomeSystem._Sequence_d__9.NativeFieldInfoPtr__card_5__3));
        return pointer == System.IntPtr.Zero ? (Card) null : new Card(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SecretNakedGnomeSystem._Sequence_d__9.NativeFieldInfoPtr__card_5__3), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
