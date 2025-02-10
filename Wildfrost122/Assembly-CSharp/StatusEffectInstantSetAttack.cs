// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantSetAttack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Set Attack", fileName = "Set Attack")]
public class StatusEffectInstantSetAttack : StatusEffectInstant
{
  [SerializeField]
  private bool maxOnly;
  [SerializeField]
  private bool equalAmount = true;
  [SerializeField]
  [HideIf("equalAmount")]
  private StatusEffectInstantSetAttack setMaxAttackEffect;
  [SerializeField]
  [HideIf("equalAmount")]
  private float factor = 1f;

  protected override IEnumerator Process()
  {
    StatusEffectInstantSetAttack instantSetAttack = this;
    if (instantSetAttack.equalAmount)
    {
      int amount = instantSetAttack.GetAmount();
      instantSetAttack.target.damage.max = amount;
      instantSetAttack.target.damage.current = instantSetAttack.maxOnly ? Mathf.Min(instantSetAttack.target.damage.current, instantSetAttack.target.damage.max) : amount;
    }
    else if ((double) instantSetAttack.factor < 1.0)
    {
      int count = Mathf.CeilToInt((float) instantSetAttack.target.damage.max * instantSetAttack.factor);
      int damage = Mathf.FloorToInt((float) instantSetAttack.target.damage.current * instantSetAttack.factor);
      if (damage > 0)
      {
        Hit hit = new Hit((Entity) null, instantSetAttack.target, damage)
        {
          countsAsHit = false,
          screenShake = 0.0f
        };
        hit.AddStatusEffect((StatusEffectData) instantSetAttack.setMaxAttackEffect, count);
        yield return (object) hit.Process();
      }
    }
    else
    {
      instantSetAttack.target.damage.max = Mathf.CeilToInt((float) instantSetAttack.target.damage.max * instantSetAttack.factor);
      instantSetAttack.target.damage.current = Mathf.CeilToInt((float) instantSetAttack.target.damage.current * instantSetAttack.factor);
    }
    instantSetAttack.target.PromptUpdate();
    // ISSUE: reference to a compiler-generated method
    yield return (object) instantSetAttack.\u003C\u003En__0();
  }
}
