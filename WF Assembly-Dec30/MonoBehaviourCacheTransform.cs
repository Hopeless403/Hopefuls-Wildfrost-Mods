// Decompiled with JetBrains decompiler
// Type: MonoBehaviourCacheTransform
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
public class MonoBehaviourCacheTransform : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr__transform;
  private static readonly IntPtr NativeMethodInfoPtr_get_transform_Public_get_Transform_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public new unsafe Transform transform
  {
    [CallerCount(211), CachedScanResults(RefRangeStart = 52714, RefRangeEnd = 52925, XrefRangeStart = 52710, XrefRangeEnd = 52714, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(MonoBehaviourCacheTransform.NativeMethodInfoPtr_get_transform_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MonoBehaviourCacheTransform()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBehaviourCacheTransform>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MonoBehaviourCacheTransform.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static MonoBehaviourCacheTransform()
  {
    Il2CppClassPointerStore<MonoBehaviourCacheTransform>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (MonoBehaviourCacheTransform));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBehaviourCacheTransform>.NativeClassPtr);
    MonoBehaviourCacheTransform.NativeFieldInfoPtr__transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBehaviourCacheTransform>.NativeClassPtr, nameof (_transform));
    MonoBehaviourCacheTransform.NativeMethodInfoPtr_get_transform_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviourCacheTransform>.NativeClassPtr, 100667564);
    MonoBehaviourCacheTransform.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviourCacheTransform>.NativeClassPtr, 100667565);
  }

  public MonoBehaviourCacheTransform(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Transform _transform
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MonoBehaviourCacheTransform.NativeFieldInfoPtr__transform));
      return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MonoBehaviourCacheTransform.NativeFieldInfoPtr__transform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
