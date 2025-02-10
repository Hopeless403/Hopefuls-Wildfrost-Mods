// Decompiled with JetBrains decompiler
// Type: CardAnimationClunkerBossChange
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class CardAnimationClunkerBossChange : CardAnimation
{
  private static readonly System.IntPtr NativeFieldInfoPtr_explosionCountRange;
  private static readonly System.IntPtr NativeFieldInfoPtr_explosionDelayRange;
  private static readonly System.IntPtr NativeFieldInfoPtr_explosionStart;
  private static readonly System.IntPtr NativeFieldInfoPtr_explosion;
  private static readonly System.IntPtr NativeFieldInfoPtr_explosionEnd;
  private static readonly System.IntPtr NativeFieldInfoPtr_explosionPositionRandom;
  private static readonly System.IntPtr NativeFieldInfoPtr_duration;
  private static readonly System.IntPtr NativeFieldInfoPtr_rumbleAmount;
  private static readonly System.IntPtr NativeFieldInfoPtr_rumbleDurationIn;
  private static readonly System.IntPtr NativeFieldInfoPtr_rumbleDurationOut;
  private static readonly System.IntPtr NativeMethodInfoPtr_Routine_Public_Virtual_IEnumerator_Object_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RandomOffset_Private_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ExplodeAfterDelay_Private_IEnumerator_Single_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Explode_Private_Void_ParticleSystem_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107896, XrefRangeEnd = 107902, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IEnumerator Routine(Il2CppSystem.Object data, float startDelay = 0.0f)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &startDelay;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardAnimationClunkerBossChange.NativeMethodInfoPtr_Routine_Public_Virtual_IEnumerator_Object_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 107906, RefRangeEnd = 107908, XrefRangeStart = 107902, XrefRangeEnd = 107906, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 RandomOffset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardAnimationClunkerBossChange.NativeMethodInfoPtr_RandomOffset_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107908, XrefRangeEnd = 107913, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator ExplodeAfterDelay(float delay, Vector3 position)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &delay;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardAnimationClunkerBossChange.NativeMethodInfoPtr_ExplodeAfterDelay_Private_IEnumerator_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 107925, RefRangeEnd = 107927, XrefRangeStart = 107913, XrefRangeEnd = 107925, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Explode(ParticleSystem prefab, Vector3 position, float screenShake = 1f)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefab);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &screenShake;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardAnimationClunkerBossChange.NativeMethodInfoPtr_Explode_Private_Void_ParticleSystem_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107927, XrefRangeEnd = 107928, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardAnimationClunkerBossChange()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardAnimationClunkerBossChange>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardAnimationClunkerBossChange.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CardAnimationClunkerBossChange()
  {
    Il2CppClassPointerStore<CardAnimationClunkerBossChange>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CardAnimationClunkerBossChange));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardAnimationClunkerBossChange>.NativeClassPtr);
    CardAnimationClunkerBossChange.NativeFieldInfoPtr_explosionCountRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationClunkerBossChange>.NativeClassPtr, nameof (explosionCountRange));
    CardAnimationClunkerBossChange.NativeFieldInfoPtr_explosionDelayRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationClunkerBossChange>.NativeClassPtr, nameof (explosionDelayRange));
    CardAnimationClunkerBossChange.NativeFieldInfoPtr_explosionStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationClunkerBossChange>.NativeClassPtr, nameof (explosionStart));
    CardAnimationClunkerBossChange.NativeFieldInfoPtr_explosion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationClunkerBossChange>.NativeClassPtr, nameof (explosion));
    CardAnimationClunkerBossChange.NativeFieldInfoPtr_explosionEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationClunkerBossChange>.NativeClassPtr, nameof (explosionEnd));
    CardAnimationClunkerBossChange.NativeFieldInfoPtr_explosionPositionRandom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationClunkerBossChange>.NativeClassPtr, nameof (explosionPositionRandom));
    CardAnimationClunkerBossChange.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationClunkerBossChange>.NativeClassPtr, nameof (duration));
    CardAnimationClunkerBossChange.NativeFieldInfoPtr_rumbleAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationClunkerBossChange>.NativeClassPtr, nameof (rumbleAmount));
    CardAnimationClunkerBossChange.NativeFieldInfoPtr_rumbleDurationIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationClunkerBossChange>.NativeClassPtr, nameof (rumbleDurationIn));
    CardAnimationClunkerBossChange.NativeFieldInfoPtr_rumbleDurationOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationClunkerBossChange>.NativeClassPtr, nameof (rumbleDurationOut));
    CardAnimationClunkerBossChange.NativeMethodInfoPtr_Routine_Public_Virtual_IEnumerator_Object_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardAnimationClunkerBossChange>.NativeClassPtr, 100673177);
    CardAnimationClunkerBossChange.NativeMethodInfoPtr_RandomOffset_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardAnimationClunkerBossChange>.NativeClassPtr, 100673178);
    CardAnimationClunkerBossChange.NativeMethodInfoPtr_ExplodeAfterDelay_Private_IEnumerator_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardAnimationClunkerBossChange>.NativeClassPtr, 100673179);
    CardAnimationClunkerBossChange.NativeMethodInfoPtr_Explode_Private_Void_ParticleSystem_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardAnimationClunkerBossChange>.NativeClassPtr, 100673180);
    CardAnimationClunkerBossChange.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardAnimationClunkerBossChange>.NativeClassPtr, 100673181);
  }

  public CardAnimationClunkerBossChange(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Vector2Int explosionCountRange
  {
    get
    {
      return *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationClunkerBossChange.NativeFieldInfoPtr_explosionCountRange));
    }
    [param: In] set
    {
      *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationClunkerBossChange.NativeFieldInfoPtr_explosionCountRange)) = value;
    }
  }

  public unsafe Vector2 explosionDelayRange
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationClunkerBossChange.NativeFieldInfoPtr_explosionDelayRange));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationClunkerBossChange.NativeFieldInfoPtr_explosionDelayRange)) = value;
    }
  }

  public unsafe ParticleSystem explosionStart
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationClunkerBossChange.NativeFieldInfoPtr_explosionStart));
      return pointer == System.IntPtr.Zero ? (ParticleSystem) null : new ParticleSystem(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationClunkerBossChange.NativeFieldInfoPtr_explosionStart), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ParticleSystem explosion
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationClunkerBossChange.NativeFieldInfoPtr_explosion));
      return pointer == System.IntPtr.Zero ? (ParticleSystem) null : new ParticleSystem(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationClunkerBossChange.NativeFieldInfoPtr_explosion), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ParticleSystem explosionEnd
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationClunkerBossChange.NativeFieldInfoPtr_explosionEnd));
      return pointer == System.IntPtr.Zero ? (ParticleSystem) null : new ParticleSystem(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationClunkerBossChange.NativeFieldInfoPtr_explosionEnd), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float explosionPositionRandom
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationClunkerBossChange.NativeFieldInfoPtr_explosionPositionRandom));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationClunkerBossChange.NativeFieldInfoPtr_explosionPositionRandom)) = value;
    }
  }

  public unsafe float duration
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationClunkerBossChange.NativeFieldInfoPtr_duration));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationClunkerBossChange.NativeFieldInfoPtr_duration)) = value;
    }
  }

  public unsafe float rumbleAmount
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationClunkerBossChange.NativeFieldInfoPtr_rumbleAmount));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationClunkerBossChange.NativeFieldInfoPtr_rumbleAmount)) = value;
    }
  }

  public unsafe float rumbleDurationIn
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationClunkerBossChange.NativeFieldInfoPtr_rumbleDurationIn));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationClunkerBossChange.NativeFieldInfoPtr_rumbleDurationIn)) = value;
    }
  }

  public unsafe float rumbleDurationOut
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationClunkerBossChange.NativeFieldInfoPtr_rumbleDurationOut));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationClunkerBossChange.NativeFieldInfoPtr_rumbleDurationOut)) = value;
    }
  }

  [ObfuscatedName("CardAnimationClunkerBossChange/<Routine>d__10")]
  public sealed class _Routine_d__10 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr_data;
    private static readonly System.IntPtr NativeFieldInfoPtr_startDelay;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr__target_5__2;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _Routine_d__10(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardAnimationClunkerBossChange._Routine_d__10>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardAnimationClunkerBossChange._Routine_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardAnimationClunkerBossChange._Routine_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107833, XrefRangeEnd = 107879, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardAnimationClunkerBossChange._Routine_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardAnimationClunkerBossChange._Routine_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107879, XrefRangeEnd = 107885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardAnimationClunkerBossChange._Routine_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardAnimationClunkerBossChange._Routine_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _Routine_d__10()
    {
      Il2CppClassPointerStore<CardAnimationClunkerBossChange._Routine_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CardAnimationClunkerBossChange>.NativeClassPtr, "<Routine>d__10");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardAnimationClunkerBossChange._Routine_d__10>.NativeClassPtr);
      CardAnimationClunkerBossChange._Routine_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationClunkerBossChange._Routine_d__10>.NativeClassPtr, "<>1__state");
      CardAnimationClunkerBossChange._Routine_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationClunkerBossChange._Routine_d__10>.NativeClassPtr, "<>2__current");
      CardAnimationClunkerBossChange._Routine_d__10.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationClunkerBossChange._Routine_d__10>.NativeClassPtr, nameof (data));
      CardAnimationClunkerBossChange._Routine_d__10.NativeFieldInfoPtr_startDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationClunkerBossChange._Routine_d__10>.NativeClassPtr, nameof (startDelay));
      CardAnimationClunkerBossChange._Routine_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationClunkerBossChange._Routine_d__10>.NativeClassPtr, "<>4__this");
      CardAnimationClunkerBossChange._Routine_d__10.NativeFieldInfoPtr__target_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationClunkerBossChange._Routine_d__10>.NativeClassPtr, "<target>5__2");
      CardAnimationClunkerBossChange._Routine_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardAnimationClunkerBossChange._Routine_d__10>.NativeClassPtr, 100673182);
      CardAnimationClunkerBossChange._Routine_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardAnimationClunkerBossChange._Routine_d__10>.NativeClassPtr, 100673183);
      CardAnimationClunkerBossChange._Routine_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardAnimationClunkerBossChange._Routine_d__10>.NativeClassPtr, 100673184);
      CardAnimationClunkerBossChange._Routine_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardAnimationClunkerBossChange._Routine_d__10>.NativeClassPtr, 100673185);
      CardAnimationClunkerBossChange._Routine_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardAnimationClunkerBossChange._Routine_d__10>.NativeClassPtr, 100673186);
      CardAnimationClunkerBossChange._Routine_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardAnimationClunkerBossChange._Routine_d__10>.NativeClassPtr, 100673187);
    }

    public _Routine_d__10(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationClunkerBossChange._Routine_d__10.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationClunkerBossChange._Routine_d__10.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationClunkerBossChange._Routine_d__10.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationClunkerBossChange._Routine_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Object data
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationClunkerBossChange._Routine_d__10.NativeFieldInfoPtr_data));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationClunkerBossChange._Routine_d__10.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float startDelay
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationClunkerBossChange._Routine_d__10.NativeFieldInfoPtr_startDelay));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationClunkerBossChange._Routine_d__10.NativeFieldInfoPtr_startDelay)) = value;
      }
    }

    public unsafe CardAnimationClunkerBossChange __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationClunkerBossChange._Routine_d__10.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (CardAnimationClunkerBossChange) null : new CardAnimationClunkerBossChange(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationClunkerBossChange._Routine_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity _target_5__2
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationClunkerBossChange._Routine_d__10.NativeFieldInfoPtr__target_5__2));
        return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationClunkerBossChange._Routine_d__10.NativeFieldInfoPtr__target_5__2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("CardAnimationClunkerBossChange/<ExplodeAfterDelay>d__12")]
  public sealed class _ExplodeAfterDelay_d__12 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr_delay;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_position;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _ExplodeAfterDelay_d__12(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardAnimationClunkerBossChange._ExplodeAfterDelay_d__12>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardAnimationClunkerBossChange._ExplodeAfterDelay_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardAnimationClunkerBossChange._ExplodeAfterDelay_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107885, XrefRangeEnd = 107890, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardAnimationClunkerBossChange._ExplodeAfterDelay_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardAnimationClunkerBossChange._ExplodeAfterDelay_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107890, XrefRangeEnd = 107896, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardAnimationClunkerBossChange._ExplodeAfterDelay_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardAnimationClunkerBossChange._ExplodeAfterDelay_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _ExplodeAfterDelay_d__12()
    {
      Il2CppClassPointerStore<CardAnimationClunkerBossChange._ExplodeAfterDelay_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CardAnimationClunkerBossChange>.NativeClassPtr, "<ExplodeAfterDelay>d__12");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardAnimationClunkerBossChange._ExplodeAfterDelay_d__12>.NativeClassPtr);
      CardAnimationClunkerBossChange._ExplodeAfterDelay_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationClunkerBossChange._ExplodeAfterDelay_d__12>.NativeClassPtr, "<>1__state");
      CardAnimationClunkerBossChange._ExplodeAfterDelay_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationClunkerBossChange._ExplodeAfterDelay_d__12>.NativeClassPtr, "<>2__current");
      CardAnimationClunkerBossChange._ExplodeAfterDelay_d__12.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationClunkerBossChange._ExplodeAfterDelay_d__12>.NativeClassPtr, nameof (delay));
      CardAnimationClunkerBossChange._ExplodeAfterDelay_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationClunkerBossChange._ExplodeAfterDelay_d__12>.NativeClassPtr, "<>4__this");
      CardAnimationClunkerBossChange._ExplodeAfterDelay_d__12.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationClunkerBossChange._ExplodeAfterDelay_d__12>.NativeClassPtr, nameof (position));
      CardAnimationClunkerBossChange._ExplodeAfterDelay_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardAnimationClunkerBossChange._ExplodeAfterDelay_d__12>.NativeClassPtr, 100673188);
      CardAnimationClunkerBossChange._ExplodeAfterDelay_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardAnimationClunkerBossChange._ExplodeAfterDelay_d__12>.NativeClassPtr, 100673189);
      CardAnimationClunkerBossChange._ExplodeAfterDelay_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardAnimationClunkerBossChange._ExplodeAfterDelay_d__12>.NativeClassPtr, 100673190);
      CardAnimationClunkerBossChange._ExplodeAfterDelay_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardAnimationClunkerBossChange._ExplodeAfterDelay_d__12>.NativeClassPtr, 100673191);
      CardAnimationClunkerBossChange._ExplodeAfterDelay_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardAnimationClunkerBossChange._ExplodeAfterDelay_d__12>.NativeClassPtr, 100673192);
      CardAnimationClunkerBossChange._ExplodeAfterDelay_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardAnimationClunkerBossChange._ExplodeAfterDelay_d__12>.NativeClassPtr, 100673193);
    }

    public _ExplodeAfterDelay_d__12(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationClunkerBossChange._ExplodeAfterDelay_d__12.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationClunkerBossChange._ExplodeAfterDelay_d__12.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationClunkerBossChange._ExplodeAfterDelay_d__12.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationClunkerBossChange._ExplodeAfterDelay_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float delay
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationClunkerBossChange._ExplodeAfterDelay_d__12.NativeFieldInfoPtr_delay));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationClunkerBossChange._ExplodeAfterDelay_d__12.NativeFieldInfoPtr_delay)) = value;
      }
    }

    public unsafe CardAnimationClunkerBossChange __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationClunkerBossChange._ExplodeAfterDelay_d__12.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (CardAnimationClunkerBossChange) null : new CardAnimationClunkerBossChange(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationClunkerBossChange._ExplodeAfterDelay_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Vector3 position
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationClunkerBossChange._ExplodeAfterDelay_d__12.NativeFieldInfoPtr_position));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationClunkerBossChange._ExplodeAfterDelay_d__12.NativeFieldInfoPtr_position)) = value;
      }
    }
  }
}
