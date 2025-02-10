// Decompiled with JetBrains decompiler
// Type: CopyRectTransform
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
public class CopyRectTransform : MonoBehaviourRect
{
  private static readonly IntPtr NativeFieldInfoPtr_target;
  private static readonly IntPtr NativeFieldInfoPtr_onEnable;
  private static readonly IntPtr NativeFieldInfoPtr_onUpdate;
  private static readonly IntPtr NativeFieldInfoPtr_onValidate;
  private static readonly IntPtr NativeFieldInfoPtr_copyPosition;
  private static readonly IntPtr NativeFieldInfoPtr_copyRotation;
  private static readonly IntPtr NativeFieldInfoPtr_copySize;
  private static readonly IntPtr NativeFieldInfoPtr_copyPivot;
  private static readonly IntPtr NativeFieldInfoPtr_copyScale;
  private static readonly IntPtr NativeFieldInfoPtr_invertScale;
  private static readonly IntPtr NativeMethodInfoPtr_get_hasTarget_Private_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_hasTargetAndCopyScale_Private_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Copy_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe bool hasTarget
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38190, XrefRangeEnd = 38194, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(CopyRectTransform.NativeMethodInfoPtr_get_hasTarget_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public unsafe bool hasTargetAndCopyScale
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38194, XrefRangeEnd = 38198, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(CopyRectTransform.NativeMethodInfoPtr_get_hasTargetAndCopyScale_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38198, XrefRangeEnd = 38199, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CopyRectTransform.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38199, XrefRangeEnd = 38200, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LateUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CopyRectTransform.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 38222, RefRangeEnd = 38224, XrefRangeStart = 38200, XrefRangeEnd = 38222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Copy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CopyRectTransform.NativeMethodInfoPtr_Copy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38224, XrefRangeEnd = 38225, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CopyRectTransform()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CopyRectTransform>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CopyRectTransform.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CopyRectTransform()
  {
    Il2CppClassPointerStore<CopyRectTransform>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CopyRectTransform));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopyRectTransform>.NativeClassPtr);
    CopyRectTransform.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyRectTransform>.NativeClassPtr, nameof (target));
    CopyRectTransform.NativeFieldInfoPtr_onEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyRectTransform>.NativeClassPtr, nameof (onEnable));
    CopyRectTransform.NativeFieldInfoPtr_onUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyRectTransform>.NativeClassPtr, nameof (onUpdate));
    CopyRectTransform.NativeFieldInfoPtr_onValidate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyRectTransform>.NativeClassPtr, nameof (onValidate));
    CopyRectTransform.NativeFieldInfoPtr_copyPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyRectTransform>.NativeClassPtr, nameof (copyPosition));
    CopyRectTransform.NativeFieldInfoPtr_copyRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyRectTransform>.NativeClassPtr, nameof (copyRotation));
    CopyRectTransform.NativeFieldInfoPtr_copySize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyRectTransform>.NativeClassPtr, nameof (copySize));
    CopyRectTransform.NativeFieldInfoPtr_copyPivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyRectTransform>.NativeClassPtr, nameof (copyPivot));
    CopyRectTransform.NativeFieldInfoPtr_copyScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyRectTransform>.NativeClassPtr, nameof (copyScale));
    CopyRectTransform.NativeFieldInfoPtr_invertScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyRectTransform>.NativeClassPtr, nameof (invertScale));
    CopyRectTransform.NativeMethodInfoPtr_get_hasTarget_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyRectTransform>.NativeClassPtr, 100665872);
    CopyRectTransform.NativeMethodInfoPtr_get_hasTargetAndCopyScale_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyRectTransform>.NativeClassPtr, 100665873);
    CopyRectTransform.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyRectTransform>.NativeClassPtr, 100665874);
    CopyRectTransform.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyRectTransform>.NativeClassPtr, 100665875);
    CopyRectTransform.NativeMethodInfoPtr_Copy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyRectTransform>.NativeClassPtr, 100665876);
    CopyRectTransform.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyRectTransform>.NativeClassPtr, 100665877);
  }

  public CopyRectTransform(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe RectTransform target
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CopyRectTransform.NativeFieldInfoPtr_target));
      return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CopyRectTransform.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool onEnable
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CopyRectTransform.NativeFieldInfoPtr_onEnable));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CopyRectTransform.NativeFieldInfoPtr_onEnable)) = value;
    }
  }

  public unsafe bool onUpdate
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CopyRectTransform.NativeFieldInfoPtr_onUpdate));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CopyRectTransform.NativeFieldInfoPtr_onUpdate)) = value;
    }
  }

  public unsafe bool onValidate
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CopyRectTransform.NativeFieldInfoPtr_onValidate));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CopyRectTransform.NativeFieldInfoPtr_onValidate)) = value;
    }
  }

  public unsafe bool copyPosition
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CopyRectTransform.NativeFieldInfoPtr_copyPosition));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CopyRectTransform.NativeFieldInfoPtr_copyPosition)) = value;
    }
  }

  public unsafe bool copyRotation
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CopyRectTransform.NativeFieldInfoPtr_copyRotation));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CopyRectTransform.NativeFieldInfoPtr_copyRotation)) = value;
    }
  }

  public unsafe bool copySize
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CopyRectTransform.NativeFieldInfoPtr_copySize));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CopyRectTransform.NativeFieldInfoPtr_copySize)) = value;
    }
  }

  public unsafe bool copyPivot
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CopyRectTransform.NativeFieldInfoPtr_copyPivot));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CopyRectTransform.NativeFieldInfoPtr_copyPivot)) = value;
    }
  }

  public unsafe bool copyScale
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CopyRectTransform.NativeFieldInfoPtr_copyScale));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CopyRectTransform.NativeFieldInfoPtr_copyScale)) = value;
    }
  }

  public unsafe bool invertScale
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CopyRectTransform.NativeFieldInfoPtr_invertScale));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CopyRectTransform.NativeFieldInfoPtr_invertScale)) = value;
    }
  }
}
