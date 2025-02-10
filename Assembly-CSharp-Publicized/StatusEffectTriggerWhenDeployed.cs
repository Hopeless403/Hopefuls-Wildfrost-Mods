// Decompiled with JetBrains decompiler
// Type: StatusEffectTriggerWhenDeployed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Traits/Trigger When Deployed", fileName = "Trigger When Deployed")]
public class StatusEffectTriggerWhenDeployed : StatusEffectData
{
  public bool isAlreadyOnBoard;

  public override object GetMidBattleData() => (object) Battle.IsOnBoard(this.target);

  public override void RestoreMidBattleData(object data)
  {
    if (!(data is bool flag))
      return;
    this.isAlreadyOnBoard = flag && Battle.IsOnBoard(this.target);
  }

  public override void Init()
  {
    this.OnEnable += new StatusEffectData.EffectEntityEventHandler(this.Enable);
    this.OnCardMove += new StatusEffectData.EffectEntityEventHandler(this.CardMove);
  }

  public override bool RunEnableEvent(Entity entity)
  {
    if (this.isAlreadyOnBoard)
    {
      this.isAlreadyOnBoard = false;
      return false;
    }
    return (Object) entity == (Object) this.target && Battle.IsOnBoard(this.target);
  }

  public IEnumerator Enable(Entity entity)
  {
    yield return (object) Sequences.Wait(0.2f);
    yield return (object) this.Activate();
  }

  public override bool RunCardMoveEvent(Entity entity) => (Object) this.target == (Object) entity && this.target.enabled && Battle.IsOnBoard(this.target) && !Battle.IsOnBoard(entity.preContainers);

  public IEnumerator CardMove(Entity entity)
  {
    yield return (object) Sequences.Wait(0.2f);
    yield return (object) this.Activate();
  }

  public IEnumerator Activate()
  {
    StatusEffectTriggerWhenDeployed triggerWhenDeployed = this;
    if (!triggerWhenDeployed.target.silenced)
    {
      yield return (object) Sequences.Wait(0.1f);
      CurveAnimator curveAnimator = triggerWhenDeployed.target.curveAnimator;
      if (curveAnimator != null)
      {
        double num = (double) curveAnimator.Ping();
      }
      yield return (object) Sequences.Wait(0.5f);
      ActionQueue.Stack((PlayAction) new ActionTrigger(triggerWhenDeployed.target, (Entity) null), true);
    }
  }
}
