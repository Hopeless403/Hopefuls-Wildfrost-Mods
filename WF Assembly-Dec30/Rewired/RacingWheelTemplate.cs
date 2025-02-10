// Decompiled with JetBrains decompiler
// Type: Rewired.RacingWheelTemplate
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
  public sealed class RacingWheelTemplate : ControllerTemplate
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_typeGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheel;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_accelerator;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_brake;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_clutch;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_shiftDown;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_shiftUp;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheelButton1;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheelButton2;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheelButton3;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheelButton4;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheelButton5;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheelButton6;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheelButton7;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheelButton8;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheelButton9;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheelButton10;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_consoleButton1;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_consoleButton2;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_consoleButton3;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_consoleButton4;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_consoleButton5;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_consoleButton6;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_consoleButton7;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_consoleButton8;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_consoleButton9;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_consoleButton10;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_shifter1;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_shifter2;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_shifter3;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_shifter4;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_shifter5;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_shifter6;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_shifter7;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_shifter8;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_shifter9;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_shifter10;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_reverseGear;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_select;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_start;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_systemButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_horn;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_dPadUp;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_dPadRight;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_dPadDown;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_dPadLeft;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_dPad;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheel_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_accelerator_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_brake_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_clutch_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shiftDown_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shiftUp_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter4_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter5_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter6_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter7_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter8_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter9_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter10_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_reverseGear_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_select_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_start_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_systemButton_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_horn_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_dPad_Private_Virtual_Final_New_get_IControllerTemplateDPad_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

    public virtual unsafe IControllerTemplateAxis Rewired\u002EIRacingWheelTemplate\u002Ewheel
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136989, XrefRangeEnd = 136997, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheel_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateAxis) null : new IControllerTemplateAxis(pointer);
      }
    }

    public virtual unsafe IControllerTemplateAxis Rewired\u002EIRacingWheelTemplate\u002Eaccelerator
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136997, XrefRangeEnd = 137000, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_accelerator_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateAxis) null : new IControllerTemplateAxis(pointer);
      }
    }

    public virtual unsafe IControllerTemplateAxis Rewired\u002EIRacingWheelTemplate\u002Ebrake
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137000, XrefRangeEnd = 137003, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_brake_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateAxis) null : new IControllerTemplateAxis(pointer);
      }
    }

    public virtual unsafe IControllerTemplateAxis Rewired\u002EIRacingWheelTemplate\u002Eclutch
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137003, XrefRangeEnd = 137006, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_clutch_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateAxis) null : new IControllerTemplateAxis(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002EshiftDown
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137006, XrefRangeEnd = 137009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shiftDown_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002EshiftUp
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137009, XrefRangeEnd = 137012, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shiftUp_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002EwheelButton1
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137012, XrefRangeEnd = 137015, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002EwheelButton2
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137015, XrefRangeEnd = 137018, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002EwheelButton3
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137018, XrefRangeEnd = 137021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002EwheelButton4
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137021, XrefRangeEnd = 137024, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002EwheelButton5
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137024, XrefRangeEnd = 137027, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002EwheelButton6
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137027, XrefRangeEnd = 137030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002EwheelButton7
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137030, XrefRangeEnd = 137033, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002EwheelButton8
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137033, XrefRangeEnd = 137036, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002EwheelButton9
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137036, XrefRangeEnd = 137039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002EwheelButton10
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137039, XrefRangeEnd = 137042, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002EconsoleButton1
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137042, XrefRangeEnd = 137045, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002EconsoleButton2
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137045, XrefRangeEnd = 137048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002EconsoleButton3
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137048, XrefRangeEnd = 137051, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002EconsoleButton4
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137051, XrefRangeEnd = 137054, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002EconsoleButton5
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137054, XrefRangeEnd = 137057, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002EconsoleButton6
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137057, XrefRangeEnd = 137060, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002EconsoleButton7
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137060, XrefRangeEnd = 137063, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002EconsoleButton8
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137063, XrefRangeEnd = 137066, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002EconsoleButton9
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137066, XrefRangeEnd = 137069, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002EconsoleButton10
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137069, XrefRangeEnd = 137072, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002Eshifter1
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137072, XrefRangeEnd = 137075, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002Eshifter2
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137075, XrefRangeEnd = 137078, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002Eshifter3
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137078, XrefRangeEnd = 137081, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002Eshifter4
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137081, XrefRangeEnd = 137084, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter4_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002Eshifter5
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137084, XrefRangeEnd = 137087, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter5_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002Eshifter6
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137087, XrefRangeEnd = 137090, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter6_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002Eshifter7
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137090, XrefRangeEnd = 137093, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter7_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002Eshifter8
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137093, XrefRangeEnd = 137096, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter8_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002Eshifter9
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137096, XrefRangeEnd = 137099, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter9_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002Eshifter10
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137099, XrefRangeEnd = 137102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter10_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002EreverseGear
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137102, XrefRangeEnd = 137105, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_reverseGear_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002Eselect
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137105, XrefRangeEnd = 137108, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_select_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002Estart
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137108, XrefRangeEnd = 137111, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_start_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002EsystemButton
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137111, XrefRangeEnd = 137114, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_systemButton_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIRacingWheelTemplate\u002Ehorn
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137114, XrefRangeEnd = 137117, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_horn_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateDPad Rewired\u002EIRacingWheelTemplate\u002EdPad
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137117, XrefRangeEnd = 137120, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_dPad_Private_Virtual_Final_New_get_IControllerTemplateDPad_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateDPad) null : new IControllerTemplateDPad(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RacingWheelTemplate(Il2CppSystem.Object payload)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) payload)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RacingWheelTemplate()
    {
      Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired", nameof (RacingWheelTemplate));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr);
      RacingWheelTemplate.NativeFieldInfoPtr_typeGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (typeGuid));
      RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_wheel));
      RacingWheelTemplate.NativeFieldInfoPtr_elementId_accelerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_accelerator));
      RacingWheelTemplate.NativeFieldInfoPtr_elementId_brake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_brake));
      RacingWheelTemplate.NativeFieldInfoPtr_elementId_clutch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_clutch));
      RacingWheelTemplate.NativeFieldInfoPtr_elementId_shiftDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_shiftDown));
      RacingWheelTemplate.NativeFieldInfoPtr_elementId_shiftUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_shiftUp));
      RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_wheelButton1));
      RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_wheelButton2));
      RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_wheelButton3));
      RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_wheelButton4));
      RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_wheelButton5));
      RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_wheelButton6));
      RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_wheelButton7));
      RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_wheelButton8));
      RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_wheelButton9));
      RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_wheelButton10));
      RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_consoleButton1));
      RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_consoleButton2));
      RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_consoleButton3));
      RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_consoleButton4));
      RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_consoleButton5));
      RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_consoleButton6));
      RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_consoleButton7));
      RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_consoleButton8));
      RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_consoleButton9));
      RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_consoleButton10));
      RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_shifter1));
      RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_shifter2));
      RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_shifter3));
      RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_shifter4));
      RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_shifter5));
      RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_shifter6));
      RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_shifter7));
      RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_shifter8));
      RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_shifter9));
      RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_shifter10));
      RacingWheelTemplate.NativeFieldInfoPtr_elementId_reverseGear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_reverseGear));
      RacingWheelTemplate.NativeFieldInfoPtr_elementId_select = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_select));
      RacingWheelTemplate.NativeFieldInfoPtr_elementId_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_start));
      RacingWheelTemplate.NativeFieldInfoPtr_elementId_systemButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_systemButton));
      RacingWheelTemplate.NativeFieldInfoPtr_elementId_horn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_horn));
      RacingWheelTemplate.NativeFieldInfoPtr_elementId_dPadUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_dPadUp));
      RacingWheelTemplate.NativeFieldInfoPtr_elementId_dPadRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_dPadRight));
      RacingWheelTemplate.NativeFieldInfoPtr_elementId_dPadDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_dPadDown));
      RacingWheelTemplate.NativeFieldInfoPtr_elementId_dPadLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_dPadLeft));
      RacingWheelTemplate.NativeFieldInfoPtr_elementId_dPad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, nameof (elementId_dPad));
      RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheel_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100677712);
      RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_accelerator_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100677713);
      RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_brake_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100677714);
      RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_clutch_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100677715);
      RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shiftDown_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100677716);
      RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shiftUp_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100677717);
      RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100677718);
      RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100677719);
      RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100677720);
      RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100677721);
      RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100677722);
      RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100677723);
      RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100677724);
      RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100677725);
      RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100677726);
      RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100677727);
      RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100677728);
      RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100677729);
      RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100677730);
      RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100677731);
      RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100677732);
      RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100677733);
      RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100677734);
      RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100677735);
      RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100677736);
      RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100677737);
      RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100677738);
      RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100677739);
      RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100677740);
      RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter4_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100677741);
      RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter5_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100677742);
      RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter6_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100677743);
      RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter7_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100677744);
      RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter8_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100677745);
      RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter9_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100677746);
      RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter10_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100677747);
      RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_reverseGear_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100677748);
      RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_select_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100677749);
      RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_start_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100677750);
      RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_systemButton_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100677751);
      RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_horn_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100677752);
      RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_dPad_Private_Virtual_Final_New_get_IControllerTemplateDPad_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100677753);
      RacingWheelTemplate.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100677754);
    }

    public RacingWheelTemplate(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe Il2CppSystem.Guid typeGuid
    {
      get
      {
        Il2CppSystem.Guid typeGuid;
        IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_typeGuid, (void*) &typeGuid);
        return typeGuid;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_typeGuid, (void*) &value);
      }
    }

    public static unsafe int elementId_wheel
    {
      get
      {
        int elementIdWheel;
        IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheel, (void*) &elementIdWheel);
        return elementIdWheel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheel, (void*) &value);
      }
    }

    public static unsafe int elementId_accelerator
    {
      get
      {
        int elementIdAccelerator;
        IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_accelerator, (void*) &elementIdAccelerator);
        return elementIdAccelerator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_accelerator, (void*) &value);
      }
    }

    public static unsafe int elementId_brake
    {
      get
      {
        int elementIdBrake;
        IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_brake, (void*) &elementIdBrake);
        return elementIdBrake;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_brake, (void*) &value);
      }
    }

    public static unsafe int elementId_clutch
    {
      get
      {
        int elementIdClutch;
        IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_clutch, (void*) &elementIdClutch);
        return elementIdClutch;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_clutch, (void*) &value);
      }
    }

    public static unsafe int elementId_shiftDown
    {
      get
      {
        int elementIdShiftDown;
        IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shiftDown, (void*) &elementIdShiftDown);
        return elementIdShiftDown;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shiftDown, (void*) &value);
      }
    }

    public static unsafe int elementId_shiftUp
    {
      get
      {
        int elementIdShiftUp;
        IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shiftUp, (void*) &elementIdShiftUp);
        return elementIdShiftUp;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shiftUp, (void*) &value);
      }
    }

    public static unsafe int elementId_wheelButton1
    {
      get
      {
        int elementIdWheelButton1;
        IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton1, (void*) &elementIdWheelButton1);
        return elementIdWheelButton1;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton1, (void*) &value);
      }
    }

    public static unsafe int elementId_wheelButton2
    {
      get
      {
        int elementIdWheelButton2;
        IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton2, (void*) &elementIdWheelButton2);
        return elementIdWheelButton2;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton2, (void*) &value);
      }
    }

    public static unsafe int elementId_wheelButton3
    {
      get
      {
        int elementIdWheelButton3;
        IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton3, (void*) &elementIdWheelButton3);
        return elementIdWheelButton3;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton3, (void*) &value);
      }
    }

    public static unsafe int elementId_wheelButton4
    {
      get
      {
        int elementIdWheelButton4;
        IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton4, (void*) &elementIdWheelButton4);
        return elementIdWheelButton4;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton4, (void*) &value);
      }
    }

    public static unsafe int elementId_wheelButton5
    {
      get
      {
        int elementIdWheelButton5;
        IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton5, (void*) &elementIdWheelButton5);
        return elementIdWheelButton5;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton5, (void*) &value);
      }
    }

    public static unsafe int elementId_wheelButton6
    {
      get
      {
        int elementIdWheelButton6;
        IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton6, (void*) &elementIdWheelButton6);
        return elementIdWheelButton6;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton6, (void*) &value);
      }
    }

    public static unsafe int elementId_wheelButton7
    {
      get
      {
        int elementIdWheelButton7;
        IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton7, (void*) &elementIdWheelButton7);
        return elementIdWheelButton7;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton7, (void*) &value);
      }
    }

    public static unsafe int elementId_wheelButton8
    {
      get
      {
        int elementIdWheelButton8;
        IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton8, (void*) &elementIdWheelButton8);
        return elementIdWheelButton8;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton8, (void*) &value);
      }
    }

    public static unsafe int elementId_wheelButton9
    {
      get
      {
        int elementIdWheelButton9;
        IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton9, (void*) &elementIdWheelButton9);
        return elementIdWheelButton9;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton9, (void*) &value);
      }
    }

    public static unsafe int elementId_wheelButton10
    {
      get
      {
        int elementIdWheelButton10;
        IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton10, (void*) &elementIdWheelButton10);
        return elementIdWheelButton10;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton10, (void*) &value);
      }
    }

    public static unsafe int elementId_consoleButton1
    {
      get
      {
        int idConsoleButton1;
        IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton1, (void*) &idConsoleButton1);
        return idConsoleButton1;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton1, (void*) &value);
      }
    }

    public static unsafe int elementId_consoleButton2
    {
      get
      {
        int idConsoleButton2;
        IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton2, (void*) &idConsoleButton2);
        return idConsoleButton2;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton2, (void*) &value);
      }
    }

    public static unsafe int elementId_consoleButton3
    {
      get
      {
        int idConsoleButton3;
        IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton3, (void*) &idConsoleButton3);
        return idConsoleButton3;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton3, (void*) &value);
      }
    }

    public static unsafe int elementId_consoleButton4
    {
      get
      {
        int idConsoleButton4;
        IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton4, (void*) &idConsoleButton4);
        return idConsoleButton4;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton4, (void*) &value);
      }
    }

    public static unsafe int elementId_consoleButton5
    {
      get
      {
        int idConsoleButton5;
        IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton5, (void*) &idConsoleButton5);
        return idConsoleButton5;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton5, (void*) &value);
      }
    }

    public static unsafe int elementId_consoleButton6
    {
      get
      {
        int idConsoleButton6;
        IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton6, (void*) &idConsoleButton6);
        return idConsoleButton6;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton6, (void*) &value);
      }
    }

    public static unsafe int elementId_consoleButton7
    {
      get
      {
        int idConsoleButton7;
        IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton7, (void*) &idConsoleButton7);
        return idConsoleButton7;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton7, (void*) &value);
      }
    }

    public static unsafe int elementId_consoleButton8
    {
      get
      {
        int idConsoleButton8;
        IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton8, (void*) &idConsoleButton8);
        return idConsoleButton8;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton8, (void*) &value);
      }
    }

    public static unsafe int elementId_consoleButton9
    {
      get
      {
        int idConsoleButton9;
        IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton9, (void*) &idConsoleButton9);
        return idConsoleButton9;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton9, (void*) &value);
      }
    }

    public static unsafe int elementId_consoleButton10
    {
      get
      {
        int idConsoleButton10;
        IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton10, (void*) &idConsoleButton10);
        return idConsoleButton10;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton10, (void*) &value);
      }
    }

    public static unsafe int elementId_shifter1
    {
      get
      {
        int elementIdShifter1;
        IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter1, (void*) &elementIdShifter1);
        return elementIdShifter1;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter1, (void*) &value);
      }
    }

    public static unsafe int elementId_shifter2
    {
      get
      {
        int elementIdShifter2;
        IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter2, (void*) &elementIdShifter2);
        return elementIdShifter2;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter2, (void*) &value);
      }
    }

    public static unsafe int elementId_shifter3
    {
      get
      {
        int elementIdShifter3;
        IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter3, (void*) &elementIdShifter3);
        return elementIdShifter3;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter3, (void*) &value);
      }
    }

    public static unsafe int elementId_shifter4
    {
      get
      {
        int elementIdShifter4;
        IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter4, (void*) &elementIdShifter4);
        return elementIdShifter4;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter4, (void*) &value);
      }
    }

    public static unsafe int elementId_shifter5
    {
      get
      {
        int elementIdShifter5;
        IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter5, (void*) &elementIdShifter5);
        return elementIdShifter5;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter5, (void*) &value);
      }
    }

    public static unsafe int elementId_shifter6
    {
      get
      {
        int elementIdShifter6;
        IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter6, (void*) &elementIdShifter6);
        return elementIdShifter6;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter6, (void*) &value);
      }
    }

    public static unsafe int elementId_shifter7
    {
      get
      {
        int elementIdShifter7;
        IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter7, (void*) &elementIdShifter7);
        return elementIdShifter7;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter7, (void*) &value);
      }
    }

    public static unsafe int elementId_shifter8
    {
      get
      {
        int elementIdShifter8;
        IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter8, (void*) &elementIdShifter8);
        return elementIdShifter8;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter8, (void*) &value);
      }
    }

    public static unsafe int elementId_shifter9
    {
      get
      {
        int elementIdShifter9;
        IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter9, (void*) &elementIdShifter9);
        return elementIdShifter9;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter9, (void*) &value);
      }
    }

    public static unsafe int elementId_shifter10
    {
      get
      {
        int elementIdShifter10;
        IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter10, (void*) &elementIdShifter10);
        return elementIdShifter10;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter10, (void*) &value);
      }
    }

    public static unsafe int elementId_reverseGear
    {
      get
      {
        int elementIdReverseGear;
        IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_reverseGear, (void*) &elementIdReverseGear);
        return elementIdReverseGear;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_reverseGear, (void*) &value);
      }
    }

    public static unsafe int elementId_select
    {
      get
      {
        int elementIdSelect;
        IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_select, (void*) &elementIdSelect);
        return elementIdSelect;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_select, (void*) &value);
      }
    }

    public static unsafe int elementId_start
    {
      get
      {
        int elementIdStart;
        IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_start, (void*) &elementIdStart);
        return elementIdStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_start, (void*) &value);
      }
    }

    public static unsafe int elementId_systemButton
    {
      get
      {
        int elementIdSystemButton;
        IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_systemButton, (void*) &elementIdSystemButton);
        return elementIdSystemButton;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_systemButton, (void*) &value);
      }
    }

    public static unsafe int elementId_horn
    {
      get
      {
        int elementIdHorn;
        IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_horn, (void*) &elementIdHorn);
        return elementIdHorn;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_horn, (void*) &value);
      }
    }

    public static unsafe int elementId_dPadUp
    {
      get
      {
        int elementIdDPadUp;
        IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_dPadUp, (void*) &elementIdDPadUp);
        return elementIdDPadUp;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_dPadUp, (void*) &value);
      }
    }

    public static unsafe int elementId_dPadRight
    {
      get
      {
        int elementIdDPadRight;
        IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_dPadRight, (void*) &elementIdDPadRight);
        return elementIdDPadRight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_dPadRight, (void*) &value);
      }
    }

    public static unsafe int elementId_dPadDown
    {
      get
      {
        int elementIdDPadDown;
        IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_dPadDown, (void*) &elementIdDPadDown);
        return elementIdDPadDown;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_dPadDown, (void*) &value);
      }
    }

    public static unsafe int elementId_dPadLeft
    {
      get
      {
        int elementIdDPadLeft;
        IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_dPadLeft, (void*) &elementIdDPadLeft);
        return elementIdDPadLeft;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_dPadLeft, (void*) &value);
      }
    }

    public static unsafe int elementId_dPad
    {
      get
      {
        int elementIdDPad;
        IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_dPad, (void*) &elementIdDPad);
        return elementIdDPad;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_dPad, (void*) &value);
      }
    }
  }
}
