// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantSetAttack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Set Attack", fileName = "Set Attack")]
public class StatusEffectInstantSetAttack : StatusEffectInstant
{
  [SerializeField]
  public bool maxOnly;
  [SerializeField]
  public bool equalAmount = true;
  [SerializeField]
  [HideIf("equalAmount")]
  public StatusEffectInstantSetAttack setMaxAttackEffect;
  [SerializeField]
  [HideIf("equalAmount")]
  public float factor = 1f;

  public override IEnumerator Process()
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
    yield return (object) instantSetAttack.\u003C\u003En__0();
  }

  [CompilerGenerated]
  [DebuggerHidden]
  public new IEnumerator \u003C\u003En__0() => base.Process();
}
