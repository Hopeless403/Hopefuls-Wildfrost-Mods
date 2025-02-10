// Decompiled with JetBrains decompiler
// Type: ActionTriggerSubsequent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;

#nullable disable
public class ActionTriggerSubsequent : ActionTriggerAgainst
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Entity_Entity_Entity_CardContainer_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetTargets_Protected_Virtual_Il2CppReferenceArray_1_Entity_0;

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 26167, RefRangeEnd = 26171, XrefRangeStart = 26167, XrefRangeEnd = 26171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ActionTriggerSubsequent(
    Entity entity,
    Entity triggeredBy,
    Entity target,
    CardContainer targetContainer)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionTriggerSubsequent>.NativeClassPtr))
  {
    IntPtr* numPtr = stackalloc IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) triggeredBy);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targetContainer);
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ActionTriggerSubsequent.NativeMethodInfoPtr__ctor_Public_Void_Entity_Entity_Entity_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26220, XrefRangeEnd = 26224, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Il2CppReferenceArray<Entity> GetTargets()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ActionTriggerSubsequent.NativeMethodInfoPtr_GetTargets_Protected_Virtual_Il2CppReferenceArray_1_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    IntPtr nativeObject = num;
    return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<Entity>) null : new Il2CppReferenceArray<Entity>(nativeObject);
  }

  static ActionTriggerSubsequent()
  {
    Il2CppClassPointerStore<ActionTriggerSubsequent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ActionTriggerSubsequent));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionTriggerSubsequent>.NativeClassPtr);
    ActionTriggerSubsequent.NativeMethodInfoPtr__ctor_Public_Void_Entity_Entity_Entity_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionTriggerSubsequent>.NativeClassPtr, 100664595);
    ActionTriggerSubsequent.NativeMethodInfoPtr_GetTargets_Protected_Virtual_Il2CppReferenceArray_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionTriggerSubsequent>.NativeClassPtr, 100664596);
  }

  public ActionTriggerSubsequent(IntPtr pointer)
    : base(pointer)
  {
  }
}
