// Decompiled with JetBrains decompiler
// Type: ActionTrigger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class ActionTrigger : PlayAction
{
  private static readonly IntPtr NativeFieldInfoPtr_entity;
  private static readonly IntPtr NativeFieldInfoPtr_triggeredBy;
  private static readonly IntPtr NativeFieldInfoPtr_triggerType;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Entity_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_IsRoutine_Public_Virtual_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_Process_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetTrigger_Protected_Virtual_New_Trigger_0;

  [CallerCount(10)]
  [CachedScanResults(RefRangeStart = 26127, RefRangeEnd = 26137, XrefRangeStart = 26120, XrefRangeEnd = 26127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ActionTrigger(Entity entity, Entity triggeredBy)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionTrigger>.NativeClassPtr))
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) triggeredBy);
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ActionTrigger.NativeMethodInfoPtr__ctor_Public_Void_Entity_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  public override unsafe bool IsRoutine
  {
    [CallerCount(126), CachedScanResults(RefRangeStart = 15285, RefRangeEnd = 15411, XrefRangeStart = 15285, XrefRangeEnd = 15411, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ActionTrigger.NativeMethodInfoPtr_get_IsRoutine_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26137, XrefRangeEnd = 26155, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Process()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ActionTrigger.NativeMethodInfoPtr_Process_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26155, XrefRangeEnd = 26164, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Trigger GetTrigger()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ActionTrigger.NativeMethodInfoPtr_GetTrigger_Protected_Virtual_New_Trigger_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    IntPtr pointer = num;
    return pointer == IntPtr.Zero ? (Trigger) null : new Trigger(pointer);
  }

  static ActionTrigger()
  {
    Il2CppClassPointerStore<ActionTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ActionTrigger));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionTrigger>.NativeClassPtr);
    ActionTrigger.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionTrigger>.NativeClassPtr, nameof (entity));
    ActionTrigger.NativeFieldInfoPtr_triggeredBy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionTrigger>.NativeClassPtr, nameof (triggeredBy));
    ActionTrigger.NativeFieldInfoPtr_triggerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionTrigger>.NativeClassPtr, nameof (triggerType));
    ActionTrigger.NativeMethodInfoPtr__ctor_Public_Void_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionTrigger>.NativeClassPtr, 100664583);
    ActionTrigger.NativeMethodInfoPtr_get_IsRoutine_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionTrigger>.NativeClassPtr, 100664584);
    ActionTrigger.NativeMethodInfoPtr_Process_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionTrigger>.NativeClassPtr, 100664585);
    ActionTrigger.NativeMethodInfoPtr_GetTrigger_Protected_Virtual_New_Trigger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionTrigger>.NativeClassPtr, 100664586);
  }

  public ActionTrigger(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Entity entity
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionTrigger.NativeFieldInfoPtr_entity));
      return pointer == IntPtr.Zero ? (Entity) null : new Entity(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActionTrigger.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Entity triggeredBy
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionTrigger.NativeFieldInfoPtr_triggeredBy));
      return pointer == IntPtr.Zero ? (Entity) null : new Entity(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActionTrigger.NativeFieldInfoPtr_triggeredBy), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string triggerType
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionTrigger.NativeFieldInfoPtr_triggerType)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActionTrigger.NativeFieldInfoPtr_triggerType), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
