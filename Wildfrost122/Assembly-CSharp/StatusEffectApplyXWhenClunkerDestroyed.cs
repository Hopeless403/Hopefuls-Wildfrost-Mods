// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenClunkerDestroyed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Clunker Destroyed", fileName = "Apply X When Clunker Destroyed")]
public class StatusEffectApplyXWhenClunkerDestroyed : StatusEffectApplyX
{
  protected override void Init()
  {
    this.OnEntityDestroyed += new StatusEffectData.EffectEntityDeathEventHandler(this.Check);
  }

  public override bool RunEntityDestroyedEvent(Entity entity, DeathType deathType)
  {
    return this.target.enabled && entity.data.cardType.name == "Clunker" && Battle.IsOnBoard(this.target);
  }

  private IEnumerator Check(Entity entity, DeathType deathType) => this.Run(this.GetTargets());
}
