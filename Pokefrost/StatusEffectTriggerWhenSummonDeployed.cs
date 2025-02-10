// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectTriggerWhenSummonDeployed
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectTriggerWhenSummonDeployed : StatusEffectData
  {
    private bool isAlreadyOnBoard;

    public override bool HasEnableRoutine => true;

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
    }

    public override bool RunEnableEvent(Entity entity) => Battle.IsOnBoard(this.target);

    private IEnumerator Enable(Entity entity)
    {
      if (entity.data.cardType.name == "Summoned")
      {
        yield return (object) Sequences.Wait(0.2f);
        yield return (object) this.Activate();
      }
    }

    private IEnumerator Activate()
    {
      if (!this.target.silenced)
      {
        yield return (object) Sequences.Wait(0.1f);
        CurveAnimator curveAnimator = this.target.curveAnimator;
        if (curveAnimator != null)
        {
          double num = (double) curveAnimator.Ping();
        }
        yield return (object) Sequences.Wait(0.2f);
        ActionQueue.Stack((PlayAction) new ActionTrigger(this.target, (Entity) null), true);
      }
    }
  }
}
