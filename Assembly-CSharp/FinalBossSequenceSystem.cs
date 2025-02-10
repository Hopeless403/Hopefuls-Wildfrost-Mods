// Decompiled with JetBrains decompiler
// Type: FinalBossSequenceSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using FMODUnity;
using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class FinalBossSequenceSystem : GameSystem
{
  [SerializeField]
  private WispAnimator wispPrefab;
  [SerializeField]
  private Canvas canvas;
  [SerializeField]
  private Image background;
  [SerializeField]
  private ParticleSystem blipFX;
  [SerializeField]
  private ParticleSystem bigBlipFX;
  [SerializeField]
  private AnimationCurve hitMoveCurve;
  [SerializeField]
  private AnimationCurve hitRotateCurve;
  [SerializeField]
  private string sealCard = "LuminVase";
  [SerializeField]
  private Color possessFlashColor;
  [FormerlySerializedAs("flashColor")]
  [SerializeField]
  private Color luminFlashColor;
  [SerializeField]
  private LocalizedString continueKey;
  [SerializeField]
  private LocalizedString throwKey;
  [Header("SFX")]
  [SerializeField]
  private EventReference shadeSpawnSfxEvent;
  [SerializeField]
  private EventReference shadeFleeSfxEvent;
  [SerializeField]
  private EventReference shadeMoveSfxEvent;
  [SerializeField]
  private EventReference shadeFlashSfxEvent;
  [SerializeField]
  private EventReference cameraInSfxEvent;
  [SerializeField]
  private EventReference cameraOutHeroSfxEvent;
  [SerializeField]
  private EventReference cameraOutVaseSfxEvent;
  [SerializeField]
  private EventReference shakeHeroSfxEvent;
  [SerializeField]
  private EventReference shakeVaseSfxEvent;
  [SerializeField]
  private EventReference vaseSpawnSfxEvent;
  [SerializeField]
  private EventReference hitHeroSfxEvent;
  [SerializeField]
  private EventReference hitVaseSfxEvent;
  [SerializeField]
  private EventReference pingHeroSfxEvent;
  [SerializeField]
  private EventReference pingVaseSfxEvent;
  [SerializeField]
  private SfxLoop darkLoop;
  [SerializeField]
  private SfxLoop brightLoop;
  [SerializeField]
  private SfxLoop shadeLoop;
  private WispAnimator wisp;
  private bool running;
  private bool blockWisp;
  private Entity leader;
  private Entity blockCard;
  private CampaignNode playerNode;

  private void OnEnable()
  {
    global::Events.OnEntityKilled += new UnityAction<Entity, DeathType>(this.EntityKilled);
    global::Events.PreBattleEnd += new global::Events.AsyncAction(this.PreBattleEnd);
    this.playerNode = Campaign.FindCharacterNode(References.Player);
    if (this.playerNode.finalNode && Campaign.Data.GameMode.mainGameMode)
      return;
    UnityEngine.Object.Destroy((UnityEngine.Object) this);
  }

  private void OnDisable()
  {
    global::Events.OnEntityKilled -= new UnityAction<Entity, DeathType>(this.EntityKilled);
    global::Events.PreBattleEnd -= new global::Events.AsyncAction(this.PreBattleEnd);
  }

  private void EntityKilled(Entity entity, DeathType type)
  {
    if (!(bool) (UnityEngine.Object) References.Battle || !entity.data.cardType.miniboss || entity.owner.team != References.Battle.enemy.team || References.Battle.minibosses.Count<Entity>((Func<Entity, bool>) (a => (UnityEngine.Object) a != (UnityEngine.Object) entity && a.owner.team == References.Battle.enemy.team)) > 0)
      return;
    this.wisp = UnityEngine.Object.Instantiate<WispAnimator>(this.wispPrefab, entity.transform.position, Quaternion.identity, this.transform);
    this.wisp.KnockBackFrom(Vector3.zero);
    this.leader = Battle.GetCards(References.Battle.player).FirstOrDefault<Entity>((Func<Entity, bool>) (a => a.data.cardType.miniboss));
    if ((bool) (UnityEngine.Object) this.leader && this.leader.IsAliveAndExists())
      this.wisp.SetTarget(this.leader.transform);
    SfxSystem.OneShot(this.shadeSpawnSfxEvent);
    this.shadeLoop.Play();
  }

  private async Task PreBattleEnd()
  {
    FinalBossSequenceSystem bossSequenceSystem = this;
    if (!(bool) (UnityEngine.Object) bossSequenceSystem.wisp)
      return;
    if (!bossSequenceSystem.wisp.TargetExists())
    {
      bossSequenceSystem.wisp.maxSpeed = 0.0f;
      bossSequenceSystem.wisp.gravitate *= 0.5f;
    }
    else
    {
      if (!bossSequenceSystem.playerNode.finalNode)
        bossSequenceSystem.StartCoroutine(bossSequenceSystem.Flee());
      else
        bossSequenceSystem.StartCoroutine(bossSequenceSystem.PossessLeader());
      while (bossSequenceSystem.running)
        await Task.Delay(25);
    }
  }

  private IEnumerator PossessLeader()
  {
    FinalBossSequenceSystem bossSequenceSystem = this;
    if (bossSequenceSystem.leader.IsAliveAndExists())
    {
      PauseMenu.Block();
      bossSequenceSystem.running = true;
      CardData blockCardData = bossSequenceSystem.GetBlockCard();
      bossSequenceSystem.blockWisp = (bool) (UnityEngine.Object) blockCardData;
      if (!bossSequenceSystem.blockWisp)
        References.LeaderData.SetCustomData("eyes", (object) "frost");
      bossSequenceSystem.wisp.maxSpeed = 0.0f;
      bossSequenceSystem.wisp.gravitate *= 0.5f;
      yield return (object) new WaitForSeconds(1f);
      AmbienceSystem.SetParam("shade_visit", 1f);
      SfxSystem.OneShot(bossSequenceSystem.cameraInSfxEvent);
      if (bossSequenceSystem.blockWisp)
        bossSequenceSystem.brightLoop.Play();
      else
        bossSequenceSystem.darkLoop.Play();
      CinemaBarSystem.In();
      CinemaBarSystem.SetSortingLayer("Inspect", 1);
      bossSequenceSystem.canvas.gameObject.SetActive(true);
      bossSequenceSystem.leader.transform.SetParent(bossSequenceSystem.canvas.transform);
      Vector2 v = new Vector2(1.5f, 2f);
      LeanTween.move(bossSequenceSystem.leader.gameObject, new Vector3(-3f, 0.25f, -3f), v.Random()).setEase(LeanTweenType.easeInOutQuart);
      LeanTween.move(bossSequenceSystem.wisp.gameObject, new Vector3(3f, 0.25f, -3f), v.Random()).setEase(LeanTweenType.easeInOutQuart);
      bossSequenceSystem.wisp.SetSortingLayer("Inspect", 1);
      yield return (object) new WaitForSeconds(v.y);
      if (bossSequenceSystem.blockWisp)
        yield return (object) bossSequenceSystem.BlockWisp(blockCardData);
      SfxSystem.OneShot(bossSequenceSystem.shadeMoveSfxEvent);
      SfxSystem.OneShot(bossSequenceSystem.shadeFlashSfxEvent);
      bossSequenceSystem.wisp.JumpToTarget();
      bossSequenceSystem.wisp.FadeToColour(new Color(0.6f, 0.2f, 1f), 0.5f, 0.4f);
      global::Events.InvokeScreenRumble(1f, 0.0f, 0.0f, 0.1f, 0.9f, 1f / 1000f);
      yield return (object) new WaitForSeconds(1f);
      global::Events.InvokeScreenShake();
      bossSequenceSystem.wisp.gameObject.Destroy();
      bossSequenceSystem.blipFX.transform.position = bossSequenceSystem.wisp.transform.position;
      bossSequenceSystem.blipFX.Play();
      bossSequenceSystem.shadeLoop.Stop();
      Entity hitCard = bossSequenceSystem.leader;
      if (bossSequenceSystem.blockWisp)
      {
        SfxSystem.OneShot(bossSequenceSystem.hitVaseSfxEvent);
        hitCard = bossSequenceSystem.blockCard;
        bossSequenceSystem.ReturnLeader();
      }
      else
        SfxSystem.OneShot(bossSequenceSystem.hitHeroSfxEvent);
      LeanTween.value(bossSequenceSystem.gameObject, Time.timeScale, 0.1f, 0.05f).setEase(LeanTweenType.linear).setOnUpdate(new Action<float>(global::Events.InvokeTimeScaleChange));
      ScreenFlashSystem.SetDrawOrder("ParticlesFront", 999);
      if (bossSequenceSystem.blockWisp)
      {
        ScreenFlashSystem.SetColour(bossSequenceSystem.luminFlashColor);
        ScreenFlashSystem.Run(0.25f);
      }
      else
      {
        ScreenFlashSystem.SetColour(bossSequenceSystem.possessFlashColor);
        ScreenFlashSystem.SetMaterialAdditive();
        ScreenFlashSystem.Run(0.15f);
      }
      hitCard.wobbler.WobbleRandom();
      double num1 = (double) hitCard.curveAnimator.Move(new Vector3(-2f, 0.0f, 0.0f), bossSequenceSystem.hitMoveCurve, 0.0f, 1f);
      double num2 = (double) hitCard.curveAnimator.Rotate(new Vector3(0.0f, 0.0f, 10f), bossSequenceSystem.hitRotateCurve, 1f);
      yield return (object) new WaitForSeconds(0.25f);
      LeanTween.value(bossSequenceSystem.gameObject, Time.timeScale, 1f, 0.25f).setEase(LeanTweenType.linear).setOnUpdate(new Action<float>(global::Events.InvokeTimeScaleChange));
      yield return (object) new WaitForSeconds(0.25f);
      SfxSystem.OneShot(bossSequenceSystem.blockWisp ? bossSequenceSystem.shakeVaseSfxEvent : bossSequenceSystem.shakeHeroSfxEvent);
      FinalBossSequenceSystem.ZoomInOn(hitCard.gameObject);
      global::Events.InvokeScreenRumble(0.0f, 1f, 0.4f, 0.3f, 0.2f, 0.1f);
      if (bossSequenceSystem.blockWisp)
      {
        // ISSUE: reference to a compiler-generated method
        LeanTween.value(1f, 0.9f, 1f).setEaseInOutQuart().setOnUpdate(new Action<float>(bossSequenceSystem.\u003CPossessLeader\u003Eb__39_0));
      }
      yield return (object) new WaitForSeconds(1.1f);
      bossSequenceSystem.brightLoop.Stop();
      bossSequenceSystem.darkLoop.Stop();
      SfxSystem.OneShot(bossSequenceSystem.blockWisp ? bossSequenceSystem.pingVaseSfxEvent : bossSequenceSystem.pingHeroSfxEvent);
      bossSequenceSystem.Ping(hitCard);
      if (!bossSequenceSystem.blockWisp)
        FrostEyeSystem.Create(bossSequenceSystem.leader);
      CinemaBarSystem.Top.SetPrompt(bossSequenceSystem.continueKey.GetLocalizedString(), "Select");
      yield return (object) new WaitUntil(new Func<bool>(InputSystem.IsSelectPressed));
      AmbienceSystem.SetParam("shade_visit", 0.0f);
      bossSequenceSystem.canvas.gameObject.SetActive(false);
      if (bossSequenceSystem.blockWisp)
      {
        CardManager.ReturnToPool(bossSequenceSystem.blockCard);
        SfxSystem.OneShot(bossSequenceSystem.cameraOutVaseSfxEvent);
      }
      else
      {
        bossSequenceSystem.ReturnLeader();
        SfxSystem.OneShot(bossSequenceSystem.cameraOutHeroSfxEvent);
      }
      CinemaBarSystem.Out();
      CinemaBarSystem.SetSortingLayer("CinemaBars");
      bossSequenceSystem.running = false;
      PauseMenu.Unblock();
    }
  }

  private CardData GetBlockCard() => References.PlayerData.inventory.deck.FirstOrDefault<CardData>((Func<CardData, bool>) (a => a.name == this.sealCard));

  private IEnumerator BlockWisp(CardData blockCardData)
  {
    FinalBossSequenceSystem bossSequenceSystem = this;
    bossSequenceSystem.blockCard = CardManager.Get(blockCardData, bossSequenceSystem.leader.display.hover.controller, bossSequenceSystem.leader.owner, true, true).entity;
    yield return (object) bossSequenceSystem.blockCard.display.UpdateData();
    SfxSystem.OneShot(bossSequenceSystem.vaseSpawnSfxEvent);
    LeanTween.value(bossSequenceSystem.gameObject, Time.timeScale, 0.1f, 0.25f).setEase(LeanTweenType.linear).setOnUpdate(new Action<float>(global::Events.InvokeTimeScaleChange));
    bossSequenceSystem.blockCard.transform.localScale = bossSequenceSystem.leader.transform.localScale;
    bossSequenceSystem.blockCard.transform.SetParent(bossSequenceSystem.canvas.transform);
    bossSequenceSystem.blockCard.transform.SetPositionAndRotation(new Vector3(0.0f, -5f, -2f), Quaternion.identity);
    LeanTween.move(bossSequenceSystem.blockCard.gameObject, bossSequenceSystem.blockCard.transform.position.WithY(-3f), 0.5f).setIgnoreTimeScale(true).setEaseOutBack();
    bossSequenceSystem.blockCard.DrawOrder = 2;
    CinemaBarSystem.Top.SetPrompt(bossSequenceSystem.throwKey.GetLocalizedString().Format((object) blockCardData.title), "Select");
    yield return (object) new WaitUntil(new Func<bool>(InputSystem.IsSelectPressed));
    CinemaBarSystem.Top.RemovePrompt();
    LeanTween.move(bossSequenceSystem.blockCard.gameObject, bossSequenceSystem.leader.transform.position.WithX(-2.5f), 1f).setEaseOutQuint();
    LeanTween.move(bossSequenceSystem.leader.gameObject, bossSequenceSystem.leader.transform.position.WithX(-5f), 0.75f).setEaseOutQuint();
    LeanTween.value(bossSequenceSystem.gameObject, Time.timeScale, 1f, 0.15f).setEase(LeanTweenType.linear).setOnUpdate(new Action<float>(global::Events.InvokeTimeScaleChange));
  }

  private IEnumerator Flee()
  {
    SfxSystem.OneShot(this.shadeFleeSfxEvent);
    this.shadeLoop.Stop();
    this.running = true;
    this.wisp.SetTarget(References.Battle.enemy.reserveContainer.transform);
    this.wisp.JumpToTarget();
    yield return (object) new WaitForSeconds(1f);
    this.running = false;
  }

  private static void ZoomInOn(GameObject target, float zPos = -2f)
  {
    LeanTween.cancel(target);
    LeanTween.moveLocal(target, Vector3.zero.WithZ(zPos), 0.5f).setEase(LeanTweenType.easeInOutQuad);
    LeanTween.rotateLocal(target, Vector3.zero, 0.5f).setEase(LeanTweenType.easeInOutQuad);
  }

  private void Ping(Entity entity)
  {
    double num = (double) entity.curveAnimator.Ping();
    entity.wobbler.WobbleRandom(2f);
    global::Events.InvokeScreenShake(2f);
    this.bigBlipFX.transform.position = entity.transform.position;
    this.bigBlipFX.Play();
  }

  private void ReturnLeader()
  {
    this.leader.transform.SetParent((Transform) this.leader.actualContainers[0].holder);
    this.leader.TweenToContainer();
    this.leader.wobbler.WobbleRandom();
  }
}
