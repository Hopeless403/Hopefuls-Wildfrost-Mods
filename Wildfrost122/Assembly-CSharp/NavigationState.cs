// Decompiled with JetBrains decompiler
// Type: NavigationState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;

#nullable disable
public static class NavigationState
{
  private static readonly Stack<INavigationState> stateHistory = new Stack<INavigationState>();

  private static INavigationState PeekCurrentState()
  {
    return NavigationState.stateHistory.Count <= 0 ? (INavigationState) null : NavigationState.stateHistory.Peek();
  }

  private static INavigationState PopCurrentState()
  {
    return NavigationState.stateHistory.Count <= 0 ? (INavigationState) null : NavigationState.stateHistory.Pop();
  }

  public static void Start(INavigationState state)
  {
    INavigationState navigationState = NavigationState.PeekCurrentState();
    if (navigationState == state)
      return;
    navigationState?.End();
    if (state == null)
      return;
    state.Begin();
    NavigationState.stateHistory.Push(state);
  }

  public static void BackToPreviousState()
  {
    if (NavigationState.stateHistory.Count <= 0)
      return;
    NavigationState.PopCurrentState()?.End();
    NavigationState.PeekCurrentState()?.Begin();
  }

  public static void Reset()
  {
    NavigationState.stateHistory.Clear();
    NavigationState.Start((INavigationState) new NavigationStateIdle());
  }
}
