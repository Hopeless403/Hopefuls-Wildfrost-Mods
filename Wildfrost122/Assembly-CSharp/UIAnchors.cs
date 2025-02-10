// Decompiled with JetBrains decompiler
// Type: UIAnchors
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
public class UIAnchors : MonoBehaviour
{
  public UIAnchors.AnchorPoint[] list;

  public int Count => this.list.Length;

  public void Activate(int anchorIndex) => this.list[anchorIndex].Activate();

  public void Deactivate(int anchorIndex) => this.list[anchorIndex].Deactivate();

  public IEnumerator Reveal(int anchorIndex)
  {
    UIAnchors.AnchorPoint anchorPoint = this.list[anchorIndex];
    UIAnchor target = anchorPoint.target;
    RectTransform anchor = anchorPoint.anchor;
    target.Reveal();
    yield return (object) Sequences.Wait(target.revealDur);
  }

  public IEnumerator UnReveal(int anchorIndex, float delay = 0.0f)
  {
    UIAnchor target = this.list[anchorIndex].target;
    target.UnReveal(delay);
    yield return (object) Sequences.Wait(target.hideDur + delay);
  }

  [Button(null, EButtonEnableMode.Always)]
  private void PromptUpdate() => this.StartCoroutine(this.UpdatePositions());

  [Button(null, EButtonEnableMode.Always)]
  private void SetPositions()
  {
    foreach (UIAnchors.AnchorPoint anchorPoint in this.list)
      anchorPoint.target.transform.position = anchorPoint.anchor.transform.position;
  }

  public IEnumerator UpdatePositions()
  {
    List<Routine> routines = new List<Routine>();
    foreach (UIAnchors.AnchorPoint anchorPoint in this.list)
    {
      if (anchorPoint.target.gameObject.activeSelf)
        routines.Add(new Routine(anchorPoint.Move()));
    }
    bool routinesDone = false;
    while (!routinesDone)
    {
      routinesDone = true;
      foreach (Routine routine in routines)
      {
        if (routine != null && routine.IsRunning)
        {
          routinesDone = false;
          break;
        }
      }
      yield return (object) null;
    }
  }

  [Serializable]
  public class AnchorPoint
  {
    public UIAnchor target;
    public RectTransform anchor;

    public void Activate()
    {
      this.target.gameObject.SetActive(true);
      this.anchor.gameObject.SetActive(true);
    }

    public void Deactivate()
    {
      this.target.gameObject.SetActive(false);
      this.anchor.gameObject.SetActive(false);
    }

    public void SetUp() => this.target.SetUp();

    public IEnumerator Move(float dur = 0.75f, LeanTweenType ease = LeanTweenType.easeOutBack)
    {
      LeanTween.move(this.target.gameObject, this.anchor.position, dur).setEase(ease);
      Vector3 movement = this.anchor.position - this.target.transform.position;
      this.target.GetComponentInChildren<Wobbler>()?.Wobble(movement);
      yield return (object) Sequences.Wait(dur);
    }
  }
}
