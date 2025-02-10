// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenClunkerDestroyed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Clunker Destroyed", fileName = "Apply X When Clunker Destroyed")]
public class StatusEffectApplyXWhenClunkerDestroyed : StatusEffectApplyX
{
  public override void Init() => this.OnEntityDestroyed += new StatusEffectData.EffectEntityDeathEventHandler(this.Check);

  public override bool RunEntityDestroyedEvent(Entity entity, DeathType deathType) => this.target.enabled && entity.data.cardType.name == "Clunker" && Battle.IsOnBoard(this.target);

  public IEnumerator Check(Entity entity, DeathType deathType) => this.Run(this.GetTargets());
}
