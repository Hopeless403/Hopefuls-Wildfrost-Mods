// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantDraw
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

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
