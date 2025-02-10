// Decompiled with JetBrains decompiler
// Type: StatusEffectSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
public class StatusEffectSystem : GameSystem
{
  public static readonly FreezableList<StatusEffectData> activeEffects = new FreezableList<StatusEffectData>(true, (IComparer<StatusEffectData>) new StatusEffectSystem.StatusEffectComparer());
  public static int eventRoutineCount;

  public static bool EventsRunning => StatusEffectSystem.eventRoutineCount > 0;

  public static IEnumerator Apply(
    Entity target,
    Entity applier,
    StatusEffectData effectData,
    int count,
    bool temporary = false,
    Action<StatusEffectData> onEffectApplied = null,
    bool fireEvents = true,
    bool applyEvenIfZero = false)
  {
    bool flag = true;
    if (effectData.targetConstraints != null && ((IEnumerable<TargetConstraint>) effectData.targetConstraints).Any<TargetConstraint>((Func<TargetConstraint, bool>) (constraint => !constraint.Check(target))))
      flag = false;
    if (flag)
    {
      StatusEffectSystem.activeEffects.Freeze();
      StatusEffectApply s = new StatusEffectApply(applier, target, effectData, count);
      if (fireEvents)
        yield return (object) StatusEffectSystem.ApplyStatusEvent(s);
      if ((bool) (UnityEngine.Object) s.effectData && (s.count > 0 | applyEvenIfZero || !s.effectData.canBeBoosted || s.effectData is StatusEffectInstantMultiple))
      {
        StatusEffectData effect = target.statusEffects.Find((Predicate<StatusEffectData>) (a => a.name == s.effectData.name));
        if ((bool) (UnityEngine.Object) effect && effect.stackable)
        {
          Debug.Log((object) string.Format("Stacking [{0} {1}] on top of [{2}]", (object) s.effectData.name, (object) s.count, (object) target.name));
          effect.count += s.count;
          if (temporary)
            effect.temporary += s.count;
          effect.applier = applier;
        }
        else
        {
          Debug.Log((object) string.Format("[{0} {1}] applied to [{2}]", (object) s.effectData.name, (object) s.count, (object) target.name));
          effect = s.effectData.Instantiate();
          effect.Apply(s.count, target, applier);
          if (temporary)
            effect.temporary = s.count;
          StatusEffectSystem.activeEffects.Add(effect);
          Action<StatusEffectData> action = onEffectApplied;
          if (action != null)
            action(effect);
          if (effect.RunBeginEvent() && effect.HasBeginRoutine)
            yield return (object) effect.BeginRoutine();
        }
        if ((bool) (UnityEngine.Object) applier)
          effect.applierOwner = applier.owner;
        if (effect.RunStackEvent(s.count) && effect.HasStackRoutine)
          yield return (object) effect.StackRoutine(s.count);
        target.PromptUpdate();
        effect = (StatusEffectData) null;
      }
      if (target.startingEffectsApplied && target.display.init && fireEvents)
      {
        Events.InvokeStatusEffectApplied(s);
        yield return (object) StatusEffectSystem.PostApplyStatusEvent(s);
      }
      StatusEffectSystem.activeEffects.Thaw();
    }
  }

  public static IEnumerator Clear()
  {
    StatusEffectSystem.activeEffects.Freeze();
    for (int i = StatusEffectSystem.activeEffects.Count - 1; i >= 0; --i)
      yield return (object) StatusEffectSystem.activeEffects[i].Remove();
    StatusEffectSystem.activeEffects.Thaw();
  }

