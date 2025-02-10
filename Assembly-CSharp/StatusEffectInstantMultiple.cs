// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantMultiple
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Instant/Multiple", fileName = "Instant Apply X")]
public class StatusEffectInstantMultiple : StatusEffectInstant
{
  public StatusEffectInstant[] effects;

  public override bool CanStackActions => false;

  protected override IEnumerator Process()
  {
    StatusEffectInstantMultiple effectInstantMultiple = this;
    int amount = effectInstantMultiple.GetAmount();
    Routine.Clump clump = new Routine.Clump();
    foreach (StatusEffectInstant effect in effectInstantMultiple.effects)
    {
      if (!effect.canBeBoosted || amount > 0)
        clump.Add(StatusEffectSystem.Apply(effectInstantMultiple.target, effectInstantMultiple.applier, (StatusEffectData) effect, amount, true));
    }
    yield return (object) clump.WaitForEnd();
    // ISSUE: reference to a compiler-generated method
    yield return (object) effectInstantMultiple.\u003C\u003En__0();
  }
}
