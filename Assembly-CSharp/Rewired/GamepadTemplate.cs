// Decompiled with JetBrains decompiler
// Type: Rewired.GamepadTemplate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;

namespace Rewired
{
  public sealed class GamepadTemplate : ControllerTemplate, IGamepadTemplate, IControllerTemplate
  {
    public static readonly Guid typeGuid = new Guid("83b427e4-086f-47f3-bb06-be266abd1ca5");
    public const int elementId_leftStickX = 0;
    public const int elementId_leftStickY = 1;
    public const int elementId_rightStickX = 2;
    public const int elementId_rightStickY = 3;
    public const int elementId_actionBottomRow1 = 4;
    public const int elementId_a = 4;
    public const int elementId_actionBottomRow2 = 5;
    public const int elementId_b = 5;
    public const int elementId_actionBottomRow3 = 6;
    public const int elementId_c = 6;
    public const int elementId_actionTopRow1 = 7;
    public const int elementId_x = 7;
    public const int elementId_actionTopRow2 = 8;
    public const int elementId_y = 8;
    public const int elementId_actionTopRow3 = 9;
    public const int elementId_z = 9;
    public const int elementId_leftShoulder1 = 10;
    public const int elementId_leftBumper = 10;
    public const int elementId_leftShoulder2 = 11;
    public const int elementId_leftTrigger = 11;
    public const int elementId_rightShoulder1 = 12;
    public const int elementId_rightBumper = 12;
    public const int elementId_rightShoulder2 = 13;
    public const int elementId_rightTrigger = 13;
    public const int elementId_center1 = 14;
    public const int elementId_back = 14;
    public const int elementId_center2 = 15;
    public const int elementId_start = 15;
    public const int elementId_center3 = 16;
    public const int elementId_guide = 16;
    public const int elementId_leftStickButton = 17;
    public const int elementId_rightStickButton = 18;
    public const int elementId_dPadUp = 19;
    public const int elementId_dPadRight = 20;
    public const int elementId_dPadDown = 21;
    public const int elementId_dPadLeft = 22;
    public const int elementId_leftStick = 23;
    public const int elementId_rightStick = 24;
    public const int elementId_dPad = 25;

    IControllerTemplateButton IGamepadTemplate.actionBottomRow1 => this.GetElement<IControllerTemplateButton>(4);

    IControllerTemplateButton IGamepadTemplate.a => this.GetElement<IControllerTemplateButton>(4);

    IControllerTemplateButton IGamepadTemplate.actionBottomRow2 => this.GetElement<IControllerTemplateButton>(5);

    IControllerTemplateButton IGamepadTemplate.b => this.GetElement<IControllerTemplateButton>(5);

    IControllerTemplateButton IGamepadTemplate.actionBottomRow3 => this.GetElement<IControllerTemplateButton>(6);

    IControllerTemplateButton IGamepadTemplate.c => this.GetElement<IControllerTemplateButton>(6);

    IControllerTemplateButton IGamepadTemplate.actionTopRow1 => this.GetElement<IControllerTemplateButton>(7);

    IControllerTemplateButton IGamepadTemplate.x => this.GetElement<IControllerTemplateButton>(7);

    IControllerTemplateButton IGamepadTemplate.actionTopRow2 => this.GetElement<IControllerTemplateButton>(8);

    IControllerTemplateButton IGamepadTemplate.y => this.GetElement<IControllerTemplateButton>(8);

    IControllerTemplateButton IGamepadTemplate.actionTopRow3 => this.GetElement<IControllerTemplateButton>(9);

    IControllerTemplateButton IGamepadTemplate.z => this.GetElement<IControllerTemplateButton>(9);

    IControllerTemplateButton IGamepadTemplate.leftShoulder1 => this.GetElement<IControllerTemplateButton>(10);

    IControllerTemplateButton IGamepadTemplate.leftBumper => this.GetElement<IControllerTemplateButton>(10);

    IControllerTemplateAxis IGamepadTemplate.leftShoulder2 => this.GetElement<IControllerTemplateAxis>(11);

    IControllerTemplateAxis IGamepadTemplate.leftTrigger => this.GetElement<IControllerTemplateAxis>(11);

    IControllerTemplateButton IGamepadTemplate.rightShoulder1 => this.GetElement<IControllerTemplateButton>(12);

    IControllerTemplateButton IGamepadTemplate.rightBumper => this.GetElement<IControllerTemplateButton>(12);

    IControllerTemplateAxis IGamepadTemplate.rightShoulder2 => this.GetElement<IControllerTemplateAxis>(13);

    IControllerTemplateAxis IGamepadTemplate.rightTrigger => this.GetElement<IControllerTemplateAxis>(13);

    IControllerTemplateButton IGamepadTemplate.center1 => this.GetElement<IControllerTemplateButton>(14);

    IControllerTemplateButton IGamepadTemplate.back => this.GetElement<IControllerTemplateButton>(14);

    IControllerTemplateButton IGamepadTemplate.center2 => this.GetElement<IControllerTemplateButton>(15);

    IControllerTemplateButton IGamepadTemplate.start => this.GetElement<IControllerTemplateButton>(15);

    IControllerTemplateButton IGamepadTemplate.center3 => this.GetElement<IControllerTemplateButton>(16);

    IControllerTemplateButton IGamepadTemplate.guide => this.GetElement<IControllerTemplateButton>(16);

    IControllerTemplateThumbStick IGamepadTemplate.leftStick => this.GetElement<IControllerTemplateThumbStick>(23);

    IControllerTemplateThumbStick IGamepadTemplate.rightStick => this.GetElement<IControllerTemplateThumbStick>(24);

    IControllerTemplateDPad IGamepadTemplate.dPad => this.GetElement<IControllerTemplateDPad>(25);

    public GamepadTemplate(object payload)
      : base(payload)
    {
    }
  }
}
