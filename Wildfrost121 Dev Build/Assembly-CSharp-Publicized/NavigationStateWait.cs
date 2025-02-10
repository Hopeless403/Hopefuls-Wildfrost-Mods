// Decompiled with JetBrains decompiler
// Type: NavigationStateWait
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

#nullable disable
public class NavigationStateWait : INavigationState
{
  public readonly bool disableInput;

  public NavigationStateWait(bool disableInput = false) => this.disableInput = disableInput;

  public void Begin()
  {
    VirtualPointer.Hide();
    if (!this.disableInput)
      return;
    InputSystem.Disable();
  }

  public void End()
  {
    VirtualPointer.Show();
    if (!this.disableInput)
      return;
    InputSystem.Enable();
  }
}
