// Decompiled with JetBrains decompiler
// Type: RedrawBellStartChargedModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine.Events;

#nullable disable
public class RedrawBellStartChargedModifierSystem : GameSystem
{
  private void OnEnable()
  {
    global::Events.OnRedrawBellRevealed += new UnityAction<RedrawBellSystem>(RedrawBellStartChargedModifierSystem.RedrawBellRevealed);
  }

  private void OnDisable()
  {
    global::Events.OnRedrawBellRevealed -= new UnityAction<RedrawBellSystem>(RedrawBellStartChargedModifierSystem.RedrawBellRevealed);
  }

  private static void RedrawBellRevealed(RedrawBellSystem redrawBellSystem)
  {
    redrawBellSystem.SetCounter(0);
  }
}
