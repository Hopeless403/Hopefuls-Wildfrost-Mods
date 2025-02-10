// Decompiled with JetBrains decompiler
// Type: Pokefrost.BounceJuiceModifierSystem
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  public class BounceJuiceModifierSystem : GameSystem
  {
    public void OnEnable()
    {
      StatusEffectSpicune.OnJuiceCleared += new UnityAction<Entity, int>(this.BounceJuice);
    }

    public void OnDisable()
    {
      StatusEffectSpicune.OnJuiceCleared -= new UnityAction<Entity, int>(this.BounceJuice);
    }

    private void BounceJuice(Entity entity, int amount)
    {
      if ((Object) Battle.instance == (Object) null)
        return;
      List<Entity> cards = Battle.GetCards(References.Player);
      TargetConstraintCanBeBoosted instance = ScriptableObject.CreateInstance<TargetConstraintCanBeBoosted>();
      foreach (Entity target in (IEnumerable<Entity>) cards.InRandomOrder<Entity>())
      {
        if (instance.Check(target) && (Object) target != (Object) entity)
        {
          ActionQueue.Stack((PlayAction) new ActionApplyStatus(target, (Entity) null, Pokefrost.Pokefrost.instance.Get<StatusEffectData>("Spicune"), 1));
          break;
        }
      }
    }
  }
}
