// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantSetHealth
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Instant/Set Health", fileName = "Set Health")]
public class StatusEffectInstantSetHealth : StatusEffectInstant
{
  [SerializeField]
  private bool maxOnly;
  [SerializeField]
  private bool equalAmount = true;
  [SerializeField]
  [HideIf("equalAmount")]
  private StatusEffectInstantSetHealth setMaxHealthEffect;
  [SerializeField]
  [HideIf("equalAmount")]
  private float factor = 1f;

  protected override IEnumerator Process()
  {
    StatusEffectInstantSetHealth instantSetHealth = this;
    if (instantSetHealth.equalAmount)
    {
      int amount = instantSetHealth.GetAmount();
      instantSetHealth.target.hp.max = amount;
      instantSetHealth.target.hp.current = instantSetHealth.maxOnly ? Mathf.Min(instantSetHealth.target.hp.current, instantSetHealth.target.hp.max) : amount;
    }
    else if ((double) instantSetHealth.factor < 1.0)
    {
      int count = Mathf.CeilToInt((float) instantSetHealth.target.hp.max * instantSetHealth.factor);
      int damage = Mathf.FloorToInt((float) instantSetHealth.target.hp.current * instantSetHealth.factor);
      if (damage > 0)
      {
        Hit hit = new Hit((Entity) null, instantSetHealth.target, damage)
        {
          countsAsHit = false,
          screenShake = 0.0f
        };
        hit.AddStatusEffect((StatusEffectData) instantSetHealth.setMaxHealthEffect, count);
        yield return (object) hit.Process();
      }
    }
    else
    {
      instantSetHealth.target.hp.max = Mathf.CeilToInt((float) instantSetHealth.target.hp.max * instantSetHealth.factor);
      instantSetHealth.target.hp.current = Mathf.CeilToInt((float) instantSetHealth.target.hp.current * instantSetHealth.factor);
    }
    instantSetHealth.target.PromptUpdate();
    // ISSUE: reference to a compiler-generated method
    yield return (object) instantSetHealth.\u003C\u003En__0();
  }
}
