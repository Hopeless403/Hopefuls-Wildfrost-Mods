// Decompiled with JetBrains decompiler
// Type: MinibossDeathZoomSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
public class MinibossDeathZoomSystem : GameSystem
{
  [SerializeField]
  private Transform container;
  [SerializeField]
  private float zoomAmount = 4f;
  [SerializeField]
  private Image fade;
  [SerializeField]
  private Color fadeColor;
  [SerializeField]
  private Color flashColor;
  [SerializeField]
  private Image flash;
  [SerializeField]
  private AnimationCurve flashCurve;
  [SerializeField]
  private float slowmo = 0.1f;
  [SerializeField]
  private float duration = 0.3f;
  [SerializeField]
  private Vector3 limit = new Vector3(5.5f, 2.5f, 5f);
  private Entity target;
  private Transform targetPreviousParent;
  private bool pauseBlocked;
  private bool slowmoActive;

  private void OnEnable()
  {
    global::Events.OnEntityKilled += new UnityAction<Entity, DeathType>(this.EntityKilled);
  }

  private void OnDisable()
  {
    global::Events.OnEntityKilled -= new UnityAction<Entity, DeathType>(this.EntityKilled);
    this.UnblockPause();
    this.EndSlowmo();
  }

  private void EntityKilled(Entity entity, DeathType deathType)
  {
    if (!(bool) (UnityEngine.Object) entity || !(bool) (UnityEngine.Object) entity.data)
      return;
    CardType cardType = entity.data.cardType;
    if (cardType == null || !cardType.miniboss || References.Battle.minibosses.Count<Entity>((Func<Entity, bool>) (a => (UnityEngine.Object) a != (UnityEngine.Object) entity && (UnityEngine.Object) a.owner == (UnityEngine.Object) entity.owner)) > 0)
      return;
    this.Run(entity);
  }

  private void Run(Entity target) => this.StartCoroutine(this.Routine(target));

  private void BlockPause()
  {
    if (this.pauseBlocked)
      return;
    this.pauseBlocked = true;
    PauseMenu.Block();
    DeckpackBlocker.Block();
    if (!Deckpack.IsOpen || !(References.Player.entity.display is CharacterDisplay display))
      return;
    display.CloseInventory();
  }

  private void UnblockPause()
  {
    if (!this.pauseBlocked)
      return;
    this.pauseBlocked = false;
    DeckpackBlocker.Unblock();
    PauseMenu.Unblock();
  }

  private void Slowmo()
  {
    if (this.slowmoActive)
      return;
    this.slowmoActive = true;
    LeanTween.value(Time.timeScale, this.slowmo, 0.05f).setEase(LeanTweenType.linear).setOnUpdate(new Action<float>(global::Events.InvokeTimeScaleChange));
  }

  private void EndSlowmo()
  {
    if (!this.slowmoActive)
      return;
    this.slowmoActive = false;
    LeanTween.value(Time.timeScale, 1f, 0.25f).setEase(LeanTweenType.linear).setOnUpdate(new Action<float>(global::Events.InvokeTimeScaleChange));
  }

  private IEnumerator Routine(Entity target)
  {
    MinibossDeathZoomSystem minibossDeathZoomSystem = this;
    minibossDeathZoomSystem.BlockPause();
    if ((bool) (UnityEngine.Object) minibossDeathZoomSystem.target)
      minibossDeathZoomSystem.target.transform.SetParent(minibossDeathZoomSystem.targetPreviousParent);
    yield return (object) null;
    minibossDeathZoomSystem.target = target;
    minibossDeathZoomSystem.targetPreviousParent = target.transform.parent;
    target.transform.SetParent(minibossDeathZoomSystem.container);
    target.ResetDrawOrder();
    HitFlashSystem.Remove(target);
    FlyOffScreen component = target.GetComponent<FlyOffScreen>();
    if ((bool) (UnityEngine.Object) component)
    {
      component.velocity.z = 0.0f;
      component.velocity = component.velocity.normalized * 20f;
      component.velocity.z = -3f;
    }
    ScreenFlashSystem.SetDrawOrder("Inspect", 1);
    ScreenFlashSystem.SetColour(minibossDeathZoomSystem.flashColor);
    ScreenFlashSystem.Run(0.1f);
    minibossDeathZoomSystem.Slowmo();
    // ISSUE: reference to a compiler-generated method
    LeanTween.value(minibossDeathZoomSystem.gameObject, minibossDeathZoomSystem.fade.color.a, minibossDeathZoomSystem.fadeColor.a, minibossDeathZoomSystem.duration).setEase(LeanTweenType.easeInOutQuint).setOnUpdate(new Action<float>(minibossDeathZoomSystem.\u003CRoutine\u003Eb__22_0));
    Vector3 to = (target.transform.position.WithZ(minibossDeathZoomSystem.zoomAmount) - References.MinibossCameraMover.position).Clamp(-minibossDeathZoomSystem.limit, minibossDeathZoomSystem.limit);
    LeanTween.cancel(References.MinibossCameraMover.gameObject);
    LeanTween.moveLocal(References.MinibossCameraMover.gameObject, to, Mathf.Min(minibossDeathZoomSystem.duration, 0.4f)).setEase(LeanTweenType.easeOutBack);
    yield return (object) Sequences.Wait(minibossDeathZoomSystem.duration);
    minibossDeathZoomSystem.EndSlowmo();
    LeanTween.moveLocal(References.MinibossCameraMover.gameObject, Vector3.zero, 1f).setEase(LeanTweenType.easeOutBack);
    // ISSUE: reference to a compiler-generated method
    LeanTween.value(minibossDeathZoomSystem.gameObject, minibossDeathZoomSystem.fade.color.a, 0.0f, 0.25f).setEase(LeanTweenType.easeInOutQuart).setOnUpdate(new Action<float>(minibossDeathZoomSystem.\u003CRoutine\u003Eb__22_1));
    yield return (object) Sequences.Wait(1f);
    if ((bool) (UnityEngine.Object) minibossDeathZoomSystem.target)
      minibossDeathZoomSystem.target.transform.SetParent(minibossDeathZoomSystem.targetPreviousParent);
    minibossDeathZoomSystem.target = (Entity) null;
    minibossDeathZoomSystem.UnblockPause();
  }
}
