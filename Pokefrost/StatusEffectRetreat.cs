// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectRetreat
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Localization;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectRetreat : StatusEffectInstant
  {
    public static readonly string Key_TooBig = "websiteofsites.wildfrost.pokefrost.toobig";

    [PokeLocalizer]
    public static void DefineStrings()
    {
      LocalizationHelper.GetCollection("Tooltips", (LocaleIdentifier) SystemLanguage.English).SetString(StatusEffectRetreat.Key_TooBig, "Target Too Big!");
    }

    public virtual void PopupText(Entity entity, string s)
    {
      NoTargetTextSystem objectOfType = Object.FindObjectOfType<NoTargetTextSystem>();
      if (!((Object) objectOfType != (Object) null))
        return;
      objectOfType.textElement.text = LocalizationHelper.GetCollection("Tooltips", (LocaleIdentifier) SystemLanguage.English).GetString(s).GetLocalizedString();
      objectOfType.PopText(entity.transform.position);
    }

    public static CardStack FindEnemyReserveStack()
    {
      foreach (CardStack enemyReserveStack in Object.FindObjectsOfType<CardStack>(true))
      {
        if (enemyReserveStack.name == "Enemy Reserve Stack")
          return enemyReserveStack;
      }
      return (CardStack) null;
    }

    public static WaveDeploySystem FindWaveSystem()
    {
      foreach (WaveDeploySystem waveSystem in Object.FindObjectsOfType<WaveDeploySystem>(true))
      {
        if (waveSystem.name == "WaveDeployer")
          return waveSystem;
      }
      return (WaveDeploySystem) null;
    }

    public static WaveDeploySystemOverflow FindWaveSystemOverflow()
    {
      foreach (WaveDeploySystemOverflow waveSystemOverflow in Object.FindObjectsOfType<WaveDeploySystemOverflow>(true))
      {
        if (waveSystemOverflow.name == "WaveDeployerOverflow")
          return waveSystemOverflow;
      }
      return (WaveDeploySystemOverflow) null;
    }

    public static void FailSafe(int _)
    {
      List<Entity> cardsOnBoard = Battle.GetCardsOnBoard(Battle.GetOpponent(References.Player));
      if (cardsOnBoard == null || cardsOnBoard.Count > 0)
        return;
      CardStack enemyReserveStack = StatusEffectRetreat.FindEnemyReserveStack();
      if ((Object) enemyReserveStack == (Object) null)
        return;
      if (enemyReserveStack.Count > 0)
      {
        WaveDeploySystemOverflow waveSystemOverflow = StatusEffectRetreat.FindWaveSystemOverflow();
        if ((Object) waveSystemOverflow == (Object) null || waveSystemOverflow.currentWave < waveSystemOverflow.waves.Count)
          return;
        StatusEffectRetreat.FixWaves(enemyReserveStack.entities.Clone<Entity>().ToArray());
      }
      else
      {
        Battle.instance.winner = References.Player;
        Battle.instance.phase = Battle.Phase.End;
      }
    }

    public static bool FixWaves(params Entity[] entities)
    {
      if (((IEnumerable<Entity>) entities).Count<Entity>() == 0)
        return false;
      WaveDeploySystem waveSystem = StatusEffectRetreat.FindWaveSystem();
      WaveDeploySystemOverflow waveSystemOverflow = StatusEffectRetreat.FindWaveSystemOverflow();
      if ((Object) waveSystem == (Object) null || (Object) waveSystemOverflow == (Object) null)
        return false;
      bool flag1 = false;
      bool flag2 = false;
      if (waveSystemOverflow.currentWave >= waveSystemOverflow.waves.Count)
        flag1 = true;
      if (!flag1)
      {
        BattleWaveManager.Wave wave = waveSystemOverflow.waves[waveSystemOverflow.currentWave];
        if (wave.units.Count<CardData>() > 5)
        {
          flag2 = true;
        }
        else
        {
          waveSystemOverflow.deployed.Remove(entities[0].data.id);
          wave.units.Add(entities[0].data);
        }
      }
      if (flag1 | flag2)
      {
        waveSystemOverflow.Overflow((IEnumerable<Entity>) entities);
        waveSystemOverflow.deployed.Remove(entities[0].data.id);
        if (flag1)
        {
          waveSystemOverflow.SetCounter(waveSystemOverflow.waves[waveSystemOverflow.currentWave].counter);
          waveSystemOverflow.Show();
        }
      }
      return true;
    }

    public override IEnumerator Process()
    {
      if (this.target.height > 1)
      {
        this.PopupText(this.target, StatusEffectRetreat.Key_TooBig);
      }
      else
      {
        CardStack cardStack = StatusEffectRetreat.FindEnemyReserveStack();
        if ((Object) cardStack != (Object) null)
        {
          if (StatusEffectRetreat.FixWaves(this.target))
            yield return (object) Sequences.CardMove(this.target, new CardContainer[1]
            {
              (CardContainer) cardStack
            });
        }
        cardStack = (CardStack) null;
      }
      yield return (object) base.Process();
    }
  }
}
