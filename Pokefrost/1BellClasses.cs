// Decompiled with JetBrains decompiler
// Type: Pokefrost.AlwaysIgniteModifierSystem
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  public class AlwaysIgniteModifierSystem : GameSystem
  {
    private StatusEffectData status = Pokefrost.Pokefrost.instance.Get<StatusEffectData>("Burning");
    private int count = 3;

    public void OnEnable() => global::Events.OnBattlePreTurnStart += new UnityAction<int>(this.ApplyIgnite);

    public void OnDisable()
    {
      global::Events.OnBattlePreTurnStart -= new UnityAction<int>(this.ApplyIgnite);
    }

    private void ApplyIgnite(int turn)
    {
      if ((UnityEngine.Object) Battle.instance == (UnityEngine.Object) null)
        return;
      HashSet<Entity> allUnits = Battle.GetAllUnits(Battle.instance.enemy);
      if (allUnits.Count == 0)
        return;
      foreach (Entity entity in allUnits)
      {
        if ((UnityEngine.Object) entity.statusEffects.FirstOrDefault<StatusEffectData>((Func<StatusEffectData, bool>) (s => s.type == "burning")) != (UnityEngine.Object) null)
          return;
      }
      ActionQueue.Stack((PlayAction) new ActionApplyStatus(allUnits.RandomItems<Entity>(1)[0], (Entity) null, this.status, this.count));
    }
  }
}
