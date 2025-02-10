// Decompiled with JetBrains decompiler
// Type: CounterImminentDisplaySystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class CounterImminentDisplaySystem : GameSystem
{
  private static readonly IntPtr NativeFieldInfoPtr_disableCardAnimationHover;
  private static readonly IntPtr NativeFieldInfoPtr_disableIconAnimationHover;
  private static readonly IntPtr NativeFieldInfoPtr_currentImminent;
  private static readonly IntPtr NativeFieldInfoPtr_currentHover;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_EntityHover_Private_Void_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_EntityUnHover_Private_Void_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_EntityDisabled_Private_Void_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetCardAnimation_Private_Void_Entity_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetCounterIconAnimation_Private_Void_Entity_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_EntityCheck_Private_Void_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_Imminent_Private_Boolean_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58650, XrefRangeEnd = 58691, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CounterImminentDisplaySystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58691, XrefRangeEnd = 58732, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CounterImminentDisplaySystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58732, XrefRangeEnd = 58748, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityHover(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CounterImminentDisplaySystem.NativeMethodInfoPtr_EntityHover_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58748, XrefRangeEnd = 58765, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityUnHover(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CounterImminentDisplaySystem.NativeMethodInfoPtr_EntityUnHover_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58765, XrefRangeEnd = 58777, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityDisabled(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CounterImminentDisplaySystem.NativeMethodInfoPtr_EntityDisabled_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58777, XrefRangeEnd = 58782, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetCardAnimation(Entity entity, bool enable)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &enable;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CounterImminentDisplaySystem.NativeMethodInfoPtr_SetCardAnimation_Private_Void_Entity_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 58792, RefRangeEnd = 58796, XrefRangeStart = 58782, XrefRangeEnd = 58792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetCounterIconAnimation(Entity entity, bool enable)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &enable;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CounterImminentDisplaySystem.NativeMethodInfoPtr_SetCounterIconAnimation_Private_Void_Entity_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58796, XrefRangeEnd = 58812, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityCheck(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CounterImminentDisplaySystem.NativeMethodInfoPtr_EntityCheck_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58812, XrefRangeEnd = 58813, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool Imminent(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(CounterImminentDisplaySystem.NativeMethodInfoPtr_Imminent_Private_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58813, XrefRangeEnd = 58827, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CounterImminentDisplaySystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CounterImminentDisplaySystem>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CounterImminentDisplaySystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CounterImminentDisplaySystem()
  {
    Il2CppClassPointerStore<CounterImminentDisplaySystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CounterImminentDisplaySystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CounterImminentDisplaySystem>.NativeClassPtr);
    CounterImminentDisplaySystem.NativeFieldInfoPtr_disableCardAnimationHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterImminentDisplaySystem>.NativeClassPtr, nameof (disableCardAnimationHover));
    CounterImminentDisplaySystem.NativeFieldInfoPtr_disableIconAnimationHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterImminentDisplaySystem>.NativeClassPtr, nameof (disableIconAnimationHover));
    CounterImminentDisplaySystem.NativeFieldInfoPtr_currentImminent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterImminentDisplaySystem>.NativeClassPtr, nameof (currentImminent));
    CounterImminentDisplaySystem.NativeFieldInfoPtr_currentHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterImminentDisplaySystem>.NativeClassPtr, nameof (currentHover));
    CounterImminentDisplaySystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterImminentDisplaySystem>.NativeClassPtr, 100668095);
    CounterImminentDisplaySystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterImminentDisplaySystem>.NativeClassPtr, 100668096);
    CounterImminentDisplaySystem.NativeMethodInfoPtr_EntityHover_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterImminentDisplaySystem>.NativeClassPtr, 100668097);
    CounterImminentDisplaySystem.NativeMethodInfoPtr_EntityUnHover_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterImminentDisplaySystem>.NativeClassPtr, 100668098);
    CounterImminentDisplaySystem.NativeMethodInfoPtr_EntityDisabled_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterImminentDisplaySystem>.NativeClassPtr, 100668099);
    CounterImminentDisplaySystem.NativeMethodInfoPtr_SetCardAnimation_Private_Void_Entity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterImminentDisplaySystem>.NativeClassPtr, 100668100);
    CounterImminentDisplaySystem.NativeMethodInfoPtr_SetCounterIconAnimation_Private_Void_Entity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterImminentDisplaySystem>.NativeClassPtr, 100668101);
    CounterImminentDisplaySystem.NativeMethodInfoPtr_EntityCheck_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterImminentDisplaySystem>.NativeClassPtr, 100668102);
    CounterImminentDisplaySystem.NativeMethodInfoPtr_Imminent_Private_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterImminentDisplaySystem>.NativeClassPtr, 100668103);
    CounterImminentDisplaySystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterImminentDisplaySystem>.NativeClassPtr, 100668104);
  }

  public CounterImminentDisplaySystem(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool disableCardAnimationHover
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CounterImminentDisplaySystem.NativeFieldInfoPtr_disableCardAnimationHover));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CounterImminentDisplaySystem.NativeFieldInfoPtr_disableCardAnimationHover)) = value;
    }
  }

  public unsafe bool disableIconAnimationHover
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CounterImminentDisplaySystem.NativeFieldInfoPtr_disableIconAnimationHover));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CounterImminentDisplaySystem.NativeFieldInfoPtr_disableIconAnimationHover)) = value;
    }
  }

  public unsafe List<Entity> currentImminent
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CounterImminentDisplaySystem.NativeFieldInfoPtr_currentImminent));
      return pointer == IntPtr.Zero ? (List<Entity>) null : new List<Entity>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CounterImminentDisplaySystem.NativeFieldInfoPtr_currentImminent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<Entity> currentHover
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CounterImminentDisplaySystem.NativeFieldInfoPtr_currentHover));
      return pointer == IntPtr.Zero ? (List<Entity>) null : new List<Entity>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CounterImminentDisplaySystem.NativeFieldInfoPtr_currentHover), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
