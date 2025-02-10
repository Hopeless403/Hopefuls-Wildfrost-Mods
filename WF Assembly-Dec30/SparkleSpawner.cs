// Decompiled with JetBrains decompiler
// Type: SparkleSpawner
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
public class SparkleSpawner : MonoBehaviourRect
{
  private static readonly IntPtr NativeFieldInfoPtr_sparkleCount;
  private static readonly IntPtr NativeFieldInfoPtr_sparkleSprite;
  private static readonly IntPtr NativeFieldInfoPtr_pool;
  private static readonly IntPtr NativeFieldInfoPtr_activeSparkles;
  private static readonly IntPtr NativeFieldInfoPtr_sizeRange;
  private static readonly IntPtr NativeFieldInfoPtr_colour;
  private static readonly IntPtr NativeFieldInfoPtr_spawnTimeRange;
  private static readonly IntPtr NativeFieldInfoPtr_timer;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_NewSparkle_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95147, XrefRangeEnd = 95171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SparkleSpawner.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 95221, RefRangeEnd = 95222, XrefRangeStart = 95171, XrefRangeEnd = 95221, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void NewSparkle()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SparkleSpawner.NativeMethodInfoPtr_NewSparkle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95222, XrefRangeEnd = 95238, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SparkleSpawner()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SparkleSpawner>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SparkleSpawner.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static SparkleSpawner()
  {
    Il2CppClassPointerStore<SparkleSpawner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (SparkleSpawner));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SparkleSpawner>.NativeClassPtr);
    SparkleSpawner.NativeFieldInfoPtr_sparkleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SparkleSpawner>.NativeClassPtr, nameof (sparkleCount));
    SparkleSpawner.NativeFieldInfoPtr_sparkleSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SparkleSpawner>.NativeClassPtr, nameof (sparkleSprite));
    SparkleSpawner.NativeFieldInfoPtr_pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SparkleSpawner>.NativeClassPtr, nameof (pool));
    SparkleSpawner.NativeFieldInfoPtr_activeSparkles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SparkleSpawner>.NativeClassPtr, nameof (activeSparkles));
    SparkleSpawner.NativeFieldInfoPtr_sizeRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SparkleSpawner>.NativeClassPtr, nameof (sizeRange));
    SparkleSpawner.NativeFieldInfoPtr_colour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SparkleSpawner>.NativeClassPtr, nameof (colour));
    SparkleSpawner.NativeFieldInfoPtr_spawnTimeRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SparkleSpawner>.NativeClassPtr, nameof (spawnTimeRange));
    SparkleSpawner.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SparkleSpawner>.NativeClassPtr, nameof (timer));
    SparkleSpawner.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparkleSpawner>.NativeClassPtr, 100671576);
    SparkleSpawner.NativeMethodInfoPtr_NewSparkle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparkleSpawner>.NativeClassPtr, 100671577);
    SparkleSpawner.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparkleSpawner>.NativeClassPtr, 100671578);
  }

  public SparkleSpawner(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe int sparkleCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SparkleSpawner.NativeFieldInfoPtr_sparkleCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SparkleSpawner.NativeFieldInfoPtr_sparkleCount)) = value;
    }
  }

  public unsafe Sprite sparkleSprite
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SparkleSpawner.NativeFieldInfoPtr_sparkleSprite));
      return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SparkleSpawner.NativeFieldInfoPtr_sparkleSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Queue<Sparkle> pool
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SparkleSpawner.NativeFieldInfoPtr_pool));
      return pointer == IntPtr.Zero ? (Queue<Sparkle>) null : new Queue<Sparkle>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SparkleSpawner.NativeFieldInfoPtr_pool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<Transform> activeSparkles
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SparkleSpawner.NativeFieldInfoPtr_activeSparkles));
      return pointer == IntPtr.Zero ? (List<Transform>) null : new List<Transform>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SparkleSpawner.NativeFieldInfoPtr_activeSparkles), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector2 sizeRange
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SparkleSpawner.NativeFieldInfoPtr_sizeRange));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SparkleSpawner.NativeFieldInfoPtr_sizeRange)) = value;
    }
  }

  public unsafe Color colour
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SparkleSpawner.NativeFieldInfoPtr_colour));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SparkleSpawner.NativeFieldInfoPtr_colour)) = value;
    }
  }

  public unsafe Vector2 spawnTimeRange
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SparkleSpawner.NativeFieldInfoPtr_spawnTimeRange));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SparkleSpawner.NativeFieldInfoPtr_spawnTimeRange)) = value;
    }
  }

  public unsafe float timer
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SparkleSpawner.NativeFieldInfoPtr_timer));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SparkleSpawner.NativeFieldInfoPtr_timer)) = value;
    }
  }
}
