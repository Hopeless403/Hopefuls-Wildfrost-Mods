// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantSetHealth
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Instant/Set Health", fileName = "Set Health")]
public class StatusEffectInstantSetHealth : StatusEffectInstant
{
  [SerializeField]
  public bool maxOnly;
  [SerializeField]
  public bool equalAmount = true;
  [SerializeField]
  [HideIf("equalAmount")]
  public StatusEffectInstantSetHealth setMaxHealthEffect;
  [SerializeField]
  [HideIf("equalAmount")]
  public float factor = 1f;

  public override IEnumerator Process()
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
    yield return (object) instantSetHealth.\u003C\u003En__0();
  }

  [CompilerGenerated]
  [DebuggerHidden]
  public new IEnumerator \u003C\u003En__0() => base.Process();
}
