// Decompiled with JetBrains decompiler
// Type: StatusEffectSummoned
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Summoned", fileName = "Summoned")]
public class StatusEffectSummoned : StatusEffectData
{
  private bool triggered;

  protected override void Init() => this.OnTurnEnd += new StatusEffectData.EffectEntityEventHandler(this.DealDamage);

  public override bool RunCardPlayedEvent(Entity entity, Entity[] targets)
  {
    if ((Object) entity == (Object) this.target)
      this.triggered = true;
    return false;
  }

  public override bool RunTurnEndEvent(Entity entity) => this.CanTrigger() && (Object) entity == (Object) this.target && this.triggered;

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
