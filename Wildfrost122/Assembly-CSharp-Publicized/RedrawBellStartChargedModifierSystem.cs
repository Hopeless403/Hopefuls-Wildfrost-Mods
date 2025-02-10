// Decompiled with JetBrains decompiler
// Type: RedrawBellStartChargedModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine.Events;

#nullable disable
public class RedrawBellStartChargedModifierSystem : GameSystem
{
  public void OnEnable()
  {
    global::Events.OnRedrawBellRevealed += new UnityAction<RedrawBellSystem>(RedrawBellStartChargedModifierSystem.RedrawBellRevealed);
  }

  public void OnDisable()
  {
    global::Events.OnRedrawBellRevealed -= new UnityAction<RedrawBellSystem>(RedrawBellStartChargedModifierSystem.RedrawBellRevealed);
  }

  public static void RedrawBellRevealed(RedrawBellSystem redrawBellSystem)
  {
    redrawBellSystem.SetCounter(0);
  }
}
