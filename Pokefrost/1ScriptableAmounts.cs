// Decompiled with JetBrains decompiler
// Type: Pokefrost.ScriptableCursesInHand
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;

#nullable disable
namespace Pokefrost
{
  internal class ScriptableCursesInHand : ScriptableAmount
  {
    public override int Get(Entity entity)
    {
      if (!(bool) (UnityEngine.Object) entity)
        return 0;
      int num = 0;
      foreach (Entity entity1 in References.Player.handContainer)
      {
        foreach (StatusEffectData statusEffect in entity1.statusEffects)
        {
          if (statusEffect.type == "paracurse" || statusEffect.type == "weakcurse" || statusEffect.type == "powercurse" || statusEffect.type == "frenzycurse")
          {
            num += (1 + entity.effectBonus) * (int) Math.Round((double) entity.effectFactor);
            break;
          }
        }
      }
      return num;
    }
  }
}
