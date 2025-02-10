// Decompiled with JetBrains decompiler
// Type: BlingParticleSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class BlingParticleSystem : GameSystem
{
  private static readonly IntPtr NativeFieldInfoPtr_blingPrefab;
  private static readonly IntPtr NativeFieldInfoPtr_initialPoolSize;
  private static readonly IntPtr NativeFieldInfoPtr_lowValueSprite;
  private static readonly IntPtr NativeFieldInfoPtr_highValueSprite;
  private static readonly IntPtr NativeFieldInfoPtr_highValueAmount;
  private static readonly IntPtr NativeFieldInfoPtr_pool;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_DropGold_Private_Void_Int32_String_Character_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_Get_Private_BlingParticle_0;
  private static readonly IntPtr NativeMethodInfoPtr_Pool_Public_Void_BlingParticle_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55861, XrefRangeEnd = 55873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BlingParticleSystem.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55873, XrefRangeEnd = 55881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BlingParticleSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55881, XrefRangeEnd = 55889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BlingParticleSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55889, XrefRangeEnd = 55909, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DropGold(int amount, string source, Character owner, Vector3 position)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[4];
    numPtr[0] = (IntPtr) &amount;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(source);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) owner);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &position;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BlingParticleSystem.NativeMethodInfoPtr_DropGold_Private_Void_Int32_String_Character_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55909, XrefRangeEnd = 55921, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BlingParticle Get()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(BlingParticleSystem.NativeMethodInfoPtr_Get_Private_BlingParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    IntPtr pointer = num;
    return pointer == IntPtr.Zero ? (BlingParticle) null : new BlingParticle(pointer);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 55927, RefRangeEnd = 55930, XrefRangeStart = 55921, XrefRangeEnd = 55927, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Pool(BlingParticle particle)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) particle)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BlingParticleSystem.NativeMethodInfoPtr_Pool_Public_Void_BlingParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55930, XrefRangeEnd = 55939, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BlingParticleSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlingParticleSystem>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BlingParticleSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BlingParticleSystem()
  {
    Il2CppClassPointerStore<BlingParticleSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (BlingParticleSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlingParticleSystem>.NativeClassPtr);
    BlingParticleSystem.NativeFieldInfoPtr_blingPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlingParticleSystem>.NativeClassPtr, nameof (blingPrefab));
    BlingParticleSystem.NativeFieldInfoPtr_initialPoolSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlingParticleSystem>.NativeClassPtr, nameof (initialPoolSize));
    BlingParticleSystem.NativeFieldInfoPtr_lowValueSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlingParticleSystem>.NativeClassPtr, nameof (lowValueSprite));
    BlingParticleSystem.NativeFieldInfoPtr_highValueSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlingParticleSystem>.NativeClassPtr, nameof (highValueSprite));
    BlingParticleSystem.NativeFieldInfoPtr_highValueAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlingParticleSystem>.NativeClassPtr, nameof (highValueAmount));
    BlingParticleSystem.NativeFieldInfoPtr_pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlingParticleSystem>.NativeClassPtr, nameof (pool));
    BlingParticleSystem.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlingParticleSystem>.NativeClassPtr, 100667864);
    BlingParticleSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlingParticleSystem>.NativeClassPtr, 100667865);
    BlingParticleSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlingParticleSystem>.NativeClassPtr, 100667866);
    BlingParticleSystem.NativeMethodInfoPtr_DropGold_Private_Void_Int32_String_Character_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlingParticleSystem>.NativeClassPtr, 100667867);
    BlingParticleSystem.NativeMethodInfoPtr_Get_Private_BlingParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlingParticleSystem>.NativeClassPtr, 100667868);
    BlingParticleSystem.NativeMethodInfoPtr_Pool_Public_Void_BlingParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlingParticleSystem>.NativeClassPtr, 100667869);
    BlingParticleSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlingParticleSystem>.NativeClassPtr, 100667870);
  }

  public BlingParticleSystem(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe BlingParticle blingPrefab
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticleSystem.NativeFieldInfoPtr_blingPrefab));
      return pointer == IntPtr.Zero ? (BlingParticle) null : new BlingParticle(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BlingParticleSystem.NativeFieldInfoPtr_blingPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int initialPoolSize
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticleSystem.NativeFieldInfoPtr_initialPoolSize));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticleSystem.NativeFieldInfoPtr_initialPoolSize)) = value;
    }
  }

  public unsafe Sprite lowValueSprite
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticleSystem.NativeFieldInfoPtr_lowValueSprite));
      return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BlingParticleSystem.NativeFieldInfoPtr_lowValueSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite highValueSprite
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticleSystem.NativeFieldInfoPtr_highValueSprite));
      return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BlingParticleSystem.NativeFieldInfoPtr_highValueSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int highValueAmount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticleSystem.NativeFieldInfoPtr_highValueAmount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticleSystem.NativeFieldInfoPtr_highValueAmount)) = value;
    }
  }

  public unsafe Queue<BlingParticle> pool
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlingParticleSystem.NativeFieldInfoPtr_pool));
      return pointer == IntPtr.Zero ? (Queue<BlingParticle>) null : new Queue<BlingParticle>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BlingParticleSystem.NativeFieldInfoPtr_pool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
