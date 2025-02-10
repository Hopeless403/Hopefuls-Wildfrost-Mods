// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXOnHit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;

#nullable disable
public class StatusEffectApplyXOnHit : StatusEffectApplyX
{
  private static readonly System.IntPtr NativeFieldInfoPtr_postHit;
  private static readonly System.IntPtr NativeFieldInfoPtr_addDamageFactor;
  private static readonly System.IntPtr NativeFieldInfoPtr_multiplyDamageFactor;
  private static readonly System.IntPtr NativeFieldInfoPtr_storedHit;
  private static readonly System.IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RunPreAttackEvent_Public_Virtual_Boolean_Hit_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RunPostHitEvent_Public_Virtual_Boolean_Hit_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RunHitEvent_Public_Virtual_Boolean_Hit_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckHit_Private_IEnumerator_Hit_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121861, XrefRangeEnd = 121873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Init()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectApplyXOnHit.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121873, XrefRangeEnd = 121893, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool RunPreAttackEvent(Hit hit)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hit)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectApplyXOnHit.NativeMethodInfoPtr_RunPreAttackEvent_Public_Virtual_Boolean_Hit_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121893, XrefRangeEnd = 121896, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool RunPostHitEvent(Hit hit)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hit)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectApplyXOnHit.NativeMethodInfoPtr_RunPostHitEvent_Public_Virtual_Boolean_Hit_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121896, XrefRangeEnd = 121899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool RunHitEvent(Hit hit)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hit)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectApplyXOnHit.NativeMethodInfoPtr_RunHitEvent_Public_Virtual_Boolean_Hit_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121899, XrefRangeEnd = 121905, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator CheckHit(Hit hit)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hit)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectApplyXOnHit.NativeMethodInfoPtr_CheckHit_Private_IEnumerator_Hit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121905, XrefRangeEnd = 121914, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StatusEffectApplyXOnHit()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusEffectApplyXOnHit>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectApplyXOnHit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static StatusEffectApplyXOnHit()
  {
    Il2CppClassPointerStore<StatusEffectApplyXOnHit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (StatusEffectApplyXOnHit));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusEffectApplyXOnHit>.NativeClassPtr);
    StatusEffectApplyXOnHit.NativeFieldInfoPtr_postHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectApplyXOnHit>.NativeClassPtr, nameof (postHit));
    StatusEffectApplyXOnHit.NativeFieldInfoPtr_addDamageFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectApplyXOnHit>.NativeClassPtr, nameof (addDamageFactor));
    StatusEffectApplyXOnHit.NativeFieldInfoPtr_multiplyDamageFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectApplyXOnHit>.NativeClassPtr, nameof (multiplyDamageFactor));
    StatusEffectApplyXOnHit.NativeFieldInfoPtr_storedHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectApplyXOnHit>.NativeClassPtr, nameof (storedHit));
    StatusEffectApplyXOnHit.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectApplyXOnHit>.NativeClassPtr, 100675370);
    StatusEffectApplyXOnHit.NativeMethodInfoPtr_RunPreAttackEvent_Public_Virtual_Boolean_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectApplyXOnHit>.NativeClassPtr, 100675371);
    StatusEffectApplyXOnHit.NativeMethodInfoPtr_RunPostHitEvent_Public_Virtual_Boolean_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectApplyXOnHit>.NativeClassPtr, 100675372);
    StatusEffectApplyXOnHit.NativeMethodInfoPtr_RunHitEvent_Public_Virtual_Boolean_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectApplyXOnHit>.NativeClassPtr, 100675373);
    StatusEffectApplyXOnHit.NativeMethodInfoPtr_CheckHit_Private_IEnumerator_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectApplyXOnHit>.NativeClassPtr, 100675374);
    StatusEffectApplyXOnHit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectApplyXOnHit>.NativeClassPtr, 100675375);
  }

  public StatusEffectApplyXOnHit(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool postHit
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectApplyXOnHit.NativeFieldInfoPtr_postHit));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectApplyXOnHit.NativeFieldInfoPtr_postHit)) = value;
    }
  }

  public unsafe int addDamageFactor
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectApplyXOnHit.NativeFieldInfoPtr_addDamageFactor));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectApplyXOnHit.NativeFieldInfoPtr_addDamageFactor)) = value;
    }
  }

  public unsafe float multiplyDamageFactor
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectApplyXOnHit.NativeFieldInfoPtr_multiplyDamageFactor));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectApplyXOnHit.NativeFieldInfoPtr_multiplyDamageFactor)) = value;
    }
  }

  public unsafe List<Hit> storedHit
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectApplyXOnHit.NativeFieldInfoPtr_storedHit));
      return pointer == System.IntPtr.Zero ? (List<Hit>) null : new List<Hit>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectApplyXOnHit.NativeFieldInfoPtr_storedHit), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("StatusEffectApplyXOnHit/<CheckHit>d__8")]
  public sealed class _CheckHit_d__8 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_hit;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _CheckHit_d__8(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusEffectApplyXOnHit._CheckHit_d__8>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatusEffectApplyXOnHit._CheckHit_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatusEffectApplyXOnHit._CheckHit_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121847, XrefRangeEnd = 121855, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectApplyXOnHit._CheckHit_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectApplyXOnHit._CheckHit_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121855, XrefRangeEnd = 121861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatusEffectApplyXOnHit._CheckHit_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectApplyXOnHit._CheckHit_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _CheckHit_d__8()
    {
      Il2CppClassPointerStore<StatusEffectApplyXOnHit._CheckHit_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatusEffectApplyXOnHit>.NativeClassPtr, "<CheckHit>d__8");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusEffectApplyXOnHit._CheckHit_d__8>.NativeClassPtr);
      StatusEffectApplyXOnHit._CheckHit_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectApplyXOnHit._CheckHit_d__8>.NativeClassPtr, "<>1__state");
      StatusEffectApplyXOnHit._CheckHit_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectApplyXOnHit._CheckHit_d__8>.NativeClassPtr, "<>2__current");
      StatusEffectApplyXOnHit._CheckHit_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectApplyXOnHit._CheckHit_d__8>.NativeClassPtr, "<>4__this");
      StatusEffectApplyXOnHit._CheckHit_d__8.NativeFieldInfoPtr_hit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectApplyXOnHit._CheckHit_d__8>.NativeClassPtr, nameof (hit));
      StatusEffectApplyXOnHit._CheckHit_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectApplyXOnHit._CheckHit_d__8>.NativeClassPtr, 100675376);
      StatusEffectApplyXOnHit._CheckHit_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectApplyXOnHit._CheckHit_d__8>.NativeClassPtr, 100675377);
      StatusEffectApplyXOnHit._CheckHit_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectApplyXOnHit._CheckHit_d__8>.NativeClassPtr, 100675378);
      StatusEffectApplyXOnHit._CheckHit_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectApplyXOnHit._CheckHit_d__8>.NativeClassPtr, 100675379);
      StatusEffectApplyXOnHit._CheckHit_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectApplyXOnHit._CheckHit_d__8>.NativeClassPtr, 100675380);
      StatusEffectApplyXOnHit._CheckHit_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectApplyXOnHit._CheckHit_d__8>.NativeClassPtr, 100675381);
    }

    public _CheckHit_d__8(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectApplyXOnHit._CheckHit_d__8.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectApplyXOnHit._CheckHit_d__8.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectApplyXOnHit._CheckHit_d__8.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectApplyXOnHit._CheckHit_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe StatusEffectApplyXOnHit __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectApplyXOnHit._CheckHit_d__8.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (StatusEffectApplyXOnHit) null : new StatusEffectApplyXOnHit(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectApplyXOnHit._CheckHit_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Hit hit
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectApplyXOnHit._CheckHit_d__8.NativeFieldInfoPtr_hit));
        return pointer == System.IntPtr.Zero ? (Hit) null : new Hit(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectApplyXOnHit._CheckHit_d__8.NativeFieldInfoPtr_hit), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
