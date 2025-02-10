// Decompiled with JetBrains decompiler
// Type: ControllerInputSwitcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public class ControllerInputSwitcher : BaseInputSwitcher
{
  public override bool CheckSwitchTo()
  {
    if (!this.canSwitchTo || Console.active)
      return false;
    return (double) Mathf.Abs(InputSystem.GetAxisDelta("Move Vertical")) > 0.0 || (double) Mathf.Abs(InputSystem.GetAxisDelta("Move Horizontal")) > 0.0;
  }

  public override void SwitchTo()
  {
    this.gameObject.SetActive(true);
    MonoBehaviourSingleton<Cursor3d>.instance.usingMouse = false;
    MonoBehaviourSingleton<Cursor3d>.instance.usingTouch = false;
    VirtualPointer.Show();
    CustomCursor.UpdateState();
    UINavigationDefaultSystem.SetStartingItem();
    ControllerButtonSystem.SetControllerStyle();
    InputSystem.mainPlayer.controllers.Mouse.enabled = false;
    RewiredControllerManager.instance.AssignNextPlayer(InputSystem.mainPlayer.id);
    InputSystem.AllowDynamicSelectRelease = true;
  }
}
