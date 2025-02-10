// Decompiled with JetBrains decompiler
// Type: TouchInputSwitcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

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
