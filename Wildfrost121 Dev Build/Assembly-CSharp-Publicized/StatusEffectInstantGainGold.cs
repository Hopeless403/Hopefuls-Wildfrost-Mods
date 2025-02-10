// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantGainGold
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Gain Gold", fileName = "Gain Gold")]
public class StatusEffectInstantGainGold : StatusEffectInstant
{
  [SerializeField]
  public bool take;

  public override IEnumerator Process()
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
    yield return (object) effectInstantGainGold.\u003C\u003En__0();
  }

  [CompilerGenerated]
  [DebuggerHidden]
  public new IEnumerator \u003C\u003En__0() => base.Process();
}
