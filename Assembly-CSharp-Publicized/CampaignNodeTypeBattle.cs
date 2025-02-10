// Decompiled with JetBrains decompiler
// Type: CampaignNodeTypeBattle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using FMODUnity;
using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

[CreateAssetMenu(fileName = "CampaignNodeTypeBattle", menuName = "Campaign/Node Type/Battle")]
public class CampaignNodeTypeBattle : CampaignNodeType
{
  public EventReference overrideMusic;
  public bool overrideBackground;
  [ShowIf("overrideBackground")]
  public AssetReferenceGameObject background;

  public override IEnumerator Run(CampaignNode node)
  {
    yield return (object) Transition.To("Battle");
    BattleSetUp battleSetUp = Object.FindObjectOfType<BattleSetUp>();
    if ((bool) (Object) battleSetUp)
      yield return (object) battleSetUp.Run();
    BattleSaveSystem objectOfType = Object.FindObjectOfType<BattleSaveSystem>();
    if (objectOfType != null && objectOfType.TryLoadBattleState(node))
    {
      yield return (object) objectOfType.LoadRoutine();
    }
    else
    {
      object obj;
      if (node.data.TryGetValue("battle", out obj) && obj is string assetName)
      {
        BattleData battleData = AddressableLoader.Get<BattleData>("BattleData", assetName);
        if (battleData != null && (bool) (Object) battleData.setUpScript)
          yield return (object) battleData.setUpScript.Run();
      }
    }
    Transition.End();
    if ((bool) (Object) battleSetUp)
      yield return (object) battleSetUp.StartAnimation();
    yield return (object) References.Battle.Run();
    if (Campaign.CheckVictory())
    {
      yield return (object) Transition.WaitUntilDone(Transition.Begin());
      yield return (object) CampaignNodeTypeBattle.BattleEnd(node);
      Routine routine = new Routine(Sequences.EndCampaign("MainMenu"));
    }
    else
    {
      yield return (object) Transition.WaitUntilDone(Transition.Begin());
      yield return (object) CampaignNodeTypeBattle.BattleEnd(node);
      yield return (object) Sequences.SceneChange("MapNew");
      Transition.End();
      Events.InvokePostBattle(node);
      yield return (object) ActionQueue.Wait();
      yield return (object) CampaignNodeTypeBattle.CheckRecovery();
      yield return (object) MapNew.CheckCompanionLimit();
    }
  }

  public static IEnumerator BattleEnd(CampaignNode node)
  {
    Character player = Battle.instance.player;
    if ((bool) (Object) player.handContainer)
      player.handContainer.Clear();
    if ((bool) (Object) player.reserveContainer)
      player.reserveContainer.Clear();
    if ((bool) (Object) player.drawContainer)
      player.drawContainer.Clear();
    if ((bool) (Object) player.discardContainer)
      player.discardContainer.Clear();
    List<Entity> cards = References.Battle.cards;
    Debug.Log((object) string.Format("BattleEnd → Destroying [{0}] Cards!", (object) cards.Count));
    for (int index = cards.Count - 1; index >= 0; --index)
      CardManager.ReturnToPool(cards[index]);
    yield return (object) StatusEffectSystem.Clear();
    if (player.entity.alive && player.data.inventory.reserve != null)
    {
      node.SetCleared();
      if (player.entity.display is CharacterDisplay display)
        yield return (object) display.handOverlay.Hide();
    }
  }

  public static IEnumerator CheckRecovery()
  {
    if (References.Player.entity.display is CharacterDisplay display)
      yield return (object) display.deckDisplay.companionRecoverSequence.Run();
  }

  public override bool HasMissingData(CampaignNode node)
  {
    object obj;
    if (node.data.TryGetValue("battle", out obj) && obj is string assetName)
    {
      BattleData battleData = AddressableLoader.Get<BattleData>("BattleData", assetName);
      if (battleData != null && (bool) (Object) battleData.setUpScript)
      {
        BattleWaveManager.WaveData[] saveCollection = node.data.GetSaveCollection<BattleWaveManager.WaveData>("waves");
        if (saveCollection == null)
          return true;
        foreach (BattleWaveManager.WaveData waveData in saveCollection)
        {
          for (int index = 0; index < waveData.Count; ++index)
          {
            if ((Object) waveData.PeekCardData(index) == (Object) null)
              return true;
          }
        }
        return false;
      }
    }
    return true;
  }
}
