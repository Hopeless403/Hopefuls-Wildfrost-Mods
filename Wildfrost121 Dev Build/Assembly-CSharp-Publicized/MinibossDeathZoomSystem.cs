// Decompiled with JetBrains decompiler
// Type: MinibossDeathZoomSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
public class MinibossDeathZoomSystem : GameSystem
{
  [SerializeField]
  public Transform container;
  [SerializeField]
  public float zoomAmount = 4f;
  [SerializeField]
  public Image fade;
  [SerializeField]
  public Color fadeColor;
  [SerializeField]
  public Color flashColor;
  [SerializeField]
  public Image flash;
  [SerializeField]
  public AnimationCurve flashCurve;
  [SerializeField]
  public float slowmo = 0.1f;
  [SerializeField]
  public float duration = 0.3f;
  [SerializeField]
  public Vector3 limit = new Vector3(5.5f, 2.5f, 5f);
  public Entity target;
  public Transform targetPreviousParent;
  public bool pauseBlocked;
  public bool slowmoActive;

  public void OnEnable()
  {
    global::Events.OnEntityKilled += new UnityAction<Entity, DeathType>(this.EntityKilled);
  }

  public void OnDisable()
  {
    global::Events.OnEntityKilled -= new UnityAction<Entity, DeathType>(this.EntityKilled);
    this.UnblockPause();
    this.EndSlowmo();
  }

  public void EntityKilled(Entity entity, DeathType deathType)
  {
    if (!(bool) (UnityEngine.Object) entity || !(bool) (UnityEngine.Object) entity.data)
      return;
    CardType cardType = entity.data.cardType;
    if (cardType == null || !cardType.miniboss || References.Battle.minibosses.Count<Entity>((Func<Entity, bool>) (a => (UnityEngine.Object) a != (UnityEngine.Object) entity && (UnityEngine.Object) a.owner == (UnityEngine.Object) entity.owner)) > 0)
      return;
    this.Run(entity);
  }

  public void Run(Entity target) => this.StartCoroutine(this.Routine(target));

  public void BlockPause()
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

  public void UnblockPause()
  {
    if (!this.pauseBlocked)
      return;
    this.pauseBlocked = false;
    DeckpackBlocker.Unblock();
    PauseMenu.Unblock();
  }

  public void Slowmo()
  {
    if (this.slowmoActive)
      return;
    this.slowmoActive = true;
    LeanTween.value(Time.timeScale, this.slowmo, 0.05f).setEase(LeanTweenType.linear).setOnUpdate(new Action<float>(global::Events.InvokeTimeScaleChange));
  }

  public void EndSlowmo()
  {
    if (!this.slowmoActive)
      return;
    this.slowmoActive = false;
    LeanTween.value(Time.timeScale, 1f, 0.25f).setEase(LeanTweenType.linear).setOnUpdate(new Action<float>(global::Events.InvokeTimeScaleChange));
  }

  public IEnumerator Routine(Entity target)
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
    LeanTween.value(minibossDeathZoomSystem.gameObject, minibossDeathZoomSystem.fade.color.a, minibossDeathZoomSystem.fadeColor.a, minibossDeathZoomSystem.duration).setEase(LeanTweenType.easeInOutQuint).setOnUpdate(new Action<float>(minibossDeathZoomSystem.\u003CRoutine\u003Eb__22_0));
    Vector3 to = (target.transform.position.WithZ(minibossDeathZoomSystem.zoomAmount) - References.MinibossCameraMover.position).Clamp(-minibossDeathZoomSystem.limit, minibossDeathZoomSystem.limit);
    LeanTween.cancel(References.MinibossCameraMover.gameObject);
    LeanTween.moveLocal(References.MinibossCameraMover.gameObject, to, Mathf.Min(minibossDeathZoomSystem.duration, 0.4f)).setEase(LeanTweenType.easeOutBack);
    yield return (object) Sequences.Wait(minibossDeathZoomSystem.duration);
    minibossDeathZoomSystem.EndSlowmo();
    LeanTween.moveLocal(References.MinibossCameraMover.gameObject, Vector3.zero, 1f).setEase(LeanTweenType.easeOutBack);
    LeanTween.value(minibossDeathZoomSystem.gameObject, minibossDeathZoomSystem.fade.color.a, 0.0f, 0.25f).setEase(LeanTweenType.easeInOutQuart).setOnUpdate(new Action<float>(minibossDeathZoomSystem.\u003CRoutine\u003Eb__22_1));
    yield return (object) Sequences.Wait(1f);
    if ((bool) (UnityEngine.Object) minibossDeathZoomSystem.target)
      minibossDeathZoomSystem.target.transform.SetParent(minibossDeathZoomSystem.targetPreviousParent);
    minibossDeathZoomSystem.target = (Entity) null;
    minibossDeathZoomSystem.UnblockPause();
  }

  [CompilerGenerated]
  public void \u003CRoutine\u003Eb__22_0(float a)
  {
    this.fade.color = this.fade.color.With(alpha: a);
  }

  [CompilerGenerated]
  public void \u003CRoutine\u003Eb__22_1(float a)
  {
    this.fade.color = this.fade.color.With(alpha: a);
  }
}
