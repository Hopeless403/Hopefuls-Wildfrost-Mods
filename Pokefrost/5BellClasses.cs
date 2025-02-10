// Decompiled with JetBrains decompiler
// Type: Pokefrost.DestoryCardSystem
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  public class DestoryCardSystem : GameSystem
  {
    private Entity target;

    public void OnEnable()
    {
      global::Events.OnRedrawBellHit += new UnityAction<RedrawBellSystem>(this.DestoryCard);
    }

    public void OnDisable()
    {
      global::Events.OnRedrawBellHit -= new UnityAction<RedrawBellSystem>(this.DestoryCard);
    }

    private void DestoryCard(RedrawBellSystem arg0)
    {
      CardContainer handContainer = References.Player.handContainer;
      if (handContainer == null || handContainer.Count <= 0)
        return;
      this.target = References.Player.handContainer[0];
      if ((Object) this.target != (Object) null)
        ActionQueue.Add((PlayAction) new ActionKill(this.target));
    }
  }
}
