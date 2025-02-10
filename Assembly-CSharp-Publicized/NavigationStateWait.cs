// Decompiled with JetBrains decompiler
// Type: NavigationStateWait
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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
