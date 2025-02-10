// Decompiled with JetBrains decompiler
// Type: SplatterPersistenceSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class SplatterPersistenceSystem : GameSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_teamsToSave;
  private static readonly System.IntPtr NativeFieldInfoPtr_basicSplatterPrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_savedCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_saveRequired;
  private static readonly System.IntPtr NativeFieldInfoPtr_storedSplatters;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityCreated_Private_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityDestroyed_Private_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckSave_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Load_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75006, XrefRangeEnd = 75039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SplatterPersistenceSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75039, XrefRangeEnd = 75072, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SplatterPersistenceSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75072, XrefRangeEnd = 75110, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityCreated(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SplatterPersistenceSystem.NativeMethodInfoPtr_EntityCreated_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75110, XrefRangeEnd = 75201, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityDestroyed(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SplatterPersistenceSystem.NativeMethodInfoPtr_EntityDestroyed_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75201, XrefRangeEnd = 75211, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CheckSave()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SplatterPersistenceSystem.NativeMethodInfoPtr_CheckSave_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75211, XrefRangeEnd = 75222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Load()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SplatterPersistenceSystem.NativeMethodInfoPtr_Load_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75222, XrefRangeEnd = 75223, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Clear()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SplatterPersistenceSystem.NativeMethodInfoPtr_Clear_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SplatterPersistenceSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SplatterPersistenceSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SplatterPersistenceSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static SplatterPersistenceSystem()
  {
    Il2CppClassPointerStore<SplatterPersistenceSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (SplatterPersistenceSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SplatterPersistenceSystem>.NativeClassPtr);
    SplatterPersistenceSystem.NativeFieldInfoPtr_teamsToSave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplatterPersistenceSystem>.NativeClassPtr, nameof (teamsToSave));
    SplatterPersistenceSystem.NativeFieldInfoPtr_basicSplatterPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplatterPersistenceSystem>.NativeClassPtr, nameof (basicSplatterPrefab));
    SplatterPersistenceSystem.NativeFieldInfoPtr_savedCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplatterPersistenceSystem>.NativeClassPtr, nameof (savedCount));
    SplatterPersistenceSystem.NativeFieldInfoPtr_saveRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplatterPersistenceSystem>.NativeClassPtr, nameof (saveRequired));
    SplatterPersistenceSystem.NativeFieldInfoPtr_storedSplatters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplatterPersistenceSystem>.NativeClassPtr, nameof (storedSplatters));
    SplatterPersistenceSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplatterPersistenceSystem>.NativeClassPtr, 100669363);
    SplatterPersistenceSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplatterPersistenceSystem>.NativeClassPtr, 100669364);
    SplatterPersistenceSystem.NativeMethodInfoPtr_EntityCreated_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplatterPersistenceSystem>.NativeClassPtr, 100669365);
    SplatterPersistenceSystem.NativeMethodInfoPtr_EntityDestroyed_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplatterPersistenceSystem>.NativeClassPtr, 100669366);
    SplatterPersistenceSystem.NativeMethodInfoPtr_CheckSave_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplatterPersistenceSystem>.NativeClassPtr, 100669367);
    SplatterPersistenceSystem.NativeMethodInfoPtr_Load_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplatterPersistenceSystem>.NativeClassPtr, 100669368);
    SplatterPersistenceSystem.NativeMethodInfoPtr_Clear_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplatterPersistenceSystem>.NativeClassPtr, 100669369);
    SplatterPersistenceSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplatterPersistenceSystem>.NativeClassPtr, 100669370);
  }

  public SplatterPersistenceSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppStructArray<int> teamsToSave
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterPersistenceSystem.NativeFieldInfoPtr_teamsToSave));
      return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<int>) null : new Il2CppStructArray<int>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SplatterPersistenceSystem.NativeFieldInfoPtr_teamsToSave), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Splatter basicSplatterPrefab
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterPersistenceSystem.NativeFieldInfoPtr_basicSplatterPrefab));
      return pointer == System.IntPtr.Zero ? (Splatter) null : new Splatter(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SplatterPersistenceSystem.NativeFieldInfoPtr_basicSplatterPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int savedCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterPersistenceSystem.NativeFieldInfoPtr_savedCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterPersistenceSystem.NativeFieldInfoPtr_savedCount)) = value;
    }
  }

  public unsafe bool saveRequired
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterPersistenceSystem.NativeFieldInfoPtr_saveRequired));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterPersistenceSystem.NativeFieldInfoPtr_saveRequired)) = value;
    }
  }

  public unsafe Dictionary<ulong, Il2CppReferenceArray<SplatterPersistenceSystem.SplatterData>> storedSplatters
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterPersistenceSystem.NativeFieldInfoPtr_storedSplatters));
      return pointer == System.IntPtr.Zero ? (Dictionary<ulong, Il2CppReferenceArray<SplatterPersistenceSystem.SplatterData>>) null : new Dictionary<ulong, Il2CppReferenceArray<SplatterPersistenceSystem.SplatterData>>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SplatterPersistenceSystem.NativeFieldInfoPtr_storedSplatters), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class SplatterData : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_sprite;
    private static readonly System.IntPtr NativeFieldInfoPtr_color;
    private static readonly System.IntPtr NativeFieldInfoPtr_offset;
    private static readonly System.IntPtr NativeFieldInfoPtr_scale;
    private static readonly System.IntPtr NativeFieldInfoPtr_angle;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Splatter_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SplatterData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SplatterPersistenceSystem.SplatterData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SplatterPersistenceSystem.SplatterData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74991, XrefRangeEnd = 74997, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SplatterData(Splatter splatter)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SplatterPersistenceSystem.SplatterData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) splatter)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SplatterPersistenceSystem.SplatterData.NativeMethodInfoPtr__ctor_Public_Void_Splatter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SplatterData()
    {
      Il2CppClassPointerStore<SplatterPersistenceSystem.SplatterData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SplatterPersistenceSystem>.NativeClassPtr, nameof (SplatterData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SplatterPersistenceSystem.SplatterData>.NativeClassPtr);
      SplatterPersistenceSystem.SplatterData.NativeFieldInfoPtr_sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplatterPersistenceSystem.SplatterData>.NativeClassPtr, nameof (sprite));
      SplatterPersistenceSystem.SplatterData.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplatterPersistenceSystem.SplatterData>.NativeClassPtr, nameof (color));
      SplatterPersistenceSystem.SplatterData.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplatterPersistenceSystem.SplatterData>.NativeClassPtr, nameof (offset));
      SplatterPersistenceSystem.SplatterData.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplatterPersistenceSystem.SplatterData>.NativeClassPtr, nameof (scale));
      SplatterPersistenceSystem.SplatterData.NativeFieldInfoPtr_angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplatterPersistenceSystem.SplatterData>.NativeClassPtr, nameof (angle));
      SplatterPersistenceSystem.SplatterData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplatterPersistenceSystem.SplatterData>.NativeClassPtr, 100669371);
      SplatterPersistenceSystem.SplatterData.NativeMethodInfoPtr__ctor_Public_Void_Splatter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplatterPersistenceSystem.SplatterData>.NativeClassPtr, 100669372);
    }

    public SplatterData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Sprite sprite
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterPersistenceSystem.SplatterData.NativeFieldInfoPtr_sprite));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SplatterPersistenceSystem.SplatterData.NativeFieldInfoPtr_sprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Color color
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterPersistenceSystem.SplatterData.NativeFieldInfoPtr_color));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterPersistenceSystem.SplatterData.NativeFieldInfoPtr_color)) = value;
      }
    }

    public unsafe Vector3 offset
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterPersistenceSystem.SplatterData.NativeFieldInfoPtr_offset));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterPersistenceSystem.SplatterData.NativeFieldInfoPtr_offset)) = value;
      }
    }

    public unsafe Vector3 scale
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterPersistenceSystem.SplatterData.NativeFieldInfoPtr_scale));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterPersistenceSystem.SplatterData.NativeFieldInfoPtr_scale)) = value;
      }
    }

    public unsafe float angle
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterPersistenceSystem.SplatterData.NativeFieldInfoPtr_angle));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplatterPersistenceSystem.SplatterData.NativeFieldInfoPtr_angle)) = value;
      }
    }
  }

  [ObfuscatedName("SplatterPersistenceSystem/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__8_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__EntityDestroyed_b__8_0_Internal_SplatterData_Splatter_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SplatterPersistenceSystem.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SplatterPersistenceSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74997, XrefRangeEnd = 75006, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SplatterPersistenceSystem.SplatterData _EntityDestroyed_b__8_0(Splatter splatter)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) splatter)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SplatterPersistenceSystem.__c.NativeMethodInfoPtr__EntityDestroyed_b__8_0_Internal_SplatterData_Splatter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (SplatterPersistenceSystem.SplatterData) null : new SplatterPersistenceSystem.SplatterData(pointer);
    }

    static __c()
    {
      Il2CppClassPointerStore<SplatterPersistenceSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SplatterPersistenceSystem>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SplatterPersistenceSystem.__c>.NativeClassPtr);
      SplatterPersistenceSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplatterPersistenceSystem.__c>.NativeClassPtr, "<>9");
      SplatterPersistenceSystem.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplatterPersistenceSystem.__c>.NativeClassPtr, "<>9__8_0");
      SplatterPersistenceSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplatterPersistenceSystem.__c>.NativeClassPtr, 100669374);
      SplatterPersistenceSystem.__c.NativeMethodInfoPtr__EntityDestroyed_b__8_0_Internal_SplatterData_Splatter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplatterPersistenceSystem.__c>.NativeClassPtr, 100669375);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe SplatterPersistenceSystem.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(SplatterPersistenceSystem.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (SplatterPersistenceSystem.__c) null : new SplatterPersistenceSystem.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SplatterPersistenceSystem.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<Splatter, SplatterPersistenceSystem.SplatterData> __9__8_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(SplatterPersistenceSystem.__c.NativeFieldInfoPtr___9__8_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Splatter, SplatterPersistenceSystem.SplatterData>) null : new Il2CppSystem.Func<Splatter, SplatterPersistenceSystem.SplatterData>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SplatterPersistenceSystem.__c.NativeFieldInfoPtr___9__8_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