  public static IEnumerator EntityEnableEvent(Entity entity)
  {
    ++StatusEffectSystem.eventRoutineCount;
    StatusEffectSystem.activeEffects.Freeze();
    int c = StatusEffectSystem.activeEffects.Count;
    for (int i = c - 1; i >= 0; --i)
    {
      int count = StatusEffectSystem.activeEffects.Count;
      if (count < c)
      {
        i -= c - count;
        c = count;
      }
      if (i >= 0)
      {
        StatusEffectData activeEffect = StatusEffectSystem.activeEffects[i];
        if ((UnityEngine.Object) activeEffect.target != (UnityEngine.Object) null && activeEffect.RunEnableEvent(entity) && activeEffect.HasEnableRoutine)
          yield return (object) activeEffect.EnableRoutine(entity);
      }
      else
        break;
    }
    StatusEffectSystem.activeEffects.Thaw();
    --StatusEffectSystem.eventRoutineCount;
    yield return (object) Sequences.Null();
  }

  public static IEnumerator EntityDisableEvent(Entity entity)
  {
    ++StatusEffectSystem.eventRoutineCount;
    StatusEffectSystem.activeEffects.Freeze();
    int c = StatusEffectSystem.activeEffects.Count;
    for (int i = c - 1; i >= 0; --i)
    {
      int count = StatusEffectSystem.activeEffects.Count;
      if (count < c)
      {
        i -= c - count;
        c = count;
      }
      if (i >= 0)
      {
        StatusEffectData activeEffect = StatusEffectSystem.activeEffects[i];
        if ((UnityEngine.Object) activeEffect.target != (UnityEngine.Object) null && activeEffect.RunDisableEvent(entity) && activeEffect.HasDisableRoutine)
          yield return (object) activeEffect.DisableRoutine(entity);
      }
      else
        break;
    }
    StatusEffectSystem.activeEffects.Thaw();
    --StatusEffectSystem.eventRoutineCount;
    yield return (object) Sequences.Null();
  }

  public static IEnumerator TurnStartEvent(Entity entity)
  {
    ++StatusEffectSystem.eventRoutineCount;
    StatusEffectSystem.activeEffects.Freeze();
    int c = StatusEffectSystem.activeEffects.Count;
    for (int i = c - 1; i >= 0; --i)
    {
      int count = StatusEffectSystem.activeEffects.Count;
      if (count < c)
      {
        i -= c - count;
        c = count;
      }
      if (i >= 0)
      {
        StatusEffectData activeEffect = StatusEffectSystem.activeEffects[i];
        if ((UnityEngine.Object) activeEffect.target != (UnityEngine.Object) null && activeEffect.RunTurnStartEvent(entity) && activeEffect.HasTurnStartRoutine)
          yield return (object) activeEffect.TurnStartRoutine(entity);
      }
      else
        break;
    }
    StatusEffectSystem.activeEffects.Thaw();
    --StatusEffectSystem.eventRoutineCount;
    yield return (object) Sequences.Null();
  }

  public static IEnumerator TurnEvent(Entity entity)
  {
    ++StatusEffectSystem.eventRoutineCount;
    StatusEffectSystem.activeEffects.Freeze();
    int c = StatusEffectSystem.activeEffects.Count;
    for (int i = c - 1; i >= 0; --i)
    {
      int count = StatusEffectSystem.activeEffects.Count;
      if (count < c)
      {
        i -= c - count;
        c = count;
      }
      if (i >= 0)
      {
        StatusEffectData activeEffect = StatusEffectSystem.activeEffects[i];
        if ((UnityEngine.Object) activeEffect.target != (UnityEngine.Object) null && activeEffect.RunTurnEvent(entity) && activeEffect.HasTurnRoutine)
          yield return (object) activeEffect.TurnRoutine(entity);
      }
      else
        break;
    }
    StatusEffectSystem.activeEffects.Thaw();
    --StatusEffectSystem.eventRoutineCount;
    yield return (object) Sequences.Null();
  }

