// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantIncreaseMaxHealth
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Increase Max Health", fileName = "Increase Max Health")]
public class StatusEffectInstantIncreaseMaxHealth : StatusEffectInstant
{
  [SerializeField]
  private bool alsoIncreaseCurrentHealth = true;

  protected override IEnumerator Process()
  {
    StatusEffectInstantIncreaseMaxHealth increaseMaxHealth = this;
    increaseMaxHealth.target.hp.max += increaseMaxHealth.GetAmount();
    if (increaseMaxHealth.alsoIncreaseCurrentHealth)
      increaseMaxHealth.target.hp.current += increaseMaxHealth.GetAmount();
    increaseMaxHealth.target.PromptUpdate();
    // ISSUE: reference to a compiler-generated method
    yield return (object) increaseMaxHealth.\u003C\u003En__0();
  }
}
