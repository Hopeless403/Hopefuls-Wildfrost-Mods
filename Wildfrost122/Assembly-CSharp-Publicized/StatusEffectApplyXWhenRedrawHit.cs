// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenRedrawHit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Redraw Hit", fileName = "Apply X When Redraw Hit")]
public class StatusEffectApplyXWhenRedrawHit : StatusEffectApplyX
{
  public override void Init()
  {
    global::Events.OnRedrawBellHit += new UnityAction<RedrawBellSystem>(this.RedrawBellHit);
  }

  public void OnDestroy()
  {
    global::Events.OnRedrawBellHit -= new UnityAction<RedrawBellSystem>(this.RedrawBellHit);
  }

  public void RedrawBellHit(RedrawBellSystem redrawBellSystem)
  {
    if (!Battle.IsOnBoard(this.target) || !this.CanTrigger())
      return;
    ActionQueue.Stack((PlayAction) new ActionSequence(this.Run(this.GetTargets())), true);
  }
}
