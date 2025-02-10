// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantGainGold
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Gain Gold", fileName = "Gain Gold")]
public class StatusEffectInstantGainGold : StatusEffectInstant
{
  [SerializeField]
  private bool take;

  protected override IEnumerator Process()
  {
    StatusEffectInstantGainGold effectInstantGainGold = this;
    if ((bool) (Object) effectInstantGainGold.target)
    {
      Character player = References.Player;
      if ((bool) (Object) player && player.data != null && (bool) (Object) player.data.inventory)
      {
        int amount1 = effectInstantGainGold.GetAmount();
        if (effectInstantGainGold.take)
        {
          int amount2 = Mathf.Min(player.data.inventory.gold.Value, amount1);
          if (amount2 > 0)
            player.SpendGold(amount2);
        }
        else
          Events.InvokeDropGold(amount1, effectInstantGainGold.applier.data.name, player, effectInstantGainGold.applier.transform.position);
      }
    }
    // ISSUE: reference to a compiler-generated method
    yield return (object) effectInstantGainGold.\u003C\u003En__0();
  }
}
