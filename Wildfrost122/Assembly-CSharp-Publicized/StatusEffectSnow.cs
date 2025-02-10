// Decompiled with JetBrains decompiler
// Type: StatusEffectSnow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Snow", fileName = "Snow")]
public class StatusEffectSnow : StatusEffectData
{
  [SerializeField]
  public StatusEffectSnow.CountDownType countDownType;
  public bool primed;

  public override void Init()
  {
    this.OnHit += new StatusEffectData.EffectHitEventHandler(this.Hit);
    this.OnTurnEnd += new StatusEffectData.EffectEntityEventHandler(this.CustomCountDown);
  }

  public override bool RunHitEvent(global::Hit hit)
  {
    return (Object) hit.target == (Object) this.target && hit.counterReduction > 0;
  }

  public IEnumerator Hit(global::Hit hit)
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

  public override bool RunTurnEndEvent(Entity entity)
  {
    return (Object) entity == (Object) this.target && this.primed && this.countDownType == StatusEffectSnow.CountDownType.OnTurnEnd;
  }

  public IEnumerator CustomCountDown(Entity entity)
  {
    StatusEffectSnow status = this;
    int amount = 1;
    Events.InvokeStatusEffectCountDown((StatusEffectData) status, ref amount);
    if (amount != 0)
      yield return (object) status.CountDown(entity, amount);
  }

  public enum CountDownType
  {
    OnCounter,
    OnTurnEnd,
  }
}
