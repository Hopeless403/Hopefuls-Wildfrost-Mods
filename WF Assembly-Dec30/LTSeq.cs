// Decompiled with JetBrains decompiler
// Type: LTSeq
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class LTSeq : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_previous;
  private static readonly System.IntPtr NativeFieldInfoPtr_current;
  private static readonly System.IntPtr NativeFieldInfoPtr_tween;
  private static readonly System.IntPtr NativeFieldInfoPtr_totalDelay;
  private static readonly System.IntPtr NativeFieldInfoPtr_timeScale;
  private static readonly System.IntPtr NativeFieldInfoPtr_debugIter;
  private static readonly System.IntPtr NativeFieldInfoPtr_counter;
  private static readonly System.IntPtr NativeFieldInfoPtr_toggle;
  private static readonly System.IntPtr NativeFieldInfoPtr__id;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_id_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_reset_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_init_Public_Void_UInt32_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_addOn_Private_LTSeq_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_addPreviousDelays_Private_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_append_Public_LTSeq_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_append_Public_LTSeq_Action_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_append_Public_LTSeq_Action_1_Object_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_append_Public_LTSeq_GameObject_Action_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_append_Public_LTSeq_GameObject_Action_1_Object_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_append_Public_LTSeq_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_insert_Public_LTSeq_LTDescr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setScale_Public_LTSeq_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setScaleRecursive_Private_Void_LTSeq_Single_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_reverse_Public_LTSeq_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe int id
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTSeq.NativeMethodInfoPtr_get_id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 136815, RefRangeEnd = 136816, XrefRangeStart = 136813, XrefRangeEnd = 136815, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void reset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTSeq.NativeMethodInfoPtr_reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136816, XrefRangeEnd = 136819, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void init(uint id, uint global_counter)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &id;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &global_counter;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTSeq.NativeMethodInfoPtr_init_Public_Void_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 136825, RefRangeEnd = 136836, XrefRangeStart = 136819, XrefRangeEnd = 136825, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTSeq addOn()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTSeq.NativeMethodInfoPtr_addOn_Private_LTSeq_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTSeq) null : new LTSeq(pointer);
  }

  [CallerCount(0)]
  public unsafe float addPreviousDelays()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTSeq.NativeMethodInfoPtr_addPreviousDelays_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public unsafe LTSeq append(float delay)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &delay
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTSeq.NativeMethodInfoPtr_append_Public_LTSeq_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTSeq) null : new LTSeq(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136836, XrefRangeEnd = 136845, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTSeq append(Il2CppSystem.Action callback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTSeq.NativeMethodInfoPtr_append_Public_LTSeq_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTSeq) null : new LTSeq(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136845, XrefRangeEnd = 136856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTSeq append(Il2CppSystem.Action<Il2CppSystem.Object> callback, Il2CppSystem.Object obj)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTSeq.NativeMethodInfoPtr_append_Public_LTSeq_Action_1_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTSeq) null : new LTSeq(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136856, XrefRangeEnd = 136866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTSeq append(GameObject gameObject, Il2CppSystem.Action callback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTSeq.NativeMethodInfoPtr_append_Public_LTSeq_GameObject_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTSeq) null : new LTSeq(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136866, XrefRangeEnd = 136877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTSeq append(GameObject gameObject, Il2CppSystem.Action<Il2CppSystem.Object> callback, Il2CppSystem.Object obj)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTSeq.NativeMethodInfoPtr_append_Public_LTSeq_GameObject_Action_1_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTSeq) null : new LTSeq(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136877, XrefRangeEnd = 136882, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTSeq append(LTDescr tween)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tween)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTSeq.NativeMethodInfoPtr_append_Public_LTSeq_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTSeq) null : new LTSeq(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136882, XrefRangeEnd = 136887, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTSeq insert(LTDescr tween)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tween)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTSeq.NativeMethodInfoPtr_insert_Public_LTSeq_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTSeq) null : new LTSeq(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136887, XrefRangeEnd = 136892, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTSeq setScale(float timeScale)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &timeScale
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTSeq.NativeMethodInfoPtr_setScale_Public_LTSeq_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTSeq) null : new LTSeq(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 136894, RefRangeEnd = 136895, XrefRangeStart = 136892, XrefRangeEnd = 136894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void setScaleRecursive(LTSeq seq, float timeScale, int count)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) seq);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &timeScale;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTSeq.NativeMethodInfoPtr_setScaleRecursive_Private_Void_LTSeq_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136895, XrefRangeEnd = 136896, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTSeq reverse()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LTSeq.NativeMethodInfoPtr_reverse_Public_LTSeq_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (LTSeq) null : new LTSeq(pointer);
  }

  [CallerCount(1959)]
  [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTSeq()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTSeq>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTSeq.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static LTSeq()
  {
    Il2CppClassPointerStore<LTSeq>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (LTSeq));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LTSeq>.NativeClassPtr);
    LTSeq.NativeFieldInfoPtr_previous = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, nameof (previous));
    LTSeq.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, nameof (current));
    LTSeq.NativeFieldInfoPtr_tween = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, nameof (tween));
    LTSeq.NativeFieldInfoPtr_totalDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, nameof (totalDelay));
    LTSeq.NativeFieldInfoPtr_timeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, nameof (timeScale));
    LTSeq.NativeFieldInfoPtr_debugIter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, nameof (debugIter));
    LTSeq.NativeFieldInfoPtr_counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, nameof (counter));
    LTSeq.NativeFieldInfoPtr_toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, nameof (toggle));
    LTSeq.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, nameof (_id));
    LTSeq.NativeMethodInfoPtr_get_id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, 100677413);
    LTSeq.NativeMethodInfoPtr_reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, 100677414);
    LTSeq.NativeMethodInfoPtr_init_Public_Void_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, 100677415);
    LTSeq.NativeMethodInfoPtr_addOn_Private_LTSeq_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, 100677416);
    LTSeq.NativeMethodInfoPtr_addPreviousDelays_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, 100677417);
    LTSeq.NativeMethodInfoPtr_append_Public_LTSeq_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, 100677418);
    LTSeq.NativeMethodInfoPtr_append_Public_LTSeq_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, 100677419);
    LTSeq.NativeMethodInfoPtr_append_Public_LTSeq_Action_1_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, 100677420);
    LTSeq.NativeMethodInfoPtr_append_Public_LTSeq_GameObject_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, 100677421);
    LTSeq.NativeMethodInfoPtr_append_Public_LTSeq_GameObject_Action_1_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, 100677422);
    LTSeq.NativeMethodInfoPtr_append_Public_LTSeq_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, 100677423);
    LTSeq.NativeMethodInfoPtr_insert_Public_LTSeq_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, 100677424);
    LTSeq.NativeMethodInfoPtr_setScale_Public_LTSeq_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, 100677425);
    LTSeq.NativeMethodInfoPtr_setScaleRecursive_Private_Void_LTSeq_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, 100677426);
    LTSeq.NativeMethodInfoPtr_reverse_Public_LTSeq_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, 100677427);
    LTSeq.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, 100677428);
  }

  public LTSeq(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe LTSeq previous
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTSeq.NativeFieldInfoPtr_previous));
      return pointer == System.IntPtr.Zero ? (LTSeq) null : new LTSeq(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LTSeq.NativeFieldInfoPtr_previous), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LTSeq current
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTSeq.NativeFieldInfoPtr_current));
      return pointer == System.IntPtr.Zero ? (LTSeq) null : new LTSeq(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LTSeq.NativeFieldInfoPtr_current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LTDescr tween
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTSeq.NativeFieldInfoPtr_tween));
      return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LTSeq.NativeFieldInfoPtr_tween), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float totalDelay
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTSeq.NativeFieldInfoPtr_totalDelay));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTSeq.NativeFieldInfoPtr_totalDelay)) = value;
    }
  }

  public unsafe float timeScale
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTSeq.NativeFieldInfoPtr_timeScale));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTSeq.NativeFieldInfoPtr_timeScale)) = value;
    }
  }

  public unsafe int debugIter
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTSeq.NativeFieldInfoPtr_debugIter));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTSeq.NativeFieldInfoPtr_debugIter)) = value;
    }
  }

  public unsafe uint counter
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTSeq.NativeFieldInfoPtr_counter));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTSeq.NativeFieldInfoPtr_counter)) = value;
    }
  }

  public unsafe bool toggle
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTSeq.NativeFieldInfoPtr_toggle));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTSeq.NativeFieldInfoPtr_toggle)) = value;
    }
  }

  public unsafe uint _id
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTSeq.NativeFieldInfoPtr__id));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTSeq.NativeFieldInfoPtr__id)) = value;
    }
  }
}
