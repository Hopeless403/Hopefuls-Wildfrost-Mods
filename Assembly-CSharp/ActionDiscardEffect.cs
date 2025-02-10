// Decompiled with JetBrains decompiler
// Type: ActionDiscardEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

public class ActionDiscardEffect : PlayAction
{
  public readonly Entity target;
  private readonly int healAmount;

  public ActionDiscardEffect(Entity target, int healAmount)
  {
    this.target = target;
    this.healAmount = healAmount;
  }

  public override IEnumerator Run()
  {
    Routine.Clump clump = new Routine.Clump();
    if (this.target.data.hasHealth)
    {
      this.target.hp.current = Mathf.Min(this.target.hp.current + this.healAmount, this.target.hp.max);
      this.target.PromptUpdate();
      CurveAnimator curveAnimator = this.target.curveAnimator;
      if (curveAnimator != null)
      {
        double num = (double) curveAnimator.Ping();
      }
      clump.Add(Sequences.Wait(0.6f));
      SfxSystem.OneShot("event:/sfx/status/heal");
    }
    clump.Add(this.RemoveStatuses());
    yield return (object) clump.WaitForEnd();
  }

  private IEnumerator RemoveStatuses()
  {
    for (int i = this.target.statusEffects.Count - 1; i >= 0; --i)
    {
      StatusEffectData statusEffect = this.target.statusEffects[i];
      if ((bool) (Object) statusEffect && statusEffect.removeOnDiscard)
        yield return (object) statusEffect.Remove();
    }
  }
}
