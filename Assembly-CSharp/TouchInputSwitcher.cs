// Decompiled with JetBrains decompiler
// Type: TouchInputSwitcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

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