  public static IEnumerator TurnEndEvent(Entity entity)
  {
    ++StatusEffectSystem.eventRoutineCount;
    StatusEffectSystem.activeEffects.Freeze();
    int c = StatusEffectSystem.activeEffects.Count;
    for (int i = c - 1; i >= 0; --i)
    {
      int count = StatusEffectSystem.activeEffects.Count;
      if (count < c)
      {
        i -= c - count;
        c = count;
      }
      if (i >= 0)
      {
        StatusEffectData activeEffect = StatusEffectSystem.activeEffects[i];
        if ((UnityEngine.Object) activeEffect.target != (UnityEngine.Object) null && activeEffect.RunTurnEndEvent(entity) && activeEffect.HasTurnEndRoutine)
          yield return (object) activeEffect.TurnEndRoutine(entity);
      }
      else
        break;
    }
    StatusEffectSystem.activeEffects.Thaw();
    --StatusEffectSystem.eventRoutineCount;
    yield return (object) Sequences.Null();
  }

  public static IEnumerator PreAttackEvent(Hit hit)
  {
    ++StatusEffectSystem.eventRoutineCount;
    StatusEffectSystem.activeEffects.Freeze();
    int c = StatusEffectSystem.activeEffects.Count;
    for (int i = c - 1; i >= 0; --i)
    {
      int count = StatusEffectSystem.activeEffects.Count;
      if (count < c)
      {
        i -= c - count;
        c = count;
      }
      if (i >= 0)
      {
        StatusEffectData activeEffect = StatusEffectSystem.activeEffects[i];
        if ((UnityEngine.Object) activeEffect.target != (UnityEngine.Object) null && activeEffect.RunPreAttackEvent(hit) && activeEffect.HasPreAttackRoutine)
          yield return (object) activeEffect.PreAttackRoutine(hit);
      }
      else
        break;
    }
    StatusEffectSystem.activeEffects.Thaw();
    --StatusEffectSystem.eventRoutineCount;
    yield return (object) Sequences.Null();
  }

  public static IEnumerator HitEvent(Hit hit)
  {
    ++StatusEffectSystem.eventRoutineCount;
    StatusEffectSystem.activeEffects.Freeze();
    int c = StatusEffectSystem.activeEffects.Count;
    for (int i = c - 1; i >= 0; --i)
    {
      int count = StatusEffectSystem.activeEffects.Count;
      if (count < c)
      {
        i -= c - count;
        c = count;
      }
      if (i >= 0)
      {
        StatusEffectData activeEffect = StatusEffectSystem.activeEffects[i];
        if ((UnityEngine.Object) activeEffect.target != (UnityEngine.Object) null && activeEffect.RunHitEvent(hit) && activeEffect.HasHitRoutine)
          yield return (object) activeEffect.HitRoutine(hit);
      }
      else
        break;
    }
    StatusEffectSystem.activeEffects.Thaw();
    --StatusEffectSystem.eventRoutineCount;
    yield return (object) Sequences.Null();
  }

  public static IEnumerator PostHitEvent(Hit hit)
  {
    ++StatusEffectSystem.eventRoutineCount;
    StatusEffectSystem.activeEffects.Freeze();
    int c = StatusEffectSystem.activeEffects.Count;
    for (int i = c - 1; i >= 0; --i)
    {
      int count = StatusEffectSystem.activeEffects.Count;
      if (count < c)
      {
        i -= c - count;
        c = count;
      }
      if (i >= 0)
      {
        StatusEffectData activeEffect = StatusEffectSystem.activeEffects[i];
        if ((UnityEngine.Object) activeEffect.target != (UnityEngine.Object) null && activeEffect.RunPostHitEvent(hit) && activeEffect.HasPostHitRoutine)
          yield return (object) activeEffect.PostHitRoutine(hit);
      }
      else
        break;
    }
    StatusEffectSystem.activeEffects.Thaw();
    --StatusEffectSystem.eventRoutineCount;
    yield return (object) Sequences.Null();
  }

