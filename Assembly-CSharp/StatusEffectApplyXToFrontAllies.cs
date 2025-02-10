// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXToFrontAllies
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X To Front Allies", fileName = "Apply X To Front Allies")]
public class StatusEffectApplyXToFrontAllies : StatusEffectApplyX
{
  protected override void Init() => this.OnCardPlayed += new StatusEffectData.EffectCardPlayEventHandler(this.Run);

  public override bool RunCardPlayedEvent(Entity entity, Entity[] targets) => (Object) entity == (Object) this.target;

  private IEnumerator Run(Entity entity, Entity[] targets)
  {
    StatusEffectApplyXToFrontAllies applyXtoFrontAllies = this;
    int a = applyXtoFrontAllies.GetAmount();
    List<Entity> toAffect = new List<Entity>();
    foreach (CardContainer row in Battle.instance.GetRows(applyXtoFrontAllies.target.owner))
      toAffect.AddIfNotNull<Entity>(row.GetTop());
    if (toAffect.Count > 0)
    {
      double num = (double) applyXtoFrontAllies.target.curveAnimator.Ping();
      yield return (object) Sequences.Wait(0.13f);
      Routine.Clump clump = new Routine.Clump();
      foreach (Entity target in toAffect)
      {
        Hit hit = new Hit(applyXtoFrontAllies.target, target, 0);
        hit.AddStatusEffect(applyXtoFrontAllies.effectToApply, a);
        clump.Add(hit.Process());
      }
      yield return (object) clump.WaitForEnd();
      yield return (object) Sequences.Wait(0.13f);
    }
  }
}
