// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantDraw
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Draw", fileName = "Instant Draw")]
public class StatusEffectInstantDraw : StatusEffectInstant
{
  protected override IEnumerator Process()
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
    // ISSUE: reference to a compiler-generated method
    yield return (object) effectInstantDraw.\u003C\u003En__0();
  }
}
