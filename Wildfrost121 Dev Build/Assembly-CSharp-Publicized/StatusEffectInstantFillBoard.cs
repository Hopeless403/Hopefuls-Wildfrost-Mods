// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantFillBoard
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using FMODUnity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Fill Board", fileName = "Fill Board")]
public class StatusEffectInstantFillBoard : StatusEffectInstant
{
  [SerializeField]
  public bool doPing = true;
  [SerializeField]
  public EventReference sfxEvent;
  [SerializeField]
  public CardData[] withCards;
  public readonly List<CardData> pool = new List<CardData>();

  public override IEnumerator Process()
  {
    StatusEffectInstantFillBoard instantFillBoard = this;
    if (instantFillBoard.doPing)
    {
      double num = (double) instantFillBoard.target.curveAnimator.Ping();
      SfxSystem.OneShot(instantFillBoard.sfxEvent);
      Events.InvokeScreenRumble(0.0f, 0.4f, 0.0f, 0.4f, 0.1f, 0.4f);
    }
    List<CardContainer> rows = References.Battle.GetRows(instantFillBoard.target.owner);
    List<CardSlot> cardSlotList = new List<CardSlot>();
    foreach (CardContainer cardContainer in rows)
    {
      if (cardContainer is CardSlotLane cardSlotLane)
        cardSlotList.AddRange(cardSlotLane.slots.Where<CardSlot>((Func<CardSlot, bool>) (slot => slot.Empty)));
    }
    foreach (CardSlot slot in cardSlotList)
    {
      Card card = CardManager.Get(instantFillBoard.Pull().Clone(), References.Battle.playerCardController, instantFillBoard.target.owner, true, instantFillBoard.target.owner.team == References.Player.team);
      yield return (object) card.UpdateData(false);
      instantFillBoard.target.owner.reserveContainer.Add(card.entity);
      instantFillBoard.target.owner.reserveContainer.SetChildPosition(card.entity);
      ActionQueue.Stack((PlayAction) new ActionMove(card.entity, new CardContainer[1]
      {
        (CardContainer) slot
      }), true);
      ActionQueue.Stack((PlayAction) new ActionRunEnableEvent(card.entity), true);
      card = (Card) null;
    }
    yield return (object) instantFillBoard.\u003C\u003En__0();
  }

  public CardData Pull()
  {
    if (this.pool.Count <= 0)
      this.pool.AddRange((IEnumerable<CardData>) this.withCards);
    return this.pool.TakeRandom<CardData>();
  }

  [CompilerGenerated]
  [DebuggerHidden]
  public new IEnumerator \u003C\u003En__0() => base.Process();
}
