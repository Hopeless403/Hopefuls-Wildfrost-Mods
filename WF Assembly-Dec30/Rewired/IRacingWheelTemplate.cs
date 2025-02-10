// Decompiled with JetBrains decompiler
// Type: Rewired.IRacingWheelTemplate
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
  public class IRacingWheelTemplate : Il2CppObjectBase
  {
    private static readonly IntPtr NativeMethodInfoPtr_get_wheel_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_accelerator_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_brake_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_clutch_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_shiftDown_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_shiftUp_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_wheelButton1_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_wheelButton2_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_wheelButton3_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_wheelButton4_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_wheelButton5_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_wheelButton6_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_wheelButton7_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_wheelButton8_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_wheelButton9_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_wheelButton10_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_consoleButton1_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_consoleButton2_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_consoleButton3_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_consoleButton4_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_consoleButton5_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_consoleButton6_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_consoleButton7_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_consoleButton8_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_consoleButton9_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_consoleButton10_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_shifter1_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_shifter2_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_shifter3_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_shifter4_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_shifter5_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_shifter6_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_shifter7_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_shifter8_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_shifter9_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_shifter10_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_reverseGear_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_select_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_start_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_systemButton_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_horn_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_dPad_Public_Abstract_Virtual_New_get_IControllerTemplateDPad_0;

    public virtual unsafe IControllerTemplateAxis wheel
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRacingWheelTemplate.NativeMethodInfoPtr_get_wheel_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateAxis) null : new IControllerTemplateAxis(pointer);
      }
    }

    public virtual unsafe IControllerTemplateAxis accelerator
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRacingWheelTemplate.NativeMethodInfoPtr_get_accelerator_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateAxis) null : new IControllerTemplateAxis(pointer);
      }
    }

    public virtual unsafe IControllerTemplateAxis brake
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRacingWheelTemplate.NativeMethodInfoPtr_get_brake_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateAxis) null : new IControllerTemplateAxis(pointer);
      }
    }

    public virtual unsafe IControllerTemplateAxis clutch
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRacingWheelTemplate.NativeMethodInfoPtr_get_clutch_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateAxis) null : new IControllerTemplateAxis(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton shiftDown
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRacingWheelTemplate.NativeMethodInfoPtr_get_shiftDown_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton shiftUp
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRacingWheelTemplate.NativeMethodInfoPtr_get_shiftUp_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton wheelButton1
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRacingWheelTemplate.NativeMethodInfoPtr_get_wheelButton1_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton wheelButton2
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRacingWheelTemplate.NativeMethodInfoPtr_get_wheelButton2_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton wheelButton3
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRacingWheelTemplate.NativeMethodInfoPtr_get_wheelButton3_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton wheelButton4
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRacingWheelTemplate.NativeMethodInfoPtr_get_wheelButton4_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton wheelButton5
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRacingWheelTemplate.NativeMethodInfoPtr_get_wheelButton5_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton wheelButton6
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRacingWheelTemplate.NativeMethodInfoPtr_get_wheelButton6_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton wheelButton7
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRacingWheelTemplate.NativeMethodInfoPtr_get_wheelButton7_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton wheelButton8
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRacingWheelTemplate.NativeMethodInfoPtr_get_wheelButton8_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton wheelButton9
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRacingWheelTemplate.NativeMethodInfoPtr_get_wheelButton9_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton wheelButton10
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRacingWheelTemplate.NativeMethodInfoPtr_get_wheelButton10_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton consoleButton1
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRacingWheelTemplate.NativeMethodInfoPtr_get_consoleButton1_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton consoleButton2
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRacingWheelTemplate.NativeMethodInfoPtr_get_consoleButton2_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton consoleButton3
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRacingWheelTemplate.NativeMethodInfoPtr_get_consoleButton3_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton consoleButton4
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRacingWheelTemplate.NativeMethodInfoPtr_get_consoleButton4_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton consoleButton5
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRacingWheelTemplate.NativeMethodInfoPtr_get_consoleButton5_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton consoleButton6
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRacingWheelTemplate.NativeMethodInfoPtr_get_consoleButton6_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton consoleButton7
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRacingWheelTemplate.NativeMethodInfoPtr_get_consoleButton7_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton consoleButton8
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRacingWheelTemplate.NativeMethodInfoPtr_get_consoleButton8_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton consoleButton9
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRacingWheelTemplate.NativeMethodInfoPtr_get_consoleButton9_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton consoleButton10
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRacingWheelTemplate.NativeMethodInfoPtr_get_consoleButton10_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton shifter1
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRacingWheelTemplate.NativeMethodInfoPtr_get_shifter1_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton shifter2
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRacingWheelTemplate.NativeMethodInfoPtr_get_shifter2_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton shifter3
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRacingWheelTemplate.NativeMethodInfoPtr_get_shifter3_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton shifter4
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRacingWheelTemplate.NativeMethodInfoPtr_get_shifter4_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton shifter5
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRacingWheelTemplate.NativeMethodInfoPtr_get_shifter5_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton shifter6
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRacingWheelTemplate.NativeMethodInfoPtr_get_shifter6_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton shifter7
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRacingWheelTemplate.NativeMethodInfoPtr_get_shifter7_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton shifter8
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRacingWheelTemplate.NativeMethodInfoPtr_get_shifter8_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton shifter9
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRacingWheelTemplate.NativeMethodInfoPtr_get_shifter9_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton shifter10
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRacingWheelTemplate.NativeMethodInfoPtr_get_shifter10_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton reverseGear
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRacingWheelTemplate.NativeMethodInfoPtr_get_reverseGear_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton select
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRacingWheelTemplate.NativeMethodInfoPtr_get_select_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton start
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRacingWheelTemplate.NativeMethodInfoPtr_get_start_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton systemButton
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRacingWheelTemplate.NativeMethodInfoPtr_get_systemButton_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton horn
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRacingWheelTemplate.NativeMethodInfoPtr_get_horn_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateDPad dPad
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRacingWheelTemplate.NativeMethodInfoPtr_get_dPad_Public_Abstract_Virtual_New_get_IControllerTemplateDPad_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IControllerTemplateDPad) null : new IControllerTemplateDPad(pointer);
      }
    }

    static IRacingWheelTemplate()
    {
      Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired", nameof (IRacingWheelTemplate));
      IRacingWheelTemplate.NativeMethodInfoPtr_get_wheel_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100677458);
      IRacingWheelTemplate.NativeMethodInfoPtr_get_accelerator_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100677459);
      IRacingWheelTemplate.NativeMethodInfoPtr_get_brake_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100677460);
      IRacingWheelTemplate.NativeMethodInfoPtr_get_clutch_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100677461);
      IRacingWheelTemplate.NativeMethodInfoPtr_get_shiftDown_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100677462);
      IRacingWheelTemplate.NativeMethodInfoPtr_get_shiftUp_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100677463);
      IRacingWheelTemplate.NativeMethodInfoPtr_get_wheelButton1_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100677464);
      IRacingWheelTemplate.NativeMethodInfoPtr_get_wheelButton2_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100677465);
      IRacingWheelTemplate.NativeMethodInfoPtr_get_wheelButton3_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100677466);
      IRacingWheelTemplate.NativeMethodInfoPtr_get_wheelButton4_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100677467);
      IRacingWheelTemplate.NativeMethodInfoPtr_get_wheelButton5_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100677468);
      IRacingWheelTemplate.NativeMethodInfoPtr_get_wheelButton6_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100677469);
      IRacingWheelTemplate.NativeMethodInfoPtr_get_wheelButton7_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100677470);
      IRacingWheelTemplate.NativeMethodInfoPtr_get_wheelButton8_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100677471);
      IRacingWheelTemplate.NativeMethodInfoPtr_get_wheelButton9_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100677472);
      IRacingWheelTemplate.NativeMethodInfoPtr_get_wheelButton10_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100677473);
      IRacingWheelTemplate.NativeMethodInfoPtr_get_consoleButton1_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100677474);
      IRacingWheelTemplate.NativeMethodInfoPtr_get_consoleButton2_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100677475);
      IRacingWheelTemplate.NativeMethodInfoPtr_get_consoleButton3_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100677476);
      IRacingWheelTemplate.NativeMethodInfoPtr_get_consoleButton4_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100677477);
      IRacingWheelTemplate.NativeMethodInfoPtr_get_consoleButton5_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100677478);
      IRacingWheelTemplate.NativeMethodInfoPtr_get_consoleButton6_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100677479);
      IRacingWheelTemplate.NativeMethodInfoPtr_get_consoleButton7_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100677480);
      IRacingWheelTemplate.NativeMethodInfoPtr_get_consoleButton8_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100677481);
      IRacingWheelTemplate.NativeMethodInfoPtr_get_consoleButton9_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100677482);
      IRacingWheelTemplate.NativeMethodInfoPtr_get_consoleButton10_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100677483);
      IRacingWheelTemplate.NativeMethodInfoPtr_get_shifter1_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100677484);
      IRacingWheelTemplate.NativeMethodInfoPtr_get_shifter2_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100677485);
      IRacingWheelTemplate.NativeMethodInfoPtr_get_shifter3_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100677486);
      IRacingWheelTemplate.NativeMethodInfoPtr_get_shifter4_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100677487);
      IRacingWheelTemplate.NativeMethodInfoPtr_get_shifter5_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100677488);
      IRacingWheelTemplate.NativeMethodInfoPtr_get_shifter6_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100677489);
      IRacingWheelTemplate.NativeMethodInfoPtr_get_shifter7_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100677490);
      IRacingWheelTemplate.NativeMethodInfoPtr_get_shifter8_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100677491);
      IRacingWheelTemplate.NativeMethodInfoPtr_get_shifter9_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100677492);
      IRacingWheelTemplate.NativeMethodInfoPtr_get_shifter10_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100677493);
      IRacingWheelTemplate.NativeMethodInfoPtr_get_reverseGear_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100677494);
      IRacingWheelTemplate.NativeMethodInfoPtr_get_select_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100677495);
      IRacingWheelTemplate.NativeMethodInfoPtr_get_start_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100677496);
      IRacingWheelTemplate.NativeMethodInfoPtr_get_systemButton_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100677497);
      IRacingWheelTemplate.NativeMethodInfoPtr_get_horn_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100677498);
      IRacingWheelTemplate.NativeMethodInfoPtr_get_dPad_Public_Abstract_Virtual_New_get_IControllerTemplateDPad_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100677499);
    }

    public IRacingWheelTemplate(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
