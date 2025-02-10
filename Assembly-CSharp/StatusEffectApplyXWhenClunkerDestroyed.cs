// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenClunkerDestroyed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Clunker Destroyed", fileName = "Apply X When Clunker Destroyed")]
public class StatusEffectApplyXWhenClunkerDestroyed : StatusEffectApplyX
{
  protected override void Init() => this.OnEntityDestroyed += new StatusEffectData.EffectEntityDeathEventHandler(this.Check);

  public override bool RunEntityDestroyedEvent(Entity entity, DeathType deathType) => this.target.enabled && entity.data.cardType.name == "Clunker" && Battle.IsOnBoard(this.target);

  private IEnumerator Check(Entity entity, DeathType deathType) => this.Run(this.GetTargets());
}
