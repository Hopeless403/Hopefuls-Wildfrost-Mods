// Decompiled with JetBrains decompiler
// Type: UINavigationItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class UINavigationItem : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_navigationLayer;
  private static readonly IntPtr NativeFieldInfoPtr_offset;
  private static readonly IntPtr NativeFieldInfoPtr_selectionPriority;
  private static readonly IntPtr NativeFieldInfoPtr_clickHandler;
  private static readonly IntPtr NativeFieldInfoPtr_isHighlighted;
  private static readonly IntPtr NativeFieldInfoPtr_canLoop;
  private static readonly IntPtr NativeFieldInfoPtr_ignoreLayers;
  private static readonly IntPtr NativeFieldInfoPtr_isSelectable;
  private static readonly IntPtr NativeFieldInfoPtr_overrideInputs;
  private static readonly IntPtr NativeFieldInfoPtr_inputLeft;
  private static readonly IntPtr NativeFieldInfoPtr_inputRight;
  private static readonly IntPtr NativeFieldInfoPtr_inputUp;
  private static readonly IntPtr NativeFieldInfoPtr_inputDown;
  private static readonly IntPtr NativeFieldInfoPtr_overrideHorizontal;
  private static readonly IntPtr NativeFieldInfoPtr_OnHorizontalOverride;
  private static readonly IntPtr NativeFieldInfoPtr_overrideVertical;
  private static readonly IntPtr NativeFieldInfoPtr_OnVerticalOverride;
  private static readonly IntPtr NativeFieldInfoPtr_hasLayerBeenChecked;
  private static readonly IntPtr NativeFieldInfoPtr__cam;
  private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_get_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_cam_Public_get_Camera_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnRemoved_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnTransformParentChanged_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckForReferences_Private_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckForNavigationLayer_Internal_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckForNavigationLayer_Internal_Void_Transform_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckForSelectable_Internal_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckForSelectableDown_Internal_Void_Transform_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckForSelectableUp_Internal_Void_Transform_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckLayer_Internal_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe Vector3 Position
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 18293, RefRangeEnd = 18296, XrefRangeStart = 18291, XrefRangeEnd = 18293, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationItem.NativeMethodInfoPtr_get_Position_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public unsafe Camera cam
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18296, XrefRangeEnd = 18298, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationItem.NativeMethodInfoPtr_get_cam_Public_get_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (Camera) null : new Camera(pointer);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18298, XrefRangeEnd = 18305, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UINavigationItem.NativeMethodInfoPtr_OnEnable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18305, XrefRangeEnd = 18306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UINavigationItem.NativeMethodInfoPtr_OnDisable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UINavigationItem.NativeMethodInfoPtr_OnDestroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 18316, RefRangeEnd = 18318, XrefRangeStart = 18306, XrefRangeEnd = 18316, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnRemoved()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UINavigationItem.NativeMethodInfoPtr_OnRemoved_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18318, XrefRangeEnd = 18327, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Reset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UINavigationItem.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18327, XrefRangeEnd = 18331, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnTransformParentChanged()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UINavigationItem.NativeMethodInfoPtr_OnTransformParentChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 18342, RefRangeEnd = 18344, XrefRangeStart = 18331, XrefRangeEnd = 18342, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CheckForReferences(bool isFirstTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &isFirstTime
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UINavigationItem.NativeMethodInfoPtr_CheckForReferences_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18344, XrefRangeEnd = 18347, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CheckForNavigationLayer(bool isFirstTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &isFirstTime
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UINavigationItem.NativeMethodInfoPtr_CheckForNavigationLayer_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 18372, RefRangeEnd = 18376, XrefRangeStart = 18347, XrefRangeEnd = 18372, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CheckForNavigationLayer(Transform checkTransform, bool isFirstTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) checkTransform);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &isFirstTime;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UINavigationItem.NativeMethodInfoPtr_CheckForNavigationLayer_Internal_Void_Transform_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 18404, RefRangeEnd = 18405, XrefRangeStart = 18376, XrefRangeEnd = 18404, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CheckForSelectable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UINavigationItem.NativeMethodInfoPtr_CheckForSelectable_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 18422, RefRangeEnd = 18426, XrefRangeStart = 18405, XrefRangeEnd = 18422, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CheckForSelectableDown(Transform checkTransform)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) checkTransform)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UINavigationItem.NativeMethodInfoPtr_CheckForSelectableDown_Internal_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18426, XrefRangeEnd = 18446, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CheckForSelectableUp(Transform checkTransform)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) checkTransform)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UINavigationItem.NativeMethodInfoPtr_CheckForSelectableUp_Internal_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 18455, RefRangeEnd = 18456, XrefRangeStart = 18446, XrefRangeEnd = 18455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CheckLayer()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationItem.NativeMethodInfoPtr_CheckLayer_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UINavigationItem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UINavigationItem>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UINavigationItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static UINavigationItem()
  {
    Il2CppClassPointerStore<UINavigationItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (UINavigationItem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UINavigationItem>.NativeClassPtr);
    UINavigationItem.NativeFieldInfoPtr_navigationLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationItem>.NativeClassPtr, nameof (navigationLayer));
    UINavigationItem.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationItem>.NativeClassPtr, nameof (offset));
    UINavigationItem.NativeFieldInfoPtr_selectionPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationItem>.NativeClassPtr, nameof (selectionPriority));
    UINavigationItem.NativeFieldInfoPtr_clickHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationItem>.NativeClassPtr, nameof (clickHandler));
    UINavigationItem.NativeFieldInfoPtr_isHighlighted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationItem>.NativeClassPtr, nameof (isHighlighted));
    UINavigationItem.NativeFieldInfoPtr_canLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationItem>.NativeClassPtr, nameof (canLoop));
    UINavigationItem.NativeFieldInfoPtr_ignoreLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationItem>.NativeClassPtr, nameof (ignoreLayers));
    UINavigationItem.NativeFieldInfoPtr_isSelectable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationItem>.NativeClassPtr, nameof (isSelectable));
    UINavigationItem.NativeFieldInfoPtr_overrideInputs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationItem>.NativeClassPtr, nameof (overrideInputs));
    UINavigationItem.NativeFieldInfoPtr_inputLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationItem>.NativeClassPtr, nameof (inputLeft));
    UINavigationItem.NativeFieldInfoPtr_inputRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationItem>.NativeClassPtr, nameof (inputRight));
    UINavigationItem.NativeFieldInfoPtr_inputUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationItem>.NativeClassPtr, nameof (inputUp));
    UINavigationItem.NativeFieldInfoPtr_inputDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationItem>.NativeClassPtr, nameof (inputDown));
    UINavigationItem.NativeFieldInfoPtr_overrideHorizontal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationItem>.NativeClassPtr, nameof (overrideHorizontal));
    UINavigationItem.NativeFieldInfoPtr_OnHorizontalOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationItem>.NativeClassPtr, nameof (OnHorizontalOverride));
    UINavigationItem.NativeFieldInfoPtr_overrideVertical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationItem>.NativeClassPtr, nameof (overrideVertical));
    UINavigationItem.NativeFieldInfoPtr_OnVerticalOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationItem>.NativeClassPtr, nameof (OnVerticalOverride));
    UINavigationItem.NativeFieldInfoPtr_hasLayerBeenChecked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationItem>.NativeClassPtr, nameof (hasLayerBeenChecked));
    UINavigationItem.NativeFieldInfoPtr__cam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationItem>.NativeClassPtr, nameof (_cam));
    UINavigationItem.NativeMethodInfoPtr_get_Position_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationItem>.NativeClassPtr, 100663547);
    UINavigationItem.NativeMethodInfoPtr_get_cam_Public_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationItem>.NativeClassPtr, 100663548);
    UINavigationItem.NativeMethodInfoPtr_OnEnable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationItem>.NativeClassPtr, 100663549);
    UINavigationItem.NativeMethodInfoPtr_OnDisable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationItem>.NativeClassPtr, 100663550);
    UINavigationItem.NativeMethodInfoPtr_OnDestroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationItem>.NativeClassPtr, 100663551);
    UINavigationItem.NativeMethodInfoPtr_OnRemoved_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationItem>.NativeClassPtr, 100663552);
    UINavigationItem.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationItem>.NativeClassPtr, 100663553);
    UINavigationItem.NativeMethodInfoPtr_OnTransformParentChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationItem>.NativeClassPtr, 100663554);
    UINavigationItem.NativeMethodInfoPtr_CheckForReferences_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationItem>.NativeClassPtr, 100663555);
    UINavigationItem.NativeMethodInfoPtr_CheckForNavigationLayer_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationItem>.NativeClassPtr, 100663556);
    UINavigationItem.NativeMethodInfoPtr_CheckForNavigationLayer_Internal_Void_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationItem>.NativeClassPtr, 100663557);
    UINavigationItem.NativeMethodInfoPtr_CheckForSelectable_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationItem>.NativeClassPtr, 100663558);
    UINavigationItem.NativeMethodInfoPtr_CheckForSelectableDown_Internal_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationItem>.NativeClassPtr, 100663559);
    UINavigationItem.NativeMethodInfoPtr_CheckForSelectableUp_Internal_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationItem>.NativeClassPtr, 100663560);
    UINavigationItem.NativeMethodInfoPtr_CheckLayer_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationItem>.NativeClassPtr, 100663561);
    UINavigationItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationItem>.NativeClassPtr, 100663562);
  }

  public UINavigationItem(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe UINavigationLayer navigationLayer
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationItem.NativeFieldInfoPtr_navigationLayer));
      return pointer == IntPtr.Zero ? (UINavigationLayer) null : new UINavigationLayer(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UINavigationItem.NativeFieldInfoPtr_navigationLayer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 offset
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationItem.NativeFieldInfoPtr_offset));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationItem.NativeFieldInfoPtr_offset)) = value;
    }
  }

  public unsafe UINavigationItem.SelectionPriority selectionPriority
  {
    get
    {
      return *(UINavigationItem.SelectionPriority*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationItem.NativeFieldInfoPtr_selectionPriority));
    }
    [param: In] set
    {
      *(UINavigationItem.SelectionPriority*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationItem.NativeFieldInfoPtr_selectionPriority)) = value;
    }
  }

  public unsafe GameObject clickHandler
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationItem.NativeFieldInfoPtr_clickHandler));
      return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UINavigationItem.NativeFieldInfoPtr_clickHandler), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool isHighlighted
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationItem.NativeFieldInfoPtr_isHighlighted));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationItem.NativeFieldInfoPtr_isHighlighted)) = value;
    }
  }

  public unsafe bool canLoop
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationItem.NativeFieldInfoPtr_canLoop));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationItem.NativeFieldInfoPtr_canLoop)) = value;
    }
  }

  public unsafe bool ignoreLayers
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationItem.NativeFieldInfoPtr_ignoreLayers));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationItem.NativeFieldInfoPtr_ignoreLayers)) = value;
    }
  }

  public unsafe bool isSelectable
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationItem.NativeFieldInfoPtr_isSelectable));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationItem.NativeFieldInfoPtr_isSelectable)) = value;
    }
  }

  public unsafe bool overrideInputs
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationItem.NativeFieldInfoPtr_overrideInputs));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationItem.NativeFieldInfoPtr_overrideInputs)) = value;
    }
  }

  public unsafe UINavigationItem inputLeft
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationItem.NativeFieldInfoPtr_inputLeft));
      return pointer == IntPtr.Zero ? (UINavigationItem) null : new UINavigationItem(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UINavigationItem.NativeFieldInfoPtr_inputLeft), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UINavigationItem inputRight
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationItem.NativeFieldInfoPtr_inputRight));
      return pointer == IntPtr.Zero ? (UINavigationItem) null : new UINavigationItem(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UINavigationItem.NativeFieldInfoPtr_inputRight), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UINavigationItem inputUp
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationItem.NativeFieldInfoPtr_inputUp));
      return pointer == IntPtr.Zero ? (UINavigationItem) null : new UINavigationItem(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UINavigationItem.NativeFieldInfoPtr_inputUp), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UINavigationItem inputDown
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationItem.NativeFieldInfoPtr_inputDown));
      return pointer == IntPtr.Zero ? (UINavigationItem) null : new UINavigationItem(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UINavigationItem.NativeFieldInfoPtr_inputDown), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool overrideHorizontal
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationItem.NativeFieldInfoPtr_overrideHorizontal));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationItem.NativeFieldInfoPtr_overrideHorizontal)) = value;
    }
  }

  public unsafe UnityEvent<float> OnHorizontalOverride
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationItem.NativeFieldInfoPtr_OnHorizontalOverride));
      return pointer == IntPtr.Zero ? (UnityEvent<float>) null : new UnityEvent<float>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UINavigationItem.NativeFieldInfoPtr_OnHorizontalOverride), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool overrideVertical
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationItem.NativeFieldInfoPtr_overrideVertical));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationItem.NativeFieldInfoPtr_overrideVertical)) = value;
    }
  }

  public unsafe UnityEvent<float> OnVerticalOverride
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationItem.NativeFieldInfoPtr_OnVerticalOverride));
      return pointer == IntPtr.Zero ? (UnityEvent<float>) null : new UnityEvent<float>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UINavigationItem.NativeFieldInfoPtr_OnVerticalOverride), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool hasLayerBeenChecked
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationItem.NativeFieldInfoPtr_hasLayerBeenChecked));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationItem.NativeFieldInfoPtr_hasLayerBeenChecked)) = value;
    }
  }

  public unsafe Camera _cam
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationItem.NativeFieldInfoPtr__cam));
      return pointer == IntPtr.Zero ? (Camera) null : new Camera(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UINavigationItem.NativeFieldInfoPtr__cam), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public enum SelectionPriority
  {
    Lowest = -2, // 0xFFFFFFFE
    Low = -1, // 0xFFFFFFFF
    Medium = 0,
    High = 1,
    Highest = 2,
    Mega = 10, // 0x0000000A
  }
}
