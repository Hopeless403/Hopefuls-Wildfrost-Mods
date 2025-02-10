// Decompiled with JetBrains decompiler
// Type: StatusEffectVim
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Vim", fileName = "Vim")]
public class StatusEffectVim : StatusEffectData
{
  public override void Init()
  {
    this.OnHit += new StatusEffectData.EffectHitEventHandler(this.Check);
  }

  public override bool RunHitEvent(Hit hit)
  {
    return (Object) hit.target == (Object) this.target && hit.Offensive && hit.canBeNullified && hit.BasicHit;
  }

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
