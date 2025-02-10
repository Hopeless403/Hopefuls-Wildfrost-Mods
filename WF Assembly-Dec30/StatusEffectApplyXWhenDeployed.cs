// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenDeployed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections;
using System.Runtime.InteropServices;

#nullable disable
public class StatusEffectApplyXWhenDeployed : StatusEffectApplyX
{
  private static readonly System.IntPtr NativeFieldInfoPtr_whenSelfDeployed;
  private static readonly System.IntPtr NativeFieldInfoPtr_whenAllyDeployed;
  private static readonly System.IntPtr NativeFieldInfoPtr_whenEnemyDeployed;
  private static readonly System.IntPtr NativeFieldInfoPtr_hackyHit;
  private static readonly System.IntPtr NativeFieldInfoPtr_isAlreadyOnBoard;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetMidBattleData_Public_Virtual_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RestoreMidBattleData_Public_Virtual_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RunEnableEvent_Public_Virtual_Boolean_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckEnable_Private_IEnumerator_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RunCardMoveEvent_Public_Virtual_Boolean_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckCardMove_Private_IEnumerator_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_WasMovedOnToBoard_Private_Static_Boolean_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsAlly_Private_Static_Boolean_Entity_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsEnemy_Private_Static_Boolean_Entity_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122580, XrefRangeEnd = 122584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Il2CppSystem.Object GetMidBattleData()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectApplyXWhenDeployed.NativeMethodInfoPtr_GetMidBattleData_Public_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122584, XrefRangeEnd = 122589, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void RestoreMidBattleData(Il2CppSystem.Object data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectApplyXWhenDeployed.NativeMethodInfoPtr_RestoreMidBattleData_Public_Virtual_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122589, XrefRangeEnd = 122603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Init()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectApplyXWhenDeployed.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122603, XrefRangeEnd = 122610, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool RunEnableEvent(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectApplyXWhenDeployed.NativeMethodInfoPtr_RunEnableEvent_Public_Virtual_Boolean_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122610, XrefRangeEnd = 122612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator CheckEnable(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectApplyXWhenDeployed.NativeMethodInfoPtr_CheckEnable_Private_IEnumerator_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122612, XrefRangeEnd = 122623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool RunCardMoveEvent(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectApplyXWhenDeployed.NativeMethodInfoPtr_RunCardMoveEvent_Public_Virtual_Boolean_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator CheckCardMove(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectApplyXWhenDeployed.NativeMethodInfoPtr_CheckCardMove_Private_IEnumerator_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122623, XrefRangeEnd = 122624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool WasMovedOnToBoard(Entity entity)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectApplyXWhenDeployed.NativeMethodInfoPtr_WasMovedOnToBoard_Private_Static_Boolean_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122624, XrefRangeEnd = 122628, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsAlly(Entity a, Entity b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) b);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectApplyXWhenDeployed.NativeMethodInfoPtr_IsAlly_Private_Static_Boolean_Entity_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe bool IsEnemy(Entity a, Entity b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) b);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectApplyXWhenDeployed.NativeMethodInfoPtr_IsEnemy_Private_Static_Boolean_Entity_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122628, XrefRangeEnd = 122629, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StatusEffectApplyXWhenDeployed()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusEffectApplyXWhenDeployed>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectApplyXWhenDeployed.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static StatusEffectApplyXWhenDeployed()
  {
    Il2CppClassPointerStore<StatusEffectApplyXWhenDeployed>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (StatusEffectApplyXWhenDeployed));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusEffectApplyXWhenDeployed>.NativeClassPtr);
    StatusEffectApplyXWhenDeployed.NativeFieldInfoPtr_whenSelfDeployed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectApplyXWhenDeployed>.NativeClassPtr, nameof (whenSelfDeployed));
    StatusEffectApplyXWhenDeployed.NativeFieldInfoPtr_whenAllyDeployed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectApplyXWhenDeployed>.NativeClassPtr, nameof (whenAllyDeployed));
    StatusEffectApplyXWhenDeployed.NativeFieldInfoPtr_whenEnemyDeployed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectApplyXWhenDeployed>.NativeClassPtr, nameof (whenEnemyDeployed));
    StatusEffectApplyXWhenDeployed.NativeFieldInfoPtr_hackyHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectApplyXWhenDeployed>.NativeClassPtr, nameof (hackyHit));
    StatusEffectApplyXWhenDeployed.NativeFieldInfoPtr_isAlreadyOnBoard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectApplyXWhenDeployed>.NativeClassPtr, nameof (isAlreadyOnBoard));
    StatusEffectApplyXWhenDeployed.NativeMethodInfoPtr_GetMidBattleData_Public_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectApplyXWhenDeployed>.NativeClassPtr, 100675530);
    StatusEffectApplyXWhenDeployed.NativeMethodInfoPtr_RestoreMidBattleData_Public_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectApplyXWhenDeployed>.NativeClassPtr, 100675531);
    StatusEffectApplyXWhenDeployed.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectApplyXWhenDeployed>.NativeClassPtr, 100675532);
    StatusEffectApplyXWhenDeployed.NativeMethodInfoPtr_RunEnableEvent_Public_Virtual_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectApplyXWhenDeployed>.NativeClassPtr, 100675533);
    StatusEffectApplyXWhenDeployed.NativeMethodInfoPtr_CheckEnable_Private_IEnumerator_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectApplyXWhenDeployed>.NativeClassPtr, 100675534);
    StatusEffectApplyXWhenDeployed.NativeMethodInfoPtr_RunCardMoveEvent_Public_Virtual_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectApplyXWhenDeployed>.NativeClassPtr, 100675535);
    StatusEffectApplyXWhenDeployed.NativeMethodInfoPtr_CheckCardMove_Private_IEnumerator_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectApplyXWhenDeployed>.NativeClassPtr, 100675536);
    StatusEffectApplyXWhenDeployed.NativeMethodInfoPtr_WasMovedOnToBoard_Private_Static_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectApplyXWhenDeployed>.NativeClassPtr, 100675537);
    StatusEffectApplyXWhenDeployed.NativeMethodInfoPtr_IsAlly_Private_Static_Boolean_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectApplyXWhenDeployed>.NativeClassPtr, 100675538);
    StatusEffectApplyXWhenDeployed.NativeMethodInfoPtr_IsEnemy_Private_Static_Boolean_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectApplyXWhenDeployed>.NativeClassPtr, 100675539);
    StatusEffectApplyXWhenDeployed.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectApplyXWhenDeployed>.NativeClassPtr, 100675540);
  }

  public StatusEffectApplyXWhenDeployed(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool whenSelfDeployed
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectApplyXWhenDeployed.NativeFieldInfoPtr_whenSelfDeployed));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectApplyXWhenDeployed.NativeFieldInfoPtr_whenSelfDeployed)) = value;
    }
  }

  public unsafe bool whenAllyDeployed
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectApplyXWhenDeployed.NativeFieldInfoPtr_whenAllyDeployed));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectApplyXWhenDeployed.NativeFieldInfoPtr_whenAllyDeployed)) = value;
    }
  }

  public unsafe bool whenEnemyDeployed
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectApplyXWhenDeployed.NativeFieldInfoPtr_whenEnemyDeployed));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectApplyXWhenDeployed.NativeFieldInfoPtr_whenEnemyDeployed)) = value;
    }
  }

  public unsafe Hit hackyHit
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectApplyXWhenDeployed.NativeFieldInfoPtr_hackyHit));
      return pointer == System.IntPtr.Zero ? (Hit) null : new Hit(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectApplyXWhenDeployed.NativeFieldInfoPtr_hackyHit), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool isAlreadyOnBoard
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectApplyXWhenDeployed.NativeFieldInfoPtr_isAlreadyOnBoard));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectApplyXWhenDeployed.NativeFieldInfoPtr_isAlreadyOnBoard)) = value;
    }
  }
}
