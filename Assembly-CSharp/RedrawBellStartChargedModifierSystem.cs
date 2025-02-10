// Decompiled with JetBrains decompiler
// Type: RedrawBellStartChargedModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine.Events;

public class RedrawBellStartChargedModifierSystem : GameSystem
{
  private void OnEnable() => global::Events.OnRedrawBellRevealed += new UnityAction<RedrawBellSystem>(RedrawBellStartChargedModifierSystem.RedrawBellRevealed);

  private void OnDisable() => global::Events.OnRedrawBellRevealed -= new UnityAction<RedrawBellSystem>(RedrawBellStartChargedModifierSystem.RedrawBellRevealed);

  private static void RedrawBellRevealed(RedrawBellSystem redrawBellSystem) => redrawBellSystem.SetCounter(0);
}
