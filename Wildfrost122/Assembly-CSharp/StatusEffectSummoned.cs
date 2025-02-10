// Decompiled with JetBrains decompiler
// Type: StatusEffectSummoned
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Summoned", fileName = "Summoned")]
public class StatusEffectSummoned : StatusEffectData
{
  private bool triggered;

  protected override void Init()
  {
    this.OnTurnEnd += new StatusEffectData.EffectEntityEventHandler(this.DealDamage);
  }

  public override bool RunCardPlayedEvent(Entity entity, Entity[] targets)
  {
    if ((Object) entity == (Object) this.target && !this.target.silenced)
      this.triggered = true;
    return false;
  }

  public override bool RunTurnEndEvent(Entity entity)
  {
    if ((Object) entity == (Object) this.target && this.triggered)
    {
      if (this.target.silenced)
        this.triggered = false;
      if (this.CanTrigger())
        return true;
    }
    return false;
  }

  private IEnumerator DealDamage(Entity entity)
  {
    StatusEffectSummoned statusEffectSummoned = this;
    statusEffectSummoned.triggered = false;
    SfxSystem.OneShot("event:/sfx/status/shadeheart");
    yield return (object) new Hit(statusEffectSummoned.target, statusEffectSummoned.target, 1)
    {
      damageType = "summoned",
      countsAsHit = false,
      screenShake = 0.0f
    }.Process();
    yield return (object) Sequences.Wait(0.1f);
  }
}
