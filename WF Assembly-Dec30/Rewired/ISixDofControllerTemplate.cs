// Decompiled with JetBrains decompiler
// Type: Rewired.ISixDofControllerTemplate
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
  public class ISixDofControllerTemplate : Il2CppObjectBase
  {
    private static readonly IntPtr NativeMethodInfoPtr_get_extraAxis1_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_extraAxis2_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_extraAxis3_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_extraAxis4_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_button1_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_button2_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_button3_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_button4_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_button5_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_button6_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_button7_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_button8_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_button9_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_button10_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_button11_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_button12_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_button13_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_button14_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_button15_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_button16_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_button17_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_button18_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_button19_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_button20_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_button21_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_button22_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_button23_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_button24_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_button25_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_button26_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_button27_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_button28_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_button29_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_button30_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_button31_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_button32_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_hat1_Public_Abstract_Virtual_New_get_IControllerTemplateHat_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_hat2_Public_Abstract_Virtual_New_get_IControllerTemplateHat_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_throttle1_Public_Abstract_Virtual_New_get_IControllerTemplateThrottle_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_throttle2_Public_Abstract_Virtual_New_get_IControllerTemplateThrottle_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_stick_Public_Abstract_Virtual_New_get_IControllerTemplateStick6D_0;

    public virtual unsafe IControllerTemplateAxis extraAxis1
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ISixDofControllerTemplate.NativeMethodInfoPtr_get_extraAxis1_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateAxis) null : new IControllerTemplateAxis(pointer);
      }
    }

    public virtual unsafe IControllerTemplateAxis extraAxis2
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ISixDofControllerTemplate.NativeMethodInfoPtr_get_extraAxis2_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateAxis) null : new IControllerTemplateAxis(pointer);
      }
    }

    public virtual unsafe IControllerTemplateAxis extraAxis3
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ISixDofControllerTemplate.NativeMethodInfoPtr_get_extraAxis3_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateAxis) null : new IControllerTemplateAxis(pointer);
      }
    }

    public virtual unsafe IControllerTemplateAxis extraAxis4
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ISixDofControllerTemplate.NativeMethodInfoPtr_get_extraAxis4_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateAxis) null : new IControllerTemplateAxis(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton button1
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ISixDofControllerTemplate.NativeMethodInfoPtr_get_button1_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton button2
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ISixDofControllerTemplate.NativeMethodInfoPtr_get_button2_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton button3
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ISixDofControllerTemplate.NativeMethodInfoPtr_get_button3_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton button4
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ISixDofControllerTemplate.NativeMethodInfoPtr_get_button4_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton button5
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ISixDofControllerTemplate.NativeMethodInfoPtr_get_button5_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton button6
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ISixDofControllerTemplate.NativeMethodInfoPtr_get_button6_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton button7
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ISixDofControllerTemplate.NativeMethodInfoPtr_get_button7_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton button8
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ISixDofControllerTemplate.NativeMethodInfoPtr_get_button8_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton button9
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ISixDofControllerTemplate.NativeMethodInfoPtr_get_button9_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton button10
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ISixDofControllerTemplate.NativeMethodInfoPtr_get_button10_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton button11
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ISixDofControllerTemplate.NativeMethodInfoPtr_get_button11_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton button12
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ISixDofControllerTemplate.NativeMethodInfoPtr_get_button12_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton button13
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ISixDofControllerTemplate.NativeMethodInfoPtr_get_button13_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton button14
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ISixDofControllerTemplate.NativeMethodInfoPtr_get_button14_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton button15
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ISixDofControllerTemplate.NativeMethodInfoPtr_get_button15_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton button16
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ISixDofControllerTemplate.NativeMethodInfoPtr_get_button16_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton button17
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ISixDofControllerTemplate.NativeMethodInfoPtr_get_button17_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton button18
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ISixDofControllerTemplate.NativeMethodInfoPtr_get_button18_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton button19
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ISixDofControllerTemplate.NativeMethodInfoPtr_get_button19_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton button20
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ISixDofControllerTemplate.NativeMethodInfoPtr_get_button20_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton button21
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ISixDofControllerTemplate.NativeMethodInfoPtr_get_button21_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton button22
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ISixDofControllerTemplate.NativeMethodInfoPtr_get_button22_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton button23
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ISixDofControllerTemplate.NativeMethodInfoPtr_get_button23_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton button24
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ISixDofControllerTemplate.NativeMethodInfoPtr_get_button24_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton button25
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ISixDofControllerTemplate.NativeMethodInfoPtr_get_button25_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton button26
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ISixDofControllerTemplate.NativeMethodInfoPtr_get_button26_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton button27
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ISixDofControllerTemplate.NativeMethodInfoPtr_get_button27_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton button28
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ISixDofControllerTemplate.NativeMethodInfoPtr_get_button28_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton button29
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ISixDofControllerTemplate.NativeMethodInfoPtr_get_button29_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton button30
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ISixDofControllerTemplate.NativeMethodInfoPtr_get_button30_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton button31
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ISixDofControllerTemplate.NativeMethodInfoPtr_get_button31_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton button32
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ISixDofControllerTemplate.NativeMethodInfoPtr_get_button32_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateHat hat1
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ISixDofControllerTemplate.NativeMethodInfoPtr_get_hat1_Public_Abstract_Virtual_New_get_IControllerTemplateHat_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateHat) null : new IControllerTemplateHat(pointer);
      }
    }

    public virtual unsafe IControllerTemplateHat hat2
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ISixDofControllerTemplate.NativeMethodInfoPtr_get_hat2_Public_Abstract_Virtual_New_get_IControllerTemplateHat_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateHat) null : new IControllerTemplateHat(pointer);
      }
    }

    public virtual unsafe IControllerTemplateThrottle throttle1
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ISixDofControllerTemplate.NativeMethodInfoPtr_get_throttle1_Public_Abstract_Virtual_New_get_IControllerTemplateThrottle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateThrottle) null : new IControllerTemplateThrottle(pointer);
      }
    }

    public virtual unsafe IControllerTemplateThrottle throttle2
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ISixDofControllerTemplate.NativeMethodInfoPtr_get_throttle2_Public_Abstract_Virtual_New_get_IControllerTemplateThrottle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateThrottle) null : new IControllerTemplateThrottle(pointer);
      }
    }

    public virtual unsafe IControllerTemplateStick6D stick
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ISixDofControllerTemplate.NativeMethodInfoPtr_get_stick_Public_Abstract_Virtual_New_get_IControllerTemplateStick6D_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateStick6D) null : new IControllerTemplateStick6D(pointer);
      }
    }

    static ISixDofControllerTemplate()
    {
      Il2CppClassPointerStore<ISixDofControllerTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired", nameof (ISixDofControllerTemplate));
      ISixDofControllerTemplate.NativeMethodInfoPtr_get_extraAxis1_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISixDofControllerTemplate>.NativeClassPtr, 100677640);
      ISixDofControllerTemplate.NativeMethodInfoPtr_get_extraAxis2_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISixDofControllerTemplate>.NativeClassPtr, 100677641);
      ISixDofControllerTemplate.NativeMethodInfoPtr_get_extraAxis3_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISixDofControllerTemplate>.NativeClassPtr, 100677642);
      ISixDofControllerTemplate.NativeMethodInfoPtr_get_extraAxis4_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISixDofControllerTemplate>.NativeClassPtr, 100677643);
      ISixDofControllerTemplate.NativeMethodInfoPtr_get_button1_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISixDofControllerTemplate>.NativeClassPtr, 100677644);
      ISixDofControllerTemplate.NativeMethodInfoPtr_get_button2_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISixDofControllerTemplate>.NativeClassPtr, 100677645);
      ISixDofControllerTemplate.NativeMethodInfoPtr_get_button3_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISixDofControllerTemplate>.NativeClassPtr, 100677646);
      ISixDofControllerTemplate.NativeMethodInfoPtr_get_button4_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISixDofControllerTemplate>.NativeClassPtr, 100677647);
      ISixDofControllerTemplate.NativeMethodInfoPtr_get_button5_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISixDofControllerTemplate>.NativeClassPtr, 100677648);
      ISixDofControllerTemplate.NativeMethodInfoPtr_get_button6_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISixDofControllerTemplate>.NativeClassPtr, 100677649);
      ISixDofControllerTemplate.NativeMethodInfoPtr_get_button7_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISixDofControllerTemplate>.NativeClassPtr, 100677650);
      ISixDofControllerTemplate.NativeMethodInfoPtr_get_button8_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISixDofControllerTemplate>.NativeClassPtr, 100677651);
      ISixDofControllerTemplate.NativeMethodInfoPtr_get_button9_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISixDofControllerTemplate>.NativeClassPtr, 100677652);
      ISixDofControllerTemplate.NativeMethodInfoPtr_get_button10_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISixDofControllerTemplate>.NativeClassPtr, 100677653);
      ISixDofControllerTemplate.NativeMethodInfoPtr_get_button11_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISixDofControllerTemplate>.NativeClassPtr, 100677654);
      ISixDofControllerTemplate.NativeMethodInfoPtr_get_button12_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISixDofControllerTemplate>.NativeClassPtr, 100677655);
      ISixDofControllerTemplate.NativeMethodInfoPtr_get_button13_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISixDofControllerTemplate>.NativeClassPtr, 100677656);
      ISixDofControllerTemplate.NativeMethodInfoPtr_get_button14_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISixDofControllerTemplate>.NativeClassPtr, 100677657);
      ISixDofControllerTemplate.NativeMethodInfoPtr_get_button15_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISixDofControllerTemplate>.NativeClassPtr, 100677658);
      ISixDofControllerTemplate.NativeMethodInfoPtr_get_button16_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISixDofControllerTemplate>.NativeClassPtr, 100677659);
      ISixDofControllerTemplate.NativeMethodInfoPtr_get_button17_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISixDofControllerTemplate>.NativeClassPtr, 100677660);
      ISixDofControllerTemplate.NativeMethodInfoPtr_get_button18_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISixDofControllerTemplate>.NativeClassPtr, 100677661);
      ISixDofControllerTemplate.NativeMethodInfoPtr_get_button19_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISixDofControllerTemplate>.NativeClassPtr, 100677662);
      ISixDofControllerTemplate.NativeMethodInfoPtr_get_button20_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISixDofControllerTemplate>.NativeClassPtr, 100677663);
      ISixDofControllerTemplate.NativeMethodInfoPtr_get_button21_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISixDofControllerTemplate>.NativeClassPtr, 100677664);
      ISixDofControllerTemplate.NativeMethodInfoPtr_get_button22_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISixDofControllerTemplate>.NativeClassPtr, 100677665);
      ISixDofControllerTemplate.NativeMethodInfoPtr_get_button23_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISixDofControllerTemplate>.NativeClassPtr, 100677666);
      ISixDofControllerTemplate.NativeMethodInfoPtr_get_button24_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISixDofControllerTemplate>.NativeClassPtr, 100677667);
      ISixDofControllerTemplate.NativeMethodInfoPtr_get_button25_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISixDofControllerTemplate>.NativeClassPtr, 100677668);
      ISixDofControllerTemplate.NativeMethodInfoPtr_get_button26_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISixDofControllerTemplate>.NativeClassPtr, 100677669);
      ISixDofControllerTemplate.NativeMethodInfoPtr_get_button27_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISixDofControllerTemplate>.NativeClassPtr, 100677670);
      ISixDofControllerTemplate.NativeMethodInfoPtr_get_button28_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISixDofControllerTemplate>.NativeClassPtr, 100677671);
      ISixDofControllerTemplate.NativeMethodInfoPtr_get_button29_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISixDofControllerTemplate>.NativeClassPtr, 100677672);
      ISixDofControllerTemplate.NativeMethodInfoPtr_get_button30_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISixDofControllerTemplate>.NativeClassPtr, 100677673);
      ISixDofControllerTemplate.NativeMethodInfoPtr_get_button31_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISixDofControllerTemplate>.NativeClassPtr, 100677674);
      ISixDofControllerTemplate.NativeMethodInfoPtr_get_button32_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISixDofControllerTemplate>.NativeClassPtr, 100677675);
      ISixDofControllerTemplate.NativeMethodInfoPtr_get_hat1_Public_Abstract_Virtual_New_get_IControllerTemplateHat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISixDofControllerTemplate>.NativeClassPtr, 100677676);
      ISixDofControllerTemplate.NativeMethodInfoPtr_get_hat2_Public_Abstract_Virtual_New_get_IControllerTemplateHat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISixDofControllerTemplate>.NativeClassPtr, 100677677);
      ISixDofControllerTemplate.NativeMethodInfoPtr_get_throttle1_Public_Abstract_Virtual_New_get_IControllerTemplateThrottle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISixDofControllerTemplate>.NativeClassPtr, 100677678);
      ISixDofControllerTemplate.NativeMethodInfoPtr_get_throttle2_Public_Abstract_Virtual_New_get_IControllerTemplateThrottle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISixDofControllerTemplate>.NativeClassPtr, 100677679);
      ISixDofControllerTemplate.NativeMethodInfoPtr_get_stick_Public_Abstract_Virtual_New_get_IControllerTemplateStick6D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISixDofControllerTemplate>.NativeClassPtr, 100677680);
    }

    public ISixDofControllerTemplate(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
