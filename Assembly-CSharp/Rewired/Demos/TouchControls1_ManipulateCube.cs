// Decompiled with JetBrains decompiler
// Type: Rewired.Demos.TouchControls1_ManipulateCube
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using UnityEngine;

namespace Rewired.Demos
{
  [AddComponentMenu("")]
  public class TouchControls1_ManipulateCube : MonoBehaviour
  {
    public float rotateSpeed = 1f;
    public float moveSpeed = 1f;
    private int currentColorIndex;
    private Color[] colors = new Color[4]
    {
      Color.white,
      Color.red,
      Color.green,
      Color.blue
    };

    private void OnEnable()
    {
      if (!ReInput.isReady)
        return;
      Player player = ReInput.players.GetPlayer(0);
      if (player == null)
        return;
      player.AddInputEventDelegate(new Action<InputActionEventData>(this.OnMoveReceivedX), UpdateLoopType.Update, InputActionEventType.AxisActive, "Horizontal");
      player.AddInputEventDelegate(new Action<InputActionEventData>(this.OnMoveReceivedX), UpdateLoopType.Update, InputActionEventType.AxisInactive, "Horizontal");
      player.AddInputEventDelegate(new Action<InputActionEventData>(this.OnMoveReceivedY), UpdateLoopType.Update, InputActionEventType.AxisActive, "Vertical");
      player.AddInputEventDelegate(new Action<InputActionEventData>(this.OnMoveReceivedY), UpdateLoopType.Update, InputActionEventType.AxisInactive, "Vertical");
      player.AddInputEventDelegate(new Action<InputActionEventData>(this.OnCycleColor), UpdateLoopType.Update, InputActionEventType.ButtonJustPressed, "CycleColor");
      player.AddInputEventDelegate(new Action<InputActionEventData>(this.OnCycleColorReverse), UpdateLoopType.Update, InputActionEventType.ButtonJustPressed, "CycleColorReverse");
      player.AddInputEventDelegate(new Action<InputActionEventData>(this.OnRotationReceivedX), UpdateLoopType.Update, InputActionEventType.AxisActive, "RotateHorizontal");
      player.AddInputEventDelegate(new Action<InputActionEventData>(this.OnRotationReceivedX), UpdateLoopType.Update, InputActionEventType.AxisInactive, "RotateHorizontal");
      player.AddInputEventDelegate(new Action<InputActionEventData>(this.OnRotationReceivedY), UpdateLoopType.Update, InputActionEventType.AxisActive, "RotateVertical");
      player.AddInputEventDelegate(new Action<InputActionEventData>(this.OnRotationReceivedY), UpdateLoopType.Update, InputActionEventType.AxisInactive, "RotateVertical");
    }

    private void OnDisable()
    {
      if (!ReInput.isReady)
        return;
      Player player = ReInput.players.GetPlayer(0);
      if (player == null)
        return;
      player.RemoveInputEventDelegate(new Action<InputActionEventData>(this.OnMoveReceivedX));
      player.RemoveInputEventDelegate(new Action<InputActionEventData>(this.OnMoveReceivedY));
      player.RemoveInputEventDelegate(new Action<InputActionEventData>(this.OnCycleColor));
      player.RemoveInputEventDelegate(new Action<InputActionEventData>(this.OnCycleColorReverse));
      player.RemoveInputEventDelegate(new Action<InputActionEventData>(this.OnRotationReceivedX));
      player.RemoveInputEventDelegate(new Action<InputActionEventData>(this.OnRotationReceivedY));
    }

    private void OnMoveReceivedX(InputActionEventData data) => this.OnMoveReceived(new Vector2(data.GetAxis(), 0.0f));

    private void OnMoveReceivedY(InputActionEventData data) => this.OnMoveReceived(new Vector2(0.0f, data.GetAxis()));

    private void OnRotationReceivedX(InputActionEventData data) => this.OnRotationReceived(new Vector2(data.GetAxis(), 0.0f));

    private void OnRotationReceivedY(InputActionEventData data) => this.OnRotationReceived(new Vector2(0.0f, data.GetAxis()));

    private void OnCycleColor(InputActionEventData data) => this.OnCycleColor();

    private void OnCycleColorReverse(InputActionEventData data) => this.OnCycleColorReverse();

    private void OnMoveReceived(Vector2 move) => this.transform.Translate((Vector3) move * Time.deltaTime * this.moveSpeed, Space.World);

    private void OnRotationReceived(Vector2 rotate)
    {
      rotate *= this.rotateSpeed;
      this.transform.Rotate(Vector3.up, -rotate.x, Space.World);
      this.transform.Rotate(Vector3.right, rotate.y, Space.World);
    }

    private void OnCycleColor()
    {
      if (this.colors.Length == 0)
        return;
      ++this.currentColorIndex;
      if (this.currentColorIndex >= this.colors.Length)
        this.currentColorIndex = 0;
      this.GetComponent<Renderer>().material.color = this.colors[this.currentColorIndex];
    }

    private void OnCycleColorReverse()
    {
      if (this.colors.Length == 0)
        return;
      --this.currentColorIndex;
      if (this.currentColorIndex < 0)
        this.currentColorIndex = this.colors.Length - 1;
      this.GetComponent<Renderer>().material.color = this.colors[this.currentColorIndex];
    }
  }
}
