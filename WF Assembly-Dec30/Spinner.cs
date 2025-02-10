// Decompiled with JetBrains decompiler
// Type: Spinner
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
public class Spinner : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_ignoreTimeScale;
  private static readonly IntPtr NativeFieldInfoPtr_speed;
  private static readonly IntPtr NativeFieldInfoPtr_setTargetSpeed;
  private static readonly IntPtr NativeFieldInfoPtr_targetSpeed;
  private static readonly IntPtr NativeFieldInfoPtr_targetSpeedAcc;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54153, XrefRangeEnd = 54167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Spinner.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54167, XrefRangeEnd = 54168, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Spinner()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spinner>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Spinner.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static Spinner()
  {
    Il2CppClassPointerStore<Spinner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (Spinner));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spinner>.NativeClassPtr);
    Spinner.NativeFieldInfoPtr_ignoreTimeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spinner>.NativeClassPtr, nameof (ignoreTimeScale));
    Spinner.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spinner>.NativeClassPtr, nameof (speed));
    Spinner.NativeFieldInfoPtr_setTargetSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spinner>.NativeClassPtr, nameof (setTargetSpeed));
    Spinner.NativeFieldInfoPtr_targetSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spinner>.NativeClassPtr, nameof (targetSpeed));
    Spinner.NativeFieldInfoPtr_targetSpeedAcc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spinner>.NativeClassPtr, nameof (targetSpeedAcc));
    Spinner.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spinner>.NativeClassPtr, 100667737);
    Spinner.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spinner>.NativeClassPtr, 100667738);
  }

  public Spinner(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool ignoreTimeScale
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Spinner.NativeFieldInfoPtr_ignoreTimeScale));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Spinner.NativeFieldInfoPtr_ignoreTimeScale)) = value;
    }
  }

  public unsafe Vector3 speed
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Spinner.NativeFieldInfoPtr_speed));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Spinner.NativeFieldInfoPtr_speed)) = value;
    }
  }

  public unsafe bool setTargetSpeed
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Spinner.NativeFieldInfoPtr_setTargetSpeed));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Spinner.NativeFieldInfoPtr_setTargetSpeed)) = value;
    }
  }

  public unsafe Vector3 targetSpeed
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Spinner.NativeFieldInfoPtr_targetSpeed));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Spinner.NativeFieldInfoPtr_targetSpeed)) = value;
    }
  }

  public unsafe float targetSpeedAcc
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Spinner.NativeFieldInfoPtr_targetSpeedAcc));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Spinner.NativeFieldInfoPtr_targetSpeedAcc)) = value;
    }
  }
}
