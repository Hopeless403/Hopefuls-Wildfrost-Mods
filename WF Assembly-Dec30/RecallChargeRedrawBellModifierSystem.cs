// Decompiled with JetBrains decompiler
// Type: RecallChargeRedrawBellModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class RecallChargeRedrawBellModifierSystem : GameSystem
{
  private static readonly IntPtr NativeFieldInfoPtr__redrawBellSystem;
  private static readonly IntPtr NativeMethodInfoPtr_get_redrawBellSystem_Private_get_RedrawBellSystem_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_EntityDiscard_Private_Void_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe RedrawBellSystem redrawBellSystem
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 65703, RefRangeEnd = 65705, XrefRangeStart = 65696, XrefRangeEnd = 65703, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(RecallChargeRedrawBellModifierSystem.NativeMethodInfoPtr_get_redrawBellSystem_Private_get_RedrawBellSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (RedrawBellSystem) null : new RedrawBellSystem(pointer);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65705, XrefRangeEnd = 65713, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RecallChargeRedrawBellModifierSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65713, XrefRangeEnd = 65721, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RecallChargeRedrawBellModifierSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65721, XrefRangeEnd = 65728, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityDiscard(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RecallChargeRedrawBellModifierSystem.NativeMethodInfoPtr_EntityDiscard_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RecallChargeRedrawBellModifierSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RecallChargeRedrawBellModifierSystem>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RecallChargeRedrawBellModifierSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static RecallChargeRedrawBellModifierSystem()
  {
    Il2CppClassPointerStore<RecallChargeRedrawBellModifierSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (RecallChargeRedrawBellModifierSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecallChargeRedrawBellModifierSystem>.NativeClassPtr);
    RecallChargeRedrawBellModifierSystem.NativeFieldInfoPtr__redrawBellSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecallChargeRedrawBellModifierSystem>.NativeClassPtr, nameof (_redrawBellSystem));
    RecallChargeRedrawBellModifierSystem.NativeMethodInfoPtr_get_redrawBellSystem_Private_get_RedrawBellSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecallChargeRedrawBellModifierSystem>.NativeClassPtr, 100668707);
    RecallChargeRedrawBellModifierSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecallChargeRedrawBellModifierSystem>.NativeClassPtr, 100668708);
    RecallChargeRedrawBellModifierSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecallChargeRedrawBellModifierSystem>.NativeClassPtr, 100668709);
    RecallChargeRedrawBellModifierSystem.NativeMethodInfoPtr_EntityDiscard_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecallChargeRedrawBellModifierSystem>.NativeClassPtr, 100668710);
    RecallChargeRedrawBellModifierSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecallChargeRedrawBellModifierSystem>.NativeClassPtr, 100668711);
  }

  public RecallChargeRedrawBellModifierSystem(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe RedrawBellSystem _redrawBellSystem
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecallChargeRedrawBellModifierSystem.NativeFieldInfoPtr__redrawBellSystem));
      return pointer == IntPtr.Zero ? (RedrawBellSystem) null : new RedrawBellSystem(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RecallChargeRedrawBellModifierSystem.NativeFieldInfoPtr__redrawBellSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
