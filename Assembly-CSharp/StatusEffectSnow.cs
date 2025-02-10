// Decompiled with JetBrains decompiler
// Type: StatusEffectSnow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Snow", fileName = "Snow")]
public class StatusEffectSnow : StatusEffectData
{
  [SerializeField]
  private StatusEffectSnow.CountDownType countDownType;
  private bool primed;

  protected override void Init()
  {
    this.OnHit += new StatusEffectData.EffectHitEventHandler(this.Hit);
    this.OnTurnEnd += new StatusEffectData.EffectEntityEventHandler(this.CustomCountDown);
  }

  public override bool RunHitEvent(global::Hit hit) => (Object) hit.target == (Object) this.target && hit.counterReduction > 0;

  private IEnumerator Hit(global::Hit hit)
  {
    StatusEffectSnow statusEffectSnow;
    for (statusEffectSnow = this; hit.counterReduction > 0 && statusEffectSnow.count > 0; --hit.counterReduction)
    {
      if (statusEffectSnow.countDownType == StatusEffectSnow.CountDownType.OnCounter)
        --statusEffectSnow.count;
    }
    if (statusEffectSnow.count <= 0)
      yield return (object) statusEffectSnow.Remove();
  }

  public override bool RunTurnStartEvent(Entity entity)
  {
    if (!this.primed && (Object) entity == (Object) this.target && this.countDownType == StatusEffectSnow.CountDownType.OnTurnEnd && Battle.IsOnBoard(entity))
      this.primed = true;
    return false;
  }

  public override bool RunTurnEndEvent(Entity entity) => (Object) entity == (Object) this.target && this.primed && this.countDownType == StatusEffectSnow.CountDownType.OnTurnEnd;

  private IEnumerator CustomCountDown(Entity entity)
  {
    StatusEffectSnow status = this;
    int amount = 1;
    Events.InvokeStatusEffectCountDown((StatusEffectData) status, ref amount);
    if (amount != 0)
      yield return (object) status.CountDown(entity, amount);
  }

  private enum CountDownType
  {
    OnCounter,
    OnTurnEnd,
  }
}
