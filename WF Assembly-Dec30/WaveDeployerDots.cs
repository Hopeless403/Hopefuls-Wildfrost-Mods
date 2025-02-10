// Decompiled with JetBrains decompiler
// Type: WaveDeployerDots
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
public class WaveDeployerDots : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_fanRadius;
  private static readonly IntPtr NativeFieldInfoPtr_startAngle;
  private static readonly IntPtr NativeFieldInfoPtr_arcMax;
  private static readonly IntPtr NativeFieldInfoPtr_arcGap;
  private static readonly IntPtr NativeFieldInfoPtr_dots;
  private static readonly IntPtr NativeFieldInfoPtr_dotContainer;
  private static readonly IntPtr NativeFieldInfoPtr_dotPrefab;
  private static readonly IntPtr NativeFieldInfoPtr_bigDotPrefab;
  private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_BattleWaveManager_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_UpdateDots_Public_Void_BattleWaveManager_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetPositions_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetPosition_Private_Vector3_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetAngle_Private_Single_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetAngleAdd_Private_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 101256, RefRangeEnd = 101258, XrefRangeStart = 101197, XrefRangeEnd = 101256, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Init(BattleWaveManager waveManager, int currentWaveIndex)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) waveManager);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &currentWaveIndex;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WaveDeployerDots.NativeMethodInfoPtr_Init_Public_Void_BattleWaveManager_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 101267, RefRangeEnd = 101268, XrefRangeStart = 101258, XrefRangeEnd = 101267, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateDots(BattleWaveManager waveManager, int currentWaveIndex)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) waveManager);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &currentWaveIndex;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WaveDeployerDots.NativeMethodInfoPtr_UpdateDots_Public_Void_BattleWaveManager_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 101278, RefRangeEnd = 101279, XrefRangeStart = 101268, XrefRangeEnd = 101278, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetPositions()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WaveDeployerDots.NativeMethodInfoPtr_SetPositions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101279, XrefRangeEnd = 101282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 GetPosition(int index)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &index
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(WaveDeployerDots.NativeMethodInfoPtr_GetPosition_Private_Vector3_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101282, XrefRangeEnd = 101284, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float GetAngle(int index)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &index
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(WaveDeployerDots.NativeMethodInfoPtr_GetAngle_Private_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101284, XrefRangeEnd = 101285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float GetAngleAdd()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(WaveDeployerDots.NativeMethodInfoPtr_GetAngleAdd_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101285, XrefRangeEnd = 101286, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe WaveDeployerDots()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaveDeployerDots>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WaveDeployerDots.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static WaveDeployerDots()
  {
    Il2CppClassPointerStore<WaveDeployerDots>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (WaveDeployerDots));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaveDeployerDots>.NativeClassPtr);
    WaveDeployerDots.NativeFieldInfoPtr_fanRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeployerDots>.NativeClassPtr, nameof (fanRadius));
    WaveDeployerDots.NativeFieldInfoPtr_startAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeployerDots>.NativeClassPtr, nameof (startAngle));
    WaveDeployerDots.NativeFieldInfoPtr_arcMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeployerDots>.NativeClassPtr, nameof (arcMax));
    WaveDeployerDots.NativeFieldInfoPtr_arcGap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeployerDots>.NativeClassPtr, nameof (arcGap));
    WaveDeployerDots.NativeFieldInfoPtr_dots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeployerDots>.NativeClassPtr, nameof (dots));
    WaveDeployerDots.NativeFieldInfoPtr_dotContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeployerDots>.NativeClassPtr, nameof (dotContainer));
    WaveDeployerDots.NativeFieldInfoPtr_dotPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeployerDots>.NativeClassPtr, nameof (dotPrefab));
    WaveDeployerDots.NativeFieldInfoPtr_bigDotPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveDeployerDots>.NativeClassPtr, nameof (bigDotPrefab));
    WaveDeployerDots.NativeMethodInfoPtr_Init_Public_Void_BattleWaveManager_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeployerDots>.NativeClassPtr, 100672365);
    WaveDeployerDots.NativeMethodInfoPtr_UpdateDots_Public_Void_BattleWaveManager_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeployerDots>.NativeClassPtr, 100672366);
    WaveDeployerDots.NativeMethodInfoPtr_SetPositions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeployerDots>.NativeClassPtr, 100672367);
    WaveDeployerDots.NativeMethodInfoPtr_GetPosition_Private_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeployerDots>.NativeClassPtr, 100672368);
    WaveDeployerDots.NativeMethodInfoPtr_GetAngle_Private_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeployerDots>.NativeClassPtr, 100672369);
    WaveDeployerDots.NativeMethodInfoPtr_GetAngleAdd_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeployerDots>.NativeClassPtr, 100672370);
    WaveDeployerDots.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveDeployerDots>.NativeClassPtr, 100672371);
  }

  public WaveDeployerDots(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe float fanRadius
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeployerDots.NativeFieldInfoPtr_fanRadius));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeployerDots.NativeFieldInfoPtr_fanRadius)) = value;
    }
  }

  public unsafe float startAngle
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeployerDots.NativeFieldInfoPtr_startAngle));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeployerDots.NativeFieldInfoPtr_startAngle)) = value;
    }
  }

  public unsafe float arcMax
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeployerDots.NativeFieldInfoPtr_arcMax));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeployerDots.NativeFieldInfoPtr_arcMax)) = value;
    }
  }

  public unsafe float arcGap
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeployerDots.NativeFieldInfoPtr_arcGap));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeployerDots.NativeFieldInfoPtr_arcGap)) = value;
    }
  }

  public unsafe List<WaveDot> dots
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeployerDots.NativeFieldInfoPtr_dots));
      return pointer == IntPtr.Zero ? (List<WaveDot>) null : new List<WaveDot>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WaveDeployerDots.NativeFieldInfoPtr_dots), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform dotContainer
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeployerDots.NativeFieldInfoPtr_dotContainer));
      return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WaveDeployerDots.NativeFieldInfoPtr_dotContainer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe WaveDot dotPrefab
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeployerDots.NativeFieldInfoPtr_dotPrefab));
      return pointer == IntPtr.Zero ? (WaveDot) null : new WaveDot(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WaveDeployerDots.NativeFieldInfoPtr_dotPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe WaveDot bigDotPrefab
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaveDeployerDots.NativeFieldInfoPtr_bigDotPrefab));
      return pointer == IntPtr.Zero ? (WaveDot) null : new WaveDot(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WaveDeployerDots.NativeFieldInfoPtr_bigDotPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
