// Decompiled with JetBrains decompiler
// Type: Pokefrost.GiveDreamCardModifierSystem
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
  public class GiveDreamCardModifierSystem : GameSystem
  {
    public void OnEnable()
    {
      global::Events.OnRedrawBellHit += new UnityAction<RedrawBellSystem>(this.Dream);
    }

    public void OnDisable()
    {
      global::Events.OnRedrawBellHit -= new UnityAction<RedrawBellSystem>(this.Dream);
    }

    private void Dream(RedrawBellSystem arg0) => this.StartCoroutine(this.DumbWait());

    public IEnumerator DumbWait()
    {
      yield return (object) new WaitUntil((Func<bool>) (() => ActionQueue.Empty));
      ActionQueue.Add((PlayAction) new ActionSequence(this.GainDream()));
    }

    public IEnumerator GainDream()
    {
      List<Entity> list = References.Player.handContainer.ToList<Entity>();
      if (list.Count != 0)
      {
        Entity rando = list.RandomItem<Entity>();
        Debug.Log((object) ("[Pokefrost] " + rando.name));
        yield return (object) StatusEffectSystem.Apply(rando, rando, Pokefrost.Pokefrost.instance.Get<StatusEffectData>("Instant Summon Dream Base In Hand"), 2);
      }
    }
  }
}
