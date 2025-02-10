// Decompiled with JetBrains decompiler
// Type: Pokefrost.CountdownRedrawWhenLeaderIsHitModifierSystem
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  public class CountdownRedrawWhenLeaderIsHitModifierSystem : GameSystem
  {
    public void OnEnable() => global::Events.OnEntityPostHit += new UnityAction<Hit>(this.Countdown);

    public void OnDisable() => global::Events.OnEntityPostHit -= new UnityAction<Hit>(this.Countdown);

    private void Countdown(Hit hit)
    {
      if (hit == null || !hit.Offensive || !((UnityEngine.Object) hit.target != (UnityEngine.Object) null) || !(hit.target.data.cardType.name == "Leader") || !((UnityEngine.Object) hit.target.owner == (UnityEngine.Object) References.Player))
        return;
      RedrawBellSystem objectOfType = UnityEngine.Object.FindObjectOfType<RedrawBellSystem>();
      if ((UnityEngine.Object) objectOfType != (UnityEngine.Object) null)
        objectOfType.SetCounter(Math.Max(0, objectOfType.counter.current - 1));
    }
  }
}
