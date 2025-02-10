// Decompiled with JetBrains decompiler
// Type: Rewired.GamepadTemplate
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
  public sealed class GamepadTemplate : ControllerTemplate
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_typeGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftStickX;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftStickY;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightStickX;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightStickY;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_actionBottomRow1;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_a;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_actionBottomRow2;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_b;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_actionBottomRow3;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_c;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_actionTopRow1;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_x;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_actionTopRow2;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_y;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_actionTopRow3;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_z;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftShoulder1;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftBumper;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftShoulder2;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftTrigger;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightShoulder1;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightBumper;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightShoulder2;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightTrigger;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_center1;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_back;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_center2;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_start;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_center3;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_guide;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftStickButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightStickButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_dPadUp;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_dPadRight;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_dPadDown;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_dPadLeft;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftStick;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightStick;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_dPad;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionBottomRow1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_a_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionBottomRow2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_b_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionBottomRow3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_c_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionTopRow1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_x_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionTopRow2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_y_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionTopRow3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_z_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftShoulder1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftBumper_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftShoulder2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftTrigger_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightShoulder1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightBumper_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightShoulder2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightTrigger_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_center1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_back_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_center2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_start_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_center3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_guide_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftStick_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightStick_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_dPad_Private_Virtual_Final_New_get_IControllerTemplateDPad_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

    public virtual unsafe IControllerTemplateButton Rewired\u002EIGamepadTemplate\u002EactionBottomRow1
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136896, XrefRangeEnd = 136899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionBottomRow1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIGamepadTemplate\u002Ea
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136899, XrefRangeEnd = 136902, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_a_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIGamepadTemplate\u002EactionBottomRow2
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136902, XrefRangeEnd = 136905, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionBottomRow2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIGamepadTemplate\u002Eb
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136905, XrefRangeEnd = 136908, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_b_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIGamepadTemplate\u002EactionBottomRow3
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136908, XrefRangeEnd = 136911, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionBottomRow3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIGamepadTemplate\u002Ec
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136911, XrefRangeEnd = 136914, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_c_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIGamepadTemplate\u002EactionTopRow1
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136914, XrefRangeEnd = 136917, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionTopRow1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIGamepadTemplate\u002Ex
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136917, XrefRangeEnd = 136920, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_x_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIGamepadTemplate\u002EactionTopRow2
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136920, XrefRangeEnd = 136923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionTopRow2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIGamepadTemplate\u002Ey
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136923, XrefRangeEnd = 136926, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_y_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIGamepadTemplate\u002EactionTopRow3
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136926, XrefRangeEnd = 136929, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionTopRow3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIGamepadTemplate\u002Ez
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136929, XrefRangeEnd = 136937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_z_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIGamepadTemplate\u002EleftShoulder1
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136937, XrefRangeEnd = 136940, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftShoulder1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIGamepadTemplate\u002EleftBumper
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136940, XrefRangeEnd = 136943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftBumper_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateAxis Rewired\u002EIGamepadTemplate\u002EleftShoulder2
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136943, XrefRangeEnd = 136946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftShoulder2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateAxis) null : new IControllerTemplateAxis(pointer);
      }
    }

    public virtual unsafe IControllerTemplateAxis Rewired\u002EIGamepadTemplate\u002EleftTrigger
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136946, XrefRangeEnd = 136949, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftTrigger_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateAxis) null : new IControllerTemplateAxis(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIGamepadTemplate\u002ErightShoulder1
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136949, XrefRangeEnd = 136952, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightShoulder1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIGamepadTemplate\u002ErightBumper
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136952, XrefRangeEnd = 136955, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightBumper_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateAxis Rewired\u002EIGamepadTemplate\u002ErightShoulder2
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136955, XrefRangeEnd = 136958, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightShoulder2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateAxis) null : new IControllerTemplateAxis(pointer);
      }
    }

    public virtual unsafe IControllerTemplateAxis Rewired\u002EIGamepadTemplate\u002ErightTrigger
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136958, XrefRangeEnd = 136961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightTrigger_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateAxis) null : new IControllerTemplateAxis(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIGamepadTemplate\u002Ecenter1
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136961, XrefRangeEnd = 136964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_center1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIGamepadTemplate\u002Eback
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136964, XrefRangeEnd = 136967, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_back_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIGamepadTemplate\u002Ecenter2
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136967, XrefRangeEnd = 136970, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_center2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIGamepadTemplate\u002Estart
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136970, XrefRangeEnd = 136973, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_start_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIGamepadTemplate\u002Ecenter3
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136973, XrefRangeEnd = 136976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_center3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIGamepadTemplate\u002Eguide
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136976, XrefRangeEnd = 136979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_guide_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateThumbStick Rewired\u002EIGamepadTemplate\u002EleftStick
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136979, XrefRangeEnd = 136982, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftStick_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateThumbStick) null : new IControllerTemplateThumbStick(pointer);
      }
    }

    public virtual unsafe IControllerTemplateThumbStick Rewired\u002EIGamepadTemplate\u002ErightStick
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136982, XrefRangeEnd = 136985, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightStick_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateThumbStick) null : new IControllerTemplateThumbStick(pointer);
      }
    }

    public virtual unsafe IControllerTemplateDPad Rewired\u002EIGamepadTemplate\u002EdPad
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136985, XrefRangeEnd = 136988, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_dPad_Private_Virtual_Final_New_get_IControllerTemplateDPad_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateDPad) null : new IControllerTemplateDPad(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136988, XrefRangeEnd = 136989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GamepadTemplate(Il2CppSystem.Object payload)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) payload)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GamepadTemplate()
    {
      Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired", nameof (GamepadTemplate));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr);
      GamepadTemplate.NativeFieldInfoPtr_typeGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, nameof (typeGuid));
      GamepadTemplate.NativeFieldInfoPtr_elementId_leftStickX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, nameof (elementId_leftStickX));
      GamepadTemplate.NativeFieldInfoPtr_elementId_leftStickY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, nameof (elementId_leftStickY));
      GamepadTemplate.NativeFieldInfoPtr_elementId_rightStickX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, nameof (elementId_rightStickX));
      GamepadTemplate.NativeFieldInfoPtr_elementId_rightStickY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, nameof (elementId_rightStickY));
      GamepadTemplate.NativeFieldInfoPtr_elementId_actionBottomRow1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, nameof (elementId_actionBottomRow1));
      GamepadTemplate.NativeFieldInfoPtr_elementId_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, nameof (elementId_a));
      GamepadTemplate.NativeFieldInfoPtr_elementId_actionBottomRow2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, nameof (elementId_actionBottomRow2));
      GamepadTemplate.NativeFieldInfoPtr_elementId_b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, nameof (elementId_b));
      GamepadTemplate.NativeFieldInfoPtr_elementId_actionBottomRow3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, nameof (elementId_actionBottomRow3));
      GamepadTemplate.NativeFieldInfoPtr_elementId_c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, nameof (elementId_c));
      GamepadTemplate.NativeFieldInfoPtr_elementId_actionTopRow1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, nameof (elementId_actionTopRow1));
      GamepadTemplate.NativeFieldInfoPtr_elementId_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, nameof (elementId_x));
      GamepadTemplate.NativeFieldInfoPtr_elementId_actionTopRow2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, nameof (elementId_actionTopRow2));
      GamepadTemplate.NativeFieldInfoPtr_elementId_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, nameof (elementId_y));
      GamepadTemplate.NativeFieldInfoPtr_elementId_actionTopRow3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, nameof (elementId_actionTopRow3));
      GamepadTemplate.NativeFieldInfoPtr_elementId_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, nameof (elementId_z));
      GamepadTemplate.NativeFieldInfoPtr_elementId_leftShoulder1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, nameof (elementId_leftShoulder1));
      GamepadTemplate.NativeFieldInfoPtr_elementId_leftBumper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, nameof (elementId_leftBumper));
      GamepadTemplate.NativeFieldInfoPtr_elementId_leftShoulder2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, nameof (elementId_leftShoulder2));
      GamepadTemplate.NativeFieldInfoPtr_elementId_leftTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, nameof (elementId_leftTrigger));
      GamepadTemplate.NativeFieldInfoPtr_elementId_rightShoulder1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, nameof (elementId_rightShoulder1));
      GamepadTemplate.NativeFieldInfoPtr_elementId_rightBumper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, nameof (elementId_rightBumper));
      GamepadTemplate.NativeFieldInfoPtr_elementId_rightShoulder2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, nameof (elementId_rightShoulder2));
      GamepadTemplate.NativeFieldInfoPtr_elementId_rightTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, nameof (elementId_rightTrigger));
      GamepadTemplate.NativeFieldInfoPtr_elementId_center1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, nameof (elementId_center1));
      GamepadTemplate.NativeFieldInfoPtr_elementId_back = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, nameof (elementId_back));
      GamepadTemplate.NativeFieldInfoPtr_elementId_center2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, nameof (elementId_center2));
      GamepadTemplate.NativeFieldInfoPtr_elementId_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, nameof (elementId_start));
      GamepadTemplate.NativeFieldInfoPtr_elementId_center3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, nameof (elementId_center3));
      GamepadTemplate.NativeFieldInfoPtr_elementId_guide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, nameof (elementId_guide));
      GamepadTemplate.NativeFieldInfoPtr_elementId_leftStickButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, nameof (elementId_leftStickButton));
      GamepadTemplate.NativeFieldInfoPtr_elementId_rightStickButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, nameof (elementId_rightStickButton));
      GamepadTemplate.NativeFieldInfoPtr_elementId_dPadUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, nameof (elementId_dPadUp));
      GamepadTemplate.NativeFieldInfoPtr_elementId_dPadRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, nameof (elementId_dPadRight));
      GamepadTemplate.NativeFieldInfoPtr_elementId_dPadDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, nameof (elementId_dPadDown));
      GamepadTemplate.NativeFieldInfoPtr_elementId_dPadLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, nameof (elementId_dPadLeft));
      GamepadTemplate.NativeFieldInfoPtr_elementId_leftStick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, nameof (elementId_leftStick));
      GamepadTemplate.NativeFieldInfoPtr_elementId_rightStick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, nameof (elementId_rightStick));
      GamepadTemplate.NativeFieldInfoPtr_elementId_dPad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, nameof (elementId_dPad));
      GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionBottomRow1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100677681);
      GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_a_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100677682);
      GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionBottomRow2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100677683);
      GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_b_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100677684);
      GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionBottomRow3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100677685);
      GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_c_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100677686);
      GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionTopRow1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100677687);
      GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_x_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100677688);
      GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionTopRow2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100677689);
      GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_y_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100677690);
      GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionTopRow3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100677691);
      GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_z_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100677692);
      GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftShoulder1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100677693);
      GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftBumper_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100677694);
      GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftShoulder2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100677695);
      GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftTrigger_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100677696);
      GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightShoulder1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100677697);
      GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightBumper_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100677698);
      GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightShoulder2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100677699);
      GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightTrigger_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100677700);
      GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_center1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100677701);
      GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_back_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100677702);
      GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_center2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100677703);
      GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_start_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100677704);
      GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_center3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100677705);
      GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_guide_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100677706);
      GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftStick_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100677707);
      GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightStick_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100677708);
      GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_dPad_Private_Virtual_Final_New_get_IControllerTemplateDPad_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100677709);
      GamepadTemplate.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100677710);
    }

    public GamepadTemplate(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe Il2CppSystem.Guid typeGuid
    {
      get
      {
        Il2CppSystem.Guid typeGuid;
        IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_typeGuid, (void*) &typeGuid);
        return typeGuid;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_typeGuid, (void*) &value);
      }
    }

    public static unsafe int elementId_leftStickX
    {
      get
      {
        int elementIdLeftStickX;
        IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_leftStickX, (void*) &elementIdLeftStickX);
        return elementIdLeftStickX;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_leftStickX, (void*) &value);
      }
    }

    public static unsafe int elementId_leftStickY
    {
      get
      {
        int elementIdLeftStickY;
        IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_leftStickY, (void*) &elementIdLeftStickY);
        return elementIdLeftStickY;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_leftStickY, (void*) &value);
      }
    }

    public static unsafe int elementId_rightStickX
    {
      get
      {
        int elementIdRightStickX;
        IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_rightStickX, (void*) &elementIdRightStickX);
        return elementIdRightStickX;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_rightStickX, (void*) &value);
      }
    }

    public static unsafe int elementId_rightStickY
    {
      get
      {
        int elementIdRightStickY;
        IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_rightStickY, (void*) &elementIdRightStickY);
        return elementIdRightStickY;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_rightStickY, (void*) &value);
      }
    }

    public static unsafe int elementId_actionBottomRow1
    {
      get
      {
        int actionBottomRow1;
        IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_actionBottomRow1, (void*) &actionBottomRow1);
        return actionBottomRow1;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_actionBottomRow1, (void*) &value);
      }
    }

    public static unsafe int elementId_a
    {
      get
      {
        int elementIdA;
        IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_a, (void*) &elementIdA);
        return elementIdA;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_a, (void*) &value);
      }
    }

    public static unsafe int elementId_actionBottomRow2
    {
      get
      {
        int actionBottomRow2;
        IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_actionBottomRow2, (void*) &actionBottomRow2);
        return actionBottomRow2;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_actionBottomRow2, (void*) &value);
      }
    }

    public static unsafe int elementId_b
    {
      get
      {
        int elementIdB;
        IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_b, (void*) &elementIdB);
        return elementIdB;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_b, (void*) &value);
      }
    }

    public static unsafe int elementId_actionBottomRow3
    {
      get
      {
        int actionBottomRow3;
        IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_actionBottomRow3, (void*) &actionBottomRow3);
        return actionBottomRow3;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_actionBottomRow3, (void*) &value);
      }
    }

    public static unsafe int elementId_c
    {
      get
      {
        int elementIdC;
        IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_c, (void*) &elementIdC);
        return elementIdC;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_c, (void*) &value);
      }
    }

    public static unsafe int elementId_actionTopRow1
    {
      get
      {
        int elementIdActionTopRow1;
        IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_actionTopRow1, (void*) &elementIdActionTopRow1);
        return elementIdActionTopRow1;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_actionTopRow1, (void*) &value);
      }
    }

    public static unsafe int elementId_x
    {
      get
      {
        int elementIdX;
        IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_x, (void*) &elementIdX);
        return elementIdX;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_x, (void*) &value);
      }
    }

    public static unsafe int elementId_actionTopRow2
    {
      get
      {
        int elementIdActionTopRow2;
        IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_actionTopRow2, (void*) &elementIdActionTopRow2);
        return elementIdActionTopRow2;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_actionTopRow2, (void*) &value);
      }
    }

    public static unsafe int elementId_y
    {
      get
      {
        int elementIdY;
        IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_y, (void*) &elementIdY);
        return elementIdY;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_y, (void*) &value);
      }
    }

    public static unsafe int elementId_actionTopRow3
    {
      get
      {
        int elementIdActionTopRow3;
        IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_actionTopRow3, (void*) &elementIdActionTopRow3);
        return elementIdActionTopRow3;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_actionTopRow3, (void*) &value);
      }
    }

    public static unsafe int elementId_z
    {
      get
      {
        int elementIdZ;
        IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_z, (void*) &elementIdZ);
        return elementIdZ;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_z, (void*) &value);
      }
    }

    public static unsafe int elementId_leftShoulder1
    {
      get
      {
        int elementIdLeftShoulder1;
        IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_leftShoulder1, (void*) &elementIdLeftShoulder1);
        return elementIdLeftShoulder1;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_leftShoulder1, (void*) &value);
      }
    }

    public static unsafe int elementId_leftBumper
    {
      get
      {
        int elementIdLeftBumper;
        IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_leftBumper, (void*) &elementIdLeftBumper);
        return elementIdLeftBumper;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_leftBumper, (void*) &value);
      }
    }

    public static unsafe int elementId_leftShoulder2
    {
      get
      {
        int elementIdLeftShoulder2;
        IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_leftShoulder2, (void*) &elementIdLeftShoulder2);
        return elementIdLeftShoulder2;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_leftShoulder2, (void*) &value);
      }
    }

    public static unsafe int elementId_leftTrigger
    {
      get
      {
        int elementIdLeftTrigger;
        IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_leftTrigger, (void*) &elementIdLeftTrigger);
        return elementIdLeftTrigger;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_leftTrigger, (void*) &value);
      }
    }

    public static unsafe int elementId_rightShoulder1
    {
      get
      {
        int idRightShoulder1;
        IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_rightShoulder1, (void*) &idRightShoulder1);
        return idRightShoulder1;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_rightShoulder1, (void*) &value);
      }
    }

    public static unsafe int elementId_rightBumper
    {
      get
      {
        int elementIdRightBumper;
        IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_rightBumper, (void*) &elementIdRightBumper);
        return elementIdRightBumper;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_rightBumper, (void*) &value);
      }
    }

    public static unsafe int elementId_rightShoulder2
    {
      get
      {
        int idRightShoulder2;
        IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_rightShoulder2, (void*) &idRightShoulder2);
        return idRightShoulder2;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_rightShoulder2, (void*) &value);
      }
    }

    public static unsafe int elementId_rightTrigger
    {
      get
      {
        int elementIdRightTrigger;
        IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_rightTrigger, (void*) &elementIdRightTrigger);
        return elementIdRightTrigger;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_rightTrigger, (void*) &value);
      }
    }

    public static unsafe int elementId_center1
    {
      get
      {
        int elementIdCenter1;
        IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_center1, (void*) &elementIdCenter1);
        return elementIdCenter1;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_center1, (void*) &value);
      }
    }

    public static unsafe int elementId_back
    {
      get
      {
        int elementIdBack;
        IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_back, (void*) &elementIdBack);
        return elementIdBack;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_back, (void*) &value);
      }
    }

    public static unsafe int elementId_center2
    {
      get
      {
        int elementIdCenter2;
        IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_center2, (void*) &elementIdCenter2);
        return elementIdCenter2;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_center2, (void*) &value);
      }
    }

    public static unsafe int elementId_start
    {
      get
      {
        int elementIdStart;
        IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_start, (void*) &elementIdStart);
        return elementIdStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_start, (void*) &value);
      }
    }

    public static unsafe int elementId_center3
    {
      get
      {
        int elementIdCenter3;
        IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_center3, (void*) &elementIdCenter3);
        return elementIdCenter3;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_center3, (void*) &value);
      }
    }

    public static unsafe int elementId_guide
    {
      get
      {
        int elementIdGuide;
        IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_guide, (void*) &elementIdGuide);
        return elementIdGuide;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_guide, (void*) &value);
      }
    }

    public static unsafe int elementId_leftStickButton
    {
      get
      {
        int idLeftStickButton;
        IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_leftStickButton, (void*) &idLeftStickButton);
        return idLeftStickButton;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_leftStickButton, (void*) &value);
      }
    }

    public static unsafe int elementId_rightStickButton
    {
      get
      {
        int rightStickButton;
        IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_rightStickButton, (void*) &rightStickButton);
        return rightStickButton;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_rightStickButton, (void*) &value);
      }
    }

    public static unsafe int elementId_dPadUp
    {
      get
      {
        int elementIdDPadUp;
        IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_dPadUp, (void*) &elementIdDPadUp);
        return elementIdDPadUp;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_dPadUp, (void*) &value);
      }
    }

    public static unsafe int elementId_dPadRight
    {
      get
      {
        int elementIdDPadRight;
        IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_dPadRight, (void*) &elementIdDPadRight);
        return elementIdDPadRight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_dPadRight, (void*) &value);
      }
    }

    public static unsafe int elementId_dPadDown
    {
      get
      {
        int elementIdDPadDown;
        IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_dPadDown, (void*) &elementIdDPadDown);
        return elementIdDPadDown;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_dPadDown, (void*) &value);
      }
    }

    public static unsafe int elementId_dPadLeft
    {
      get
      {
        int elementIdDPadLeft;
        IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_dPadLeft, (void*) &elementIdDPadLeft);
        return elementIdDPadLeft;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_dPadLeft, (void*) &value);
      }
    }

    public static unsafe int elementId_leftStick
    {
      get
      {
        int elementIdLeftStick;
        IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_leftStick, (void*) &elementIdLeftStick);
        return elementIdLeftStick;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_leftStick, (void*) &value);
      }
    }

    public static unsafe int elementId_rightStick
    {
      get
      {
        int elementIdRightStick;
        IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_rightStick, (void*) &elementIdRightStick);
        return elementIdRightStick;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_rightStick, (void*) &value);
      }
    }

    public static unsafe int elementId_dPad
    {
      get
      {
        int elementIdDPad;
        IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_dPad, (void*) &elementIdDPad);
        return elementIdDPad;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_dPad, (void*) &value);
      }
    }
  }
}