  public static IEnumerator PostAttackEvent(Hit hit)
  {
    ++StatusEffectSystem.eventRoutineCount;
    StatusEffectSystem.activeEffects.Freeze();
    int c = StatusEffectSystem.activeEffects.Count;
    for (int i = c - 1; i >= 0; --i)
    {
      int count = StatusEffectSystem.activeEffects.Count;
      if (count < c)
      {
        i -= c - count;
        c = count;
      }
      if (i >= 0)
      {
        StatusEffectData activeEffect = StatusEffectSystem.activeEffects[i];
        if ((UnityEngine.Object) activeEffect.target != (UnityEngine.Object) null && activeEffect.RunPostAttackEvent(hit) && activeEffect.HasPostAttackRoutine)
          yield return (object) activeEffect.PostAttackRoutine(hit);
      }
      else
        break;
    }
    StatusEffectSystem.activeEffects.Thaw();
    --StatusEffectSystem.eventRoutineCount;
    yield return (object) Sequences.Null();
  }

  public static IEnumerator ApplyStatusEvent(StatusEffectApply apply)
  {
    ++StatusEffectSystem.eventRoutineCount;
    StatusEffectSystem.activeEffects.Freeze();
    int c = StatusEffectSystem.activeEffects.Count;
    for (int i = c - 1; i >= 0; --i)
    {
      int count = StatusEffectSystem.activeEffects.Count;
      if (count < c)
      {
        i -= c - count;
        c = count;
      }
      if (i >= 0)
      {
        StatusEffectData activeEffect = StatusEffectSystem.activeEffects[i];
        if ((UnityEngine.Object) activeEffect.target != (UnityEngine.Object) null && activeEffect.RunApplyStatusEvent(apply) && activeEffect.HasApplyStatusRoutine)
          yield return (object) activeEffect.ApplyStatusRoutine(apply);
      }
      else
        break;
    }
    StatusEffectSystem.activeEffects.Thaw();
    --StatusEffectSystem.eventRoutineCount;
    yield return (object) Sequences.Null();
  }

  public static IEnumerator PostApplyStatusEvent(StatusEffectApply apply)
  {
    ++StatusEffectSystem.eventRoutineCount;
    StatusEffectSystem.activeEffects.Freeze();
    int c = StatusEffectSystem.activeEffects.Count;
    for (int i = c - 1; i >= 0; --i)
    {
      int count = StatusEffectSystem.activeEffects.Count;
      if (count < c)
      {
        i -= c - count;
        c = count;
      }
      if (i >= 0)
      {
        StatusEffectData activeEffect = StatusEffectSystem.activeEffects[i];
        if ((UnityEngine.Object) activeEffect.target != (UnityEngine.Object) null && activeEffect.RunPostApplyStatusEvent(apply) && activeEffect.HasPostApplyStatusRoutine)
          yield return (object) activeEffect.PostApplyStatusRoutine(apply);
      }
      else
        break;
    }
    StatusEffectSystem.activeEffects.Thaw();
    --StatusEffectSystem.eventRoutineCount;
    yield return (object) Sequences.Null();
  }

  public static IEnumerator EntityDestroyedEvent(Entity entity, DeathType deathType)
  {
    ++StatusEffectSystem.eventRoutineCount;
    StatusEffectSystem.activeEffects.Freeze();
    int c = StatusEffectSystem.activeEffects.Count;
    int i;
    for (i = c - 1; i >= 0; --i)
    {
      int count = StatusEffectSystem.activeEffects.Count;
      if (count < c)
      {
        i -= c - count;
        c = count;
      }
      if (i >= 0)
      {
        StatusEffectData activeEffect = StatusEffectSystem.activeEffects[i];
        if ((UnityEngine.Object) activeEffect.target != (UnityEngine.Object) null && activeEffect.RunEntityDestroyedEvent(entity, deathType) && activeEffect.HasEntityDestroyedRoutine)
          yield return (object) activeEffect.EntityDestroyedRoutine(entity, deathType);
      }
      else
        break;
    }
    if (entity.statusEffects != null)
    {
      c = entity.statusEffects.Count;
      for (i = c - 1; i >= 0; --i)
      {
        int count = StatusEffectSystem.activeEffects.Count;
        if (count < c)
        {
          i -= c - count;
          c = count;
        }
        if (i >= 0)
        {
          StatusEffectData statusEffect = entity.statusEffects[i];
          if ((UnityEngine.Object) statusEffect.target != (UnityEngine.Object) null && statusEffect.RunDisableEvent(entity) && statusEffect.HasDisableRoutine)
            yield return (object) statusEffect.DisableRoutine(entity);
        }
        else
          break;
      }
    }
    StatusEffectSystem.activeEffects.Thaw();
    --StatusEffectSystem.eventRoutineCount;
    yield return (object) Sequences.Null();
  }

