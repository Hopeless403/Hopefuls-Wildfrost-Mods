// Decompiled with JetBrains decompiler
// Type: ScreenFlashSystem
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
public class ScreenFlashSystem : GameSystem
{
  private static readonly IntPtr NativeFieldInfoPtr_instance;
  private static readonly IntPtr NativeFieldInfoPtr_renderer;
  private static readonly IntPtr NativeFieldInfoPtr_curve;
  private static readonly IntPtr NativeFieldInfoPtr_basicMaterial;
  private static readonly IntPtr NativeFieldInfoPtr_additiveMaterial;
  private static readonly IntPtr NativeFieldInfoPtr_color;
  private static readonly IntPtr NativeFieldInfoPtr_current;
  private static readonly IntPtr NativeFieldInfoPtr_duration;
  private static readonly IntPtr NativeFieldInfoPtr_amount;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetDrawOrder_Public_Static_Void_String_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetColour_Public_Static_Void_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetMaterialAdditive_Public_Static_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Static_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__SetDrawOrder_Private_Void_String_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__Run_Private_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70459, XrefRangeEnd = 70463, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScreenFlashSystem.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70463, XrefRangeEnd = 70470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScreenFlashSystem.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 70475, RefRangeEnd = 70478, XrefRangeStart = 70470, XrefRangeEnd = 70475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetDrawOrder(string sortingLayer, int orderInLayer)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(sortingLayer);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &orderInLayer;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScreenFlashSystem.NativeMethodInfoPtr_SetDrawOrder_Public_Static_Void_String_Int32_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 70480, RefRangeEnd = 70484, XrefRangeStart = 70478, XrefRangeEnd = 70480, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetColour(Color color)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &color
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScreenFlashSystem.NativeMethodInfoPtr_SetColour_Public_Static_Void_Color_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 70488, RefRangeEnd = 70489, XrefRangeStart = 70484, XrefRangeEnd = 70488, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetMaterialAdditive()
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScreenFlashSystem.NativeMethodInfoPtr_SetMaterialAdditive_Public_Static_Void_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 70500, RefRangeEnd = 70503, XrefRangeStart = 70489, XrefRangeEnd = 70500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Run(float duration)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &duration
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScreenFlashSystem.NativeMethodInfoPtr_Run_Public_Static_Void_Single_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70503, XrefRangeEnd = 70506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _SetDrawOrder(string sortingLayer, int orderInLayer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(sortingLayer);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &orderInLayer;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScreenFlashSystem.NativeMethodInfoPtr__SetDrawOrder_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70506, XrefRangeEnd = 70515, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _Run(float duration)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &duration
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScreenFlashSystem.NativeMethodInfoPtr__Run_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70515, XrefRangeEnd = 70516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ScreenFlashSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenFlashSystem>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScreenFlashSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ScreenFlashSystem()
  {
    Il2CppClassPointerStore<ScreenFlashSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ScreenFlashSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenFlashSystem>.NativeClassPtr);
    ScreenFlashSystem.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenFlashSystem>.NativeClassPtr, nameof (instance));
    ScreenFlashSystem.NativeFieldInfoPtr_renderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenFlashSystem>.NativeClassPtr, nameof (renderer));
    ScreenFlashSystem.NativeFieldInfoPtr_curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenFlashSystem>.NativeClassPtr, nameof (curve));
    ScreenFlashSystem.NativeFieldInfoPtr_basicMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenFlashSystem>.NativeClassPtr, nameof (basicMaterial));
    ScreenFlashSystem.NativeFieldInfoPtr_additiveMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenFlashSystem>.NativeClassPtr, nameof (additiveMaterial));
    ScreenFlashSystem.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenFlashSystem>.NativeClassPtr, nameof (color));
    ScreenFlashSystem.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenFlashSystem>.NativeClassPtr, nameof (current));
    ScreenFlashSystem.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenFlashSystem>.NativeClassPtr, nameof (duration));
    ScreenFlashSystem.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenFlashSystem>.NativeClassPtr, nameof (amount));
    ScreenFlashSystem.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenFlashSystem>.NativeClassPtr, 100669048);
    ScreenFlashSystem.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenFlashSystem>.NativeClassPtr, 100669049);
    ScreenFlashSystem.NativeMethodInfoPtr_SetDrawOrder_Public_Static_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenFlashSystem>.NativeClassPtr, 100669050);
    ScreenFlashSystem.NativeMethodInfoPtr_SetColour_Public_Static_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenFlashSystem>.NativeClassPtr, 100669051);
    ScreenFlashSystem.NativeMethodInfoPtr_SetMaterialAdditive_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenFlashSystem>.NativeClassPtr, 100669052);
    ScreenFlashSystem.NativeMethodInfoPtr_Run_Public_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenFlashSystem>.NativeClassPtr, 100669053);
    ScreenFlashSystem.NativeMethodInfoPtr__SetDrawOrder_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenFlashSystem>.NativeClassPtr, 100669054);
    ScreenFlashSystem.NativeMethodInfoPtr__Run_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenFlashSystem>.NativeClassPtr, 100669055);
    ScreenFlashSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenFlashSystem>.NativeClassPtr, 100669056);
  }

  public ScreenFlashSystem(IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe ScreenFlashSystem instance
  {
    get
    {
      IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ScreenFlashSystem.NativeFieldInfoPtr_instance, (void*) &num);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (ScreenFlashSystem) null : new ScreenFlashSystem(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ScreenFlashSystem.NativeFieldInfoPtr_instance, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SpriteRenderer renderer
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenFlashSystem.NativeFieldInfoPtr_renderer));
      return pointer == IntPtr.Zero ? (SpriteRenderer) null : new SpriteRenderer(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScreenFlashSystem.NativeFieldInfoPtr_renderer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve curve
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenFlashSystem.NativeFieldInfoPtr_curve));
      return pointer == IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScreenFlashSystem.NativeFieldInfoPtr_curve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Material basicMaterial
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenFlashSystem.NativeFieldInfoPtr_basicMaterial));
      return pointer == IntPtr.Zero ? (Material) null : new Material(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScreenFlashSystem.NativeFieldInfoPtr_basicMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Material additiveMaterial
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenFlashSystem.NativeFieldInfoPtr_additiveMaterial));
      return pointer == IntPtr.Zero ? (Material) null : new Material(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScreenFlashSystem.NativeFieldInfoPtr_additiveMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Color color
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenFlashSystem.NativeFieldInfoPtr_color));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenFlashSystem.NativeFieldInfoPtr_color)) = value;
    }
  }

  public unsafe float current
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenFlashSystem.NativeFieldInfoPtr_current));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenFlashSystem.NativeFieldInfoPtr_current)) = value;
    }
  }

  public unsafe float duration
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenFlashSystem.NativeFieldInfoPtr_duration));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenFlashSystem.NativeFieldInfoPtr_duration)) = value;
    }
  }

  public unsafe float amount
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenFlashSystem.NativeFieldInfoPtr_amount));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenFlashSystem.NativeFieldInfoPtr_amount)) = value;
    }
  }
}
