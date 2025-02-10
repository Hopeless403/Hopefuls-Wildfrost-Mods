// Decompiled with JetBrains decompiler
// Type: ActionTriggerByCounter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
public class ActionTriggerByCounter : ActionTrigger
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Entity_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_IsRoutine_Public_Virtual_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_Process_Public_Virtual_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26201, XrefRangeEnd = 26202, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ActionTriggerByCounter(Entity entity, Entity triggeredBy)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionTriggerByCounter>.NativeClassPtr))
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) triggeredBy);
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ActionTriggerByCounter.NativeMethodInfoPtr__ctor_Public_Void_Entity_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  public override unsafe bool IsRoutine
  {
    [CallerCount(126), CachedScanResults(RefRangeStart = 15285, RefRangeEnd = 15411, XrefRangeStart = 15285, XrefRangeEnd = 15411, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ActionTriggerByCounter.NativeMethodInfoPtr_get_IsRoutine_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26202, XrefRangeEnd = 26220, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Process()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ActionTriggerByCounter.NativeMethodInfoPtr_Process_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ActionTriggerByCounter()
  {
    Il2CppClassPointerStore<ActionTriggerByCounter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ActionTriggerByCounter));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionTriggerByCounter>.NativeClassPtr);
    ActionTriggerByCounter.NativeMethodInfoPtr__ctor_Public_Void_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionTriggerByCounter>.NativeClassPtr, 100664592);
    ActionTriggerByCounter.NativeMethodInfoPtr_get_IsRoutine_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionTriggerByCounter>.NativeClassPtr, 100664593);
    ActionTriggerByCounter.NativeMethodInfoPtr_Process_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionTriggerByCounter>.NativeClassPtr, 100664594);
  }

  public ActionTriggerByCounter(IntPtr pointer)
    : base(pointer)
  {
  }
}
