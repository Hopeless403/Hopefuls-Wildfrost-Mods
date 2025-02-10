// Decompiled with JetBrains decompiler
// Type: StatusEffectBonusDamageEqualToX
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
public class StatusEffectBonusDamageEqualToX : StatusEffectData
{
  private static readonly System.IntPtr NativeFieldInfoPtr_on;
  private static readonly System.IntPtr NativeFieldInfoPtr_scriptableAmount;
  private static readonly System.IntPtr NativeFieldInfoPtr_add;
  private static readonly System.IntPtr NativeFieldInfoPtr_health;
  private static readonly System.IntPtr NativeFieldInfoPtr_effectType;
  private static readonly System.IntPtr NativeFieldInfoPtr_ping;
  private static readonly System.IntPtr NativeFieldInfoPtr_currentAmount;
  private static readonly System.IntPtr NativeFieldInfoPtr_toReset;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_useScriptableAmount_Private_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RunPreCardPlayedEvent_Public_Virtual_Boolean_Entity_Il2CppReferenceArray_1_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Gain_Private_IEnumerator_Entity_Il2CppReferenceArray_1_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RunTurnEndEvent_Public_Virtual_Boolean_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Find_Private_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FindOnSelf_Private_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FindOnBoard_Private_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__FindOnBoard_b__17_0_Private_Int32_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__FindOnBoard_b__17_1_Private_StatusEffectData_Entity_0;

