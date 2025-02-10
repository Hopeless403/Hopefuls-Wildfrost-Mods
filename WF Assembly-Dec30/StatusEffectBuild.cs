// Decompiled with JetBrains decompiler
// Type: StatusEffectBuild
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class StatusEffectBuild : StatusEffectData
{
  private static readonly IntPtr NativeFieldInfoPtr_requires;
  private static readonly IntPtr NativeMethodInfoPtr_RunCardMoveEvent_Public_Virtual_Boolean_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__RunCardMoveEvent_b__1_0_Private_Boolean_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr__RunCardMoveEvent_b__1_1_Private_Boolean_StatusEffectData_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126674, XrefRangeEnd = 126710, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool RunCardMoveEvent(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StatusEffectBuild.NativeMethodInfoPtr_RunCardMoveEvent_Public_Virtual_Boolean_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126710, XrefRangeEnd = 126711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StatusEffectBuild()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusEffectBuild>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatusEffectBuild.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126711, XrefRangeEnd = 126721, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool _RunCardMoveEvent_b__1_0(Entity ally)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) ally)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectBuild.NativeMethodInfoPtr__RunCardMoveEvent_b__1_0_Private_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126721, XrefRangeEnd = 126725, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool _RunCardMoveEvent_b__1_1(StatusEffectData a)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatusEffectBuild.NativeMethodInfoPtr__RunCardMoveEvent_b__1_1_Private_Boolean_StatusEffectData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  static StatusEffectBuild()
  {
    Il2CppClassPointerStore<StatusEffectBuild>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (StatusEffectBuild));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusEffectBuild>.NativeClassPtr);
    StatusEffectBuild.NativeFieldInfoPtr_requires = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffectBuild>.NativeClassPtr, nameof (requires));
    StatusEffectBuild.NativeMethodInfoPtr_RunCardMoveEvent_Public_Virtual_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectBuild>.NativeClassPtr, 100676355);
    StatusEffectBuild.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectBuild>.NativeClassPtr, 100676356);
    StatusEffectBuild.NativeMethodInfoPtr__RunCardMoveEvent_b__1_0_Private_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectBuild>.NativeClassPtr, 100676357);
    StatusEffectBuild.NativeMethodInfoPtr__RunCardMoveEvent_b__1_1_Private_Boolean_StatusEffectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffectBuild>.NativeClassPtr, 100676358);
  }

  public StatusEffectBuild(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe int requires
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectBuild.NativeFieldInfoPtr_requires));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatusEffectBuild.NativeFieldInfoPtr_requires)) = value;
    }
  }
}
