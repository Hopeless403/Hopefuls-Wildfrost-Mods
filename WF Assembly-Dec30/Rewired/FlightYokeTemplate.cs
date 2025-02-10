// Decompiled with JetBrains decompiler
// Type: Rewired.FlightYokeTemplate
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
  public sealed class FlightYokeTemplate : ControllerTemplate
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_typeGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rotateYoke;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_yokeZ;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftPaddle;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightPaddle;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_lever1Axis;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_lever1MinDetent;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_lever2Axis;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_lever2MinDetent;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_lever3Axis;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_lever3MinDetent;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_lever4Axis;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_lever4MinDetent;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_lever5Axis;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_lever5MinDetent;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftGripButton1;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftGripButton2;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftGripButton3;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftGripButton4;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftGripButton5;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftGripButton6;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightGripButton1;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightGripButton2;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightGripButton3;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightGripButton4;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightGripButton5;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightGripButton6;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_centerButton1;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_centerButton2;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_centerButton3;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_centerButton4;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_centerButton5;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_centerButton6;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_centerButton7;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_centerButton8;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheel1Up;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheel1Down;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheel1Press;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheel2Up;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheel2Down;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheel2Press;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftGripHatUp;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftGripHatUpRight;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftGripHatRight;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftGripHatDownRight;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftGripHatDown;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftGripHatDownLeft;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftGripHatLeft;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftGripHatUpLeft;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightGripHatUp;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightGripHatUpRight;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightGripHatRight;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightGripHatDownRight;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightGripHatDown;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightGripHatDownLeft;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightGripHatLeft;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightGripHatUpLeft;
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
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_mode1;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_mode2;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_mode3;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_yoke;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_lever1;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_lever2;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_lever3;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_lever4;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_lever5;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftGripHat;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightGripHat;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftPaddle_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightPaddle_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel1Up_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel1Down_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel1Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel2Up_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel2Down_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel2Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_mode1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_mode2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_mode3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_yoke_Private_Virtual_Final_New_get_IControllerTemplateYoke_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever1_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever2_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever3_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever4_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever5_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripHat_Private_Virtual_Final_New_get_IControllerTemplateHat_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripHat_Private_Virtual_Final_New_get_IControllerTemplateHat_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

    public virtual unsafe IControllerTemplateButton Rewired\u002EIFlightYokeTemplate\u002EleftPaddle
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137389, XrefRangeEnd = 137392, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftPaddle_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIFlightYokeTemplate\u002ErightPaddle
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137392, XrefRangeEnd = 137395, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightPaddle_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIFlightYokeTemplate\u002EleftGripButton1
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137395, XrefRangeEnd = 137398, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIFlightYokeTemplate\u002EleftGripButton2
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137398, XrefRangeEnd = 137401, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIFlightYokeTemplate\u002EleftGripButton3
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137401, XrefRangeEnd = 137404, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIFlightYokeTemplate\u002EleftGripButton4
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137404, XrefRangeEnd = 137407, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIFlightYokeTemplate\u002EleftGripButton5
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137407, XrefRangeEnd = 137410, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIFlightYokeTemplate\u002EleftGripButton6
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137410, XrefRangeEnd = 137413, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIFlightYokeTemplate\u002ErightGripButton1
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137413, XrefRangeEnd = 137416, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIFlightYokeTemplate\u002ErightGripButton2
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137416, XrefRangeEnd = 137419, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIFlightYokeTemplate\u002ErightGripButton3
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137419, XrefRangeEnd = 137422, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIFlightYokeTemplate\u002ErightGripButton4
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137422, XrefRangeEnd = 137425, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIFlightYokeTemplate\u002ErightGripButton5
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137425, XrefRangeEnd = 137428, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIFlightYokeTemplate\u002ErightGripButton6
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137428, XrefRangeEnd = 137431, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIFlightYokeTemplate\u002EcenterButton1
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137431, XrefRangeEnd = 137434, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIFlightYokeTemplate\u002EcenterButton2
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137434, XrefRangeEnd = 137437, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIFlightYokeTemplate\u002EcenterButton3
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137437, XrefRangeEnd = 137440, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIFlightYokeTemplate\u002EcenterButton4
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137440, XrefRangeEnd = 137443, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIFlightYokeTemplate\u002EcenterButton5
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137443, XrefRangeEnd = 137446, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIFlightYokeTemplate\u002EcenterButton6
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137446, XrefRangeEnd = 137449, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIFlightYokeTemplate\u002EcenterButton7
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137449, XrefRangeEnd = 137452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIFlightYokeTemplate\u002EcenterButton8
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137452, XrefRangeEnd = 137455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIFlightYokeTemplate\u002Ewheel1Up
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137455, XrefRangeEnd = 137458, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel1Up_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIFlightYokeTemplate\u002Ewheel1Down
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137458, XrefRangeEnd = 137461, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel1Down_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIFlightYokeTemplate\u002Ewheel1Press
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137461, XrefRangeEnd = 137464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel1Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIFlightYokeTemplate\u002Ewheel2Up
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137464, XrefRangeEnd = 137467, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel2Up_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIFlightYokeTemplate\u002Ewheel2Down
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137467, XrefRangeEnd = 137470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel2Down_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIFlightYokeTemplate\u002Ewheel2Press
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137470, XrefRangeEnd = 137473, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel2Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIFlightYokeTemplate\u002EconsoleButton1
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137473, XrefRangeEnd = 137476, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIFlightYokeTemplate\u002EconsoleButton2
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137476, XrefRangeEnd = 137479, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIFlightYokeTemplate\u002EconsoleButton3
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137479, XrefRangeEnd = 137482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIFlightYokeTemplate\u002EconsoleButton4
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137482, XrefRangeEnd = 137485, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIFlightYokeTemplate\u002EconsoleButton5
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137485, XrefRangeEnd = 137488, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIFlightYokeTemplate\u002EconsoleButton6
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137488, XrefRangeEnd = 137491, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIFlightYokeTemplate\u002EconsoleButton7
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137491, XrefRangeEnd = 137494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIFlightYokeTemplate\u002EconsoleButton8
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137494, XrefRangeEnd = 137497, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIFlightYokeTemplate\u002EconsoleButton9
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137497, XrefRangeEnd = 137500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIFlightYokeTemplate\u002EconsoleButton10
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137500, XrefRangeEnd = 137503, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIFlightYokeTemplate\u002Emode1
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137503, XrefRangeEnd = 137506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_mode1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIFlightYokeTemplate\u002Emode2
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137506, XrefRangeEnd = 137509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_mode2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIFlightYokeTemplate\u002Emode3
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137509, XrefRangeEnd = 137512, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_mode3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateYoke Rewired\u002EIFlightYokeTemplate\u002Eyoke
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137512, XrefRangeEnd = 137520, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_yoke_Private_Virtual_Final_New_get_IControllerTemplateYoke_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateYoke) null : new IControllerTemplateYoke(pointer);
      }
    }

    public virtual unsafe IControllerTemplateThrottle Rewired\u002EIFlightYokeTemplate\u002Elever1
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137520, XrefRangeEnd = 137523, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever1_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateThrottle) null : new IControllerTemplateThrottle(pointer);
      }
    }

    public virtual unsafe IControllerTemplateThrottle Rewired\u002EIFlightYokeTemplate\u002Elever2
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137523, XrefRangeEnd = 137526, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever2_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateThrottle) null : new IControllerTemplateThrottle(pointer);
      }
    }

    public virtual unsafe IControllerTemplateThrottle Rewired\u002EIFlightYokeTemplate\u002Elever3
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137526, XrefRangeEnd = 137529, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever3_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateThrottle) null : new IControllerTemplateThrottle(pointer);
      }
    }

    public virtual unsafe IControllerTemplateThrottle Rewired\u002EIFlightYokeTemplate\u002Elever4
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137529, XrefRangeEnd = 137532, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever4_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateThrottle) null : new IControllerTemplateThrottle(pointer);
      }
    }

    public virtual unsafe IControllerTemplateThrottle Rewired\u002EIFlightYokeTemplate\u002Elever5
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137532, XrefRangeEnd = 137535, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever5_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateThrottle) null : new IControllerTemplateThrottle(pointer);
      }
    }

    public virtual unsafe IControllerTemplateHat Rewired\u002EIFlightYokeTemplate\u002EleftGripHat
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137535, XrefRangeEnd = 137538, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripHat_Private_Virtual_Final_New_get_IControllerTemplateHat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateHat) null : new IControllerTemplateHat(pointer);
      }
    }

    public virtual unsafe IControllerTemplateHat Rewired\u002EIFlightYokeTemplate\u002ErightGripHat
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137538, XrefRangeEnd = 137541, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripHat_Private_Virtual_Final_New_get_IControllerTemplateHat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateHat) null : new IControllerTemplateHat(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FlightYokeTemplate(Il2CppSystem.Object payload)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) payload)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static FlightYokeTemplate()
    {
      Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired", nameof (FlightYokeTemplate));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr);
      FlightYokeTemplate.NativeFieldInfoPtr_typeGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (typeGuid));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_rotateYoke = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_rotateYoke));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_yokeZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_yokeZ));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftPaddle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_leftPaddle));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightPaddle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_rightPaddle));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever1Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_lever1Axis));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever1MinDetent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_lever1MinDetent));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever2Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_lever2Axis));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever2MinDetent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_lever2MinDetent));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever3Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_lever3Axis));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever3MinDetent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_lever3MinDetent));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever4Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_lever4Axis));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever4MinDetent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_lever4MinDetent));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever5Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_lever5Axis));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever5MinDetent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_lever5MinDetent));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripButton1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_leftGripButton1));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripButton2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_leftGripButton2));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripButton3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_leftGripButton3));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripButton4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_leftGripButton4));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripButton5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_leftGripButton5));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripButton6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_leftGripButton6));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripButton1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_rightGripButton1));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripButton2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_rightGripButton2));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripButton3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_rightGripButton3));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripButton4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_rightGripButton4));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripButton5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_rightGripButton5));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripButton6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_rightGripButton6));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_centerButton1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_centerButton1));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_centerButton2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_centerButton2));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_centerButton3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_centerButton3));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_centerButton4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_centerButton4));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_centerButton5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_centerButton5));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_centerButton6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_centerButton6));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_centerButton7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_centerButton7));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_centerButton8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_centerButton8));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_wheel1Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_wheel1Up));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_wheel1Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_wheel1Down));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_wheel1Press = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_wheel1Press));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_wheel2Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_wheel2Up));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_wheel2Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_wheel2Down));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_wheel2Press = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_wheel2Press));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHatUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_leftGripHatUp));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHatUpRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_leftGripHatUpRight));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHatRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_leftGripHatRight));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHatDownRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_leftGripHatDownRight));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHatDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_leftGripHatDown));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHatDownLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_leftGripHatDownLeft));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHatLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_leftGripHatLeft));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHatUpLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_leftGripHatUpLeft));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHatUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_rightGripHatUp));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHatUpRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_rightGripHatUpRight));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHatRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_rightGripHatRight));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHatDownRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_rightGripHatDownRight));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHatDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_rightGripHatDown));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHatDownLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_rightGripHatDownLeft));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHatLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_rightGripHatLeft));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHatUpLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_rightGripHatUpLeft));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_consoleButton1));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_consoleButton2));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_consoleButton3));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_consoleButton4));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_consoleButton5));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_consoleButton6));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_consoleButton7));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_consoleButton8));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_consoleButton9));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_consoleButton10));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_mode1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_mode1));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_mode2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_mode2));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_mode3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_mode3));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_yoke = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_yoke));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_lever1));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_lever2));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_lever3));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_lever4));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_lever5));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_leftGripHat));
      FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, nameof (elementId_rightGripHat));
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftPaddle_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677846);
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightPaddle_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677847);
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677848);
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677849);
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677850);
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677851);
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677852);
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677853);
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677854);
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677855);
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677856);
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677857);
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677858);
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677859);
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677860);
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677861);
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677862);
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677863);
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677864);
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677865);
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677866);
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677867);
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel1Up_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677868);
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel1Down_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677869);
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel1Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677870);
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel2Up_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677871);
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel2Down_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677872);
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel2Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677873);
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677874);
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677875);
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677876);
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677877);
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677878);
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677879);
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677880);
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677881);
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677882);
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677883);
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_mode1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677884);
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_mode2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677885);
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_mode3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677886);
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_yoke_Private_Virtual_Final_New_get_IControllerTemplateYoke_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677887);
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever1_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677888);
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever2_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677889);
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever3_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677890);
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever4_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677891);
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever5_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677892);
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripHat_Private_Virtual_Final_New_get_IControllerTemplateHat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677893);
      FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripHat_Private_Virtual_Final_New_get_IControllerTemplateHat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677894);
      FlightYokeTemplate.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100677895);
    }

    public FlightYokeTemplate(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe Il2CppSystem.Guid typeGuid
    {
      get
      {
        Il2CppSystem.Guid typeGuid;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_typeGuid, (void*) &typeGuid);
        return typeGuid;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_typeGuid, (void*) &value);
      }
    }

    public static unsafe int elementId_rotateYoke
    {
      get
      {
        int elementIdRotateYoke;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rotateYoke, (void*) &elementIdRotateYoke);
        return elementIdRotateYoke;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rotateYoke, (void*) &value);
      }
    }

    public static unsafe int elementId_yokeZ
    {
      get
      {
        int elementIdYokeZ;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_yokeZ, (void*) &elementIdYokeZ);
        return elementIdYokeZ;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_yokeZ, (void*) &value);
      }
    }

    public static unsafe int elementId_leftPaddle
    {
      get
      {
        int elementIdLeftPaddle;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftPaddle, (void*) &elementIdLeftPaddle);
        return elementIdLeftPaddle;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftPaddle, (void*) &value);
      }
    }

    public static unsafe int elementId_rightPaddle
    {
      get
      {
        int elementIdRightPaddle;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightPaddle, (void*) &elementIdRightPaddle);
        return elementIdRightPaddle;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightPaddle, (void*) &value);
      }
    }

    public static unsafe int elementId_lever1Axis
    {
      get
      {
        int elementIdLever1Axis;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever1Axis, (void*) &elementIdLever1Axis);
        return elementIdLever1Axis;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever1Axis, (void*) &value);
      }
    }

    public static unsafe int elementId_lever1MinDetent
    {
      get
      {
        int idLever1MinDetent;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever1MinDetent, (void*) &idLever1MinDetent);
        return idLever1MinDetent;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever1MinDetent, (void*) &value);
      }
    }

    public static unsafe int elementId_lever2Axis
    {
      get
      {
        int elementIdLever2Axis;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever2Axis, (void*) &elementIdLever2Axis);
        return elementIdLever2Axis;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever2Axis, (void*) &value);
      }
    }

    public static unsafe int elementId_lever2MinDetent
    {
      get
      {
        int idLever2MinDetent;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever2MinDetent, (void*) &idLever2MinDetent);
        return idLever2MinDetent;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever2MinDetent, (void*) &value);
      }
    }

    public static unsafe int elementId_lever3Axis
    {
      get
      {
        int elementIdLever3Axis;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever3Axis, (void*) &elementIdLever3Axis);
        return elementIdLever3Axis;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever3Axis, (void*) &value);
      }
    }

    public static unsafe int elementId_lever3MinDetent
    {
      get
      {
        int idLever3MinDetent;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever3MinDetent, (void*) &idLever3MinDetent);
        return idLever3MinDetent;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever3MinDetent, (void*) &value);
      }
    }

    public static unsafe int elementId_lever4Axis
    {
      get
      {
        int elementIdLever4Axis;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever4Axis, (void*) &elementIdLever4Axis);
        return elementIdLever4Axis;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever4Axis, (void*) &value);
      }
    }

    public static unsafe int elementId_lever4MinDetent
    {
      get
      {
        int idLever4MinDetent;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever4MinDetent, (void*) &idLever4MinDetent);
        return idLever4MinDetent;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever4MinDetent, (void*) &value);
      }
    }

    public static unsafe int elementId_lever5Axis
    {
      get
      {
        int elementIdLever5Axis;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever5Axis, (void*) &elementIdLever5Axis);
        return elementIdLever5Axis;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever5Axis, (void*) &value);
      }
    }

    public static unsafe int elementId_lever5MinDetent
    {
      get
      {
        int idLever5MinDetent;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever5MinDetent, (void*) &idLever5MinDetent);
        return idLever5MinDetent;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever5MinDetent, (void*) &value);
      }
    }

    public static unsafe int elementId_leftGripButton1
    {
      get
      {
        int idLeftGripButton1;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripButton1, (void*) &idLeftGripButton1);
        return idLeftGripButton1;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripButton1, (void*) &value);
      }
    }

    public static unsafe int elementId_leftGripButton2
    {
      get
      {
        int idLeftGripButton2;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripButton2, (void*) &idLeftGripButton2);
        return idLeftGripButton2;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripButton2, (void*) &value);
      }
    }

    public static unsafe int elementId_leftGripButton3
    {
      get
      {
        int idLeftGripButton3;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripButton3, (void*) &idLeftGripButton3);
        return idLeftGripButton3;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripButton3, (void*) &value);
      }
    }

    public static unsafe int elementId_leftGripButton4
    {
      get
      {
        int idLeftGripButton4;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripButton4, (void*) &idLeftGripButton4);
        return idLeftGripButton4;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripButton4, (void*) &value);
      }
    }

    public static unsafe int elementId_leftGripButton5
    {
      get
      {
        int idLeftGripButton5;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripButton5, (void*) &idLeftGripButton5);
        return idLeftGripButton5;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripButton5, (void*) &value);
      }
    }

    public static unsafe int elementId_leftGripButton6
    {
      get
      {
        int idLeftGripButton6;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripButton6, (void*) &idLeftGripButton6);
        return idLeftGripButton6;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripButton6, (void*) &value);
      }
    }

    public static unsafe int elementId_rightGripButton1
    {
      get
      {
        int rightGripButton1;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripButton1, (void*) &rightGripButton1);
        return rightGripButton1;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripButton1, (void*) &value);
      }
    }

    public static unsafe int elementId_rightGripButton2
    {
      get
      {
        int rightGripButton2;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripButton2, (void*) &rightGripButton2);
        return rightGripButton2;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripButton2, (void*) &value);
      }
    }

    public static unsafe int elementId_rightGripButton3
    {
      get
      {
        int rightGripButton3;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripButton3, (void*) &rightGripButton3);
        return rightGripButton3;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripButton3, (void*) &value);
      }
    }

    public static unsafe int elementId_rightGripButton4
    {
      get
      {
        int rightGripButton4;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripButton4, (void*) &rightGripButton4);
        return rightGripButton4;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripButton4, (void*) &value);
      }
    }

    public static unsafe int elementId_rightGripButton5
    {
      get
      {
        int rightGripButton5;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripButton5, (void*) &rightGripButton5);
        return rightGripButton5;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripButton5, (void*) &value);
      }
    }

    public static unsafe int elementId_rightGripButton6
    {
      get
      {
        int rightGripButton6;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripButton6, (void*) &rightGripButton6);
        return rightGripButton6;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripButton6, (void*) &value);
      }
    }

    public static unsafe int elementId_centerButton1
    {
      get
      {
        int elementIdCenterButton1;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_centerButton1, (void*) &elementIdCenterButton1);
        return elementIdCenterButton1;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_centerButton1, (void*) &value);
      }
    }

    public static unsafe int elementId_centerButton2
    {
      get
      {
        int elementIdCenterButton2;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_centerButton2, (void*) &elementIdCenterButton2);
        return elementIdCenterButton2;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_centerButton2, (void*) &value);
      }
    }

    public static unsafe int elementId_centerButton3
    {
      get
      {
        int elementIdCenterButton3;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_centerButton3, (void*) &elementIdCenterButton3);
        return elementIdCenterButton3;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_centerButton3, (void*) &value);
      }
    }

    public static unsafe int elementId_centerButton4
    {
      get
      {
        int elementIdCenterButton4;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_centerButton4, (void*) &elementIdCenterButton4);
        return elementIdCenterButton4;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_centerButton4, (void*) &value);
      }
    }

    public static unsafe int elementId_centerButton5
    {
      get
      {
        int elementIdCenterButton5;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_centerButton5, (void*) &elementIdCenterButton5);
        return elementIdCenterButton5;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_centerButton5, (void*) &value);
      }
    }

    public static unsafe int elementId_centerButton6
    {
      get
      {
        int elementIdCenterButton6;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_centerButton6, (void*) &elementIdCenterButton6);
        return elementIdCenterButton6;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_centerButton6, (void*) &value);
      }
    }

    public static unsafe int elementId_centerButton7
    {
      get
      {
        int elementIdCenterButton7;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_centerButton7, (void*) &elementIdCenterButton7);
        return elementIdCenterButton7;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_centerButton7, (void*) &value);
      }
    }

    public static unsafe int elementId_centerButton8
    {
      get
      {
        int elementIdCenterButton8;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_centerButton8, (void*) &elementIdCenterButton8);
        return elementIdCenterButton8;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_centerButton8, (void*) &value);
      }
    }

    public static unsafe int elementId_wheel1Up
    {
      get
      {
        int elementIdWheel1Up;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_wheel1Up, (void*) &elementIdWheel1Up);
        return elementIdWheel1Up;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_wheel1Up, (void*) &value);
      }
    }

    public static unsafe int elementId_wheel1Down
    {
      get
      {
        int elementIdWheel1Down;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_wheel1Down, (void*) &elementIdWheel1Down);
        return elementIdWheel1Down;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_wheel1Down, (void*) &value);
      }
    }

    public static unsafe int elementId_wheel1Press
    {
      get
      {
        int elementIdWheel1Press;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_wheel1Press, (void*) &elementIdWheel1Press);
        return elementIdWheel1Press;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_wheel1Press, (void*) &value);
      }
    }

    public static unsafe int elementId_wheel2Up
    {
      get
      {
        int elementIdWheel2Up;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_wheel2Up, (void*) &elementIdWheel2Up);
        return elementIdWheel2Up;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_wheel2Up, (void*) &value);
      }
    }

    public static unsafe int elementId_wheel2Down
    {
      get
      {
        int elementIdWheel2Down;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_wheel2Down, (void*) &elementIdWheel2Down);
        return elementIdWheel2Down;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_wheel2Down, (void*) &value);
      }
    }

    public static unsafe int elementId_wheel2Press
    {
      get
      {
        int elementIdWheel2Press;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_wheel2Press, (void*) &elementIdWheel2Press);
        return elementIdWheel2Press;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_wheel2Press, (void*) &value);
      }
    }

    public static unsafe int elementId_leftGripHatUp
    {
      get
      {
        int elementIdLeftGripHatUp;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHatUp, (void*) &elementIdLeftGripHatUp);
        return elementIdLeftGripHatUp;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHatUp, (void*) &value);
      }
    }

    public static unsafe int elementId_leftGripHatUpRight
    {
      get
      {
        int leftGripHatUpRight;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHatUpRight, (void*) &leftGripHatUpRight);
        return leftGripHatUpRight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHatUpRight, (void*) &value);
      }
    }

    public static unsafe int elementId_leftGripHatRight
    {
      get
      {
        int leftGripHatRight;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHatRight, (void*) &leftGripHatRight);
        return leftGripHatRight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHatRight, (void*) &value);
      }
    }

    public static unsafe int elementId_leftGripHatDownRight
    {
      get
      {
        int gripHatDownRight;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHatDownRight, (void*) &gripHatDownRight);
        return gripHatDownRight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHatDownRight, (void*) &value);
      }
    }

    public static unsafe int elementId_leftGripHatDown
    {
      get
      {
        int idLeftGripHatDown;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHatDown, (void*) &idLeftGripHatDown);
        return idLeftGripHatDown;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHatDown, (void*) &value);
      }
    }

    public static unsafe int elementId_leftGripHatDownLeft
    {
      get
      {
        int leftGripHatDownLeft;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHatDownLeft, (void*) &leftGripHatDownLeft);
        return leftGripHatDownLeft;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHatDownLeft, (void*) &value);
      }
    }

    public static unsafe int elementId_leftGripHatLeft
    {
      get
      {
        int idLeftGripHatLeft;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHatLeft, (void*) &idLeftGripHatLeft);
        return idLeftGripHatLeft;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHatLeft, (void*) &value);
      }
    }

    public static unsafe int elementId_leftGripHatUpLeft
    {
      get
      {
        int leftGripHatUpLeft;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHatUpLeft, (void*) &leftGripHatUpLeft);
        return leftGripHatUpLeft;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHatUpLeft, (void*) &value);
      }
    }

    public static unsafe int elementId_rightGripHatUp
    {
      get
      {
        int idRightGripHatUp;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHatUp, (void*) &idRightGripHatUp);
        return idRightGripHatUp;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHatUp, (void*) &value);
      }
    }

    public static unsafe int elementId_rightGripHatUpRight
    {
      get
      {
        int rightGripHatUpRight;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHatUpRight, (void*) &rightGripHatUpRight);
        return rightGripHatUpRight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHatUpRight, (void*) &value);
      }
    }

    public static unsafe int elementId_rightGripHatRight
    {
      get
      {
        int rightGripHatRight;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHatRight, (void*) &rightGripHatRight);
        return rightGripHatRight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHatRight, (void*) &value);
      }
    }

    public static unsafe int elementId_rightGripHatDownRight
    {
      get
      {
        int gripHatDownRight;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHatDownRight, (void*) &gripHatDownRight);
        return gripHatDownRight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHatDownRight, (void*) &value);
      }
    }

    public static unsafe int elementId_rightGripHatDown
    {
      get
      {
        int rightGripHatDown;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHatDown, (void*) &rightGripHatDown);
        return rightGripHatDown;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHatDown, (void*) &value);
      }
    }

    public static unsafe int elementId_rightGripHatDownLeft
    {
      get
      {
        int rightGripHatDownLeft;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHatDownLeft, (void*) &rightGripHatDownLeft);
        return rightGripHatDownLeft;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHatDownLeft, (void*) &value);
      }
    }

    public static unsafe int elementId_rightGripHatLeft
    {
      get
      {
        int rightGripHatLeft;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHatLeft, (void*) &rightGripHatLeft);
        return rightGripHatLeft;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHatLeft, (void*) &value);
      }
    }

    public static unsafe int elementId_rightGripHatUpLeft
    {
      get
      {
        int rightGripHatUpLeft;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHatUpLeft, (void*) &rightGripHatUpLeft);
        return rightGripHatUpLeft;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHatUpLeft, (void*) &value);
      }
    }

    public static unsafe int elementId_consoleButton1
    {
      get
      {
        int idConsoleButton1;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton1, (void*) &idConsoleButton1);
        return idConsoleButton1;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton1, (void*) &value);
      }
    }

    public static unsafe int elementId_consoleButton2
    {
      get
      {
        int idConsoleButton2;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton2, (void*) &idConsoleButton2);
        return idConsoleButton2;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton2, (void*) &value);
      }
    }

    public static unsafe int elementId_consoleButton3
    {
      get
      {
        int idConsoleButton3;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton3, (void*) &idConsoleButton3);
        return idConsoleButton3;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton3, (void*) &value);
      }
    }

    public static unsafe int elementId_consoleButton4
    {
      get
      {
        int idConsoleButton4;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton4, (void*) &idConsoleButton4);
        return idConsoleButton4;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton4, (void*) &value);
      }
    }

    public static unsafe int elementId_consoleButton5
    {
      get
      {
        int idConsoleButton5;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton5, (void*) &idConsoleButton5);
        return idConsoleButton5;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton5, (void*) &value);
      }
    }

    public static unsafe int elementId_consoleButton6
    {
      get
      {
        int idConsoleButton6;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton6, (void*) &idConsoleButton6);
        return idConsoleButton6;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton6, (void*) &value);
      }
    }

    public static unsafe int elementId_consoleButton7
    {
      get
      {
        int idConsoleButton7;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton7, (void*) &idConsoleButton7);
        return idConsoleButton7;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton7, (void*) &value);
      }
    }

    public static unsafe int elementId_consoleButton8
    {
      get
      {
        int idConsoleButton8;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton8, (void*) &idConsoleButton8);
        return idConsoleButton8;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton8, (void*) &value);
      }
    }

    public static unsafe int elementId_consoleButton9
    {
      get
      {
        int idConsoleButton9;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton9, (void*) &idConsoleButton9);
        return idConsoleButton9;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton9, (void*) &value);
      }
    }

    public static unsafe int elementId_consoleButton10
    {
      get
      {
        int idConsoleButton10;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton10, (void*) &idConsoleButton10);
        return idConsoleButton10;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton10, (void*) &value);
      }
    }

    public static unsafe int elementId_mode1
    {
      get
      {
        int elementIdMode1;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_mode1, (void*) &elementIdMode1);
        return elementIdMode1;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_mode1, (void*) &value);
      }
    }

    public static unsafe int elementId_mode2
    {
      get
      {
        int elementIdMode2;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_mode2, (void*) &elementIdMode2);
        return elementIdMode2;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_mode2, (void*) &value);
      }
    }

    public static unsafe int elementId_mode3
    {
      get
      {
        int elementIdMode3;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_mode3, (void*) &elementIdMode3);
        return elementIdMode3;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_mode3, (void*) &value);
      }
    }

    public static unsafe int elementId_yoke
    {
      get
      {
        int elementIdYoke;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_yoke, (void*) &elementIdYoke);
        return elementIdYoke;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_yoke, (void*) &value);
      }
    }

    public static unsafe int elementId_lever1
    {
      get
      {
        int elementIdLever1;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever1, (void*) &elementIdLever1);
        return elementIdLever1;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever1, (void*) &value);
      }
    }

    public static unsafe int elementId_lever2
    {
      get
      {
        int elementIdLever2;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever2, (void*) &elementIdLever2);
        return elementIdLever2;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever2, (void*) &value);
      }
    }

    public static unsafe int elementId_lever3
    {
      get
      {
        int elementIdLever3;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever3, (void*) &elementIdLever3);
        return elementIdLever3;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever3, (void*) &value);
      }
    }

    public static unsafe int elementId_lever4
    {
      get
      {
        int elementIdLever4;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever4, (void*) &elementIdLever4);
        return elementIdLever4;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever4, (void*) &value);
      }
    }

    public static unsafe int elementId_lever5
    {
      get
      {
        int elementIdLever5;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever5, (void*) &elementIdLever5);
        return elementIdLever5;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever5, (void*) &value);
      }
    }

    public static unsafe int elementId_leftGripHat
    {
      get
      {
        int elementIdLeftGripHat;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHat, (void*) &elementIdLeftGripHat);
        return elementIdLeftGripHat;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHat, (void*) &value);
      }
    }

    public static unsafe int elementId_rightGripHat
    {
      get
      {
        int elementIdRightGripHat;
        IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHat, (void*) &elementIdRightGripHat);
        return elementIdRightGripHat;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHat, (void*) &value);
      }
    }
  }
}
