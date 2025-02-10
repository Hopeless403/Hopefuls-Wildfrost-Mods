// Decompiled with JetBrains decompiler
// Type: Pokefrost.EarlyBellDrawModifierSystem
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  public class EarlyBellDrawModifierSystem : GameSystem
  {
    public void OnEnable()
    {
      global::Events.OnRedrawBellHit += new UnityAction<RedrawBellSystem>(this.Draw);
    }

    public void OnDisable()
    {
      global::Events.OnRedrawBellHit -= new UnityAction<RedrawBellSystem>(this.Draw);
    }

    private void Draw(RedrawBellSystem arg0)
    {
      if (arg0.counter.current == 0)
        return;
      ActionQueue.Add((PlayAction) new ActionRedraw(arg0.owner, 3));
    }
  }
}
