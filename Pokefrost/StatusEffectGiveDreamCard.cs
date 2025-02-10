// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectGiveDreamCard
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectGiveDreamCard : StatusEffectApplyX
  {
    public override void Init()
    {
      global::Events.OnRedrawBellHit += new UnityAction<RedrawBellSystem>(this.GiveCard);
      this.OnCardMove += new StatusEffectData.EffectEntityEventHandler(this.GiveCard2);
      base.Init();
    }

    public override bool RunCardMoveEvent(Entity entity)
    {
      return (Object) entity == (Object) this.target && StatusEffectGiveDreamCard.WasMovedOnToBoard(entity);
    }

    private IEnumerator GiveCard2(Entity entity) => this.Run(this.GetTargets());

    private void OnDestroy()
    {
      global::Events.OnRedrawBellHit -= new UnityAction<RedrawBellSystem>(this.GiveCard);
    }

    private void GiveCard(RedrawBellSystem arg0)
    {
      if (!Battle.IsOnBoard(this.target))
        return;
      ActionQueue.Add((PlayAction) new ActionSequence(this.Run(this.GetTargets())), true);
    }

    public static bool WasMovedOnToBoard(Entity entity)
    {
      return Battle.IsOnBoard(entity) && !Battle.IsOnBoard(entity.preContainers);
    }
  }
}
