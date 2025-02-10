// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenRedrawHit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Redraw Hit", fileName = "Apply X When Redraw Hit")]
public class StatusEffectApplyXWhenRedrawHit : StatusEffectApplyX
{
  protected override void Init()
  {
    global::Events.OnRedrawBellHit += new UnityAction<RedrawBellSystem>(this.RedrawBellHit);
  }

  private void OnDestroy()
  {
    global::Events.OnRedrawBellHit -= new UnityAction<RedrawBellSystem>(this.RedrawBellHit);
  }

  private void RedrawBellHit(RedrawBellSystem redrawBellSystem)
  {
    if (!Battle.IsOnBoard(this.target) || !this.CanTrigger())
      return;
    ActionQueue.Stack((PlayAction) new ActionSequence(this.Run(this.GetTargets())), true);
  }
}
