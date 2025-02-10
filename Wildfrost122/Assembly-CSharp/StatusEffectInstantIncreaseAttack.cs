// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantIncreaseAttack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Increase Attack", fileName = "Increase Attack")]
public class StatusEffectInstantIncreaseAttack : StatusEffectInstant
{
  [SerializeField]
  private ScriptableAmount scriptableAmount;

  protected override IEnumerator Process()
  {
    StatusEffectInstantIncreaseAttack instantIncreaseAttack = this;
    instantIncreaseAttack.target.damage.current += (bool) (Object) instantIncreaseAttack.scriptableAmount ? instantIncreaseAttack.scriptableAmount.Get(instantIncreaseAttack.target) : instantIncreaseAttack.GetAmount();
    instantIncreaseAttack.target.PromptUpdate();
    // ISSUE: reference to a compiler-generated method
    yield return (object) instantIncreaseAttack.\u003C\u003En__0();
  }
}
