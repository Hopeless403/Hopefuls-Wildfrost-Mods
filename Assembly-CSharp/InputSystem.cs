// Decompiled with JetBrains decompiler
// Type: InputSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Rewired;
using UnityEngine;

public class InputSystem : GameSystem
{
  private static InputSystem instance;
  [Header("Hold Direction Settings")]
  public float holdDirectionStartTime = 0.1f;
  public float holdDirectionFlowTime = 0.05f;
  public static Player mainPlayer;
  private static bool enabled = true;
  private static bool isLongHeld;
  private static float holdDirectionTime;
  private static bool wasSelectHeldLong;
  private static bool wasSelectHeldLong2;
  public static bool AllowDynamicSelectRelease = true;
  private static int _reset;

  public static bool Enabled => InputSystem.enabled && !Transition.Running;

  public static Vector3 MousePosition { get; private set; }

  public static bool reset
  {
    get => InputSystem._reset > 0;
    set => InputSystem._reset = value ? 2 : 0;
  }

  private void Awake()
  {
    InputSystem.instance = this;
    InputSystem.mainPlayer = ReInput.players.GetPlayer(0);
  }

  private void LateUpdate()
  {
    InputSystem.wasSelectHeldLong = InputSystem.wasSelectHeldLong2;
    InputSystem.wasSelectHeldLong2 = InputSystem.mainPlayer.GetButtonTimedPress("Select", 0.1f);
    InputSystem.MousePosition = Input.touchCount <= 0 ? Input.mousePosition : (Vector3) Input.GetTouch(0).position;
    --InputSystem._reset;
  }

  public static void Enable() => InputSystem.enabled = true;

  public static void Disable() => InputSystem.enabled = false;

  public static bool IsButtonPressed(string input, bool positive = true) => !(InputSystem.Enabled & positive) ? InputSystem.mainPlayer.GetNegativeButtonDown(input) : InputSystem.mainPlayer.GetButtonDown(input);

  public static bool IsButtonHeld(string input, bool positive = true) => !(InputSystem.Enabled & positive) ? InputSystem.mainPlayer.GetNegativeButton(input) : InputSystem.mainPlayer.GetButton(input);

  public static bool IsButtonLongHeld(string input, bool positive = true) => !(InputSystem.Enabled & positive) ? InputSystem.mainPlayer.GetNegativeButtonLongPress(input) : InputSystem.mainPlayer.GetButtonLongPress(input);

  public static bool IsButtonReleased(string input, bool positive = true) => !(InputSystem.Enabled & positive) ? InputSystem.mainPlayer.GetNegativeButtonUp(input) : InputSystem.mainPlayer.GetButtonUp(input);

  public static bool WasButtonPressed(string input, bool positive = true) => !(InputSystem.Enabled & positive) ? InputSystem.mainPlayer.GetNegativeButtonPrev(input) : InputSystem.mainPlayer.GetButtonPrev(input);

  public static bool WasButtonReleased(string input, bool positive = true) => !(InputSystem.Enabled & positive) ? !InputSystem.mainPlayer.GetNegativeButtonPrev(input) : !InputSystem.mainPlayer.GetButtonPrev(input);

  public static bool IsSelectPressed() => InputSystem.IsButtonPressed("Select");

  public static bool IsSelectHeld() => InputSystem.IsButtonHeld("Select");

  public static bool IsSelectReleased() => InputSystem.IsButtonReleased("Select");

  public static bool IsDynamicSelectReleased(bool allowSelectAgainToRelease)
  {
    if (!InputSystem.Enabled)
      return false;
    if (MonoBehaviourSingleton<Cursor3d>.instance.usingMouse && InputSystem.wasSelectHeldLong && !InputSystem.IsSelectHeld())
      return true;
    return allowSelectAgainToRelease ? InputSystem.IsSelectPressed() : !InputSystem.IsSelectHeld();
  }

  public static bool CheckLongHold()
  {
    if (InputSystem.IsButtonLongHeld("Move Vertical") || InputSystem.IsButtonLongHeld("Move Vertical", false) || InputSystem.IsButtonLongHeld("Move Horizontal") || InputSystem.IsButtonLongHeld("Move Horizontal", false))
    {
      if (!InputSystem.isLongHeld)
        InputSystem.holdDirectionTime = InputSystem.instance.holdDirectionStartTime;
      InputSystem.isLongHeld = true;
    }
    if (InputSystem.isLongHeld)
    {
      if (RewiredControllerManager.instance.IsButtonReleased() || !RewiredControllerManager.instance.IsButtonHeld())
      {
        InputSystem.isLongHeld = false;
      }
      else
      {
        InputSystem.holdDirectionTime -= Time.unscaledDeltaTime;
        if ((double) InputSystem.holdDirectionTime > 0.0)
          return false;
        InputSystem.holdDirectionTime = InputSystem.instance.holdDirectionFlowTime;
        return true;
      }
    }
    return InputSystem.isLongHeld;
  }

  public static float GetAxis(string actionName) => InputSystem.Enabled ? InputSystem.mainPlayer.GetAxis(actionName) : 0.0f;

  public static float GetAxisDelta(string actionName) => InputSystem.Enabled ? InputSystem.mainPlayer.GetAxisDelta(actionName) : 0.0f;
}
