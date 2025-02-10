// Decompiled with JetBrains decompiler
// Type: VfxHitSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class VfxHitSystem : GameSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_profileCurve;
  private static readonly System.IntPtr NativeFieldInfoPtr_profiles;
  private static readonly System.IntPtr NativeFieldInfoPtr_withStatusProfiles;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetProfile_Private_Profile_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHitPower_Private_Static_Int32_Hit_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityHit_Private_Void_Hit_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TakeHit_Private_Void_Hit_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateEffect_Private_Void_GameObject_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81195, XrefRangeEnd = 81198, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe VfxHitSystem.Profile GetProfile(int power)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &power
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VfxHitSystem.NativeMethodInfoPtr_GetProfile_Private_Profile_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (VfxHitSystem.Profile) null : new VfxHitSystem.Profile(pointer);
  }

  [CallerCount(0)]
  public static unsafe int GetHitPower(Hit hit)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hit)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VfxHitSystem.NativeMethodInfoPtr_GetHitPower_Private_Static_Int32_Hit_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81198, XrefRangeEnd = 81206, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(VfxHitSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81206, XrefRangeEnd = 81214, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(VfxHitSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81214, XrefRangeEnd = 81220, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityHit(Hit hit)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hit)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(VfxHitSystem.NativeMethodInfoPtr_EntityHit_Private_Void_Hit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 81260, RefRangeEnd = 81261, XrefRangeStart = 81220, XrefRangeEnd = 81260, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void TakeHit(Hit hit)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hit)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(VfxHitSystem.NativeMethodInfoPtr_TakeHit_Private_Void_Hit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 81275, RefRangeEnd = 81277, XrefRangeStart = 81261, XrefRangeEnd = 81275, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CreateEffect(GameObject prefab, Vector3 position, Vector3 scale)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefab);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &scale;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(VfxHitSystem.NativeMethodInfoPtr_CreateEffect_Private_Void_GameObject_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe VfxHitSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VfxHitSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(VfxHitSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static VfxHitSystem()
  {
    Il2CppClassPointerStore<VfxHitSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (VfxHitSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VfxHitSystem>.NativeClassPtr);
    VfxHitSystem.NativeFieldInfoPtr_profileCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VfxHitSystem>.NativeClassPtr, nameof (profileCurve));
    VfxHitSystem.NativeFieldInfoPtr_profiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VfxHitSystem>.NativeClassPtr, nameof (profiles));
    VfxHitSystem.NativeFieldInfoPtr_withStatusProfiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VfxHitSystem>.NativeClassPtr, nameof (withStatusProfiles));
    VfxHitSystem.NativeMethodInfoPtr_GetProfile_Private_Profile_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VfxHitSystem>.NativeClassPtr, 100669951);
    VfxHitSystem.NativeMethodInfoPtr_GetHitPower_Private_Static_Int32_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VfxHitSystem>.NativeClassPtr, 100669952);
    VfxHitSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VfxHitSystem>.NativeClassPtr, 100669953);
    VfxHitSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VfxHitSystem>.NativeClassPtr, 100669954);
    VfxHitSystem.NativeMethodInfoPtr_EntityHit_Private_Void_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VfxHitSystem>.NativeClassPtr, 100669955);
    VfxHitSystem.NativeMethodInfoPtr_TakeHit_Private_Void_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VfxHitSystem>.NativeClassPtr, 100669956);
    VfxHitSystem.NativeMethodInfoPtr_CreateEffect_Private_Void_GameObject_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VfxHitSystem>.NativeClassPtr, 100669957);
    VfxHitSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VfxHitSystem>.NativeClassPtr, 100669958);
  }

  public VfxHitSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe AnimationCurve profileCurve
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VfxHitSystem.NativeFieldInfoPtr_profileCurve));
      return pointer == System.IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VfxHitSystem.NativeFieldInfoPtr_profileCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<VfxHitSystem.Profile> profiles
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VfxHitSystem.NativeFieldInfoPtr_profiles));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<VfxHitSystem.Profile>) null : new Il2CppReferenceArray<VfxHitSystem.Profile>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VfxHitSystem.NativeFieldInfoPtr_profiles), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<VfxHitSystem.WithStatusProfile> withStatusProfiles
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VfxHitSystem.NativeFieldInfoPtr_withStatusProfiles));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<VfxHitSystem.WithStatusProfile>) null : new Il2CppReferenceArray<VfxHitSystem.WithStatusProfile>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VfxHitSystem.NativeFieldInfoPtr_withStatusProfiles), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class Profile : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_effectPrefab;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Profile()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VfxHitSystem.Profile>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VfxHitSystem.Profile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Profile()
    {
      Il2CppClassPointerStore<VfxHitSystem.Profile>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VfxHitSystem>.NativeClassPtr, nameof (Profile));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VfxHitSystem.Profile>.NativeClassPtr);
      VfxHitSystem.Profile.NativeFieldInfoPtr_effectPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VfxHitSystem.Profile>.NativeClassPtr, nameof (effectPrefab));
      VfxHitSystem.Profile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VfxHitSystem.Profile>.NativeClassPtr, 100669959);
    }

    public Profile(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GameObject effectPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VfxHitSystem.Profile.NativeFieldInfoPtr_effectPrefab));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VfxHitSystem.Profile.NativeFieldInfoPtr_effectPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [Serializable]
  public class WithStatusProfile : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_statusType;
    private static readonly System.IntPtr NativeFieldInfoPtr_effectPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_sfxEvent;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe WithStatusProfile()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VfxHitSystem.WithStatusProfile>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VfxHitSystem.WithStatusProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static WithStatusProfile()
    {
      Il2CppClassPointerStore<VfxHitSystem.WithStatusProfile>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VfxHitSystem>.NativeClassPtr, nameof (WithStatusProfile));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VfxHitSystem.WithStatusProfile>.NativeClassPtr);
      VfxHitSystem.WithStatusProfile.NativeFieldInfoPtr_statusType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VfxHitSystem.WithStatusProfile>.NativeClassPtr, nameof (statusType));
      VfxHitSystem.WithStatusProfile.NativeFieldInfoPtr_effectPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VfxHitSystem.WithStatusProfile>.NativeClassPtr, nameof (effectPrefab));
      VfxHitSystem.WithStatusProfile.NativeFieldInfoPtr_sfxEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VfxHitSystem.WithStatusProfile>.NativeClassPtr, nameof (sfxEvent));
      VfxHitSystem.WithStatusProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VfxHitSystem.WithStatusProfile>.NativeClassPtr, 100669960);
    }

    public WithStatusProfile(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string statusType
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VfxHitSystem.WithStatusProfile.NativeFieldInfoPtr_statusType)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VfxHitSystem.WithStatusProfile.NativeFieldInfoPtr_statusType), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe GameObject effectPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VfxHitSystem.WithStatusProfile.NativeFieldInfoPtr_effectPrefab));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VfxHitSystem.WithStatusProfile.NativeFieldInfoPtr_effectPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EventReference sfxEvent
    {
      get
      {
        return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VfxHitSystem.WithStatusProfile.NativeFieldInfoPtr_sfxEvent));
      }
      [param: In] set
      {
        *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VfxHitSystem.WithStatusProfile.NativeFieldInfoPtr_sfxEvent)) = value;
      }
    }
  }
}
