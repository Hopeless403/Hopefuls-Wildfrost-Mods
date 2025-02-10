// Decompiled with JetBrains decompiler
// Type: ActionTriggerAgainst
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
public class ActionTriggerAgainst : ActionTrigger
{
  private static readonly IntPtr NativeFieldInfoPtr_target;
  private static readonly IntPtr NativeFieldInfoPtr_targetContainer;
  private static readonly IntPtr NativeFieldInfoPtr_trigger;
  private static readonly IntPtr NativeFieldInfoPtr_countsAsTrigger;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Entity_Entity_Entity_CardContainer_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_IsRoutine_Public_Virtual_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_Process_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetTrigger_Protected_Virtual_Trigger_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetTargets_Protected_Virtual_New_Il2CppReferenceArray_1_Entity_0;

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 26167, RefRangeEnd = 26171, XrefRangeStart = 26164, XrefRangeEnd = 26167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ActionTriggerAgainst(
    Entity entity,
    Entity triggeredBy,
    Entity target,
    CardContainer targetContainer)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionTriggerAgainst>.NativeClassPtr))
  {
    IntPtr* numPtr = stackalloc IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) triggeredBy);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targetContainer);
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ActionTriggerAgainst.NativeMethodInfoPtr__ctor_Public_Void_Entity_Entity_Entity_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  public override unsafe bool IsRoutine
  {
    [CallerCount(126), CachedScanResults(RefRangeStart = 15285, RefRangeEnd = 15411, XrefRangeStart = 15285, XrefRangeEnd = 15411, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ActionTriggerAgainst.NativeMethodInfoPtr_get_IsRoutine_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26171, XrefRangeEnd = 26189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Process()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ActionTriggerAgainst.NativeMethodInfoPtr_Process_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26189, XrefRangeEnd = 26196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Trigger GetTrigger()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ActionTriggerAgainst.NativeMethodInfoPtr_GetTrigger_Protected_Virtual_Trigger_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    IntPtr pointer = num;
    return pointer == IntPtr.Zero ? (Trigger) null : new Trigger(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26196, XrefRangeEnd = 26201, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppReferenceArray<Entity> GetTargets()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ActionTriggerAgainst.NativeMethodInfoPtr_GetTargets_Protected_Virtual_New_Il2CppReferenceArray_1_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    IntPtr nativeObject = num;
    return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<Entity>) null : new Il2CppReferenceArray<Entity>(nativeObject);
  }

  static ActionTriggerAgainst()
  {
    Il2CppClassPointerStore<ActionTriggerAgainst>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ActionTriggerAgainst));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionTriggerAgainst>.NativeClassPtr);
    ActionTriggerAgainst.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionTriggerAgainst>.NativeClassPtr, nameof (target));
    ActionTriggerAgainst.NativeFieldInfoPtr_targetContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionTriggerAgainst>.NativeClassPtr, nameof (targetContainer));
    ActionTriggerAgainst.NativeFieldInfoPtr_trigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionTriggerAgainst>.NativeClassPtr, nameof (trigger));
    ActionTriggerAgainst.NativeFieldInfoPtr_countsAsTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionTriggerAgainst>.NativeClassPtr, nameof (countsAsTrigger));
    ActionTriggerAgainst.NativeMethodInfoPtr__ctor_Public_Void_Entity_Entity_Entity_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionTriggerAgainst>.NativeClassPtr, 100664587);
    ActionTriggerAgainst.NativeMethodInfoPtr_get_IsRoutine_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionTriggerAgainst>.NativeClassPtr, 100664588);
    ActionTriggerAgainst.NativeMethodInfoPtr_Process_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionTriggerAgainst>.NativeClassPtr, 100664589);
    ActionTriggerAgainst.NativeMethodInfoPtr_GetTrigger_Protected_Virtual_Trigger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionTriggerAgainst>.NativeClassPtr, 100664590);
    ActionTriggerAgainst.NativeMethodInfoPtr_GetTargets_Protected_Virtual_New_Il2CppReferenceArray_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionTriggerAgainst>.NativeClassPtr, 100664591);
  }

  public ActionTriggerAgainst(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Entity target
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionTriggerAgainst.NativeFieldInfoPtr_target));
      return pointer == IntPtr.Zero ? (Entity) null : new Entity(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActionTriggerAgainst.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CardContainer targetContainer
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionTriggerAgainst.NativeFieldInfoPtr_targetContainer));
      return pointer == IntPtr.Zero ? (CardContainer) null : new CardContainer(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActionTriggerAgainst.NativeFieldInfoPtr_targetContainer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Trigger trigger
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionTriggerAgainst.NativeFieldInfoPtr_trigger));
      return pointer == IntPtr.Zero ? (Trigger) null : new Trigger(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActionTriggerAgainst.NativeFieldInfoPtr_trigger), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool countsAsTrigger
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionTriggerAgainst.NativeFieldInfoPtr_countsAsTrigger));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionTriggerAgainst.NativeFieldInfoPtr_countsAsTrigger)) = value;
    }
  }
}
