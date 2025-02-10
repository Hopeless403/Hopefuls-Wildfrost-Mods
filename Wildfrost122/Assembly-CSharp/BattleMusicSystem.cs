// Decompiled with JetBrains decompiler
// Type: BattleMusicSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using FMOD;
using FMOD.Studio;
using FMODUnity;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

#nullable disable
public class BattleMusicSystem : GameSystem, ISaveable<BattleMusicSaveData>
{
  public int startingIntensity;
  public int normalIntensity = 1;
  [Header("Win/Lose Jingles")]
  [SerializeField]
  private EventReference winJingle;
  [SerializeField]
  private EventReference loseJingle;
  [Header("Miniboss Intros")]
  [SerializeField]
  private EventReference minibossIntroDefault;
  [SerializeField]
  private BattleMusicSystem.MinibossIntroRef[] minibossIntros;
  [SerializeField]
  private float minibossIntroDuration = 2f;
  private readonly Dictionary<string, EventReference> minibossIntroLookup = new Dictionary<string, EventReference>();
  private Scene currentScene;
  private EventInstance current;
  private EventInstance minibossIntroInstance;
  private int intensity;
  private PARAMETER_ID intensityParameterId;
  private bool bossEntered;
  private float promptStartMiniboss;
  private int bossPhase = 1;
  private float volume = 1f;
  private float pitch = 1f;
  private float targetVolume = 1f;
  private float targetPitch = 1f;
  private const float fadeAmount = 1f;

  private void Awake()
  {
    foreach (BattleMusicSystem.MinibossIntroRef minibossIntro in this.minibossIntros)
      this.minibossIntroLookup[minibossIntro.cardData.name] = minibossIntro.introEvent;
  }

  private void OnEnable()
  {
    global::Events.OnSceneChanged += new UnityAction<Scene>(this.SceneChange);
    global::Events.OnBattlePhaseStart += new UnityAction<Battle.Phase>(this.BattlePhaseChange);
    global::Events.OnBattleEnd += new UnityAction(this.BattleEnd);
    global::Events.OnEntityHit += new UnityAction<Hit>(this.EntityHit);
    global::Events.OnEntityMove += new UnityAction<Entity>(this.EntityMove);
    global::Events.OnMinibossIntro += new UnityAction<Entity>(this.MinibossIntro);
    global::Events.OnEntityChangePhase += new UnityAction<Entity>(this.EntityChangePhase);
    this.Check();
  }

  private void OnDisable()
  {
    global::Events.OnSceneChanged -= new UnityAction<Scene>(this.SceneChange);
    global::Events.OnBattlePhaseStart -= new UnityAction<Battle.Phase>(this.BattlePhaseChange);
    global::Events.OnBattleEnd -= new UnityAction(this.BattleEnd);
    global::Events.OnEntityHit -= new UnityAction<Hit>(this.EntityHit);
    global::Events.OnEntityMove -= new UnityAction<Entity>(this.EntityMove);
    global::Events.OnMinibossIntro -= new UnityAction<Entity>(this.MinibossIntro);
    global::Events.OnEntityChangePhase -= new UnityAction<Entity>(this.EntityChangePhase);
    this.StopMusic();
  }

  private void OnDestroy() => this.StopMusic();

  private void Update()
  {
    if ((double) this.promptStartMiniboss > 0.0)
    {
      this.promptStartMiniboss -= Time.deltaTime;
      if ((double) this.promptStartMiniboss <= 0.0)
      {
        this.StartMusic(References.GetCurrentArea().minibossMusicEvent);
        this.SetParam("bossHealth", 1f);
      }
    }
    float max = 1f * Time.deltaTime;
    if ((double) Mathf.Abs(this.pitch - this.targetPitch) <= (double) max)
      return;
    this.pitch += Mathf.Clamp(this.targetPitch - this.pitch, -max, max);
    if (!BattleMusicSystem.IsRunning(this.current))
      return;
    int num = (int) this.current.setPitch(this.pitch);
  }

  public void FadePitchTo(float value) => this.targetPitch = value;

  private void SceneChange(Scene scene)
  {
    this.currentScene = scene;
    this.Check();
  }

