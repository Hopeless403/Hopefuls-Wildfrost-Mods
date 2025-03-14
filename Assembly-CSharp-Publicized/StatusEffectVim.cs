﻿// Decompiled with JetBrains decompiler
// Type: StatusEffectVim
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Vim", fileName = "Vim")]
public class StatusEffectVim : StatusEffectData
{
  public override void Init() => this.OnHit += new StatusEffectData.EffectHitEventHandler(this.Check);

  public override bool RunHitEvent(Hit hit) => (Object) hit.target == (Object) this.target && hit.Offensive && hit.canBeNullified && hit.BasicHit;

  public IEnumerator Check(Hit hit)
  {
    StatusEffectVim statusEffectVim = this;
    hit.dodged = true;
    hit.countsAsHit = false;
    hit.damageBlocked = hit.damage;
    hit.damage = 0;
    if ((bool) (Object) hit.attacker && hit.attacker.canBeHit && hit.canRetaliate)
      yield return (object) new Hit(statusEffectVim.target, hit.attacker, statusEffectVim.count)
      {
        canRetaliate = false,
        damageType = "vim"
      }.Process();
    ActionQueue.Stack((PlayAction) new ActionSequence(statusEffectVim.CountDown()), true);
  }

  public IEnumerator CountDown()
  {
    StatusEffectVim status = this;
    int count = status.count;
    Events.InvokeStatusEffectCountDown((StatusEffectData) status, ref count);
    if (count != 0)
      yield return (object) status.CountDown(status.target, count);
  }
}