  public static IEnumerator CardMoveEvent(Entity entity)
  {
    ++StatusEffectSystem.eventRoutineCount;
    StatusEffectSystem.activeEffects.Freeze();
    int c = StatusEffectSystem.activeEffects.Count;
    for (int i = c - 1; i >= 0; --i)
    {
      int count = StatusEffectSystem.activeEffects.Count;
      if (count < c)
      {
        i -= c - count;
        c = count;
      }
      if (i >= 0)
      {
        StatusEffectData activeEffect = StatusEffectSystem.activeEffects[i];
        if ((UnityEngine.Object) activeEffect.target != (UnityEngine.Object) null && activeEffect.RunCardMoveEvent(entity) && activeEffect.HasCardMoveRoutine)
          yield return (object) activeEffect.CardMoveRoutine(entity);
      }
      else
        break;
    }
    StatusEffectSystem.activeEffects.Thaw();
    --StatusEffectSystem.eventRoutineCount;
    yield return (object) Sequences.Null();
  }

  public static IEnumerator PreTriggerEvent(Trigger trigger)
  {
    ++StatusEffectSystem.eventRoutineCount;
    StatusEffectSystem.activeEffects.Freeze();
    int c = StatusEffectSystem.activeEffects.Count;
    for (int i = c - 1; i >= 0; --i)
    {
      int count = StatusEffectSystem.activeEffects.Count;
      if (count < c)
      {
        i -= c - count;
        c = count;
      }
      if (i >= 0)
      {
        StatusEffectData activeEffect = StatusEffectSystem.activeEffects[i];
        if ((UnityEngine.Object) activeEffect.target != (UnityEngine.Object) null && activeEffect.RunPreTriggerEvent(trigger) && activeEffect.HasPreTriggerRoutine)
          yield return (object) activeEffect.PreTriggerRoutine(trigger);
      }
      else
        break;
    }
    StatusEffectSystem.activeEffects.Thaw();
    --StatusEffectSystem.eventRoutineCount;
    yield return (object) Sequences.Null();
  }

  public static IEnumerator PreCardPlayedEvent(Entity entity, Entity[] targets)
  {
    ++StatusEffectSystem.eventRoutineCount;
    StatusEffectSystem.activeEffects.Freeze();
    int c = StatusEffectSystem.activeEffects.Count;
    for (int i = c - 1; i >= 0; --i)
    {
      int count = StatusEffectSystem.activeEffects.Count;
      if (count < c)
      {
        i -= c - count;
        c = count;
      }
      if (i >= 0)
      {
        StatusEffectData activeEffect = StatusEffectSystem.activeEffects[i];
        if ((UnityEngine.Object) activeEffect.target != (UnityEngine.Object) null && activeEffect.RunPreCardPlayedEvent(entity, targets) && activeEffect.HasPreCardPlayedRoutine)
          yield return (object) activeEffect.PreCardPlayedRoutine(entity, targets);
      }
      else
        break;
    }
    StatusEffectSystem.activeEffects.Thaw();
    --StatusEffectSystem.eventRoutineCount;
    yield return (object) Sequences.Null();
  }

