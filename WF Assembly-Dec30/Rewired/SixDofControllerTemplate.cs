// Decompiled with JetBrains decompiler
// Type: Rewired.SixDofControllerTemplate
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
  public sealed class SixDofControllerTemplate : ControllerTemplate
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_typeGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_positionX;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_positionY;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_positionZ;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rotationX;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rotationY;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rotationZ;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttle1Axis;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttle1MinDetent;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttle2Axis;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttle2MinDetent;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_extraAxis1;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_extraAxis2;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_extraAxis3;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_extraAxis4;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button1;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button2;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button3;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button4;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button5;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button6;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button7;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button8;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button9;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button10;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button11;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button12;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button13;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button14;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button15;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button16;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button17;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button18;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button19;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button20;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button21;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button22;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button23;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button24;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button25;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button26;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button27;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button28;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button29;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button30;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button31;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button32;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_hat1Up;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_hat1UpRight;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_hat1Right;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_hat1DownRight;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_hat1Down;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_hat1DownLeft;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_hat1Left;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_hat1UpLeft;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_hat2Up;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_hat2UpRight;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_hat2Right;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_hat2DownRight;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_hat2Down;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_hat2DownLeft;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_hat2Left;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_hat2UpLeft;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_hat1;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_hat2;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttle1;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttle2;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stick;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_extraAxis1_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_extraAxis2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_extraAxis3_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_extraAxis4_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button4_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button5_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button6_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button7_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button8_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button9_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button10_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button11_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button12_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button13_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button14_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button15_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button16_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button17_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button18_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button19_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button20_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button21_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button22_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button23_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button24_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button25_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button26_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button27_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button28_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button29_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button30_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button31_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button32_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_hat1_Private_Virtual_Final_New_get_IControllerTemplateHat_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_hat2_Private_Virtual_Final_New_get_IControllerTemplateHat_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_throttle1_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_throttle2_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_stick_Private_Virtual_Final_New_get_IControllerTemplateStick6D_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

    public virtual unsafe IControllerTemplateAxis Rewired\u002EISixDofControllerTemplate\u002EextraAxis1
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137555, XrefRangeEnd = 137558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_extraAxis1_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateAxis) null : new IControllerTemplateAxis(pointer);
      }
    }

    public virtual unsafe IControllerTemplateAxis Rewired\u002EISixDofControllerTemplate\u002EextraAxis2
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137558, XrefRangeEnd = 137561, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_extraAxis2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateAxis) null : new IControllerTemplateAxis(pointer);
      }
    }

    public virtual unsafe IControllerTemplateAxis Rewired\u002EISixDofControllerTemplate\u002EextraAxis3
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137561, XrefRangeEnd = 137564, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_extraAxis3_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateAxis) null : new IControllerTemplateAxis(pointer);
      }
    }

    public virtual unsafe IControllerTemplateAxis Rewired\u002EISixDofControllerTemplate\u002EextraAxis4
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137564, XrefRangeEnd = 137567, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_extraAxis4_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateAxis) null : new IControllerTemplateAxis(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EISixDofControllerTemplate\u002Ebutton1
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137567, XrefRangeEnd = 137570, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EISixDofControllerTemplate\u002Ebutton2
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137570, XrefRangeEnd = 137573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EISixDofControllerTemplate\u002Ebutton3
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137573, XrefRangeEnd = 137576, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EISixDofControllerTemplate\u002Ebutton4
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137576, XrefRangeEnd = 137579, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button4_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EISixDofControllerTemplate\u002Ebutton5
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137579, XrefRangeEnd = 137582, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button5_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EISixDofControllerTemplate\u002Ebutton6
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137582, XrefRangeEnd = 137585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button6_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EISixDofControllerTemplate\u002Ebutton7
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137585, XrefRangeEnd = 137588, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button7_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EISixDofControllerTemplate\u002Ebutton8
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137588, XrefRangeEnd = 137591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button8_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EISixDofControllerTemplate\u002Ebutton9
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137591, XrefRangeEnd = 137594, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button9_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EISixDofControllerTemplate\u002Ebutton10
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137594, XrefRangeEnd = 137597, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button10_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EISixDofControllerTemplate\u002Ebutton11
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137597, XrefRangeEnd = 137600, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button11_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EISixDofControllerTemplate\u002Ebutton12
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137600, XrefRangeEnd = 137603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button12_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EISixDofControllerTemplate\u002Ebutton13
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137603, XrefRangeEnd = 137606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button13_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EISixDofControllerTemplate\u002Ebutton14
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137606, XrefRangeEnd = 137609, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button14_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EISixDofControllerTemplate\u002Ebutton15
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137609, XrefRangeEnd = 137612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button15_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EISixDofControllerTemplate\u002Ebutton16
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137612, XrefRangeEnd = 137615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button16_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EISixDofControllerTemplate\u002Ebutton17
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137615, XrefRangeEnd = 137618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button17_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EISixDofControllerTemplate\u002Ebutton18
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137618, XrefRangeEnd = 137621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button18_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EISixDofControllerTemplate\u002Ebutton19
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137621, XrefRangeEnd = 137624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button19_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EISixDofControllerTemplate\u002Ebutton20
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137624, XrefRangeEnd = 137627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button20_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EISixDofControllerTemplate\u002Ebutton21
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137627, XrefRangeEnd = 137630, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button21_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EISixDofControllerTemplate\u002Ebutton22
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137630, XrefRangeEnd = 137633, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button22_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EISixDofControllerTemplate\u002Ebutton23
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137633, XrefRangeEnd = 137636, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button23_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EISixDofControllerTemplate\u002Ebutton24
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137636, XrefRangeEnd = 137639, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button24_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EISixDofControllerTemplate\u002Ebutton25
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137639, XrefRangeEnd = 137642, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button25_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EISixDofControllerTemplate\u002Ebutton26
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137642, XrefRangeEnd = 137645, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button26_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EISixDofControllerTemplate\u002Ebutton27
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137645, XrefRangeEnd = 137648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button27_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EISixDofControllerTemplate\u002Ebutton28
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137648, XrefRangeEnd = 137651, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button28_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EISixDofControllerTemplate\u002Ebutton29
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137651, XrefRangeEnd = 137654, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button29_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EISixDofControllerTemplate\u002Ebutton30
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137654, XrefRangeEnd = 137657, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button30_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EISixDofControllerTemplate\u002Ebutton31
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137657, XrefRangeEnd = 137660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button31_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EISixDofControllerTemplate\u002Ebutton32
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137660, XrefRangeEnd = 137663, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button32_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateHat Rewired\u002EISixDofControllerTemplate\u002Ehat1
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137663, XrefRangeEnd = 137666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_hat1_Private_Virtual_Final_New_get_IControllerTemplateHat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateHat) null : new IControllerTemplateHat(pointer);
      }
    }

    public virtual unsafe IControllerTemplateHat Rewired\u002EISixDofControllerTemplate\u002Ehat2
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137666, XrefRangeEnd = 137669, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_hat2_Private_Virtual_Final_New_get_IControllerTemplateHat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateHat) null : new IControllerTemplateHat(pointer);
      }
    }

    public virtual unsafe IControllerTemplateThrottle Rewired\u002EISixDofControllerTemplate\u002Ethrottle1
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137669, XrefRangeEnd = 137672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_throttle1_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateThrottle) null : new IControllerTemplateThrottle(pointer);
      }
    }

    public virtual unsafe IControllerTemplateThrottle Rewired\u002EISixDofControllerTemplate\u002Ethrottle2
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137672, XrefRangeEnd = 137680, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_throttle2_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateThrottle) null : new IControllerTemplateThrottle(pointer);
      }
    }

    public virtual unsafe IControllerTemplateStick6D Rewired\u002EISixDofControllerTemplate\u002Estick
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137680, XrefRangeEnd = 137683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_stick_Private_Virtual_Final_New_get_IControllerTemplateStick6D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateStick6D) null : new IControllerTemplateStick6D(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SixDofControllerTemplate(Il2CppSystem.Object payload)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) payload)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SixDofControllerTemplate()
    {
      Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired", nameof (SixDofControllerTemplate));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr);
      SixDofControllerTemplate.NativeFieldInfoPtr_typeGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (typeGuid));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_positionX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_positionX));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_positionY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_positionY));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_positionZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_positionZ));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_rotationX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_rotationX));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_rotationY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_rotationY));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_rotationZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_rotationZ));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_throttle1Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_throttle1Axis));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_throttle1MinDetent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_throttle1MinDetent));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_throttle2Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_throttle2Axis));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_throttle2MinDetent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_throttle2MinDetent));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_extraAxis1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_extraAxis1));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_extraAxis2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_extraAxis2));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_extraAxis3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_extraAxis3));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_extraAxis4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_extraAxis4));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_button1));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_button2));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_button3));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_button4));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_button5));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_button6));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_button7));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_button8));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_button9));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_button10));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_button11));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_button12));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_button13));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_button14));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_button15));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_button16));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button17 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_button17));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button18 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_button18));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button19 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_button19));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button20 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_button20));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button21 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_button21));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button22 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_button22));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button23 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_button23));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button24 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_button24));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button25 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_button25));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button26 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_button26));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button27 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_button27));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button28 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_button28));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button29 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_button29));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button30 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_button30));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button31 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_button31));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_button32));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_hat1Up));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1UpRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_hat1UpRight));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_hat1Right));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1DownRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_hat1DownRight));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_hat1Down));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1DownLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_hat1DownLeft));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_hat1Left));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1UpLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_hat1UpLeft));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_hat2Up));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2UpRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_hat2UpRight));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_hat2Right));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2DownRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_hat2DownRight));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_hat2Down));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2DownLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_hat2DownLeft));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_hat2Left));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2UpLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_hat2UpLeft));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_hat1));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_hat2));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_throttle1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_throttle1));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_throttle2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_throttle2));
      SixDofControllerTemplate.NativeFieldInfoPtr_elementId_stick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, nameof (elementId_stick));
      SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_extraAxis1_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100677902);
      SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_extraAxis2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100677903);
      SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_extraAxis3_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100677904);
      SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_extraAxis4_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100677905);
      SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100677906);
      SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100677907);
      SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100677908);
      SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button4_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100677909);
      SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button5_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100677910);
      SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button6_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100677911);
      SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button7_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100677912);
      SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button8_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100677913);
      SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button9_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100677914);
      SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button10_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100677915);
      SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button11_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100677916);
      SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button12_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100677917);
      SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button13_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100677918);
      SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button14_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100677919);
      SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button15_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100677920);
      SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button16_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100677921);
      SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button17_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100677922);
      SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button18_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100677923);
      SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button19_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100677924);
      SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button20_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100677925);
      SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button21_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100677926);
      SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button22_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100677927);
      SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button23_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100677928);
      SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button24_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100677929);
      SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button25_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100677930);
      SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button26_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100677931);
      SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button27_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100677932);
      SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button28_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100677933);
      SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button29_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100677934);
      SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button30_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100677935);
      SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button31_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100677936);
      SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button32_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100677937);
      SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_hat1_Private_Virtual_Final_New_get_IControllerTemplateHat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100677938);
      SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_hat2_Private_Virtual_Final_New_get_IControllerTemplateHat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100677939);
      SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_throttle1_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100677940);
      SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_throttle2_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100677941);
      SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_stick_Private_Virtual_Final_New_get_IControllerTemplateStick6D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100677942);
      SixDofControllerTemplate.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100677943);
    }

    public SixDofControllerTemplate(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe Il2CppSystem.Guid typeGuid
    {
      get
      {
        Il2CppSystem.Guid typeGuid;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_typeGuid, (void*) &typeGuid);
        return typeGuid;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_typeGuid, (void*) &value);
      }
    }

    public static unsafe int elementId_positionX
    {
      get
      {
        int elementIdPositionX;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_positionX, (void*) &elementIdPositionX);
        return elementIdPositionX;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_positionX, (void*) &value);
      }
    }

    public static unsafe int elementId_positionY
    {
      get
      {
        int elementIdPositionY;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_positionY, (void*) &elementIdPositionY);
        return elementIdPositionY;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_positionY, (void*) &value);
      }
    }

    public static unsafe int elementId_positionZ
    {
      get
      {
        int elementIdPositionZ;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_positionZ, (void*) &elementIdPositionZ);
        return elementIdPositionZ;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_positionZ, (void*) &value);
      }
    }

    public static unsafe int elementId_rotationX
    {
      get
      {
        int elementIdRotationX;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_rotationX, (void*) &elementIdRotationX);
        return elementIdRotationX;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_rotationX, (void*) &value);
      }
    }

    public static unsafe int elementId_rotationY
    {
      get
      {
        int elementIdRotationY;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_rotationY, (void*) &elementIdRotationY);
        return elementIdRotationY;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_rotationY, (void*) &value);
      }
    }

    public static unsafe int elementId_rotationZ
    {
      get
      {
        int elementIdRotationZ;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_rotationZ, (void*) &elementIdRotationZ);
        return elementIdRotationZ;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_rotationZ, (void*) &value);
      }
    }

    public static unsafe int elementId_throttle1Axis
    {
      get
      {
        int elementIdThrottle1Axis;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_throttle1Axis, (void*) &elementIdThrottle1Axis);
        return elementIdThrottle1Axis;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_throttle1Axis, (void*) &value);
      }
    }

    public static unsafe int elementId_throttle1MinDetent
    {
      get
      {
        int throttle1MinDetent;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_throttle1MinDetent, (void*) &throttle1MinDetent);
        return throttle1MinDetent;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_throttle1MinDetent, (void*) &value);
      }
    }

    public static unsafe int elementId_throttle2Axis
    {
      get
      {
        int elementIdThrottle2Axis;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_throttle2Axis, (void*) &elementIdThrottle2Axis);
        return elementIdThrottle2Axis;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_throttle2Axis, (void*) &value);
      }
    }

    public static unsafe int elementId_throttle2MinDetent
    {
      get
      {
        int throttle2MinDetent;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_throttle2MinDetent, (void*) &throttle2MinDetent);
        return throttle2MinDetent;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_throttle2MinDetent, (void*) &value);
      }
    }

    public static unsafe int elementId_extraAxis1
    {
      get
      {
        int elementIdExtraAxis1;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_extraAxis1, (void*) &elementIdExtraAxis1);
        return elementIdExtraAxis1;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_extraAxis1, (void*) &value);
      }
    }

    public static unsafe int elementId_extraAxis2
    {
      get
      {
        int elementIdExtraAxis2;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_extraAxis2, (void*) &elementIdExtraAxis2);
        return elementIdExtraAxis2;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_extraAxis2, (void*) &value);
      }
    }

    public static unsafe int elementId_extraAxis3
    {
      get
      {
        int elementIdExtraAxis3;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_extraAxis3, (void*) &elementIdExtraAxis3);
        return elementIdExtraAxis3;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_extraAxis3, (void*) &value);
      }
    }

    public static unsafe int elementId_extraAxis4
    {
      get
      {
        int elementIdExtraAxis4;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_extraAxis4, (void*) &elementIdExtraAxis4);
        return elementIdExtraAxis4;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_extraAxis4, (void*) &value);
      }
    }

    public static unsafe int elementId_button1
    {
      get
      {
        int elementIdButton1;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button1, (void*) &elementIdButton1);
        return elementIdButton1;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button1, (void*) &value);
      }
    }

    public static unsafe int elementId_button2
    {
      get
      {
        int elementIdButton2;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button2, (void*) &elementIdButton2);
        return elementIdButton2;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button2, (void*) &value);
      }
    }

    public static unsafe int elementId_button3
    {
      get
      {
        int elementIdButton3;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button3, (void*) &elementIdButton3);
        return elementIdButton3;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button3, (void*) &value);
      }
    }

    public static unsafe int elementId_button4
    {
      get
      {
        int elementIdButton4;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button4, (void*) &elementIdButton4);
        return elementIdButton4;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button4, (void*) &value);
      }
    }

    public static unsafe int elementId_button5
    {
      get
      {
        int elementIdButton5;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button5, (void*) &elementIdButton5);
        return elementIdButton5;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button5, (void*) &value);
      }
    }

    public static unsafe int elementId_button6
    {
      get
      {
        int elementIdButton6;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button6, (void*) &elementIdButton6);
        return elementIdButton6;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button6, (void*) &value);
      }
    }

    public static unsafe int elementId_button7
    {
      get
      {
        int elementIdButton7;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button7, (void*) &elementIdButton7);
        return elementIdButton7;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button7, (void*) &value);
      }
    }

    public static unsafe int elementId_button8
    {
      get
      {
        int elementIdButton8;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button8, (void*) &elementIdButton8);
        return elementIdButton8;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button8, (void*) &value);
      }
    }

    public static unsafe int elementId_button9
    {
      get
      {
        int elementIdButton9;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button9, (void*) &elementIdButton9);
        return elementIdButton9;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button9, (void*) &value);
      }
    }

    public static unsafe int elementId_button10
    {
      get
      {
        int elementIdButton10;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button10, (void*) &elementIdButton10);
        return elementIdButton10;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button10, (void*) &value);
      }
    }

    public static unsafe int elementId_button11
    {
      get
      {
        int elementIdButton11;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button11, (void*) &elementIdButton11);
        return elementIdButton11;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button11, (void*) &value);
      }
    }

    public static unsafe int elementId_button12
    {
      get
      {
        int elementIdButton12;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button12, (void*) &elementIdButton12);
        return elementIdButton12;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button12, (void*) &value);
      }
    }

    public static unsafe int elementId_button13
    {
      get
      {
        int elementIdButton13;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button13, (void*) &elementIdButton13);
        return elementIdButton13;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button13, (void*) &value);
      }
    }

    public static unsafe int elementId_button14
    {
      get
      {
        int elementIdButton14;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button14, (void*) &elementIdButton14);
        return elementIdButton14;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button14, (void*) &value);
      }
    }

    public static unsafe int elementId_button15
    {
      get
      {
        int elementIdButton15;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button15, (void*) &elementIdButton15);
        return elementIdButton15;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button15, (void*) &value);
      }
    }

    public static unsafe int elementId_button16
    {
      get
      {
        int elementIdButton16;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button16, (void*) &elementIdButton16);
        return elementIdButton16;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button16, (void*) &value);
      }
    }

    public static unsafe int elementId_button17
    {
      get
      {
        int elementIdButton17;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button17, (void*) &elementIdButton17);
        return elementIdButton17;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button17, (void*) &value);
      }
    }

    public static unsafe int elementId_button18
    {
      get
      {
        int elementIdButton18;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button18, (void*) &elementIdButton18);
        return elementIdButton18;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button18, (void*) &value);
      }
    }

    public static unsafe int elementId_button19
    {
      get
      {
        int elementIdButton19;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button19, (void*) &elementIdButton19);
        return elementIdButton19;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button19, (void*) &value);
      }
    }

    public static unsafe int elementId_button20
    {
      get
      {
        int elementIdButton20;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button20, (void*) &elementIdButton20);
        return elementIdButton20;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button20, (void*) &value);
      }
    }

    public static unsafe int elementId_button21
    {
      get
      {
        int elementIdButton21;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button21, (void*) &elementIdButton21);
        return elementIdButton21;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button21, (void*) &value);
      }
    }

    public static unsafe int elementId_button22
    {
      get
      {
        int elementIdButton22;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button22, (void*) &elementIdButton22);
        return elementIdButton22;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button22, (void*) &value);
      }
    }

    public static unsafe int elementId_button23
    {
      get
      {
        int elementIdButton23;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button23, (void*) &elementIdButton23);
        return elementIdButton23;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button23, (void*) &value);
      }
    }

    public static unsafe int elementId_button24
    {
      get
      {
        int elementIdButton24;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button24, (void*) &elementIdButton24);
        return elementIdButton24;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button24, (void*) &value);
      }
    }

    public static unsafe int elementId_button25
    {
      get
      {
        int elementIdButton25;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button25, (void*) &elementIdButton25);
        return elementIdButton25;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button25, (void*) &value);
      }
    }

    public static unsafe int elementId_button26
    {
      get
      {
        int elementIdButton26;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button26, (void*) &elementIdButton26);
        return elementIdButton26;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button26, (void*) &value);
      }
    }

    public static unsafe int elementId_button27
    {
      get
      {
        int elementIdButton27;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button27, (void*) &elementIdButton27);
        return elementIdButton27;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button27, (void*) &value);
      }
    }

    public static unsafe int elementId_button28
    {
      get
      {
        int elementIdButton28;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button28, (void*) &elementIdButton28);
        return elementIdButton28;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button28, (void*) &value);
      }
    }

    public static unsafe int elementId_button29
    {
      get
      {
        int elementIdButton29;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button29, (void*) &elementIdButton29);
        return elementIdButton29;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button29, (void*) &value);
      }
    }

    public static unsafe int elementId_button30
    {
      get
      {
        int elementIdButton30;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button30, (void*) &elementIdButton30);
        return elementIdButton30;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button30, (void*) &value);
      }
    }

    public static unsafe int elementId_button31
    {
      get
      {
        int elementIdButton31;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button31, (void*) &elementIdButton31);
        return elementIdButton31;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button31, (void*) &value);
      }
    }

    public static unsafe int elementId_button32
    {
      get
      {
        int elementIdButton32;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button32, (void*) &elementIdButton32);
        return elementIdButton32;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button32, (void*) &value);
      }
    }

    public static unsafe int elementId_hat1Up
    {
      get
      {
        int elementIdHat1Up;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1Up, (void*) &elementIdHat1Up);
        return elementIdHat1Up;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1Up, (void*) &value);
      }
    }

    public static unsafe int elementId_hat1UpRight
    {
      get
      {
        int elementIdHat1UpRight;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1UpRight, (void*) &elementIdHat1UpRight);
        return elementIdHat1UpRight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1UpRight, (void*) &value);
      }
    }

    public static unsafe int elementId_hat1Right
    {
      get
      {
        int elementIdHat1Right;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1Right, (void*) &elementIdHat1Right);
        return elementIdHat1Right;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1Right, (void*) &value);
      }
    }

    public static unsafe int elementId_hat1DownRight
    {
      get
      {
        int elementIdHat1DownRight;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1DownRight, (void*) &elementIdHat1DownRight);
        return elementIdHat1DownRight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1DownRight, (void*) &value);
      }
    }

    public static unsafe int elementId_hat1Down
    {
      get
      {
        int elementIdHat1Down;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1Down, (void*) &elementIdHat1Down);
        return elementIdHat1Down;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1Down, (void*) &value);
      }
    }

    public static unsafe int elementId_hat1DownLeft
    {
      get
      {
        int elementIdHat1DownLeft;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1DownLeft, (void*) &elementIdHat1DownLeft);
        return elementIdHat1DownLeft;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1DownLeft, (void*) &value);
      }
    }

    public static unsafe int elementId_hat1Left
    {
      get
      {
        int elementIdHat1Left;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1Left, (void*) &elementIdHat1Left);
        return elementIdHat1Left;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1Left, (void*) &value);
      }
    }

    public static unsafe int elementId_hat1UpLeft
    {
      get
      {
        int elementIdHat1UpLeft;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1UpLeft, (void*) &elementIdHat1UpLeft);
        return elementIdHat1UpLeft;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1UpLeft, (void*) &value);
      }
    }

    public static unsafe int elementId_hat2Up
    {
      get
      {
        int elementIdHat2Up;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2Up, (void*) &elementIdHat2Up);
        return elementIdHat2Up;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2Up, (void*) &value);
      }
    }

    public static unsafe int elementId_hat2UpRight
    {
      get
      {
        int elementIdHat2UpRight;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2UpRight, (void*) &elementIdHat2UpRight);
        return elementIdHat2UpRight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2UpRight, (void*) &value);
      }
    }

    public static unsafe int elementId_hat2Right
    {
      get
      {
        int elementIdHat2Right;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2Right, (void*) &elementIdHat2Right);
        return elementIdHat2Right;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2Right, (void*) &value);
      }
    }

    public static unsafe int elementId_hat2DownRight
    {
      get
      {
        int elementIdHat2DownRight;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2DownRight, (void*) &elementIdHat2DownRight);
        return elementIdHat2DownRight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2DownRight, (void*) &value);
      }
    }

    public static unsafe int elementId_hat2Down
    {
      get
      {
        int elementIdHat2Down;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2Down, (void*) &elementIdHat2Down);
        return elementIdHat2Down;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2Down, (void*) &value);
      }
    }

    public static unsafe int elementId_hat2DownLeft
    {
      get
      {
        int elementIdHat2DownLeft;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2DownLeft, (void*) &elementIdHat2DownLeft);
        return elementIdHat2DownLeft;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2DownLeft, (void*) &value);
      }
    }

    public static unsafe int elementId_hat2Left
    {
      get
      {
        int elementIdHat2Left;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2Left, (void*) &elementIdHat2Left);
        return elementIdHat2Left;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2Left, (void*) &value);
      }
    }

    public static unsafe int elementId_hat2UpLeft
    {
      get
      {
        int elementIdHat2UpLeft;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2UpLeft, (void*) &elementIdHat2UpLeft);
        return elementIdHat2UpLeft;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2UpLeft, (void*) &value);
      }
    }

    public static unsafe int elementId_hat1
    {
      get
      {
        int elementIdHat1;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1, (void*) &elementIdHat1);
        return elementIdHat1;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1, (void*) &value);
      }
    }

    public static unsafe int elementId_hat2
    {
      get
      {
        int elementIdHat2;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2, (void*) &elementIdHat2);
        return elementIdHat2;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2, (void*) &value);
      }
    }

    public static unsafe int elementId_throttle1
    {
      get
      {
        int elementIdThrottle1;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_throttle1, (void*) &elementIdThrottle1);
        return elementIdThrottle1;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_throttle1, (void*) &value);
      }
    }

    public static unsafe int elementId_throttle2
    {
      get
      {
        int elementIdThrottle2;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_throttle2, (void*) &elementIdThrottle2);
        return elementIdThrottle2;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_throttle2, (void*) &value);
      }
    }

    public static unsafe int elementId_stick
    {
      get
      {
        int elementIdStick;
        IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_stick, (void*) &elementIdStick);
        return elementIdStick;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_stick, (void*) &value);
      }
    }
  }
}
