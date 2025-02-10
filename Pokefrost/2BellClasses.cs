// Decompiled with JetBrains decompiler
// Type: Pokefrost.GiveZoomlinModifierSystem
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  public class GiveZoomlinModifierSystem : GameSystem
  {
    private TargetConstraint[] targetConstraints = Pokefrost.Pokefrost.instance.Get<StatusEffectData>("Temporary Zoomlin").targetConstraints;

    public void OnEnable()
    {
      global::Events.OnRedrawBellHit += new UnityAction<RedrawBellSystem>(this.Zoomin);
    }

    public void OnDisable()
    {
      global::Events.OnRedrawBellHit -= new UnityAction<RedrawBellSystem>(this.Zoomin);
    }

    private void Zoomin(RedrawBellSystem arg0) => this.StartCoroutine(this.DumbWait());

    public IEnumerator DumbWait()
    {
      yield return (object) new WaitUntil((Func<bool>) (() => ActionQueue.Empty));
      ActionQueue.Add((PlayAction) new ActionSequence(this.GiveZoomlin()));
    }

    public IEnumerator GiveZoomlin()
    {
      List<Entity> list = References.Player.handContainer.Where<Entity>((Func<Entity, bool>) (e =>
      {
        foreach (TargetConstraint targetConstraint in this.targetConstraints)
        {
          if (!targetConstraint.Check(e))
            return false;
        }
        return true;
      })).ToList<Entity>();
      if (list.Count != 0)
      {
        Entity rando = list.RandomItem<Entity>();
        yield return (object) StatusEffectSystem.Apply(rando, (Entity) null, Pokefrost.Pokefrost.instance.Get<StatusEffectData>("Temporary Zoomlin"), 1);
      }
    }
  }
}
