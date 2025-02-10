// Decompiled with JetBrains decompiler
// Type: StatusEffectWhileActiveAlliesImmuneToX
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific/While Active Allies Immune To X", fileName = "While Active Allies Immune To X")]
public class StatusEffectWhileActiveAlliesImmuneToX : StatusEffectData
{
  public List<Entity> affected = new List<Entity>();
  public bool pingDone;
  [SerializeField]
  public StatusEffectData immunityEffect;

  public override void Init()
  {
    this.OnEnable += new StatusEffectData.EffectEntityEventHandler(this.Enable);
    this.OnDisable += new StatusEffectData.EffectEntityEventHandler(this.Disable);
    this.OnCardMove += new StatusEffectData.EffectEntityEventHandler(this.CardMove);
  }

  public override bool RunEnableEvent(Entity entity) => (Object) entity == (Object) this.target;

  public IEnumerator Enable(Entity entity)
  {
    StatusEffectWhileActiveAlliesImmuneToX activeAlliesImmuneToX = this;
    if (!activeAlliesImmuneToX.pingDone)
    {
      CurveAnimator curveAnimator = activeAlliesImmuneToX.target.curveAnimator;
      if (curveAnimator != null)
      {
        double num = (double) curveAnimator.Ping();
      }
      activeAlliesImmuneToX.pingDone = true;
    }
    foreach (Entity ally in activeAlliesImmuneToX.target.GetAllies())
      yield return (object) activeAlliesImmuneToX.Affect(ally);
  }

  public override bool RunDisableEvent(Entity entity) => (Object) entity == (Object) this.target;

  public IEnumerator Disable(Entity entity)
  {
    foreach (Entity entity1 in this.affected)
      yield return (object) this.UnAffect(entity1);
    this.affected.Clear();
  }

  public override bool RunCardMoveEvent(Entity entity) => this.target.enabled && (Object) entity != (Object) this.target && (Object) entity.owner == (Object) this.target.owner && Battle.IsOnBoard(entity);

  public IEnumerator CardMove(Entity entity)
  {
    yield return (object) this.Affect(entity);
  }

  public IEnumerator Affect(Entity entity)
  {
    StatusEffectWhileActiveAlliesImmuneToX activeAlliesImmuneToX = this;
    if (!activeAlliesImmuneToX.affected.Contains(entity))
    {
      yield return (object) StatusEffectSystem.Apply(entity, activeAlliesImmuneToX.target, activeAlliesImmuneToX.immunityEffect, 1, true);
      entity.PromptUpdate();
      activeAlliesImmuneToX.affected.Add(entity);
    }
  }

  public IEnumerator UnAffect(Entity entity)
  {
    if (this.affected.Contains(entity))
    {
      for (int i = entity.statusEffects.Count - 1; i >= 0; --i)
      {
        StatusEffectData statusEffect = entity.statusEffects[i];
        if ((bool) (Object) statusEffect && statusEffect.name == this.immunityEffect.name)
          yield return (object) statusEffect.RemoveStacks(1, true);
      }
    }
  }
}
