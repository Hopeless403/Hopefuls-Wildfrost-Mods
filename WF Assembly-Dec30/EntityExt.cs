// Decompiled with JetBrains decompiler
// Type: EntityExt
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
public static class EntityExt : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_GetContainerWorldPosition_Public_Static_Vector3_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetContainerLocalPosition_Public_Static_Vector3_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetContainerWorldRotation_Public_Static_Vector3_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetContainerLocalRotation_Public_Static_Vector3_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetContainerScale_Public_Static_Vector3_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TweenToContainer_Public_Static_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ForceUnHover_Public_Static_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsOffensive_Public_Static_Boolean_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CanRecall_Public_Static_Boolean_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StillExists_Public_Static_Boolean_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsAliveAndExists_Public_Static_Boolean_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HasAnyCharms_Public_Static_Boolean_Entity_0;

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 101599, RefRangeEnd = 101604, XrefRangeStart = 101581, XrefRangeEnd = 101599, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 GetContainerWorldPosition(this Entity entity)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EntityExt.NativeMethodInfoPtr_GetContainerWorldPosition_Public_Static_Vector3_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 101628, RefRangeEnd = 101629, XrefRangeStart = 101604, XrefRangeEnd = 101628, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 GetContainerLocalPosition(this Entity entity)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EntityExt.NativeMethodInfoPtr_GetContainerLocalPosition_Public_Static_Vector3_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 101650, RefRangeEnd = 101651, XrefRangeStart = 101629, XrefRangeEnd = 101650, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 GetContainerWorldRotation(this Entity entity)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EntityExt.NativeMethodInfoPtr_GetContainerWorldRotation_Public_Static_Vector3_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 101668, RefRangeEnd = 101669, XrefRangeStart = 101651, XrefRangeEnd = 101668, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 GetContainerLocalRotation(this Entity entity)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EntityExt.NativeMethodInfoPtr_GetContainerLocalRotation_Public_Static_Vector3_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 101686, RefRangeEnd = 101689, XrefRangeStart = 101669, XrefRangeEnd = 101686, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 GetContainerScale(this Entity entity)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EntityExt.NativeMethodInfoPtr_GetContainerScale_Public_Static_Vector3_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(13)]
  [CachedScanResults(RefRangeStart = 101714, RefRangeEnd = 101727, XrefRangeStart = 101689, XrefRangeEnd = 101714, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void TweenToContainer(this Entity entity)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(EntityExt.NativeMethodInfoPtr_TweenToContainer_Public_Static_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 101731, RefRangeEnd = 101733, XrefRangeStart = 101727, XrefRangeEnd = 101731, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ForceUnHover(this Entity entity)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(EntityExt.NativeMethodInfoPtr_ForceUnHover_Public_Static_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 101773, RefRangeEnd = 101779, XrefRangeStart = 101733, XrefRangeEnd = 101773, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsOffensive(this Entity entity)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EntityExt.NativeMethodInfoPtr_IsOffensive_Public_Static_Boolean_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 101786, RefRangeEnd = 101792, XrefRangeStart = 101779, XrefRangeEnd = 101786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool CanRecall(this Entity entity)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EntityExt.NativeMethodInfoPtr_CanRecall_Public_Static_Boolean_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 101796, RefRangeEnd = 101798, XrefRangeStart = 101792, XrefRangeEnd = 101796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool StillExists(this Entity entity)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EntityExt.NativeMethodInfoPtr_StillExists_Public_Static_Boolean_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(23)]
  [CachedScanResults(RefRangeStart = 101802, RefRangeEnd = 101825, XrefRangeStart = 101798, XrefRangeEnd = 101802, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsAliveAndExists(this Entity entity)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EntityExt.NativeMethodInfoPtr_IsAliveAndExists_Public_Static_Boolean_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 101829, RefRangeEnd = 101830, XrefRangeStart = 101825, XrefRangeEnd = 101829, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool HasAnyCharms(this Entity entity)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EntityExt.NativeMethodInfoPtr_HasAnyCharms_Public_Static_Boolean_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  static EntityExt()
  {
    Il2CppClassPointerStore<EntityExt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (EntityExt));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityExt>.NativeClassPtr);
    EntityExt.NativeMethodInfoPtr_GetContainerWorldPosition_Public_Static_Vector3_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityExt>.NativeClassPtr, 100672410);
    EntityExt.NativeMethodInfoPtr_GetContainerLocalPosition_Public_Static_Vector3_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityExt>.NativeClassPtr, 100672411);
    EntityExt.NativeMethodInfoPtr_GetContainerWorldRotation_Public_Static_Vector3_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityExt>.NativeClassPtr, 100672412);
    EntityExt.NativeMethodInfoPtr_GetContainerLocalRotation_Public_Static_Vector3_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityExt>.NativeClassPtr, 100672413);
    EntityExt.NativeMethodInfoPtr_GetContainerScale_Public_Static_Vector3_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityExt>.NativeClassPtr, 100672414);
    EntityExt.NativeMethodInfoPtr_TweenToContainer_Public_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityExt>.NativeClassPtr, 100672415);
    EntityExt.NativeMethodInfoPtr_ForceUnHover_Public_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityExt>.NativeClassPtr, 100672416);
    EntityExt.NativeMethodInfoPtr_IsOffensive_Public_Static_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityExt>.NativeClassPtr, 100672417);
    EntityExt.NativeMethodInfoPtr_CanRecall_Public_Static_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityExt>.NativeClassPtr, 100672418);
    EntityExt.NativeMethodInfoPtr_StillExists_Public_Static_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityExt>.NativeClassPtr, 100672419);
    EntityExt.NativeMethodInfoPtr_IsAliveAndExists_Public_Static_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityExt>.NativeClassPtr, 100672420);
    EntityExt.NativeMethodInfoPtr_HasAnyCharms_Public_Static_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityExt>.NativeClassPtr, 100672421);
  }

  public EntityExt(System.IntPtr pointer)
    : base(pointer)
  {
  }

  [ObfuscatedName("EntityExt/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__7_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__7_1;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__11_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__IsOffensive_b__7_0_Internal_Boolean_StatusEffectStacks_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__IsOffensive_b__7_1_Internal_Boolean_StatusEffectData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__HasAnyCharms_b__11_0_Internal_Boolean_CardUpgradeData_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityExt.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EntityExt.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _IsOffensive_b__7_0(CardData.StatusEffectStacks s)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) s)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EntityExt.__c.NativeMethodInfoPtr__IsOffensive_b__7_0_Internal_Boolean_StatusEffectStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe bool _IsOffensive_b__7_1(StatusEffectData s)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) s)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EntityExt.__c.NativeMethodInfoPtr__IsOffensive_b__7_1_Internal_Boolean_StatusEffectData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe bool _HasAnyCharms_b__11_0(CardUpgradeData a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EntityExt.__c.NativeMethodInfoPtr__HasAnyCharms_b__11_0_Internal_Boolean_CardUpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<EntityExt.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EntityExt>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityExt.__c>.NativeClassPtr);
      EntityExt.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityExt.__c>.NativeClassPtr, "<>9");
      EntityExt.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityExt.__c>.NativeClassPtr, "<>9__7_0");
      EntityExt.__c.NativeFieldInfoPtr___9__7_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityExt.__c>.NativeClassPtr, "<>9__7_1");
      EntityExt.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityExt.__c>.NativeClassPtr, "<>9__11_0");
      EntityExt.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityExt.__c>.NativeClassPtr, 100672423);
      EntityExt.__c.NativeMethodInfoPtr__IsOffensive_b__7_0_Internal_Boolean_StatusEffectStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityExt.__c>.NativeClassPtr, 100672424);
      EntityExt.__c.NativeMethodInfoPtr__IsOffensive_b__7_1_Internal_Boolean_StatusEffectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityExt.__c>.NativeClassPtr, 100672425);
      EntityExt.__c.NativeMethodInfoPtr__HasAnyCharms_b__11_0_Internal_Boolean_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityExt.__c>.NativeClassPtr, 100672426);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe EntityExt.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(EntityExt.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (EntityExt.__c) null : new EntityExt.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EntityExt.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CardData.StatusEffectStacks, bool> __9__7_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(EntityExt.__c.NativeFieldInfoPtr___9__7_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardData.StatusEffectStacks, bool>) null : new Il2CppSystem.Func<CardData.StatusEffectStacks, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EntityExt.__c.NativeFieldInfoPtr___9__7_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<StatusEffectData, bool> __9__7_1
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(EntityExt.__c.NativeFieldInfoPtr___9__7_1, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<StatusEffectData, bool>) null : new Il2CppSystem.Func<StatusEffectData, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EntityExt.__c.NativeFieldInfoPtr___9__7_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CardUpgradeData, bool> __9__11_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(EntityExt.__c.NativeFieldInfoPtr___9__11_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardUpgradeData, bool>) null : new Il2CppSystem.Func<CardUpgradeData, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EntityExt.__c.NativeFieldInfoPtr___9__11_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
