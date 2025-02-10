// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXToFrontAllyBasedOnDamageDealt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X To Front Ally Based On Damage Dealt", fileName = "Apply X To Front Ally Based On Damage Dealt")]
public class StatusEffectApplyXToFrontAllyBasedOnDamageDealt : StatusEffectApplyX
{
  public Dictionary<Entity, int[]> entitiesHitInRows = new Dictionary<Entity, int[]>();
  public Dictionary<int, int> damageDealtInRows = new Dictionary<int, int>();

  public override void Init()
  {
    this.OnCardPlayed += new StatusEffectData.EffectCardPlayEventHandler(this.Check);
  }

  public override bool RunHitEvent(Hit hit)
  {
    if ((Object) hit.attacker == (Object) this.target && (Object) hit.target != (Object) null && hit.Offensive)
      this.entitiesHitInRows.Add(hit.target, Battle.instance.GetRowIndices(hit.target));
    return false;
  }

  public override bool RunPostHitEvent(Hit hit)
  {
    if ((Object) hit.attacker == (Object) this.target && this.entitiesHitInRows.ContainsKey(hit.target) && hit.damageDealt > 0)
    {
      int[] entitiesHitInRow = this.entitiesHitInRows[hit.target];
      int damageDealt = hit.damageDealt;
      foreach (int key in entitiesHitInRow)
      {
        if (this.damageDealtInRows.ContainsKey(key))
          this.damageDealtInRows[key] += damageDealt;
        else
          this.damageDealtInRows[key] = damageDealt;
      }
    }
    return false;
  }

  public override bool RunCardPlayedEvent(Entity entity, Entity[] targets)
  {
    if (!((Object) entity == (Object) this.target))
      return false;
    return this.damageDealtInRows.Count > 0 || this.entitiesHitInRows.Count > 0;
  }

  public IEnumerator Check(Entity entity, Entity[] targets)
  {
    StatusEffectApplyXToFrontAllyBasedOnDamageDealt basedOnDamageDealt = this;
    Dictionary<Entity, int> toAffect = new Dictionary<Entity, int>();
    foreach (int key in basedOnDamageDealt.damageDealtInRows.Keys)
    {
      CardContainer row = Battle.instance.GetRow(basedOnDamageDealt.target.owner, key);
      if ((Object) row != (Object) null)
      {
        Entity top = row.GetTop();
        if ((Object) top != (Object) null)
          toAffect[top] = basedOnDamageDealt.damageDealtInRows[key];
      }
    }
    if (toAffect.Count > 0)
    {
      yield return (object) Sequences.WaitForAnimationEnd(basedOnDamageDealt.target);
      double num1 = (double) basedOnDamageDealt.target.curveAnimator.Ping();
      yield return (object) Sequences.Wait(0.1f);
      Routine.Clump clump = new Routine.Clump();
      foreach (Entity key in toAffect.Keys)
      {
        int count = toAffect[key];
        Hit hit = new Hit(basedOnDamageDealt.target, key, 0);
        hit.AddStatusEffect(basedOnDamageDealt.effectToApply, count);
        clump.Add(hit.Process());
        if (basedOnDamageDealt.doPing)
        {
          double num2 = (double) key.curveAnimator.Ping();
        }
      }
      yield return (object) clump.WaitForEnd();
    }
    yield return (object) Sequences.Wait(0.1f);
    basedOnDamageDealt.damageDealtInRows.Clear();
    basedOnDamageDealt.entitiesHitInRows.Clear();
  }
}
