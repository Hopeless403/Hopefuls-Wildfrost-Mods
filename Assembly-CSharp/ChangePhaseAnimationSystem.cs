// Decompiled with JetBrains decompiler
// Type: ChangePhaseAnimationSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangePhaseAnimationSystem : GameSystem
{
  [SerializeField]
  private Transform container;
  [SerializeField]
  private float zoomAmount = 3f;
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
  public float slowmo = 0.1f;
  public float durationIn = 0.3f;
  public float durationOut = 0.9f;
  private readonly List<ChangePhaseAnimationSystem.Target> targets = new List<ChangePhaseAnimationSystem.Target>();

  public void Assign(Entity target)
  {
    this.targets.Add(new ChangePhaseAnimationSystem.Target(target));
    target.transform.SetParent(this.container, true);
    target.ResetDrawOrder();
  }

  public void ClearFocus()
  {
    foreach (ChangePhaseAnimationSystem.Target target in this.targets)
    {
      if ((bool) (UnityEngine.Object) target.entity && (bool) (UnityEngine.Object) target.entity.transform && (bool) (UnityEngine.Object) target.previousParent)
        target.entity.transform.SetParent(target.previousParent);
    }
    this.targets.Clear();
  }

  public void RemoveTarget(Entity entity)
  {
    for (int index = this.targets.Count - 1; index >= 0; --index)
    {
      if ((UnityEngine.Object) this.targets[index].entity == (UnityEngine.Object) entity)
        this.targets.RemoveAt(index);
    }
  }

  public void Flash()
  {
    ScreenFlashSystem.SetDrawOrder("ParticlesFront", 0);
    ScreenFlashSystem.SetColour(this.flashColor);
    ScreenFlashSystem.Run(0.2f);
  }

  public IEnumerator Focus(Entity target)
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    ChangePhaseAnimationSystem phaseAnimationSystem = this;
    if (num != 0)
    {
      if (num != 1)
        return false;
      // ISSUE: reference to a compiler-generated field
      this.\u003C\u003E1__state = -1;
      LeanTween.value(phaseAnimationSystem.gameObject, Time.timeScale, 1f, 0.25f).setEase(LeanTweenType.linear).setOnUpdate(new Action<float>(Events.InvokeTimeScaleChange));
      return false;
    }
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = -1;
    phaseAnimationSystem.Assign(target);
    HitFlashSystem.Remove(target);
    LeanTween.value(phaseAnimationSystem.gameObject, Time.timeScale, phaseAnimationSystem.slowmo, 0.05f).setEase(LeanTweenType.linear).setOnUpdate(new Action<float>(Events.InvokeTimeScaleChange));
    LeanTween.value(phaseAnimationSystem.gameObject, Time.timeScale, 1f, 0.25f).setDelay(phaseAnimationSystem.durationIn).setEase(LeanTweenType.linear).setOnUpdate(new Action<float>(Events.InvokeTimeScaleChange));
    // ISSUE: reference to a compiler-generated method
    LeanTween.value(phaseAnimationSystem.gameObject, phaseAnimationSystem.fade.color.a, phaseAnimationSystem.fadeColor.a, phaseAnimationSystem.durationIn).setEase(LeanTweenType.easeInOutQuint).setOnUpdate(new Action<float>(phaseAnimationSystem.\u003CFocus\u003Eb__15_0));
    Vector3 to = target.transform.position.WithZ(phaseAnimationSystem.zoomAmount);
    LeanTween.cancel(References.MinibossCameraMover.gameObject);
    LeanTween.move(References.MinibossCameraMover.gameObject, to, Mathf.Min(phaseAnimationSystem.durationIn, 0.4f)).setEase(LeanTweenType.easeOutBack);
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E2__current = (object) Sequences.Wait(phaseAnimationSystem.durationIn);
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = 1;
    return true;
  }

  public IEnumerator UnFocus()
  {
    ChangePhaseAnimationSystem phaseAnimationSystem = this;
    yield return (object) Sequences.Wait(0.1f);
    LeanTween.moveLocal(References.MinibossCameraMover.gameObject, Vector3.zero, phaseAnimationSystem.durationOut).setEase(LeanTweenType.easeOutBack);
    // ISSUE: reference to a compiler-generated method
    LeanTween.value(phaseAnimationSystem.gameObject, phaseAnimationSystem.fade.color.a, 0.0f, 0.25f).setEase(LeanTweenType.easeInOutQuart).setOnUpdate(new Action<float>(phaseAnimationSystem.\u003CUnFocus\u003Eb__16_0));
    yield return (object) Sequences.Wait(phaseAnimationSystem.durationOut);
    phaseAnimationSystem.ClearFocus();
    PauseMenu.Unblock();
    DeckpackBlocker.Unblock();
  }

  private class Target
  {
    public Entity entity;
    public Transform previousParent;

    public Target(Entity entity)
    {
      this.entity = entity;
      this.previousParent = entity.transform.parent;
    }
  }
}
