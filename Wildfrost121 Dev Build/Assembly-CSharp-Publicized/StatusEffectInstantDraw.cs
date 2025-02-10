// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantDraw
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Draw", fileName = "Instant Draw")]
public class StatusEffectInstantDraw : StatusEffectInstant
{
  public override IEnumerator Process()
  {
    StatusEffectInstantDraw effectInstantDraw = this;
    Character player = References.Player;
    if (player.drawContainer.Empty && player.discardContainer.Empty)
    {
      if (NoTargetTextSystem.Exists())
        yield return (object) NoTargetTextSystem.Run(effectInstantDraw.target, NoTargetType.NoCardsToDraw);
    }
    else
      ActionQueue.Stack((PlayAction) new ActionDraw(player, effectInstantDraw.GetAmount()), true);
    yield return (object) effectInstantDraw.\u003C\u003En__0();
  }

  [CompilerGenerated]
  [DebuggerHidden]
  public new IEnumerator \u003C\u003En__0() => base.Process();
}
