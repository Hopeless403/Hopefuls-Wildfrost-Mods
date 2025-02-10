// Decompiled with JetBrains decompiler
// Type: StatusEffectShroom
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Status Effects/Shroom", fileName = "Shroom")]
public class StatusEffectShroom : StatusEffectData
{
  private bool subbed;
  private bool primed;

  protected override void Init()
  {
    this.OnTurnEnd += new StatusEffectData.EffectEntityEventHandler(this.DealDamage);
    global::Events.OnPostProcessUnits += new UnityAction<Character>(this.Prime);
    this.subbed = true;
  }

  private void OnDestroy() => this.Unsub();

  private void Unsub()
  {
    if (!this.subbed)
      return;
    global::Events.OnPostProcessUnits -= new UnityAction<Character>(this.Prime);
    this.subbed = false;
  }

  private void Prime(Character character)
  {
    this.primed = true;
    this.Unsub();
  }

  public override bool RunTurnEndEvent(Entity entity) => this.primed && this.target.enabled && (Object) entity == (Object) this.target;

  private IEnumerator DealDamage(Entity entity)
  {
    StatusEffectShroom status = this;
    yield return (object) new Hit(status.GetDamager(), status.target, status.count)
    {
      screenShake = 0.25f,
      damageType = "shroom"
    }.Process();
    yield return (object) Sequences.Wait(0.2f);
    int amount = 1;
    global::Events.InvokeStatusEffectCountDown((StatusEffectData) status, ref amount);
    if (amount != 0)
      yield return (object) status.CountDown(entity, amount);
  }
}
