// Decompiled with JetBrains decompiler
// Type: DrainLeaderAfterBattleSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections;
using System.Runtime.InteropServices;

#nullable disable
public class DrainLeaderAfterBattleSystem : GameSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_modifyAfterBattleTier;
  private static readonly System.IntPtr NativeFieldInfoPtr_modifyScript;
  private static readonly System.IntPtr NativeFieldInfoPtr_modifyLeader;
  private static readonly System.IntPtr NativeFieldInfoPtr_modifyCardIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_sequencePrefab;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BattleWinPreRewards_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ModifyCardRoutine_Private_IEnumerator_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65316, XrefRangeEnd = 65324, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DrainLeaderAfterBattleSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65324, XrefRangeEnd = 65332, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DrainLeaderAfterBattleSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65332, XrefRangeEnd = 65356, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BattleWinPreRewards()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DrainLeaderAfterBattleSystem.NativeMethodInfoPtr_BattleWinPreRewards_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65356, XrefRangeEnd = 65362, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator ModifyCardRoutine(CardData cardToModify)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cardToModify)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DrainLeaderAfterBattleSystem.NativeMethodInfoPtr_ModifyCardRoutine_Private_IEnumerator_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65362, XrefRangeEnd = 65369, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DrainLeaderAfterBattleSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrainLeaderAfterBattleSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DrainLeaderAfterBattleSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static DrainLeaderAfterBattleSystem()
  {
    Il2CppClassPointerStore<DrainLeaderAfterBattleSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (DrainLeaderAfterBattleSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrainLeaderAfterBattleSystem>.NativeClassPtr);
    DrainLeaderAfterBattleSystem.NativeFieldInfoPtr_modifyAfterBattleTier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrainLeaderAfterBattleSystem>.NativeClassPtr, nameof (modifyAfterBattleTier));
    DrainLeaderAfterBattleSystem.NativeFieldInfoPtr_modifyScript = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrainLeaderAfterBattleSystem>.NativeClassPtr, nameof (modifyScript));
    DrainLeaderAfterBattleSystem.NativeFieldInfoPtr_modifyLeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrainLeaderAfterBattleSystem>.NativeClassPtr, nameof (modifyLeader));
    DrainLeaderAfterBattleSystem.NativeFieldInfoPtr_modifyCardIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrainLeaderAfterBattleSystem>.NativeClassPtr, nameof (modifyCardIndex));
    DrainLeaderAfterBattleSystem.NativeFieldInfoPtr_sequencePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrainLeaderAfterBattleSystem>.NativeClassPtr, nameof (sequencePrefab));
    DrainLeaderAfterBattleSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrainLeaderAfterBattleSystem>.NativeClassPtr, 100668661);
    DrainLeaderAfterBattleSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrainLeaderAfterBattleSystem>.NativeClassPtr, 100668662);
    DrainLeaderAfterBattleSystem.NativeMethodInfoPtr_BattleWinPreRewards_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrainLeaderAfterBattleSystem>.NativeClassPtr, 100668663);
    DrainLeaderAfterBattleSystem.NativeMethodInfoPtr_ModifyCardRoutine_Private_IEnumerator_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrainLeaderAfterBattleSystem>.NativeClassPtr, 100668664);
    DrainLeaderAfterBattleSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrainLeaderAfterBattleSystem>.NativeClassPtr, 100668665);
  }

  public DrainLeaderAfterBattleSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppStructArray<int> modifyAfterBattleTier
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DrainLeaderAfterBattleSystem.NativeFieldInfoPtr_modifyAfterBattleTier));
      return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<int>) null : new Il2CppStructArray<int>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DrainLeaderAfterBattleSystem.NativeFieldInfoPtr_modifyAfterBattleTier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CardScript modifyScript
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DrainLeaderAfterBattleSystem.NativeFieldInfoPtr_modifyScript));
      return pointer == System.IntPtr.Zero ? (CardScript) null : new CardScript(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DrainLeaderAfterBattleSystem.NativeFieldInfoPtr_modifyScript), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool modifyLeader
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DrainLeaderAfterBattleSystem.NativeFieldInfoPtr_modifyLeader));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DrainLeaderAfterBattleSystem.NativeFieldInfoPtr_modifyLeader)) = value;
    }
  }

  public unsafe int modifyCardIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DrainLeaderAfterBattleSystem.NativeFieldInfoPtr_modifyCardIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DrainLeaderAfterBattleSystem.NativeFieldInfoPtr_modifyCardIndex)) = value;
    }
  }

  public unsafe ModifyCardSequence sequencePrefab
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DrainLeaderAfterBattleSystem.NativeFieldInfoPtr_sequencePrefab));
      return pointer == System.IntPtr.Zero ? (ModifyCardSequence) null : new ModifyCardSequence(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DrainLeaderAfterBattleSystem.NativeFieldInfoPtr_sequencePrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("DrainLeaderAfterBattleSystem/<ModifyCardRoutine>d__8")]
  public sealed class _ModifyCardRoutine_d__8 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_cardToModify;
    private static readonly System.IntPtr NativeFieldInfoPtr__sequence_5__2;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _ModifyCardRoutine_d__8(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrainLeaderAfterBattleSystem._ModifyCardRoutine_d__8>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DrainLeaderAfterBattleSystem._ModifyCardRoutine_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DrainLeaderAfterBattleSystem._ModifyCardRoutine_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65298, XrefRangeEnd = 65310, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DrainLeaderAfterBattleSystem._ModifyCardRoutine_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DrainLeaderAfterBattleSystem._ModifyCardRoutine_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65310, XrefRangeEnd = 65316, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DrainLeaderAfterBattleSystem._ModifyCardRoutine_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DrainLeaderAfterBattleSystem._ModifyCardRoutine_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _ModifyCardRoutine_d__8()
    {
      Il2CppClassPointerStore<DrainLeaderAfterBattleSystem._ModifyCardRoutine_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DrainLeaderAfterBattleSystem>.NativeClassPtr, "<ModifyCardRoutine>d__8");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrainLeaderAfterBattleSystem._ModifyCardRoutine_d__8>.NativeClassPtr);
      DrainLeaderAfterBattleSystem._ModifyCardRoutine_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrainLeaderAfterBattleSystem._ModifyCardRoutine_d__8>.NativeClassPtr, "<>1__state");
      DrainLeaderAfterBattleSystem._ModifyCardRoutine_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrainLeaderAfterBattleSystem._ModifyCardRoutine_d__8>.NativeClassPtr, "<>2__current");
      DrainLeaderAfterBattleSystem._ModifyCardRoutine_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrainLeaderAfterBattleSystem._ModifyCardRoutine_d__8>.NativeClassPtr, "<>4__this");
      DrainLeaderAfterBattleSystem._ModifyCardRoutine_d__8.NativeFieldInfoPtr_cardToModify = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrainLeaderAfterBattleSystem._ModifyCardRoutine_d__8>.NativeClassPtr, nameof (cardToModify));
      DrainLeaderAfterBattleSystem._ModifyCardRoutine_d__8.NativeFieldInfoPtr__sequence_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrainLeaderAfterBattleSystem._ModifyCardRoutine_d__8>.NativeClassPtr, "<sequence>5__2");
      DrainLeaderAfterBattleSystem._ModifyCardRoutine_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrainLeaderAfterBattleSystem._ModifyCardRoutine_d__8>.NativeClassPtr, 100668666);
      DrainLeaderAfterBattleSystem._ModifyCardRoutine_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrainLeaderAfterBattleSystem._ModifyCardRoutine_d__8>.NativeClassPtr, 100668667);
      DrainLeaderAfterBattleSystem._ModifyCardRoutine_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrainLeaderAfterBattleSystem._ModifyCardRoutine_d__8>.NativeClassPtr, 100668668);
      DrainLeaderAfterBattleSystem._ModifyCardRoutine_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrainLeaderAfterBattleSystem._ModifyCardRoutine_d__8>.NativeClassPtr, 100668669);
      DrainLeaderAfterBattleSystem._ModifyCardRoutine_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrainLeaderAfterBattleSystem._ModifyCardRoutine_d__8>.NativeClassPtr, 100668670);
      DrainLeaderAfterBattleSystem._ModifyCardRoutine_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrainLeaderAfterBattleSystem._ModifyCardRoutine_d__8>.NativeClassPtr, 100668671);
    }

    public _ModifyCardRoutine_d__8(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DrainLeaderAfterBattleSystem._ModifyCardRoutine_d__8.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DrainLeaderAfterBattleSystem._ModifyCardRoutine_d__8.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DrainLeaderAfterBattleSystem._ModifyCardRoutine_d__8.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DrainLeaderAfterBattleSystem._ModifyCardRoutine_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe DrainLeaderAfterBattleSystem __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DrainLeaderAfterBattleSystem._ModifyCardRoutine_d__8.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (DrainLeaderAfterBattleSystem) null : new DrainLeaderAfterBattleSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DrainLeaderAfterBattleSystem._ModifyCardRoutine_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CardData cardToModify
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DrainLeaderAfterBattleSystem._ModifyCardRoutine_d__8.NativeFieldInfoPtr_cardToModify));
        return pointer == System.IntPtr.Zero ? (CardData) null : new CardData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DrainLeaderAfterBattleSystem._ModifyCardRoutine_d__8.NativeFieldInfoPtr_cardToModify), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ModifyCardSequence _sequence_5__2
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DrainLeaderAfterBattleSystem._ModifyCardRoutine_d__8.NativeFieldInfoPtr__sequence_5__2));
        return pointer == System.IntPtr.Zero ? (ModifyCardSequence) null : new ModifyCardSequence(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DrainLeaderAfterBattleSystem._ModifyCardRoutine_d__8.NativeFieldInfoPtr__sequence_5__2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
