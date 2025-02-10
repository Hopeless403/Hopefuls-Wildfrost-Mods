// Decompiled with JetBrains decompiler
// Type: Rewired.FlightPedalsTemplate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Rewired
{
  public sealed class FlightPedalsTemplate : ControllerTemplate
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_typeGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftPedal;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightPedal;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_slide;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightPedalsTemplate_get_leftPedal_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightPedalsTemplate_get_rightPedal_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightPedalsTemplate_get_slide_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

    public virtual unsafe IControllerTemplateAxis Rewired\u002EIFlightPedalsTemplate\u002EleftPedal
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137541, XrefRangeEnd = 137544, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightPedalsTemplate.NativeMethodInfoPtr_Rewired_IFlightPedalsTemplate_get_leftPedal_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateAxis) null : new IControllerTemplateAxis(pointer);
      }
    }

    public virtual unsafe IControllerTemplateAxis Rewired\u002EIFlightPedalsTemplate\u002ErightPedal
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137544, XrefRangeEnd = 137547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightPedalsTemplate.NativeMethodInfoPtr_Rewired_IFlightPedalsTemplate_get_rightPedal_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateAxis) null : new IControllerTemplateAxis(pointer);
      }
    }

    public virtual unsafe IControllerTemplateAxis Rewired\u002EIFlightPedalsTemplate\u002Eslide
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137547, XrefRangeEnd = 137555, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightPedalsTemplate.NativeMethodInfoPtr_Rewired_IFlightPedalsTemplate_get_slide_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateAxis) null : new IControllerTemplateAxis(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FlightPedalsTemplate(Il2CppSystem.Object payload)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlightPedalsTemplate>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) payload)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FlightPedalsTemplate.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static FlightPedalsTemplate()
    {
      Il2CppClassPointerStore<FlightPedalsTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired", nameof (FlightPedalsTemplate));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlightPedalsTemplate>.NativeClassPtr);
      FlightPedalsTemplate.NativeFieldInfoPtr_typeGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightPedalsTemplate>.NativeClassPtr, nameof (typeGuid));
      FlightPedalsTemplate.NativeFieldInfoPtr_elementId_leftPedal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightPedalsTemplate>.NativeClassPtr, nameof (elementId_leftPedal));
      FlightPedalsTemplate.NativeFieldInfoPtr_elementId_rightPedal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightPedalsTemplate>.NativeClassPtr, nameof (elementId_rightPedal));
      FlightPedalsTemplate.NativeFieldInfoPtr_elementId_slide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightPedalsTemplate>.NativeClassPtr, nameof (elementId_slide));
      FlightPedalsTemplate.NativeMethodInfoPtr_Rewired_IFlightPedalsTemplate_get_leftPedal_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightPedalsTemplate>.NativeClassPtr, 100677897);
      FlightPedalsTemplate.NativeMethodInfoPtr_Rewired_IFlightPedalsTemplate_get_rightPedal_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightPedalsTemplate>.NativeClassPtr, 100677898);
      FlightPedalsTemplate.NativeMethodInfoPtr_Rewired_IFlightPedalsTemplate_get_slide_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightPedalsTemplate>.NativeClassPtr, 100677899);
      FlightPedalsTemplate.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightPedalsTemplate>.NativeClassPtr, 100677900);
    }

    public FlightPedalsTemplate(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe Il2CppSystem.Guid typeGuid
    {
      get
      {
        Il2CppSystem.Guid typeGuid;
        IL2CPP.il2cpp_field_static_get_value(FlightPedalsTemplate.NativeFieldInfoPtr_typeGuid, (void*) &typeGuid);
        return typeGuid;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightPedalsTemplate.NativeFieldInfoPtr_typeGuid, (void*) &value);
      }
    }

    public static unsafe int elementId_leftPedal
    {
      get
      {
        int elementIdLeftPedal;
        IL2CPP.il2cpp_field_static_get_value(FlightPedalsTemplate.NativeFieldInfoPtr_elementId_leftPedal, (void*) &elementIdLeftPedal);
        return elementIdLeftPedal;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightPedalsTemplate.NativeFieldInfoPtr_elementId_leftPedal, (void*) &value);
      }
    }

    public static unsafe int elementId_rightPedal
    {
      get
      {
        int elementIdRightPedal;
        IL2CPP.il2cpp_field_static_get_value(FlightPedalsTemplate.NativeFieldInfoPtr_elementId_rightPedal, (void*) &elementIdRightPedal);
        return elementIdRightPedal;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightPedalsTemplate.NativeFieldInfoPtr_elementId_rightPedal, (void*) &value);
      }
    }

    public static unsafe int elementId_slide
    {
      get
      {
        int elementIdSlide;
        IL2CPP.il2cpp_field_static_get_value(FlightPedalsTemplate.NativeFieldInfoPtr_elementId_slide, (void*) &elementIdSlide);
        return elementIdSlide;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightPedalsTemplate.NativeFieldInfoPtr_elementId_slide, (void*) &value);
      }
    }
  }
}
