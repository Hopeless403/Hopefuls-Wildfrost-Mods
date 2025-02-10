// Decompiled with JetBrains decompiler
// Type: HandleSpinner
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
public class HandleSpinner : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_handle;
  private static readonly IntPtr NativeFieldInfoPtr_startSpeed;
  private static readonly IntPtr NativeFieldInfoPtr_targetSpeed;
  private static readonly IntPtr NativeFieldInfoPtr_acceleration;
  private static readonly IntPtr NativeFieldInfoPtr_deceleration;
  private static readonly IntPtr NativeFieldInfoPtr_spinning;
  private static readonly IntPtr NativeFieldInfoPtr_speed;
  private static readonly IntPtr NativeMethodInfoPtr_Spin_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50771, XrefRangeEnd = 50772, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Spin()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HandleSpinner.NativeMethodInfoPtr_Spin_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 50772, RefRangeEnd = 50776, XrefRangeStart = 50772, XrefRangeEnd = 50772, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Stop()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HandleSpinner.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50776, XrefRangeEnd = 50781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HandleSpinner.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50781, XrefRangeEnd = 50782, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe HandleSpinner()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HandleSpinner>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HandleSpinner.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static HandleSpinner()
  {
    Il2CppClassPointerStore<HandleSpinner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (HandleSpinner));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandleSpinner>.NativeClassPtr);
    HandleSpinner.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleSpinner>.NativeClassPtr, nameof (handle));
    HandleSpinner.NativeFieldInfoPtr_startSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleSpinner>.NativeClassPtr, nameof (startSpeed));
    HandleSpinner.NativeFieldInfoPtr_targetSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleSpinner>.NativeClassPtr, nameof (targetSpeed));
    HandleSpinner.NativeFieldInfoPtr_acceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleSpinner>.NativeClassPtr, nameof (acceleration));
    HandleSpinner.NativeFieldInfoPtr_deceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleSpinner>.NativeClassPtr, nameof (deceleration));
    HandleSpinner.NativeFieldInfoPtr_spinning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleSpinner>.NativeClassPtr, nameof (spinning));
    HandleSpinner.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleSpinner>.NativeClassPtr, nameof (speed));
    HandleSpinner.NativeMethodInfoPtr_Spin_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleSpinner>.NativeClassPtr, 100667350);
    HandleSpinner.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleSpinner>.NativeClassPtr, 100667351);
    HandleSpinner.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleSpinner>.NativeClassPtr, 100667352);
    HandleSpinner.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleSpinner>.NativeClassPtr, 100667353);
  }

  public HandleSpinner(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Transform handle
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleSpinner.NativeFieldInfoPtr_handle));
      return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HandleSpinner.NativeFieldInfoPtr_handle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float startSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleSpinner.NativeFieldInfoPtr_startSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleSpinner.NativeFieldInfoPtr_startSpeed)) = value;
    }
  }

  public unsafe float targetSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleSpinner.NativeFieldInfoPtr_targetSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleSpinner.NativeFieldInfoPtr_targetSpeed)) = value;
    }
  }

  public unsafe float acceleration
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleSpinner.NativeFieldInfoPtr_acceleration));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleSpinner.NativeFieldInfoPtr_acceleration)) = value;
    }
  }

  public unsafe float deceleration
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleSpinner.NativeFieldInfoPtr_deceleration));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleSpinner.NativeFieldInfoPtr_deceleration)) = value;
    }
  }

  public unsafe bool spinning
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleSpinner.NativeFieldInfoPtr_spinning));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleSpinner.NativeFieldInfoPtr_spinning)) = value;
    }
  }

  public unsafe float speed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleSpinner.NativeFieldInfoPtr_speed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleSpinner.NativeFieldInfoPtr_speed)) = value;
    }
  }
}
