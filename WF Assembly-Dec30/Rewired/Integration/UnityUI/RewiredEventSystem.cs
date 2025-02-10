// Decompiled with JetBrains decompiler
// Type: Rewired.Integration.UnityUI.RewiredEventSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine.EventSystems;

#nullable disable
namespace Rewired.Integration.UnityUI
{
  public class RewiredEventSystem : EventSystem
  {
    private static readonly IntPtr NativeFieldInfoPtr__alwaysUpdate;
    private static readonly IntPtr NativeMethodInfoPtr_get_alwaysUpdate_Public_get_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_alwaysUpdate_Public_set_Void_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe bool alwaysUpdate
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredEventSystem.NativeMethodInfoPtr_get_alwaysUpdate_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1]
        {
          (IntPtr) &value
        };
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RewiredEventSystem.NativeMethodInfoPtr_set_alwaysUpdate_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139694, XrefRangeEnd = 139710, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RewiredEventSystem.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139710, XrefRangeEnd = 139714, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RewiredEventSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RewiredEventSystem>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RewiredEventSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RewiredEventSystem()
    {
      Il2CppClassPointerStore<RewiredEventSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Integration.UnityUI", nameof (RewiredEventSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RewiredEventSystem>.NativeClassPtr);
      RewiredEventSystem.NativeFieldInfoPtr__alwaysUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredEventSystem>.NativeClassPtr, nameof (_alwaysUpdate));
      RewiredEventSystem.NativeMethodInfoPtr_get_alwaysUpdate_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredEventSystem>.NativeClassPtr, 100678192);
      RewiredEventSystem.NativeMethodInfoPtr_set_alwaysUpdate_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredEventSystem>.NativeClassPtr, 100678193);
      RewiredEventSystem.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredEventSystem>.NativeClassPtr, 100678194);
      RewiredEventSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredEventSystem>.NativeClassPtr, 100678195);
    }

    public RewiredEventSystem(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool _alwaysUpdate
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredEventSystem.NativeFieldInfoPtr__alwaysUpdate));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredEventSystem.NativeFieldInfoPtr__alwaysUpdate)) = value;
      }
    }
  }
}
