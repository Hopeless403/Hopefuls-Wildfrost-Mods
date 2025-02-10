// Decompiled with JetBrains decompiler
// Type: StatusEffectSummoned
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Summoned", fileName = "Summoned")]
public class StatusEffectSummoned : StatusEffectData
{
  public bool triggered;

  public override void Init() => this.OnTurnEnd += new StatusEffectData.EffectEntityEventHandler(this.DealDamage);

  public override bool RunCardPlayedEvent(Entity entity, Entity[] targets)
  {
    if ((Object) entity == (Object) this.target)
      this.triggered = true;
    return false;
  }

  public override bool RunTurnEndEvent(Entity entity) => this.CanTrigger() && (Object) entity == (Object) this.target && this.triggered;

  public IEnumerator DealDamage(Entity entity)
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
