// Decompiled with JetBrains decompiler
// Type: MinibossIntroSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using FMODUnity;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

#nullable disable
public class MinibossIntroSystem : GameSystem
{
  [SerializeField]
  public Transform container;
  [Header("Focus")]
  [SerializeField]
  public float focusAmount = 0.75f;
  [SerializeField]
  public float zoomAmount = 3f;
  [SerializeField]
  public CurveProfile focusTween;
  [SerializeField]
  public CurveProfile unfocusTween;
  [Header("Fade")]
  [SerializeField]
  public Image fade;
  [SerializeField]
  public Color fadeColor;
  [Header("Move miniboss to position")]
  [SerializeField]
  public Vector3 move = new Vector3(0.0f, 0.0f, -1f);
  [SerializeField]
  public CurveProfile moveTween;
  [SerializeField]
  public CurveProfile returnTween;
  [Header("Pauses before/after miniboss animation")]
  [SerializeField]
  public float pauseBefore = 0.33f;
  [SerializeField]
  public float pauseAfter = 1f;
  [Header("Delays")]
  [SerializeField]
  public float delayBefore = 0.2f;
  [SerializeField]
  public float delayAfter = 0.2f;
  [Header("Miniboss animations")]
  [SerializeField]
  public CardAnimation defaultAnimation;
  [SerializeField]
  public MinibossIntroSystem.MinibossAnimation[] specificAnimations;
  [Header("SFX")]
  [SerializeField]
  public EventReference zoomSfx;
  [SerializeField]
  public EventReference shakeSfx;
  public readonly List<Entity> ignore = new List<Entity>();
  public Dictionary<string, CardAnimation> animationLookup;
  public Entity target;
  public Transform targetPreviousParent;
  public global::Routine routine;
  public bool hasRun;

  public void OnEnable()
  {
    global::Events.OnSceneChanged += new UnityAction<Scene>(this.SceneChanged);
    global::Events.OnEntityMove += new UnityAction<Entity>(this.EntityMove);
    this.animationLookup = new Dictionary<string, CardAnimation>();
    foreach (MinibossIntroSystem.MinibossAnimation specificAnimation in this.specificAnimations)
      this.animationLookup[specificAnimation.cardData.name] = specificAnimation.animation;
  }

  public void OnDisable()
  {
    global::Events.OnSceneChanged -= new UnityAction<Scene>(this.SceneChanged);
    global::Events.OnEntityMove -= new UnityAction<Entity>(this.EntityMove);
    this.StopAllCoroutines();
    this.routine?.Stop();
    if (!(bool) (UnityEngine.Object) References.MinibossCameraMover)
      return;
    LeanTween.cancel(References.MinibossCameraMover.gameObject);
    References.MinibossCameraMover.localPosition = Vector3.zero;
  }

  public void Ignore(Entity entity) => this.ignore.Add(entity);

  public void SceneChanged(Scene scene)
  {
    this.ignore.Clear();
    this.hasRun = false;
  }

  public void EntityMove(Entity entity)
  {
    if (this.hasRun || this.ignore.Contains(entity))
      return;
    CardType cardType = entity.data.cardType;
    if (cardType == null || !cardType.miniboss || !((UnityEngine.Object) entity.owner == (UnityEngine.Object) Battle.instance.enemy) || !Battle.IsOnBoard(entity) || Battle.IsOnBoard(entity.preContainers))
      return;
    this.Activate(entity);
    this.hasRun = true;
  }

  public void Activate(Entity target)
  {
    this.ignore.Add(target);
    this.routine = new global::Routine(this.Routine(target));
    ActionQueue.Stack((PlayAction) new ActionSequence(this.WaitForRoutineToEnd()));
  }

  public IEnumerator WaitForRoutineToEnd()
  {
    while (this.routine.IsRunning)
      yield return (object) null;
  }

  public void Assign(Entity target)
  {
    this.UnAssign();
    this.target = target;
    this.targetPreviousParent = target.transform.parent;
    target.transform.SetParent(this.container, true);
    target.ResetDrawOrder();
  }

  public void UnAssign()
  {
    if ((bool) (UnityEngine.Object) this.target)
      this.target.transform.SetParent(this.targetPreviousParent);
    this.target = (Entity) null;
  }

