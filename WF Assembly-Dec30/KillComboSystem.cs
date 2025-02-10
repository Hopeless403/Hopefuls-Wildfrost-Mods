// Decompiled with JetBrains decompiler
// Type: KillComboSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class KillComboSystem : GameSystem
{
  private static readonly IntPtr NativeFieldInfoPtr_colors;
  private static readonly IntPtr NativeFieldInfoPtr_format;
  private static readonly IntPtr NativeFieldInfoPtr_min;
  private static readonly IntPtr NativeFieldInfoPtr_baseGold;
  private static readonly IntPtr NativeFieldInfoPtr_goldPerCombo;
  private static readonly IntPtr NativeFieldInfoPtr_count;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_BattlePhaseStart_Private_Void_Phase_0;
  private static readonly IntPtr NativeMethodInfoPtr_BattleTurnEnd_Private_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_EntityKilled_Private_Void_Entity_DeathType_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetGoldAmount_Private_Int32_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62782, XrefRangeEnd = 62804, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(KillComboSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62804, XrefRangeEnd = 62826, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(KillComboSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe void BattlePhaseStart(Battle.Phase phase)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &phase
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(KillComboSystem.NativeMethodInfoPtr_BattlePhaseStart_Private_Void_Phase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe void BattleTurnEnd(int turnNumber)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &turnNumber
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(KillComboSystem.NativeMethodInfoPtr_BattleTurnEnd_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62826, XrefRangeEnd = 62877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityKilled(Entity entity, DeathType deathType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &deathType;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(KillComboSystem.NativeMethodInfoPtr_EntityKilled_Private_Void_Entity_DeathType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62877, XrefRangeEnd = 62889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int GetGoldAmount(int killCount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &killCount
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(KillComboSystem.NativeMethodInfoPtr_GetGoldAmount_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62889, XrefRangeEnd = 62907, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe KillComboSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KillComboSystem>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(KillComboSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static KillComboSystem()
  {
    Il2CppClassPointerStore<KillComboSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (KillComboSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KillComboSystem>.NativeClassPtr);
    KillComboSystem.NativeFieldInfoPtr_colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillComboSystem>.NativeClassPtr, nameof (colors));
    KillComboSystem.NativeFieldInfoPtr_format = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillComboSystem>.NativeClassPtr, nameof (format));
    KillComboSystem.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillComboSystem>.NativeClassPtr, nameof (min));
    KillComboSystem.NativeFieldInfoPtr_baseGold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillComboSystem>.NativeClassPtr, nameof (baseGold));
    KillComboSystem.NativeFieldInfoPtr_goldPerCombo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillComboSystem>.NativeClassPtr, nameof (goldPerCombo));
    KillComboSystem.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillComboSystem>.NativeClassPtr, nameof (count));
    KillComboSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillComboSystem>.NativeClassPtr, 100668418);
    KillComboSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillComboSystem>.NativeClassPtr, 100668419);
    KillComboSystem.NativeMethodInfoPtr_BattlePhaseStart_Private_Void_Phase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillComboSystem>.NativeClassPtr, 100668420);
    KillComboSystem.NativeMethodInfoPtr_BattleTurnEnd_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillComboSystem>.NativeClassPtr, 100668421);
    KillComboSystem.NativeMethodInfoPtr_EntityKilled_Private_Void_Entity_DeathType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillComboSystem>.NativeClassPtr, 100668422);
    KillComboSystem.NativeMethodInfoPtr_GetGoldAmount_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillComboSystem>.NativeClassPtr, 100668423);
    KillComboSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillComboSystem>.NativeClassPtr, 100668424);
  }

  public KillComboSystem(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppStringArray colors
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillComboSystem.NativeFieldInfoPtr_colors));
      return pointer == IntPtr.Zero ? (Il2CppStringArray) null : new Il2CppStringArray(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(KillComboSystem.NativeFieldInfoPtr_colors), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string format
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillComboSystem.NativeFieldInfoPtr_format)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(KillComboSystem.NativeFieldInfoPtr_format), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe int min
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillComboSystem.NativeFieldInfoPtr_min));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillComboSystem.NativeFieldInfoPtr_min)) = value;
    }
  }

  public unsafe int baseGold
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillComboSystem.NativeFieldInfoPtr_baseGold));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillComboSystem.NativeFieldInfoPtr_baseGold)) = value;
    }
  }

  public unsafe int goldPerCombo
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillComboSystem.NativeFieldInfoPtr_goldPerCombo));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillComboSystem.NativeFieldInfoPtr_goldPerCombo)) = value;
    }
  }

  public unsafe int count
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillComboSystem.NativeFieldInfoPtr_count));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillComboSystem.NativeFieldInfoPtr_count)) = value;
    }
  }
}