  public unsafe bool useScriptableAmount
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectBonusDamageEqualToX.NativeMethodInfoPtr_get_useScriptableAmount_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123637, XrefRangeEnd = 123645, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Init()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectBonusDamageEqualToX.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123645, XrefRangeEnd = 123649, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool RunPreCardPlayedEvent(
    Entity entity,
    Il2CppReferenceArray<Entity> targets)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targets);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectBonusDamageEqualToX.NativeMethodInfoPtr_RunPreCardPlayedEvent_Public_Virtual_Boolean_Entity_Il2CppReferenceArray_1_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123649, XrefRangeEnd = 123654, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator Gain(Entity entity, Il2CppReferenceArray<Entity> targets)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targets);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectBonusDamageEqualToX.NativeMethodInfoPtr_Gain_Private_IEnumerator_Entity_Il2CppReferenceArray_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123654, XrefRangeEnd = 123660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool RunTurnEndEvent(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectBonusDamageEqualToX.NativeMethodInfoPtr_RunTurnEndEvent_Public_Virtual_Boolean_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public unsafe int Find()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectBonusDamageEqualToX.NativeMethodInfoPtr_Find_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123660, XrefRangeEnd = 123665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int FindOnSelf()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectBonusDamageEqualToX.NativeMethodInfoPtr_FindOnSelf_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 123720, RefRangeEnd = 123721, XrefRangeStart = 123665, XrefRangeEnd = 123720, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int FindOnBoard()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectBonusDamageEqualToX.NativeMethodInfoPtr_FindOnBoard_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123721, XrefRangeEnd = 123726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StatusEffectBonusDamageEqualToX()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusEffectBonusDamageEqualToX>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectBonusDamageEqualToX.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123726, XrefRangeEnd = 123728, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int _FindOnBoard_b__17_0(Entity e)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) e)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectBonusDamageEqualToX.NativeMethodInfoPtr__FindOnBoard_b__17_0_Private_Int32_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123728, XrefRangeEnd = 123730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StatusEffectData _FindOnBoard_b__17_1(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectBonusDamageEqualToX.NativeMethodInfoPtr__FindOnBoard_b__17_1_Private_StatusEffectData_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (StatusEffectData) null : new StatusEffectData(pointer);
  }

  static StatusEffectBonusDamageEqualToX()
  {
    Il2CppClassPointerStore<StatusEffectBonusDamageEqualToX>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (StatusEffectBonusDamageEqualToX));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusEffectBonusDamageEqualToX>.NativeClassPtr);
    StatusEffectBonusDamageEqualToX.NativeFieldInfoPtr_on = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectBonusDamageEqualToX>.NativeClassPtr, nameof (on));
    StatusEffectBonusDamageEqualToX.NativeFieldInfoPtr_scriptableAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectBonusDamageEqualToX>.NativeClassPtr, nameof (scriptableAmount));
    StatusEffectBonusDamageEqualToX.NativeFieldInfoPtr_add = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectBonusDamageEqualToX>.NativeClassPtr, nameof (add));
    StatusEffectBonusDamageEqualToX.NativeFieldInfoPtr_health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectBonusDamageEqualToX>.NativeClassPtr, nameof (health));
    StatusEffectBonusDamageEqualToX.NativeFieldInfoPtr_effectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectBonusDamageEqualToX>.NativeClassPtr, nameof (effectType));
    StatusEffectBonusDamageEqualToX.NativeFieldInfoPtr_ping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectBonusDamageEqualToX>.NativeClassPtr, nameof (ping));
    StatusEffectBonusDamageEqualToX.NativeFieldInfoPtr_currentAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectBonusDamageEqualToX>.NativeClassPtr, nameof (currentAmount));
    StatusEffectBonusDamageEqualToX.NativeFieldInfoPtr_toReset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectBonusDamageEqualToX>.NativeClassPtr, nameof (toReset));
    StatusEffectBonusDamageEqualToX.NativeMethodInfoPtr_get_useScriptableAmount_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectBonusDamageEqualToX>.NativeClassPtr, 100675700);
    StatusEffectBonusDamageEqualToX.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectBonusDamageEqualToX>.NativeClassPtr, 100675701);
    StatusEffectBonusDamageEqualToX.NativeMethodInfoPtr_RunPreCardPlayedEvent_Public_Virtual_Boolean_Entity_Il2CppReferenceArray_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectBonusDamageEqualToX>.NativeClassPtr, 100675702);
    StatusEffectBonusDamageEqualToX.NativeMethodInfoPtr_Gain_Private_IEnumerator_Entity_Il2CppReferenceArray_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectBonusDamageEqualToX>.NativeClassPtr, 100675703);
    StatusEffectBonusDamageEqualToX.NativeMethodInfoPtr_RunTurnEndEvent_Public_Virtual_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectBonusDamageEqualToX>.NativeClassPtr, 100675704);
    StatusEffectBonusDamageEqualToX.NativeMethodInfoPtr_Find_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectBonusDamageEqualToX>.NativeClassPtr, 100675705);
    StatusEffectBonusDamageEqualToX.NativeMethodInfoPtr_FindOnSelf_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectBonusDamageEqualToX>.NativeClassPtr, 100675706);
    StatusEffectBonusDamageEqualToX.NativeMethodInfoPtr_FindOnBoard_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectBonusDamageEqualToX>.NativeClassPtr, 100675707);
    StatusEffectBonusDamageEqualToX.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectBonusDamageEqualToX>.NativeClassPtr, 100675708);
    StatusEffectBonusDamageEqualToX.NativeMethodInfoPtr__FindOnBoard_b__17_0_Private_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectBonusDamageEqualToX>.NativeClassPtr, 100675709);
    StatusEffectBonusDamageEqualToX.NativeMethodInfoPtr__FindOnBoard_b__17_1_Private_StatusEffectData_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectBonusDamageEqualToX>.NativeClassPtr, 100675710);
  }

  public StatusEffectBonusDamageEqualToX(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe StatusEffectBonusDamageEqualToX.On on
  {
    get
    {
      return *(StatusEffectBonusDamageEqualToX.On*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectBonusDamageEqualToX.NativeFieldInfoPtr_on));
    }
    [param: In] set
    {
      *(StatusEffectBonusDamageEqualToX.On*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectBonusDamageEqualToX.NativeFieldInfoPtr_on)) = value;
    }
  }

  public unsafe ScriptableAmount scriptableAmount
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectBonusDamageEqualToX.NativeFieldInfoPtr_scriptableAmount));
      return pointer == System.IntPtr.Zero ? (ScriptableAmount) null : new ScriptableAmount(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectBonusDamageEqualToX.NativeFieldInfoPtr_scriptableAmount), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool add
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectBonusDamageEqualToX.NativeFieldInfoPtr_add));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectBonusDamageEqualToX.NativeFieldInfoPtr_add)) = value;
    }
  }

  public unsafe bool health
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectBonusDamageEqualToX.NativeFieldInfoPtr_health));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectBonusDamageEqualToX.NativeFieldInfoPtr_health)) = value;
    }
  }

  public unsafe string effectType
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectBonusDamageEqualToX.NativeFieldInfoPtr_effectType)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectBonusDamageEqualToX.NativeFieldInfoPtr_effectType), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe bool ping
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectBonusDamageEqualToX.NativeFieldInfoPtr_ping));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectBonusDamageEqualToX.NativeFieldInfoPtr_ping)) = value;
    }
  }

  public unsafe int currentAmount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectBonusDamageEqualToX.NativeFieldInfoPtr_currentAmount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectBonusDamageEqualToX.NativeFieldInfoPtr_currentAmount)) = value;
    }
  }

  public unsafe bool toReset
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectBonusDamageEqualToX.NativeFieldInfoPtr_toReset));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectBonusDamageEqualToX.NativeFieldInfoPtr_toReset)) = value;
    }
  }

  public enum On
  {
    Self,
    Board,
    ScriptableAmount,
  }

  [ObfuscatedName("StatusEffectBonusDamageEqualToX/<Gain>d__13")]
  public sealed class _Gain_d__13 : Il2CppSystem.Object
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
    public unsafe _Gain_d__13(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusEffectBonusDamageEqualToX._Gain_d__13>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatusEffectBonusDamageEqualToX._Gain_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatusEffectBonusDamageEqualToX._Gain_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123607, XrefRangeEnd = 123627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectBonusDamageEqualToX._Gain_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectBonusDamageEqualToX._Gain_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123627, XrefRangeEnd = 123633, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatusEffectBonusDamageEqualToX._Gain_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectBonusDamageEqualToX._Gain_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _Gain_d__13()
    {
      Il2CppClassPointerStore<StatusEffectBonusDamageEqualToX._Gain_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatusEffectBonusDamageEqualToX>.NativeClassPtr, "<Gain>d__13");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusEffectBonusDamageEqualToX._Gain_d__13>.NativeClassPtr);
      StatusEffectBonusDamageEqualToX._Gain_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectBonusDamageEqualToX._Gain_d__13>.NativeClassPtr, "<>1__state");
      StatusEffectBonusDamageEqualToX._Gain_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectBonusDamageEqualToX._Gain_d__13>.NativeClassPtr, "<>2__current");
      StatusEffectBonusDamageEqualToX._Gain_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectBonusDamageEqualToX._Gain_d__13>.NativeClassPtr, "<>4__this");
      StatusEffectBonusDamageEqualToX._Gain_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectBonusDamageEqualToX._Gain_d__13>.NativeClassPtr, 100675711);
      StatusEffectBonusDamageEqualToX._Gain_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectBonusDamageEqualToX._Gain_d__13>.NativeClassPtr, 100675712);
      StatusEffectBonusDamageEqualToX._Gain_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectBonusDamageEqualToX._Gain_d__13>.NativeClassPtr, 100675713);
      StatusEffectBonusDamageEqualToX._Gain_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectBonusDamageEqualToX._Gain_d__13>.NativeClassPtr, 100675714);
      StatusEffectBonusDamageEqualToX._Gain_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectBonusDamageEqualToX._Gain_d__13>.NativeClassPtr, 100675715);
      StatusEffectBonusDamageEqualToX._Gain_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectBonusDamageEqualToX._Gain_d__13>.NativeClassPtr, 100675716);
    }

    public _Gain_d__13(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectBonusDamageEqualToX._Gain_d__13.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectBonusDamageEqualToX._Gain_d__13.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectBonusDamageEqualToX._Gain_d__13.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectBonusDamageEqualToX._Gain_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe StatusEffectBonusDamageEqualToX __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectBonusDamageEqualToX._Gain_d__13.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (StatusEffectBonusDamageEqualToX) null : new StatusEffectBonusDamageEqualToX(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectBonusDamageEqualToX._Gain_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("StatusEffectBonusDamageEqualToX/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__17_2;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__17_3;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__FindOnBoard_b__17_2_Internal_Boolean_StatusEffectData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__FindOnBoard_b__17_3_Internal_Int32_StatusEffectData_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusEffectBonusDamageEqualToX.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatusEffectBonusDamageEqualToX.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123633, XrefRangeEnd = 123637, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _FindOnBoard_b__17_2(StatusEffectData effect)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) effect)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectBonusDamageEqualToX.__c.NativeMethodInfoPtr__FindOnBoard_b__17_2_Internal_Boolean_StatusEffectData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe int _FindOnBoard_b__17_3(StatusEffectData effect)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) effect)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectBonusDamageEqualToX.__c.NativeMethodInfoPtr__FindOnBoard_b__17_3_Internal_Int32_StatusEffectData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<StatusEffectBonusDamageEqualToX.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatusEffectBonusDamageEqualToX>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusEffectBonusDamageEqualToX.__c>.NativeClassPtr);
      StatusEffectBonusDamageEqualToX.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectBonusDamageEqualToX.__c>.NativeClassPtr, "<>9");
      StatusEffectBonusDamageEqualToX.__c.NativeFieldInfoPtr___9__17_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectBonusDamageEqualToX.__c>.NativeClassPtr, "<>9__17_2");
      StatusEffectBonusDamageEqualToX.__c.NativeFieldInfoPtr___9__17_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectBonusDamageEqualToX.__c>.NativeClassPtr, "<>9__17_3");
      StatusEffectBonusDamageEqualToX.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectBonusDamageEqualToX.__c>.NativeClassPtr, 100675718);
      StatusEffectBonusDamageEqualToX.__c.NativeMethodInfoPtr__FindOnBoard_b__17_2_Internal_Boolean_StatusEffectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectBonusDamageEqualToX.__c>.NativeClassPtr, 100675719);
      StatusEffectBonusDamageEqualToX.__c.NativeMethodInfoPtr__FindOnBoard_b__17_3_Internal_Int32_StatusEffectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectBonusDamageEqualToX.__c>.NativeClassPtr, 100675720);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe StatusEffectBonusDamageEqualToX.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(StatusEffectBonusDamageEqualToX.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (StatusEffectBonusDamageEqualToX.__c) null : new StatusEffectBonusDamageEqualToX.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StatusEffectBonusDamageEqualToX.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<StatusEffectData, bool> __9__17_2
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(StatusEffectBonusDamageEqualToX.__c.NativeFieldInfoPtr___9__17_2, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<StatusEffectData, bool>) null : new Il2CppSystem.Func<StatusEffectData, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StatusEffectBonusDamageEqualToX.__c.NativeFieldInfoPtr___9__17_2, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<StatusEffectData, int> __9__17_3
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(StatusEffectBonusDamageEqualToX.__c.NativeFieldInfoPtr___9__17_3, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<StatusEffectData, int>) null : new Il2CppSystem.Func<StatusEffectData, int>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StatusEffectBonusDamageEqualToX.__c.NativeFieldInfoPtr___9__17_3, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
