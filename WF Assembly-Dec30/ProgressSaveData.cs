// Decompiled with JetBrains decompiler
// Type: ProgressSaveData
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
[Serializable]
public class ProgressSaveData : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_nextSeed;
  private static readonly System.IntPtr NativeFieldInfoPtr_tutorialProgress;
  private static readonly System.IntPtr NativeFieldInfoPtr_tutorialCharmDone;
  private static readonly System.IntPtr NativeFieldInfoPtr_tutorialInjuryDone;
  private static readonly System.IntPtr NativeFieldInfoPtr_finalBossEnemies;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Default_Public_Static_ProgressSaveData_0;

  [CallerCount(1959)]
  [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ProgressSaveData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProgressSaveData>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ProgressSaveData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103930, XrefRangeEnd = 103935, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ProgressSaveData Default()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProgressSaveData.NativeMethodInfoPtr_Default_Public_Static_ProgressSaveData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (ProgressSaveData) null : new ProgressSaveData(pointer);
  }

  static ProgressSaveData()
  {
    Il2CppClassPointerStore<ProgressSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ProgressSaveData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProgressSaveData>.NativeClassPtr);
    ProgressSaveData.NativeFieldInfoPtr_nextSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressSaveData>.NativeClassPtr, nameof (nextSeed));
    ProgressSaveData.NativeFieldInfoPtr_tutorialProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressSaveData>.NativeClassPtr, nameof (tutorialProgress));
    ProgressSaveData.NativeFieldInfoPtr_tutorialCharmDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressSaveData>.NativeClassPtr, nameof (tutorialCharmDone));
    ProgressSaveData.NativeFieldInfoPtr_tutorialInjuryDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressSaveData>.NativeClassPtr, nameof (tutorialInjuryDone));
    ProgressSaveData.NativeFieldInfoPtr_finalBossEnemies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressSaveData>.NativeClassPtr, nameof (finalBossEnemies));
    ProgressSaveData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressSaveData>.NativeClassPtr, 100672677);
    ProgressSaveData.NativeMethodInfoPtr_Default_Public_Static_ProgressSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressSaveData>.NativeClassPtr, 100672678);
  }

  public ProgressSaveData(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe int nextSeed
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProgressSaveData.NativeFieldInfoPtr_nextSeed));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProgressSaveData.NativeFieldInfoPtr_nextSeed)) = value;
    }
  }

  public unsafe int tutorialProgress
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProgressSaveData.NativeFieldInfoPtr_tutorialProgress));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProgressSaveData.NativeFieldInfoPtr_tutorialProgress)) = value;
    }
  }

  public unsafe bool tutorialCharmDone
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProgressSaveData.NativeFieldInfoPtr_tutorialCharmDone));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProgressSaveData.NativeFieldInfoPtr_tutorialCharmDone)) = value;
    }
  }

  public unsafe bool tutorialInjuryDone
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProgressSaveData.NativeFieldInfoPtr_tutorialInjuryDone));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProgressSaveData.NativeFieldInfoPtr_tutorialInjuryDone)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<CardSaveData> finalBossEnemies
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProgressSaveData.NativeFieldInfoPtr_finalBossEnemies));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CardSaveData>) null : new Il2CppReferenceArray<CardSaveData>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ProgressSaveData.NativeFieldInfoPtr_finalBossEnemies), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
