// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenRedrawHit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Redraw Hit", fileName = "Apply X When Redraw Hit")]
public class StatusEffectApplyXWhenRedrawHit : StatusEffectApplyX
{
  public override void Init() => global::Events.OnRedrawBellHit += new UnityAction<RedrawBellSystem>(this.RedrawBellHit);

  public void OnDestroy() => global::Events.OnRedrawBellHit -= new UnityAction<RedrawBellSystem>(this.RedrawBellHit);

  public void RedrawBellHit(RedrawBellSystem redrawBellSystem) => ActionQueue.Stack((PlayAction) new ActionSequence(this.Run(this.GetTargets())), true);
}
