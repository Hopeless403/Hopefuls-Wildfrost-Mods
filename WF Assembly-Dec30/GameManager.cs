// Decompiled with JetBrains decompiler
// Type: GameManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections;
using Il2CppSystem.Globalization;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class GameManager : MonoBehaviourSingleton<GameManager>
{
  private static readonly System.IntPtr NativeFieldInfoPtr_CARD_WIDTH;
  private static readonly System.IntPtr NativeFieldInfoPtr_CARD_HEIGHT;
  private static readonly System.IntPtr NativeFieldInfoPtr_CARD_SIZE;
  private static readonly System.IntPtr NativeFieldInfoPtr_LARGE_UI;
  private static readonly System.IntPtr NativeFieldInfoPtr_targetFrameRate;
  private static readonly System.IntPtr NativeFieldInfoPtr_editorTargetFrameRate;
  private static readonly System.IntPtr NativeFieldInfoPtr_tasksInProgress;
  private static readonly System.IntPtr NativeFieldInfoPtr_init;
  private static readonly System.IntPtr NativeFieldInfoPtr_End;
  private static readonly System.IntPtr NativeFieldInfoPtr_paused;
  private static readonly System.IntPtr NativeFieldInfoPtr_CultureInfo;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Busy_Public_Static_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Ready_Public_Static_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Quit_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public static unsafe bool Busy
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 50603, RefRangeEnd = 50604, XrefRangeStart = 50599, XrefRangeEnd = 50603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr_get_Busy_Public_Static_get_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public static unsafe bool Ready
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50604, XrefRangeEnd = 50608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr_get_Ready_Public_Static_get_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50608, XrefRangeEnd = 50613, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50613, XrefRangeEnd = 50624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnApplicationQuit()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 50625, RefRangeEnd = 50630, XrefRangeStart = 50624, XrefRangeEnd = 50625, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Quit()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr_Quit_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50630, XrefRangeEnd = 50633, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GameManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameManager>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static GameManager()
  {
    Il2CppClassPointerStore<GameManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (GameManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameManager>.NativeClassPtr);
    GameManager.NativeFieldInfoPtr_CARD_WIDTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, nameof (CARD_WIDTH));
    GameManager.NativeFieldInfoPtr_CARD_HEIGHT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, nameof (CARD_HEIGHT));
    GameManager.NativeFieldInfoPtr_CARD_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, nameof (CARD_SIZE));
    GameManager.NativeFieldInfoPtr_LARGE_UI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, nameof (LARGE_UI));
    GameManager.NativeFieldInfoPtr_targetFrameRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, nameof (targetFrameRate));
    GameManager.NativeFieldInfoPtr_editorTargetFrameRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, nameof (editorTargetFrameRate));
    GameManager.NativeFieldInfoPtr_tasksInProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, nameof (tasksInProgress));
    GameManager.NativeFieldInfoPtr_init = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, nameof (init));
    GameManager.NativeFieldInfoPtr_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, nameof (End));
    GameManager.NativeFieldInfoPtr_paused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, nameof (paused));
    GameManager.NativeFieldInfoPtr_CultureInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, nameof (CultureInfo));
    GameManager.NativeMethodInfoPtr_get_Busy_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100667310);
    GameManager.NativeMethodInfoPtr_get_Ready_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100667311);
    GameManager.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100667312);
    GameManager.NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100667313);
    GameManager.NativeMethodInfoPtr_Quit_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100667314);
    GameManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100667315);
  }

  public GameManager(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe float CARD_WIDTH
  {
    get
    {
      float cardWidth;
      IL2CPP.il2cpp_field_static_get_value(GameManager.NativeFieldInfoPtr_CARD_WIDTH, (void*) &cardWidth);
      return cardWidth;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GameManager.NativeFieldInfoPtr_CARD_WIDTH, (void*) &value);
    }
  }

  public static unsafe float CARD_HEIGHT
  {
    get
    {
      float cardHeight;
      IL2CPP.il2cpp_field_static_get_value(GameManager.NativeFieldInfoPtr_CARD_HEIGHT, (void*) &cardHeight);
      return cardHeight;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GameManager.NativeFieldInfoPtr_CARD_HEIGHT, (void*) &value);
    }
  }

  public static unsafe Vector2 CARD_SIZE
  {
    get
    {
      Vector2 cardSize;
      IL2CPP.il2cpp_field_static_get_value(GameManager.NativeFieldInfoPtr_CARD_SIZE, (void*) &cardSize);
      return cardSize;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GameManager.NativeFieldInfoPtr_CARD_SIZE, (void*) &value);
    }
  }

  public static unsafe float LARGE_UI
  {
    get
    {
      float largeUi;
      IL2CPP.il2cpp_field_static_get_value(GameManager.NativeFieldInfoPtr_LARGE_UI, (void*) &largeUi);
      return largeUi;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GameManager.NativeFieldInfoPtr_LARGE_UI, (void*) &value);
    }
  }

  public unsafe int targetFrameRate
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr_targetFrameRate));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr_targetFrameRate)) = value;
    }
  }

  public unsafe int editorTargetFrameRate
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr_editorTargetFrameRate));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr_editorTargetFrameRate)) = value;
    }
  }

  public static unsafe int tasksInProgress
  {
    get
    {
      int tasksInProgress;
      IL2CPP.il2cpp_field_static_get_value(GameManager.NativeFieldInfoPtr_tasksInProgress, (void*) &tasksInProgress);
      return tasksInProgress;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GameManager.NativeFieldInfoPtr_tasksInProgress, (void*) &value);
    }
  }

  public static unsafe bool init
  {
    get
    {
      bool init;
      IL2CPP.il2cpp_field_static_get_value(GameManager.NativeFieldInfoPtr_init, (void*) &init);
      return init;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GameManager.NativeFieldInfoPtr_init, (void*) &value);
    }
  }

  public static unsafe bool End
  {
    get
    {
      bool end;
      IL2CPP.il2cpp_field_static_get_value(GameManager.NativeFieldInfoPtr_End, (void*) &end);
      return end;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GameManager.NativeFieldInfoPtr_End, (void*) &value);
    }
  }

  public static unsafe bool paused
  {
    get
    {
      bool paused;
      IL2CPP.il2cpp_field_static_get_value(GameManager.NativeFieldInfoPtr_paused, (void*) &paused);
      return paused;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GameManager.NativeFieldInfoPtr_paused, (void*) &value);
    }
  }

  public static unsafe CultureInfo CultureInfo
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(GameManager.NativeFieldInfoPtr_CultureInfo, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CultureInfo) null : new CultureInfo(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GameManager.NativeFieldInfoPtr_CultureInfo, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("GameManager/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__15_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__15_0_Internal_Boolean_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameManager.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50579, XrefRangeEnd = 50581, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _Start_b__15_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameManager.__c.NativeMethodInfoPtr__Start_b__15_0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<GameManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameManager.__c>.NativeClassPtr);
      GameManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager.__c>.NativeClassPtr, "<>9");
      GameManager.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager.__c>.NativeClassPtr, "<>9__15_0");
      GameManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager.__c>.NativeClassPtr, 100667318);
      GameManager.__c.NativeMethodInfoPtr__Start_b__15_0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager.__c>.NativeClassPtr, 100667319);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe GameManager.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(GameManager.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (GameManager.__c) null : new GameManager.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GameManager.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<bool> __9__15_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(GameManager.__c.NativeFieldInfoPtr___9__15_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<bool>) null : new Il2CppSystem.Func<bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GameManager.__c.NativeFieldInfoPtr___9__15_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("GameManager/<Start>d__15")]
  public sealed class _Start_d__15 : Il2CppSystem.Object
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
    public unsafe _Start_d__15(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameManager._Start_d__15>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameManager._Start_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameManager._Start_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50581, XrefRangeEnd = 50593, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameManager._Start_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameManager._Start_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50593, XrefRangeEnd = 50599, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameManager._Start_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameManager._Start_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _Start_d__15()
    {
      Il2CppClassPointerStore<GameManager._Start_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "<Start>d__15");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameManager._Start_d__15>.NativeClassPtr);
      GameManager._Start_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager._Start_d__15>.NativeClassPtr, "<>1__state");
      GameManager._Start_d__15.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager._Start_d__15>.NativeClassPtr, "<>2__current");
      GameManager._Start_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager._Start_d__15>.NativeClassPtr, "<>4__this");
      GameManager._Start_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager._Start_d__15>.NativeClassPtr, 100667320);
      GameManager._Start_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager._Start_d__15>.NativeClassPtr, 100667321);
      GameManager._Start_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager._Start_d__15>.NativeClassPtr, 100667322);
      GameManager._Start_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager._Start_d__15>.NativeClassPtr, 100667323);
      GameManager._Start_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager._Start_d__15>.NativeClassPtr, 100667324);
      GameManager._Start_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager._Start_d__15>.NativeClassPtr, 100667325);
    }

    public _Start_d__15(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameManager._Start_d__15.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameManager._Start_d__15.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameManager._Start_d__15.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameManager._Start_d__15.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameManager __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameManager._Start_d__15.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (GameManager) null : new GameManager(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameManager._Start_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
