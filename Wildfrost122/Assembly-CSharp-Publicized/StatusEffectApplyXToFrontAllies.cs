// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXToFrontAllies
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X To Front Allies", fileName = "Apply X To Front Allies")]
public class StatusEffectApplyXToFrontAllies : StatusEffectApplyX
{
  public override void Init()
  {
    this.OnCardPlayed += new StatusEffectData.EffectCardPlayEventHandler(this.Run);
  }

  public override bool RunCardPlayedEvent(Entity entity, Entity[] targets)
  {
    return (Object) entity == (Object) this.target;
  }

  public IEnumerator Run(Entity entity, Entity[] targets)
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
