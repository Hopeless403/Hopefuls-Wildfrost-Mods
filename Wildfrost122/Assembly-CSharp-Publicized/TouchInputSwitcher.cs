// Decompiled with JetBrains decompiler
// Type: TouchInputSwitcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public class TouchInputSwitcher : BaseInputSwitcher
{
  public override bool CheckSwitchTo() => this.canSwitchTo && Input.touchCount > 0;

  public override void SwitchTo()
  {
    this.gameObject.SetActive(true);
    MonoBehaviourSingleton<Cursor3d>.instance.usingMouse = true;
    MonoBehaviourSingleton<Cursor3d>.instance.usingTouch = true;
    VirtualPointer.Hide();
    CustomCursor.UpdateState();
    MonoBehaviourSingleton<UINavigationSystem>.instance.SetCurrentNavigationItem((UINavigationItem) null);
    ControllerButtonSystem.SetTouchStyle();
    InputSystem.mainPlayer.controllers.Mouse.enabled = true;
    InputSystem.AllowDynamicSelectRelease = false;
  }
}
