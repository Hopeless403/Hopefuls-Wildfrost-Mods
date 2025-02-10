// Decompiled with JetBrains decompiler
// Type: Rewired.Utils.ExternalTools
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Rewired.Internal;
using Rewired.Internal.Windows;
using Rewired.Utils.Interfaces;
using Rewired.Utils.Platforms.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.Utils
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public class ExternalTools : IExternalTools
  {
    private static Func<object> _getPlatformInitializerDelegate;
    private bool _isEditorPaused;
    private Action<bool> _EditorPausedStateChangedEvent;

    public static Func<object> getPlatformInitializerDelegate
    {
      get => ExternalTools._getPlatformInitializerDelegate;
      set => ExternalTools._getPlatformInitializerDelegate = value;
    }

    public void Destroy()
    {
    }

    public bool isEditorPaused => this._isEditorPaused;

    public event Action<bool> EditorPausedStateChangedEvent
    {
      add => this._EditorPausedStateChangedEvent += value;
      remove => this._EditorPausedStateChangedEvent -= value;
    }

    public object GetPlatformInitializer() => Main.GetPlatformInitializer();

    public string GetFocusedEditorWindowTitle() => string.Empty;

    public bool IsEditorSceneViewFocused() => false;

    public bool LinuxInput_IsJoystickPreconfigured(string name) => false;

    public event Action<uint, bool> XboxOneInput_OnGamepadStateChange;

    public int XboxOneInput_GetUserIdForGamepad(uint id) => 0;

    public ulong XboxOneInput_GetControllerId(uint unityJoystickId) => 0;

    public bool XboxOneInput_IsGamepadActive(uint unityJoystickId) => false;

    public string XboxOneInput_GetControllerType(ulong xboxControllerId) => string.Empty;

    public uint XboxOneInput_GetJoystickId(ulong xboxControllerId) => 0;

    public void XboxOne_Gamepad_UpdatePlugin()
    {
    }

    public bool XboxOne_Gamepad_SetGamepadVibration(
      ulong xboxOneJoystickId,
      float leftMotor,
      float rightMotor,
      float leftTriggerLevel,
      float rightTriggerLevel)
    {
      return false;
    }

    public void XboxOne_Gamepad_PulseVibrateMotor(
      ulong xboxOneJoystickId,
      int motorInt,
      float startLevel,
      float endLevel,
      ulong durationMS)
    {
    }

    public void GetDeviceVIDPIDs(out List<int> vids, out List<int> pids)
    {
      vids = new List<int>();
      pids = new List<int>();
    }

    public int GetAndroidAPILevel() => -1;

    public void WindowsStandalone_ForwardRawInput(
      IntPtr rawInputHeaderIndices,
      IntPtr rawInputDataIndices,
      uint indicesCount,
      IntPtr rawInputData,
      uint rawInputDataSize)
    {
      Functions.ForwardRawInput(rawInputHeaderIndices, rawInputDataIndices, indicesCount, rawInputData, rawInputDataSize);
    }

    public bool UnityUI_Graphic_GetRaycastTarget(object graphic) => !((UnityEngine.Object) (graphic as Graphic) == (UnityEngine.Object) null) && (graphic as Graphic).raycastTarget;

    public void UnityUI_Graphic_SetRaycastTarget(object graphic, bool value)
    {
      if ((UnityEngine.Object) (graphic as Graphic) == (UnityEngine.Object) null)
        return;
      (graphic as Graphic).raycastTarget = value;
    }

    public bool UnityInput_IsTouchPressureSupported => Input.touchPressureSupported;

    public float UnityInput_GetTouchPressure(ref Touch touch) => touch.pressure;

    public float UnityInput_GetTouchMaximumPossiblePressure(ref Touch touch) => touch.maximumPossiblePressure;

    public IControllerTemplate CreateControllerTemplate(Guid typeGuid, object payload) => ControllerTemplateFactory.Create(typeGuid, payload);

    public System.Type[] GetControllerTemplateTypes() => ControllerTemplateFactory.templateTypes;

    public System.Type[] GetControllerTemplateInterfaceTypes() => ControllerTemplateFactory.templateInterfaceTypes;
  }
}
