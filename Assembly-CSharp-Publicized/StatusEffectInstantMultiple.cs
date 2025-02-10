// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantMultiple
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Instant/Multiple", fileName = "Instant Apply X")]
public class StatusEffectInstantMultiple : StatusEffectInstant
{
  public StatusEffectInstant[] effects;

  public override bool CanStackActions => false;

  public override IEnumerator Process()
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
    yield return (object) effectInstantMultiple.\u003C\u003En__0();
  }

  [CompilerGenerated]
  [DebuggerHidden]
  public new IEnumerator \u003C\u003En__0() => base.Process();
}
