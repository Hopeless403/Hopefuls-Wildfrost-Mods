// Decompiled with JetBrains decompiler
// Type: FrostoscopeSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using FMODUnity;
using NaughtyAttributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class FrostoscopeSequence : MonoBehaviour
{
  [SerializeField]
  public EventReference enterSfxEvent;
  [SerializeField]
  public CardController cardController;
  [SerializeField]
  public CardContainer[] cardHolders;
  [SerializeField]
  public CardContainer leaderCardHolder;
  [SerializeField]
  public Transform scene;
  [SerializeField]
  public BattleGenerationScriptFinalBoss generationScript;
  [SerializeField]
  public Vector2 cameraLimits;
  [SerializeField]
  public GameObject nothingHere;
  [SerializeField]
  public GameObject group;
  [SerializeField]
  public bool enableGroupAfterGeneration;
  [SerializeField]
  [ShowIf("enableGroupAfterGeneration")]
  public float delayBeforeEnableGroup = 0.25f;
  [SerializeField]
  public bool unloadSceneOnEnd;
  public Entity hover;
  public bool hovering;
  public bool generated;

  public void OnEnable()
  {
    global::Events.OnEntityHover += new UnityAction<Entity>(this.EntityHover);
    global::Events.OnEntityUnHover += new UnityAction<Entity>(this.EntityUnHover);
    this.cardController.Enable();
    this.StartCoroutine(this.Run());
    MusicSystem.FadePitchTo(0.25f, 0.2f);
  }

  public void OnDisable()
  {
    global::Events.OnEntityHover -= new UnityAction<Entity>(this.EntityHover);
    global::Events.OnEntityUnHover -= new UnityAction<Entity>(this.EntityUnHover);
    this.hover = (Entity) null;
    this.hovering = false;
    this.cardController.Disable();
    this.StopAllCoroutines();
    this.generated = false;
    MusicSystem.FadePitchTo(1f, 0.2f);
  }

  public void EntityHover(Entity entity)
  {
    this.hover = entity;
    this.hovering = true;
  }

  public void EntityUnHover(Entity entity)
  {
    this.hover = (Entity) null;
    this.hovering = false;
  }

  public void Update()
  {
    Vector3 localPosition = this.scene.localPosition;
    Vector3 target = -(this.hovering ? Vector3.Lerp(this.hover.transform.position.WithZ(0.0f), Cursor3d.Position, 0.5f) : Cursor3d.Position);
    target.x = Mathf.Clamp(target.x, -this.cameraLimits.x, this.cameraLimits.x);
    target.y = Mathf.Clamp(target.y, -this.cameraLimits.y, this.cameraLimits.y);
    this.scene.localPosition = Delta.Lerp(localPosition, target, 0.025f, Time.deltaTime);
  }

  public IEnumerator Run()
  {
    if (this.enableGroupAfterGeneration)
    {
      Routine.Clump clump = new Routine.Clump();
      clump.Add(this.CreateCards(false));
      clump.Add(Sequences.Wait(this.delayBeforeEnableGroup));
      yield return (object) clump.WaitForEnd();
      this.group.SetActive(true);
    }
    SfxSystem.OneShot(this.enterSfxEvent);
    if (!this.generated)
      yield return (object) this.CreateCards(true);
  }

  public IEnumerator CreateCards(bool startFlipped)
  {
    this.generated = true;
    (GameMode gameMode, int seed) = FrostoscopeSequence.GetGameModeAndSeed();
    List<CardData> cardDataList;
    if (!FrostoscopeSequence.TryGetPreGeneratedBattle(gameMode, out cardDataList))
      this.generationScript.GetBaseEnemies(this.generationScript.LoadCards(gameMode), seed, out cardDataList, out bool _, out bool _, out CardData _, out bool _, out CardData _);
    if (cardDataList == null || cardDataList.Count <= 0)
    {
      this.nothingHere.SetActive(true);
    }
    else
    {
      this.nothingHere.SetActive(false);
      Routine.Clump clump = new Routine.Clump();
      List<CardContainer> list = this.cardHolders.ToList<CardContainer>();
      foreach (CardData cardData in cardDataList)
      {
        if (cardData.cardType.miniboss)
          clump.Add(this.CreateCard(cardData, this.leaderCardHolder, startFlipped));
        else if (list.Count > 0)
        {
          clump.Add(this.CreateCard(cardData, list[0], startFlipped));
          list.RemoveAt(0);
        }
        else
          break;
      }
      yield return (object) clump.WaitForEnd();
    }
  }

  public static bool TryGetPreGeneratedBattle(GameMode gameMode, out List<CardData> cards)
  {
    cards = (List<CardData>) null;
    if (SaveSystem.LoadCampaignData<Campaign.Result>(gameMode, "result", Campaign.Result.None) != Campaign.Result.None)
      return false;
    CampaignSaveData campaignSaveData = SaveSystem.LoadCampaignData<CampaignSaveData>(gameMode, "data");
    CampaignNodeSaveData campaignNodeSaveData1;
    if (campaignSaveData == null)
    {
      campaignNodeSaveData1 = (CampaignNodeSaveData) null;
    }
    else
    {
      CampaignNodeSaveData[] nodes = campaignSaveData.nodes;
      campaignNodeSaveData1 = nodes != null ? ((IEnumerable<CampaignNodeSaveData>) nodes).FirstOrDefault<CampaignNodeSaveData>((Func<CampaignNodeSaveData, bool>) (a => a.typeName == "CampaignNodeFinalBoss")) : (CampaignNodeSaveData) null;
    }
    CampaignNodeSaveData campaignNodeSaveData2 = campaignNodeSaveData1;
    object obj;
    if (campaignNodeSaveData2 != null && campaignNodeSaveData2.data.TryGetValue("waves", out obj) && obj is SaveCollection<BattleWaveManager.WaveData> saveCollection)
    {
      BattleWaveManager.WaveData[] collection = saveCollection.collection;
      if (collection != null)
      {
        cards = new List<CardData>();
        if (!campaignNodeSaveData2.cleared)
        {
          foreach (BattleWaveManager.WaveData waveData in collection)
          {
            if (!(waveData is BattleWaveManager.WaveDataFull waveDataFull))
            {
              for (int index = 0; index < waveData.Count; ++index)
                cards.Add(waveData.GetCardData(index));
            }
            else
            {
              foreach (CardSaveData cardData in waveDataFull.cardDatas)
                cards.Add(cardData.Load());
            }
          }
        }
        return true;
      }
    }
    return false;
  }

  public static (GameMode, int) GetGameModeAndSeed()
  {
    GameMode gameMode;
    int num;
    if ((bool) (UnityEngine.Object) References.Campaign && Campaign.Data != null)
    {
      gameMode = Campaign.Data.GameMode;
      num = Campaign.Data.Seed;
    }
    else
    {
      gameMode = AddressableLoader.Get<GameMode>("GameMode", "GameModeNormal");
      num = SaveSystem.LoadProgressData<int>("nextSeed", -1);
      if (num == -1)
      {
        num = Dead.Random.Seed();
        SaveSystem.SaveProgressData<int>("nextSeed", num);
      }
    }
    return (gameMode, num);
  }

  public IEnumerator CreateCard(CardData cardData, CardContainer cardHolder, bool startFlipped)
  {
    Card card = CardManager.Get(cardData, this.cardController, (Character) null, false, false);
    Transform transform = card.transform;
    if (startFlipped)
      card.entity.flipper.FlipDownInstant();
    cardHolder.Add(card.entity);
    cardHolder.SetChildPositions();
    yield return (object) card.UpdateData(false);
    if (startFlipped)
      card.entity.flipper.FlipUp(true);
  }

  public void End()
  {
    foreach (CardContainer cardHolder in this.cardHolders)
    {
      cardHolder.DestroyAll();
      cardHolder.Clear();
    }
    this.leaderCardHolder.DestroyAll();
    this.leaderCardHolder.Clear();
    this.gameObject.SetActive(false);
    if (!this.unloadSceneOnEnd)
      return;
    Routine routine = new Routine(SceneManager.Unload("NewFrostGuardian"));
  }
}
