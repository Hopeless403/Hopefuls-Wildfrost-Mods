// Decompiled with JetBrains decompiler
// Type: ActionReveal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class ActionReveal : PlayAction
{
  private static readonly IntPtr NativeFieldInfoPtr_entity;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Entity_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_IsRoutine_Public_Virtual_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_Process_Public_Virtual_Void_0;

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 25799, RefRangeEnd = 25802, XrefRangeStart = 25797, XrefRangeEnd = 25799, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ActionReveal(Entity entity, float pauseAfter = 0.0f)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionReveal>.NativeClassPtr))
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &pauseAfter;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ActionReveal.NativeMethodInfoPtr__ctor_Public_Void_Entity_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  public override unsafe bool IsRoutine
  {
    [CallerCount(126), CachedScanResults(RefRangeStart = 15285, RefRangeEnd = 15411, XrefRangeStart = 15285, XrefRangeEnd = 15411, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ActionReveal.NativeMethodInfoPtr_get_IsRoutine_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25802, XrefRangeEnd = 25805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Process()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ActionReveal.NativeMethodInfoPtr_Process_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ActionReveal()
  {
    Il2CppClassPointerStore<ActionReveal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ActionReveal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionReveal>.NativeClassPtr);
    ActionReveal.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionReveal>.NativeClassPtr, nameof (entity));
    ActionReveal.NativeMethodInfoPtr__ctor_Public_Void_Entity_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionReveal>.NativeClassPtr, 100664544);
    ActionReveal.NativeMethodInfoPtr_get_IsRoutine_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionReveal>.NativeClassPtr, 100664545);
    ActionReveal.NativeMethodInfoPtr_Process_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionReveal>.NativeClassPtr, 100664546);
  }

  public ActionReveal(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Entity entity
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionReveal.NativeFieldInfoPtr_entity));
      return pointer == IntPtr.Zero ? (Entity) null : new Entity(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActionReveal.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
