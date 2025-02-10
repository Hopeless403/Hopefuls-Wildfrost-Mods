// Decompiled with JetBrains decompiler
// Type: GameMode
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
public class GameMode : DataFile
{
  private static readonly IntPtr NativeFieldInfoPtr_saveFileName;
  private static readonly IntPtr NativeFieldInfoPtr_seed;
  private static readonly IntPtr NativeFieldInfoPtr_classes;
  private static readonly IntPtr NativeFieldInfoPtr_generator;
  private static readonly IntPtr NativeFieldInfoPtr_populator;
  private static readonly IntPtr NativeFieldInfoPtr_startInNode;
  private static readonly IntPtr NativeFieldInfoPtr_takeStartingPet;
  private static readonly IntPtr NativeFieldInfoPtr_countsAsWin;
  private static readonly IntPtr NativeFieldInfoPtr_showStats;
  private static readonly IntPtr NativeFieldInfoPtr_gainProgress;
  private static readonly IntPtr NativeFieldInfoPtr_doSave;
  private static readonly IntPtr NativeFieldInfoPtr_canRestart;
  private static readonly IntPtr NativeFieldInfoPtr_canGoBack;
  private static readonly IntPtr NativeFieldInfoPtr_submitScore;
  private static readonly IntPtr NativeFieldInfoPtr_mainGameMode;
  private static readonly IntPtr NativeFieldInfoPtr_dailyRun;
  private static readonly IntPtr NativeFieldInfoPtr_tutorialRun;
  private static readonly IntPtr NativeFieldInfoPtr_leaderboardType;
  private static readonly IntPtr NativeFieldInfoPtr_startScene;
  private static readonly IntPtr NativeFieldInfoPtr_sceneAfterSelection;
  private static readonly IntPtr NativeFieldInfoPtr_campaignSystemNames;
  private static readonly IntPtr NativeFieldInfoPtr_systemsToDisable;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109490, XrefRangeEnd = 109499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GameMode()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameMode>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(GameMode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static GameMode()
  {
    Il2CppClassPointerStore<GameMode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (GameMode));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameMode>.NativeClassPtr);
    GameMode.NativeFieldInfoPtr_saveFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMode>.NativeClassPtr, nameof (saveFileName));
    GameMode.NativeFieldInfoPtr_seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMode>.NativeClassPtr, nameof (seed));
    GameMode.NativeFieldInfoPtr_classes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMode>.NativeClassPtr, nameof (classes));
    GameMode.NativeFieldInfoPtr_generator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMode>.NativeClassPtr, nameof (generator));
    GameMode.NativeFieldInfoPtr_populator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMode>.NativeClassPtr, nameof (populator));
    GameMode.NativeFieldInfoPtr_startInNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMode>.NativeClassPtr, nameof (startInNode));
    GameMode.NativeFieldInfoPtr_takeStartingPet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMode>.NativeClassPtr, nameof (takeStartingPet));
    GameMode.NativeFieldInfoPtr_countsAsWin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMode>.NativeClassPtr, nameof (countsAsWin));
    GameMode.NativeFieldInfoPtr_showStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMode>.NativeClassPtr, nameof (showStats));
    GameMode.NativeFieldInfoPtr_gainProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMode>.NativeClassPtr, nameof (gainProgress));
    GameMode.NativeFieldInfoPtr_doSave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMode>.NativeClassPtr, nameof (doSave));
    GameMode.NativeFieldInfoPtr_canRestart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMode>.NativeClassPtr, nameof (canRestart));
    GameMode.NativeFieldInfoPtr_canGoBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMode>.NativeClassPtr, nameof (canGoBack));
    GameMode.NativeFieldInfoPtr_submitScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMode>.NativeClassPtr, nameof (submitScore));
    GameMode.NativeFieldInfoPtr_mainGameMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMode>.NativeClassPtr, nameof (mainGameMode));
    GameMode.NativeFieldInfoPtr_dailyRun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMode>.NativeClassPtr, nameof (dailyRun));
    GameMode.NativeFieldInfoPtr_tutorialRun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMode>.NativeClassPtr, nameof (tutorialRun));
    GameMode.NativeFieldInfoPtr_leaderboardType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMode>.NativeClassPtr, nameof (leaderboardType));
    GameMode.NativeFieldInfoPtr_startScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMode>.NativeClassPtr, nameof (startScene));
    GameMode.NativeFieldInfoPtr_sceneAfterSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMode>.NativeClassPtr, nameof (sceneAfterSelection));
    GameMode.NativeFieldInfoPtr_campaignSystemNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMode>.NativeClassPtr, nameof (campaignSystemNames));
    GameMode.NativeFieldInfoPtr_systemsToDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMode>.NativeClassPtr, nameof (systemsToDisable));
    GameMode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameMode>.NativeClassPtr, 100673391);
  }

  public GameMode(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe string saveFileName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameMode.NativeFieldInfoPtr_saveFileName)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameMode.NativeFieldInfoPtr_saveFileName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string seed
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameMode.NativeFieldInfoPtr_seed)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameMode.NativeFieldInfoPtr_seed), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe Il2CppReferenceArray<ClassData> classes
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameMode.NativeFieldInfoPtr_classes));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<ClassData>) null : new Il2CppReferenceArray<ClassData>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameMode.NativeFieldInfoPtr_classes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CampaignGenerator generator
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameMode.NativeFieldInfoPtr_generator));
      return pointer == IntPtr.Zero ? (CampaignGenerator) null : new CampaignGenerator(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameMode.NativeFieldInfoPtr_generator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CampaignPopulator populator
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameMode.NativeFieldInfoPtr_populator));
      return pointer == IntPtr.Zero ? (CampaignPopulator) null : new CampaignPopulator(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameMode.NativeFieldInfoPtr_populator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool startInNode
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameMode.NativeFieldInfoPtr_startInNode));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameMode.NativeFieldInfoPtr_startInNode)) = value;
    }
  }

  public unsafe bool takeStartingPet
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameMode.NativeFieldInfoPtr_takeStartingPet));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameMode.NativeFieldInfoPtr_takeStartingPet)) = value;
    }
  }

  public unsafe bool countsAsWin
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameMode.NativeFieldInfoPtr_countsAsWin));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameMode.NativeFieldInfoPtr_countsAsWin)) = value;
    }
  }

  public unsafe bool showStats
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameMode.NativeFieldInfoPtr_showStats));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameMode.NativeFieldInfoPtr_showStats)) = value;
    }
  }

  public unsafe bool gainProgress
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameMode.NativeFieldInfoPtr_gainProgress));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameMode.NativeFieldInfoPtr_gainProgress)) = value;
    }
  }

  public unsafe bool doSave
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameMode.NativeFieldInfoPtr_doSave));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameMode.NativeFieldInfoPtr_doSave)) = value;
    }
  }

  public unsafe bool canRestart
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameMode.NativeFieldInfoPtr_canRestart));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameMode.NativeFieldInfoPtr_canRestart)) = value;
    }
  }

  public unsafe bool canGoBack
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameMode.NativeFieldInfoPtr_canGoBack));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameMode.NativeFieldInfoPtr_canGoBack)) = value;
    }
  }

  public unsafe bool submitScore
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameMode.NativeFieldInfoPtr_submitScore));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameMode.NativeFieldInfoPtr_submitScore)) = value;
    }
  }

  public unsafe bool mainGameMode
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameMode.NativeFieldInfoPtr_mainGameMode));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameMode.NativeFieldInfoPtr_mainGameMode)) = value;
    }
  }

  public unsafe bool dailyRun
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameMode.NativeFieldInfoPtr_dailyRun));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameMode.NativeFieldInfoPtr_dailyRun)) = value;
    }
  }

  public unsafe bool tutorialRun
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameMode.NativeFieldInfoPtr_tutorialRun));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameMode.NativeFieldInfoPtr_tutorialRun)) = value;
    }
  }

  public unsafe Scores.Type leaderboardType
  {
    get
    {
      return *(Scores.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameMode.NativeFieldInfoPtr_leaderboardType));
    }
    [param: In] set
    {
      *(Scores.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameMode.NativeFieldInfoPtr_leaderboardType)) = value;
    }
  }

  public unsafe string startScene
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameMode.NativeFieldInfoPtr_startScene)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameMode.NativeFieldInfoPtr_startScene), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string sceneAfterSelection
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameMode.NativeFieldInfoPtr_sceneAfterSelection)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameMode.NativeFieldInfoPtr_sceneAfterSelection), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe Il2CppStringArray campaignSystemNames
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameMode.NativeFieldInfoPtr_campaignSystemNames));
      return pointer == IntPtr.Zero ? (Il2CppStringArray) null : new Il2CppStringArray(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameMode.NativeFieldInfoPtr_campaignSystemNames), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStringArray systemsToDisable
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameMode.NativeFieldInfoPtr_systemsToDisable));
      return pointer == IntPtr.Zero ? (Il2CppStringArray) null : new Il2CppStringArray(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameMode.NativeFieldInfoPtr_systemsToDisable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
