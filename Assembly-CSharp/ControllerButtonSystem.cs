// Decompiled with JetBrains decompiler
// Type: ControllerButtonSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Rewired;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;

public class ControllerButtonSystem : GameSystem
{
  private static ControllerButtonSystem instance;
  private static JoystickButtonStyle style;
  [SerializeField]
  private JoystickButtonStyle defaultControllerStyle;
  [SerializeField]
  private JoystickButtonStyle mouseStyle;
  [SerializeField]
  private JoystickButtonStyle touchStyle;
  [SerializeField]
  private JoystickButtonStyle[] styles;

  private void Awake() => ControllerButtonSystem.instance = this;

  private void OnEnable() => global::Events.OnControllerSwitched += new UnityAction(ControllerButtonSystem.ControllerSwitched);

  private void OnDisable() => global::Events.OnControllerSwitched -= new UnityAction(ControllerButtonSystem.ControllerSwitched);

  private static void ControllerSwitched()
  {
    if (MonoBehaviourSingleton<Cursor3d>.instance.usingMouse)
      return;
    ControllerButtonSystem.SetControllerStyle();
  }

  public static void SetMouseStyle()
  {
    ControllerButtonSystem.style = ControllerButtonSystem.instance.mouseStyle;
    global::Events.InvokeButtonStyleChanged();
  }

  public static void SetTouchStyle()
  {
    ControllerButtonSystem.style = ControllerButtonSystem.instance.touchStyle;
    global::Events.InvokeButtonStyleChanged();
  }

  public static void SetControllerStyle()
  {
    Player playerController = RewiredControllerManager.GetPlayerController(0);
    Controller controller = (Controller) null;
    double num = -1.0;
    foreach (Joystick joystick in (IEnumerable<Joystick>) playerController.controllers.Joysticks)
    {
      double lastTimeActive = joystick.GetLastTimeActive();
      if (lastTimeActive > num)
      {
        num = lastTimeActive;
        controller = (Controller) joystick;
      }
    }
    if (controller == null)
      return;
    ControllerButtonSystem.style = ((IEnumerable<JoystickButtonStyle>) ControllerButtonSystem.instance.styles).FirstOrDefault<JoystickButtonStyle>((Func<JoystickButtonStyle, bool>) (a => a.guids.Contains<Guid>(controller.hardwareTypeGuid)));
    if (ControllerButtonSystem.style == null)
      ControllerButtonSystem.style = ControllerButtonSystem.instance.defaultControllerStyle;
    Debug.LogWarning((object) ("ControllerButtonStyle Set: [" + ControllerButtonSystem.style.name + "]"));
    global::Events.InvokeButtonStyleChanged();
  }

  public static Sprite Get(string action)
  {
    if (action.IsNullOrWhitespace())
      return (Sprite) null;
    Player playerController = RewiredControllerManager.GetPlayerController(0);
    return ControllerButtonSystem.style.GetElement(playerController, action).buttonSprite;
  }

  public static JoystickButtonStyle.ElementButton GetElement(Player player, string actionName) => ControllerButtonSystem.style.GetElement(player, actionName);

  public static string ProcessActionTags(LocalizedString key, bool preferTextActions = true) => ControllerButtonSystem.ProcessActionTags(key.GetLocalizedString(), preferTextActions);

  public static string ProcessActionTags(string text, bool preferTextActions)
  {
    Player playerController = RewiredControllerManager.GetPlayerController(0);
    int startIndex = 0;
    do
    {
      startIndex = text.IndexOf("<action=", startIndex);
      if (startIndex >= 0)
      {
        int count = text.IndexOf('>', startIndex) - startIndex + 1;
        string actionName = text.Substring(startIndex + 8, count - 9);
        Debug.Log((object) ("Action: " + actionName));
        text = text.Remove(startIndex, count);
        JoystickButtonStyle.ElementButton element = ControllerButtonSystem.style.GetElement(playerController, actionName);
        if (element != null)
        {
          if (element.textKey.IsEmpty || !preferTextActions)
          {
            string name = element.buttonSprite.name;
            Debug.Log((object) ("Button Sprite Index for [" + actionName + "]: " + name));
            text = text.Insert(startIndex, "<sprite name=" + name + ">");
          }
          else
          {
            string text1 = element.text;
            Debug.Log((object) ("Button Key Name for [" + actionName + "]: " + text1));
            text = text.Insert(startIndex, text1);
          }
        }
        else
          Debug.Log((object) "No element using that action! (or action doesn't exist...)");
      }
      else
        break;
    }
    while (startIndex >= 0);
    return text;
  }
}
