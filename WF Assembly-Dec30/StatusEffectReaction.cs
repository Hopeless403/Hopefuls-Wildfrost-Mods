// Decompiled with JetBrains decompiler
// Type: StatusEffectReaction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;

#nullable disable
public class StatusEffectReaction : StatusEffectData
{
  private static readonly IntPtr NativeMethodInfoPtr_CanTrigger_Protected_Virtual_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_PlayedInThisRow_Protected_Boolean_Entity_Il2CppReferenceArray_1_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120522, XrefRangeEnd = 120523, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool CanTrigger()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectReaction.NativeMethodInfoPtr_CanTrigger_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120523, XrefRangeEnd = 120532, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool PlayedInThisRow(Entity entity, Il2CppReferenceArray<Entity> targets)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targets);
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectReaction.NativeMethodInfoPtr_PlayedInThisRow_Protected_Boolean_Entity_Il2CppReferenceArray_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(23)]
  [CachedScanResults(RefRangeStart = 118133, RefRangeEnd = 118156, XrefRangeStart = 118133, XrefRangeEnd = 118156, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StatusEffectReaction()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusEffectReaction>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectReaction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static StatusEffectReaction()
  {
    Il2CppClassPointerStore<StatusEffectReaction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (StatusEffectReaction));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusEffectReaction>.NativeClassPtr);
    StatusEffectReaction.NativeMethodInfoPtr_CanTrigger_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectReaction>.NativeClassPtr, 100675248);
    StatusEffectReaction.NativeMethodInfoPtr_PlayedInThisRow_Protected_Boolean_Entity_Il2CppReferenceArray_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectReaction>.NativeClassPtr, 100675249);
    StatusEffectReaction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectReaction>.NativeClassPtr, 100675250);
  }

  public StatusEffectReaction(IntPtr pointer)
    : base(pointer)
  {
  }
}
