﻿// Decompiled with JetBrains decompiler
// Type: StatusEffectShuffleEnemiesAndAllies
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
public class StatusEffectShuffleEnemiesAndAllies : StatusEffectData
{
  private static readonly System.IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RunCardPlayedEvent_Public_Virtual_Boolean_Entity_Il2CppReferenceArray_1_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Run_Private_IEnumerator_Entity_Il2CppReferenceArray_1_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124225, XrefRangeEnd = 124233, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Init()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectShuffleEnemiesAndAllies.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124233, XrefRangeEnd = 124237, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool RunCardPlayedEvent(
    Entity entity,
    Il2CppReferenceArray<Entity> targets)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targets);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectShuffleEnemiesAndAllies.NativeMethodInfoPtr_RunCardPlayedEvent_Public_Virtual_Boolean_Entity_Il2CppReferenceArray_1_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124237, XrefRangeEnd = 124242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator Run(Entity entity, Il2CppReferenceArray<Entity> targets)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targets);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectShuffleEnemiesAndAllies.NativeMethodInfoPtr_Run_Private_IEnumerator_Entity_Il2CppReferenceArray_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(23)]
  [CachedScanResults(RefRangeStart = 118133, RefRangeEnd = 118156, XrefRangeStart = 118133, XrefRangeEnd = 118156, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StatusEffectShuffleEnemiesAndAllies()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusEffectShuffleEnemiesAndAllies>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectShuffleEnemiesAndAllies.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static StatusEffectShuffleEnemiesAndAllies()
  {
    Il2CppClassPointerStore<StatusEffectShuffleEnemiesAndAllies>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (StatusEffectShuffleEnemiesAndAllies));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusEffectShuffleEnemiesAndAllies>.NativeClassPtr);
    StatusEffectShuffleEnemiesAndAllies.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectShuffleEnemiesAndAllies>.NativeClassPtr, 100675813);
    StatusEffectShuffleEnemiesAndAllies.NativeMethodInfoPtr_RunCardPlayedEvent_Public_Virtual_Boolean_Entity_Il2CppReferenceArray_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectShuffleEnemiesAndAllies>.NativeClassPtr, 100675814);
    StatusEffectShuffleEnemiesAndAllies.NativeMethodInfoPtr_Run_Private_IEnumerator_Entity_Il2CppReferenceArray_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectShuffleEnemiesAndAllies>.NativeClassPtr, 100675815);
    StatusEffectShuffleEnemiesAndAllies.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectShuffleEnemiesAndAllies>.NativeClassPtr, 100675816);
  }

  public StatusEffectShuffleEnemiesAndAllies(System.IntPtr pointer)
    : base(pointer)
  {
  }

  [ObfuscatedName("StatusEffectShuffleEnemiesAndAllies/<Run>d__2")]
  public sealed class _Run_d__2 : Il2CppSystem.Object
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
    public unsafe _Run_d__2(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusEffectShuffleEnemiesAndAllies._Run_d__2>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatusEffectShuffleEnemiesAndAllies._Run_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatusEffectShuffleEnemiesAndAllies._Run_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124135, XrefRangeEnd = 124219, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectShuffleEnemiesAndAllies._Run_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectShuffleEnemiesAndAllies._Run_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124219, XrefRangeEnd = 124225, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatusEffectShuffleEnemiesAndAllies._Run_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectShuffleEnemiesAndAllies._Run_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _Run_d__2()
    {
      Il2CppClassPointerStore<StatusEffectShuffleEnemiesAndAllies._Run_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatusEffectShuffleEnemiesAndAllies>.NativeClassPtr, "<Run>d__2");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusEffectShuffleEnemiesAndAllies._Run_d__2>.NativeClassPtr);
      StatusEffectShuffleEnemiesAndAllies._Run_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectShuffleEnemiesAndAllies._Run_d__2>.NativeClassPtr, "<>1__state");
      StatusEffectShuffleEnemiesAndAllies._Run_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectShuffleEnemiesAndAllies._Run_d__2>.NativeClassPtr, "<>2__current");
      StatusEffectShuffleEnemiesAndAllies._Run_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectShuffleEnemiesAndAllies._Run_d__2>.NativeClassPtr, "<>4__this");
      StatusEffectShuffleEnemiesAndAllies._Run_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectShuffleEnemiesAndAllies._Run_d__2>.NativeClassPtr, 100675817);
      StatusEffectShuffleEnemiesAndAllies._Run_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectShuffleEnemiesAndAllies._Run_d__2>.NativeClassPtr, 100675818);
      StatusEffectShuffleEnemiesAndAllies._Run_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectShuffleEnemiesAndAllies._Run_d__2>.NativeClassPtr, 100675819);
      StatusEffectShuffleEnemiesAndAllies._Run_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectShuffleEnemiesAndAllies._Run_d__2>.NativeClassPtr, 100675820);
      StatusEffectShuffleEnemiesAndAllies._Run_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectShuffleEnemiesAndAllies._Run_d__2>.NativeClassPtr, 100675821);
      StatusEffectShuffleEnemiesAndAllies._Run_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectShuffleEnemiesAndAllies._Run_d__2>.NativeClassPtr, 100675822);
    }

    public _Run_d__2(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectShuffleEnemiesAndAllies._Run_d__2.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectShuffleEnemiesAndAllies._Run_d__2.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectShuffleEnemiesAndAllies._Run_d__2.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectShuffleEnemiesAndAllies._Run_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe StatusEffectShuffleEnemiesAndAllies __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectShuffleEnemiesAndAllies._Run_d__2.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (StatusEffectShuffleEnemiesAndAllies) null : new StatusEffectShuffleEnemiesAndAllies(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectShuffleEnemiesAndAllies._Run_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
