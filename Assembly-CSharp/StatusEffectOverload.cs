// Decompiled with JetBrains decompiler
// Type: StatusEffectOverload
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Status Effects/Overload", fileName = "Overload")]
public class StatusEffectOverload : StatusEffectData
{
  [SerializeField]
  private CardAnimation buildupAnimation;
  private bool overloading;

  protected override void Init()
  {
    this.OnStack += new StatusEffectData.EffectStackEventHandler(this.Stack);
    global::Events.OnEntityDisplayUpdated += new UnityAction<Entity>(this.EntityDisplayUpdated);
  }

  private void OnDestroy() => global::Events.OnEntityDisplayUpdated -= new UnityAction<Entity>(this.EntityDisplayUpdated);

  private void EntityDisplayUpdated(Entity entity)
  {
    if (!((Object) entity == (Object) this.target) || !this.target.enabled)
      return;
    this.Check();
  }

  private IEnumerator Stack(int stacks)
  {
    this.Check();
    yield return (object) null;
  }

  private void Check()
  {
    if (this.count < this.target.hp.current || this.overloading)
      return;
    ActionSequence action1 = new ActionSequence(this.DealDamage(this.count));
    action1.fixedPosition = true;
    action1.priority = this.eventPriority;
    action1.note = "Overload";
    ActionQueue.Stack((PlayAction) action1);
    ActionSequence action2 = new ActionSequence(this.Clear());
    action2.fixedPosition = true;
    action2.priority = this.eventPriority;
    action2.note = "Clear Overload";
    ActionQueue.Stack((PlayAction) action2);
    this.overloading = true;
  }

  private IEnumerator DealDamage(int damage)
  {
    StatusEffectOverload statusEffectOverload = this;
    if ((bool) (Object) statusEffectOverload && (bool) (Object) statusEffectOverload.target && statusEffectOverload.target.alive)
    {
      HashSet<Entity> targets = new HashSet<Entity>();
      foreach (IEnumerable<Entity> container in statusEffectOverload.target.containers)
        targets.AddRange<Entity>(container);
      if ((bool) (Object) statusEffectOverload.buildupAnimation)
        yield return (object) statusEffectOverload.buildupAnimation.Routine((object) statusEffectOverload.target);
      Entity damager = statusEffectOverload.GetDamager();
      Routine.Clump clump = new Routine.Clump();
      foreach (Entity target in targets)
      {
        Hit hit = new Hit(damager, target, damage)
        {
          damageType = "overload"
        };
        clump.Add(hit.Process());
      }
      clump.Add(Sequences.Wait(0.5f));
      yield return (object) clump.WaitForEnd();
    }
  }

  private IEnumerator Clear()
  {
    StatusEffectOverload statusEffectOverload = this;
    if ((bool) (Object) statusEffectOverload && (bool) (Object) statusEffectOverload.target && statusEffectOverload.target.alive)
    {
      yield return (object) statusEffectOverload.Remove();
      statusEffectOverload.overloading = false;
    }
  }
}
