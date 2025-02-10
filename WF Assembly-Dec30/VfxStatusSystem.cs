// Decompiled with JetBrains decompiler
// Type: VfxStatusSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class VfxStatusSystem : GameSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_profiles;
  private static readonly System.IntPtr NativeFieldInfoPtr_damageProfiles;
  private static readonly System.IntPtr NativeFieldInfoPtr_profileLookup;
  private static readonly System.IntPtr NativeFieldInfoPtr_damageProfileLookup;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StatusApplied_Private_Void_StatusEffectApply_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityHit_Private_Void_Hit_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateEffect_Private_Void_GameObject_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81277, XrefRangeEnd = 81313, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(VfxStatusSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81313, XrefRangeEnd = 81328, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(VfxStatusSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81328, XrefRangeEnd = 81348, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StatusApplied(StatusEffectApply apply)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) apply)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(VfxStatusSystem.NativeMethodInfoPtr_StatusApplied_Private_Void_StatusEffectApply_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81348, XrefRangeEnd = 81364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityHit(Hit hit)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hit)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(VfxStatusSystem.NativeMethodInfoPtr_EntityHit_Private_Void_Hit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 81375, RefRangeEnd = 81377, XrefRangeStart = 81364, XrefRangeEnd = 81375, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CreateEffect(GameObject prefab, Vector3 position, Vector3 scale)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefab);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &scale;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(VfxStatusSystem.NativeMethodInfoPtr_CreateEffect_Private_Void_GameObject_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe VfxStatusSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VfxStatusSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(VfxStatusSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static VfxStatusSystem()
  {
    Il2CppClassPointerStore<VfxStatusSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (VfxStatusSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VfxStatusSystem>.NativeClassPtr);
    VfxStatusSystem.NativeFieldInfoPtr_profiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VfxStatusSystem>.NativeClassPtr, nameof (profiles));
    VfxStatusSystem.NativeFieldInfoPtr_damageProfiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VfxStatusSystem>.NativeClassPtr, nameof (damageProfiles));
    VfxStatusSystem.NativeFieldInfoPtr_profileLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VfxStatusSystem>.NativeClassPtr, nameof (profileLookup));
    VfxStatusSystem.NativeFieldInfoPtr_damageProfileLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VfxStatusSystem>.NativeClassPtr, nameof (damageProfileLookup));
    VfxStatusSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VfxStatusSystem>.NativeClassPtr, 100669961);
    VfxStatusSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VfxStatusSystem>.NativeClassPtr, 100669962);
    VfxStatusSystem.NativeMethodInfoPtr_StatusApplied_Private_Void_StatusEffectApply_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VfxStatusSystem>.NativeClassPtr, 100669963);
    VfxStatusSystem.NativeMethodInfoPtr_EntityHit_Private_Void_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VfxStatusSystem>.NativeClassPtr, 100669964);
    VfxStatusSystem.NativeMethodInfoPtr_CreateEffect_Private_Void_GameObject_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VfxStatusSystem>.NativeClassPtr, 100669965);
    VfxStatusSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VfxStatusSystem>.NativeClassPtr, 100669966);
  }

  public VfxStatusSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppReferenceArray<VfxStatusSystem.Profile> profiles
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VfxStatusSystem.NativeFieldInfoPtr_profiles));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<VfxStatusSystem.Profile>) null : new Il2CppReferenceArray<VfxStatusSystem.Profile>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VfxStatusSystem.NativeFieldInfoPtr_profiles), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<VfxStatusSystem.DamageProfile> damageProfiles
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VfxStatusSystem.NativeFieldInfoPtr_damageProfiles));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<VfxStatusSystem.DamageProfile>) null : new Il2CppReferenceArray<VfxStatusSystem.DamageProfile>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VfxStatusSystem.NativeFieldInfoPtr_damageProfiles), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<string, VfxStatusSystem.Profile> profileLookup
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VfxStatusSystem.NativeFieldInfoPtr_profileLookup));
      return pointer == System.IntPtr.Zero ? (Dictionary<string, VfxStatusSystem.Profile>) null : new Dictionary<string, VfxStatusSystem.Profile>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VfxStatusSystem.NativeFieldInfoPtr_profileLookup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<string, VfxStatusSystem.DamageProfile> damageProfileLookup
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VfxStatusSystem.NativeFieldInfoPtr_damageProfileLookup));
      return pointer == System.IntPtr.Zero ? (Dictionary<string, VfxStatusSystem.DamageProfile>) null : new Dictionary<string, VfxStatusSystem.DamageProfile>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VfxStatusSystem.NativeFieldInfoPtr_damageProfileLookup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class Profile : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_type;
    private static readonly System.IntPtr NativeFieldInfoPtr_applyEffectPrefab;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Profile()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VfxStatusSystem.Profile>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VfxStatusSystem.Profile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Profile()
    {
      Il2CppClassPointerStore<VfxStatusSystem.Profile>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VfxStatusSystem>.NativeClassPtr, nameof (Profile));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VfxStatusSystem.Profile>.NativeClassPtr);
      VfxStatusSystem.Profile.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VfxStatusSystem.Profile>.NativeClassPtr, nameof (type));
      VfxStatusSystem.Profile.NativeFieldInfoPtr_applyEffectPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VfxStatusSystem.Profile>.NativeClassPtr, nameof (applyEffectPrefab));
      VfxStatusSystem.Profile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VfxStatusSystem.Profile>.NativeClassPtr, 100669967);
    }

    public Profile(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string type
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VfxStatusSystem.Profile.NativeFieldInfoPtr_type)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VfxStatusSystem.Profile.NativeFieldInfoPtr_type), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe GameObject applyEffectPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VfxStatusSystem.Profile.NativeFieldInfoPtr_applyEffectPrefab));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VfxStatusSystem.Profile.NativeFieldInfoPtr_applyEffectPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [Serializable]
  public class DamageProfile : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_damageType;
    private static readonly System.IntPtr NativeFieldInfoPtr_damageEffectPrefab;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DamageProfile()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VfxStatusSystem.DamageProfile>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VfxStatusSystem.DamageProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DamageProfile()
    {
      Il2CppClassPointerStore<VfxStatusSystem.DamageProfile>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VfxStatusSystem>.NativeClassPtr, nameof (DamageProfile));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VfxStatusSystem.DamageProfile>.NativeClassPtr);
      VfxStatusSystem.DamageProfile.NativeFieldInfoPtr_damageType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VfxStatusSystem.DamageProfile>.NativeClassPtr, nameof (damageType));
      VfxStatusSystem.DamageProfile.NativeFieldInfoPtr_damageEffectPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VfxStatusSystem.DamageProfile>.NativeClassPtr, nameof (damageEffectPrefab));
      VfxStatusSystem.DamageProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VfxStatusSystem.DamageProfile>.NativeClassPtr, 100669968);
    }

    public DamageProfile(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string damageType
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VfxStatusSystem.DamageProfile.NativeFieldInfoPtr_damageType)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VfxStatusSystem.DamageProfile.NativeFieldInfoPtr_damageType), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe GameObject damageEffectPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VfxStatusSystem.DamageProfile.NativeFieldInfoPtr_damageEffectPrefab));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VfxStatusSystem.DamageProfile.NativeFieldInfoPtr_damageEffectPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
