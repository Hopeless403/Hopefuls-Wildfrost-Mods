// Decompiled with JetBrains decompiler
// Type: ActionResetOffset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class ActionResetOffset : PlayAction
{
  private static readonly IntPtr NativeFieldInfoPtr_entity;
  private static readonly IntPtr NativeFieldInfoPtr_dur;
  private static readonly IntPtr NativeFieldInfoPtr_ease;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_IsRoutine_Public_Virtual_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_Process_Public_Virtual_Void_0;

  [CallerCount(19)]
  [CachedScanResults(RefRangeStart = 25476, RefRangeEnd = 25495, XrefRangeStart = 25476, XrefRangeEnd = 25495, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ActionResetOffset(Entity entity)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionResetOffset>.NativeClassPtr))
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ActionResetOffset.NativeMethodInfoPtr__ctor_Public_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  public override unsafe bool IsRoutine
  {
    [CallerCount(126), CachedScanResults(RefRangeStart = 15285, RefRangeEnd = 15411, XrefRangeStart = 15285, XrefRangeEnd = 15411, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ActionResetOffset.NativeMethodInfoPtr_get_IsRoutine_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25778, XrefRangeEnd = 25797, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Process()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ActionResetOffset.NativeMethodInfoPtr_Process_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ActionResetOffset()
  {
    Il2CppClassPointerStore<ActionResetOffset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ActionResetOffset));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionResetOffset>.NativeClassPtr);
    ActionResetOffset.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionResetOffset>.NativeClassPtr, nameof (entity));
    ActionResetOffset.NativeFieldInfoPtr_dur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionResetOffset>.NativeClassPtr, nameof (dur));
    ActionResetOffset.NativeFieldInfoPtr_ease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionResetOffset>.NativeClassPtr, nameof (ease));
    ActionResetOffset.NativeMethodInfoPtr__ctor_Public_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionResetOffset>.NativeClassPtr, 100664541);
    ActionResetOffset.NativeMethodInfoPtr_get_IsRoutine_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionResetOffset>.NativeClassPtr, 100664542);
    ActionResetOffset.NativeMethodInfoPtr_Process_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionResetOffset>.NativeClassPtr, 100664543);
  }

  public ActionResetOffset(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Entity entity
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionResetOffset.NativeFieldInfoPtr_entity));
      return pointer == IntPtr.Zero ? (Entity) null : new Entity(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActionResetOffset.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe float dur
  {
    get
    {
      float dur;
      IL2CPP.il2cpp_field_static_get_value(ActionResetOffset.NativeFieldInfoPtr_dur, (void*) &dur);
      return dur;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ActionResetOffset.NativeFieldInfoPtr_dur, (void*) &value);
    }
  }

  public static unsafe LeanTweenType ease
  {
    get
    {
      LeanTweenType ease;
      IL2CPP.il2cpp_field_static_get_value(ActionResetOffset.NativeFieldInfoPtr_ease, (void*) &ease);
      return ease;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ActionResetOffset.NativeFieldInfoPtr_ease, (void*) &value);
    }
  }
}
