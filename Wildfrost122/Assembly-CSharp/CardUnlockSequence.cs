// Decompiled with JetBrains decompiler
// Type: CardUnlockSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Localization;

#nullable disable
public class CardUnlockSequence : MonoBehaviour
{
  [SerializeField]
  private Transform cardHolder;
  [SerializeField]
  private float duration = 2f;
  [SerializeField]
  private string waitForPress = "Select";
  [SerializeField]
  private ParticleSystem burstParticleSystem;
  [SerializeField]
  private LocalizedString titleKey;
  [SerializeField]
  private LocalizedString promptKey;

  public IEnumerator Run(Entity card, CardContainer endContainer)
  {
    CardUnlockSequence cardUnlockSequence = this;
    Events.InvokeEntityShowUnlocked(card);
    cardUnlockSequence.gameObject.SetActive(true);
    CinemaBarSystem.In();
    CinemaBarSystem.Top.SetPrompt(cardUnlockSequence.titleKey.GetLocalizedString(), "");
    CinemaBarSystem.Bottom.SetPrompt(cardUnlockSequence.promptKey.GetLocalizedString(), "Select");
    CinemaBarSystem.SetSortingLayer("UI2");
    Transform transform = card.transform;
    transform.SetParent(cardUnlockSequence.cardHolder);
    transform.localPosition = Vector3.zero;
    cardUnlockSequence.burstParticleSystem.Play();
    transform.localScale = new Vector3(2f, 0.0f, 1f);
    LeanTween.scale(transform.gameObject, Vector3.one, 1.5f).setEase(LeanTweenType.easeOutElastic);
    yield return (object) new WaitForSeconds(cardUnlockSequence.duration);
    if (!cardUnlockSequence.waitForPress.IsNullOrWhitespace())
    {
      // ISSUE: reference to a compiler-generated method
      yield return (object) new WaitUntil(new Func<bool>(cardUnlockSequence.\u003CRun\u003Eb__6_0));
    }
    CinemaBarSystem.Clear();
    CinemaBarSystem.Out();
    if ((UnityEngine.Object) endContainer != (UnityEngine.Object) null)
    {
      endContainer.Add(card);
      endContainer.TweenChildPositions();
    }
    cardUnlockSequence.gameObject.SetActive(false);
  }
}