  public static IEnumerator CardPlayedEvent(Entity entity, Entity[] targets)
  {
    ++StatusEffectSystem.eventRoutineCount;
    StatusEffectSystem.activeEffects.Freeze();
    int c = StatusEffectSystem.activeEffects.Count;
    for (int i = c - 1; i >= 0; --i)
    {
      int count = StatusEffectSystem.activeEffects.Count;
      if (count < c)
      {
        i -= c - count;
        c = count;
      }
      if (i >= 0)
      {
        StatusEffectData activeEffect = StatusEffectSystem.activeEffects[i];
        if ((UnityEngine.Object) activeEffect.target != (UnityEngine.Object) null && activeEffect.RunCardPlayedEvent(entity, targets) && activeEffect.HasCardPlayedRoutine)
          yield return (object) activeEffect.CardPlayedRoutine(entity, targets);
      }
      else
        break;
    }
    StatusEffectSystem.activeEffects.Thaw();
    --StatusEffectSystem.eventRoutineCount;
    yield return (object) Sequences.Null();
  }

  public static IEnumerator EffectBonusChangedEvent(Entity entity)
  {
    ++StatusEffectSystem.eventRoutineCount;
    if (entity.statusEffects != null)
    {
      StatusEffectSystem.activeEffects.Freeze();
      int c = entity.statusEffects.Count;
      for (int i = c - 1; i >= 0; --i)
      {
        int count = StatusEffectSystem.activeEffects.Count;
        if (count < c)
        {
          i -= c - count;
          c = count;
        }
        if (i >= 0)
        {
          StatusEffectData statusEffect = entity.statusEffects[i];
          if ((UnityEngine.Object) statusEffect.target != (UnityEngine.Object) null && statusEffect.RunEffectBonusChangedEvent() && statusEffect.HasEffectBonusChangedRoutine)
            yield return (object) statusEffect.EffectBonusChangedRoutine();
        }
        else
          break;
      }
      StatusEffectSystem.activeEffects.Thaw();
    }
    --StatusEffectSystem.eventRoutineCount;
    yield return (object) Sequences.Null();
  }

  public static IEnumerator ActionPerformedEvent(PlayAction action)
  {
    ++StatusEffectSystem.eventRoutineCount;
    StatusEffectSystem.activeEffects.Freeze();
    int c = StatusEffectSystem.activeEffects.Count;
    for (int i = c - 1; i >= 0; --i)
    {
      int count = StatusEffectSystem.activeEffects.Count;
      if (count < c)
      {
        i -= c - count;
        c = count;
      }
      if (i >= 0)
      {
        StatusEffectData activeEffect = StatusEffectSystem.activeEffects[i];
        if ((UnityEngine.Object) activeEffect.target != (UnityEngine.Object) null && activeEffect.RunActionPerformedEvent(action) && activeEffect.HasActionPerformedRoutine)
          yield return (object) activeEffect.ActionPerformedRoutine(action);
      }
      else
        break;
    }
    StatusEffectSystem.activeEffects.Thaw();
    --StatusEffectSystem.eventRoutineCount;
    yield return (object) Sequences.Null();
  }

  public static IEnumerator BuildEvent(Entity entity)
  {
    ++StatusEffectSystem.eventRoutineCount;
    StatusEffectSystem.activeEffects.Freeze();
    int c = StatusEffectSystem.activeEffects.Count;
    for (int i = c - 1; i >= 0; --i)
    {
      int count = StatusEffectSystem.activeEffects.Count;
      if (count < c)
      {
        i -= c - count;
        c = count;
      }
      if (i >= 0)
      {
        StatusEffectData activeEffect = StatusEffectSystem.activeEffects[i];
        if ((UnityEngine.Object) activeEffect.target != (UnityEngine.Object) null && activeEffect.RunBuildEvent(entity) && activeEffect.HasBuildRoutine)
          yield return (object) activeEffect.BuildRoutine(entity);
      }
      else
        break;
    }
    StatusEffectSystem.activeEffects.Thaw();
    --StatusEffectSystem.eventRoutineCount;
    yield return (object) Sequences.Null();
  }

  public class StatusEffectComparer : IComparer<StatusEffectData>
  {
    public int Compare(StatusEffectData x, StatusEffectData y)
    {
      return ((UnityEngine.Object) x != (UnityEngine.Object) null ? x.eventPriority : 0) >= ((UnityEngine.Object) y != (UnityEngine.Object) null ? y.eventPriority : 0) ? 1 : -1;
    }
  }
}
