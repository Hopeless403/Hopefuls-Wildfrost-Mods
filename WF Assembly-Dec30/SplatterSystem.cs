// Decompiled with JetBrains decompiler
// Type: SplatterSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class SplatterSystem : GameSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_spread;
  private static readonly System.IntPtr NativeFieldInfoPtr_speedRange;
  private static readonly System.IntPtr NativeFieldInfoPtr_upSpeedRange;
  private static readonly System.IntPtr NativeFieldInfoPtr_bloodAmount;
  private static readonly System.IntPtr NativeFieldInfoPtr_maxPerHit;
  private static readonly System.IntPtr NativeFieldInfoPtr_rainbow;
  private static readonly System.IntPtr NativeFieldInfoPtr_BloodType;
  private static readonly System.IntPtr NativeFieldInfoPtr_BloodAmount;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SettingChanged_Private_Static_Void_String_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityHit_Private_Void_Hit_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetBloodColour_Public_Color_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75371, XrefRangeEnd = 75401, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SplatterSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75401, XrefRangeEnd = 75416, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SplatterSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75416, XrefRangeEnd = 75426, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SettingChanged(string key, Il2CppSystem.Object value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(key);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SplatterSystem.NativeMethodInfoPtr_SettingChanged_Private_Static_Void_String_Object_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75426, XrefRangeEnd = 75488, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityHit(Hit hit)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hit)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SplatterSystem.NativeMethodInfoPtr_EntityHit_Private_Void_Hit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 75495, RefRangeEnd = 75497, XrefRangeStart = 75488, XrefRangeEnd = 75495, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Color GetBloodColour(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SplatterSystem.NativeMethodInfoPtr_GetBloodColour_Public_Color_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Color*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75497, XrefRangeEnd = 75498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SplatterSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SplatterSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SplatterSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static SplatterSystem()
  {
    Il2CppClassPointerStore<SplatterSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (SplatterSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SplatterSystem>.NativeClassPtr);
    SplatterSystem.NativeFieldInfoPtr_spread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplatterSystem>.NativeClassPtr, nameof (spread));
    SplatterSystem.NativeFieldInfoPtr_speedRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplatterSystem>.NativeClassPtr, nameof (speedRange));
    SplatterSystem.NativeFieldInfoPtr_upSpeedRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplatterSystem>.NativeClassPtr, nameof (upSpeedRange));
    SplatterSystem.NativeFieldInfoPtr_bloodAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplatterSystem>.NativeClassPtr, nameof (bloodAmount));
    SplatterSystem.NativeFieldInfoPtr_maxPerHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplatterSystem>.NativeClassPtr, nameof (maxPerHit));
    SplatterSystem.NativeFieldInfoPtr_rainbow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplatterSystem>.NativeClassPtr, nameof (rainbow));
    SplatterSystem.NativeFieldInfoPtr_BloodType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplatterSystem>.NativeClassPtr, nameof (BloodType));
    SplatterSystem.NativeFieldInfoPtr_BloodAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplatterSystem>.NativeClassPtr, nameof (BloodAmount));
    SplatterSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplatterSystem>.NativeClassPtr, 100669387);
    SplatterSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplatterSystem>.NativeClassPtr, 100669388);
    SplatterSystem.NativeMethodInfoPtr_SettingChanged_Private_Static_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplatterSystem>.NativeClassPtr, 100669389);
    SplatterSystem.NativeMethodInfoPtr_EntityHit_Private_Void_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplatterSystem>.NativeClassPtr, 100669390);
    SplatterSystem.NativeMethodInfoPtr_GetBloodColour_Public_Color_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplatterSystem>.NativeClassPtr, 100669391);
    SplatterSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplatterSystem>.NativeClassPtr, 100669392);
  }

  public SplatterSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe float spread
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterSystem.NativeFieldInfoPtr_spread));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterSystem.NativeFieldInfoPtr_spread)) = value;
    }
  }

  public unsafe Vector2 speedRange
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterSystem.NativeFieldInfoPtr_speedRange));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterSystem.NativeFieldInfoPtr_speedRange)) = value;
    }
  }

  public unsafe Vector2 upSpeedRange
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterSystem.NativeFieldInfoPtr_upSpeedRange));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterSystem.NativeFieldInfoPtr_upSpeedRange)) = value;
    }
  }

  public unsafe float bloodAmount
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterSystem.NativeFieldInfoPtr_bloodAmount));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterSystem.NativeFieldInfoPtr_bloodAmount)) = value;
    }
  }

  public unsafe int maxPerHit
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterSystem.NativeFieldInfoPtr_maxPerHit));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterSystem.NativeFieldInfoPtr_maxPerHit)) = value;
    }
  }

  public unsafe Gradient rainbow
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterSystem.NativeFieldInfoPtr_rainbow));
      return pointer == System.IntPtr.Zero ? (Gradient) null : new Gradient(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SplatterSystem.NativeFieldInfoPtr_rainbow), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe int BloodType
  {
    get
    {
      int bloodType;
      IL2CPP.il2cpp_field_static_get_value(SplatterSystem.NativeFieldInfoPtr_BloodType, (void*) &bloodType);
      return bloodType;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SplatterSystem.NativeFieldInfoPtr_BloodType, (void*) &value);
    }
  }

  public static unsafe float BloodAmount
  {
    get
    {
      float bloodAmount;
      IL2CPP.il2cpp_field_static_get_value(SplatterSystem.NativeFieldInfoPtr_BloodAmount, (void*) &bloodAmount);
      return bloodAmount;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SplatterSystem.NativeFieldInfoPtr_BloodAmount, (void*) &value);
    }
  }
}
