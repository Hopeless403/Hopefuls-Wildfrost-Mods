// Decompiled with JetBrains decompiler
// Type: MouseInputSwitcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class MouseInputSwitcher : BaseInputSwitcher
{
  public override bool CheckSwitchTo() => this.canSwitchTo && Input.GetMouseButtonDown(0);

  public override void SwitchTo()
  {
    this.gameObject.SetActive(true);
    MonoBehaviourSingleton<Cursor3d>.instance.usingMouse = true;
    MonoBehaviourSingleton<Cursor3d>.instance.usingTouch = false;
    VirtualPointer.Hide();
    CustomCursor.UpdateState();
    MonoBehaviourSingleton<UINavigationSystem>.instance.SetCurrentNavigationItem((UINavigationItem) null);
    ControllerButtonSystem.SetMouseStyle();
    InputSystem.mainPlayer.controllers.Mouse.enabled = true;
    InputSystem.AllowDynamicSelectRelease = true;
  }
}
