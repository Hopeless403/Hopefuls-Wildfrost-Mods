// Decompiled with JetBrains decompiler
// Type: FrostEyeSystem
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
using UnityEngine.AddressableAssets;

#nullable disable
public class FrostEyeSystem : GameSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_frostEyePrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_frostEyePrefabRef;
  private static readonly System.IntPtr NativeFieldInfoPtr_toProcess;
  private static readonly System.IntPtr NativeFieldInfoPtr_toRemove;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityCreated_Private_Static_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityDataUpdated_Private_Static_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CardPooled_Private_Static_Void_Card_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60049, XrefRangeEnd = 60096, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FrostEyeSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60096, XrefRangeEnd = 60117, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FrostEyeSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60117, XrefRangeEnd = 60134, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void EntityCreated(Entity entity)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FrostEyeSystem.NativeMethodInfoPtr_EntityCreated_Private_Static_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60134, XrefRangeEnd = 60148, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void EntityDataUpdated(Entity entity)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FrostEyeSystem.NativeMethodInfoPtr_EntityDataUpdated_Private_Static_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 60248, RefRangeEnd = 60250, XrefRangeStart = 60148, XrefRangeEnd = 60248, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Create(Entity entity)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FrostEyeSystem.NativeMethodInfoPtr_Create_Public_Static_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60250, XrefRangeEnd = 60302, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CardPooled(Card card)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) card)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FrostEyeSystem.NativeMethodInfoPtr_CardPooled_Private_Static_Void_Card_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FrostEyeSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FrostEyeSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FrostEyeSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static FrostEyeSystem()
  {
    Il2CppClassPointerStore<FrostEyeSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (FrostEyeSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FrostEyeSystem>.NativeClassPtr);
    FrostEyeSystem.NativeFieldInfoPtr_frostEyePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrostEyeSystem>.NativeClassPtr, nameof (frostEyePrefab));
    FrostEyeSystem.NativeFieldInfoPtr_frostEyePrefabRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrostEyeSystem>.NativeClassPtr, nameof (frostEyePrefabRef));
    FrostEyeSystem.NativeFieldInfoPtr_toProcess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrostEyeSystem>.NativeClassPtr, nameof (toProcess));
    FrostEyeSystem.NativeFieldInfoPtr_toRemove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrostEyeSystem>.NativeClassPtr, nameof (toRemove));
    FrostEyeSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrostEyeSystem>.NativeClassPtr, 100668209);
    FrostEyeSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrostEyeSystem>.NativeClassPtr, 100668210);
    FrostEyeSystem.NativeMethodInfoPtr_EntityCreated_Private_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrostEyeSystem>.NativeClassPtr, 100668211);
    FrostEyeSystem.NativeMethodInfoPtr_EntityDataUpdated_Private_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrostEyeSystem>.NativeClassPtr, 100668212);
    FrostEyeSystem.NativeMethodInfoPtr_Create_Public_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrostEyeSystem>.NativeClassPtr, 100668213);
    FrostEyeSystem.NativeMethodInfoPtr_CardPooled_Private_Static_Void_Card_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrostEyeSystem>.NativeClassPtr, 100668214);
    FrostEyeSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrostEyeSystem>.NativeClassPtr, 100668215);
  }

  public FrostEyeSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe AssetReference frostEyePrefab
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrostEyeSystem.NativeFieldInfoPtr_frostEyePrefab));
      return pointer == System.IntPtr.Zero ? (AssetReference) null : new AssetReference(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FrostEyeSystem.NativeFieldInfoPtr_frostEyePrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe AssetReference frostEyePrefabRef
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(FrostEyeSystem.NativeFieldInfoPtr_frostEyePrefabRef, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (AssetReference) null : new AssetReference(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FrostEyeSystem.NativeFieldInfoPtr_frostEyePrefabRef, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe List<Entity> toProcess
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(FrostEyeSystem.NativeFieldInfoPtr_toProcess, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (List<Entity>) null : new List<Entity>(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FrostEyeSystem.NativeFieldInfoPtr_toProcess, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Dictionary<Card, List<GameObject>> toRemove
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(FrostEyeSystem.NativeFieldInfoPtr_toRemove, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Dictionary<Card, List<GameObject>>) null : new Dictionary<Card, List<GameObject>>(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FrostEyeSystem.NativeFieldInfoPtr_toRemove, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("FrostEyeSystem/<>c__DisplayClass8_0")]
  public sealed class __c__DisplayClass8_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_entity;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Create_b__0_Internal_Boolean_EyeData_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass8_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FrostEyeSystem.__c__DisplayClass8_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FrostEyeSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _Create_b__0(EyeData a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FrostEyeSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__Create_b__0_Internal_Boolean_EyeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass8_0()
    {
      Il2CppClassPointerStore<FrostEyeSystem.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FrostEyeSystem>.NativeClassPtr, "<>c__DisplayClass8_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FrostEyeSystem.__c__DisplayClass8_0>.NativeClassPtr);
      FrostEyeSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrostEyeSystem.__c__DisplayClass8_0>.NativeClassPtr, nameof (entity));
      FrostEyeSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrostEyeSystem.__c__DisplayClass8_0>.NativeClassPtr, 100668217);
      FrostEyeSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__Create_b__0_Internal_Boolean_EyeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrostEyeSystem.__c__DisplayClass8_0>.NativeClassPtr, 100668218);
    }

    public __c__DisplayClass8_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Entity entity
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrostEyeSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_entity));
        return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FrostEyeSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("FrostEyeSystem/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__8_1;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Create_b__8_1_Internal_Boolean_Transform_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FrostEyeSystem.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FrostEyeSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60046, XrefRangeEnd = 60049, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _Create_b__8_1(Transform a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FrostEyeSystem.__c.NativeMethodInfoPtr__Create_b__8_1_Internal_Boolean_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<FrostEyeSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FrostEyeSystem>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FrostEyeSystem.__c>.NativeClassPtr);
      FrostEyeSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrostEyeSystem.__c>.NativeClassPtr, "<>9");
      FrostEyeSystem.__c.NativeFieldInfoPtr___9__8_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrostEyeSystem.__c>.NativeClassPtr, "<>9__8_1");
      FrostEyeSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrostEyeSystem.__c>.NativeClassPtr, 100668220);
      FrostEyeSystem.__c.NativeMethodInfoPtr__Create_b__8_1_Internal_Boolean_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrostEyeSystem.__c>.NativeClassPtr, 100668221);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe FrostEyeSystem.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(FrostEyeSystem.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (FrostEyeSystem.__c) null : new FrostEyeSystem.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FrostEyeSystem.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<Transform, bool> __9__8_1
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(FrostEyeSystem.__c.NativeFieldInfoPtr___9__8_1, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Transform, bool>) null : new Il2CppSystem.Func<Transform, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FrostEyeSystem.__c.NativeFieldInfoPtr___9__8_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
