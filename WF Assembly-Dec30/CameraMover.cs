// Decompiled with JetBrains decompiler
// Type: CameraMover
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;

#nullable disable
public class CameraMover : GameSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_battlePhasePositions;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BattlePhaseStart_Private_Void_Phase_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SceneChange_Private_Void_Scene_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31121, XrefRangeEnd = 31136, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CameraMover.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31136, XrefRangeEnd = 31151, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CameraMover.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31151, XrefRangeEnd = 31175, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BattlePhaseStart(Battle.Phase phase)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &phase
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CameraMover.NativeMethodInfoPtr_BattlePhaseStart_Private_Void_Phase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31175, XrefRangeEnd = 31188, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SceneChange(Scene scene)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &scene
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CameraMover.NativeMethodInfoPtr_SceneChange_Private_Void_Scene_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CameraMover()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraMover>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CameraMover.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CameraMover()
  {
    Il2CppClassPointerStore<CameraMover>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CameraMover));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraMover>.NativeClassPtr);
    CameraMover.NativeFieldInfoPtr_battlePhasePositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraMover>.NativeClassPtr, nameof (battlePhasePositions));
    CameraMover.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraMover>.NativeClassPtr, 100665142);
    CameraMover.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraMover>.NativeClassPtr, 100665143);
    CameraMover.NativeMethodInfoPtr_BattlePhaseStart_Private_Void_Phase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraMover>.NativeClassPtr, 100665144);
    CameraMover.NativeMethodInfoPtr_SceneChange_Private_Void_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraMover>.NativeClassPtr, 100665145);
    CameraMover.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraMover>.NativeClassPtr, 100665146);
  }

  public CameraMover(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppReferenceArray<CameraMover.Translation> battlePhasePositions
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraMover.NativeFieldInfoPtr_battlePhasePositions));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CameraMover.Translation>) null : new Il2CppReferenceArray<CameraMover.Translation>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CameraMover.NativeFieldInfoPtr_battlePhasePositions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class Translation : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_name;
    private static readonly System.IntPtr NativeFieldInfoPtr_position;
    private static readonly System.IntPtr NativeFieldInfoPtr_rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_ease;
    private static readonly System.IntPtr NativeFieldInfoPtr_dur;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Translation()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraMover.Translation>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CameraMover.Translation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Translation()
    {
      Il2CppClassPointerStore<CameraMover.Translation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CameraMover>.NativeClassPtr, nameof (Translation));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraMover.Translation>.NativeClassPtr);
      CameraMover.Translation.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraMover.Translation>.NativeClassPtr, nameof (name));
      CameraMover.Translation.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraMover.Translation>.NativeClassPtr, nameof (position));
      CameraMover.Translation.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraMover.Translation>.NativeClassPtr, nameof (rotation));
      CameraMover.Translation.NativeFieldInfoPtr_ease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraMover.Translation>.NativeClassPtr, nameof (ease));
      CameraMover.Translation.NativeFieldInfoPtr_dur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraMover.Translation>.NativeClassPtr, nameof (dur));
      CameraMover.Translation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraMover.Translation>.NativeClassPtr, 100665147);
    }

    public Translation(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraMover.Translation.NativeFieldInfoPtr_name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CameraMover.Translation.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe Vector3 position
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraMover.Translation.NativeFieldInfoPtr_position));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraMover.Translation.NativeFieldInfoPtr_position)) = value;
      }
    }

    public unsafe Vector3 rotation
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraMover.Translation.NativeFieldInfoPtr_rotation));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraMover.Translation.NativeFieldInfoPtr_rotation)) = value;
      }
    }

    public unsafe LeanTweenType ease
    {
      get
      {
        return *(LeanTweenType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraMover.Translation.NativeFieldInfoPtr_ease));
      }
      [param: In] set
      {
        *(LeanTweenType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraMover.Translation.NativeFieldInfoPtr_ease)) = value;
      }
    }

    public unsafe float dur
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraMover.Translation.NativeFieldInfoPtr_dur));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraMover.Translation.NativeFieldInfoPtr_dur)) = value;
      }
    }
  }

  [ObfuscatedName("CameraMover/<>c__DisplayClass3_0")]
  public sealed class __c__DisplayClass3_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_phase;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__BattlePhaseStart_b__0_Internal_Boolean_Translation_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass3_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraMover.__c__DisplayClass3_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CameraMover.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31116, XrefRangeEnd = 31121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _BattlePhaseStart_b__0(CameraMover.Translation a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CameraMover.__c__DisplayClass3_0.NativeMethodInfoPtr__BattlePhaseStart_b__0_Internal_Boolean_Translation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass3_0()
    {
      Il2CppClassPointerStore<CameraMover.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CameraMover>.NativeClassPtr, "<>c__DisplayClass3_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraMover.__c__DisplayClass3_0>.NativeClassPtr);
      CameraMover.__c__DisplayClass3_0.NativeFieldInfoPtr_phase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraMover.__c__DisplayClass3_0>.NativeClassPtr, nameof (phase));
      CameraMover.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraMover.__c__DisplayClass3_0>.NativeClassPtr, 100665148);
      CameraMover.__c__DisplayClass3_0.NativeMethodInfoPtr__BattlePhaseStart_b__0_Internal_Boolean_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraMover.__c__DisplayClass3_0>.NativeClassPtr, 100665149);
    }

    public __c__DisplayClass3_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Battle.Phase phase
    {
      get
      {
        return *(Battle.Phase*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraMover.__c__DisplayClass3_0.NativeFieldInfoPtr_phase));
      }
      [param: In] set
      {
        *(Battle.Phase*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraMover.__c__DisplayClass3_0.NativeFieldInfoPtr_phase)) = value;
      }
    }
  }
}
