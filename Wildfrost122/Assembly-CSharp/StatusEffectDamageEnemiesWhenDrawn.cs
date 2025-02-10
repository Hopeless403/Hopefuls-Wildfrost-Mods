// Decompiled with JetBrains decompiler
// Type: StatusEffectDamageEnemiesWhenDrawn
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X To Enemies When Drawn", fileName = "Apply X To Enemies When Drawn")]
public class StatusEffectDamageEnemiesWhenDrawn : StatusEffectApplyX
{
  protected override void Init()
  {
    this.OnEnable += new StatusEffectData.EffectEntityEventHandler(this.Check);
  }

  public override bool RunEnableEvent(Entity entity)
  {
    return (Object) entity == (Object) this.target && this.target.InHand();
  }

  private IEnumerator Check(Entity entity) => this.Run(this.GetTargets());
}