  private void BattlePhaseChange(Battle.Phase phase)
  {
    if (phase != Battle.Phase.End)
      return;
    this.StopMusic(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
  }

  private void BattleEnd()
  {
    if ((UnityEngine.Object) Battle.instance.winner == (UnityEngine.Object) Battle.instance.player)
      SfxSystem.OneShot(this.winJingle);
    else
      SfxSystem.OneShot(this.loseJingle);
  }

  private void EntityHit(Hit hit)
  {
    if (this.bossEntered || this.intensity != this.startingIntensity || !hit.Offensive)
      return;
    this.SetIntensity(this.normalIntensity);
  }

  private void EntityMove(Entity entity)
  {
    if (this.bossEntered || !this.currentScene.IsValid() || !(bool) (UnityEngine.Object) References.Battle || !((UnityEngine.Object) entity.owner == (UnityEngine.Object) References.Battle.enemy))
      return;
    CardType cardType = entity.data?.cardType;
    if (cardType == null || !cardType.miniboss || !Battle.IsOnBoard(entity) || Battle.IsOnBoard(entity.preContainers))
      return;
    this.bossEntered = true;
    this.StopMusic(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
  }

  private void MinibossIntro(Entity entity)
  {
    if (BattleMusicSystem.IsBossBattle())
      return;
    this.minibossIntroInstance = SfxSystem.OneShot(this.minibossIntroLookup.ContainsKey(entity.data.name) ? this.minibossIntroLookup[entity.data.name] : this.minibossIntroDefault);
    this.promptStartMiniboss = this.minibossIntroDuration;
  }

  private void EntityChangePhase(Entity entity)
  {
    if (!entity.data.cardType.miniboss || entity.owner.team != References.Battle.enemy.team || this.bossPhase >= 2)
      return;
    ++this.bossPhase;
    this.SetParam("finalboss", (float) this.bossPhase);
  }

  private void Check()
  {
    if (this.currentScene.name == "Battle")
    {
      CampaignNode characterNode = Campaign.FindCharacterNode(References.Player);
      AreaData area = References.Areas[characterNode.areaIndex];
      if (characterNode.type is CampaignNodeTypeBattle type && !type.overrideMusic.IsNull)
        this.StartMusic(type.overrideMusic);
      else if (characterNode.type.isBoss)
      {
        this.StartMusic(area.bossMusicEvent);
      }
      else
      {
        this.StartMusic(area.battleMusicEvent);
        this.InitBattleMusic();
      }
      if (!characterNode.type.isBoss)
        return;
      this.bossEntered = true;
      this.bossPhase = 1;
      this.SetParam("finalboss", (float) this.bossPhase);
    }
    else
      this.StopMusic(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
  }

  private void InitBattleMusic()
  {
    EventDescription description1;
    int description2 = (int) this.current.getDescription(out description1);
    PARAMETER_DESCRIPTION parameter;
    int descriptionByName = (int) description1.getParameterDescriptionByName("Phase", out parameter);
    this.intensityParameterId = parameter.id;
    this.SetIntensity(this.startingIntensity);
    this.bossEntered = false;
  }

  private void StartMusic(EventReference eventReference) => this.StartMusic(eventReference.Guid);

  private void StartMusic(GUID eventGUID)
  {
    try
    {
      this.current = RuntimeManager.CreateInstance(eventGUID);
      int num1 = (int) this.current.start();
      int num2 = (int) this.current.setPitch(this.pitch);
    }
    catch (EventNotFoundException ex)
    {
      UnityEngine.Debug.LogWarning((object) ex);
    }
  }

  private void StopMusic(FMOD.Studio.STOP_MODE stopMode = FMOD.Studio.STOP_MODE.IMMEDIATE)
  {
    int num1 = (int) this.current.stop(stopMode);
    int num2 = (int) this.current.release();
    this.targetPitch = 1f;
    this.targetVolume = 1f;
  }

  private void SetIntensity(int amount)
  {
    this.intensity = amount;
    int num = (int) this.current.setParameterByID(this.intensityParameterId, (float) this.intensity);
    UnityEngine.Debug.Log((object) string.Format("Battle Music System → Intensity Set to {0}", (object) this.intensity));
  }

  private void SetParam(string name, float value)
  {
    if (!BattleMusicSystem.IsRunning(this.current))
      return;
    int num = (int) this.current.setParameterByName(name, value);
    UnityEngine.Debug.Log((object) string.Format("Param Set: {0}: {1}", (object) name, (object) value));
  }

  private static bool IsRunning(EventInstance instance)
  {
    if (instance.isValid())
    {
      PLAYBACK_STATE state;
      int playbackState = (int) instance.getPlaybackState(out state);
      if (state != PLAYBACK_STATE.STOPPED)
        return true;
    }
    return false;
  }

  private static bool IsBossBattle() => Campaign.FindCharacterNode(References.Player).type.isBoss;

  public BattleMusicSaveData Save()
  {
    return new BattleMusicSaveData()
    {
      intensity = this.intensity,
      bossEntered = this.bossEntered,
      bossPhase = this.bossPhase
    };
  }

  public void Load(BattleMusicSaveData state)
  {
    if (BattleMusicSystem.IsRunning(this.current) && this.bossEntered == state.bossEntered && this.bossPhase == state.bossPhase)
      return;
    this.StopMusic();
    this.bossEntered = state.bossEntered;
    this.bossPhase = state.bossPhase;
    if (BattleMusicSystem.IsBossBattle())
    {
      this.StartMusic(References.GetCurrentArea().bossMusicEvent);
      this.SetParam("finalboss", (float) this.bossPhase);
    }
    else if (this.bossEntered)
    {
      this.StartMusic(References.GetCurrentArea().minibossMusicEvent);
    }
    else
    {
      this.StartMusic(References.GetCurrentArea().battleMusicEvent);
      this.SetIntensity(state.intensity);
    }
  }

  [Serializable]
  private struct MinibossIntroRef
  {
    [SerializeField]
    internal CardData cardData;
    [SerializeField]
    internal EventReference introEvent;
  }
}
