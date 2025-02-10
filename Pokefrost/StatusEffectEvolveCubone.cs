// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectEvolveCubone
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using System;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectEvolveCubone : StatusEffectEvolveFromKill
  {
    public string normalEvolution;
    public string sacEvolution;

    public override void Init() => base.Init();

    public void SetEvolutions(string normal, string sac)
    {
      this.evolutionCardName = normal;
      this.normalEvolution = normal;
      this.sacEvolution = sac;
    }

    public override bool RunBeginEvent()
    {
      this.anyKill = true;
      this.constraint = (Func<Entity, DeathType, bool>) ((entity, death) => (UnityEngine.Object) entity == (UnityEngine.Object) this.target);
      return false;
    }

    public override bool RunEntityDestroyedEvent(Entity entity, DeathType deathType)
    {
      if (this.count > 0)
      {
        base.RunEntityDestroyedEvent(entity, deathType);
        if (this.count == 0 && ((UnityEngine.Object) entity?.lastHit?.attacker?.owner == (UnityEngine.Object) this.target.owner || deathType == DeathType.Sacrifice))
          this.FindDeckCopy((Action<CardData, CardData.StatusEffectStacks>) ((card, status) => status.count = 2));
      }
      return false;
    }

    public override bool ReadyToEvolve(CardData cardData)
    {
      foreach (CardData.StatusEffectStacks startWithEffect in cardData.startWithEffects)
      {
        if (startWithEffect.data.name == this.name && (startWithEffect.count == 0 || startWithEffect.count == 2))
          return true;
      }
      return false;
    }

    public override void Evolve(WildfrostMod mod, CardData preEvo)
    {
      foreach (CardData.StatusEffectStacks startWithEffect in preEvo.startWithEffects)
      {
        if (startWithEffect.data.name == this.name && startWithEffect.count == 2)
        {
          this.evolutionCardName = this.sacEvolution;
          base.Evolve(mod, preEvo);
          return;
        }
      }
      this.evolutionCardName = this.normalEvolution;
      base.Evolve(mod, preEvo);
    }
  }
}
