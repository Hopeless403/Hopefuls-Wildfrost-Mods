// Decompiled with JetBrains decompiler
// Type: ShadowManager
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
public class ShadowManager : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_shadowPrefab;
  private static readonly IntPtr NativeFieldInfoPtr_limitX;
  private static readonly IntPtr NativeFieldInfoPtr_limitY;
  private static readonly IntPtr NativeFieldInfoPtr_limitZ;
  private static readonly IntPtr NativeFieldInfoPtr_offset;
  private static readonly IntPtr NativeFieldInfoPtr_offsetBasedOnScale;
  private static readonly IntPtr NativeFieldInfoPtr_considerScale;
  private static readonly IntPtr NativeFieldInfoPtr_baseScale;
  private static readonly IntPtr NativeFieldInfoPtr_active;
  private static readonly IntPtr NativeFieldInfoPtr_pool;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Assign_Private_Void_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_EntityDestroyed_Private_Void_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Get_Private_Shadow_0;
  private static readonly IntPtr NativeMethodInfoPtr_Pool_Private_Void_Shadow_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53638, XrefRangeEnd = 53652, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ShadowManager.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53652, XrefRangeEnd = 53666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ShadowManager.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53666, XrefRangeEnd = 53688, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Assign(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ShadowManager.NativeMethodInfoPtr_Assign_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53688, XrefRangeEnd = 53703, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityDestroyed(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ShadowManager.NativeMethodInfoPtr_EntityDestroyed_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53703, XrefRangeEnd = 53738, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LateUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ShadowManager.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53738, XrefRangeEnd = 53752, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Shadow Get()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(ShadowManager.NativeMethodInfoPtr_Get_Private_Shadow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    IntPtr pointer = num;
    return pointer == IntPtr.Zero ? (Shadow) null : new Shadow(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53752, XrefRangeEnd = 53758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Pool(Shadow shadow)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) shadow)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ShadowManager.NativeMethodInfoPtr_Pool_Private_Void_Shadow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53758, XrefRangeEnd = 53774, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ShadowManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShadowManager>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ShadowManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ShadowManager()
  {
    Il2CppClassPointerStore<ShadowManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ShadowManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadowManager>.NativeClassPtr);
    ShadowManager.NativeFieldInfoPtr_shadowPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowManager>.NativeClassPtr, nameof (shadowPrefab));
    ShadowManager.NativeFieldInfoPtr_limitX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowManager>.NativeClassPtr, nameof (limitX));
    ShadowManager.NativeFieldInfoPtr_limitY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowManager>.NativeClassPtr, nameof (limitY));
    ShadowManager.NativeFieldInfoPtr_limitZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowManager>.NativeClassPtr, nameof (limitZ));
    ShadowManager.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowManager>.NativeClassPtr, nameof (offset));
    ShadowManager.NativeFieldInfoPtr_offsetBasedOnScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowManager>.NativeClassPtr, nameof (offsetBasedOnScale));
    ShadowManager.NativeFieldInfoPtr_considerScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowManager>.NativeClassPtr, nameof (considerScale));
    ShadowManager.NativeFieldInfoPtr_baseScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowManager>.NativeClassPtr, nameof (baseScale));
    ShadowManager.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowManager>.NativeClassPtr, nameof (active));
    ShadowManager.NativeFieldInfoPtr_pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowManager>.NativeClassPtr, nameof (pool));
    ShadowManager.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowManager>.NativeClassPtr, 100667684);
    ShadowManager.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowManager>.NativeClassPtr, 100667685);
    ShadowManager.NativeMethodInfoPtr_Assign_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowManager>.NativeClassPtr, 100667686);
    ShadowManager.NativeMethodInfoPtr_EntityDestroyed_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowManager>.NativeClassPtr, 100667687);
    ShadowManager.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowManager>.NativeClassPtr, 100667688);
    ShadowManager.NativeMethodInfoPtr_Get_Private_Shadow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowManager>.NativeClassPtr, 100667689);
    ShadowManager.NativeMethodInfoPtr_Pool_Private_Void_Shadow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowManager>.NativeClassPtr, 100667690);
    ShadowManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowManager>.NativeClassPtr, 100667691);
  }

  public ShadowManager(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Shadow shadowPrefab
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowManager.NativeFieldInfoPtr_shadowPrefab));
      return pointer == IntPtr.Zero ? (Shadow) null : new Shadow(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShadowManager.NativeFieldInfoPtr_shadowPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector2 limitX
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowManager.NativeFieldInfoPtr_limitX));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowManager.NativeFieldInfoPtr_limitX)) = value;
    }
  }

  public unsafe Vector2 limitY
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowManager.NativeFieldInfoPtr_limitY));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowManager.NativeFieldInfoPtr_limitY)) = value;
    }
  }

  public unsafe Vector2 limitZ
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowManager.NativeFieldInfoPtr_limitZ));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowManager.NativeFieldInfoPtr_limitZ)) = value;
    }
  }

  public unsafe Vector3 offset
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowManager.NativeFieldInfoPtr_offset));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowManager.NativeFieldInfoPtr_offset)) = value;
    }
  }

  public unsafe Vector3 offsetBasedOnScale
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowManager.NativeFieldInfoPtr_offsetBasedOnScale));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowManager.NativeFieldInfoPtr_offsetBasedOnScale)) = value;
    }
  }

  public unsafe float considerScale
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowManager.NativeFieldInfoPtr_considerScale));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowManager.NativeFieldInfoPtr_considerScale)) = value;
    }
  }

  public unsafe Vector3 baseScale
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowManager.NativeFieldInfoPtr_baseScale));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowManager.NativeFieldInfoPtr_baseScale)) = value;
    }
  }

  public unsafe Dictionary<ulong, Shadow> active
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowManager.NativeFieldInfoPtr_active));
      return pointer == IntPtr.Zero ? (Dictionary<ulong, Shadow>) null : new Dictionary<ulong, Shadow>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShadowManager.NativeFieldInfoPtr_active), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Queue<Shadow> pool
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowManager.NativeFieldInfoPtr_pool));
      return pointer == IntPtr.Zero ? (Queue<Shadow>) null : new Queue<Shadow>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShadowManager.NativeFieldInfoPtr_pool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