  public IEnumerator Routine(Entity target)
  {
    MinibossIntroSystem minibossIntroSystem = this;
    global::Events.InvokeSetWeatherIntensity(1f, 1f);
    minibossIntroSystem.Assign(target);
    LeanTween.value(minibossIntroSystem.gameObject, minibossIntroSystem.fade.color.a, minibossIntroSystem.fadeColor.a, minibossIntroSystem.focusTween.duration).setEase(LeanTweenType.easeInOutQuart).setOnUpdate((Action<float>) (a => this.fade.color = this.fade.color.With(alpha: a)));
    target.flipper?.FlipUpInstant();
    CinemaBarSystem.SetSortingLayer("Inspect", 1);
    CinemaBarSystem.In();
    LeanTween.cancel(target.gameObject);
    yield return (object) Sequences.Wait(minibossIntroSystem.delayBefore);
    global::Events.InvokeMinibossIntro(target);
    LeanTween.moveLocal(target.gameObject, Vector3.zero, minibossIntroSystem.moveTween.duration).setEase(minibossIntroSystem.moveTween.curve);
    yield return (object) Sequences.Wait(minibossIntroSystem.pauseBefore);
    PauseMenu.Block();
    Vector3 originalCameraPos = Vector3.zero;
    Vector3 to = Vector3.Lerp(originalCameraPos, minibossIntroSystem.container.position, minibossIntroSystem.focusAmount).WithZ(minibossIntroSystem.zoomAmount);
    LeanTween.cancel(References.MinibossCameraMover.gameObject);
    LeanTween.move(References.MinibossCameraMover.gameObject, to, minibossIntroSystem.focusTween.duration).setEase(minibossIntroSystem.focusTween.curve);
    SfxSystem.OneShot(minibossIntroSystem.zoomSfx);
    CardAnimation valueOrDefault = minibossIntroSystem.animationLookup.GetValueOrDefault<string, CardAnimation>(target.name, minibossIntroSystem.defaultAnimation);
    SfxSystem.OneShot(minibossIntroSystem.shakeSfx);
    yield return (object) valueOrDefault.Routine((object) target);
    yield return (object) Sequences.Wait(minibossIntroSystem.pauseAfter);
    CardContainer actualContainer = target.actualContainers[0];
    Vector3 containerScale = target.GetContainerScale();
    Vector3 containerWorldRotation = target.GetContainerWorldRotation();
    Vector3 containerWorldPosition = target.GetContainerWorldPosition();
    LeanTween.cancel(target.gameObject);
    LeanTween.scale(target.gameObject, containerScale, minibossIntroSystem.returnTween.duration).setEase(minibossIntroSystem.returnTween.curve);
    LeanTween.rotate(target.gameObject, containerWorldRotation, minibossIntroSystem.returnTween.duration).setEase(minibossIntroSystem.returnTween.curve);
    LeanTween.move(target.gameObject, containerWorldPosition, minibossIntroSystem.returnTween.duration).setEase(minibossIntroSystem.returnTween.curve).setOnComplete((System.Action) (() => target.wobbler?.WobbleRandom()));
    LeanTween.moveLocal(References.MinibossCameraMover.gameObject, originalCameraPos, minibossIntroSystem.unfocusTween.duration).setEase(LeanTweenType.easeInOutBack);
    LeanTween.value(minibossIntroSystem.gameObject, minibossIntroSystem.fade.color.a, 0.0f, minibossIntroSystem.unfocusTween.duration).setEase(minibossIntroSystem.unfocusTween.curve).setOnUpdate((Action<float>) (a => this.fade.color = this.fade.color.With(alpha: a)));
    CinemaBarSystem.Out();
    global::Events.InvokeSetWeatherIntensity(0.25f, 3f);
    global::Events.InvokeMinibossIntroDone(target);
    yield return (object) Sequences.Wait(minibossIntroSystem.unfocusTween.duration);
    minibossIntroSystem.UnAssign();
    PauseMenu.Unblock();
    yield return (object) Sequences.Wait(minibossIntroSystem.delayAfter);
  }

  [Serializable]
  public struct MinibossAnimation
  {
    public CardData cardData;
    public CardAnimation animation;
  }
}
