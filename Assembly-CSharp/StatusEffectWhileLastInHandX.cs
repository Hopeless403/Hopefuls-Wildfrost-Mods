// Decompiled with JetBrains decompiler
// Type: StatusEffectWhileLastInHandX
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific/While Last In Hand X", fileName = "While Last In Hand X")]
public class StatusEffectWhileLastInHandX : StatusEffectWhileActiveX
{
  private bool isInHand;

  protected override void Init()
  {
    base.Init();
    this.OnEntityDestroyed += new StatusEffectData.EffectEntityDeathEventHandler(this.EntityDestroyed);
  }

  protected override bool CanActivate() => this.isInHand && (UnityEngine.Object) this.target.owner.handContainer.FirstOrDefault<Entity>((Func<Entity, bool>) (a => a.alive)) == (UnityEngine.Object) this.target;

  public override bool RunBeginEvent()
  {
    this.isInHand = this.target.InHand();
    return base.RunBeginEvent();
  }

  public override bool RunEnableEvent(Entity entity)
  {
    if ((UnityEngine.Object) this.target == (UnityEngine.Object) entity)
      this.isInHand = this.target.InHand();
    return base.RunEnableEvent(entity);
  }

  public override bool RunCardMoveEvent(Entity entity) => this.target.enabled;

  protected override IEnumerator CardMove(Entity entity)
  {
    StatusEffectWhileLastInHandX whileLastInHandX = this;
    if ((UnityEngine.Object) whileLastInHandX.target == (UnityEngine.Object) entity)
      whileLastInHandX.isInHand = whileLastInHandX.target.InHand();
    if (whileLastInHandX.active)
    {
      if (((UnityEngine.Object) whileLastInHandX.target == (UnityEngine.Object) entity || entity.containers.Contains<CardContainer>(whileLastInHandX.target.owner.handContainer)) && !whileLastInHandX.CanActivate())
        yield return (object) whileLastInHandX.Deactivate();
    }
    else if (whileLastInHandX.CanActivate())
      yield return (object) whileLastInHandX.Activate();
  }

  public override bool RunEntityDestroyedEvent(Entity entity, DeathType deathType) => !this.active && (UnityEngine.Object) entity != (UnityEngine.Object) this.target && this.EntityInHand(entity);

  private IEnumerator EntityDestroyed(Entity entity, DeathType deathType)
  {
    StatusEffectWhileLastInHandX whileLastInHandX = this;
    if (whileLastInHandX.CanActivate())
      yield return (object) whileLastInHandX.Activate();
  }

  private bool EntityInHand(Entity entity)
  {
    if ((bool) (UnityEngine.Object) entity)
    {
      CardContainer[] containers = entity.containers;
      if ((containers != null ? (containers.Length != 0 ? 1 : 0) : 0) != 0)
        return entity.containers.Contains<CardContainer>(this.target?.owner?.handContainer);
    }
    return entity.preContainers.Contains<CardContainer>(this.target?.owner?.handContainer);
  }
}
