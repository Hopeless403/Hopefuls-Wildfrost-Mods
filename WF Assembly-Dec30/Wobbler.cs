// Decompiled with JetBrains decompiler
// Type: Wobbler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class Wobbler : MonoBehaviourCacheTransform
{
  private static readonly IntPtr NativeFieldInfoPtr_rotationInfluence;
  private static readonly IntPtr NativeFieldInfoPtr_rotationMax;
  private static readonly IntPtr NativeFieldInfoPtr_rotationDamping;
  private static readonly IntPtr NativeFieldInfoPtr_rotationAcc;
  private static readonly IntPtr NativeFieldInfoPtr_rotation;
  private static readonly IntPtr NativeFieldInfoPtr_rotationVelocity;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Wobble_Public_Void_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_WobbleRandom_Public_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnGetFromPool_Public_Virtual_Final_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnReturnToPool_Public_Virtual_Final_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101457, XrefRangeEnd = 101466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Wobbler.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 101467, RefRangeEnd = 101472, XrefRangeStart = 101466, XrefRangeEnd = 101467, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Wobble(Vector3 movement)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &movement
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Wobbler.NativeMethodInfoPtr_Wobble_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(29)]
  [CachedScanResults(RefRangeStart = 101474, RefRangeEnd = 101503, XrefRangeStart = 101472, XrefRangeEnd = 101474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void WobbleRandom(float wobbleFactor = 1f)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &wobbleFactor
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Wobbler.NativeMethodInfoPtr_WobbleRandom_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(12611)]
  [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnGetFromPool()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Wobbler.NativeMethodInfoPtr_OnGetFromPool_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 101511, RefRangeEnd = 101512, XrefRangeStart = 101503, XrefRangeEnd = 101511, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnReturnToPool()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Wobbler.NativeMethodInfoPtr_OnReturnToPool_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101512, XrefRangeEnd = 101513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Wobbler()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Wobbler>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Wobbler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static Wobbler()
  {
    Il2CppClassPointerStore<Wobbler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (Wobbler));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Wobbler>.NativeClassPtr);
    Wobbler.NativeFieldInfoPtr_rotationInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wobbler>.NativeClassPtr, nameof (rotationInfluence));
    Wobbler.NativeFieldInfoPtr_rotationMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wobbler>.NativeClassPtr, nameof (rotationMax));
    Wobbler.NativeFieldInfoPtr_rotationDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wobbler>.NativeClassPtr, nameof (rotationDamping));
    Wobbler.NativeFieldInfoPtr_rotationAcc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wobbler>.NativeClassPtr, nameof (rotationAcc));
    Wobbler.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wobbler>.NativeClassPtr, nameof (rotation));
    Wobbler.NativeFieldInfoPtr_rotationVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wobbler>.NativeClassPtr, nameof (rotationVelocity));
    Wobbler.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wobbler>.NativeClassPtr, 100672400);
    Wobbler.NativeMethodInfoPtr_Wobble_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wobbler>.NativeClassPtr, 100672401);
    Wobbler.NativeMethodInfoPtr_WobbleRandom_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wobbler>.NativeClassPtr, 100672402);
    Wobbler.NativeMethodInfoPtr_OnGetFromPool_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wobbler>.NativeClassPtr, 100672403);
    Wobbler.NativeMethodInfoPtr_OnReturnToPool_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wobbler>.NativeClassPtr, 100672404);
    Wobbler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wobbler>.NativeClassPtr, 100672405);
  }

  public Wobbler(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Vector3 rotationInfluence
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Wobbler.NativeFieldInfoPtr_rotationInfluence));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Wobbler.NativeFieldInfoPtr_rotationInfluence)) = value;
    }
  }

  public unsafe Vector3 rotationMax
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Wobbler.NativeFieldInfoPtr_rotationMax));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Wobbler.NativeFieldInfoPtr_rotationMax)) = value;
    }
  }

  public unsafe Vector3 rotationDamping
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Wobbler.NativeFieldInfoPtr_rotationDamping));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Wobbler.NativeFieldInfoPtr_rotationDamping)) = value;
    }
  }

  public unsafe Vector3 rotationAcc
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Wobbler.NativeFieldInfoPtr_rotationAcc));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Wobbler.NativeFieldInfoPtr_rotationAcc)) = value;
    }
  }

  public unsafe Vector3 rotation
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Wobbler.NativeFieldInfoPtr_rotation));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Wobbler.NativeFieldInfoPtr_rotation)) = value;
    }
  }

  public unsafe Vector3 rotationVelocity
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Wobbler.NativeFieldInfoPtr_rotationVelocity));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Wobbler.NativeFieldInfoPtr_rotationVelocity)) = value;
    }
  }
}
