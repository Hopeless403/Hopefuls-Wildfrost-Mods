// Decompiled with JetBrains decompiler
// Type: TargetModeCrowns
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class TargetModeCrowns : TargetMode
{
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPotentialTargets_Public_Virtual_Il2CppReferenceArray_1_Entity_Entity_Entity_CardContainer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSubsequentTargets_Public_Virtual_Il2CppReferenceArray_1_Entity_Entity_Entity_CardContainer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24577, XrefRangeEnd = 24609, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Il2CppReferenceArray<Entity> GetPotentialTargets(
    Entity entity,
    Entity target,
    CardContainer targetContainer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targetContainer);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TargetModeCrowns.NativeMethodInfoPtr_GetPotentialTargets_Public_Virtual_Il2CppReferenceArray_1_Entity_Entity_Entity_CardContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr nativeObject = num;
    return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Entity>) null : new Il2CppReferenceArray<Entity>(nativeObject);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 24609, RefRangeEnd = 24612, XrefRangeStart = 24609, XrefRangeEnd = 24609, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Il2CppReferenceArray<Entity> GetSubsequentTargets(
    Entity entity,
    Entity target,
    CardContainer targetContainer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targetContainer);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TargetModeCrowns.NativeMethodInfoPtr_GetSubsequentTargets_Public_Virtual_Il2CppReferenceArray_1_Entity_Entity_Entity_CardContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr nativeObject = num;
    return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Entity>) null : new Il2CppReferenceArray<Entity>(nativeObject);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TargetModeCrowns()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetModeCrowns>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TargetModeCrowns.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static TargetModeCrowns()
  {
    Il2CppClassPointerStore<TargetModeCrowns>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (TargetModeCrowns));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetModeCrowns>.NativeClassPtr);
    TargetModeCrowns.NativeMethodInfoPtr_GetPotentialTargets_Public_Virtual_Il2CppReferenceArray_1_Entity_Entity_Entity_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetModeCrowns>.NativeClassPtr, 100664357);
    TargetModeCrowns.NativeMethodInfoPtr_GetSubsequentTargets_Public_Virtual_Il2CppReferenceArray_1_Entity_Entity_Entity_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetModeCrowns>.NativeClassPtr, 100664358);
    TargetModeCrowns.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetModeCrowns>.NativeClassPtr, 100664359);
  }

  public TargetModeCrowns(System.IntPtr pointer)
    : base(pointer)
  {
  }

  [ObfuscatedName("TargetModeCrowns/<>c")]
  [Serializable]
  public new sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__0_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetPotentialTargets_b__0_0_Internal_Boolean_Entity_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetModeCrowns.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TargetModeCrowns.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24570, XrefRangeEnd = 24577, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GetPotentialTargets_b__0_0(Entity e)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) e)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TargetModeCrowns.__c.NativeMethodInfoPtr__GetPotentialTargets_b__0_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<TargetModeCrowns.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TargetModeCrowns>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetModeCrowns.__c>.NativeClassPtr);
      TargetModeCrowns.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetModeCrowns.__c>.NativeClassPtr, "<>9");
      TargetModeCrowns.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetModeCrowns.__c>.NativeClassPtr, "<>9__0_0");
      TargetModeCrowns.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetModeCrowns.__c>.NativeClassPtr, 100664361);
      TargetModeCrowns.__c.NativeMethodInfoPtr__GetPotentialTargets_b__0_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetModeCrowns.__c>.NativeClassPtr, 100664362);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe TargetModeCrowns.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(TargetModeCrowns.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (TargetModeCrowns.__c) null : new TargetModeCrowns.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TargetModeCrowns.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<Entity, bool> __9__0_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(TargetModeCrowns.__c.NativeFieldInfoPtr___9__0_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Entity, bool>) null : new Il2CppSystem.Func<Entity, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TargetModeCrowns.__c.NativeFieldInfoPtr___9__0_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
