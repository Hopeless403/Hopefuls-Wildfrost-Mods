// Decompiled with JetBrains decompiler
// Type: Rewired.Demos.TouchControls1_ManipulateCube
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using UnityEngine;

namespace Rewired.Demos
{
  [AddComponentMenu("")]
  public class TouchControls1_ManipulateCube : MonoBehaviour
  {
    public float rotateSpeed = 1f;
    public float moveSpeed = 1f;
    public int currentColorIndex;
    public Color[] colors = new Color[4]
    {
      Color.white,
      Color.red,
      Color.green,
      Color.blue
    };

    public void OnEnable()
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

    public void OnDisable()
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

    public void OnMoveReceivedX(InputActionEventData data) => this.OnMoveReceived(new Vector2(data.GetAxis(), 0.0f));

    public void OnMoveReceivedY(InputActionEventData data) => this.OnMoveReceived(new Vector2(0.0f, data.GetAxis()));

    public void OnRotationReceivedX(InputActionEventData data) => this.OnRotationReceived(new Vector2(data.GetAxis(), 0.0f));

    public void OnRotationReceivedY(InputActionEventData data) => this.OnRotationReceived(new Vector2(0.0f, data.GetAxis()));

    public void OnCycleColor(InputActionEventData data) => this.OnCycleColor();

    public void OnCycleColorReverse(InputActionEventData data) => this.OnCycleColorReverse();

    public void OnMoveReceived(Vector2 move) => this.transform.Translate((Vector3) move * Time.deltaTime * this.moveSpeed, Space.World);

    public void OnRotationReceived(Vector2 rotate)
    {
      rotate *= this.rotateSpeed;
      this.transform.Rotate(Vector3.up, -rotate.x, Space.World);
      this.transform.Rotate(Vector3.right, rotate.y, Space.World);
    }

    public void OnCycleColor()
    {
      if (this.colors.Length == 0)
        return;
      ++this.currentColorIndex;
      if (this.currentColorIndex >= this.colors.Length)
        this.currentColorIndex = 0;
      this.GetComponent<Renderer>().material.color = this.colors[this.currentColorIndex];
    }

    public void OnCycleColorReverse()
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
