// Decompiled with JetBrains decompiler
// Type: NavigationStateWait
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

#nullable disable
public class NavigationStateWait : INavigationState
{
  private readonly bool disableInput;

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
