// Decompiled with JetBrains decompiler
// Type: Rewired.IFlightPedalsTemplate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace Rewired
{
  public class IFlightPedalsTemplate : Il2CppObjectBase
  {
    private static readonly IntPtr NativeMethodInfoPtr_get_leftPedal_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_rightPedal_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_slide_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0;

    public virtual unsafe IControllerTemplateAxis leftPedal
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IFlightPedalsTemplate.NativeMethodInfoPtr_get_leftPedal_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateAxis) null : new IControllerTemplateAxis(pointer);
      }
    }

    public virtual unsafe IControllerTemplateAxis rightPedal
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IFlightPedalsTemplate.NativeMethodInfoPtr_get_rightPedal_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateAxis) null : new IControllerTemplateAxis(pointer);
      }
    }

    public virtual unsafe IControllerTemplateAxis slide
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IFlightPedalsTemplate.NativeMethodInfoPtr_get_slide_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateAxis) null : new IControllerTemplateAxis(pointer);
      }
    }

    static IFlightPedalsTemplate()
    {
      Il2CppClassPointerStore<IFlightPedalsTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired", nameof (IFlightPedalsTemplate));
      IFlightPedalsTemplate.NativeMethodInfoPtr_get_leftPedal_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFlightPedalsTemplate>.NativeClassPtr, 100677637);
      IFlightPedalsTemplate.NativeMethodInfoPtr_get_rightPedal_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFlightPedalsTemplate>.NativeClassPtr, 100677638);
      IFlightPedalsTemplate.NativeMethodInfoPtr_get_slide_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFlightPedalsTemplate>.NativeClassPtr, 100677639);
    }

    public IFlightPedalsTemplate(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
