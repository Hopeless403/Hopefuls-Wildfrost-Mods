﻿// Decompiled with JetBrains decompiler
// Type: Rewired.HOTASTemplate
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
  public sealed class HOTASTemplate : ControllerTemplate
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_typeGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickX;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickY;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickRotate;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickMiniStick1X;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickMiniStick1Y;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickMiniStick1Press;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickMiniStick2X;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickMiniStick2Y;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickMiniStick2Press;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickTrigger;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickTriggerStage2;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickPinkyButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickPinkyTrigger;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickButton1;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickButton2;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickButton3;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickButton4;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickButton5;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickButton6;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickButton7;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickButton8;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickButton9;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickButton10;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickBaseButton1;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickBaseButton2;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickBaseButton3;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickBaseButton4;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickBaseButton5;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickBaseButton6;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickBaseButton7;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickBaseButton8;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickBaseButton9;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickBaseButton10;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickBaseButton11;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickBaseButton12;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat1Up;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat1UpRight;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat1Right;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat1DownRight;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat1Down;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat1DownLeft;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat1Left;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat1Up_Left;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat2Up;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat2Up_right;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat2Right;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat2Down_Right;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat2Down;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat2Down_Left;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat2Left;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat2Up_Left;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat3Up;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat3Up_Right;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat3Right;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat3Down_Right;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat3Down;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat3Down_Left;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat3Left;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat3Up_Left;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat4Up;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat4Up_Right;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat4Right;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat4Down_Right;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat4Down;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat4Down_Left;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat4Left;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat4Up_Left;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_mode1;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_mode2;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_mode3;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttle1Axis;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttle2Axis;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttle1MinDetent;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttle2MinDetent;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleButton1;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleButton2;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleButton3;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleButton4;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleButton5;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleButton6;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleButton7;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleButton8;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleButton9;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleButton10;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleBaseButton1;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleBaseButton2;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleBaseButton3;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleBaseButton4;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleBaseButton5;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleBaseButton6;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleBaseButton7;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleBaseButton8;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleBaseButton9;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleBaseButton10;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleBaseButton11;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleBaseButton12;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleBaseButton13;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleBaseButton14;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleBaseButton15;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleSlider1;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleSlider2;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleSlider3;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleSlider4;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleDial1;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleDial2;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleDial3;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleDial4;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleMiniStickX;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleMiniStickY;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleMiniStickPress;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleWheel1Forward;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleWheel1Back;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleWheel1Press;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleWheel2Forward;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleWheel2Back;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleWheel2Press;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleWheel3Forward;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleWheel3Back;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleWheel3Press;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat1Up;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat1Up_Right;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat1Right;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat1Down_Right;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat1Down;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat1Down_Left;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat1Left;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat1Up_Left;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat2Up;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat2Up_Right;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat2Right;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat2Down_Right;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat2Down;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat2Down_Left;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat2Left;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat2Up_Left;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat3Up;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat3Up_Right;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat3Right;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat3Down_Right;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat3Down;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat3Down_Left;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat3Left;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat3Up_Left;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat4Up;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat4Up_Right;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat4Right;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat4Down_Right;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat4Down;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat4Down_Left;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat4Left;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat4Up_Left;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftPedal;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightPedal;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_slidePedals;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stick;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickMiniStick1;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickMiniStick2;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat1;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat2;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat3;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat4;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttle1;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttle2;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleMiniStick;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat1;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat2;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat3;
    private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat4;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickTrigger_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickTriggerStage2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickPinkyButton_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickPinkyTrigger_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton11_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton12_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_mode1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_mode2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_mode3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton11_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton12_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton13_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton14_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton15_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleSlider1_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleSlider2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleSlider3_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleSlider4_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleDial1_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleDial2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleDial3_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleDial4_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel1Forward_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel1Back_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel1Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel2Forward_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel2Back_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel2Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel3Forward_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel3Back_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel3Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_leftPedal_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_rightPedal_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_slidePedals_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stick_Private_Virtual_Final_New_get_IControllerTemplateStick_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickMiniStick1_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickMiniStick2_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickHat1_Private_Virtual_Final_New_get_IControllerTemplateHat_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickHat2_Private_Virtual_Final_New_get_IControllerTemplateHat_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickHat3_Private_Virtual_Final_New_get_IControllerTemplateHat_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickHat4_Private_Virtual_Final_New_get_IControllerTemplateHat_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttle1_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttle2_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleMiniStick_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleHat1_Private_Virtual_Final_New_get_IControllerTemplateHat_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleHat2_Private_Virtual_Final_New_get_IControllerTemplateHat_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleHat3_Private_Virtual_Final_New_get_IControllerTemplateHat_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleHat4_Private_Virtual_Final_New_get_IControllerTemplateHat_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EstickTrigger
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137120, XrefRangeEnd = 137123, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickTrigger_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EstickTriggerStage2
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137123, XrefRangeEnd = 137126, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickTriggerStage2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EstickPinkyButton
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137126, XrefRangeEnd = 137129, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickPinkyButton_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EstickPinkyTrigger
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137129, XrefRangeEnd = 137132, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickPinkyTrigger_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EstickButton1
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137132, XrefRangeEnd = 137135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EstickButton2
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137135, XrefRangeEnd = 137138, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EstickButton3
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137138, XrefRangeEnd = 137141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EstickButton4
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137141, XrefRangeEnd = 137144, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EstickButton5
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137144, XrefRangeEnd = 137147, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EstickButton6
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137147, XrefRangeEnd = 137150, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EstickButton7
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137150, XrefRangeEnd = 137153, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EstickButton8
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137153, XrefRangeEnd = 137156, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EstickButton9
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137156, XrefRangeEnd = 137159, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EstickButton10
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137159, XrefRangeEnd = 137162, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EstickBaseButton1
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137162, XrefRangeEnd = 137165, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EstickBaseButton2
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137165, XrefRangeEnd = 137168, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EstickBaseButton3
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137168, XrefRangeEnd = 137171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EstickBaseButton4
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137171, XrefRangeEnd = 137174, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EstickBaseButton5
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137174, XrefRangeEnd = 137177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EstickBaseButton6
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137177, XrefRangeEnd = 137180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EstickBaseButton7
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137180, XrefRangeEnd = 137183, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EstickBaseButton8
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137183, XrefRangeEnd = 137186, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EstickBaseButton9
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137186, XrefRangeEnd = 137189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EstickBaseButton10
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137189, XrefRangeEnd = 137192, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EstickBaseButton11
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137192, XrefRangeEnd = 137195, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton11_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EstickBaseButton12
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137195, XrefRangeEnd = 137198, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton12_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002Emode1
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137198, XrefRangeEnd = 137201, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_mode1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002Emode2
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137201, XrefRangeEnd = 137204, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_mode2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002Emode3
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137204, XrefRangeEnd = 137207, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_mode3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EthrottleButton1
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137207, XrefRangeEnd = 137210, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EthrottleButton2
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137210, XrefRangeEnd = 137213, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EthrottleButton3
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137213, XrefRangeEnd = 137216, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EthrottleButton4
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137216, XrefRangeEnd = 137219, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EthrottleButton5
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137219, XrefRangeEnd = 137222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EthrottleButton6
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137222, XrefRangeEnd = 137225, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EthrottleButton7
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137225, XrefRangeEnd = 137228, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EthrottleButton8
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137228, XrefRangeEnd = 137231, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EthrottleButton9
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137231, XrefRangeEnd = 137234, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EthrottleButton10
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137234, XrefRangeEnd = 137237, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EthrottleBaseButton1
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137237, XrefRangeEnd = 137240, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EthrottleBaseButton2
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137240, XrefRangeEnd = 137243, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EthrottleBaseButton3
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137243, XrefRangeEnd = 137246, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EthrottleBaseButton4
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137246, XrefRangeEnd = 137249, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EthrottleBaseButton5
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137249, XrefRangeEnd = 137252, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EthrottleBaseButton6
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137252, XrefRangeEnd = 137255, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EthrottleBaseButton7
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137255, XrefRangeEnd = 137258, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EthrottleBaseButton8
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137258, XrefRangeEnd = 137261, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EthrottleBaseButton9
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137261, XrefRangeEnd = 137264, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EthrottleBaseButton10
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137264, XrefRangeEnd = 137267, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EthrottleBaseButton11
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137267, XrefRangeEnd = 137270, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton11_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EthrottleBaseButton12
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137270, XrefRangeEnd = 137273, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton12_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EthrottleBaseButton13
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137273, XrefRangeEnd = 137276, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton13_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EthrottleBaseButton14
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137276, XrefRangeEnd = 137279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton14_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EthrottleBaseButton15
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137279, XrefRangeEnd = 137282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton15_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateAxis Rewired\u002EIHOTASTemplate\u002EthrottleSlider1
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137282, XrefRangeEnd = 137285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleSlider1_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateAxis) null : new IControllerTemplateAxis(pointer);
      }
    }

    public virtual unsafe IControllerTemplateAxis Rewired\u002EIHOTASTemplate\u002EthrottleSlider2
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137285, XrefRangeEnd = 137288, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleSlider2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateAxis) null : new IControllerTemplateAxis(pointer);
      }
    }

    public virtual unsafe IControllerTemplateAxis Rewired\u002EIHOTASTemplate\u002EthrottleSlider3
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137288, XrefRangeEnd = 137291, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleSlider3_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateAxis) null : new IControllerTemplateAxis(pointer);
      }
    }

    public virtual unsafe IControllerTemplateAxis Rewired\u002EIHOTASTemplate\u002EthrottleSlider4
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137291, XrefRangeEnd = 137294, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleSlider4_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateAxis) null : new IControllerTemplateAxis(pointer);
      }
    }

    public virtual unsafe IControllerTemplateAxis Rewired\u002EIHOTASTemplate\u002EthrottleDial1
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137294, XrefRangeEnd = 137297, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleDial1_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateAxis) null : new IControllerTemplateAxis(pointer);
      }
    }

    public virtual unsafe IControllerTemplateAxis Rewired\u002EIHOTASTemplate\u002EthrottleDial2
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137297, XrefRangeEnd = 137300, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleDial2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateAxis) null : new IControllerTemplateAxis(pointer);
      }
    }

    public virtual unsafe IControllerTemplateAxis Rewired\u002EIHOTASTemplate\u002EthrottleDial3
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137300, XrefRangeEnd = 137303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleDial3_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateAxis) null : new IControllerTemplateAxis(pointer);
      }
    }

    public virtual unsafe IControllerTemplateAxis Rewired\u002EIHOTASTemplate\u002EthrottleDial4
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137303, XrefRangeEnd = 137306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleDial4_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateAxis) null : new IControllerTemplateAxis(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EthrottleWheel1Forward
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137306, XrefRangeEnd = 137309, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel1Forward_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EthrottleWheel1Back
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137309, XrefRangeEnd = 137312, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel1Back_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EthrottleWheel1Press
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137312, XrefRangeEnd = 137315, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel1Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EthrottleWheel2Forward
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137315, XrefRangeEnd = 137318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel2Forward_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EthrottleWheel2Back
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137318, XrefRangeEnd = 137321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel2Back_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EthrottleWheel2Press
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137321, XrefRangeEnd = 137324, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel2Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EthrottleWheel3Forward
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137324, XrefRangeEnd = 137327, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel3Forward_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EthrottleWheel3Back
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137327, XrefRangeEnd = 137330, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel3Back_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateButton Rewired\u002EIHOTASTemplate\u002EthrottleWheel3Press
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137330, XrefRangeEnd = 137338, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel3Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateButton) null : new IControllerTemplateButton(pointer);
      }
    }

    public virtual unsafe IControllerTemplateAxis Rewired\u002EIHOTASTemplate\u002EleftPedal
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137338, XrefRangeEnd = 137341, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_leftPedal_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateAxis) null : new IControllerTemplateAxis(pointer);
      }
    }

    public virtual unsafe IControllerTemplateAxis Rewired\u002EIHOTASTemplate\u002ErightPedal
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137341, XrefRangeEnd = 137344, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_rightPedal_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateAxis) null : new IControllerTemplateAxis(pointer);
      }
    }

    public virtual unsafe IControllerTemplateAxis Rewired\u002EIHOTASTemplate\u002EslidePedals
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137344, XrefRangeEnd = 137347, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_slidePedals_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateAxis) null : new IControllerTemplateAxis(pointer);
      }
    }

    public virtual unsafe IControllerTemplateStick Rewired\u002EIHOTASTemplate\u002Estick
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137347, XrefRangeEnd = 137350, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stick_Private_Virtual_Final_New_get_IControllerTemplateStick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateStick) null : new IControllerTemplateStick(pointer);
      }
    }

    public virtual unsafe IControllerTemplateThumbStick Rewired\u002EIHOTASTemplate\u002EstickMiniStick1
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137350, XrefRangeEnd = 137353, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickMiniStick1_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateThumbStick) null : new IControllerTemplateThumbStick(pointer);
      }
    }

    public virtual unsafe IControllerTemplateThumbStick Rewired\u002EIHOTASTemplate\u002EstickMiniStick2
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137353, XrefRangeEnd = 137356, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickMiniStick2_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateThumbStick) null : new IControllerTemplateThumbStick(pointer);
      }
    }

    public virtual unsafe IControllerTemplateHat Rewired\u002EIHOTASTemplate\u002EstickHat1
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137356, XrefRangeEnd = 137359, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickHat1_Private_Virtual_Final_New_get_IControllerTemplateHat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateHat) null : new IControllerTemplateHat(pointer);
      }
    }

    public virtual unsafe IControllerTemplateHat Rewired\u002EIHOTASTemplate\u002EstickHat2
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137359, XrefRangeEnd = 137362, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickHat2_Private_Virtual_Final_New_get_IControllerTemplateHat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateHat) null : new IControllerTemplateHat(pointer);
      }
    }

    public virtual unsafe IControllerTemplateHat Rewired\u002EIHOTASTemplate\u002EstickHat3
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137362, XrefRangeEnd = 137365, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickHat3_Private_Virtual_Final_New_get_IControllerTemplateHat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateHat) null : new IControllerTemplateHat(pointer);
      }
    }

    public virtual unsafe IControllerTemplateHat Rewired\u002EIHOTASTemplate\u002EstickHat4
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137365, XrefRangeEnd = 137368, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickHat4_Private_Virtual_Final_New_get_IControllerTemplateHat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateHat) null : new IControllerTemplateHat(pointer);
      }
    }

    public virtual unsafe IControllerTemplateThrottle Rewired\u002EIHOTASTemplate\u002Ethrottle1
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137368, XrefRangeEnd = 137371, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttle1_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateThrottle) null : new IControllerTemplateThrottle(pointer);
      }
    }

    public virtual unsafe IControllerTemplateThrottle Rewired\u002EIHOTASTemplate\u002Ethrottle2
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137371, XrefRangeEnd = 137374, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttle2_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateThrottle) null : new IControllerTemplateThrottle(pointer);
      }
    }

    public virtual unsafe IControllerTemplateThumbStick Rewired\u002EIHOTASTemplate\u002EthrottleMiniStick
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137374, XrefRangeEnd = 137377, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleMiniStick_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateThumbStick) null : new IControllerTemplateThumbStick(pointer);
      }
    }

    public virtual unsafe IControllerTemplateHat Rewired\u002EIHOTASTemplate\u002EthrottleHat1
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137377, XrefRangeEnd = 137380, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleHat1_Private_Virtual_Final_New_get_IControllerTemplateHat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateHat) null : new IControllerTemplateHat(pointer);
      }
    }

    public virtual unsafe IControllerTemplateHat Rewired\u002EIHOTASTemplate\u002EthrottleHat2
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137380, XrefRangeEnd = 137383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleHat2_Private_Virtual_Final_New_get_IControllerTemplateHat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateHat) null : new IControllerTemplateHat(pointer);
      }
    }

    public virtual unsafe IControllerTemplateHat Rewired\u002EIHOTASTemplate\u002EthrottleHat3
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137383, XrefRangeEnd = 137386, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleHat3_Private_Virtual_Final_New_get_IControllerTemplateHat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateHat) null : new IControllerTemplateHat(pointer);
      }
    }

    public virtual unsafe IControllerTemplateHat Rewired\u002EIHOTASTemplate\u002EthrottleHat4
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137386, XrefRangeEnd = 137389, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleHat4_Private_Virtual_Final_New_get_IControllerTemplateHat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IControllerTemplateHat) null : new IControllerTemplateHat(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HOTASTemplate(Il2CppSystem.Object payload)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) payload)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HOTASTemplate()
    {
      Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired", nameof (HOTASTemplate));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr);
      HOTASTemplate.NativeFieldInfoPtr_typeGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (typeGuid));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickX));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickY));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickRotate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickRotate));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickMiniStick1X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickMiniStick1X));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickMiniStick1Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickMiniStick1Y));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickMiniStick1Press = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickMiniStick1Press));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickMiniStick2X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickMiniStick2X));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickMiniStick2Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickMiniStick2Y));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickMiniStick2Press = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickMiniStick2Press));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickTrigger));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickTriggerStage2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickTriggerStage2));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickPinkyButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickPinkyButton));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickPinkyTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickPinkyTrigger));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickButton1));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickButton2));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickButton3));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickButton4));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickButton5));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickButton6));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickButton7));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickButton8));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickButton9));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickButton10));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickBaseButton1));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickBaseButton2));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickBaseButton3));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickBaseButton4));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickBaseButton5));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickBaseButton6));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickBaseButton7));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickBaseButton8));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickBaseButton9));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickBaseButton10));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickBaseButton11));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickBaseButton12));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickHat1Up));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1UpRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickHat1UpRight));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickHat1Right));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1DownRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickHat1DownRight));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickHat1Down));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1DownLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickHat1DownLeft));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickHat1Left));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1Up_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickHat1Up_Left));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickHat2Up));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2Up_right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickHat2Up_right));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickHat2Right));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2Down_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickHat2Down_Right));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickHat2Down));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2Down_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickHat2Down_Left));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickHat2Left));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2Up_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickHat2Up_Left));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickHat3Up));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3Up_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickHat3Up_Right));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickHat3Right));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3Down_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickHat3Down_Right));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickHat3Down));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3Down_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickHat3Down_Left));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickHat3Left));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3Up_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickHat3Up_Left));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickHat4Up));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4Up_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickHat4Up_Right));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickHat4Right));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4Down_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickHat4Down_Right));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickHat4Down));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4Down_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickHat4Down_Left));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickHat4Left));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4Up_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickHat4Up_Left));
      HOTASTemplate.NativeFieldInfoPtr_elementId_mode1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_mode1));
      HOTASTemplate.NativeFieldInfoPtr_elementId_mode2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_mode2));
      HOTASTemplate.NativeFieldInfoPtr_elementId_mode3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_mode3));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttle1Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttle1Axis));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttle2Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttle2Axis));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttle1MinDetent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttle1MinDetent));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttle2MinDetent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttle2MinDetent));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleButton1));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleButton2));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleButton3));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleButton4));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleButton5));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleButton6));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleButton7));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleButton8));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleButton9));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleButton10));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleBaseButton1));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleBaseButton2));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleBaseButton3));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleBaseButton4));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleBaseButton5));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleBaseButton6));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleBaseButton7));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleBaseButton8));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleBaseButton9));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleBaseButton10));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleBaseButton11));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleBaseButton12));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleBaseButton13));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleBaseButton14));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleBaseButton15));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleSlider1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleSlider1));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleSlider2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleSlider2));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleSlider3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleSlider3));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleSlider4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleSlider4));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleDial1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleDial1));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleDial2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleDial2));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleDial3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleDial3));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleDial4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleDial4));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleMiniStickX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleMiniStickX));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleMiniStickY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleMiniStickY));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleMiniStickPress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleMiniStickPress));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel1Forward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleWheel1Forward));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel1Back = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleWheel1Back));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel1Press = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleWheel1Press));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel2Forward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleWheel2Forward));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel2Back = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleWheel2Back));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel2Press = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleWheel2Press));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel3Forward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleWheel3Forward));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel3Back = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleWheel3Back));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel3Press = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleWheel3Press));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleHat1Up));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1Up_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleHat1Up_Right));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleHat1Right));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1Down_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleHat1Down_Right));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleHat1Down));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1Down_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleHat1Down_Left));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleHat1Left));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1Up_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleHat1Up_Left));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleHat2Up));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2Up_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleHat2Up_Right));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleHat2Right));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2Down_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleHat2Down_Right));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleHat2Down));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2Down_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleHat2Down_Left));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleHat2Left));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2Up_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleHat2Up_Left));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleHat3Up));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3Up_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleHat3Up_Right));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleHat3Right));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3Down_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleHat3Down_Right));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleHat3Down));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3Down_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleHat3Down_Left));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleHat3Left));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3Up_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleHat3Up_Left));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleHat4Up));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4Up_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleHat4Up_Right));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleHat4Right));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4Down_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleHat4Down_Right));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleHat4Down));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4Down_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleHat4Down_Left));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleHat4Left));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4Up_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleHat4Up_Left));
      HOTASTemplate.NativeFieldInfoPtr_elementId_leftPedal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_leftPedal));
      HOTASTemplate.NativeFieldInfoPtr_elementId_rightPedal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_rightPedal));
      HOTASTemplate.NativeFieldInfoPtr_elementId_slidePedals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_slidePedals));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stick));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickMiniStick1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickMiniStick1));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickMiniStick2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickMiniStick2));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickHat1));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickHat2));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickHat3));
      HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_stickHat4));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttle1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttle1));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttle2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttle2));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleMiniStick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleMiniStick));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleHat1));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleHat2));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleHat3));
      HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, nameof (elementId_throttleHat4));
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickTrigger_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677756);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickTriggerStage2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677757);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickPinkyButton_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677758);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickPinkyTrigger_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677759);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677760);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677761);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677762);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677763);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677764);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677765);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677766);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677767);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677768);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677769);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677770);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677771);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677772);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677773);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677774);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677775);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677776);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677777);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677778);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677779);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton11_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677780);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton12_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677781);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_mode1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677782);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_mode2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677783);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_mode3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677784);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677785);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677786);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677787);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677788);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677789);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677790);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677791);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677792);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677793);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677794);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677795);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677796);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677797);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677798);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677799);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677800);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677801);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677802);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677803);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677804);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton11_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677805);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton12_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677806);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton13_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677807);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton14_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677808);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton15_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677809);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleSlider1_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677810);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleSlider2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677811);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleSlider3_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677812);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleSlider4_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677813);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleDial1_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677814);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleDial2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677815);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleDial3_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677816);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleDial4_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677817);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel1Forward_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677818);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel1Back_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677819);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel1Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677820);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel2Forward_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677821);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel2Back_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677822);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel2Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677823);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel3Forward_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677824);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel3Back_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677825);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel3Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677826);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_leftPedal_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677827);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_rightPedal_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677828);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_slidePedals_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677829);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stick_Private_Virtual_Final_New_get_IControllerTemplateStick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677830);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickMiniStick1_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677831);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickMiniStick2_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677832);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickHat1_Private_Virtual_Final_New_get_IControllerTemplateHat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677833);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickHat2_Private_Virtual_Final_New_get_IControllerTemplateHat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677834);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickHat3_Private_Virtual_Final_New_get_IControllerTemplateHat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677835);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickHat4_Private_Virtual_Final_New_get_IControllerTemplateHat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677836);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttle1_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677837);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttle2_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677838);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleMiniStick_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677839);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleHat1_Private_Virtual_Final_New_get_IControllerTemplateHat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677840);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleHat2_Private_Virtual_Final_New_get_IControllerTemplateHat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677841);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleHat3_Private_Virtual_Final_New_get_IControllerTemplateHat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677842);
      HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleHat4_Private_Virtual_Final_New_get_IControllerTemplateHat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677843);
      HOTASTemplate.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100677844);
    }

    public HOTASTemplate(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe Il2CppSystem.Guid typeGuid
    {
      get
      {
        Il2CppSystem.Guid typeGuid;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_typeGuid, (void*) &typeGuid);
        return typeGuid;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_typeGuid, (void*) &value);
      }
    }

    public static unsafe int elementId_stickX
    {
      get
      {
        int elementIdStickX;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickX, (void*) &elementIdStickX);
        return elementIdStickX;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickX, (void*) &value);
      }
    }

    public static unsafe int elementId_stickY
    {
      get
      {
        int elementIdStickY;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickY, (void*) &elementIdStickY);
        return elementIdStickY;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickY, (void*) &value);
      }
    }

    public static unsafe int elementId_stickRotate
    {
      get
      {
        int elementIdStickRotate;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickRotate, (void*) &elementIdStickRotate);
        return elementIdStickRotate;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickRotate, (void*) &value);
      }
    }

    public static unsafe int elementId_stickMiniStick1X
    {
      get
      {
        int stickMiniStick1X;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickMiniStick1X, (void*) &stickMiniStick1X);
        return stickMiniStick1X;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickMiniStick1X, (void*) &value);
      }
    }

    public static unsafe int elementId_stickMiniStick1Y
    {
      get
      {
        int stickMiniStick1Y;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickMiniStick1Y, (void*) &stickMiniStick1Y);
        return stickMiniStick1Y;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickMiniStick1Y, (void*) &value);
      }
    }

    public static unsafe int elementId_stickMiniStick1Press
    {
      get
      {
        int stickMiniStick1Press;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickMiniStick1Press, (void*) &stickMiniStick1Press);
        return stickMiniStick1Press;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickMiniStick1Press, (void*) &value);
      }
    }

    public static unsafe int elementId_stickMiniStick2X
    {
      get
      {
        int stickMiniStick2X;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickMiniStick2X, (void*) &stickMiniStick2X);
        return stickMiniStick2X;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickMiniStick2X, (void*) &value);
      }
    }

    public static unsafe int elementId_stickMiniStick2Y
    {
      get
      {
        int stickMiniStick2Y;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickMiniStick2Y, (void*) &stickMiniStick2Y);
        return stickMiniStick2Y;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickMiniStick2Y, (void*) &value);
      }
    }

    public static unsafe int elementId_stickMiniStick2Press
    {
      get
      {
        int stickMiniStick2Press;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickMiniStick2Press, (void*) &stickMiniStick2Press);
        return stickMiniStick2Press;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickMiniStick2Press, (void*) &value);
      }
    }

    public static unsafe int elementId_stickTrigger
    {
      get
      {
        int elementIdStickTrigger;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickTrigger, (void*) &elementIdStickTrigger);
        return elementIdStickTrigger;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickTrigger, (void*) &value);
      }
    }

    public static unsafe int elementId_stickTriggerStage2
    {
      get
      {
        int stickTriggerStage2;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickTriggerStage2, (void*) &stickTriggerStage2);
        return stickTriggerStage2;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickTriggerStage2, (void*) &value);
      }
    }

    public static unsafe int elementId_stickPinkyButton
    {
      get
      {
        int stickPinkyButton;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickPinkyButton, (void*) &stickPinkyButton);
        return stickPinkyButton;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickPinkyButton, (void*) &value);
      }
    }

    public static unsafe int elementId_stickPinkyTrigger
    {
      get
      {
        int stickPinkyTrigger;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickPinkyTrigger, (void*) &stickPinkyTrigger);
        return stickPinkyTrigger;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickPinkyTrigger, (void*) &value);
      }
    }

    public static unsafe int elementId_stickButton1
    {
      get
      {
        int elementIdStickButton1;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton1, (void*) &elementIdStickButton1);
        return elementIdStickButton1;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton1, (void*) &value);
      }
    }

    public static unsafe int elementId_stickButton2
    {
      get
      {
        int elementIdStickButton2;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton2, (void*) &elementIdStickButton2);
        return elementIdStickButton2;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton2, (void*) &value);
      }
    }

    public static unsafe int elementId_stickButton3
    {
      get
      {
        int elementIdStickButton3;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton3, (void*) &elementIdStickButton3);
        return elementIdStickButton3;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton3, (void*) &value);
      }
    }

    public static unsafe int elementId_stickButton4
    {
      get
      {
        int elementIdStickButton4;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton4, (void*) &elementIdStickButton4);
        return elementIdStickButton4;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton4, (void*) &value);
      }
    }

    public static unsafe int elementId_stickButton5
    {
      get
      {
        int elementIdStickButton5;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton5, (void*) &elementIdStickButton5);
        return elementIdStickButton5;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton5, (void*) &value);
      }
    }

    public static unsafe int elementId_stickButton6
    {
      get
      {
        int elementIdStickButton6;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton6, (void*) &elementIdStickButton6);
        return elementIdStickButton6;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton6, (void*) &value);
      }
    }

    public static unsafe int elementId_stickButton7
    {
      get
      {
        int elementIdStickButton7;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton7, (void*) &elementIdStickButton7);
        return elementIdStickButton7;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton7, (void*) &value);
      }
    }

    public static unsafe int elementId_stickButton8
    {
      get
      {
        int elementIdStickButton8;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton8, (void*) &elementIdStickButton8);
        return elementIdStickButton8;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton8, (void*) &value);
      }
    }

    public static unsafe int elementId_stickButton9
    {
      get
      {
        int elementIdStickButton9;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton9, (void*) &elementIdStickButton9);
        return elementIdStickButton9;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton9, (void*) &value);
      }
    }

    public static unsafe int elementId_stickButton10
    {
      get
      {
        int elementIdStickButton10;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton10, (void*) &elementIdStickButton10);
        return elementIdStickButton10;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton10, (void*) &value);
      }
    }

    public static unsafe int elementId_stickBaseButton1
    {
      get
      {
        int stickBaseButton1;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton1, (void*) &stickBaseButton1);
        return stickBaseButton1;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton1, (void*) &value);
      }
    }

    public static unsafe int elementId_stickBaseButton2
    {
      get
      {
        int stickBaseButton2;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton2, (void*) &stickBaseButton2);
        return stickBaseButton2;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton2, (void*) &value);
      }
    }

    public static unsafe int elementId_stickBaseButton3
    {
      get
      {
        int stickBaseButton3;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton3, (void*) &stickBaseButton3);
        return stickBaseButton3;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton3, (void*) &value);
      }
    }

    public static unsafe int elementId_stickBaseButton4
    {
      get
      {
        int stickBaseButton4;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton4, (void*) &stickBaseButton4);
        return stickBaseButton4;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton4, (void*) &value);
      }
    }

    public static unsafe int elementId_stickBaseButton5
    {
      get
      {
        int stickBaseButton5;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton5, (void*) &stickBaseButton5);
        return stickBaseButton5;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton5, (void*) &value);
      }
    }

    public static unsafe int elementId_stickBaseButton6
    {
      get
      {
        int stickBaseButton6;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton6, (void*) &stickBaseButton6);
        return stickBaseButton6;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton6, (void*) &value);
      }
    }

    public static unsafe int elementId_stickBaseButton7
    {
      get
      {
        int stickBaseButton7;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton7, (void*) &stickBaseButton7);
        return stickBaseButton7;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton7, (void*) &value);
      }
    }

    public static unsafe int elementId_stickBaseButton8
    {
      get
      {
        int stickBaseButton8;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton8, (void*) &stickBaseButton8);
        return stickBaseButton8;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton8, (void*) &value);
      }
    }

    public static unsafe int elementId_stickBaseButton9
    {
      get
      {
        int stickBaseButton9;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton9, (void*) &stickBaseButton9);
        return stickBaseButton9;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton9, (void*) &value);
      }
    }

    public static unsafe int elementId_stickBaseButton10
    {
      get
      {
        int stickBaseButton10;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton10, (void*) &stickBaseButton10);
        return stickBaseButton10;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton10, (void*) &value);
      }
    }

    public static unsafe int elementId_stickBaseButton11
    {
      get
      {
        int stickBaseButton11;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton11, (void*) &stickBaseButton11);
        return stickBaseButton11;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton11, (void*) &value);
      }
    }

    public static unsafe int elementId_stickBaseButton12
    {
      get
      {
        int stickBaseButton12;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton12, (void*) &stickBaseButton12);
        return stickBaseButton12;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton12, (void*) &value);
      }
    }

    public static unsafe int elementId_stickHat1Up
    {
      get
      {
        int elementIdStickHat1Up;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1Up, (void*) &elementIdStickHat1Up);
        return elementIdStickHat1Up;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1Up, (void*) &value);
      }
    }

    public static unsafe int elementId_stickHat1UpRight
    {
      get
      {
        int stickHat1UpRight;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1UpRight, (void*) &stickHat1UpRight);
        return stickHat1UpRight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1UpRight, (void*) &value);
      }
    }

    public static unsafe int elementId_stickHat1Right
    {
      get
      {
        int idStickHat1Right;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1Right, (void*) &idStickHat1Right);
        return idStickHat1Right;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1Right, (void*) &value);
      }
    }

    public static unsafe int elementId_stickHat1DownRight
    {
      get
      {
        int stickHat1DownRight;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1DownRight, (void*) &stickHat1DownRight);
        return stickHat1DownRight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1DownRight, (void*) &value);
      }
    }

    public static unsafe int elementId_stickHat1Down
    {
      get
      {
        int elementIdStickHat1Down;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1Down, (void*) &elementIdStickHat1Down);
        return elementIdStickHat1Down;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1Down, (void*) &value);
      }
    }

    public static unsafe int elementId_stickHat1DownLeft
    {
      get
      {
        int stickHat1DownLeft;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1DownLeft, (void*) &stickHat1DownLeft);
        return stickHat1DownLeft;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1DownLeft, (void*) &value);
      }
    }

    public static unsafe int elementId_stickHat1Left
    {
      get
      {
        int elementIdStickHat1Left;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1Left, (void*) &elementIdStickHat1Left);
        return elementIdStickHat1Left;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1Left, (void*) &value);
      }
    }

    public static unsafe int elementId_stickHat1Up_Left
    {
      get
      {
        int idStickHat1UpLeft;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1Up_Left, (void*) &idStickHat1UpLeft);
        return idStickHat1UpLeft;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1Up_Left, (void*) &value);
      }
    }

    public static unsafe int elementId_stickHat2Up
    {
      get
      {
        int elementIdStickHat2Up;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2Up, (void*) &elementIdStickHat2Up);
        return elementIdStickHat2Up;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2Up, (void*) &value);
      }
    }

    public static unsafe int elementId_stickHat2Up_right
    {
      get
      {
        int stickHat2UpRight;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2Up_right, (void*) &stickHat2UpRight);
        return stickHat2UpRight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2Up_right, (void*) &value);
      }
    }

    public static unsafe int elementId_stickHat2Right
    {
      get
      {
        int idStickHat2Right;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2Right, (void*) &idStickHat2Right);
        return idStickHat2Right;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2Right, (void*) &value);
      }
    }

    public static unsafe int elementId_stickHat2Down_Right
    {
      get
      {
        int stickHat2DownRight;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2Down_Right, (void*) &stickHat2DownRight);
        return stickHat2DownRight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2Down_Right, (void*) &value);
      }
    }

    public static unsafe int elementId_stickHat2Down
    {
      get
      {
        int elementIdStickHat2Down;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2Down, (void*) &elementIdStickHat2Down);
        return elementIdStickHat2Down;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2Down, (void*) &value);
      }
    }

    public static unsafe int elementId_stickHat2Down_Left
    {
      get
      {
        int stickHat2DownLeft;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2Down_Left, (void*) &stickHat2DownLeft);
        return stickHat2DownLeft;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2Down_Left, (void*) &value);
      }
    }

    public static unsafe int elementId_stickHat2Left
    {
      get
      {
        int elementIdStickHat2Left;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2Left, (void*) &elementIdStickHat2Left);
        return elementIdStickHat2Left;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2Left, (void*) &value);
      }
    }

    public static unsafe int elementId_stickHat2Up_Left
    {
      get
      {
        int idStickHat2UpLeft;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2Up_Left, (void*) &idStickHat2UpLeft);
        return idStickHat2UpLeft;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2Up_Left, (void*) &value);
      }
    }

    public static unsafe int elementId_stickHat3Up
    {
      get
      {
        int elementIdStickHat3Up;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3Up, (void*) &elementIdStickHat3Up);
        return elementIdStickHat3Up;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3Up, (void*) &value);
      }
    }

    public static unsafe int elementId_stickHat3Up_Right
    {
      get
      {
        int stickHat3UpRight;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3Up_Right, (void*) &stickHat3UpRight);
        return stickHat3UpRight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3Up_Right, (void*) &value);
      }
    }

    public static unsafe int elementId_stickHat3Right
    {
      get
      {
        int idStickHat3Right;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3Right, (void*) &idStickHat3Right);
        return idStickHat3Right;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3Right, (void*) &value);
      }
    }

    public static unsafe int elementId_stickHat3Down_Right
    {
      get
      {
        int stickHat3DownRight;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3Down_Right, (void*) &stickHat3DownRight);
        return stickHat3DownRight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3Down_Right, (void*) &value);
      }
    }

    public static unsafe int elementId_stickHat3Down
    {
      get
      {
        int elementIdStickHat3Down;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3Down, (void*) &elementIdStickHat3Down);
        return elementIdStickHat3Down;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3Down, (void*) &value);
      }
    }

    public static unsafe int elementId_stickHat3Down_Left
    {
      get
      {
        int stickHat3DownLeft;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3Down_Left, (void*) &stickHat3DownLeft);
        return stickHat3DownLeft;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3Down_Left, (void*) &value);
      }
    }

    public static unsafe int elementId_stickHat3Left
    {
      get
      {
        int elementIdStickHat3Left;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3Left, (void*) &elementIdStickHat3Left);
        return elementIdStickHat3Left;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3Left, (void*) &value);
      }
    }

    public static unsafe int elementId_stickHat3Up_Left
    {
      get
      {
        int idStickHat3UpLeft;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3Up_Left, (void*) &idStickHat3UpLeft);
        return idStickHat3UpLeft;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3Up_Left, (void*) &value);
      }
    }

    public static unsafe int elementId_stickHat4Up
    {
      get
      {
        int elementIdStickHat4Up;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4Up, (void*) &elementIdStickHat4Up);
        return elementIdStickHat4Up;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4Up, (void*) &value);
      }
    }

    public static unsafe int elementId_stickHat4Up_Right
    {
      get
      {
        int stickHat4UpRight;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4Up_Right, (void*) &stickHat4UpRight);
        return stickHat4UpRight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4Up_Right, (void*) &value);
      }
    }

    public static unsafe int elementId_stickHat4Right
    {
      get
      {
        int idStickHat4Right;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4Right, (void*) &idStickHat4Right);
        return idStickHat4Right;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4Right, (void*) &value);
      }
    }

    public static unsafe int elementId_stickHat4Down_Right
    {
      get
      {
        int stickHat4DownRight;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4Down_Right, (void*) &stickHat4DownRight);
        return stickHat4DownRight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4Down_Right, (void*) &value);
      }
    }

    public static unsafe int elementId_stickHat4Down
    {
      get
      {
        int elementIdStickHat4Down;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4Down, (void*) &elementIdStickHat4Down);
        return elementIdStickHat4Down;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4Down, (void*) &value);
      }
    }

    public static unsafe int elementId_stickHat4Down_Left
    {
      get
      {
        int stickHat4DownLeft;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4Down_Left, (void*) &stickHat4DownLeft);
        return stickHat4DownLeft;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4Down_Left, (void*) &value);
      }
    }

    public static unsafe int elementId_stickHat4Left
    {
      get
      {
        int elementIdStickHat4Left;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4Left, (void*) &elementIdStickHat4Left);
        return elementIdStickHat4Left;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4Left, (void*) &value);
      }
    }

    public static unsafe int elementId_stickHat4Up_Left
    {
      get
      {
        int idStickHat4UpLeft;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4Up_Left, (void*) &idStickHat4UpLeft);
        return idStickHat4UpLeft;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4Up_Left, (void*) &value);
      }
    }

    public static unsafe int elementId_mode1
    {
      get
      {
        int elementIdMode1;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_mode1, (void*) &elementIdMode1);
        return elementIdMode1;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_mode1, (void*) &value);
      }
    }

    public static unsafe int elementId_mode2
    {
      get
      {
        int elementIdMode2;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_mode2, (void*) &elementIdMode2);
        return elementIdMode2;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_mode2, (void*) &value);
      }
    }

    public static unsafe int elementId_mode3
    {
      get
      {
        int elementIdMode3;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_mode3, (void*) &elementIdMode3);
        return elementIdMode3;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_mode3, (void*) &value);
      }
    }

    public static unsafe int elementId_throttle1Axis
    {
      get
      {
        int elementIdThrottle1Axis;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttle1Axis, (void*) &elementIdThrottle1Axis);
        return elementIdThrottle1Axis;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttle1Axis, (void*) &value);
      }
    }

    public static unsafe int elementId_throttle2Axis
    {
      get
      {
        int elementIdThrottle2Axis;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttle2Axis, (void*) &elementIdThrottle2Axis);
        return elementIdThrottle2Axis;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttle2Axis, (void*) &value);
      }
    }

    public static unsafe int elementId_throttle1MinDetent
    {
      get
      {
        int throttle1MinDetent;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttle1MinDetent, (void*) &throttle1MinDetent);
        return throttle1MinDetent;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttle1MinDetent, (void*) &value);
      }
    }

    public static unsafe int elementId_throttle2MinDetent
    {
      get
      {
        int throttle2MinDetent;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttle2MinDetent, (void*) &throttle2MinDetent);
        return throttle2MinDetent;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttle2MinDetent, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleButton1
    {
      get
      {
        int idThrottleButton1;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton1, (void*) &idThrottleButton1);
        return idThrottleButton1;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton1, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleButton2
    {
      get
      {
        int idThrottleButton2;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton2, (void*) &idThrottleButton2);
        return idThrottleButton2;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton2, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleButton3
    {
      get
      {
        int idThrottleButton3;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton3, (void*) &idThrottleButton3);
        return idThrottleButton3;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton3, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleButton4
    {
      get
      {
        int idThrottleButton4;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton4, (void*) &idThrottleButton4);
        return idThrottleButton4;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton4, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleButton5
    {
      get
      {
        int idThrottleButton5;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton5, (void*) &idThrottleButton5);
        return idThrottleButton5;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton5, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleButton6
    {
      get
      {
        int idThrottleButton6;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton6, (void*) &idThrottleButton6);
        return idThrottleButton6;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton6, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleButton7
    {
      get
      {
        int idThrottleButton7;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton7, (void*) &idThrottleButton7);
        return idThrottleButton7;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton7, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleButton8
    {
      get
      {
        int idThrottleButton8;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton8, (void*) &idThrottleButton8);
        return idThrottleButton8;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton8, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleButton9
    {
      get
      {
        int idThrottleButton9;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton9, (void*) &idThrottleButton9);
        return idThrottleButton9;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton9, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleButton10
    {
      get
      {
        int throttleButton10;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton10, (void*) &throttleButton10);
        return throttleButton10;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton10, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleBaseButton1
    {
      get
      {
        int throttleBaseButton1;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton1, (void*) &throttleBaseButton1);
        return throttleBaseButton1;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton1, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleBaseButton2
    {
      get
      {
        int throttleBaseButton2;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton2, (void*) &throttleBaseButton2);
        return throttleBaseButton2;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton2, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleBaseButton3
    {
      get
      {
        int throttleBaseButton3;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton3, (void*) &throttleBaseButton3);
        return throttleBaseButton3;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton3, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleBaseButton4
    {
      get
      {
        int throttleBaseButton4;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton4, (void*) &throttleBaseButton4);
        return throttleBaseButton4;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton4, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleBaseButton5
    {
      get
      {
        int throttleBaseButton5;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton5, (void*) &throttleBaseButton5);
        return throttleBaseButton5;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton5, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleBaseButton6
    {
      get
      {
        int throttleBaseButton6;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton6, (void*) &throttleBaseButton6);
        return throttleBaseButton6;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton6, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleBaseButton7
    {
      get
      {
        int throttleBaseButton7;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton7, (void*) &throttleBaseButton7);
        return throttleBaseButton7;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton7, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleBaseButton8
    {
      get
      {
        int throttleBaseButton8;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton8, (void*) &throttleBaseButton8);
        return throttleBaseButton8;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton8, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleBaseButton9
    {
      get
      {
        int throttleBaseButton9;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton9, (void*) &throttleBaseButton9);
        return throttleBaseButton9;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton9, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleBaseButton10
    {
      get
      {
        int throttleBaseButton10;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton10, (void*) &throttleBaseButton10);
        return throttleBaseButton10;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton10, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleBaseButton11
    {
      get
      {
        int throttleBaseButton11;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton11, (void*) &throttleBaseButton11);
        return throttleBaseButton11;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton11, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleBaseButton12
    {
      get
      {
        int throttleBaseButton12;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton12, (void*) &throttleBaseButton12);
        return throttleBaseButton12;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton12, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleBaseButton13
    {
      get
      {
        int throttleBaseButton13;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton13, (void*) &throttleBaseButton13);
        return throttleBaseButton13;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton13, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleBaseButton14
    {
      get
      {
        int throttleBaseButton14;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton14, (void*) &throttleBaseButton14);
        return throttleBaseButton14;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton14, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleBaseButton15
    {
      get
      {
        int throttleBaseButton15;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton15, (void*) &throttleBaseButton15);
        return throttleBaseButton15;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton15, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleSlider1
    {
      get
      {
        int idThrottleSlider1;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleSlider1, (void*) &idThrottleSlider1);
        return idThrottleSlider1;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleSlider1, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleSlider2
    {
      get
      {
        int idThrottleSlider2;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleSlider2, (void*) &idThrottleSlider2);
        return idThrottleSlider2;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleSlider2, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleSlider3
    {
      get
      {
        int idThrottleSlider3;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleSlider3, (void*) &idThrottleSlider3);
        return idThrottleSlider3;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleSlider3, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleSlider4
    {
      get
      {
        int idThrottleSlider4;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleSlider4, (void*) &idThrottleSlider4);
        return idThrottleSlider4;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleSlider4, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleDial1
    {
      get
      {
        int elementIdThrottleDial1;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleDial1, (void*) &elementIdThrottleDial1);
        return elementIdThrottleDial1;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleDial1, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleDial2
    {
      get
      {
        int elementIdThrottleDial2;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleDial2, (void*) &elementIdThrottleDial2);
        return elementIdThrottleDial2;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleDial2, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleDial3
    {
      get
      {
        int elementIdThrottleDial3;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleDial3, (void*) &elementIdThrottleDial3);
        return elementIdThrottleDial3;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleDial3, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleDial4
    {
      get
      {
        int elementIdThrottleDial4;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleDial4, (void*) &elementIdThrottleDial4);
        return elementIdThrottleDial4;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleDial4, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleMiniStickX
    {
      get
      {
        int throttleMiniStickX;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleMiniStickX, (void*) &throttleMiniStickX);
        return throttleMiniStickX;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleMiniStickX, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleMiniStickY
    {
      get
      {
        int throttleMiniStickY;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleMiniStickY, (void*) &throttleMiniStickY);
        return throttleMiniStickY;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleMiniStickY, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleMiniStickPress
    {
      get
      {
        int throttleMiniStickPress;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleMiniStickPress, (void*) &throttleMiniStickPress);
        return throttleMiniStickPress;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleMiniStickPress, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleWheel1Forward
    {
      get
      {
        int throttleWheel1Forward;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel1Forward, (void*) &throttleWheel1Forward);
        return throttleWheel1Forward;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel1Forward, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleWheel1Back
    {
      get
      {
        int throttleWheel1Back;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel1Back, (void*) &throttleWheel1Back);
        return throttleWheel1Back;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel1Back, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleWheel1Press
    {
      get
      {
        int throttleWheel1Press;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel1Press, (void*) &throttleWheel1Press);
        return throttleWheel1Press;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel1Press, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleWheel2Forward
    {
      get
      {
        int throttleWheel2Forward;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel2Forward, (void*) &throttleWheel2Forward);
        return throttleWheel2Forward;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel2Forward, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleWheel2Back
    {
      get
      {
        int throttleWheel2Back;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel2Back, (void*) &throttleWheel2Back);
        return throttleWheel2Back;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel2Back, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleWheel2Press
    {
      get
      {
        int throttleWheel2Press;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel2Press, (void*) &throttleWheel2Press);
        return throttleWheel2Press;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel2Press, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleWheel3Forward
    {
      get
      {
        int throttleWheel3Forward;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel3Forward, (void*) &throttleWheel3Forward);
        return throttleWheel3Forward;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel3Forward, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleWheel3Back
    {
      get
      {
        int throttleWheel3Back;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel3Back, (void*) &throttleWheel3Back);
        return throttleWheel3Back;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel3Back, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleWheel3Press
    {
      get
      {
        int throttleWheel3Press;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel3Press, (void*) &throttleWheel3Press);
        return throttleWheel3Press;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel3Press, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleHat1Up
    {
      get
      {
        int idThrottleHat1Up;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1Up, (void*) &idThrottleHat1Up);
        return idThrottleHat1Up;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1Up, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleHat1Up_Right
    {
      get
      {
        int throttleHat1UpRight;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1Up_Right, (void*) &throttleHat1UpRight);
        return throttleHat1UpRight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1Up_Right, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleHat1Right
    {
      get
      {
        int throttleHat1Right;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1Right, (void*) &throttleHat1Right);
        return throttleHat1Right;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1Right, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleHat1Down_Right
    {
      get
      {
        int throttleHat1DownRight;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1Down_Right, (void*) &throttleHat1DownRight);
        return throttleHat1DownRight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1Down_Right, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleHat1Down
    {
      get
      {
        int throttleHat1Down;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1Down, (void*) &throttleHat1Down);
        return throttleHat1Down;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1Down, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleHat1Down_Left
    {
      get
      {
        int throttleHat1DownLeft;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1Down_Left, (void*) &throttleHat1DownLeft);
        return throttleHat1DownLeft;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1Down_Left, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleHat1Left
    {
      get
      {
        int throttleHat1Left;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1Left, (void*) &throttleHat1Left);
        return throttleHat1Left;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1Left, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleHat1Up_Left
    {
      get
      {
        int throttleHat1UpLeft;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1Up_Left, (void*) &throttleHat1UpLeft);
        return throttleHat1UpLeft;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1Up_Left, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleHat2Up
    {
      get
      {
        int idThrottleHat2Up;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2Up, (void*) &idThrottleHat2Up);
        return idThrottleHat2Up;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2Up, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleHat2Up_Right
    {
      get
      {
        int throttleHat2UpRight;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2Up_Right, (void*) &throttleHat2UpRight);
        return throttleHat2UpRight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2Up_Right, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleHat2Right
    {
      get
      {
        int throttleHat2Right;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2Right, (void*) &throttleHat2Right);
        return throttleHat2Right;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2Right, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleHat2Down_Right
    {
      get
      {
        int throttleHat2DownRight;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2Down_Right, (void*) &throttleHat2DownRight);
        return throttleHat2DownRight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2Down_Right, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleHat2Down
    {
      get
      {
        int throttleHat2Down;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2Down, (void*) &throttleHat2Down);
        return throttleHat2Down;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2Down, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleHat2Down_Left
    {
      get
      {
        int throttleHat2DownLeft;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2Down_Left, (void*) &throttleHat2DownLeft);
        return throttleHat2DownLeft;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2Down_Left, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleHat2Left
    {
      get
      {
        int throttleHat2Left;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2Left, (void*) &throttleHat2Left);
        return throttleHat2Left;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2Left, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleHat2Up_Left
    {
      get
      {
        int throttleHat2UpLeft;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2Up_Left, (void*) &throttleHat2UpLeft);
        return throttleHat2UpLeft;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2Up_Left, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleHat3Up
    {
      get
      {
        int idThrottleHat3Up;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3Up, (void*) &idThrottleHat3Up);
        return idThrottleHat3Up;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3Up, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleHat3Up_Right
    {
      get
      {
        int throttleHat3UpRight;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3Up_Right, (void*) &throttleHat3UpRight);
        return throttleHat3UpRight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3Up_Right, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleHat3Right
    {
      get
      {
        int throttleHat3Right;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3Right, (void*) &throttleHat3Right);
        return throttleHat3Right;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3Right, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleHat3Down_Right
    {
      get
      {
        int throttleHat3DownRight;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3Down_Right, (void*) &throttleHat3DownRight);
        return throttleHat3DownRight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3Down_Right, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleHat3Down
    {
      get
      {
        int throttleHat3Down;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3Down, (void*) &throttleHat3Down);
        return throttleHat3Down;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3Down, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleHat3Down_Left
    {
      get
      {
        int throttleHat3DownLeft;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3Down_Left, (void*) &throttleHat3DownLeft);
        return throttleHat3DownLeft;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3Down_Left, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleHat3Left
    {
      get
      {
        int throttleHat3Left;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3Left, (void*) &throttleHat3Left);
        return throttleHat3Left;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3Left, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleHat3Up_Left
    {
      get
      {
        int throttleHat3UpLeft;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3Up_Left, (void*) &throttleHat3UpLeft);
        return throttleHat3UpLeft;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3Up_Left, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleHat4Up
    {
      get
      {
        int idThrottleHat4Up;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4Up, (void*) &idThrottleHat4Up);
        return idThrottleHat4Up;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4Up, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleHat4Up_Right
    {
      get
      {
        int throttleHat4UpRight;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4Up_Right, (void*) &throttleHat4UpRight);
        return throttleHat4UpRight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4Up_Right, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleHat4Right
    {
      get
      {
        int throttleHat4Right;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4Right, (void*) &throttleHat4Right);
        return throttleHat4Right;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4Right, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleHat4Down_Right
    {
      get
      {
        int throttleHat4DownRight;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4Down_Right, (void*) &throttleHat4DownRight);
        return throttleHat4DownRight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4Down_Right, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleHat4Down
    {
      get
      {
        int throttleHat4Down;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4Down, (void*) &throttleHat4Down);
        return throttleHat4Down;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4Down, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleHat4Down_Left
    {
      get
      {
        int throttleHat4DownLeft;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4Down_Left, (void*) &throttleHat4DownLeft);
        return throttleHat4DownLeft;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4Down_Left, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleHat4Left
    {
      get
      {
        int throttleHat4Left;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4Left, (void*) &throttleHat4Left);
        return throttleHat4Left;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4Left, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleHat4Up_Left
    {
      get
      {
        int throttleHat4UpLeft;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4Up_Left, (void*) &throttleHat4UpLeft);
        return throttleHat4UpLeft;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4Up_Left, (void*) &value);
      }
    }

    public static unsafe int elementId_leftPedal
    {
      get
      {
        int elementIdLeftPedal;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_leftPedal, (void*) &elementIdLeftPedal);
        return elementIdLeftPedal;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_leftPedal, (void*) &value);
      }
    }

    public static unsafe int elementId_rightPedal
    {
      get
      {
        int elementIdRightPedal;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_rightPedal, (void*) &elementIdRightPedal);
        return elementIdRightPedal;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_rightPedal, (void*) &value);
      }
    }

    public static unsafe int elementId_slidePedals
    {
      get
      {
        int elementIdSlidePedals;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_slidePedals, (void*) &elementIdSlidePedals);
        return elementIdSlidePedals;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_slidePedals, (void*) &value);
      }
    }

    public static unsafe int elementId_stick
    {
      get
      {
        int elementIdStick;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stick, (void*) &elementIdStick);
        return elementIdStick;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stick, (void*) &value);
      }
    }

    public static unsafe int elementId_stickMiniStick1
    {
      get
      {
        int idStickMiniStick1;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickMiniStick1, (void*) &idStickMiniStick1);
        return idStickMiniStick1;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickMiniStick1, (void*) &value);
      }
    }

    public static unsafe int elementId_stickMiniStick2
    {
      get
      {
        int idStickMiniStick2;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickMiniStick2, (void*) &idStickMiniStick2);
        return idStickMiniStick2;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickMiniStick2, (void*) &value);
      }
    }

    public static unsafe int elementId_stickHat1
    {
      get
      {
        int elementIdStickHat1;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1, (void*) &elementIdStickHat1);
        return elementIdStickHat1;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1, (void*) &value);
      }
    }

    public static unsafe int elementId_stickHat2
    {
      get
      {
        int elementIdStickHat2;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2, (void*) &elementIdStickHat2);
        return elementIdStickHat2;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2, (void*) &value);
      }
    }

    public static unsafe int elementId_stickHat3
    {
      get
      {
        int elementIdStickHat3;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3, (void*) &elementIdStickHat3);
        return elementIdStickHat3;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3, (void*) &value);
      }
    }

    public static unsafe int elementId_stickHat4
    {
      get
      {
        int elementIdStickHat4;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4, (void*) &elementIdStickHat4);
        return elementIdStickHat4;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4, (void*) &value);
      }
    }

    public static unsafe int elementId_throttle1
    {
      get
      {
        int elementIdThrottle1;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttle1, (void*) &elementIdThrottle1);
        return elementIdThrottle1;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttle1, (void*) &value);
      }
    }

    public static unsafe int elementId_throttle2
    {
      get
      {
        int elementIdThrottle2;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttle2, (void*) &elementIdThrottle2);
        return elementIdThrottle2;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttle2, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleMiniStick
    {
      get
      {
        int throttleMiniStick;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleMiniStick, (void*) &throttleMiniStick);
        return throttleMiniStick;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleMiniStick, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleHat1
    {
      get
      {
        int elementIdThrottleHat1;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1, (void*) &elementIdThrottleHat1);
        return elementIdThrottleHat1;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleHat2
    {
      get
      {
        int elementIdThrottleHat2;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2, (void*) &elementIdThrottleHat2);
        return elementIdThrottleHat2;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleHat3
    {
      get
      {
        int elementIdThrottleHat3;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3, (void*) &elementIdThrottleHat3);
        return elementIdThrottleHat3;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3, (void*) &value);
      }
    }

    public static unsafe int elementId_throttleHat4
    {
      get
      {
        int elementIdThrottleHat4;
        IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4, (void*) &elementIdThrottleHat4);
        return elementIdThrottleHat4;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4, (void*) &value);
      }
    }
  }
}
