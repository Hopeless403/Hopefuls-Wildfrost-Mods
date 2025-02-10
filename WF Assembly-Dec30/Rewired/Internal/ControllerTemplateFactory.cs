// Decompiled with JetBrains decompiler
// Type: Rewired.Internal.ControllerTemplateFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace Rewired.Internal
{
  public static class ControllerTemplateFactory : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__defaultTemplateTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr__defaultTemplateInterfaceTypes;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_templateTypes_Public_Static_get_Il2CppReferenceArray_1_Type_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_templateInterfaceTypes_Public_Static_get_Il2CppReferenceArray_1_Type_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_IControllerTemplate_Guid_Object_0;

    public static unsafe Il2CppReferenceArray<Il2CppSystem.Type> templateTypes
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139615, XrefRangeEnd = 139619, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateFactory.NativeMethodInfoPtr_get_templateTypes_Public_Static_get_Il2CppReferenceArray_1_Type_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr nativeObject = num;
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Il2CppSystem.Type>) null : new Il2CppReferenceArray<Il2CppSystem.Type>(nativeObject);
      }
    }

    public static unsafe Il2CppReferenceArray<Il2CppSystem.Type> templateInterfaceTypes
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139619, XrefRangeEnd = 139623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateFactory.NativeMethodInfoPtr_get_templateInterfaceTypes_Public_Static_get_Il2CppReferenceArray_1_Type_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr nativeObject = num;
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Il2CppSystem.Type>) null : new Il2CppReferenceArray<Il2CppSystem.Type>(nativeObject);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 139653, RefRangeEnd = 139654, XrefRangeStart = 139623, XrefRangeEnd = 139653, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe IControllerTemplate Create(Il2CppSystem.Guid typeGuid, Il2CppSystem.Object payload)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &typeGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) payload);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateFactory.NativeMethodInfoPtr_Create_Public_Static_IControllerTemplate_Guid_Object_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IControllerTemplate) null : new IControllerTemplate(pointer);
    }

    static ControllerTemplateFactory()
    {
      Il2CppClassPointerStore<ControllerTemplateFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Internal", nameof (ControllerTemplateFactory));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerTemplateFactory>.NativeClassPtr);
      ControllerTemplateFactory.NativeFieldInfoPtr__defaultTemplateTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateFactory>.NativeClassPtr, nameof (_defaultTemplateTypes));
      ControllerTemplateFactory.NativeFieldInfoPtr__defaultTemplateInterfaceTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateFactory>.NativeClassPtr, nameof (_defaultTemplateInterfaceTypes));
      ControllerTemplateFactory.NativeMethodInfoPtr_get_templateTypes_Public_Static_get_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateFactory>.NativeClassPtr, 100678174);
      ControllerTemplateFactory.NativeMethodInfoPtr_get_templateInterfaceTypes_Public_Static_get_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateFactory>.NativeClassPtr, 100678175);
      ControllerTemplateFactory.NativeMethodInfoPtr_Create_Public_Static_IControllerTemplate_Guid_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateFactory>.NativeClassPtr, 100678176);
    }

    public ControllerTemplateFactory(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe Il2CppReferenceArray<Il2CppSystem.Type> _defaultTemplateTypes
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ControllerTemplateFactory.NativeFieldInfoPtr__defaultTemplateTypes, (void*) &num);
        System.IntPtr nativeObject = num;
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Il2CppSystem.Type>) null : new Il2CppReferenceArray<Il2CppSystem.Type>(nativeObject);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ControllerTemplateFactory.NativeFieldInfoPtr__defaultTemplateTypes, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppReferenceArray<Il2CppSystem.Type> _defaultTemplateInterfaceTypes
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ControllerTemplateFactory.NativeFieldInfoPtr__defaultTemplateInterfaceTypes, (void*) &num);
        System.IntPtr nativeObject = num;
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Il2CppSystem.Type>) null : new Il2CppReferenceArray<Il2CppSystem.Type>(nativeObject);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ControllerTemplateFactory.NativeFieldInfoPtr__defaultTemplateInterfaceTypes, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
