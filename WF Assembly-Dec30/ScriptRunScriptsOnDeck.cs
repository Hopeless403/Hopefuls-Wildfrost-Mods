// Decompiled with JetBrains decompiler
// Type: ScriptRunScriptsOnDeck
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.AddressableAssets;

#nullable disable
public class ScriptRunScriptsOnDeck : Script
{
  private static readonly System.IntPtr NativeFieldInfoPtr_scriptRefs;
  private static readonly System.IntPtr NativeFieldInfoPtr_constraints;
  private static readonly System.IntPtr NativeFieldInfoPtr_countRange;
  private static readonly System.IntPtr NativeFieldInfoPtr_includeReserve;
  private static readonly System.IntPtr NativeMethodInfoPtr_Run_Public_Virtual_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddRangeIfConstraints_Private_Static_Void_ICollection_1_CardData_CardDataList_Il2CppReferenceArray_1_TargetConstraint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddIfConstraints_Private_Static_Void_ICollection_1_CardData_CardData_Il2CppReferenceArray_1_TargetConstraint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Affect_Private_Void_IReadOnlyCollection_1_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23128, XrefRangeEnd = 23133, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IEnumerator Run()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ScriptRunScriptsOnDeck.NativeMethodInfoPtr_Run_Public_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 23166, RefRangeEnd = 23168, XrefRangeStart = 23133, XrefRangeEnd = 23166, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void AddRangeIfConstraints(
    ICollection<CardData> collection,
    CardDataList toAdd,
    Il2CppReferenceArray<TargetConstraint> constraints)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) collection);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) toAdd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) constraints);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScriptRunScriptsOnDeck.NativeMethodInfoPtr_AddRangeIfConstraints_Private_Static_Void_ICollection_1_CardData_CardDataList_Il2CppReferenceArray_1_TargetConstraint_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23168, XrefRangeEnd = 23185, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void AddIfConstraints(
    ICollection<CardData> collection,
    CardData item,
    Il2CppReferenceArray<TargetConstraint> constraints)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) collection);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) item);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) constraints);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScriptRunScriptsOnDeck.NativeMethodInfoPtr_AddIfConstraints_Private_Static_Void_ICollection_1_CardData_CardData_Il2CppReferenceArray_1_TargetConstraint_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 23266, RefRangeEnd = 23267, XrefRangeStart = 23185, XrefRangeEnd = 23266, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Affect(IReadOnlyCollection<CardData> cards)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cards)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScriptRunScriptsOnDeck.NativeMethodInfoPtr_Affect_Private_Void_IReadOnlyCollection_1_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ScriptRunScriptsOnDeck()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptRunScriptsOnDeck>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScriptRunScriptsOnDeck.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ScriptRunScriptsOnDeck()
  {
    Il2CppClassPointerStore<ScriptRunScriptsOnDeck>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ScriptRunScriptsOnDeck));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptRunScriptsOnDeck>.NativeClassPtr);
    ScriptRunScriptsOnDeck.NativeFieldInfoPtr_scriptRefs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptRunScriptsOnDeck>.NativeClassPtr, nameof (scriptRefs));
    ScriptRunScriptsOnDeck.NativeFieldInfoPtr_constraints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptRunScriptsOnDeck>.NativeClassPtr, nameof (constraints));
    ScriptRunScriptsOnDeck.NativeFieldInfoPtr_countRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptRunScriptsOnDeck>.NativeClassPtr, nameof (countRange));
    ScriptRunScriptsOnDeck.NativeFieldInfoPtr_includeReserve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptRunScriptsOnDeck>.NativeClassPtr, nameof (includeReserve));
    ScriptRunScriptsOnDeck.NativeMethodInfoPtr_Run_Public_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRunScriptsOnDeck>.NativeClassPtr, 100664124);
    ScriptRunScriptsOnDeck.NativeMethodInfoPtr_AddRangeIfConstraints_Private_Static_Void_ICollection_1_CardData_CardDataList_Il2CppReferenceArray_1_TargetConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRunScriptsOnDeck>.NativeClassPtr, 100664125);
    ScriptRunScriptsOnDeck.NativeMethodInfoPtr_AddIfConstraints_Private_Static_Void_ICollection_1_CardData_CardData_Il2CppReferenceArray_1_TargetConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRunScriptsOnDeck>.NativeClassPtr, 100664126);
    ScriptRunScriptsOnDeck.NativeMethodInfoPtr_Affect_Private_Void_IReadOnlyCollection_1_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRunScriptsOnDeck>.NativeClassPtr, 100664127);
    ScriptRunScriptsOnDeck.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRunScriptsOnDeck>.NativeClassPtr, 100664128);
  }

  public ScriptRunScriptsOnDeck(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppReferenceArray<AssetReferenceT<CardScript>> scriptRefs
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptRunScriptsOnDeck.NativeFieldInfoPtr_scriptRefs));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<AssetReferenceT<CardScript>>) null : new Il2CppReferenceArray<AssetReferenceT<CardScript>>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScriptRunScriptsOnDeck.NativeFieldInfoPtr_scriptRefs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<TargetConstraint> constraints
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptRunScriptsOnDeck.NativeFieldInfoPtr_constraints));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<TargetConstraint>) null : new Il2CppReferenceArray<TargetConstraint>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScriptRunScriptsOnDeck.NativeFieldInfoPtr_constraints), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector2Int countRange
  {
    get
    {
      return *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptRunScriptsOnDeck.NativeFieldInfoPtr_countRange));
    }
    [param: In] set
    {
      *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptRunScriptsOnDeck.NativeFieldInfoPtr_countRange)) = value;
    }
  }

  public unsafe bool includeReserve
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptRunScriptsOnDeck.NativeFieldInfoPtr_includeReserve));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptRunScriptsOnDeck.NativeFieldInfoPtr_includeReserve)) = value;
    }
  }

  [ObfuscatedName("ScriptRunScriptsOnDeck/<Run>d__4")]
  public sealed class _Run_d__4 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _Run_d__4(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptRunScriptsOnDeck._Run_d__4>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScriptRunScriptsOnDeck._Run_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScriptRunScriptsOnDeck._Run_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23109, XrefRangeEnd = 23122, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScriptRunScriptsOnDeck._Run_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScriptRunScriptsOnDeck._Run_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23122, XrefRangeEnd = 23128, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScriptRunScriptsOnDeck._Run_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScriptRunScriptsOnDeck._Run_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _Run_d__4()
    {
      Il2CppClassPointerStore<ScriptRunScriptsOnDeck._Run_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptRunScriptsOnDeck>.NativeClassPtr, "<Run>d__4");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptRunScriptsOnDeck._Run_d__4>.NativeClassPtr);
      ScriptRunScriptsOnDeck._Run_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptRunScriptsOnDeck._Run_d__4>.NativeClassPtr, "<>1__state");
      ScriptRunScriptsOnDeck._Run_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptRunScriptsOnDeck._Run_d__4>.NativeClassPtr, "<>2__current");
      ScriptRunScriptsOnDeck._Run_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptRunScriptsOnDeck._Run_d__4>.NativeClassPtr, "<>4__this");
      ScriptRunScriptsOnDeck._Run_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRunScriptsOnDeck._Run_d__4>.NativeClassPtr, 100664129);
      ScriptRunScriptsOnDeck._Run_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRunScriptsOnDeck._Run_d__4>.NativeClassPtr, 100664130);
      ScriptRunScriptsOnDeck._Run_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRunScriptsOnDeck._Run_d__4>.NativeClassPtr, 100664131);
      ScriptRunScriptsOnDeck._Run_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRunScriptsOnDeck._Run_d__4>.NativeClassPtr, 100664132);
      ScriptRunScriptsOnDeck._Run_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRunScriptsOnDeck._Run_d__4>.NativeClassPtr, 100664133);
      ScriptRunScriptsOnDeck._Run_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRunScriptsOnDeck._Run_d__4>.NativeClassPtr, 100664134);
    }

    public _Run_d__4(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptRunScriptsOnDeck._Run_d__4.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptRunScriptsOnDeck._Run_d__4.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptRunScriptsOnDeck._Run_d__4.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScriptRunScriptsOnDeck._Run_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ScriptRunScriptsOnDeck __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptRunScriptsOnDeck._Run_d__4.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (ScriptRunScriptsOnDeck) null : new ScriptRunScriptsOnDeck(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScriptRunScriptsOnDeck._Run_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("ScriptRunScriptsOnDeck/<>c__DisplayClass6_0")]
  public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_item;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__AddIfConstraints_b__0_Internal_Boolean_TargetConstraint_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass6_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptRunScriptsOnDeck.__c__DisplayClass6_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScriptRunScriptsOnDeck.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _AddIfConstraints_b__0(TargetConstraint c)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) c)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScriptRunScriptsOnDeck.__c__DisplayClass6_0.NativeMethodInfoPtr__AddIfConstraints_b__0_Internal_Boolean_TargetConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass6_0()
    {
      Il2CppClassPointerStore<ScriptRunScriptsOnDeck.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptRunScriptsOnDeck>.NativeClassPtr, "<>c__DisplayClass6_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptRunScriptsOnDeck.__c__DisplayClass6_0>.NativeClassPtr);
      ScriptRunScriptsOnDeck.__c__DisplayClass6_0.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptRunScriptsOnDeck.__c__DisplayClass6_0>.NativeClassPtr, nameof (item));
      ScriptRunScriptsOnDeck.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRunScriptsOnDeck.__c__DisplayClass6_0>.NativeClassPtr, 100664135);
      ScriptRunScriptsOnDeck.__c__DisplayClass6_0.NativeMethodInfoPtr__AddIfConstraints_b__0_Internal_Boolean_TargetConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptRunScriptsOnDeck.__c__DisplayClass6_0>.NativeClassPtr, 100664136);
    }

    public __c__DisplayClass6_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CardData item
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptRunScriptsOnDeck.__c__DisplayClass6_0.NativeFieldInfoPtr_item));
        return pointer == System.IntPtr.Zero ? (CardData) null : new CardData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScriptRunScriptsOnDeck.__c__DisplayClass6_0.NativeFieldInfoPtr_item), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
