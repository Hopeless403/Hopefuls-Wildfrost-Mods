// Decompiled with JetBrains decompiler
// Type: MouseInputSwitcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
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
