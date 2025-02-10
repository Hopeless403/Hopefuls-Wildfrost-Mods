// Decompiled with JetBrains decompiler
// Type: CardRotator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
[RequireComponent(typeof (Card))]
public class CardRotator : MonoBehaviour
{
  [SerializeField]
  [Required(null)]
  [OnValueChanged("DataChanged")]
  private CardData data;
  [SerializeField]
  private float rotateSpeed;
  [SerializeField]
  private Vector3 rotateAmount;
  [SerializeField]
  private bool startFlippedDown = true;
  private Entity entity;
  private Card card;
  private float internalRotateSpeed = 1f;
  private float t;

  private IEnumerator Start()
  {
    CardRotator cardRotator = this;
    cardRotator.entity = cardRotator.GetComponent<Entity>();
    cardRotator.entity.data = cardRotator.data;
    cardRotator.card = cardRotator.GetComponent<Card>();
    yield return (object) cardRotator.card.UpdateData(false);
    if (cardRotator.startFlippedDown)
    {
      cardRotator.entity.flipper.FlipDownInstant();
      cardRotator.internalRotateSpeed = 0.0f;
      cardRotator.transform.localEulerAngles = Vector3.zero;
    }
  }

  private void Update()
  {
    this.t += Time.deltaTime * this.rotateSpeed * this.internalRotateSpeed;
    this.transform.localEulerAngles = this.rotateAmount * Mathf.Sin(this.t);
  }

  private void DataChanged()
  {
    if (Application.isEditor)
      return;
    this.StartCoroutine(this.UpdateData(this.data));
  }

  private IEnumerator UpdateData(CardData data)
  {
    this.entity.data = data;
    yield return (object) this.entity.ClearStatuses();
    this.card.ClearStatusIcons();
    yield return (object) this.card.UpdateData(false);
  }

  [Button(null, EButtonEnableMode.Always)]
  private void Flip()
  {
    if (this.entity.flipper.flipped)
      this.StartCoroutine(this.FlipUpRoutine());
    else
      this.StartCoroutine(this.FlipDownRoutine());
  }

  private IEnumerator FlipUpRoutine()
  {
    CardRotator cardRotator = this;
    cardRotator.entity.flipper.FlipUp();
    float dur = cardRotator.entity.flipper.flipUpDurationRand.y;
    yield return (object) Sequences.Wait(dur / 2f);
    cardRotator.entity.wobbler.WobbleRandom();
    yield return (object) Sequences.Wait(dur / 2f);
    // ISSUE: reference to a compiler-generated method
    LeanTween.value(0.0f, 1f, 1f).setOnUpdate(new Action<float>(cardRotator.\u003CFlipUpRoutine\u003Eb__13_0));
  }

  private IEnumerator FlipDownRoutine()
  {
    CardRotator cardRotator = this;
    cardRotator.entity.flipper.FlipDown();
    float dur = cardRotator.entity.flipper.flipUpDurationRand.y;
    yield return (object) Sequences.Wait(dur / 2f);
    cardRotator.entity.wobbler.WobbleRandom();
    yield return (object) Sequences.Wait(dur / 2f);
    // ISSUE: reference to a compiler-generated method
    LeanTween.value(1f, 0.0f, 1f).setOnUpdate(new Action<float>(cardRotator.\u003CFlipDownRoutine\u003Eb__14_0));
  }
}
