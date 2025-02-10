// Decompiled with JetBrains decompiler
// Type: StatusEffectWhileLastInHandX
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Linq;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/While Last In Hand X", fileName = "While Last In Hand X")]
public class StatusEffectWhileLastInHandX : StatusEffectWhileActiveX
{
  public bool isInHand;

  public override void Init()
  {
    base.Init();
    this.OnEntityDestroyed += new StatusEffectData.EffectEntityDeathEventHandler(this.EntityDestroyed);
  }

  public override bool CanActivate()
  {
    return this.isInHand && (UnityEngine.Object) this.target.owner.handContainer.FirstOrDefault<Entity>((Func<Entity, bool>) (a => a.alive)) == (UnityEngine.Object) this.target;
  }

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

  public override IEnumerator CardMove(Entity entity)
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

  public override bool RunEntityDestroyedEvent(Entity entity, DeathType deathType)
  {
    return !this.active && (UnityEngine.Object) entity != (UnityEngine.Object) this.target && this.EntityInHand(entity);
  }

  public IEnumerator EntityDestroyed(Entity entity, DeathType deathType)
  {
    StatusEffectWhileLastInHandX whileLastInHandX = this;
    if (whileLastInHandX.CanActivate())
      yield return (object) whileLastInHandX.Activate();
  }

  public bool EntityInHand(Entity entity)
  {
    return entity.containers.Length == 0 ? entity.preContainers.Contains<CardContainer>(this.target.owner.handContainer) : entity.containers.Contains<CardContainer>(this.target.owner.handContainer);
  }
}
