// Decompiled with JetBrains decompiler
// Type: Scroller
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class Scroller : MonoBehaviourRect
{
  private static readonly System.IntPtr NativeFieldInfoPtr_navLayer;
  private static readonly System.IntPtr NativeFieldInfoPtr_interactable;
  private static readonly System.IntPtr NativeFieldInfoPtr_scrollSpeed;
  private static readonly System.IntPtr NativeFieldInfoPtr_scrollAmount;
  private static readonly System.IntPtr NativeFieldInfoPtr_horizontal;
  private static readonly System.IntPtr NativeFieldInfoPtr_bounds;
  private static readonly System.IntPtr NativeFieldInfoPtr_boundsHardness;
  private static readonly System.IntPtr NativeFieldInfoPtr_onScroll;
  private static readonly System.IntPtr NativeFieldInfoPtr_afterScroll;
  private static readonly System.IntPtr NativeFieldInfoPtr_targetPos;
  private static readonly System.IntPtr NativeFieldInfoPtr_preTargetPos;
  private static readonly System.IntPtr NativeFieldInfoPtr_hasStartScroll;
  private static readonly System.IntPtr NativeFieldInfoPtr_startScroll;
  private static readonly System.IntPtr NativeFieldInfoPtr_ignoreTimeScale;
  private static readonly System.IntPtr NativeFieldInfoPtr_scrollKnob;
  private static readonly System.IntPtr NativeFieldInfoPtr_scrollKnobBounds;
  private static readonly System.IntPtr NativeFieldInfoPtr_boundsDelay;
  private static readonly System.IntPtr NativeFieldInfoPtr_boundsDelayMax;
  private static readonly System.IntPtr NativeFieldInfoPtr_checkBounds;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DeltaTime_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_s_Private_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_TargetPos_Private_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_TargetPos_Private_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ScrollAmount_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ScrollAmount_Public_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FindComponentInParents_Private_T_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckNavigationLayer_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InvokeAfterScroll_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Scroll_Public_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ScrollImmediate_Public_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ScrollTo_Public_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ScrollTo_Public_Void_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckBounds_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetRelevant_Private_Single_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetRelevant_Private_Vector2_Vector2_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddRelevant_Private_Vector2_Vector2_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateScrollKnob_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe float DeltaTime
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 94511, RefRangeEnd = 94514, XrefRangeStart = 94509, XrefRangeEnd = 94511, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Scroller.NativeMethodInfoPtr_get_DeltaTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public unsafe float s
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 94520, RefRangeEnd = 94531, XrefRangeStart = 94514, XrefRangeEnd = 94520, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Scroller.NativeMethodInfoPtr_get_s_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public unsafe float TargetPos
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Scroller.NativeMethodInfoPtr_get_TargetPos_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Scroller.NativeMethodInfoPtr_set_TargetPos_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe float ScrollAmount
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94531, XrefRangeEnd = 94534, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Scroller.NativeMethodInfoPtr_get_ScrollAmount_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94534, XrefRangeEnd = 94536, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Scroller.NativeMethodInfoPtr_set_ScrollAmount_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94536, XrefRangeEnd = 94555, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Scroller.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 94565, RefRangeEnd = 94566, XrefRangeStart = 94555, XrefRangeEnd = 94565, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe T FindComponentInParents<T>(Transform parent) where T : Component
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parent)
    };
    System.IntPtr exc;
    System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(Scroller.MethodInfoStoreGeneric_FindComponentInParents_Private_T_Transform_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94566, XrefRangeEnd = 94573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Scroller.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 94578, RefRangeEnd = 94579, XrefRangeStart = 94573, XrefRangeEnd = 94578, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CheckNavigationLayer()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Scroller.NativeMethodInfoPtr_CheckNavigationLayer_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94579, XrefRangeEnd = 94617, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Scroller.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94617, XrefRangeEnd = 94618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LateUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Scroller.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 94629, RefRangeEnd = 94631, XrefRangeStart = 94618, XrefRangeEnd = 94629, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InvokeAfterScroll()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Scroller.NativeMethodInfoPtr_InvokeAfterScroll_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94631, XrefRangeEnd = 94634, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Scroll(float amount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &amount
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Scroller.NativeMethodInfoPtr_Scroll_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 94641, RefRangeEnd = 94642, XrefRangeStart = 94634, XrefRangeEnd = 94641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ScrollImmediate(float amount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &amount
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Scroller.NativeMethodInfoPtr_ScrollImmediate_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94642, XrefRangeEnd = 94647, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ScrollTo(float position)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &position
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Scroller.NativeMethodInfoPtr_ScrollTo_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 94649, RefRangeEnd = 94650, XrefRangeStart = 94647, XrefRangeEnd = 94649, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ScrollTo(Vector2 targetPos)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &targetPos
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Scroller.NativeMethodInfoPtr_ScrollTo_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 94659, RefRangeEnd = 94662, XrefRangeStart = 94650, XrefRangeEnd = 94659, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CheckBounds()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Scroller.NativeMethodInfoPtr_CheckBounds_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe float GetRelevant(Vector2 vector2)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &vector2
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Scroller.NativeMethodInfoPtr_GetRelevant_Private_Single_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public unsafe Vector2 SetRelevant(Vector2 vector2, float value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &vector2;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Scroller.NativeMethodInfoPtr_SetRelevant_Private_Vector2_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public unsafe Vector2 AddRelevant(Vector2 vector2, float value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &vector2;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Scroller.NativeMethodInfoPtr_AddRelevant_Private_Vector2_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(10)]
  [CachedScanResults(RefRangeStart = 94689, RefRangeEnd = 94699, XrefRangeStart = 94662, XrefRangeEnd = 94689, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateScrollKnob()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Scroller.NativeMethodInfoPtr_UpdateScrollKnob_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe void SetInteractable(bool value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Scroller.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94699, XrefRangeEnd = 94700, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Scroller()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Scroller>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Scroller.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static Scroller()
  {
    Il2CppClassPointerStore<Scroller>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (Scroller));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Scroller>.NativeClassPtr);
    Scroller.NativeFieldInfoPtr_navLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroller>.NativeClassPtr, nameof (navLayer));
    Scroller.NativeFieldInfoPtr_interactable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroller>.NativeClassPtr, nameof (interactable));
    Scroller.NativeFieldInfoPtr_scrollSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroller>.NativeClassPtr, nameof (scrollSpeed));
    Scroller.NativeFieldInfoPtr_scrollAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroller>.NativeClassPtr, nameof (scrollAmount));
    Scroller.NativeFieldInfoPtr_horizontal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroller>.NativeClassPtr, nameof (horizontal));
    Scroller.NativeFieldInfoPtr_bounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroller>.NativeClassPtr, nameof (bounds));
    Scroller.NativeFieldInfoPtr_boundsHardness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroller>.NativeClassPtr, nameof (boundsHardness));
    Scroller.NativeFieldInfoPtr_onScroll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroller>.NativeClassPtr, nameof (onScroll));
    Scroller.NativeFieldInfoPtr_afterScroll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroller>.NativeClassPtr, nameof (afterScroll));
    Scroller.NativeFieldInfoPtr_targetPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroller>.NativeClassPtr, nameof (targetPos));
    Scroller.NativeFieldInfoPtr_preTargetPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroller>.NativeClassPtr, nameof (preTargetPos));
    Scroller.NativeFieldInfoPtr_hasStartScroll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroller>.NativeClassPtr, nameof (hasStartScroll));
    Scroller.NativeFieldInfoPtr_startScroll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroller>.NativeClassPtr, nameof (startScroll));
    Scroller.NativeFieldInfoPtr_ignoreTimeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroller>.NativeClassPtr, nameof (ignoreTimeScale));
    Scroller.NativeFieldInfoPtr_scrollKnob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroller>.NativeClassPtr, nameof (scrollKnob));
    Scroller.NativeFieldInfoPtr_scrollKnobBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroller>.NativeClassPtr, nameof (scrollKnobBounds));
    Scroller.NativeFieldInfoPtr_boundsDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroller>.NativeClassPtr, nameof (boundsDelay));
    Scroller.NativeFieldInfoPtr_boundsDelayMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroller>.NativeClassPtr, nameof (boundsDelayMax));
    Scroller.NativeFieldInfoPtr_checkBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroller>.NativeClassPtr, nameof (checkBounds));
    Scroller.NativeMethodInfoPtr_get_DeltaTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller>.NativeClassPtr, 100671463);
    Scroller.NativeMethodInfoPtr_get_s_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller>.NativeClassPtr, 100671464);
    Scroller.NativeMethodInfoPtr_get_TargetPos_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller>.NativeClassPtr, 100671465);
    Scroller.NativeMethodInfoPtr_set_TargetPos_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller>.NativeClassPtr, 100671466);
    Scroller.NativeMethodInfoPtr_get_ScrollAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller>.NativeClassPtr, 100671467);
    Scroller.NativeMethodInfoPtr_set_ScrollAmount_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller>.NativeClassPtr, 100671468);
    Scroller.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller>.NativeClassPtr, 100671469);
    Scroller.NativeMethodInfoPtr_FindComponentInParents_Private_T_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller>.NativeClassPtr, 100671470);
    Scroller.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller>.NativeClassPtr, 100671471);
    Scroller.NativeMethodInfoPtr_CheckNavigationLayer_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller>.NativeClassPtr, 100671472);
    Scroller.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller>.NativeClassPtr, 100671473);
    Scroller.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller>.NativeClassPtr, 100671474);
    Scroller.NativeMethodInfoPtr_InvokeAfterScroll_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller>.NativeClassPtr, 100671475);
    Scroller.NativeMethodInfoPtr_Scroll_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller>.NativeClassPtr, 100671476);
    Scroller.NativeMethodInfoPtr_ScrollImmediate_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller>.NativeClassPtr, 100671477);
    Scroller.NativeMethodInfoPtr_ScrollTo_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller>.NativeClassPtr, 100671478);
    Scroller.NativeMethodInfoPtr_ScrollTo_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller>.NativeClassPtr, 100671479);
    Scroller.NativeMethodInfoPtr_CheckBounds_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller>.NativeClassPtr, 100671480);
    Scroller.NativeMethodInfoPtr_GetRelevant_Private_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller>.NativeClassPtr, 100671481);
    Scroller.NativeMethodInfoPtr_SetRelevant_Private_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller>.NativeClassPtr, 100671482);
    Scroller.NativeMethodInfoPtr_AddRelevant_Private_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller>.NativeClassPtr, 100671483);
    Scroller.NativeMethodInfoPtr_UpdateScrollKnob_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller>.NativeClassPtr, 100671484);
    Scroller.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller>.NativeClassPtr, 100671485);
    Scroller.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller>.NativeClassPtr, 100671486);
  }

  public Scroller(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe UINavigationLayer navLayer
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scroller.NativeFieldInfoPtr_navLayer));
      return pointer == System.IntPtr.Zero ? (UINavigationLayer) null : new UINavigationLayer(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Scroller.NativeFieldInfoPtr_navLayer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool interactable
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scroller.NativeFieldInfoPtr_interactable));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scroller.NativeFieldInfoPtr_interactable)) = value;
    }
  }

  public unsafe float scrollSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scroller.NativeFieldInfoPtr_scrollSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scroller.NativeFieldInfoPtr_scrollSpeed)) = value;
    }
  }

  public unsafe float scrollAmount
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scroller.NativeFieldInfoPtr_scrollAmount));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scroller.NativeFieldInfoPtr_scrollAmount)) = value;
    }
  }

  public unsafe bool horizontal
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scroller.NativeFieldInfoPtr_horizontal));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scroller.NativeFieldInfoPtr_horizontal)) = value;
    }
  }

  public unsafe RectTransform bounds
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scroller.NativeFieldInfoPtr_bounds));
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Scroller.NativeFieldInfoPtr_bounds), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float boundsHardness
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scroller.NativeFieldInfoPtr_boundsHardness));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scroller.NativeFieldInfoPtr_boundsHardness)) = value;
    }
  }

  public unsafe UnityEvent onScroll
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scroller.NativeFieldInfoPtr_onScroll));
      return pointer == System.IntPtr.Zero ? (UnityEvent) null : new UnityEvent(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Scroller.NativeFieldInfoPtr_onScroll), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEvent<float> afterScroll
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scroller.NativeFieldInfoPtr_afterScroll));
      return pointer == System.IntPtr.Zero ? (UnityEvent<float>) null : new UnityEvent<float>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Scroller.NativeFieldInfoPtr_afterScroll), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector2 targetPos
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scroller.NativeFieldInfoPtr_targetPos));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scroller.NativeFieldInfoPtr_targetPos)) = value;
    }
  }

  public unsafe Vector2 preTargetPos
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scroller.NativeFieldInfoPtr_preTargetPos));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scroller.NativeFieldInfoPtr_preTargetPos)) = value;
    }
  }

  public unsafe bool hasStartScroll
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scroller.NativeFieldInfoPtr_hasStartScroll));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scroller.NativeFieldInfoPtr_hasStartScroll)) = value;
    }
  }

  public unsafe float startScroll
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scroller.NativeFieldInfoPtr_startScroll));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scroller.NativeFieldInfoPtr_startScroll)) = value;
    }
  }

  public unsafe bool ignoreTimeScale
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scroller.NativeFieldInfoPtr_ignoreTimeScale));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scroller.NativeFieldInfoPtr_ignoreTimeScale)) = value;
    }
  }

  public unsafe RectTransform scrollKnob
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scroller.NativeFieldInfoPtr_scrollKnob));
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Scroller.NativeFieldInfoPtr_scrollKnob), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform scrollKnobBounds
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scroller.NativeFieldInfoPtr_scrollKnobBounds));
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Scroller.NativeFieldInfoPtr_scrollKnobBounds), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float boundsDelay
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scroller.NativeFieldInfoPtr_boundsDelay));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scroller.NativeFieldInfoPtr_boundsDelay)) = value;
    }
  }

  public static unsafe float boundsDelayMax
  {
    get
    {
      float boundsDelayMax;
      IL2CPP.il2cpp_field_static_get_value(Scroller.NativeFieldInfoPtr_boundsDelayMax, (void*) &boundsDelayMax);
      return boundsDelayMax;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Scroller.NativeFieldInfoPtr_boundsDelayMax, (void*) &value);
    }
  }

  public unsafe bool checkBounds
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scroller.NativeFieldInfoPtr_checkBounds));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scroller.NativeFieldInfoPtr_checkBounds)) = value;
    }
  }

  private sealed class MethodInfoStoreGeneric_FindComponentInParents_Private_T_Transform_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Scroller.NativeMethodInfoPtr_FindComponentInParents_Private_T_Transform_0, Il2CppClassPointerStore<Scroller>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
