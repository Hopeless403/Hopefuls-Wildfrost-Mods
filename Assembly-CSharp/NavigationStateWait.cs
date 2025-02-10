// Decompiled with JetBrains decompiler
// Type: NavigationStateWait
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

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
