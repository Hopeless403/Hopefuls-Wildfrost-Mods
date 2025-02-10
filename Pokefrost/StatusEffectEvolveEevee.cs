// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectEvolveEevee
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  public class StatusEffectEvolveEevee : StatusEffectEvolve
  {
    public static Dictionary<string, string> upgradeMap = new Dictionary<string, string>();
    private string flareon = nameof (flareon);
    private string vaporeon = nameof (vaporeon);
    private string jolteon = nameof (jolteon);
    private string espeon = nameof (espeon);
    private string umbreon = nameof (umbreon);
    private string glaceon = nameof (glaceon);
    private string leafeon = nameof (leafeon);
    private string sylveon = nameof (sylveon);
    public static readonly string[] eeveelutions = new string[8]
    {
      nameof (flareon),
      nameof (vaporeon),
      nameof (jolteon),
      nameof (espeon),
      nameof (umbreon),
      nameof (glaceon),
      nameof (leafeon),
      nameof (sylveon)
    };

    public override void Autofill(string n, string descrip, WildfrostMod mod)
    {
      base.Autofill(n, descrip, mod);
      if (StatusEffectEvolveEevee.upgradeMap.ContainsKey("CardUpgradeOverload"))
        return;
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeOverload", this.flareon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeSpice", this.flareon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeBattle", this.flareon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeBombskull", this.flareon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeFlameberry", this.flareon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeInk", this.vaporeon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeFury", this.vaporeon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeBlock", this.vaporeon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeRemoveCharmLimit", this.vaporeon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeSpark", this.jolteon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeDraw", this.jolteon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeFrenzyReduceAttack", this.jolteon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeWildcard", this.jolteon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeGlass", this.jolteon);
      StatusEffectEvolveEevee.upgradeMap.Add("websiteofsites.wildfrost.pokefrost.CardUpgradeMagnemite", this.jolteon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeBalanced", this.espeon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeBom", this.espeon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeBoost", this.espeon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeSun", this.espeon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeBootleg", this.espeon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeGreed", this.umbreon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeTeethWhenHit", this.umbreon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeSpiky", this.umbreon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeDemonize", this.umbreon);
      StatusEffectEvolveEevee.upgradeMap.Add("websiteofsites.wildfrost.pokefrost.CardUpgradePluck", this.umbreon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeSnowball", this.glaceon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeFrosthand", this.glaceon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeSnowImmune", this.glaceon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeAttackIncreaseCounter", this.glaceon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeBlue", this.glaceon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeAcorn", this.leafeon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeShellOnKill", this.leafeon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeShroom", this.leafeon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeShroomReduceHealth", this.leafeon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradePlink", this.leafeon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeAttackAndHealth", this.sylveon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeHeart", this.sylveon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeCloudberry", this.sylveon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradePig", this.sylveon);
      StatusEffectEvolveEevee.upgradeMap.Add("CardUpgradeHeartmist", this.sylveon);
      StatusEffectEvolveEevee.upgradeMap.Add("absentabigail.wildfrost.blahaj.CardUpgradeShark", this.vaporeon);
      StatusEffectEvolveEevee.upgradeMap.Add("bethanw10.wildfrost.allcharms.CardUpgradeMakoko", this.flareon);
      StatusEffectEvolveEevee.upgradeMap.Add("bethanw10.wildfrost.allcharms.CardUpgradeScales", this.espeon);
      StatusEffectEvolveEevee.upgradeMap.Add("bethanw10.wildfrost.allcharms.CardUpgradeShadeHeart", this.umbreon);
      StatusEffectEvolveEevee.upgradeMap.Add("greenranger.wildfrost.devilcharm.CardUpgradeDevil", this.flareon);
      StatusEffectEvolveEevee.upgradeMap.Add("greenranger.wildfrost.basketcharm.CardUpgradeCleanse", this.sylveon);
      StatusEffectEvolveEevee.upgradeMap.Add("kopie.wildfrost.charmscollection.charm_speed", this.jolteon);
      StatusEffectEvolveEevee.upgradeMap.Add("semmiesem9.wildfrost.hatsunemiku.BobaCharm", this.sylveon);
      StatusEffectEvolveEevee.upgradeMap.Add("shortcake.charms.CrystalShardCharm", this.vaporeon);
      StatusEffectEvolveEevee.upgradeMap.Add("shortcake.charms.SnowFlowerCharm", this.glaceon);
      StatusEffectEvolveEevee.upgradeMap.Add("shortcake.charms.LuminiceCharm", this.espeon);
      StatusEffectEvolveEevee.upgradeMap.Add("shortcake.charms.BarrierCharm", this.vaporeon);
      StatusEffectEvolveEevee.upgradeMap.Add("shortcake.charms.OrangeCharm", this.jolteon);
      StatusEffectEvolveEevee.upgradeMap.Add("vibeneutral.wildfrost.hollowfrost.focuscharm", this.espeon);
      StatusEffectEvolveEevee.upgradeMap.Add("vibeneutral.wildfrost.hollowfrost.grimmcharm", this.flareon);
      StatusEffectEvolveEevee.upgradeMap.Add("vibeneutral.wildfrost.hollowfrost.defendercharm", this.umbreon);
      this.type = "evolve2";
    }

    public override bool ReadyToEvolve(CardData cardData)
    {
      foreach (CardUpgradeData upgrade in cardData.upgrades)
      {
        if (upgrade.type == CardUpgradeData.Type.Charm)
          return true;
      }
      return false;
    }

    private void FindEvolution(CardData carddata)
    {
      foreach (CardUpgradeData upgrade in carddata.upgrades)
      {
        if (upgrade.type == CardUpgradeData.Type.Charm)
        {
          if (StatusEffectEvolveEevee.upgradeMap.ContainsKey(upgrade.name))
          {
            this.evolutionCardName = StatusEffectEvolveEevee.upgradeMap[upgrade.name];
          }
          else
          {
            Debug.Log((object) "[Pokefrost] Unrecognized/neutral charm: randomizing evolution.");
            int index = UnityEngine.Random.Range(0, 7);
            this.evolutionCardName = StatusEffectEvolveEevee.eeveelutions[index];
          }
          Debug.Log((object) ("[Pokefrost] Evolving into " + this.evolutionCardName));
        }
      }
    }

    public override CardData[] EvolveForFinalBoss(WildfrostMod mod)
    {
      return ((IEnumerable<string>) StatusEffectEvolveEevee.eeveelutions).Select<string, CardData>((Func<string, CardData>) (s => mod.Get<CardData>(s))).ToArray<CardData>();
    }

    public override void Evolve(WildfrostMod mod, CardData preEvo)
    {
      this.FindEvolution(preEvo);
      this.evolutionCardName = Extensions.PrefixGUID(this.evolutionCardName, mod);
      Debug.Log((object) ("[Pokefrost] " + this.evolutionCardName));
      base.Evolve(mod, preEvo);
    }

    public enum eeveeEnum
    {
      Flareon,
      Vaporeon,
      Jolteon,
      Espeon,
      Umbreon,
      Glaceon,
      Leafeon,
      Sylveon,
    }
  }
}
