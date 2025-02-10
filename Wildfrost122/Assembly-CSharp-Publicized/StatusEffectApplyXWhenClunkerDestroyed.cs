// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenClunkerDestroyed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Clunker Destroyed", fileName = "Apply X When Clunker Destroyed")]
public class StatusEffectApplyXWhenClunkerDestroyed : StatusEffectApplyX
{
  public override void Init()
  {
    this.OnEntityDestroyed += new StatusEffectData.EffectEntityDeathEventHandler(this.Check);
  }

  public override bool RunEntityDestroyedEvent(Entity entity, DeathType deathType)
  {
    return this.target.enabled && entity.data.cardType.name == "Clunker" && Battle.IsOnBoard(this.target);
  }

  public IEnumerator Check(Entity entity, DeathType deathType) => this.Run(this.GetTargets());
}
