// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenRedrawHit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Redraw Hit", fileName = "Apply X When Redraw Hit")]
public class StatusEffectApplyXWhenRedrawHit : StatusEffectApplyX
{
  protected override void Init() => global::Events.OnRedrawBellHit += new UnityAction<RedrawBellSystem>(this.RedrawBellHit);

  private void OnDestroy() => global::Events.OnRedrawBellHit -= new UnityAction<RedrawBellSystem>(this.RedrawBellHit);

  private void RedrawBellHit(RedrawBellSystem redrawBellSystem) => ActionQueue.Stack((PlayAction) new ActionSequence(this.Run(this.GetTargets())), true);
}
