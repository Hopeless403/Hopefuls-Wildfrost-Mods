// Decompiled with JetBrains decompiler
// Type: ScriptAddRandomCards
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

#nullable disable
public class ScriptAddRandomCards : Script
{
  private static readonly System.IntPtr NativeFieldInfoPtr_replaceIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_anyCard;
  private static readonly System.IntPtr NativeFieldInfoPtr_ofType;
  private static readonly System.IntPtr NativeFieldInfoPtr_pool;
  private static readonly System.IntPtr NativeFieldInfoPtr_countRange;
  private static readonly System.IntPtr NativeMethodInfoPtr_Run_Public_Virtual_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PopulateCardList_Private_Void_List_1_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21476, XrefRangeEnd = 21481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IEnumerator Run()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ScriptAddRandomCards.NativeMethodInfoPtr_Run_Public_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 21492, RefRangeEnd = 21493, XrefRangeStart = 21481, XrefRangeEnd = 21492, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PopulateCardList(List<CardData> list)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) list)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScriptAddRandomCards.NativeMethodInfoPtr_PopulateCardList_Private_Void_List_1_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21493, XrefRangeEnd = 21494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ScriptAddRandomCards()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptAddRandomCards>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScriptAddRandomCards.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ScriptAddRandomCards()
  {
    Il2CppClassPointerStore<ScriptAddRandomCards>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ScriptAddRandomCards));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptAddRandomCards>.NativeClassPtr);
    ScriptAddRandomCards.NativeFieldInfoPtr_replaceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptAddRandomCards>.NativeClassPtr, nameof (replaceIndex));
    ScriptAddRandomCards.NativeFieldInfoPtr_anyCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptAddRandomCards>.NativeClassPtr, nameof (anyCard));
    ScriptAddRandomCards.NativeFieldInfoPtr_ofType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptAddRandomCards>.NativeClassPtr, nameof (ofType));
    ScriptAddRandomCards.NativeFieldInfoPtr_pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptAddRandomCards>.NativeClassPtr, nameof (pool));
    ScriptAddRandomCards.NativeFieldInfoPtr_countRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptAddRandomCards>.NativeClassPtr, nameof (countRange));
    ScriptAddRandomCards.NativeMethodInfoPtr_Run_Public_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptAddRandomCards>.NativeClassPtr, 100663913);
    ScriptAddRandomCards.NativeMethodInfoPtr_PopulateCardList_Private_Void_List_1_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptAddRandomCards>.NativeClassPtr, 100663914);
    ScriptAddRandomCards.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptAddRandomCards>.NativeClassPtr, 100663915);
  }

  public ScriptAddRandomCards(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe int replaceIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptAddRandomCards.NativeFieldInfoPtr_replaceIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptAddRandomCards.NativeFieldInfoPtr_replaceIndex)) = value;
    }
  }

  public unsafe bool anyCard
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptAddRandomCards.NativeFieldInfoPtr_anyCard));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptAddRandomCards.NativeFieldInfoPtr_anyCard)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<CardType> ofType
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptAddRandomCards.NativeFieldInfoPtr_ofType));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CardType>) null : new Il2CppReferenceArray<CardType>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScriptAddRandomCards.NativeFieldInfoPtr_ofType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<CardData> pool
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptAddRandomCards.NativeFieldInfoPtr_pool));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CardData>) null : new Il2CppReferenceArray<CardData>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScriptAddRandomCards.NativeFieldInfoPtr_pool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector2Int countRange
  {
    get
    {
      return *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptAddRandomCards.NativeFieldInfoPtr_countRange));
    }
    [param: In] set
    {
      *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptAddRandomCards.NativeFieldInfoPtr_countRange)) = value;
    }
  }

  [ObfuscatedName("ScriptAddRandomCards/<Run>d__5")]
  public sealed class _Run_d__5 : Il2CppSystem.Object
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
    public unsafe _Run_d__5(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptAddRandomCards._Run_d__5>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScriptAddRandomCards._Run_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScriptAddRandomCards._Run_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21440, XrefRangeEnd = 21470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScriptAddRandomCards._Run_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScriptAddRandomCards._Run_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21470, XrefRangeEnd = 21476, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScriptAddRandomCards._Run_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScriptAddRandomCards._Run_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _Run_d__5()
    {
      Il2CppClassPointerStore<ScriptAddRandomCards._Run_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptAddRandomCards>.NativeClassPtr, "<Run>d__5");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptAddRandomCards._Run_d__5>.NativeClassPtr);
      ScriptAddRandomCards._Run_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptAddRandomCards._Run_d__5>.NativeClassPtr, "<>1__state");
      ScriptAddRandomCards._Run_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptAddRandomCards._Run_d__5>.NativeClassPtr, "<>2__current");
      ScriptAddRandomCards._Run_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptAddRandomCards._Run_d__5>.NativeClassPtr, "<>4__this");
      ScriptAddRandomCards._Run_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptAddRandomCards._Run_d__5>.NativeClassPtr, 100663916);
      ScriptAddRandomCards._Run_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptAddRandomCards._Run_d__5>.NativeClassPtr, 100663917);
      ScriptAddRandomCards._Run_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptAddRandomCards._Run_d__5>.NativeClassPtr, 100663918);
      ScriptAddRandomCards._Run_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptAddRandomCards._Run_d__5>.NativeClassPtr, 100663919);
      ScriptAddRandomCards._Run_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptAddRandomCards._Run_d__5>.NativeClassPtr, 100663920);
      ScriptAddRandomCards._Run_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptAddRandomCards._Run_d__5>.NativeClassPtr, 100663921);
    }

    public _Run_d__5(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptAddRandomCards._Run_d__5.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptAddRandomCards._Run_d__5.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptAddRandomCards._Run_d__5.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScriptAddRandomCards._Run_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ScriptAddRandomCards __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptAddRandomCards._Run_d__5.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (ScriptAddRandomCards) null : new ScriptAddRandomCards(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScriptAddRandomCards._Run_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
